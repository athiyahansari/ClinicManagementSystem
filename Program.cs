using System;
using System.Windows.Forms;
using ClinicManagementSystem.Views.Patients; // Make sure this matches your folder + namespace

namespace ClinicManagementSystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ViewMedicalHistory()); // Ensure this class exists and inherits Form
        }
    }
}
