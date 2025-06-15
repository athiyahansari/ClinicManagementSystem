namespace CMS.View.Patient
{
    partial class Edit_Patient_Profile
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtFirstName = new TextBox();
            txtEmail = new TextBox();
            txtLastName = new TextBox();
            label6 = new Label();
            btnSave = new Button();
            btnPatient = new Button();
            btnCancel = new Button();
            btnLogOut = new Button();
            btnDoctor = new Button();
            btnAppointment = new Button();
            label7 = new Label();
            cmbGender = new ComboBox();
            label8 = new Label();
            dtpDateOfBirth = new DateTimePicker();
            DateOfTime = new Label();
            PhoneNumber = new Label();
            txtPhoneNumber = new TextBox();
            btnMyProfiles = new Button();
            txtPatientId = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.CornflowerBlue;
            pictureBox1.Location = new Point(0, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(227, 564);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.CornflowerBlue;
            label1.Font = new Font("Kristen ITC", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(39, 35);
            label1.Name = "label1";
            label1.Size = new Size(132, 30);
            label1.TabIndex = 1;
            label1.Text = "John Doe";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(397, 104);
            label2.Name = "label2";
            label2.Size = new Size(109, 22);
            label2.TabIndex = 2;
            label2.Text = "First Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(401, 179);
            label4.Name = "label4";
            label4.Size = new Size(105, 22);
            label4.TabIndex = 6;
            label4.Text = "Last Name :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(424, 345);
            label5.Name = "label5";
            label5.Size = new Size(68, 22);
            label5.TabIndex = 8;
            label5.Text = "Email :";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(541, 100);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(240, 30);
            txtFirstName.TabIndex = 9;
            txtFirstName.TextChanged += txtFirstName_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(552, 337);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(240, 30);
            txtEmail.TabIndex = 10;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(541, 175);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(240, 30);
            txtLastName.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.CornflowerBlue;
            label6.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(86, 65);
            label6.Name = "label6";
            label6.Size = new Size(123, 20);
            label6.TabIndex = 13;
            label6.Text = "Admin ID-2346";
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ActiveCaption;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(330, 487);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(144, 43);
            btnSave.TabIndex = 20;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnPatient
            // 
            btnPatient.BackColor = Color.LightSteelBlue;
            btnPatient.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPatient.Location = new Point(39, 239);
            btnPatient.Name = "btnPatient";
            btnPatient.Size = new Size(153, 37);
            btnPatient.TabIndex = 15;
            btnPatient.Text = "Patient";
            btnPatient.UseVisualStyleBackColor = false;
            btnPatient.Click += btnPatient_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ActiveCaption;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(640, 487);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(131, 43);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.LightSteelBlue;
            btnLogOut.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogOut.Location = new Point(39, 463);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(153, 39);
            btnLogOut.TabIndex = 18;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnDoctor
            // 
            btnDoctor.BackColor = Color.LightSteelBlue;
            btnDoctor.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDoctor.Location = new Point(39, 191);
            btnDoctor.Name = "btnDoctor";
            btnDoctor.Size = new Size(153, 42);
            btnDoctor.TabIndex = 21;
            btnDoctor.Text = "Doctors";
            btnDoctor.UseVisualStyleBackColor = false;
            btnDoctor.Click += btnDoctor_Click;
            // 
            // btnAppointment
            // 
            btnAppointment.BackColor = Color.LightSteelBlue;
            btnAppointment.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAppointment.Location = new Point(39, 144);
            btnAppointment.Name = "btnAppointment";
            btnAppointment.Size = new Size(153, 41);
            btnAppointment.TabIndex = 22;
            btnAppointment.Text = "Appointments";
            btnAppointment.UseVisualStyleBackColor = false;
            btnAppointment.Click += button7_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(500, 36);
            label7.Name = "label7";
            label7.Size = new Size(167, 41);
            label7.TabIndex = 23;
            label7.Text = "Edit Profile";
            // 
            // cmbGender
            // 
            cmbGender.DisplayMember = "2";
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(608, 403);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(151, 28);
            cmbGender.TabIndex = 24;
            cmbGender.ValueMember = "2";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(413, 409);
            label8.Name = "label8";
            label8.Size = new Size(79, 22);
            label8.TabIndex = 25;
            label8.Text = "Gender :";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(541, 239);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(250, 27);
            dtpDateOfBirth.TabIndex = 26;
            dtpDateOfBirth.ValueChanged += txtDateOfBirth_ValueChanged;
            // 
            // DateOfTime
            // 
            DateOfTime.AutoSize = true;
            DateOfTime.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DateOfTime.Location = new Point(401, 243);
            DateOfTime.Name = "DateOfTime";
            DateOfTime.Size = new Size(110, 20);
            DateOfTime.TabIndex = 27;
            DateOfTime.Text = "Date Of Time :";
            // 
            // PhoneNumber
            // 
            PhoneNumber.AutoSize = true;
            PhoneNumber.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PhoneNumber.Location = new Point(396, 286);
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Size = new Size(120, 19);
            PhoneNumber.TabIndex = 28;
            PhoneNumber.Text = "Phone Number :";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhoneNumber.Location = new Point(541, 286);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(240, 30);
            txtPhoneNumber.TabIndex = 29;
            // 
            // btnMyProfiles
            // 
            btnMyProfiles.BackColor = Color.LightSteelBlue;
            btnMyProfiles.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMyProfiles.Location = new Point(39, 419);
            btnMyProfiles.Name = "btnMyProfiles";
            btnMyProfiles.Size = new Size(153, 38);
            btnMyProfiles.TabIndex = 17;
            btnMyProfiles.Text = "My Profile";
            btnMyProfiles.UseVisualStyleBackColor = false;
            btnMyProfiles.Click += button4_Click;
            // 
            // txtPatientId
            // 
            txtPatientId.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPatientId.Location = new Point(541, 144);
            txtPatientId.Name = "txtPatientId";
            txtPatientId.Size = new Size(240, 30);
            txtPatientId.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(401, 148);
            label3.Name = "label3";
            label3.Size = new Size(95, 22);
            label3.TabIndex = 31;
            label3.Text = "PatientID :";
            // 
            // Edit_Patient_Profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(910, 560);
            Controls.Add(label3);
            Controls.Add(txtPatientId);
            Controls.Add(txtPhoneNumber);
            Controls.Add(PhoneNumber);
            Controls.Add(DateOfTime);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(label8);
            Controls.Add(cmbGender);
            Controls.Add(label7);
            Controls.Add(btnAppointment);
            Controls.Add(btnDoctor);
            Controls.Add(btnLogOut);
            Controls.Add(btnMyProfiles);
            Controls.Add(btnCancel);
            Controls.Add(btnPatient);
            Controls.Add(btnSave);
            Controls.Add(label6);
            Controls.Add(txtLastName);
            Controls.Add(txtEmail);
            Controls.Add(txtFirstName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Edit_Patient_Profile";
            Text = "Edit_Patient_Profile";
            Load += Edit_Patient_Profile_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox txtFirstName;
        private TextBox txtEmail;
        private TextBox txtLastName;
        private Label label6;
        private Button btnSave;
        private Button btnPatient;
        private Button btnCancel;
        private Button btnMyProfiles;
        private Button btnLogOut;
        private Button btnDoctor;
        private Button btnAppointment;
        private Label label7;
        private ComboBox cmbGender;
        private Label label8;
        private DateTimePicker dtpDateOfBirth;
        private Label DateOfTime;
        private Label PhoneNumber;
        private TextBox txtPhoneNumber;
        private TextBox txtPatientId;
        private Label label3;
        //private Button btnMyProfiles;
    }
}