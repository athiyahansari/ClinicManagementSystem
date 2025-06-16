namespace CMS.View
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel2 = new Panel();
            label2 = new Label();
            txtDoctorPassword = new TextBox();
            btnDoctorLogin = new Button();
            txtDoctorUsername = new TextBox();
            label3 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            panel1 = new Panel();
            btnRegisterNewPatient = new Button();
            newPatient = new LinkLabel();
            btnPatientLogin = new Button();
            label11 = new Label();
            txtPatientPassword = new TextBox();
            label8 = new Label();
            txtPatientUsername = new TextBox();
            label1 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            btnAdminLogin = new Button();
            label12 = new Label();
            txtAdminPassword = new TextBox();
            label9 = new Label();
            txtAdminUsername = new TextBox();
            label7 = new Label();
            label10 = new Label();
            pictureBox3 = new PictureBox();
            NAME = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.AccessibleName = "panelDoctor";
            panel2.BackColor = Color.MintCream;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtDoctorPassword);
            panel2.Controls.Add(btnDoctorLogin);
            panel2.Controls.Add(txtDoctorUsername);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(24, 65);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(234, 292);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 191);
            label2.Name = "label2";
            label2.Size = new Size(85, 19);
            label2.TabIndex = 6;
            label2.Text = "Password:";
            // 
            // txtDoctorPassword
            // 
            txtDoctorPassword.Location = new Point(100, 191);
            txtDoctorPassword.Margin = new Padding(3, 2, 3, 2);
            txtDoctorPassword.Name = "txtDoctorPassword";
            txtDoctorPassword.Size = new Size(98, 23);
            txtDoctorPassword.TabIndex = 3;
            txtDoctorPassword.UseSystemPasswordChar = true;
            // 
            // btnDoctorLogin
            // 
            btnDoctorLogin.BackColor = Color.LightSkyBlue;
            btnDoctorLogin.FlatStyle = FlatStyle.Flat;
            btnDoctorLogin.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDoctorLogin.ForeColor = Color.FromArgb(0, 0, 192);
            btnDoctorLogin.Location = new Point(76, 232);
            btnDoctorLogin.Margin = new Padding(3, 2, 3, 2);
            btnDoctorLogin.Name = "btnDoctorLogin";
            btnDoctorLogin.Size = new Size(74, 19);
            btnDoctorLogin.TabIndex = 7;
            btnDoctorLogin.Text = "LOG IN";
            btnDoctorLogin.UseVisualStyleBackColor = false;
            btnDoctorLogin.Click += btnDoctorLogin_Click;
            // 
            // txtDoctorUsername
            // 
            txtDoctorUsername.Location = new Point(100, 151);
            txtDoctorUsername.Margin = new Padding(3, 2, 3, 2);
            txtDoctorUsername.Name = "txtDoctorUsername";
            txtDoctorUsername.Size = new Size(98, 23);
            txtDoctorUsername.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Cyan;
            label3.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(56, 82);
            label3.Name = "label3";
            label3.Size = new Size(108, 26);
            label3.TabIndex = 2;
            label3.Text = "DOCTOR";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(66, 62);
            label4.Name = "label4";
            label4.Size = new Size(100, 25);
            label4.TabIndex = 1;
            label4.Text = "LOGIN AS";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.MintCream;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(66, 10);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(97, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(10, 151);
            label5.Name = "label5";
            label5.Size = new Size(88, 19);
            label5.TabIndex = 5;
            label5.Text = "Username:";
            // 
            // panel1
            // 
            panel1.AccessibleName = "panelPatient";
            panel1.BackColor = Color.MintCream;
            panel1.Controls.Add(btnRegisterNewPatient);
            panel1.Controls.Add(newPatient);
            panel1.Controls.Add(btnPatientLogin);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(txtPatientPassword);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtPatientUsername);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(290, 65);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(234, 292);
            panel1.TabIndex = 3;
            // 
            // btnRegisterNewPatient
            // 
            btnRegisterNewPatient.BackColor = Color.Turquoise;
            btnRegisterNewPatient.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegisterNewPatient.Location = new Point(140, 266);
            btnRegisterNewPatient.Margin = new Padding(3, 2, 3, 2);
            btnRegisterNewPatient.Name = "btnRegisterNewPatient";
            btnRegisterNewPatient.Size = new Size(74, 19);
            btnRegisterNewPatient.TabIndex = 10;
            btnRegisterNewPatient.Text = "SIGN UP";
            btnRegisterNewPatient.UseVisualStyleBackColor = false;
            btnRegisterNewPatient.Click += signUpbtn_Click;
            // 
            // newPatient
            // 
            newPatient.AutoSize = true;
            newPatient.Location = new Point(11, 270);
            newPatient.Name = "newPatient";
            newPatient.Size = new Size(76, 15);
            newPatient.TabIndex = 9;
            newPatient.TabStop = true;
            newPatient.Text = "New Patient?";
            // 
            // btnPatientLogin
            // 
            btnPatientLogin.BackColor = Color.LightSkyBlue;
            btnPatientLogin.FlatStyle = FlatStyle.Flat;
            btnPatientLogin.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPatientLogin.ForeColor = Color.FromArgb(0, 0, 192);
            btnPatientLogin.Location = new Point(79, 232);
            btnPatientLogin.Margin = new Padding(3, 2, 3, 2);
            btnPatientLogin.Name = "btnPatientLogin";
            btnPatientLogin.Size = new Size(74, 19);
            btnPatientLogin.TabIndex = 8;
            btnPatientLogin.Text = "LOG IN";
            btnPatientLogin.UseVisualStyleBackColor = false;
            btnPatientLogin.Click += btnPatientLogin_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(13, 190);
            label11.Name = "label11";
            label11.Size = new Size(85, 19);
            label11.TabIndex = 6;
            label11.Text = "Password:";
            // 
            // txtPatientPassword
            // 
            txtPatientPassword.Location = new Point(103, 190);
            txtPatientPassword.Margin = new Padding(3, 2, 3, 2);
            txtPatientPassword.Name = "txtPatientPassword";
            txtPatientPassword.Size = new Size(98, 23);
            txtPatientPassword.TabIndex = 5;
            txtPatientPassword.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(13, 151);
            label8.Name = "label8";
            label8.Size = new Size(88, 19);
            label8.TabIndex = 4;
            label8.Text = "Username:";
            // 
            // txtPatientUsername
            // 
            txtPatientUsername.Location = new Point(103, 147);
            txtPatientUsername.Margin = new Padding(3, 2, 3, 2);
            txtPatientUsername.Name = "txtPatientUsername";
            txtPatientUsername.Size = new Size(98, 23);
            txtPatientUsername.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Cyan;
            label1.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(60, 82);
            label1.Name = "label1";
            label1.Size = new Size(110, 26);
            label1.TabIndex = 2;
            label1.Text = "PATIENT";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(66, 62);
            label6.Name = "label6";
            label6.Size = new Size(100, 25);
            label6.TabIndex = 1;
            label6.Text = "LOGIN AS";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.Click += label6_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(60, 10);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(97, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.AccessibleName = "panelAdmin";
            panel3.BackColor = Color.MintCream;
            panel3.Controls.Add(btnAdminLogin);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(txtAdminPassword);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(txtAdminUsername);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(558, 65);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(234, 292);
            panel3.TabIndex = 4;
            // 
            // btnAdminLogin
            // 
            btnAdminLogin.BackColor = Color.LightSkyBlue;
            btnAdminLogin.FlatStyle = FlatStyle.Flat;
            btnAdminLogin.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminLogin.ForeColor = Color.FromArgb(0, 0, 192);
            btnAdminLogin.Location = new Point(80, 232);
            btnAdminLogin.Margin = new Padding(3, 2, 3, 2);
            btnAdminLogin.Name = "btnAdminLogin";
            btnAdminLogin.Size = new Size(74, 19);
            btnAdminLogin.TabIndex = 9;
            btnAdminLogin.Text = "LOG IN";
            btnAdminLogin.UseVisualStyleBackColor = false;
            btnAdminLogin.Click += btnAdminLogin_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(10, 190);
            label12.Name = "label12";
            label12.Size = new Size(85, 19);
            label12.TabIndex = 6;
            label12.Text = "Password:";
            // 
            // txtAdminPassword
            // 
            txtAdminPassword.Location = new Point(100, 188);
            txtAdminPassword.Margin = new Padding(3, 2, 3, 2);
            txtAdminPassword.Name = "txtAdminPassword";
            txtAdminPassword.Size = new Size(98, 23);
            txtAdminPassword.TabIndex = 5;
            txtAdminPassword.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(10, 147);
            label9.Name = "label9";
            label9.Size = new Size(88, 19);
            label9.TabIndex = 4;
            label9.Text = "Username:";
            // 
            // txtAdminUsername
            // 
            txtAdminUsername.Location = new Point(100, 146);
            txtAdminUsername.Margin = new Padding(3, 2, 3, 2);
            txtAdminUsername.Name = "txtAdminUsername";
            txtAdminUsername.Size = new Size(98, 23);
            txtAdminUsername.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Cyan;
            label7.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(70, 82);
            label7.Name = "label7";
            label7.Size = new Size(86, 26);
            label7.TabIndex = 2;
            label7.Text = "ADMIN";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(70, 62);
            label10.Name = "label10";
            label10.Size = new Size(100, 25);
            label10.TabIndex = 1;
            label10.Text = "LOGIN AS";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(65, 10);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(97, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // NAME
            // 
            NAME.AutoSize = true;
            NAME.BackColor = Color.Turquoise;
            NAME.FlatStyle = FlatStyle.Popup;
            NAME.Font = new Font("Stencil", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NAME.ForeColor = Color.Black;
            NAME.Location = new Point(214, 15);
            NAME.Name = "NAME";
            NAME.Size = new Size(460, 35);
            NAME.TabIndex = 5;
            NAME.Text = "WELCOME TO MEDLINE CLINIC";
            NAME.TextAlign = ContentAlignment.TopCenter;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(820, 394);
            Controls.Add(NAME);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private TextBox txtDoctorPassword;
        private Button btnDoctorLogin;
        private TextBox txtDoctorUsername;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox2;
        private Label label5;
        private Panel panel1;
        private Button btnPatientLogin;
        private Label label11;
        private TextBox txtPatientPassword;
        private Label label8;
        private TextBox txtPatientUsername;
        private Label label1;
        private Label label6;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Button btnAdminLogin;
        private Label label12;
        private TextBox txtAdminPassword;
        private Label label9;
        private TextBox txtAdminUsername;
        private Label label7;
        private Label label10;
        private PictureBox pictureBox3;
        private Label NAME;
        private Button btnRegisterNewPatient;
        private LinkLabel newPatient;
    }
}