using CMS.Model;

namespace CMS.View.Patient
{
    partial class ViewPrescription
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvPrescriptions = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diagnosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medicines = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sidenav = new System.Windows.Forms.Panel();
            this.btnAppointment = new System.Windows.Forms.Button();
            this.btnMedicalHistory = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMyProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnPrescriptions = new System.Windows.Forms.Button();
            this.btnDoctor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescriptions)).BeginInit();
            this.sidenav.SuspendLayout();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline);
            this.lblTitle.Location = new System.Drawing.Point(601, 39);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(276, 41);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Your Prescriptions";

            // dgvPrescriptions
            this.dgvPrescriptions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrescriptions.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPrescriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrescriptions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.DoctorName,
            this.Diagnosis,
            this.Medicines});
            this.dgvPrescriptions.Location = new System.Drawing.Point(273, 104);
            this.dgvPrescriptions.Name = "dgvPrescriptions";
            this.dgvPrescriptions.RowHeadersWidth = 51;
            this.dgvPrescriptions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrescriptions.Size = new System.Drawing.Size(918, 496);
            this.dgvPrescriptions.TabIndex = 3;

            // Date
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";

            // DoctorName
            this.DoctorName.HeaderText = "Doctor Name";
            this.DoctorName.MinimumWidth = 6;
            this.DoctorName.Name = "DoctorName";

            // Diagnosis
            this.Diagnosis.HeaderText = "Diagnosis";
            this.Diagnosis.MinimumWidth = 6;
            this.Diagnosis.Name = "Diagnosis";

            // Medicines
            this.Medicines.HeaderText = "Medicines";
            this.Medicines.MinimumWidth = 6;
            this.Medicines.Name = "Medicines";

            // sidenav
            this.sidenav.BackColor = System.Drawing.Color.CornflowerBlue;
            this.sidenav.Controls.Add(this.btnAppointment);
            this.sidenav.Controls.Add(this.btnMedicalHistory);
            this.sidenav.Controls.Add(this.label2);
            this.sidenav.Controls.Add(this.btnMyProfile);
            this.sidenav.Controls.Add(this.btnLogout);
            this.sidenav.Controls.Add(this.btnPrescriptions);
            this.sidenav.Controls.Add(this.btnDoctor);
            this.sidenav.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidenav.Location = new System.Drawing.Point(0, 0);
            this.sidenav.Name = "sidenav";
            this.sidenav.Size = new System.Drawing.Size(247, 684);
            this.sidenav.TabIndex = 6;

            // btnAppointment
            this.btnAppointment.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAppointment.Location = new System.Drawing.Point(43, 167);
            this.btnAppointment.Name = "btnAppointment";
            this.btnAppointment.Size = new System.Drawing.Size(160, 40);
            this.btnAppointment.TabIndex = 22;
            this.btnAppointment.Text = "Appointment";
            this.btnAppointment.UseVisualStyleBackColor = false;

            // btnMedicalHistory
            this.btnMedicalHistory.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMedicalHistory.Location = new System.Drawing.Point(44, 261);
            this.btnMedicalHistory.Name = "btnMedicalHistory";
            this.btnMedicalHistory.Size = new System.Drawing.Size(160, 44);
            this.btnMedicalHistory.TabIndex = 5;
            this.btnMedicalHistory.Text = "Medical History";
            this.btnMedicalHistory.UseVisualStyleBackColor = false;

            // label2
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.LightCyan;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 33);
            this.label2.TabIndex = 21;
            this.label2.Text = "MedLine Clinic";

            // btnMyProfile
            this.btnMyProfile.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMyProfile.Location = new System.Drawing.Point(44, 507);
            this.btnMyProfile.Name = "btnMyProfile";
            this.btnMyProfile.Size = new System.Drawing.Size(160, 45);
            this.btnMyProfile.TabIndex = 4;
            this.btnMyProfile.Text = "MyProfile";
            this.btnMyProfile.UseVisualStyleBackColor = false;

            // btnLogout
            this.btnLogout.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnLogout.Location = new System.Drawing.Point(44, 558);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(160, 42);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "LogOut";
            this.btnLogout.UseVisualStyleBackColor = false;

            // btnPrescriptions
            this.btnPrescriptions.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPrescriptions.Location = new System.Drawing.Point(44, 213);
            this.btnPrescriptions.Name = "btnPrescriptions";
            this.btnPrescriptions.Size = new System.Drawing.Size(160, 43);
            this.btnPrescriptions.TabIndex = 2;
            this.btnPrescriptions.Text = "Prescriptions";
            this.btnPrescriptions.UseVisualStyleBackColor = false;

            // btnDoctor
            this.btnDoctor.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDoctor.Location = new System.Drawing.Point(44, 120);
            this.btnDoctor.Name = "btnDoctor";
            this.btnDoctor.Size = new System.Drawing.Size(160, 40);
            this.btnDoctor.TabIndex = 0;
            this.btnDoctor.Text = "Doctor";
            this.btnDoctor.UseVisualStyleBackColor = false;

            // ViewPrescription
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 684);
            this.Controls.Add(this.sidenav);
            this.Controls.Add(this.dgvPrescriptions);
            this.Controls.Add(this.lblTitle);
            this.Name = "ViewPrescription";
            this.Text = "ViewPrescription";
            this.Load += new System.EventHandler(this.ViewPrescription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescriptions)).EndInit();
            this.sidenav.ResumeLayout(false);
            this.sidenav.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvPrescriptions;
        private System.Windows.Forms.Panel sidenav;
        private System.Windows.Forms.Button btnMedicalHistory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMyProfile;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnPrescriptions;
        private System.Windows.Forms.Button btnDoctor;
        private System.Windows.Forms.Button btnAppointment;

        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diagnosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicines;
    }
}
