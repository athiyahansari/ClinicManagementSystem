using CMS.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.View.Doctor
{
    public partial class CreatePrescription : Form
    {
        public CreatePrescription()
        {
            InitializeComponent();
        }

        //  Load event: called when the form is first shown
        private void CreatePrescription_Load(object sender, EventArgs e)
        {
            LoadPrescriptionData(); // Populate the DataGridView
        }

        //  Load all prescriptions from DB and fill into DataGridView
        private void LoadPrescriptionData()
        {
            try
            {
                using (var conn = DBHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT PrescriptionID, PrescriptionDate, PatientID, Diagnosis, Medicines FROM prescriptions";
                    using (var cmd = new MySqlCommand(query, conn))
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvPrescriptions.Rows.Clear();

                        foreach (DataRow row in dt.Rows)
                        {
                            dgvPrescriptions.Rows.Add(
                                row["PrescriptionID"],
                                Convert.ToDateTime(row["PrescriptionDate"]).ToString("yyyy-MM-dd"),
                                row["PatientID"],
                                row["Diagnosis"],
                                row["Medicines"]
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading prescriptions: " + ex.Message);
            }
        }

        //  Add a new prescription
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = DBHelper.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO prescriptions (PatientID, DoctorID, Diagnosis, Medicines, PrescriptionDate) VALUES (@pid, @did, @diag, @meds, @date)";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        // Replace with actual doctor ID from session/user context
                        cmd.Parameters.AddWithValue("@pid", txtPatientID.Text);
                        cmd.Parameters.AddWithValue("@did", 2346);
                        cmd.Parameters.AddWithValue("@diag", txtDiagnosis.Text);
                        cmd.Parameters.AddWithValue("@meds", txtMedicines.Text);
                        cmd.Parameters.AddWithValue("@date", dtpDate.Value);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Prescription added successfully!");
                        LoadPrescriptionData();
                        ClearForm();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding prescription: " + ex.Message);
            }
        }

        //  Update an existing prescription
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvPrescriptions.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            try
            {
                string id = dgvPrescriptions.SelectedRows[0].Cells["PrescriptionID"].Value.ToString();

                using (var conn = DBHelper.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE prescriptions SET PatientID=@pid, Diagnosis=@diag, Medicines=@meds, PrescriptionDate=@date WHERE PrescriptionID=@id";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@pid", txtPatientID.Text);
                        cmd.Parameters.AddWithValue("@diag", txtDiagnosis.Text);
                        cmd.Parameters.AddWithValue("@meds", txtMedicines.Text);
                        cmd.Parameters.AddWithValue("@date", dtpDate.Value);
                        cmd.Parameters.AddWithValue("@id", id);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Prescription updated successfully!");
                        LoadPrescriptionData();
                        ClearForm();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating prescription: " + ex.Message);
            }
        }

        //  Delete selected prescription
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPrescriptions.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            try
            {
                string id = dgvPrescriptions.SelectedRows[0].Cells["PrescriptionID"].Value.ToString();

                using (var conn = DBHelper.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM prescriptions WHERE PrescriptionID=@id";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Prescription deleted successfully!");
                        LoadPrescriptionData();
                        ClearForm();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting prescription: " + ex.Message);
            }
        }

        //  Clear all input fields
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        // Reset input fields
        private void ClearForm()
        {
            txtPatientID.Clear();
            txtDiagnosis.Clear();
            txtMedicines.Clear();
            dtpDate.Value = DateTime.Today;
        }

        //  Populate input fields when a row is clicked
        private void dgvPrescriptions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvPrescriptions.Rows[e.RowIndex].Cells["PrescriptionID"].Value != null)
            {
                DataGridViewRow row = dgvPrescriptions.Rows[e.RowIndex];
                txtPatientID.Text = row.Cells["ptID"].Value.ToString();
                txtDiagnosis.Text = row.Cells["disease"].Value.ToString();
                txtMedicines.Text = row.Cells["medicine"].Value.ToString();
                dtpDate.Value = DateTime.Parse(row.Cells["date"].Value.ToString());
            }
        }

        //  Go back (navigate to previous screen)
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // or navigate to previous form
        }
    }
}
