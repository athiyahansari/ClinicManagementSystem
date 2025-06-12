namespace ClinicManagementSystem.Models
{
    public class MedicalHistory
    {
        public int HistoryID { get; set; }
        public int PatientID { get; set; }
        public string PatientName { get; set; }
        public DateTime Date { get; set; }
        public string Diagnosis { get; set; }
        public string Prescription { get; set; }    // ✅ Add this
        public string Notes { get; set; }          // ✅ Add this
        public string DoctorName { get; set; }



    }
}
