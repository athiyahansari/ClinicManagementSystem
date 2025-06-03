namespace CMS.View.Doctor
{
    partial class DoctorDashboard
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
            navprofile = new Button();
            label2 = new Label();
            logout = new Button();
            navappointment = new Button();
            navpatient = new Button();
            welcome_msg = new Label();
            namelogo = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            dash_pastpatient = new LinkLabel();
            dash_currentpatients = new LinkLabel();
            dash_upcomingappointments = new LinkLabel();
            dash_appointmenttrends = new LinkLabel();
            panel1 = new Panel();
            sidenav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // sidenav
            // 
            sidenav.BackColor = Color.CornflowerBlue;
            sidenav.Controls.Add(label3);
            sidenav.Controls.Add(navprofile);
            sidenav.Controls.Add(label2);
            sidenav.Controls.Add(logout);
            sidenav.Controls.Add(navappointment);
            sidenav.Controls.Add(navpatient);
            sidenav.Dock = DockStyle.Left;
            sidenav.Location = new Point(0, 0);
            sidenav.Name = "sidenav";
            sidenav.Size = new Size(274, 716);
            sidenav.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(79, 82);
            label3.Name = "label3";
            label3.Size = new Size(152, 28);
            label3.TabIndex = 24;
            label3.Text = "Doctor ID-2346";
            // 
            // navprofile
            // 
            navprofile.BackColor = Color.LightSteelBlue;
            navprofile.Font = new Font("Segoe UI", 9F);
            navprofile.Location = new Point(46, 485);
            navprofile.Name = "navprofile";
            navprofile.Size = new Size(177, 49);
            navprofile.TabIndex = 4;
            navprofile.Text = "MyProfile";
            navprofile.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kristen ITC", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(46, 43);
            label2.Name = "label2";
            label2.Size = new Size(160, 39);
            label2.TabIndex = 23;
            label2.Text = "John Doe";
            // 
            // logout
            // 
            logout.BackColor = Color.LightSteelBlue;
            logout.Font = new Font("Segoe UI", 9F);
            logout.Location = new Point(46, 540);
            logout.Name = "logout";
            logout.Size = new Size(177, 46);
            logout.TabIndex = 3;
            logout.Text = "LogOut";
            logout.UseVisualStyleBackColor = false;
            // 
            // navappointment
            // 
            navappointment.BackColor = Color.LightSteelBlue;
            navappointment.Font = new Font("Segoe UI", 9F);
            navappointment.Location = new Point(46, 187);
            navappointment.Name = "navappointment";
            navappointment.Size = new Size(177, 51);
            navappointment.TabIndex = 1;
            navappointment.Text = "My Appointment";
            navappointment.UseVisualStyleBackColor = false;
            // 
            // navpatient
            // 
            navpatient.BackColor = Color.LightSteelBlue;
            navpatient.Font = new Font("Segoe UI", 9F);
            navpatient.Location = new Point(46, 130);
            navpatient.Name = "navpatient";
            navpatient.Size = new Size(177, 51);
            navpatient.TabIndex = 0;
            navpatient.Text = "My Patients";
            navpatient.UseVisualStyleBackColor = false;
            // 
            // welcome_msg
            // 
            welcome_msg.AutoSize = true;
            welcome_msg.BackColor = Color.Transparent;
            welcome_msg.Font = new Font("Lucida Bright", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcome_msg.Location = new Point(63, 46);
            welcome_msg.Name = "welcome_msg";
            welcome_msg.Size = new Size(420, 62);
            welcome_msg.TabIndex = 2;
            welcome_msg.Text = "Welcome back, Dr. John Doe!\r\n\r\n";
            // 
            // namelogo
            // 
            namelogo.AutoSize = true;
            namelogo.BackColor = Color.Transparent;
            namelogo.Font = new Font("Gill Sans Ultra Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            namelogo.ForeColor = Color.MidnightBlue;
            namelogo.Location = new Point(774, 50);
            namelogo.Name = "namelogo";
            namelogo.Size = new Size(210, 31);
            namelogo.TabIndex = 3;
            namelogo.Text = "MedLine Clinic";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.patient_icon;
            pictureBox1.Location = new Point(121, 306);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.patient_icon;
            pictureBox3.Location = new Point(121, 417);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(72, 62);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.upcomingappointments_icon;
            pictureBox2.Location = new Point(549, 306);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(72, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.appointmenttrends_icon;
            pictureBox4.Location = new Point(549, 417);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(72, 62);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // dash_pastpatient
            // 
            dash_pastpatient.ActiveLinkColor = SystemColors.ActiveCaptionText;
            dash_pastpatient.AutoSize = true;
            dash_pastpatient.BackColor = Color.Transparent;
            dash_pastpatient.Font = new Font("Yu Gothic UI", 10F);
            dash_pastpatient.LinkBehavior = LinkBehavior.NeverUnderline;
            dash_pastpatient.LinkColor = Color.Black;
            dash_pastpatient.Location = new Point(210, 323);
            dash_pastpatient.Name = "dash_pastpatient";
            dash_pastpatient.Size = new Size(122, 28);
            dash_pastpatient.TabIndex = 9;
            dash_pastpatient.TabStop = true;
            dash_pastpatient.Text = "Past Patients";
            // 
            // dash_currentpatients
            // 
            dash_currentpatients.ActiveLinkColor = SystemColors.ActiveCaptionText;
            dash_currentpatients.AutoSize = true;
            dash_currentpatients.BackColor = Color.Transparent;
            dash_currentpatients.Font = new Font("Yu Gothic UI", 10F);
            dash_currentpatients.LinkBehavior = LinkBehavior.NeverUnderline;
            dash_currentpatients.LinkColor = Color.Black;
            dash_currentpatients.Location = new Point(210, 431);
            dash_currentpatients.Name = "dash_currentpatients";
            dash_currentpatients.Size = new Size(151, 28);
            dash_currentpatients.TabIndex = 10;
            dash_currentpatients.TabStop = true;
            dash_currentpatients.Text = "Current Patients";
            // 
            // dash_upcomingappointments
            // 
            dash_upcomingappointments.ActiveLinkColor = SystemColors.ActiveCaptionText;
            dash_upcomingappointments.AutoSize = true;
            dash_upcomingappointments.BackColor = Color.Transparent;
            dash_upcomingappointments.Font = new Font("Yu Gothic UI", 10F);
            dash_upcomingappointments.LinkBehavior = LinkBehavior.NeverUnderline;
            dash_upcomingappointments.LinkColor = Color.Black;
            dash_upcomingappointments.Location = new Point(636, 323);
            dash_upcomingappointments.Name = "dash_upcomingappointments";
            dash_upcomingappointments.Size = new Size(234, 28);
            dash_upcomingappointments.TabIndex = 11;
            dash_upcomingappointments.TabStop = true;
            dash_upcomingappointments.Text = "Upcoming Appointments";
            // 
            // dash_appointmenttrends
            // 
            dash_appointmenttrends.ActiveLinkColor = SystemColors.ActiveCaptionText;
            dash_appointmenttrends.AutoSize = true;
            dash_appointmenttrends.BackColor = Color.Transparent;
            dash_appointmenttrends.Font = new Font("Yu Gothic UI", 10F);
            dash_appointmenttrends.LinkBehavior = LinkBehavior.NeverUnderline;
            dash_appointmenttrends.LinkColor = Color.Black;
            dash_appointmenttrends.Location = new Point(636, 431);
            dash_appointmenttrends.Name = "dash_appointmenttrends";
            dash_appointmenttrends.Size = new Size(190, 28);
            dash_appointmenttrends.TabIndex = 12;
            dash_appointmenttrends.TabStop = true;
            dash_appointmenttrends.Text = "Appointment Trends";
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.dashboard_bg;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(dash_appointmenttrends);
            panel1.Controls.Add(dash_upcomingappointments);
            panel1.Controls.Add(dash_currentpatients);
            panel1.Controls.Add(dash_pastpatient);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(namelogo);
            panel1.Controls.Add(welcome_msg);
            panel1.Location = new Point(269, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1027, 716);
            panel1.TabIndex = 13;
            // 
            // DoctorDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1292, 716);
            Controls.Add(panel1);
            Controls.Add(sidenav);
            Name = "DoctorDashboard";
            Text = "DoctorDashboard";
            sidenav.ResumeLayout(false);
            sidenav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel sidenav;
        private Button navprofile;
        private Button logout;
        private Button navappointment;
        private Button navpatient;
        private Label welcome_msg;
        private Label namelogo;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private LinkLabel dash_pastpatient;
        private LinkLabel dash_currentpatients;
        private LinkLabel dash_upcomingappointments;
        private LinkLabel dash_appointmenttrends;
        private Label label3;
        private Label label2;
        private Panel panel1;
    }
}