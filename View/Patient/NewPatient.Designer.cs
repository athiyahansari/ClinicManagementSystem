namespace CMS.View.Patient
{
    partial class NewPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPatient));
            patientRegister = new Label();
            FirstName = new Label();
            emailAddress = new Label();
            PhoneNumber = new Label();
            DateOfBirth = new Label();
            gender = new Label();
            txtFirstName = new TextBox();
            txtPhoneNumber = new TextBox();
            txtEmail = new TextBox();
            cmbGender = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            panel1 = new Panel();
            DateTimeDOB = new DateTimePicker();
            txtLastName = new TextBox();
            LastName = new Label();
            btnRegister = new Button();
            btnBackToLogin = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // patientRegister
            // 
            patientRegister.AutoSize = true;
            patientRegister.BackColor = Color.Turquoise;
            patientRegister.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            patientRegister.ForeColor = SystemColors.ActiveCaptionText;
            patientRegister.Location = new Point(41, 21);
            patientRegister.Name = "patientRegister";
            patientRegister.Size = new Size(337, 46);
            patientRegister.TabIndex = 0;
            patientRegister.Text = "Patient Registration";
            patientRegister.Click += patientRegister_Click;
            // 
            // FirstName
            // 
            FirstName.AutoSize = true;
            FirstName.BackColor = Color.MediumTurquoise;
            FirstName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FirstName.ForeColor = Color.Black;
            FirstName.Location = new Point(33, 17);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(102, 23);
            FirstName.TabIndex = 1;
            FirstName.Text = "First Name :";
            // 
            // emailAddress
            // 
            emailAddress.AutoSize = true;
            emailAddress.BackColor = Color.MediumTurquoise;
            emailAddress.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailAddress.Location = new Point(36, 89);
            emailAddress.Name = "emailAddress";
            emailAddress.Size = new Size(125, 23);
            emailAddress.TabIndex = 2;
            emailAddress.Text = "Email Address :";
            emailAddress.Click += emailAddress_Click;
            // 
            // PhoneNumber
            // 
            PhoneNumber.AutoSize = true;
            PhoneNumber.BackColor = Color.MediumTurquoise;
            PhoneNumber.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PhoneNumber.Location = new Point(36, 164);
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Size = new Size(136, 23);
            PhoneNumber.TabIndex = 3;
            PhoneNumber.Text = "Phone Number :";
            // 
            // DateOfBirth
            // 
            DateOfBirth.AutoSize = true;
            DateOfBirth.BackColor = Color.MediumTurquoise;
            DateOfBirth.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DateOfBirth.Location = new Point(36, 243);
            DateOfBirth.Name = "DateOfBirth";
            DateOfBirth.Size = new Size(117, 23);
            DateOfBirth.TabIndex = 4;
            DateOfBirth.Text = "Date of Birth :";
            // 
            // gender
            // 
            gender.AutoSize = true;
            gender.BackColor = Color.MediumTurquoise;
            gender.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gender.Location = new Point(451, 239);
            gender.Name = "gender";
            gender.Size = new Size(75, 23);
            gender.TabIndex = 5;
            gender.Text = "Gender :";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(33, 39);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(196, 27);
            txtFirstName.TabIndex = 6;
            txtFirstName.TextChanged += txtFirstName_TextChanged;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(36, 187);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(171, 27);
            txtPhoneNumber.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(36, 111);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(341, 27);
            txtEmail.TabIndex = 8;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(532, 239);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(135, 28);
            cmbGender.TabIndex = 10;
            cmbGender.Text = "Select";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MediumTurquoise;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 302);
            label1.Name = "label1";
            label1.Size = new Size(98, 23);
            label1.TabIndex = 11;
            label1.Text = "Passsword :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MediumTurquoise;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(36, 359);
            label2.Name = "label2";
            label2.Size = new Size(158, 23);
            label2.TabIndex = 12;
            label2.Text = "Confirm Password :";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(135, 299);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(184, 27);
            txtPassword.TabIndex = 13;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(181, 357);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(170, 27);
            txtConfirmPassword.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(DateTimeDOB);
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(LastName);
            panel1.Controls.Add(gender);
            panel1.Controls.Add(cmbGender);
            panel1.Controls.Add(txtConfirmPassword);
            panel1.Controls.Add(DateOfBirth);
            panel1.Controls.Add(txtPhoneNumber);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(PhoneNumber);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtFirstName);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(emailAddress);
            panel1.Controls.Add(FirstName);
            panel1.Location = new Point(41, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(860, 410);
            panel1.TabIndex = 15;
            // 
            // DateTimeDOB
            // 
            DateTimeDOB.Location = new Point(159, 240);
            DateTimeDOB.Name = "DateTimeDOB";
            DateTimeDOB.Size = new Size(250, 27);
            DateTimeDOB.TabIndex = 17;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(308, 36);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(203, 27);
            txtLastName.TabIndex = 16;
            // 
            // LastName
            // 
            LastName.AutoSize = true;
            LastName.BackColor = Color.MediumTurquoise;
            LastName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LastName.ForeColor = Color.Black;
            LastName.Location = new Point(308, 14);
            LastName.Name = "LastName";
            LastName.Size = new Size(100, 23);
            LastName.TabIndex = 15;
            LastName.Text = "Last Name :";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.LightSkyBlue;
            btnRegister.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(246, 522);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(132, 43);
            btnRegister.TabIndex = 16;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnBackToLogin
            // 
            btnBackToLogin.BackColor = Color.LightSkyBlue;
            btnBackToLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackToLogin.Location = new Point(550, 522);
            btnBackToLogin.Name = "btnBackToLogin";
            btnBackToLogin.Size = new Size(132, 43);
            btnBackToLogin.TabIndex = 17;
            btnBackToLogin.Text = "Back to Login";
            btnBackToLogin.UseVisualStyleBackColor = false;
            btnBackToLogin.Click += btnBackToLogin_Click;
            // 
            // NewPatient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 580);
            Controls.Add(btnBackToLogin);
            Controls.Add(btnRegister);
            Controls.Add(patientRegister);
            Controls.Add(panel1);
            Name = "NewPatient";
            Text = "NewPatient";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label patientRegister;
        private Label FirstName;
        private Label emailAddress;
        private Label PhoneNumber;
        private Label DateOfBirth;
        private Label gender;
        private TextBox txtFirstName;
        private TextBox txtPhoneNumber;
        private TextBox txtEmail;
        private ComboBox cmbGender;
        private Label label1;
        private Label label2;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private Panel panel1;
        private Button btnRegister;
        private Button btnBackToLogin;
        private TextBox txtLastName;
        private Label LastName;
        private DateTimePicker DateTimeDOB;
    }
}