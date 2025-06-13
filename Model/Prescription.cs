using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Model
{
    // Prescription model to hold prescription details
    public class Prescription
    {
        public int PrescriptionID { get; set; } // Prescription ID (hidden in UI)
        public DateTime PrescriptionDate { get; set; } // Date of prescription
        public string Diagnosis { get; set; } // Diagnosis text
        public string Medicines { get; set; } // Medicines prescribed

        // Association: Each prescription is linked to a Doctor and a Patient
        public Doctor Doctor { get; set; } // Doctor who created the prescription
    }
}
