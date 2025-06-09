using CMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Model
{
    // Model class for Prescription - encapsulation with public properties
    public class Prescription
    {
        public int PrescriptionID { get; set; }
        public int PatientID { get; set; }
        public int DoctorID { get; set; }
        public string Diagnosis { get; set; }
        public string Medicines { get; set; }
        public DateTime PrescriptionDate { get; set; }

        // Composition: A prescription must be associated with a patient and doctor

        // Default constructor
        public Prescription() { }

        // Constructor without ID (for new prescriptions)
        public Prescription(int patientID, int doctorID, string diagnosis, string medicines, DateTime date)
        {
            PatientID = patientID;
            DoctorID = doctorID;
            Diagnosis = diagnosis;
            Medicines = medicines;
            PrescriptionDate = date;
        }

        // Constructor with ID (for existing prescriptions)
        public Prescription(int prescriptionID, int patientID, int doctorID, string diagnosis, string medicines, DateTime date)
            : this(patientID, doctorID, diagnosis, medicines, date)
        {
            PrescriptionID = prescriptionID;
        }

    }
}





