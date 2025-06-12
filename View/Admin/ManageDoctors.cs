using CMS.Controller;
using CMS.Model;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace CMS.View.Admin
{
    public partial class ManageDoctors : Form
    {
        private readonly DoctorController ctrl = new DoctorController();
        private int selectedId = -1;

        public ManageDoctors()
        {
            InitializeComponent();
            LoadDoctors();
        }

        private void LoadDoctors()
        {
            doctorGridView.Rows.Clear();
            foreach (var d in ctrl.GetAllDoctors())
            {
                doctorGridView.Rows.Add(d.DoctorID, d.FullName, d.Speciality, d.Email, d.PhoneNo);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInputs(out Model.Doctor d))
            {
                ctrl.AddDoctor(d);
                MessageBox.Show("Doctor added!");
                ClearFields();
                LoadDoctors();
            }
        }

        private void ClearFields()
        {
            selectedId = -1;
            txtDocID.Clear();
            txtFullName.Clear();
            txtSpeciality.Clear();
            txtEmail.Clear();
            txtNumber.Clear();
        }

        private bool ValidateInputs(out Model.Doctor d)
        {
            d = null;
            string fullName = txtFullName.Text.Trim();
            string speciality = txtSpeciality.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtNumber.Text.Trim();

            // Full Name validation - only letters and spaces
            if (string.IsNullOrEmpty(fullName) || !Regex.IsMatch(fullName, @"^[a-zA-Z.\s]+$"))
            {
                MessageBox.Show("Full Name must contain only letters, spaces and periods.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            // Speciality validation - only letters and spaces
            if (string.IsNullOrEmpty(speciality) || !Regex.IsMatch(speciality, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Speciality must contain only letters and spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Email validation
            if (string.IsNullOrEmpty(email) || !Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Phone number validation - exactly 10 digits
            if (string.IsNullOrEmpty(phone) || !Regex.IsMatch(phone, @"^\d{10}$"))
            {
                MessageBox.Show("Phone number must be exactly 10 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // All checks passed, create doctor object
            d = new Model.Doctor
            {
                FullName = fullName,
                Speciality = speciality,
                Email = email,
                PhoneNo = phone,
                UserID = 1 // Replace with actual logged-in UserID if needed
            };

            return true;
        }

        private void btnClear_Click(object sender, EventArgs e) => ClearFields();
        private void btnBack_Click(object sender, EventArgs e) => this.Close();

        private void doctorGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var column = doctorGridView.Columns[e.ColumnIndex].Name;
            var row = doctorGridView.Rows[e.RowIndex];
            selectedId = Convert.ToInt32(row.Cells["doctorid"].Value);

            if (column == "DeleteColumn")
            {
                if (MessageBox.Show("Are you sure you want to delete this doctor?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ctrl.DeleteDoctor(selectedId);
                    MessageBox.Show("Doctor deleted.");
                    ClearFields();
                    LoadDoctors();
                }
            }
            else if (column == "UpdateColumn")
            {
                if (txtDocID.Text == selectedId.ToString())
                {
                    if (ValidateInputs(out Model.Doctor updatedDoctor))
                    {
                        updatedDoctor.DoctorID = selectedId;
                        ctrl.UpdateDoctor(updatedDoctor);
                        MessageBox.Show("Doctor updated successfully.");
                        ClearFields();
                        LoadDoctors();
                    }
                }
                else
                {
                    // Populate form fields for editing
                    txtDocID.Text = row.Cells["doctorid"].Value?.ToString();
                    txtFullName.Text = row.Cells["name"].Value?.ToString();
                    txtSpeciality.Text = row.Cells["docSpecialty"].Value?.ToString();
                    txtEmail.Text = row.Cells["emailNo"].Value?.ToString();
                    txtNumber.Text = row.Cells["phone"].Value?.ToString();
                    MessageBox.Show("Now edit the fields and click the same Update button again to apply changes.");
                }
            }
        }
    }
}
