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
            button1 = new Button();
            navprofile = new Button();
            label2 = new Label();
            logout = new Button();
            navappointment = new Button();
            navpatient = new Button();
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
            btnBack = new Button();
            lblPatientName = new Label();
            txtPatientName = new TextBox();
            sidenav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrescriptions).BeginInit();
            SuspendLayout();
            // 
            // sidenav
            // 
            sidenav.BackColor = Color.CornflowerBlue;
            sidenav.Controls.Add(button1);
            sidenav.Controls.Add(navprofile);
            sidenav.Controls.Add(label2);
            sidenav.Controls.Add(logout);
            sidenav.Controls.Add(navappointment);
            sidenav.Controls.Add(navpatient);
            sidenav.Dock = DockStyle.Left;
            sidenav.Location = new Point(0, 0);
            sidenav.Name = "sidenav";
            sidenav.Size = new Size(247, 735);
            sidenav.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSteelBlue;
            button1.Font = new Font("Segoe UI", 9F);
            button1.Location = new Point(42, 223);
            button1.Name = "button1";
            button1.Size = new Size(159, 47);
            button1.TabIndex = 24;
            button1.Text = "Prescriptions";
            button1.UseVisualStyleBackColor = false;
            // 
            // navprofile
            // 
            navprofile.BackColor = Color.LightSteelBlue;
            navprofile.Font = new Font("Segoe UI", 9F);
            navprofile.Location = new Point(41, 446);
            navprofile.Name = "navprofile";
            navprofile.Size = new Size(159, 45);
            navprofile.TabIndex = 4;
            navprofile.Text = "MyProfile";
            navprofile.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kristen ITC", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(23, 41);
            label2.Name = "label2";
            label2.Size = new Size(209, 33);
            label2.TabIndex = 23;
            label2.Text = "MedLine Clinic";
            // 
            // logout
            // 
            logout.BackColor = Color.LightSteelBlue;
            logout.Font = new Font("Segoe UI", 9F);
            logout.Location = new Point(41, 497);
            logout.Name = "logout";
            logout.Size = new Size(159, 42);
            logout.TabIndex = 3;
            logout.Text = "LogOut";
            logout.UseVisualStyleBackColor = false;
            // 
            // navappointment
            // 
            navappointment.BackColor = Color.LightSteelBlue;
            navappointment.Font = new Font("Segoe UI", 9F);
            navappointment.Location = new Point(41, 172);
            navappointment.Name = "navappointment";
            navappointment.Size = new Size(159, 47);
            navappointment.TabIndex = 1;
            navappointment.Text = "My Appointment";
            navappointment.UseVisualStyleBackColor = false;
            // 
            // navpatient
            // 
            navpatient.BackColor = Color.LightSteelBlue;
            navpatient.Font = new Font("Segoe UI", 9F);
            navpatient.Location = new Point(41, 120);
            navpatient.Name = "navpatient";
            navpatient.Size = new Size(159, 47);
            navpatient.TabIndex = 0;
            navpatient.Text = "My Patients";
            navpatient.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = SystemColors.GradientActiveCaption;
            lblTitle.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(554, 32);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(324, 41);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Manage Prescriptions";
            // 
            // lblPatientID
            // 
            lblPatientID.AutoSize = true;
            lblPatientID.Location = new Point(317, 120);
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
            txtPatientID.Size = new Size(125, 30);
            txtPatientID.TabIndex = 6;
            // 
            // txtDiagnosis
            // 
            txtDiagnosis.Location = new Point(455, 213);
            txtDiagnosis.Name = "txtDiagnosis";
            txtDiagnosis.Size = new Size(197, 30);
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
            txtMedicines.Size = new Size(208, 30);
            txtMedicines.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkTurquoise;
            btnAdd.Location = new Point(857, 103);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(256, 29);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add New Prescription Details";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(317, 336);
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
            dgvPrescriptions.Location = new Point(283, 405);
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
            // btnBack
            // 
            btnBack.BackColor = Color.LightSkyBlue;
            btnBack.Location = new Point(283, 694);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 16;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // lblPatientName
            // 
            lblPatientName.AutoSize = true;
            lblPatientName.Location = new Point(317, 173);
            lblPatientName.Name = "lblPatientName";
            lblPatientName.Size = new Size(123, 23);
            lblPatientName.TabIndex = 17;
            lblPatientName.Text = "Patient Name :";
            // 
            // txtPatientName
            // 
            txtPatientName.Location = new Point(455, 170);
            txtPatientName.Name = "txtPatientName";
            txtPatientName.Size = new Size(197, 30);
            txtPatientName.TabIndex = 18;
            // 
            // CreatePrescription
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1198, 735);
            Controls.Add(txtPatientName);
            Controls.Add(lblPatientName);
            Controls.Add(btnBack);
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
        private Button navprofile;
        private Label label2;
        private Button logout;
        private Button navappointment;
        private Button navpatient;
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
        private Button btnBack;
        private Label lblPatientName;
        private TextBox txtPatientName;
        private Button button1;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn ptID;
        private DataGridViewTextBoxColumn PtName;
        private DataGridViewTextBoxColumn disease;
        private DataGridViewTextBoxColumn medicine;
        private DataGridViewButtonColumn UpdateColumn;
    }
}