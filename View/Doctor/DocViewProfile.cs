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
using CMS.View.Doctor;
using CMS.View.Patient;



namespace CMS.View.Doctor
{
    public partial class DocViewProfile : Form
    {
        private int _doctorId;
        private DoctorProfileController controller;

        public DocViewProfile(int doctorId) // constructor accepts doctor
        {
            InitializeComponent();
            controller = new DoctorProfileController();
            _doctorId = doctorId; // store the doctorId
            this.Load += DocViewProfile_Load;  // Step 3: hook up load event
        }

        private void DocViewProfile_Load(object sender, EventArgs e)
        {
            DoctorProfile profile = controller.GetDoctorProfile(_doctorId);

            if (profile != null)
            {
                txtDescription.Text = profile.Description;
                txtSpeciality.Text = profile.Speciality;
                txtEmail.Text = profile.Email;
                txtContact.Text = profile.Contact;

                // Load doctor name from the same profile object
                DocName.Text = !string.IsNullOrEmpty(profile.DoctorName)
                    ? profile.DoctorName
                    : "Name not found";
            }
            else
            {
                MessageBox.Show("Doctor profile not found.");
            }
        }


        private void DocViewProfile_Load_1(object sender, EventArgs e)
        {

        }

        private void DocName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)// my profile
        {
            DocViewProfile profileForm = new DocViewProfile(_doctorId);
            profileForm.Show();
            this.Hide(); // Hide the current form
        }



        private void button6_Click(object sender, EventArgs e) //view doctors code
        {
            //ViewDoctors viewDoctorsForm = new ViewDoctors();
            //viewDoctorsForm.Show();
            //this.Hide(); // Hide the current form
        }

        private void button5_Click(object sender, EventArgs e)//appointment schedule
        {
            AppointmentSchedule appointmentScheduleForm = new AppointmentSchedule();
            appointmentScheduleForm.Show();
            this.Hide(); // Hide the current form
        }

        private void button4_Click(object sender, EventArgs e) //prescription
        {
            CreatePrescription prescriptionForm = new CreatePrescription();
            prescriptionForm.Show();
            this.Hide(); // Hide the current form
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide(); // Hide the current form
        }
    }
}
