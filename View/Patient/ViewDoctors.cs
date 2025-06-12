using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CMS.Controller;
using CMS.Model;

namespace CMS.View.Patient
{
    public partial class ViewDoctors : Form

    {
        private readonly DoctorController doctorController;

        public ViewDoctors()

        {
            InitializeComponent();
            doctorController = new DoctorController();
        }

        private void ViewDoctor_Load(object sender, EventArgs e)

        {
            LoadDoctorList();
        }

        private void LoadDoctorList()

        {
            List<Model.Doctor> doctors = doctorController.GetAllDoctors();
            dgvDoctors.DataSource = doctors;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
