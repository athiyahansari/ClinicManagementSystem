using CMS.Controller;
using CMS.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using CMS.View.Admin;

namespace CMS.View.Admin
{
    // Admin Report Form - responsible for UI interactions and triggering controller methods
    public partial class Reportadmin : Form
    {
        // Instantiate the controller to separate logic from UI
        private readonly AdminReportController controller = new AdminReportController();

        public Reportadmin()
        {
            InitializeComponent();
        }

        private void Reportadmin_Load(object sender, EventArgs e)
        {
            LoadDoctors();             // Populate doctor combo box
            SetupDataGridColumns();    // Link model properties to DataGridView columns
        }

        // Configure DataGridView to use specific property names from the AdminReport model
        private void SetupDataGridColumns()
        {
            dataGriddoctorshedule.AutoGenerateColumns = false;

            // Map model properties to grid columns
            patientcolumnshedule.DataPropertyName = "PatientName";
            appointmentdatecolumnshedule.DataPropertyName = "Date";
            appointmenttimecolumnshedule.DataPropertyName = "TimeFormatted";
            statuscolumnshedule.DataPropertyName = "Status";
        }

        // Load list of doctors from the database into the ComboBox
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

                // Handle empty result
                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("No doctors found.");
                    return;
                }

                // Bind data to combo box
                combodoctorshedule.DataSource = table;
                combodoctorshedule.DisplayMember = "full_name";
                combodoctorshedule.ValueMember = "doctor_id";
                combodoctorshedule.SelectedIndex = -1; // Reset selection
            }
        }

        // Generate button click handler for Doctor Schedule Report
        private void generateDoctorShedule_Click(object sender, EventArgs e)
        {
            // Check if doctor is selected
            if (combodoctorshedule.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a doctor.");
                return;
            }

            // Get selected doctor and date range
            int doctorId = Convert.ToInt32(combodoctorshedule.SelectedValue);
            DateTime from = doctorsheduledatefrom.Value.Date;
            DateTime to = doctorsheduledateto.Value.Date;

            string error;

            // Call controller to get data with validation
            var reports = controller.GetDoctorScheduleReport(doctorId, from, to, out error);

            // Show error or bind results
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                dataGriddoctorshedule.DataSource = null;
                return;
            }

            // Bind result to grid
            dataGriddoctorshedule.DataSource = reports;
        }

        // Generate button click handler for Patient Trends Report
        private void generatepatienttrendsbtn_Click(object sender, EventArgs e)
        {
            DateTime from = patienttrenddatefrom.Value.Date;
            DateTime to = patienttrenddateto.Value.Date;

            string error;

            // Fetch trends from controller with date validation
            var trends = controller.GetPatientTrends(from, to, out error);

            // Show error or bind results
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                dataGridViewpatienttrend.DataSource = null;
                return;
            }

            // Map model properties to grid columns
            dataGridViewpatienttrend.AutoGenerateColumns = false;
            PatientNameColumn.DataPropertyName = "PatientName";
            Totalappointmentscolumn.DataPropertyName = "TotalAppointments";
            Lastappointmentcolumn.DataPropertyName = "LastAppointmentDate";

            // Bind trend data to grid
            dataGridViewpatienttrend.DataSource = trends;
        }

        private void navdocbtn_Click(object sender, EventArgs e)
        {
            ManageDoctors manageDoctorForm = new ManageDoctors();

            // Show the ManageDoctor form
            manageDoctorForm.Show();

            // Optionally hide the current Reportadmin form
            this.Hide();

        }

        private void navappointmentbtn_Click(object sender, EventArgs e)
        {
            adminbookappointment appointmentForm = new adminbookappointment();

            // Show the AdminBookAppointment form
            appointmentForm.Show();

            // Optionally hide the current Reportadmin form
            this.Hide();

        }

        private void navprofilebtn_Click(object sender, EventArgs e)
        {
            AdminDashboard dashboardForm = new AdminDashboard();

            // Show the AdminDashboard form
            dashboardForm.Show();

            // Optionally hide the current Reportadmin form
            this.Hide();

        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            //LoginForm loginForm = new LoginForm();

            //// Show the login form
            //loginForm.Show();

            //// Close or hide the current form (e.g., Reportadmin)
            //this.Close(); 
        }
    }
}
