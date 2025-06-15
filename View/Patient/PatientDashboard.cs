using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicManagementSystem.Views.Patients;
using CMS.Controller;
using CMS.Model;
using CMS.Utils;

namespace CMS.View.Patient
{
    public partial class PatientDashboard : Form
    {
        private readonly int patientId;
        private readonly NotificationController notificationController;

        public PatientDashboard(int patientId)
        {
            InitializeComponent();
            this.patientId = patientId;
            notificationController = new NotificationController();


            // Form Load Event
            this.Load += PatientDashboard_Load;
        }

        public PatientDashboard() : this(SessionManager.CurrentUserId) { }

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
                lblNotification.Visible = false;

                if (nextAppt != null)
                {
                    lblNotification.Text =
                        $"Next Appointment:\n📅 {nextAppt.Date.ToShortDateString()} ⏰ {nextAppt.Time:hh\\:mm}\n👨‍⚕️ Dr. {nextAppt.DoctorName}";
                    lblNotification.Visible = true;
                }
                else
                {
                    // If an error occurs, you might want to clear the label or show an error message there too
                    lblNotification.Text = "Error loading appointments.";
                    lblNotification.Visible = true;
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

                lblNotification.Visible = false;

                if (notif != null)
                {
                    lblNotification.Text = "🔔 " + formattedText;
                    lblNotification.Visible = true;
                }
                else
                {
                    lblNotification.Text = "📭 No new notifications.";
                    lblNotification.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load notifications: " + ex.Message);
                // If an error occurs, you might want to clear the label or show an error message there too
                lblNotification.Text = "Error loading notifications.";
                lblNotification.Visible = true;
            }
        }

        private void dash_newdoctors_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewPatient newPatient = new NewPatient();
            newPatient.Show();
            this.Hide();
        }

        private void dash_upcomingappointments_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Bookappointmentform bookappointmentform = new Bookappointmentform();
            bookappointmentform.Show();
            this.Hide();
        }

        private void dash_prescriptions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ViewPrescription viewPrescription = new ViewPrescription(patientId);
            viewPrescription.Show();
            this.Hide();
        }

        private void dash_medicalhistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ViewMedicalHistory viewMedicalHistory = new ViewMedicalHistory();
            viewMedicalHistory.Show();
            this.Hide();
        }

        private void navdoc_Click(object sender, EventArgs e)
        {
            ViewDoctors viewDoctors = new ViewDoctors();
            viewDoctors.Show();
            this.Hide();
        }

        private void navappointment_Click(object sender, EventArgs e)
        {
            Bookappointmentform bookappointmentform = new Bookappointmentform();
            bookappointmentform.Show();
            this.Hide();
        }

        private void navprescription_Click(object sender, EventArgs e)
        {
            ViewPrescription viewPrescription = new ViewPrescription(patientId);
            viewPrescription.Show();
            this.Hide();
        }

        private void navmedicalhistory_Click(object sender, EventArgs e)
        {
            ViewMedicalHistory viewMedicalHistory = new ViewMedicalHistory();
            viewMedicalHistory.Show();
            this.Hide();
        }

        private void navprofile_Click(object sender, EventArgs e)
        {
            Edit_Patient_Profile edit_Patient_Profile = new Edit_Patient_Profile();
            edit_Patient_Profile.Show();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
