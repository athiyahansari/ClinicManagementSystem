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
        
        private PatientController _controller; // Controller instance for this form

        // Default constructor for adding a new patient (no initial patient object)
        public Edit_Patient_Profile()
        {
            InitializeComponent();
            _controller = new PatientController(this); // Pass THIS form instance to the controller
            ClearFormFields(); // Clear fields for a new entry
        }

        // Constructor for editing an existing patient
        public Edit_Patient_Profile(Patients patient)
        {
            InitializeComponent();
            _controller = new PatientController(this, patient); // Pass THIS form instance AND the patient
            // The controller's LoadInitialPatientProfile will automatically call LoadPatientData to populate fields.
        }

        // --- Properties to expose form control values to the controller ---
        // These MUST correspond to actual UI controls on your form.

        public string PatientId => txtPatientId.Text; // Assuming a TextBox named txtPatientId
        public string FirstName => txtFirstName.Text; // Assuming a TextBox named txtFirstName
        public string LastName => txtLastName.Text;   // Assuming a TextBox named txtLastName
        public string Email => txtEmail.Text;         // Assuming a TextBox named txtEmail
        public DateTime PatientDateOfBirth => dtpDateOfBirth.Value; // Assuming a DateTimePicker named dtpDateOfBirth
        public string PatientPhoneNumber => txtPhoneNumber.Text; // Assuming a TextBox named txtPhoneNumber
        public string Gender
        {
            get
            {
                // Adjust this based on your actual gender control (e.g., ComboBox, RadioButtons)
                // If using a ComboBox:
                return cmbGender.SelectedItem?.ToString();
                // If using RadioButtons (e.g., radioBtnMale, radioBtnFemale):
                // if (radioBtnMale.Checked) return "Male";
                // else if (radioBtnFemale.Checked) return "Female";
                // return string.Empty; // Or a default value
            }
        }

        public void Edit_Patient_Profile_Load(object sender, EventArgs e)
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
            this.Hide();  // Hide the current form
            Bookappointmentform profileForm = new Bookappointmentform();
            profileForm.ShowDialog();
            this.Show(); // Show again after profile closes
        }

        // Method to display messages to the user (e.g., validation errors, success)
        

        

        // Method to load initial data into the form (called by controller)
        public void LoadPatientData(Patients patient)
        {
            if (patient != null)
            {
                txtPatientId.Text = patient.PatientId;
                txtFirstName.Text = patient.FirstName;
                txtLastName.Text = patient.LastName;
                txtEmail.Text = patient.Email;
                dtpDateOfBirth.Value = patient.DateOfBirth; // Assign the date
                txtPhoneNumber.Text = patient.PhoneNumber;

                // Set the gender control based on your UI
                if (cmbGender.Items.Contains(patient.Gender)) // Assuming ComboBox
                {
                    cmbGender.SelectedItem = patient.Gender;
                }
                // If using RadioButtons:
                // if (patient.Gender == "Male") radioBtnMale.Checked = true;
                // else if (patient.Gender == "Female") radioBtnFemale.Checked = true;
            }
            else
            {
                ClearFormFields(); // Clear if no patient data
            }
        }
        // Method to display messages (called by controller)
        public void DisplayMessage(string message, string title, MessageBoxIcon icon)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, icon);
        }

        // Method to close the form (called by controller)
        public void CloseForm()
        {
            this.DialogResult = DialogResult.OK; // Indicate successful operation
            this.Close();
        }
        private void ClearFormFields()
        {
            txtPatientId.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            dtpDateOfBirth.Value = DateTime.Today; // Reset to today or a default
            txtPhoneNumber.Text = "";
            if (cmbGender.Items.Count > 0)
            {
                cmbGender.SelectedIndex = -1; // Clear selection for ComboBox
            }
            // Reset other controls as needed
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


