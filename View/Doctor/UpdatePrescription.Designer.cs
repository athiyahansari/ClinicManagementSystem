namespace CMS.View.Doctor
{
    partial class UpdatePrescription
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label lblDiagnosis;
        private System.Windows.Forms.Label lblMedicines;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.TextBox txtDiagnosis;
        private System.Windows.Forms.TextBox txtMedicines;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblPatientID = new Label();
            lblPatientName = new Label();
            lblDiagnosis = new Label();
            lblMedicines = new Label();
            txtPatientID = new TextBox();
            txtPatientName = new TextBox();
            txtDiagnosis = new TextBox();
            txtMedicines = new TextBox();
            dtpDate = new DateTimePicker();
            lblDate = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblPatientID
            // 
            lblPatientID.AutoSize = true;
            lblPatientID.Location = new Point(30, 30);
            lblPatientID.Name = "lblPatientID";
            lblPatientID.Size = new Size(89, 23);
            lblPatientID.TabIndex = 0;
            lblPatientID.Text = "Patient ID:";
            // 
            // lblPatientName
            // 
            lblPatientName.AutoSize = true;
            lblPatientName.Location = new Point(30, 70);
            lblPatientName.Name = "lblPatientName";
            lblPatientName.Size = new Size(118, 23);
            lblPatientName.TabIndex = 2;
            lblPatientName.Text = "Patient Name:";
            // 
            // lblDiagnosis
            // 
            lblDiagnosis.AutoSize = true;
            lblDiagnosis.Location = new Point(30, 110);
            lblDiagnosis.Name = "lblDiagnosis";
            lblDiagnosis.Size = new Size(87, 23);
            lblDiagnosis.TabIndex = 4;
            lblDiagnosis.Text = "Diagnosis:";
            // 
            // lblMedicines
            // 
            lblMedicines.AutoSize = true;
            lblMedicines.Location = new Point(30, 150);
            lblMedicines.Name = "lblMedicines";
            lblMedicines.Size = new Size(90, 23);
            lblMedicines.TabIndex = 6;
            lblMedicines.Text = "Medicines:";
            // 
            // txtPatientID
            // 
            txtPatientID.Location = new Point(153, 30);
            txtPatientID.Name = "txtPatientID";
            txtPatientID.ReadOnly = true;
            txtPatientID.Size = new Size(250, 30);
            txtPatientID.TabIndex = 1;
            // 
            // txtPatientName
            // 
            txtPatientName.Location = new Point(153, 67);
            txtPatientName.Name = "txtPatientName";
            txtPatientName.ReadOnly = true;
            txtPatientName.Size = new Size(250, 30);
            txtPatientName.TabIndex = 3;
            // 
            // txtDiagnosis
            // 
            txtDiagnosis.Location = new Point(153, 110);
            txtDiagnosis.Name = "txtDiagnosis";
            txtDiagnosis.Size = new Size(250, 30);
            txtDiagnosis.TabIndex = 5;
            // 
            // txtMedicines
            // 
            txtMedicines.Location = new Point(153, 151);
            txtMedicines.Name = "txtMedicines";
            txtMedicines.Size = new Size(250, 30);
            txtMedicines.TabIndex = 7;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(153, 190);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(250, 30);
            dtpDate.TabIndex = 9;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(30, 190);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(50, 23);
            lblDate.TabIndex = 8;
            lblDate.Text = "Date:";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DarkTurquoise;
            btnSave.Location = new Point(173, 240);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 32);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.DarkTurquoise;
            btnCancel.Location = new Point(300, 240);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 32);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // UpdatePrescription
            // 
            ClientSize = new Size(440, 300);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(dtpDate);
            Controls.Add(lblDate);
            Controls.Add(txtMedicines);
            Controls.Add(lblMedicines);
            Controls.Add(txtDiagnosis);
            Controls.Add(lblDiagnosis);
            Controls.Add(txtPatientName);
            Controls.Add(lblPatientName);
            Controls.Add(txtPatientID);
            Controls.Add(lblPatientID);
            Name = "UpdatePrescription";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Update Prescription";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
