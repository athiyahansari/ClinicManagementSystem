using System;
using System.Windows.Forms;
using CMS.Controller;

namespace ClinicManagementSystem.Views.Patients
{
    public partial class ViewMedicalHistory : Form
    {
        private MedicalHistoryController controller;

        public ViewMedicalHistory()
        {
            InitializeComponent();
            controller = new MedicalHistoryController();

            // Attach the event handler for the Load button
            btnLoad.Click += BtnLoad_Click;
            this.Load += ViewMedicalHistory_Load;
        }

        private void ViewMedicalHistory_Load(object sender, EventArgs e)
        {
            // Optional: any initialization on form load
        }

        // Button click event - just calls the load method
        private void BtnLoad_Click(object sender, EventArgs e)
        {
            LoadMedicalHistory();//good practice
        }

        // Method to load medical history into the DataGridView
        private void LoadMedicalHistory()
        {
            
        }

        private void dvgMedicalHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
