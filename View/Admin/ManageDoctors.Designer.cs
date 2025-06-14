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
            label3 = new Label();
            label2 = new Label();
            navprofile = new Button();
            logout = new Button();
            navappointment = new Button();
            navpatient = new Button();
            navdoc = new Button();
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
            btnBack = new Button();
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
            sidenav.Controls.Add(label3);
            sidenav.Controls.Add(label2);
            sidenav.Controls.Add(navprofile);
            sidenav.Controls.Add(logout);
            sidenav.Controls.Add(navappointment);
            sidenav.Controls.Add(navpatient);
            sidenav.Controls.Add(navdoc);
            sidenav.Dock = DockStyle.Left;
            sidenav.Location = new Point(0, 0);
            sidenav.Name = "sidenav";
            sidenav.Size = new Size(247, 686);
            sidenav.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(64, 72);
            label3.Name = "label3";
            label3.Size = new Size(126, 23);
            label3.TabIndex = 6;
            label3.Text = "Admin ID-2346";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kristen ITC", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(34, 36);
            label2.Name = "label2";
            label2.Size = new Size(139, 33);
            label2.TabIndex = 5;
            label2.Text = "John Doe";
            // 
            // navprofile
            // 
            navprofile.BackColor = Color.LightSteelBlue;
            navprofile.Location = new Point(26, 510);
            navprofile.Name = "navprofile";
            navprofile.Size = new Size(193, 39);
            navprofile.TabIndex = 4;
            navprofile.Text = "MyProfile";
            navprofile.UseVisualStyleBackColor = false;
            // 
            // logout
            // 
            logout.BackColor = Color.LightSteelBlue;
            logout.Location = new Point(26, 554);
            logout.Name = "logout";
            logout.Size = new Size(193, 40);
            logout.TabIndex = 3;
            logout.Text = "LogOut";
            logout.UseVisualStyleBackColor = false;
            // 
            // navappointment
            // 
            navappointment.BackColor = Color.LightSteelBlue;
            navappointment.Location = new Point(26, 224);
            navappointment.Name = "navappointment";
            navappointment.Size = new Size(193, 43);
            navappointment.TabIndex = 2;
            navappointment.Text = "Appointment Schedules";
            navappointment.UseVisualStyleBackColor = false;
            // 
            // navpatient
            // 
            navpatient.BackColor = Color.LightSteelBlue;
            navpatient.Location = new Point(26, 177);
            navpatient.Name = "navpatient";
            navpatient.Size = new Size(193, 42);
            navpatient.TabIndex = 1;
            navpatient.Text = "Patients";
            navpatient.UseVisualStyleBackColor = false;
            // 
            // navdoc
            // 
            navdoc.BackColor = Color.LightSteelBlue;
            navdoc.Location = new Point(26, 130);
            navdoc.Name = "navdoc";
            navdoc.Size = new Size(193, 41);
            navdoc.TabIndex = 0;
            navdoc.Text = "Doctors";
            navdoc.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = SystemColors.GradientActiveCaption;
            lblTitle.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(588, 26);
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
            txtDocID.Size = new Size(125, 30);
            txtDocID.TabIndex = 10;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(439, 148);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(125, 30);
            txtFullName.TabIndex = 11;
            // 
            // txtSpeciality
            // 
            txtSpeciality.Location = new Point(439, 196);
            txtSpeciality.Name = "txtSpeciality";
            txtSpeciality.Size = new Size(125, 30);
            txtSpeciality.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(439, 251);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 30);
            txtEmail.TabIndex = 13;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(439, 298);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(125, 30);
            txtNumber.TabIndex = 14;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkTurquoise;
            btnAdd.Location = new Point(696, 209);
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
            doctorGridView.Location = new Point(290, 350);
            doctorGridView.Name = "doctorGridView";
            doctorGridView.RowHeadersWidth = 51;
            doctorGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            doctorGridView.Size = new Size(937, 262);
            doctorGridView.TabIndex = 19;
            doctorGridView.CellContentClick += doctorGridView_CellContentClick;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.LightSkyBlue;
            btnBack.Location = new Point(290, 633);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 20;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
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
            ClientSize = new Size(1347, 686);
            Controls.Add(btnBack);
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
        private Label label3;
        private Label label2;
        private Button navprofile;
        private Button logout;
        private Button navappointment;
        private Button navpatient;
        private Button navdoc;
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
        private Button btnBack;
        private DataGridViewTextBoxColumn doctorID;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn docSpecialty;
        private DataGridViewTextBoxColumn emailNo;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewButtonColumn UpdateColumn;
        private DataGridViewButtonColumn DeleteColumn;
    }
}