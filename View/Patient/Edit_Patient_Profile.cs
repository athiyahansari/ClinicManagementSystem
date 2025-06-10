using System;
using System.Windows.Forms;
using CMS.Model;
using MySql.Data.MySqlClient;
using CMS.Utils;





namespace CMS.View.Patient
{
    public partial class Edit_Patient_Profile : Form
    {
        private int patientId;
        private Patients currentPatient;

        public Edit_Patient_Profile(int patientId)
        {
            InitializeComponent();
            this.patientId = patientId;


        }

        //public Edit_Patient_Profile()
        //{
        //}

        private void Edit_Patient_Profile_Load(object sender, EventArgs e)
        {
            LoadPatientData();

        }
        private void LoadPatientData()
        {
            using (MySqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM patients WHERE patient_id = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", patientId);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            currentPatient = new Patients
                            {
                                Id = patientId,
                                FirstName = reader["first_name"].ToString(),
                                LastName = reader["last_name"].ToString(),
                        
                                Email = reader["email"].ToString(),
                                Gender = reader["gender"].ToString()
                            };

                            txtFirstName.Text = currentPatient.FirstName;
                            txtLastName.Text = currentPatient.LastName;

                            txtEmail.Text = currentPatient.Email;
                            cmbGender.SelectedItem = currentPatient.Gender;
                        }
                    }
                }
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            currentPatient.FirstName = txtFirstName.Text.Trim();
            currentPatient.LastName = txtLastName.Text.Trim();

            currentPatient.Email = txtEmail.Text.Trim();
            currentPatient.Gender = cmbGender.SelectedItem?.ToString();

            using (MySqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();
                string query = @"UPDATE patients SET 
                                    first_name = @firstName, 
                                    last_name = @lastName, 
                                     
                                    email = @email, 
                                    gender = @gender 
                                 WHERE patient_id = @id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@firstName", currentPatient.FirstName);
                    cmd.Parameters.AddWithValue("@lastName", currentPatient.LastName);

                    cmd.Parameters.AddWithValue("@email", currentPatient.Email);
                    cmd.Parameters.AddWithValue("@gender", currentPatient.Gender);
                    cmd.Parameters.AddWithValue("@id", currentPatient.Id);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }



        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}

