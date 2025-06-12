using CMS.Model;
using CMS.Utils; // Replace with actual namespace
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
using CMS.Controller; // Replace with actual namespace for Appointmentcontroller

//using CMS.View.Doctor; // Replace with actual namespace for ViewDoctor

namespace CMS
{
    public partial class Bookappointmentform : Form
    {
        private int loggedInPatientId = 1; // Simulate logged-in user
        Appointmentcontroller repo = new Appointmentcontroller();
        //repo variable is an instance of Appointmentcontroller class which handles all database related operations
        public Bookappointmentform()
        {
            InitializeComponent();
            this.Load += Bookappointmentform_Load; //run when the form loads
            appointmentdatagrid.CellClick += appointmentdatagrid_CellClick; // Handle cell clicks for reschedule/cancel
            appointmentdatagrid.CellFormatting += appointmentdatagrid_CellFormatting;

        }

        private void Bookappointmentform_Load(object sender, EventArgs e)
        {
            LoadAppointments();
            LoadDoctors();
            PopulateTimeSlots(); // Populate time slots in the dropdown
        }
        private void PopulateTimeSlots()
        {
            // Clear existing items
            timepickform.Items.Clear();

            // Generate time slots
            var slots = repo.GenerateTimeSlots();

            // Add slots to ComboBox
            foreach (var slot in slots)
            {
                timepickform.Items.Add(slot);
            }

            // Set ComboBox to DropDownList to prevent manual editing
            timepickform.DropDownStyle = ComboBoxStyle.DropDownList;

            // Select the first slot by default if available
            if (timepickform.Items.Count > 0)
            {
                timepickform.SelectedIndex = 0;
            }
        }

        private void LoadDoctors()
        {
            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString))
            {
                conn.Open();
                string query = "SELECT doctor_id, full_name FROM doctors";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("No doctors found.");
                    return;
                }

                combodoctor.DataSource = table;
                combodoctor.DisplayMember = "full_name";
                combodoctor.ValueMember = "doctor_id";
                combodoctor.SelectedIndex = -1;
            }
        }

        private void LoadAppointments()
        {
            var list = repo.GetAppointmentsByPatientId(loggedInPatientId);

            appointmentdatagrid.AutoGenerateColumns = false;

            appointmentdatagrid.Columns["DoctorNameColumn"].DataPropertyName = "DoctorName";
            appointmentdatagrid.Columns["TimeColumn"].DataPropertyName = "Time";
            appointmentdatagrid.Columns["DateColumn"].DataPropertyName = "Date";
            appointmentdatagrid.Columns["ConsultaionColumn"].DataPropertyName = "Consultation"; // spelling as in designer
            appointmentdatagrid.Columns["StatusColumn"].DataPropertyName = "Status";
            // You can map ResheduleColumn and CancelColumn if needed

            appointmentdatagrid.DataSource = list;
            appointmentdatagrid.ReadOnly = true;

        }


        private void bookappobtn_Click(object sender, EventArgs e)
        {
            string validationError = repo.ValidateAppointmentInput(
                Convert.ToInt32(combodoctor.SelectedValue),
                dateTimePickerform.Value,
                timepickform.Text,
                notestxt.Text);

            if (validationError != null)
            {
                MessageBox.Show(validationError);
                return;
            }

            Appointment newAppt = new Appointment
            {
                PatientId = loggedInPatientId,
                DoctorId = Convert.ToInt32(combodoctor.SelectedValue),
                Date = dateTimePickerform.Value.Date,
                Time = TimeSpan.Parse(timepickform.Text),
                Consultation = notestxt.Text,
            };

            try
            {
                repo.BookAppointment(newAppt); // Save to database
                MessageBox.Show("Appointment booked!");
                LoadAppointments(); // Refresh grid
            }
            catch (MySql.Data.MySqlClient.MySqlException ex) when (ex.Number == 1062) // Duplicate entry error
            {
                MessageBox.Show("This appointment slot is already booked. Please select another.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }
        }


        private void appointmentdatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            var selectedAppointment = appointmentdatagrid.Rows[e.RowIndex].DataBoundItem as Appointment;
            if (selectedAppointment == null)
                return;

            int appointmentId = selectedAppointment.AppointmentId;
            string columnName = appointmentdatagrid.Columns[e.ColumnIndex].Name;

            if (columnName == "CancelColumn")
            {
                var confirm = MessageBox.Show("Do you want to cancel this appointment?", "Confirm Cancel", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    repo.CancelAppointment(appointmentId);
                    LoadAppointments(); // Refresh the grid
                    MessageBox.Show("Appointment cancelled.");
                }
            }
            else if (columnName == "ResheduleColumn")
            {
                var confirm = MessageBox.Show("Do you want to reschedule this appointment?", "Confirm Reschedule", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    // Ask for new date
                    string newDateInput = Microsoft.VisualBasic.Interaction.InputBox("Enter new date (yyyy-MM-dd):", "Reschedule Date", DateTime.Today.ToString("yyyy-MM-dd"));
                    if (!DateTime.TryParse(newDateInput, out DateTime newDate))
                    {
                        MessageBox.Show("Invalid date format. Please use yyyy-MM-dd.");
                        return;
                    }

                    // Ask for new time
                    string newTimeString = Microsoft.VisualBasic.Interaction.InputBox("Enter new time (HH:mm):", "Reschedule Time", "10:00");
                    if (!TimeSpan.TryParse(newTimeString, out TimeSpan newTime))
                    {
                        MessageBox.Show("Invalid time format. Please enter time as HH:mm.");
                        return;
                    }

                    // Perform reschedule
                    repo.RescheduleAppointment(appointmentId, newDate, newTime);
                    MessageBox.Show("Appointment rescheduled.");
                    LoadAppointments(); // Refresh the grid
                }
            }
        }

        private void appointmentdatagrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            {
                if (appointmentdatagrid.Columns[e.ColumnIndex].Name == "TimeColumn")
                {
                    if (e.Value is TimeSpan time)
                    {
                        e.Value = time.ToString(@"hh\:mm"); // Format as HH:mm:ss
                        e.FormattingApplied = true;
                    }
                }
            }
        }

        private void appointmentbtn_Click(object sender, EventArgs e)
        {

            Bookappointmentform apptForm = new Bookappointmentform(); //loggedinpatientID should be passed if needed
            apptForm.Show();
            this.Hide();
        }

      
    }
}

