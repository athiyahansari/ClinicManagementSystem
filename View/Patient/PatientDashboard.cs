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
using CMS.Model;

namespace CMS.View.Patient
{
    public partial class PatientDashboard : Form
    {
        private readonly int patientId;
        private readonly NotificationController notificationController;

        public PatientDashboard(int patientId)
        {
            InitializeComponent();
            notificationController = new NotificationController();

            // Form Load Event
            this.Load += PatientDashboard_Load;
        }

        private void PatientDashboard_Load(object sender, EventArgs e)
        {
            ShowNextAppointment();
            ShowLatestNotification();
        }

        private void ShowNextAppointment()
        {
            try
            {
                Appointment nextAppt = Appointmentcontroller.GetNextAppointmentForPatient(patientId);

                if (nextAppt != null)
                {
                    lblNotification.Text = $"Next Appointment:\n📅 {nextAppt.Date.ToShortDateString()} ⏰ {nextAppt.Time:hh\\:mm}\n👨‍⚕️ Dr. {nextAppt.DoctorName}";
                    lblNotification.Visible = true;
                }
                else
                {
                    lblNoNotif.Text = "🎉 No Upcoming Appointments!";
                    lblNoNotif.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load appointment: " + ex.Message);
            }
        }

        private void ShowLatestNotification()
        {
            try
            {

                string formattedText;
                Notification notif = notificationController.GetLatestNotificationForPatient(patientId, out formattedText);


                if (notif != null)
                {
                   
                    lblNotification.Text = "🔔 " + formattedText; ;

                    lblNotification.Visible = true;
                }
                else
                {
                    lblNoNotif.Text = "📭 No new notifications.";
                    lblNoNotif.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load notifications: " + ex.Message);
            }
        }
    }
}
