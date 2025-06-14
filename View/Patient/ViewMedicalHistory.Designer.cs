namespace ClinicManagementSystem.Views.Patients
{
    partial class ViewMedicalHistory
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
            txtPatientName = new TextBox();
            label1 = new Label();
            btnLoad = new Button();
            dgvHistory = new DataGridView();
            colVisitDate = new DataGridViewTextBoxColumn();
            colDiagnosis = new DataGridViewTextBoxColumn();
            colPrescription = new DataGridViewTextBoxColumn();
            colNotes = new DataGridViewTextBoxColumn();
            colDoctorName = new DataGridViewTextBoxColumn();
            label2 = new Label();
            sidenav = new Panel();
            label3 = new Label();
            navmedicalhistory = new Button();
            label4 = new Label();
            navprofile = new Button();
            logout = new Button();
            navprescription = new Button();
            navappointment = new Button();
            navdoc = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            sidenav.SuspendLayout();
            SuspendLayout();
            // 
            // txtPatientName
            // 
            txtPatientName.Location = new Point(214, 129);
            txtPatientName.Name = "txtPatientName";
            txtPatientName.Size = new Size(200, 23);
            txtPatientName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(214, 97);
            label1.Name = "label1";
            label1.Size = new Size(143, 17);
            label1.TabIndex = 1;
            label1.Text = "Enter Patient Full Name";
            // 
            // btnLoad
            // 
            btnLoad.BackColor = SystemColors.ActiveCaption;
            btnLoad.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLoad.Location = new Point(489, 128);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 32);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "Load History";
            btnLoad.UseVisualStyleBackColor = false;
            // 
            // dgvHistory
            // 
            dgvHistory.AllowUserToAddRows = false;
            dgvHistory.AllowUserToDeleteRows = false;
            dgvHistory.BackgroundColor = SystemColors.ActiveCaption;
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.Columns.AddRange(new DataGridViewColumn[] { colVisitDate, colDiagnosis, colPrescription, colNotes, colDoctorName });
            dgvHistory.Location = new Point(214, 209);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.ReadOnly = true;
            dgvHistory.Size = new Size(543, 84);
            dgvHistory.TabIndex = 3;
            // 
            // colVisitDate
            // 
            colVisitDate.HeaderText = "Visit Date";
            colVisitDate.Name = "colVisitDate";
            colVisitDate.ReadOnly = true;
            // 
            // colDiagnosis
            // 
            colDiagnosis.HeaderText = "Diagnosis";
            colDiagnosis.Name = "colDiagnosis";
            colDiagnosis.ReadOnly = true;
            // 
            // colPrescription
            // 
            colPrescription.HeaderText = "Prescription";
            colPrescription.Name = "colPrescription";
            colPrescription.ReadOnly = true;
            // 
            // colNotes
            // 
            colNotes.HeaderText = "Notes";
            colNotes.Name = "colNotes";
            colNotes.ReadOnly = true;
            // 
            // colDoctorName
            // 
            colDoctorName.HeaderText = "Doctor";
            colDoctorName.Name = "colDoctorName";
            colDoctorName.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(214, 9);
            label2.Name = "label2";
            label2.Size = new Size(224, 32);
            label2.TabIndex = 4;
            label2.Text = "View Medical History";
            // 
            // sidenav
            // 
            sidenav.BackColor = Color.CornflowerBlue;
            sidenav.Controls.Add(label3);
            sidenav.Controls.Add(navmedicalhistory);
            sidenav.Controls.Add(label4);
            sidenav.Controls.Add(navprofile);
            sidenav.Controls.Add(logout);
            sidenav.Controls.Add(navprescription);
            sidenav.Controls.Add(navappointment);
            sidenav.Controls.Add(navdoc);
            sidenav.Dock = DockStyle.Left;
            sidenav.Location = new Point(0, 0);
            sidenav.Margin = new Padding(2);
            sidenav.Name = "sidenav";
            sidenav.Size = new Size(183, 423);
            sidenav.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(57, 52);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(109, 19);
            label3.TabIndex = 22;
            label3.Text = "Patient ID-2346";
            // 
            // navmedicalhistory
            // 
            navmedicalhistory.BackColor = Color.LightSteelBlue;
            navmedicalhistory.Location = new Point(34, 170);
            navmedicalhistory.Margin = new Padding(2);
            navmedicalhistory.Name = "navmedicalhistory";
            navmedicalhistory.Size = new Size(125, 29);
            navmedicalhistory.TabIndex = 5;
            navmedicalhistory.Text = "Medical History";
            navmedicalhistory.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Kristen ITC", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(34, 29);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(113, 27);
            label4.TabIndex = 21;
            label4.Text = "John Doe";
            // 
            // navprofile
            // 
            navprofile.BackColor = Color.LightSteelBlue;
            navprofile.Location = new Point(34, 331);
            navprofile.Margin = new Padding(2);
            navprofile.Name = "navprofile";
            navprofile.Size = new Size(125, 29);
            navprofile.TabIndex = 4;
            navprofile.Text = "MyProfile";
            navprofile.UseVisualStyleBackColor = false;
            // 
            // logout
            // 
            logout.BackColor = Color.LightSteelBlue;
            logout.Location = new Point(34, 364);
            logout.Margin = new Padding(2);
            logout.Name = "logout";
            logout.Size = new Size(125, 28);
            logout.TabIndex = 3;
            logout.Text = "LogOut";
            logout.UseVisualStyleBackColor = false;
            // 
            // navprescription
            // 
            navprescription.BackColor = Color.LightSteelBlue;
            navprescription.Location = new Point(34, 139);
            navprescription.Margin = new Padding(2);
            navprescription.Name = "navprescription";
            navprescription.Size = new Size(125, 28);
            navprescription.TabIndex = 2;
            navprescription.Text = "Prescriptions";
            navprescription.UseVisualStyleBackColor = false;
            // 
            // navappointment
            // 
            navappointment.BackColor = Color.LightSteelBlue;
            navappointment.Location = new Point(34, 107);
            navappointment.Margin = new Padding(2);
            navappointment.Name = "navappointment";
            navappointment.Size = new Size(125, 28);
            navappointment.TabIndex = 1;
            navappointment.Text = "Appointment";
            navappointment.UseVisualStyleBackColor = false;
            // 
            // navdoc
            // 
            navdoc.BackColor = Color.LightSteelBlue;
            navdoc.Location = new Point(34, 78);
            navdoc.Margin = new Padding(2);
            navdoc.Name = "navdoc";
            navdoc.Size = new Size(125, 26);
            navdoc.TabIndex = 0;
            navdoc.Text = "View Doctor";
            navdoc.UseVisualStyleBackColor = false;
            // 
            // ViewMedicalHistory
            // 
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(791, 423);
            Controls.Add(sidenav);
            Controls.Add(label2);
            Controls.Add(dgvHistory);
            Controls.Add(btnLoad);
            Controls.Add(label1);
            Controls.Add(txtPatientName);
            Name = "ViewMedicalHistory";
            Text = "View Medical History";
            Load += ViewMedicalHistory_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            sidenav.ResumeLayout(false);
            sidenav.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVisitDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiagnosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDoctorName;
        private Label label2;
        private Panel sidenav;
        private Label label3;
        private Button navmedicalhistory;
        private Label label4;
        private Button navprofile;
        private Button logout;
        private Button navprescription;
        private Button navappointment;
        private Button navdoc;
    }
}
