using System;
using System.Windows.Forms;
using CMS.Model;
using MySql.Data.MySqlClient;
using CMS.Utils;
using CMS.Controller;
using CMS.View.Admin;





namespace CMS.View.Patient
{
    public partial class Edit_Patient_Profile : Form
    {
        private PatientController _controller;
        public Edit_Patient_Profile()
        {
            InitializeComponent();
            _controller = new PatientController(); // ✅ FIXED: pass the view

            this.Load += Edit_Patient_Profile_Load; 

        }
        // Properties to expose UI control values to the Controller


        public string FirstName
        {
            get { return txtFirstName.Text; }
            set { txtFirstName.Text = value; }
        }

        public string LastName
        {
            get { return txtLastName.Text; }
            set { txtLastName.Text = value; }
        }
        public DateTime PatientDateOfBirth
        {
            get { return txtDateOfBirth.Value; }
        }


        public string PatientId { get; set; } // ✅ needed for updating the same row
        private Patients _patientToEdit;




        public string PatientPhoneNumber
        {
            get { return txtPhoneNumber.Text; }
            set { txtPhoneNumber.Text = value; }
        }

        public string Email
        {
            get { return txtEmail.Text; }
            set { txtEmail.Text = value; }
        }

        public string Gender
        {
            get { return cmbGender.SelectedItem?.ToString(); }
            set { cmbGender.SelectedItem = value; }
        }

        //public Edit_Patient_Profile()
        //{
        //}

        public Edit_Patient_Profile(Patients patientToEdit)
        {
            InitializeComponent();

            _controller = new PatientController();



            _patientToEdit = patientToEdit; // save patient for later
        }


        public void Edit_Patient_Profile_Load(object sender, EventArgs e)
        {
            var patient = _controller.GetPatientByUserId(SessionManager.CurrentUserId);
            _controller.LoadInitialPatientProfile(patient);

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            _controller.SavePatientProfile();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _controller.CancelEdit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();  // Hide the current form
            Bookappointmentform profileForm = new Bookappointmentform();
            profileForm.ShowDialog();
            this.Show(); // Show again after profile closes
        }

        // Method to display messages to the user (e.g., validation errors, success)
        public void DisplayMessage(string message, string title, MessageBoxIcon icon)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, icon);
        }

        // Method to close the form
        public void CloseForm()
        {
            this.Close();
        }

        // Method to load initial data into the form (called by controller)
        public void LoadPatientData(Patients patient)
        {
            if (patient != null)
            {
                PatientId = patient.PatientId;
                FirstName = patient.FirstName;
                LastName = patient.LastName;
                Email = patient.Email;
                Gender = patient.Gender;
                PatientPhoneNumber = patient.PhoneNumber;

                // ✅ One solid guard against invalid DOB
                if (patient.DateOfBirth > txtDateOfBirth.MinDate &&
                    patient.DateOfBirth < txtDateOfBirth.MaxDate)
                {
                    txtDateOfBirth.Value = patient.DateOfBirth;
                }
                else
                {
                    txtDateOfBirth.Value = DateTime.Today; // fallback if null/invalid
                }
            }
        }

        private void txtDateOfBirth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();  // Hide the current form
            Edit_Patient_Profile profileForm = new Edit_Patient_Profile();
            profileForm.ShowDialog();
            this.Show(); // Show again after profile closes

        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            this.Hide();  // Hide the current form
            ViewDoctors profileForm = new ViewDoctors();
            profileForm.ShowDialog();
            this.Show(); // Show again after profile closes
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            this.Hide();  // Hide the current form
            Edit_Patient_Profile profileForm = new Edit_Patient_Profile();
            profileForm.ShowDialog();
            this.Show(); // Show again after profile closes

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();  // Hide the current form
            LoginForm profileForm = new LoginForm();
            profileForm.ShowDialog();
            this.Show(); // Show again after profile closes
        }
    }
}


