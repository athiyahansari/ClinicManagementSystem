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
            navprofile = new Button();
            logout = new Button();
            navprescription = new Button();
            navappointment = new Button();
            navdoc = new Button();
            welcome_msg = new Label();
            logoname = new Label();
            dash_medicalhistory = new LinkLabel();
            dash_upcomingappointments = new LinkLabel();
            dash_prescriptions = new LinkLabel();
            dash_newdoctors = new LinkLabel();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            sidenav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // sidenav
            // 
            sidenav.BackColor = Color.CornflowerBlue;
            sidenav.Controls.Add(navmedicalhistory);
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
            navmedicalhistory.Location = new Point(-1, 211);
            navmedicalhistory.Name = "navmedicalhistory";
            navmedicalhistory.Size = new Size(276, 65);
            navmedicalhistory.TabIndex = 5;
            navmedicalhistory.Text = "Medical History";
            navmedicalhistory.UseVisualStyleBackColor = false;
            // 
            // navprofile
            // 
            navprofile.BackColor = Color.LightSteelBlue;
            navprofile.Location = new Point(-1, 551);
            navprofile.Name = "navprofile";
            navprofile.Size = new Size(277, 68);
            navprofile.TabIndex = 4;
            navprofile.Text = "MyProfile";
            navprofile.UseVisualStyleBackColor = false;
            // 
            // logout
            // 
            logout.BackColor = Color.LightSteelBlue;
            logout.Location = new Point(-2, 618);
            logout.Name = "logout";
            logout.Size = new Size(277, 68);
            logout.TabIndex = 3;
            logout.Text = "LogOut";
            logout.UseVisualStyleBackColor = false;
            // 
            // navprescription
            // 
            navprescription.BackColor = Color.LightSteelBlue;
            navprescription.Location = new Point(-1, 147);
            navprescription.Name = "navprescription";
            navprescription.Size = new Size(276, 65);
            navprescription.TabIndex = 2;
            navprescription.Text = "Prescriptions";
            navprescription.UseVisualStyleBackColor = false;
            // 
            // navappointment
            // 
            navappointment.BackColor = Color.LightSteelBlue;
            navappointment.Location = new Point(-1, 86);
            navappointment.Name = "navappointment";
            navappointment.Size = new Size(276, 62);
            navappointment.TabIndex = 1;
            navappointment.Text = "Appointment";
            navappointment.UseVisualStyleBackColor = false;
            // 
            // navdoc
            // 
            navdoc.BackColor = Color.LightSteelBlue;
            navdoc.Location = new Point(-1, 22);
            navdoc.Name = "navdoc";
            navdoc.Size = new Size(276, 65);
            navdoc.TabIndex = 0;
            navdoc.Text = "Doctor";
            navdoc.UseVisualStyleBackColor = false;
            // 
            // welcome_msg
            // 
            welcome_msg.AutoSize = true;
            welcome_msg.Font = new Font("Lucida Bright", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcome_msg.Location = new Point(333, 44);
            welcome_msg.Name = "welcome_msg";
            welcome_msg.Size = new Size(369, 62);
            welcome_msg.TabIndex = 1;
            welcome_msg.Text = "Welcome back, John Doe!\r\n\r\n";
            // 
            // logoname
            // 
            logoname.AutoSize = true;
            logoname.Font = new Font("Gill Sans Ultra Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logoname.Location = new Point(1073, 48);
            logoname.Name = "logoname";
            logoname.Size = new Size(210, 31);
            logoname.TabIndex = 2;
            logoname.Text = "MedLine Clinic";
            // 
            // dash_medicalhistory
            // 
            dash_medicalhistory.ActiveLinkColor = SystemColors.ActiveCaptionText;
            dash_medicalhistory.AutoSize = true;
            dash_medicalhistory.LinkBehavior = LinkBehavior.NeverUnderline;
            dash_medicalhistory.LinkColor = Color.Black;
            dash_medicalhistory.Location = new Point(915, 433);
            dash_medicalhistory.Name = "dash_medicalhistory";
            dash_medicalhistory.Size = new Size(165, 25);
            dash_medicalhistory.TabIndex = 20;
            dash_medicalhistory.TabStop = true;
            dash_medicalhistory.Text = "My Medical History";
            // 
            // dash_upcomingappointments
            // 
            dash_upcomingappointments.ActiveLinkColor = SystemColors.ActiveCaptionText;
            dash_upcomingappointments.AutoSize = true;
            dash_upcomingappointments.LinkBehavior = LinkBehavior.NeverUnderline;
            dash_upcomingappointments.LinkColor = Color.Black;
            dash_upcomingappointments.Location = new Point(915, 325);
            dash_upcomingappointments.Name = "dash_upcomingappointments";
            dash_upcomingappointments.Size = new Size(214, 25);
            dash_upcomingappointments.TabIndex = 19;
            dash_upcomingappointments.TabStop = true;
            dash_upcomingappointments.Text = "Upcoming Appointments";
            // 
            // dash_prescriptions
            // 
            dash_prescriptions.ActiveLinkColor = SystemColors.ActiveCaptionText;
            dash_prescriptions.AutoSize = true;
            dash_prescriptions.LinkBehavior = LinkBehavior.NeverUnderline;
            dash_prescriptions.LinkColor = Color.Black;
            dash_prescriptions.Location = new Point(489, 433);
            dash_prescriptions.Name = "dash_prescriptions";
            dash_prescriptions.Size = new Size(143, 25);
            dash_prescriptions.TabIndex = 18;
            dash_prescriptions.TabStop = true;
            dash_prescriptions.Text = "My Prescriptions";
            // 
            // dash_newdoctors
            // 
            dash_newdoctors.ActiveLinkColor = SystemColors.ActiveCaptionText;
            dash_newdoctors.AutoSize = true;
            dash_newdoctors.LinkBehavior = LinkBehavior.NeverUnderline;
            dash_newdoctors.LinkColor = Color.Black;
            dash_newdoctors.Location = new Point(489, 325);
            dash_newdoctors.Name = "dash_newdoctors";
            dash_newdoctors.Size = new Size(138, 25);
            dash_newdoctors.TabIndex = 17;
            dash_newdoctors.TabStop = true;
            dash_newdoctors.Text = "Explore Doctors";
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(828, 419);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(72, 62);
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(828, 308);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(72, 62);
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(400, 419);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(72, 62);
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(400, 308);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 62);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // PatientDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1328, 720);
            Controls.Add(dash_medicalhistory);
            Controls.Add(dash_upcomingappointments);
            Controls.Add(dash_prescriptions);
            Controls.Add(dash_newdoctors);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(logoname);
            Controls.Add(welcome_msg);
            Controls.Add(sidenav);
            Name = "PatientDashboard";
            Text = "PatientDashboard";
            sidenav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label logoname;
        private LinkLabel dash_medicalhistory;
        private LinkLabel dash_upcomingappointments;
        private LinkLabel dash_prescriptions;
        private LinkLabel dash_newdoctors;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
    }
}