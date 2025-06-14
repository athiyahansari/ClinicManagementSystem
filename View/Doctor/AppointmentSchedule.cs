using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CMS.Controller;

namespace CMS.View.Doctor
{
    public partial class AppointmentSchedule : Form
    {
        private int doctorId;
        private DocAppointmentController controller;

        public AppointmentSchedule() : this(1) { } // default for now

        public AppointmentSchedule(int docId)
        {
            InitializeComponent();
            doctorId = docId;
            controller = new DocAppointmentController();
        }

        private void AppointmentSchedule_Load(object sender, EventArgs e)
        {
            LoadAppointments();
        }

        // Load the appointment data into the DataGridView
        private void LoadAppointments()
        {
            try
            {
                var appointments = controller.GetAppointmentsByDoctorId(doctorId);
                dataGridView1.Rows.Clear();

                foreach (var appt in appointments)
                {
                    dataGridView1.Rows.Add(
                        appt.AppointmentId,
                        appt.PatientName,
                        appt.Date.ToShortDateString(),
                        appt.Time.ToString(@"hh\:mm"),
                        appt.Status,
                        appt.Consultation, // Displaying notes as "Details"
                        "Cancel"
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load appointments: " + ex.Message);
            }
        }

        // Handle the Cancel button click in the DataGridView
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "Cancel")
            {
                int appointmentId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["AppointmentId"].Value);
                string status = dataGridView1.Rows[e.RowIndex].Cells["Status"].Value.ToString();

                if (status == "Cancelled")
                {
                    MessageBox.Show("This appointment is already cancelled.");
                    return;
                }

                var confirm = MessageBox.Show("Are you sure you want to cancel this appointment?", "Confirm Cancel", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    bool success = controller.CancelAppointment(appointmentId);
                    if (success)
                    {
                        MessageBox.Show("Appointment cancelled successfully.");
                        LoadAppointments(); // Refresh the grid
                    }
                    else
                    {
                        MessageBox.Show("Failed to cancel the appointment.");
                    }
                }

            }
        }

        // Side nav 'MyAppointments' button reload
        private void navappointment_Click(object sender, EventArgs e)
        {
            ReloadAppointments();
        }
        // Allows external forms or buttons (like the sidebar) to trigger a data refresh in this form
        public void ReloadAppointments()
        {
            LoadAppointments(); 
        }

    }
}
