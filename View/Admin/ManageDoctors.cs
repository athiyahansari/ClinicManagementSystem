using CMS.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CMS.Model;

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

        // Load records into grid
        private void LoadDoctors()
        {
            doctorGridView.Rows.Clear();
            foreach (var d in ctrl.GetAllDoctors())
            {
                doctorGridView.Rows.Add(d.DoctorID, d.FullName, d.Speciality, d.Email, d.PhoneNo);
            }
        }

        // Add new doctor
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInputs(out CMS.Model.Doctor d))
            {
                ctrl.AddDoctor(d);
                MessageBox.Show("Added!");
                ClearFields();
                LoadDoctors();
            }
        }

        // Update doctor details
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedId < 0) { MessageBox.Show("Select row"); return; }
            if (ValidateInputs(out CMS.Model.Doctor d))
            {
                d.DoctorID = selectedId;
                ctrl.UpdateDoctor(d);
                MessageBox.Show("Updated!");
                ClearFields();
                LoadDoctors();
            }
        }

        // Delete doctor
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId < 0) { MessageBox.Show("Select row"); return; }
            if (MessageBox.Show("Delete?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ctrl.DeleteDoctor(selectedId);
                MessageBox.Show("Deleted!");
                ClearFields();
                LoadDoctors();
            }
        }

        // Clear text fields
        private void btnClear_Click(object sender, EventArgs e) => ClearFields();

        // Populate fields from selected grid row
        private void doctorGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = doctorGridView.Rows[e.RowIndex];
            selectedId = Convert.ToInt32(row.Cells[0].Value);
            txtFullName.Text = row.Cells[1].Value?.ToString();
            txtSpeciality.Text = row.Cells[2].Value?.ToString();
            txtEmail.Text = row.Cells[3].Value?.ToString();
            txtNumber.Text = row.Cells[4].Value?.ToString();
        }

        // Clear all inputs
        private void ClearFields()
        {
            selectedId = -1;
            txtDocID.Clear();
            txtFullName.Clear();
            txtSpeciality.Clear();
            txtEmail.Clear();
            txtNumber.Clear();
        }

        // Read inputs into Doctor object
        private bool ValidateInputs(out CMS.Model.Doctor d)
        {
            d = null;
            if (string.IsNullOrWhiteSpace(txtFullName.Text) || string.IsNullOrWhiteSpace(txtSpeciality.Text))
            {
                MessageBox.Show("Name & Speciality required."); return false;
            }

           d= new Model.Doctor()
            {
                FullName = txtFullName.Text.Trim(),
                Speciality = txtSpeciality.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                PhoneNo = txtNumber.Text.Trim(),
                UserID = 1 // Replace with real user ID if needed
            };
            return true;
        }

        // Back button logic
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // (Optional) validate email input
        private void emailtxt_TextChanged(object sender, EventArgs e) { }
        private void phoneNotxt_TextChanged(object sender, EventArgs e) { }
    }
}
