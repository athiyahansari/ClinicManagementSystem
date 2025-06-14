namespace CMS.View.Doctor
{
    partial class CreatePrescription
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
            sidenav = new Panel();
            btnPrescriptions = new Button();
            btnMyProfile = new Button();
            label2 = new Label();
            btnLogout = new Button();
            btnMyAppointments = new Button();
            lblTitle = new Label();
            lblPatientID = new Label();
            lblDiagnosis = new Label();
            txtPatientID = new TextBox();
            txtDiagnosis = new TextBox();
            lblMedicines = new Label();
            txtMedicines = new TextBox();
            btnAdd = new Button();
            dtpDate = new DateTimePicker();
            dgvPrescriptions = new DataGridView();
            date = new DataGridViewTextBoxColumn();
            ptID = new DataGridViewTextBoxColumn();
            PtName = new DataGridViewTextBoxColumn();
            disease = new DataGridViewTextBoxColumn();
            medicine = new DataGridViewTextBoxColumn();
            UpdateColumn = new DataGridViewButtonColumn();
            lblPatientName = new Label();
            txtPatientName = new TextBox();
            sidenav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrescriptions).BeginInit();
            SuspendLayout();
            // 
            // sidenav
            // 
            sidenav.BackColor = Color.CornflowerBlue;
            sidenav.Controls.Add(btnPrescriptions);
            sidenav.Controls.Add(btnMyProfile);
            sidenav.Controls.Add(label2);
            sidenav.Controls.Add(btnLogout);
            sidenav.Controls.Add(btnMyAppointments);
            sidenav.Dock = DockStyle.Left;
            sidenav.Location = new Point(0, 0);
            sidenav.Name = "sidenav";
            sidenav.Size = new Size(247, 735);
            sidenav.TabIndex = 2;
            // 
            // btnPrescriptions
            // 
            btnPrescriptions.BackColor = Color.LightSteelBlue;
            btnPrescriptions.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrescriptions.Location = new Point(41, 180);
            btnPrescriptions.Name = "btnPrescriptions";
            btnPrescriptions.Size = new Size(159, 47);
            btnPrescriptions.TabIndex = 24;
            btnPrescriptions.Text = "Prescriptions";
            btnPrescriptions.UseVisualStyleBackColor = false;
            // 
            // btnMyProfile
            // 
            btnMyProfile.BackColor = Color.LightSteelBlue;
            btnMyProfile.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMyProfile.Location = new Point(41, 559);
            btnMyProfile.Name = "btnMyProfile";
            btnMyProfile.Size = new Size(159, 45);
            btnMyProfile.TabIndex = 4;
            btnMyProfile.Text = "MyProfile";
            btnMyProfile.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kristen ITC", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightCyan;
            label2.Location = new Point(23, 41);
            label2.Name = "label2";
            label2.Size = new Size(209, 33);
            label2.TabIndex = 23;
            label2.Text = "MedLine Clinic";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.LightSteelBlue;
            btnLogout.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(41, 610);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(159, 42);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "LogOut";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnMyAppointments
            // 
            btnMyAppointments.BackColor = Color.LightSteelBlue;
            btnMyAppointments.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMyAppointments.Location = new Point(41, 127);
            btnMyAppointments.Name = "btnMyAppointments";
            btnMyAppointments.Size = new Size(159, 47);
            btnMyAppointments.TabIndex = 1;
            btnMyAppointments.Text = "My Appointment";
            btnMyAppointments.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = SystemColors.GradientActiveCaption;
            lblTitle.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(597, 33);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(324, 41);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Manage Prescriptions";
            // 
            // lblPatientID
            // 
            lblPatientID.AutoSize = true;
            lblPatientID.Location = new Point(318, 127);
            lblPatientID.Name = "lblPatientID";
            lblPatientID.Size = new Size(94, 23);
            lblPatientID.TabIndex = 4;
            lblPatientID.Text = "Patient ID :";
            // 
            // lblDiagnosis
            // 
            lblDiagnosis.AutoSize = true;
            lblDiagnosis.Location = new Point(317, 220);
            lblDiagnosis.Name = "lblDiagnosis";
            lblDiagnosis.Size = new Size(92, 23);
            lblDiagnosis.TabIndex = 5;
            lblDiagnosis.Text = "Diagnosis :";
            // 
            // txtPatientID
            // 
            txtPatientID.Location = new Point(455, 120);
            txtPatientID.Name = "txtPatientID";
            txtPatientID.Size = new Size(307, 30);
            txtPatientID.TabIndex = 6;
            // 
            // txtDiagnosis
            // 
            txtDiagnosis.Location = new Point(455, 213);
            txtDiagnosis.Name = "txtDiagnosis";
            txtDiagnosis.Size = new Size(307, 30);
            txtDiagnosis.TabIndex = 7;
            txtDiagnosis.TextChanged += txtDiagnosis_TextChanged;
            // 
            // lblMedicines
            // 
            lblMedicines.AutoSize = true;
            lblMedicines.Location = new Point(317, 268);
            lblMedicines.Name = "lblMedicines";
            lblMedicines.Size = new Size(95, 23);
            lblMedicines.TabIndex = 8;
            lblMedicines.Text = "Medicines :";
            // 
            // txtMedicines
            // 
            txtMedicines.Location = new Point(455, 261);
            txtMedicines.Name = "txtMedicines";
            txtMedicines.Size = new Size(307, 30);
            txtMedicines.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkTurquoise;
            btnAdd.Location = new Point(685, 315);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(256, 29);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add New Prescription Details";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(317, 315);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(306, 30);
            dtpDate.TabIndex = 14;
            // 
            // dgvPrescriptions
            // 
            dgvPrescriptions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrescriptions.BackgroundColor = SystemColors.ButtonHighlight;
            dgvPrescriptions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrescriptions.Columns.AddRange(new DataGridViewColumn[] { date, ptID, PtName, disease, medicine, UpdateColumn });
            dgvPrescriptions.Location = new Point(282, 416);
            dgvPrescriptions.Name = "dgvPrescriptions";
            dgvPrescriptions.RowHeadersWidth = 51;
            dgvPrescriptions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrescriptions.Size = new Size(890, 268);
            dgvPrescriptions.TabIndex = 15;
            dgvPrescriptions.CellClick += dgvPrescriptions_CellClick;
            // 
            // date
            // 
            date.HeaderText = "Date";
            date.MinimumWidth = 6;
            date.Name = "date";
            // 
            // ptID
            // 
            ptID.HeaderText = "Patient ID";
            ptID.MinimumWidth = 6;
            ptID.Name = "ptID";
            // 
            // PtName
            // 
            PtName.HeaderText = "Patient Name";
            PtName.MinimumWidth = 6;
            PtName.Name = "PtName";
            // 
            // disease
            // 
            disease.HeaderText = "Diagnosis";
            disease.MinimumWidth = 6;
            disease.Name = "disease";
            // 
            // medicine
            // 
            medicine.HeaderText = "Medicines";
            medicine.MinimumWidth = 6;
            medicine.Name = "medicine";
            // 
            // UpdateColumn
            // 
            UpdateColumn.HeaderText = "Update";
            UpdateColumn.MinimumWidth = 6;
            UpdateColumn.Name = "UpdateColumn";
            UpdateColumn.Resizable = DataGridViewTriState.True;
            UpdateColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            UpdateColumn.Text = "Update";
            UpdateColumn.UseColumnTextForButtonValue = true;
            // 
            // lblPatientName
            // 
            lblPatientName.AutoSize = true;
            lblPatientName.Location = new Point(317, 172);
            lblPatientName.Name = "lblPatientName";
            lblPatientName.Size = new Size(123, 23);
            lblPatientName.TabIndex = 17;
            lblPatientName.Text = "Patient Name :";
            // 
            // txtPatientName
            // 
            txtPatientName.Location = new Point(455, 170);
            txtPatientName.Name = "txtPatientName";
            txtPatientName.Size = new Size(307, 30);
            txtPatientName.TabIndex = 18;
            // 
            // CreatePrescription
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1198, 735);
            Controls.Add(txtPatientName);
            Controls.Add(lblPatientName);
            Controls.Add(dgvPrescriptions);
            Controls.Add(dtpDate);
            Controls.Add(btnAdd);
            Controls.Add(txtMedicines);
            Controls.Add(lblMedicines);
            Controls.Add(txtDiagnosis);
            Controls.Add(txtPatientID);
            Controls.Add(lblDiagnosis);
            Controls.Add(lblPatientID);
            Controls.Add(lblTitle);
            Controls.Add(sidenav);
            Name = "CreatePrescription";
            Text = "CreatePrescription";
            Load += CreatePrescription_Load;
            sidenav.ResumeLayout(false);
            sidenav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrescriptions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel sidenav;
        private Button btnMyProfile;
        private Label label2;
        private Button btnLogout;
        private Button btnMyAppointments;
        private Label lblTitle;
        private Label lblPatientID;
        private Label lblDiagnosis;
        private TextBox txtPatientID;
        private TextBox txtDiagnosis;
        private Label lblMedicines;
        private TextBox txtMedicines;
        private Button btnAdd;
        private DateTimePicker dtpDate;
        private DataGridView dgvPrescriptions;
        private Label lblPatientName;
        private TextBox txtPatientName;
        private Button btnPrescriptions;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn ptID;
        private DataGridViewTextBoxColumn PtName;
        private DataGridViewTextBoxColumn disease;
        private DataGridViewTextBoxColumn medicine;
        private DataGridViewButtonColumn UpdateColumn;
    }
}