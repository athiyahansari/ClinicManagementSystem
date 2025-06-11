using CMS.Controller;
using CMS.Model;
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

namespace CMS.View.Admin
{
    public partial class Reportadmin : Form
    {
        public Reportadmin()
        {
            InitializeComponent();
        }

        private void Reportadmin_Load(object sender, EventArgs e)
        {
            LoadDoctors();
            SetupDataGridColumns(); // Assign model properties to each designer column
        }

        private void SetupDataGridColumns()
        {
            dataGriddoctorshedule.AutoGenerateColumns = false;

            // Bind your 4 designer-created columns to the correct model properties
            patientcolumnshedule.DataPropertyName = "PatientName";
            appointmentdatecolumnshedule.DataPropertyName = "Date";
            appointmenttimecolumnshedule.DataPropertyName = "TimeFormatted";
            statuscolumnshedule.DataPropertyName = "Status";
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

                combodoctorshedule.DataSource = table;
                combodoctorshedule.DisplayMember = "full_name";
                combodoctorshedule.ValueMember = "doctor_id";
                combodoctorshedule.SelectedIndex = -1;
            }
        }

        private void generateDoctorShedule_Click(object sender, EventArgs e)
        {
            GenerateDoctorScheduleReport();
        }

        private void GenerateDoctorScheduleReport()
        {
            if (combodoctorshedule.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a doctor.");
                return;
            }

            if (doctorsheduledatefrom.Value > doctorsheduledateto.Value)
            {
                MessageBox.Show("From date cannot be after To date.");
                return;
            }

            int doctorId = Convert.ToInt32(combodoctorshedule.SelectedValue);
            DateTime fromDate = doctorsheduledatefrom.Value.Date;
            DateTime toDate = doctorsheduledateto.Value.Date;

            AdminReportController controller = new AdminReportController();
            List<AdminReport> reports = controller.GetAppointmentsByDoctorAndDate(doctorId, fromDate, toDate);

            if (reports.Count == 0)
            {
                MessageBox.Show("No appointments found for the selected doctor and date range.");
                dataGriddoctorshedule.DataSource = null;
                return;
            }

            dataGriddoctorshedule.DataSource = null;
            dataGriddoctorshedule.DataSource = reports;
        }

        private void patienttrenddatefrom_ValueChanged(object sender, EventArgs e)
        {

        }

        private void patienttrenddateto_ValueChanged(object sender, EventArgs e)
        {

        }

        private void generatepatienttrendsbtn_Click(object sender, EventArgs e)
        {
            GeneratePatientTrendReport();
        }

        private void GeneratePatientTrendReport()
        {
            DateTime fromDate = patienttrenddatefrom.Value.Date;
            DateTime toDate = patienttrenddateto.Value.Date;

            if (fromDate > toDate)
            {
                MessageBox.Show("From date cannot be after To date.");
                return;
            }

            AdminReportController controller = new AdminReportController();
            List<PatientTrend> trends = controller.GetPatientTrendsByDateRange(fromDate, toDate);

            if (trends.Count == 0)
            {
                MessageBox.Show("No trends found for the selected date range.");
                dataGridViewpatienttrend.DataSource = null;
                return;
            }

            // Map designer-added columns to the model (once ideally)
            dataGridViewpatienttrend.AutoGenerateColumns = false;
            PatientNameColumn.DataPropertyName = "PatientName";
            Totalappointmentscolumn.DataPropertyName = "TotalAppointments";
            Lastappointmentcolumn.DataPropertyName = "LastAppointmentDate";

            dataGridViewpatienttrend.DataSource = null;
            dataGridViewpatienttrend.DataSource = trends;
        }

    }
}

