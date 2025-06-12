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
            fullName = new Label();
            emailAddress = new Label();
            phoneNumber = new Label();
            age = new Label();
            gender = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            gendercombobox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            password = new TextBox();
            confirmpassword = new TextBox();
            panel1 = new Panel();
            register = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // patientRegister
            // 
            patientRegister.AutoSize = true;
            patientRegister.BackColor = Color.Turquoise;
            patientRegister.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            patientRegister.ForeColor = SystemColors.ActiveCaptionText;
            patientRegister.Location = new Point(46, 24);
            patientRegister.Name = "patientRegister";
            patientRegister.Size = new Size(337, 46);
            patientRegister.TabIndex = 0;
            patientRegister.Text = "Patient Registration";
            patientRegister.Click += patientRegister_Click;
            // 
            // fullName
            // 
            fullName.AutoSize = true;
            fullName.BackColor = Color.MediumTurquoise;
            fullName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fullName.ForeColor = Color.Black;
            fullName.Location = new Point(37, 19);
            fullName.Name = "fullName";
            fullName.Size = new Size(97, 23);
            fullName.TabIndex = 1;
            fullName.Text = "Full Name :";
            // 
            // emailAddress
            // 
            emailAddress.AutoSize = true;
            emailAddress.BackColor = Color.MediumTurquoise;
            emailAddress.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailAddress.Location = new Point(40, 102);
            emailAddress.Name = "emailAddress";
            emailAddress.Size = new Size(125, 23);
            emailAddress.TabIndex = 2;
            emailAddress.Text = "Email Address :";
            emailAddress.Click += emailAddress_Click;
            // 
            // phoneNumber
            // 
            phoneNumber.AutoSize = true;
            phoneNumber.BackColor = Color.MediumTurquoise;
            phoneNumber.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            phoneNumber.Location = new Point(40, 189);
            phoneNumber.Name = "phoneNumber";
            phoneNumber.Size = new Size(136, 23);
            phoneNumber.TabIndex = 3;
            phoneNumber.Text = "Phone Number :";
            // 
            // age
            // 
            age.AutoSize = true;
            age.BackColor = Color.MediumTurquoise;
            age.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            age.Location = new Point(40, 280);
            age.Name = "age";
            age.Size = new Size(49, 23);
            age.TabIndex = 4;
            age.Text = "Age :";
            // 
            // gender
            // 
            gender.AutoSize = true;
            gender.BackColor = Color.MediumTurquoise;
            gender.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gender.Location = new Point(320, 279);
            gender.Name = "gender";
            gender.Size = new Size(75, 23);
            gender.TabIndex = 5;
            gender.Text = "Gender :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(37, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(383, 30);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(40, 215);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(192, 30);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(40, 128);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(383, 30);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(95, 276);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 30);
            textBox4.TabIndex = 9;
            // 
            // gendercombobox
            // 
            gendercombobox.FormattingEnabled = true;
            gendercombobox.Items.AddRange(new object[] { "Male", "Female" });
            gendercombobox.Location = new Point(401, 275);
            gendercombobox.Name = "gendercombobox";
            gendercombobox.Size = new Size(151, 31);
            gendercombobox.TabIndex = 10;
            gendercombobox.Text = "Select";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MediumTurquoise;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 347);
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
            label2.Location = new Point(40, 413);
            label2.Name = "label2";
            label2.Size = new Size(158, 23);
            label2.TabIndex = 12;
            label2.Text = "Confirm Password :";
            // 
            // password
            // 
            password.Location = new Point(140, 344);
            password.Name = "password";
            password.Size = new Size(207, 30);
            password.TabIndex = 13;
            // 
            // confirmpassword
            // 
            confirmpassword.Location = new Point(204, 410);
            confirmpassword.Name = "confirmpassword";
            confirmpassword.Size = new Size(191, 30);
            confirmpassword.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(gender);
            panel1.Controls.Add(gendercombobox);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(confirmpassword);
            panel1.Controls.Add(age);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(phoneNumber);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(password);
            panel1.Controls.Add(emailAddress);
            panel1.Controls.Add(fullName);
            panel1.Location = new Point(46, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(968, 471);
            panel1.TabIndex = 15;
            // 
            // register
            // 
            register.BackColor = Color.LightSkyBlue;
            register.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            register.Location = new Point(273, 600);
            register.Name = "register";
            register.Size = new Size(149, 49);
            register.TabIndex = 16;
            register.Text = "Register";
            register.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSkyBlue;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(619, 600);
            button1.Name = "button1";
            button1.Size = new Size(149, 49);
            button1.TabIndex = 17;
            button1.Text = "Back to Login";
            button1.UseVisualStyleBackColor = false;
            // 
            // NewPatient
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 667);
            Controls.Add(button1);
            Controls.Add(register);
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
        private Label fullName;
        private Label emailAddress;
        private Label phoneNumber;
        private Label age;
        private Label gender;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private ComboBox gendercombobox;
        private Label label1;
        private Label label2;
        private TextBox password;
        private TextBox confirmpassword;
        private Panel panel1;
        private Button register;
        private Button button1;
    }
}