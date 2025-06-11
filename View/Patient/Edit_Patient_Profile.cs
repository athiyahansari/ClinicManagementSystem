using System;
using System.Windows.Forms;
using CMS.Model;
using MySql.Data.MySqlClient;
using CMS.Utils;
using CMS.Controller;





namespace CMS.View.Patient
{
    public partial class Edit_Patient_Profile : Form
    {
        private PatientController _controller;

        public Edit_Patient_Profile()
        {
            InitializeComponent();
           // ✅ FIXED: pass the view
            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");
            cmbGender.Items.Add("Other");
            cmbGender.SelectedIndex = 0;
            _controller = new PatientController(this);



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

        public DateTime DateOfBirth
        {
            get { return DateTimePicker1.Value; }
            set { DateTimePicker1.Value = value; }
        }
        

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

        private void Edit_Patient_Profile_Load(object sender, EventArgs e)
        {
          
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
              
                FirstName = patient.FirstName;
                LastName = patient.LastName;
                DateOfBirth = patient.DateOfBirth;
               
                Email = patient.Email;
                Gender = patient.Gender;
            }
        }
    }
}


