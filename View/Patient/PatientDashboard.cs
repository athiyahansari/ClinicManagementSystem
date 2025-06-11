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
        private int currentPatientId; // This will be passed in when the form is created

        public PatientDashboard(int patientId)
        {
            InitializeComponent();
            currentPatientId = patientId;

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
                Appointment nextAppt = Appointmentcontroller.GetNextAppointmentForPatient(currentPatientId);

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
                Notification notif = NotificationController.GetLatestUnreadNotificationForPatient(currentPatientId);

                if (notif != null)
                {
                    //lblNotification.Text = $"🔔 {notif.Message}";
                    string sentence = notif.Message;
                    char separator = ' '; // Space character
                    string[] words = sentence.Split(separator);
                    int newlineum = 0;
                    string message = "";
                    foreach (string word in words)
                    {
                        message += word + " ";
                        newlineum++;
                        if (newlineum % 5 == 0) // Add a newline every 10 words
                        {
                            message += "\n";
                        }
                    }
                    lblNotification.Text = $"🔔 {message}";

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
