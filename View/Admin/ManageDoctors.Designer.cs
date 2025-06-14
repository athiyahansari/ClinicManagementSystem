namespace CMS.View.Admin
{
    partial class ManageDoctors
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
            label2 = new Label();
            btnGenerateReport = new Button();
            btnLogout = new Button();
            btnAppointmentSchedule = new Button();
            btnPatients = new Button();
            btnDoctors = new Button();
            lblTitle = new Label();
            lblDocID = new Label();
            lblFullName = new Label();
            lblSpeciality = new Label();
            lblEmail = new Label();
            lblNumber = new Label();
            txtDocID = new TextBox();
            txtFullName = new TextBox();
            txtSpeciality = new TextBox();
            txtEmail = new TextBox();
            txtNumber = new TextBox();
            btnAdd = new Button();
            doctorGridView = new DataGridView();
            doctorID = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            docSpecialty = new DataGridViewTextBoxColumn();
            emailNo = new DataGridViewTextBoxColumn();
            phone = new DataGridViewTextBoxColumn();
            UpdateColumn = new DataGridViewButtonColumn();
            DeleteColumn = new DataGridViewButtonColumn();
            sidenav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)doctorGridView).BeginInit();
            SuspendLayout();
            // 
            // sidenav
            // 
            sidenav.BackColor = Color.CornflowerBlue;
            sidenav.Controls.Add(label2);
            sidenav.Controls.Add(btnGenerateReport);
            sidenav.Controls.Add(btnLogout);
            sidenav.Controls.Add(btnAppointmentSchedule);
            sidenav.Controls.Add(btnPatients);
            sidenav.Controls.Add(btnDoctors);
            sidenav.Dock = DockStyle.Left;
            sidenav.Location = new Point(0, 0);
            sidenav.Name = "sidenav";
            sidenav.Size = new Size(247, 716);
            sidenav.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kristen ITC", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightCyan;
            label2.Location = new Point(12, 49);
            label2.Name = "label2";
            label2.Size = new Size(209, 33);
            label2.TabIndex = 5;
            label2.Text = "MedLine Clinic";
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.BackColor = Color.LightSteelBlue;
            btnGenerateReport.Location = new Point(26, 510);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(193, 39);
            btnGenerateReport.TabIndex = 4;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.LightSteelBlue;
            btnLogout.Location = new Point(26, 554);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(193, 40);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "LogOut";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnAppointmentSchedule
            // 
            btnAppointmentSchedule.BackColor = Color.LightSteelBlue;
            btnAppointmentSchedule.Location = new Point(26, 224);
            btnAppointmentSchedule.Name = "btnAppointmentSchedule";
            btnAppointmentSchedule.Size = new Size(193, 43);
            btnAppointmentSchedule.TabIndex = 2;
            btnAppointmentSchedule.Text = "Appointment Schedule";
            btnAppointmentSchedule.UseVisualStyleBackColor = false;
            // 
            // btnPatients
            // 
            btnPatients.BackColor = Color.LightSteelBlue;
            btnPatients.Location = new Point(26, 177);
            btnPatients.Name = "btnPatients";
            btnPatients.Size = new Size(193, 42);
            btnPatients.TabIndex = 1;
            btnPatients.Text = "Patients";
            btnPatients.UseVisualStyleBackColor = false;
            // 
            // btnDoctors
            // 
            btnDoctors.BackColor = Color.LightSteelBlue;
            btnDoctors.Location = new Point(26, 130);
            btnDoctors.Name = "btnDoctors";
            btnDoctors.Size = new Size(193, 41);
            btnDoctors.TabIndex = 0;
            btnDoctors.Text = "Doctors";
            btnDoctors.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = SystemColors.GradientActiveCaption;
            lblTitle.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(668, 28);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(252, 41);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Manage Doctors";
            // 
            // lblDocID
            // 
            lblDocID.AutoSize = true;
            lblDocID.Location = new Point(311, 102);
            lblDocID.Name = "lblDocID";
            lblDocID.Size = new Size(93, 23);
            lblDocID.TabIndex = 5;
            lblDocID.Text = "Doctor ID :";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(311, 148);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(96, 23);
            lblFullName.TabIndex = 6;
            lblFullName.Text = "Full Name :";
            // 
            // lblSpeciality
            // 
            lblSpeciality.AutoSize = true;
            lblSpeciality.Location = new Point(311, 199);
            lblSpeciality.Name = "lblSpeciality";
            lblSpeciality.Size = new Size(90, 23);
            lblSpeciality.TabIndex = 7;
            lblSpeciality.Text = "Speciality :";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(311, 254);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(60, 23);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email :";
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Location = new Point(311, 305);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(96, 23);
            lblNumber.TabIndex = 9;
            lblNumber.Text = "Phone No :";
            // 
            // txtDocID
            // 
            txtDocID.Location = new Point(439, 102);
            txtDocID.Name = "txtDocID";
            txtDocID.Size = new Size(331, 30);
            txtDocID.TabIndex = 10;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(439, 148);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(331, 30);
            txtFullName.TabIndex = 11;
            // 
            // txtSpeciality
            // 
            txtSpeciality.Location = new Point(439, 196);
            txtSpeciality.Name = "txtSpeciality";
            txtSpeciality.Size = new Size(331, 30);
            txtSpeciality.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(439, 251);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(331, 30);
            txtEmail.TabIndex = 13;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(439, 298);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(331, 30);
            txtNumber.TabIndex = 14;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkTurquoise;
            btnAdd.Location = new Point(439, 357);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(175, 29);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Add New Doctor";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // doctorGridView
            // 
            doctorGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            doctorGridView.BackgroundColor = SystemColors.ButtonHighlight;
            doctorGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            doctorGridView.Columns.AddRange(new DataGridViewColumn[] { doctorID, name, docSpecialty, emailNo, phone, UpdateColumn, DeleteColumn });
            doctorGridView.Location = new Point(311, 424);
            doctorGridView.Name = "doctorGridView";
            doctorGridView.RowHeadersWidth = 51;
            doctorGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            doctorGridView.Size = new Size(937, 262);
            doctorGridView.TabIndex = 19;
            doctorGridView.CellContentClick += doctorGridView_CellContentClick;
            // 
            // doctorID
            // 
            doctorID.HeaderText = "Doctor ID";
            doctorID.MinimumWidth = 6;
            doctorID.Name = "doctorID";
            // 
            // name
            // 
            name.HeaderText = "Full Name";
            name.MinimumWidth = 6;
            name.Name = "name";
            // 
            // docSpecialty
            // 
            docSpecialty.HeaderText = "Speciality";
            docSpecialty.MinimumWidth = 6;
            docSpecialty.Name = "docSpecialty";
            // 
            // emailNo
            // 
            emailNo.HeaderText = "Email";
            emailNo.MinimumWidth = 6;
            emailNo.Name = "emailNo";
            // 
            // phone
            // 
            phone.HeaderText = "Phone No";
            phone.MinimumWidth = 6;
            phone.Name = "phone";
            // 
            // UpdateColumn
            // 
            UpdateColumn.HeaderText = "Update";
            UpdateColumn.MinimumWidth = 6;
            UpdateColumn.Name = "UpdateColumn";
            UpdateColumn.Text = "Update";
            UpdateColumn.UseColumnTextForButtonValue = true;
            // 
            // DeleteColumn
            // 
            DeleteColumn.HeaderText = "Delete";
            DeleteColumn.MinimumWidth = 6;
            DeleteColumn.Name = "DeleteColumn";
            DeleteColumn.Text = "Delete";
            DeleteColumn.UseColumnTextForButtonValue = true;
            // 
            // ManageDoctors
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1301, 716);
            Controls.Add(doctorGridView);
            Controls.Add(btnAdd);
            Controls.Add(txtNumber);
            Controls.Add(txtEmail);
            Controls.Add(txtSpeciality);
            Controls.Add(txtFullName);
            Controls.Add(txtDocID);
            Controls.Add(lblNumber);
            Controls.Add(lblEmail);
            Controls.Add(lblSpeciality);
            Controls.Add(lblFullName);
            Controls.Add(lblDocID);
            Controls.Add(lblTitle);
            Controls.Add(sidenav);
            Name = "ManageDoctors";
            Text = "ManageDoctors";
            sidenav.ResumeLayout(false);
            sidenav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)doctorGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel sidenav;
        private Label label2;
        private Button btnGenerateReport;
        private Button btnLogout;
        private Button btnAppointmentSchedule;
        private Button btnPatients;
        private Button btnDoctors;
        private Label lblTitle;
        private Label lblDocID;
        private Label lblFullName;
        private Label lblSpeciality;
        private Label lblEmail;
        private Label lblNumber;
        private TextBox txtDocID;
        private TextBox txtFullName;
        private TextBox txtSpeciality;
        private TextBox txtEmail;
        private TextBox txtNumber;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView doctorGridView;
        private DataGridViewTextBoxColumn docspecilaity;
        private DataGridViewTextBoxColumn doctorID;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn docSpecialty;
        private DataGridViewTextBoxColumn emailNo;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewButtonColumn UpdateColumn;
        private DataGridViewButtonColumn DeleteColumn;
    }
}