namespace CMS.View.Patient
{
    partial class PatientDashboard
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
            navmedicalhistory = new Button();
            label2 = new Label();
            navprofile = new Button();
            logout = new Button();
            navprescription = new Button();
            navappointment = new Button();
            navdoc = new Button();
            welcome_msg = new Label();
            dash_medicalhistory = new LinkLabel();
            dash_upcomingappointments = new LinkLabel();
            dash_prescriptions = new LinkLabel();
            dash_newdoctors = new LinkLabel();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            sidenav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // sidenav
            // 
            sidenav.BackColor = Color.CornflowerBlue;
            sidenav.Controls.Add(navmedicalhistory);
            sidenav.Controls.Add(label2);
            sidenav.Controls.Add(navprofile);
            sidenav.Controls.Add(logout);
            sidenav.Controls.Add(navprescription);
            sidenav.Controls.Add(navappointment);
            sidenav.Controls.Add(navdoc);
            sidenav.Dock = DockStyle.Left;
            sidenav.Location = new Point(0, 0);
            sidenav.Name = "sidenav";
            sidenav.Size = new Size(274, 720);
            sidenav.TabIndex = 0;
            // 
            // navmedicalhistory
            // 
            navmedicalhistory.BackColor = Color.LightSteelBlue;
            navmedicalhistory.Location = new Point(49, 301);
            navmedicalhistory.Name = "navmedicalhistory";
            navmedicalhistory.Size = new Size(178, 48);
            navmedicalhistory.TabIndex = 5;
            navmedicalhistory.Text = "Medical History";
            navmedicalhistory.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kristen ITC", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(20, 59);
            label2.Name = "label2";
            label2.Size = new Size(246, 39);
            label2.TabIndex = 21;
            label2.Text = "MedLine Clinic";
            // 
            // navprofile
            // 
            navprofile.BackColor = Color.LightSteelBlue;
            navprofile.Location = new Point(49, 551);
            navprofile.Name = "navprofile";
            navprofile.Size = new Size(178, 49);
            navprofile.TabIndex = 4;
            navprofile.Text = "MyProfile";
            navprofile.UseVisualStyleBackColor = false;
            // 
            // logout
            // 
            logout.BackColor = Color.LightSteelBlue;
            logout.Location = new Point(49, 606);
            logout.Name = "logout";
            logout.Size = new Size(178, 46);
            logout.TabIndex = 3;
            logout.Text = "LogOut";
            logout.UseVisualStyleBackColor = false;
            // 
            // navprescription
            // 
            navprescription.BackColor = Color.LightSteelBlue;
            navprescription.Location = new Point(49, 248);
            navprescription.Name = "navprescription";
            navprescription.Size = new Size(178, 47);
            navprescription.TabIndex = 2;
            navprescription.Text = "Prescriptions";
            navprescription.UseVisualStyleBackColor = false;
            // 
            // navappointment
            // 
            navappointment.BackColor = Color.LightSteelBlue;
            navappointment.Location = new Point(49, 196);
            navappointment.Name = "navappointment";
            navappointment.Size = new Size(178, 46);
            navappointment.TabIndex = 1;
            navappointment.Text = "Appointment";
            navappointment.UseVisualStyleBackColor = false;
            // 
            // navdoc
            // 
            navdoc.BackColor = Color.LightSteelBlue;
            navdoc.Location = new Point(49, 147);
            navdoc.Name = "navdoc";
            navdoc.Size = new Size(178, 43);
            navdoc.TabIndex = 0;
            navdoc.Text = "Doctor";
            navdoc.UseVisualStyleBackColor = false;
            // 
            // welcome_msg
            // 
            welcome_msg.AutoSize = true;
            welcome_msg.BackColor = Color.Transparent;
            welcome_msg.Font = new Font("Lucida Bright", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcome_msg.Location = new Point(57, 46);
            welcome_msg.Name = "welcome_msg";
            welcome_msg.Size = new Size(369, 62);
            welcome_msg.TabIndex = 1;
            welcome_msg.Text = "Welcome back, John Doe!\r\n\r\n";
            // 
            // dash_medicalhistory
            // 
            dash_medicalhistory.ActiveLinkColor = SystemColors.ActiveCaptionText;
            dash_medicalhistory.AutoSize = true;
            dash_medicalhistory.BackColor = Color.Transparent;
            dash_medicalhistory.Font = new Font("Yu Gothic UI", 10F);
            dash_medicalhistory.LinkBehavior = LinkBehavior.NeverUnderline;
            dash_medicalhistory.LinkColor = Color.Black;
            dash_medicalhistory.Location = new Point(639, 432);
            dash_medicalhistory.Name = "dash_medicalhistory";
            dash_medicalhistory.Size = new Size(182, 28);
            dash_medicalhistory.TabIndex = 20;
            dash_medicalhistory.TabStop = true;
            dash_medicalhistory.Text = "My Medical History";
            // 
            // dash_upcomingappointments
            // 
            dash_upcomingappointments.ActiveLinkColor = SystemColors.ActiveCaptionText;
            dash_upcomingappointments.AutoSize = true;
            dash_upcomingappointments.BackColor = Color.Transparent;
            dash_upcomingappointments.Font = new Font("Yu Gothic UI", 10F);
            dash_upcomingappointments.LinkBehavior = LinkBehavior.NeverUnderline;
            dash_upcomingappointments.LinkColor = Color.Black;
            dash_upcomingappointments.Location = new Point(639, 324);
            dash_upcomingappointments.Name = "dash_upcomingappointments";
            dash_upcomingappointments.Size = new Size(234, 28);
            dash_upcomingappointments.TabIndex = 19;
            dash_upcomingappointments.TabStop = true;
            dash_upcomingappointments.Text = "Upcoming Appointments";
            // 
            // dash_prescriptions
            // 
            dash_prescriptions.ActiveLinkColor = SystemColors.ActiveCaptionText;
            dash_prescriptions.AutoSize = true;
            dash_prescriptions.BackColor = Color.Transparent;
            dash_prescriptions.Font = new Font("Yu Gothic UI", 10F);
            dash_prescriptions.LinkBehavior = LinkBehavior.NeverUnderline;
            dash_prescriptions.LinkColor = Color.Black;
            dash_prescriptions.Location = new Point(213, 432);
            dash_prescriptions.Name = "dash_prescriptions";
            dash_prescriptions.Size = new Size(157, 28);
            dash_prescriptions.TabIndex = 18;
            dash_prescriptions.TabStop = true;
            dash_prescriptions.Text = "My Prescriptions";
            // 
            // dash_newdoctors
            // 
            dash_newdoctors.ActiveLinkColor = SystemColors.ActiveCaptionText;
            dash_newdoctors.AutoSize = true;
            dash_newdoctors.BackColor = Color.Transparent;
            dash_newdoctors.Font = new Font("Yu Gothic UI", 10F);
            dash_newdoctors.LinkBehavior = LinkBehavior.NeverUnderline;
            dash_newdoctors.LinkColor = Color.Black;
            dash_newdoctors.Location = new Point(213, 324);
            dash_newdoctors.Name = "dash_newdoctors";
            dash_newdoctors.Size = new Size(151, 28);
            dash_newdoctors.TabIndex = 17;
            dash_newdoctors.TabStop = true;
            dash_newdoctors.Text = "Explore Doctors";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.medical_history_icon;
            pictureBox4.Location = new Point(552, 418);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(72, 62);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.upcomingappointments_icon;
            pictureBox2.Location = new Point(552, 307);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(72, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.prescription_icon;
            pictureBox3.Location = new Point(124, 418);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(72, 62);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = Properties.Resources.doctor_icon;
            pictureBox1.Location = new Point(124, 307);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.dashboard_bg;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(dash_medicalhistory);
            panel1.Controls.Add(dash_upcomingappointments);
            panel1.Controls.Add(dash_prescriptions);
            panel1.Controls.Add(dash_newdoctors);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(welcome_msg);
            panel1.Location = new Point(272, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1056, 721);
            panel1.TabIndex = 21;
            // 
            // PatientDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1328, 720);
            Controls.Add(panel1);
            Controls.Add(sidenav);
            Name = "PatientDashboard";
            Text = "PatientDashboard";
            sidenav.ResumeLayout(false);
            sidenav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel sidenav;
        private Button navdoc;
        private Button navprescription;
        private Button navappointment;
        private Button logout;
        private Button navprofile;
        private Button navmedicalhistory;
        private Label welcome_msg;
        private LinkLabel dash_medicalhistory;
        private LinkLabel dash_upcomingappointments;
        private LinkLabel dash_prescriptions;
        private LinkLabel dash_newdoctors;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel panel1;
    }
}