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



        //private void LoadDoctorProfile()
        //{
        //    DoctorProfile profile = controller.GetDoctorProfile(_doctorId);

        //    if (profile != null)
        //    {
        //        txtDescription.Text = profile.Description;
        //        txtSpeciality.Text = profile.Speciality;
        //        txtEmail.Text = profile.Email;
        //        txtContact.Text = profile.Contact;
        //    }
        //    else
        //    {
        //        MessageBox.Show("No profile found for this doctor.");
        //    }
        //}


        private void DocViewProfile_Load(object sender, EventArgs e)
        {
            DoctorProfile profile = controller.GetDoctorProfile(_doctorId);

            if (profile != null)
            {
                txtDescription.Text = profile.Description;
                txtSpeciality.Text = profile.Speciality;
                txtEmail.Text = profile.Email;
                txtContact.Text = profile.Contact;
            }
            else
            {
                MessageBox.Show("Doctor profile not found.");
            }
        }

        private void DocViewProfile_Load_1(object sender, EventArgs e)
        {

        }
    }
}
