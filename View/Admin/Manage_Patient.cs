using CMS.Controller;
using CMS.Model;
using CMS.View.Patient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CMS.View.Admin
{
    public partial class Manage_Patient : Form
    {
         PatientController controller = new PatientController();

        public Manage_Patient()
        {
            InitializeComponent();
            LoadPatients();
          


        }
        private void LoadPatients()
        {
            List<Patients> patients = controller.GetAllPatients();
            dataGridViewPatients.Rows.Clear();

            foreach (var p in patients)
            {
                dataGridViewPatients.Rows.Add( p.FirstName, p.LastName, p.Email);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new Edit_Patient_Profile();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadPatients();
            }

        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewPatients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a patient.");
                return;
            }

            int id = Convert.ToInt32(dataGridViewPatients.SelectedRows[0].Cells[0].Value);
            var patient = controller.GetAllPatients().Find(p => p.Id == id);

            if (patient != null)
            {
                var form = new Edit_Patient_Profile(); // Pass patient to edit
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadPatients();
                }
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridViewPatients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a patient to remove.");
                return;
            }

            int id = Convert.ToInt32(dataGridViewPatients.SelectedRows[0].Cells[0].Value);
            controller.DeletePatient(id);
            LoadPatients();
        }






        private void dataGridViewPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
