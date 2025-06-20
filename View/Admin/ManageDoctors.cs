﻿using CMS.Controller;
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
            AttachNavButtonEvents(); // Attach button click events at runtime
        }

        private void LoadDoctors()
        {
            doctorGridView.Rows.Clear();
            foreach (var d in ctrl.GetAllDoctors())
            {
                doctorGridView.Rows.Add(d.DoctorID, $"{d.FirstName} {d.LastName}".Trim(), d.Speciality, d.Email, d.PhoneNumber);
            }
        }

        // Add New Doctor Button
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

        // Validations for the fields
        private bool ValidateInputs(out Model.Doctor d)
        {
            d = null;
            string fullName = txtFullName.Text.Trim();
            string speciality = txtSpeciality.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtNumber.Text.Trim();

            if (string.IsNullOrEmpty(fullName) || !Regex.IsMatch(fullName, @"^[a-zA-Z.\s]+$"))
            {
                MessageBox.Show("Full Name must contain only letters, spaces, and periods.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            var nameParts = fullName.Split(new[] { ' ' }, 2, StringSplitOptions.RemoveEmptyEntries);
            string firstName = nameParts.Length > 0 ? nameParts[0] : "";
            string lastName = nameParts.Length > 1 ? nameParts[1] : "";

            if (string.IsNullOrEmpty(firstName))
            {
                MessageBox.Show("Please provide at least a first name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(speciality) || !Regex.IsMatch(speciality, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Speciality must contain only letters and spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(email) || !Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(phone) || !Regex.IsMatch(phone, @"^\d{10}$"))
            {
                MessageBox.Show("Phone number must be exactly 10 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            d = new Model.Doctor
            {
                FirstName = firstName,
                LastName = lastName,
                Speciality = speciality,
                Email = email,
                PhoneNumber = phone,
                UserID = 1 // Example: set appropriate user ID
            };

            if (selectedId != -1)
                d.DoctorID = selectedId;

            return true;
        }

        // Updating and Deleting the information
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
                    txtDocID.Text = row.Cells["doctorid"].Value?.ToString();
                    txtFullName.Text = row.Cells["name"].Value?.ToString();
                    txtSpeciality.Text = row.Cells["docSpecialty"].Value?.ToString();
                    txtEmail.Text = row.Cells["emailNo"].Value?.ToString();
                    txtNumber.Text = row.Cells["phone"].Value?.ToString();
                    MessageBox.Show("Now edit the fields and click the same Update button again to apply changes.");
                }
            }
        }

        // Attach event handlers to side navigation buttons
        private void AttachNavButtonEvents()
        {
            btnDoctors.Click += BtnDoctor_Click;
            btnPatients.Click += BtnPatients_Click;
            btnAppointmentSchedule.Click += BtnAppointmentSchedule_Click;
            btnGenerateReport.Click += BtnGenerateReport_Click;
            btnLogout.Click += BtnLogout_Click;
        }

        // Already on Manage Doctor form- optionally refresh form
        private void BtnDoctor_Click(object sender, EventArgs e)
        {
            LoadDoctors();
        }

        // Navigate to Patient form
        private void BtnPatients_Click(object sender, EventArgs e)
        {
            Manage_Patient patientForm = new Manage_Patient();
            patientForm.Show();
            this.Hide();
        }

        // Navigate to Appointment Schedule Form
        private void BtnAppointmentSchedule_Click(object sender, EventArgs e)
        {
            adminbookappointment appointmentForm = new adminbookappointment();
            appointmentForm.Show();
            this.Hide();
        }

        // Navigate to Generate Reports
        private void BtnGenerateReport_Click(object sender, EventArgs e)
        {
            Reportadmin reportForm = new Reportadmin();
            reportForm.Show();
            this.Hide();
        }

        // Log out and go back to Login form
        private void BtnLogout_Click(object sender, EventArgs e)
        {
             LoginForm loginForm = new LoginForm();
             loginForm.Show();
             this.Close(); // Close current form
        }

    }
}

    

