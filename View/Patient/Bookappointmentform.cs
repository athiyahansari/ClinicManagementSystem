using CMS.Controller; 
using CMS.Model;
using CMS.Utils; // Replace with actual namespace
using CMS.View; // or whatever the correct namespace is
using CMS.View.Doctor;
using CMS.View.Patient;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CMS
{
    public partial class Bookappointmentform : Form
    {
        private int loggedInPatientId = 2;

        // Controller instance to handle database operations related to appointments
        Appointmentcontroller repo = new Appointmentcontroller();

        // Holds the appointment ID when rescheduling (null means new booking)
        private int? reschedulingAppointmentId = null;

        // Constructor - initialize the form and attach event handlers
        public Bookappointmentform()
        {
            InitializeComponent();

            // Event fired when form loads
            this.Load += Bookappointmentform_Load;

            // Event fired when a cell is clicked in the appointments data grid
            appointmentdatagrid.CellClick += appointmentdatagrid_CellClick;

            // Event fired when a cell needs formatting (to format time display)
            appointmentdatagrid.CellFormatting += appointmentdatagrid_CellFormatting;
        }

        // Form Load event handler - load initial data for the form
        private void Bookappointmentform_Load(object sender, EventArgs e)
        {
            LoadAppointments(); // Load appointments of the logged-in patient into the grid
            LoadDoctors(); // Load all doctors into the doctor selection ComboBox
            PopulateTimeSlots(); // Load available time slots into the time ComboBox
        }

        // Load available time slots into timepickform ComboBox
        private void PopulateTimeSlots()
        {
            timepickform.Items.Clear();
            var slots = repo.GenerateTimeSlots(); // Get predefined time slots from controller

            foreach (var slot in slots)
            {
                timepickform.Items.Add(slot); // Add each time slot to ComboBox
            }

            // Make ComboBox readonly (user can't type arbitrary text)
            timepickform.DropDownStyle = ComboBoxStyle.DropDownList;

            // Select the first time slot by default, if available
            if (timepickform.Items.Count > 0)
                timepickform.SelectedIndex = 0;
        }

        // Load all doctors into the doctor selection ComboBox
        private void LoadDoctors()
        {
            var table = repo.GetAllDoctors(); // Get doctors as DataTable from controller

            if (table.Rows.Count == 0)
            {
                MessageBox.Show("No doctors found.");
                return;
            }

            // Bind DataTable to ComboBox for doctor selection
            combodoctor.DataSource = table;
            combodoctor.DisplayMember = "full_name"; // Display doctor names
            combodoctor.ValueMember = "doctor_id"; // Store doctor IDs as value
            combodoctor.SelectedIndex = -1; // No doctor selected initially
        }

        // Load the logged-in patient's appointments into the DataGridView
        private void LoadAppointments()
        {
            var list = repo.GetAppointmentsForPatient(loggedInPatientId); // Fetch appointments

            appointmentdatagrid.AutoGenerateColumns = false; // Use predefined columns

            // Map model properties to respective DataGridView columns
            appointmentdatagrid.Columns["DoctorNameColumn"].DataPropertyName = "DoctorName";
            appointmentdatagrid.Columns["TimeColumn"].DataPropertyName = "Time";
            appointmentdatagrid.Columns["DateColumn"].DataPropertyName = "Date";
            appointmentdatagrid.Columns["ConsultaionColumn"].DataPropertyName = "Consultation";
            appointmentdatagrid.Columns["StatusColumn"].DataPropertyName = "Status";

            appointmentdatagrid.DataSource = list; // Bind appointments list to the grid
            appointmentdatagrid.ReadOnly = true; // Make grid readonly to prevent direct editing
        }

        // Click event handler for the book/reschedule button
        private void bookappobtn_Click(object sender, EventArgs e)
        {
            // Call controller method to either book or reschedule an appointment,
            // depending on whether reschedulingAppointmentId has a value
            var result = repo.TryBookOrRescheduleAppointment(
                patientId: loggedInPatientId,
                doctorId: Convert.ToInt32(combodoctor.SelectedValue),
                date: dateTimePickerform.Value,
                timeText: timepickform.Text,
                notes: notestxt.Text,
                rescheduleId: reschedulingAppointmentId);

            // Show the result message (success or error)
            MessageBox.Show(result.message);

            if (result.success)
            {
                LoadAppointments(); // Refresh the appointments grid to reflect changes
                ClearFormFields(); // Reset form inputs for next operation
            }
        }

        // Handle clicks on cells inside the appointments grid (cancel/reschedule buttons)
        private void appointmentdatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore header clicks or invalid indexes
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            // Get the selected appointment object from the row clicked
            var selected = appointmentdatagrid.Rows[e.RowIndex].DataBoundItem as Appointment;
            if (selected == null) return;

            // Prevent modification of past appointments
            if (selected.Date < DateTime.Today)
            {
                MessageBox.Show("You cannot modify past appointments.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int appointmentId = selected.AppointmentId;
            string columnName = appointmentdatagrid.Columns[e.ColumnIndex].Name;

            // If Cancel button clicked
            if (columnName == "CancelColumn")
            {
                var confirm = MessageBox.Show("Do you want to cancel this appointment?", "Confirm", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    repo.CancelAppointmentWithConfirmation(appointmentId); // Cancel via controller
                    LoadAppointments(); // Reload appointments grid
                    MessageBox.Show("Cancelled successfully.");
                }
            }
            // If Reschedule button clicked
            else if (columnName == "ResheduleColumn")
            {
                var confirm = MessageBox.Show("Do you want to reschedule this appointment?", "Confirm", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    // Load selected appointment data into the form fields for editing
                    var resched = repo.PrepareAppointmentForReschedule(selected);
                    combodoctor.SelectedValue = resched.DoctorId;
                    dateTimePickerform.Value = resched.Date;
                    timepickform.SelectedItem = resched.Time.ToString(@"hh\:mm");
                    notestxt.Text = resched.Consultation;

                    // Track the appointment ID being rescheduled
                    reschedulingAppointmentId = resched.AppointmentId;

                    // Change button text to indicate rescheduling mode
                    bookappobtn.Text = "Reschedule Appointment";
                }
            }
        }

        // Format the display of the Time column in the DataGridView
        private void appointmentdatagrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (appointmentdatagrid.Columns[e.ColumnIndex].Name == "TimeColumn")
            {
                if (e.Value is TimeSpan time)
                {
                    e.Value = time.ToString(@"hh\:mm"); // Format TimeSpan as HH:mm
                    e.FormattingApplied = true; // Mark formatting as done
                }
            }
        }

        // Clear form input fields and reset state after booking/rescheduling
        private void ClearFormFields()
        {
            combodoctor.SelectedIndex = -1; // Deselect doctor
            if (timepickform.Items.Count > 0)
                timepickform.SelectedIndex = 0; // Reset time slot selection to first item

            dateTimePickerform.Value = DateTime.Today; // Reset date picker to today
            notestxt.Clear(); // Clear consultation notes

            reschedulingAppointmentId = null; // Reset reschedule mode
            bookappobtn.Text = "Book Appointment"; // Reset button text
        }


        private void doctorbtn_Click(object sender, EventArgs e)
        {
            //ViewDoctor viewDoctorForm = new ViewDoctor();
            //viewDoctorForm.Show();

            //// Hide the current form
            //this.Hide();

        }

        private void prescrbtn_Click(object sender, EventArgs e)
        {
            //ViewPrescription prescriptionForm = new ViewPrescription(); // create instance
            //prescriptionForm.Show();
            //this.Hide(); 

        }

        private void historybtn_Click(object sender, EventArgs e)
        {
            //ViewMedicalHistory historyForm = new ViewMedicalHistory();
            //historyForm.Show(); 
            //this.Hide(); 

        }

        private void profilebtn_Click(object sender, EventArgs e)
        {
            //PatientDashboard dashboardForm = new PatientDashboard(); 
            //dashboardForm.Show(); 
            //this.Hide();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
          //LoginForm loginForm = new LoginForm();
          //  loginForm.Show();
          //  this.Close(); 
        }


    }
}

