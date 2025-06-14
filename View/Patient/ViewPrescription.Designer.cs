using CMS.Model;

namespace CMS.View.Patient
{
    partial class ViewPrescription
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            dgvPrescriptions = new DataGridView();
            Date = new DataGridViewTextBoxColumn();
            DoctorName = new DataGridViewTextBoxColumn();
            Diagnosis = new DataGridViewTextBoxColumn();
            Medicines = new DataGridViewTextBoxColumn();
            sidenav = new Panel();
            btnMedicalHistory = new Button();
            label2 = new Label();
            btnMyProfile = new Button();
            btnLogout = new Button();
            btnPrescriptions = new Button();
            btnDoctor = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnAppointment = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPrescriptions).BeginInit();
            sidenav.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = SystemColors.GradientActiveCaption;
            lblTitle.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(601, 39);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(276, 41);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Your Prescriptions";

            DataGridViewTextBoxColumn PrescriptionID = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Date = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn DoctorName = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Diagnosis = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Medicines = new DataGridViewTextBoxColumn();
            // 
            // dgvPrescriptions
            // 
            dgvPrescriptions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrescriptions.BackgroundColor = SystemColors.ButtonHighlight;
            dgvPrescriptions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrescriptions.Columns.AddRange(new DataGridViewColumn[] { Date, DoctorName, Diagnosis, Medicines });
            dgvPrescriptions.Location = new Point(273, 104);
            dgvPrescriptions.Name = "dgvPrescriptions";
            dgvPrescriptions.RowHeadersWidth = 51;
            dgvPrescriptions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrescriptions.Size = new Size(918, 496);
            dgvPrescriptions.TabIndex = 3;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            // 
            // DoctorName
            // 
            DoctorName.HeaderText = "Doctor Name";
            DoctorName.MinimumWidth = 6;
            DoctorName.Name = "DoctorName";
            // 
            // Diagnosis
            // 
            Diagnosis.HeaderText = "Diagnosis";
            Diagnosis.MinimumWidth = 6;
            Diagnosis.Name = "Diagnosis";
            // 
            // Medicines
            // 
            Medicines.HeaderText = "Medicines";
            Medicines.MinimumWidth = 6;
            Medicines.Name = "Medicines";
            // 
            // sidenav
            // 
            sidenav.BackColor = Color.CornflowerBlue;
            sidenav.Controls.Add(btnAppointment);
            sidenav.Controls.Add(btnMedicalHistory);
            sidenav.Controls.Add(label2);
            sidenav.Controls.Add(btnMyProfile);
            sidenav.Controls.Add(btnLogout);
            sidenav.Controls.Add(btnPrescriptions);
            sidenav.Controls.Add(btnDoctor);
            sidenav.Dock = DockStyle.Left;
            sidenav.Location = new Point(0, 0);
            sidenav.Name = "sidenav";
            sidenav.Size = new Size(247, 684);
            sidenav.TabIndex = 6;
            // 
            // btnMedicalHistory
            // 
            btnMedicalHistory.BackColor = Color.LightSteelBlue;
            btnMedicalHistory.Location = new Point(44, 261);
            btnMedicalHistory.Name = "btnMedicalHistory";
            btnMedicalHistory.Size = new Size(160, 44);
            btnMedicalHistory.TabIndex = 5;
            btnMedicalHistory.Text = "Medical History";
            btnMedicalHistory.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kristen ITC", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightCyan;
            label2.Location = new Point(12, 47);
            label2.Name = "label2";
            label2.Size = new Size(209, 33);
            label2.TabIndex = 21;
            label2.Text = "MedLine Clinic";
            // 
            // btnMyProfile
            // 
            btnMyProfile.BackColor = Color.LightSteelBlue;
            btnMyProfile.Location = new Point(44, 507);
            btnMyProfile.Name = "btnMyProfile";
            btnMyProfile.Size = new Size(160, 45);
            btnMyProfile.TabIndex = 4;
            btnMyProfile.Text = "MyProfile";
            btnMyProfile.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.LightSteelBlue;
            btnLogout.Location = new Point(44, 558);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(160, 42);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "LogOut";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnPrescriptions
            // 
            btnPrescriptions.BackColor = Color.LightSteelBlue;
            btnPrescriptions.Location = new Point(44, 213);
            btnPrescriptions.Name = "btnPrescriptions";
            btnPrescriptions.Size = new Size(160, 43);
            btnPrescriptions.TabIndex = 2;
            btnPrescriptions.Text = "Prescriptions";
            btnPrescriptions.UseVisualStyleBackColor = false;
            // 
            // btnDoctor
            // 
            btnDoctor.BackColor = Color.LightSteelBlue;
            btnDoctor.Location = new Point(44, 120);
            btnDoctor.Name = "btnDoctor";
            btnDoctor.Size = new Size(160, 40);
            btnDoctor.TabIndex = 0;
            btnDoctor.Text = "Doctor";
            btnDoctor.UseVisualStyleBackColor = false;
            // 
            // btnAppointment
            // 
            btnAppointment.BackColor = Color.LightSteelBlue;
            btnAppointment.Location = new Point(43, 167);
            btnAppointment.Name = "btnAppointment";
            btnAppointment.Size = new Size(160, 40);
            btnAppointment.TabIndex = 22;
            btnAppointment.Text = "Appointment";
            btnAppointment.UseVisualStyleBackColor = false;
            // 
            // ViewPrescription
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 684);
            Controls.Add(sidenav);
            Controls.Add(dgvPrescriptions);
            Controls.Add(lblTitle);
            Name = "ViewPrescription";
            Text = "ViewPrescription";
            Load += ViewPrescription_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPrescriptions).EndInit();
            sidenav.ResumeLayout(false);
            sidenav.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitle;
        private DataGridView dgvPrescriptions;
        private Panel sidenav;
        private Label label3;
        private Button btnMedicalHistory;
        private Label label2;
        private Button btnMyProfile;
        private Button btnLogout;
        private Button btnPrescriptions;
        private Button btnDoctor;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn DoctorName;
        private DataGridViewTextBoxColumn Diagnosis;
        private DataGridViewTextBoxColumn Medicines;
        private Button btnAppointment;
    }
}