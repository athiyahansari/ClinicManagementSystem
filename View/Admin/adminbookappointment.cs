using CMS.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace CMS.View.Admin
{
    public partial class adminbookappointment : Form
    {
        public adminbookappointment()
        {
            InitializeComponent();
            this.Load += adminbookappointment_Load;
        }

      

        private void dataGridAdminPatient_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                string columnName = dataGridAdminPatient.Columns[e.ColumnIndex].Name;
                int appointmentId = Convert.ToInt32(dataGridAdminPatient.Rows[e.RowIndex].Cells["AppointmentIDcolumn"].Value);

                var controller = new AdminPatientController();

                if (columnName == "ResheduleColumn")
                {
                    // Ask for new date
                    string dateInput = Interaction.InputBox("Enter new appointment date (yyyy-MM-dd):", "Reschedule Date", DateTime.Now.ToString("yyyy-MM-dd"));
                    if (!DateTime.TryParse(dateInput, out DateTime newDate))
                    {
                        MessageBox.Show("Invalid date format.");
                        return;
                    }

                    // Ask for new time
                    string timeInput = Interaction.InputBox("Enter new appointment time (HH:mm):", "Reschedule Time", "10:00");
                    if (!TimeSpan.TryParse(timeInput, out TimeSpan newTime))
                    {
                        MessageBox.Show("Invalid time format.");
                        return;
                    }

                    if (controller.RescheduleAppointment(appointmentId, newDate , newTime))
                    {
                        MessageBox.Show("Appointment rescheduled successfully.");
                        LoadAppointments();
                    }
                    else
                    {
                        MessageBox.Show("Failed to reschedule the appointment.");
                    }
                }
                else if (columnName == "CancelColumn")
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to cancel this appointment?", "Confirm Cancel", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        if (controller.CancelAppointment(appointmentId))
                        {
                            MessageBox.Show("Appointment status updated to 'Cancelled'.");
                            LoadAppointments();
                        }
                    }
                }
            }
        }
        
        private void LoadAppointments()
        {
            AdminPatientController controller = new AdminPatientController();
            var appointmentList = controller.GetAllAppointments();

            dataGridAdminPatient.Rows.Clear();

            foreach (var appt in appointmentList)
            {
                dataGridAdminPatient.Rows.Add(
                     appt.AppointmentID,
                     appt.PatientName,
                     appt.DoctorName,
                     appt.Date.ToString("yyyy-MM-dd"), 
                     appt.Time,                        
                     appt.Status
 );

            }
        }

        private void adminbookappointment_Load(object sender, EventArgs e)
        {
            LoadAppointments();
        }
    }
}
