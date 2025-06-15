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
            label2 = new Label();
            navprofile = new Button();
            logout = new Button();
            navappointment = new Button();
            navpatient = new Button();
            welcome_msg = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            dash_pastpatient = new LinkLabel();
            dash_upcomingappointments = new LinkLabel();
            panel1 = new Panel();
            panel2 = new Panel();
            sidenav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // sidenav
            // 
            sidenav.BackColor = Color.CornflowerBlue;
            sidenav.Controls.Add(label2);
            sidenav.Controls.Add(navprofile);
            sidenav.Controls.Add(logout);
            sidenav.Controls.Add(navappointment);
            sidenav.Controls.Add(navpatient);
            sidenav.Dock = DockStyle.Left;
            sidenav.Location = new Point(0, 0);
            sidenav.Margin = new Padding(2, 2, 2, 2);
            sidenav.Name = "sidenav";
            sidenav.Size = new Size(219, 597);
            sidenav.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kristen ITC", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(14, 50);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(209, 33);
            label2.TabIndex = 22;
            label2.Text = "MedLine Clinic";
            // 
            // navprofile
            // 
            navprofile.BackColor = Color.LightSteelBlue;
            navprofile.Font = new Font("Segoe UI", 9F);
            navprofile.Location = new Point(37, 388);
            navprofile.Margin = new Padding(2, 2, 2, 2);
            navprofile.Name = "navprofile";
            navprofile.Size = new Size(142, 39);
            navprofile.TabIndex = 4;
            navprofile.Text = "MyProfile";
            navprofile.UseVisualStyleBackColor = false;
            // 
            // logout
            // 
            logout.BackColor = Color.LightSteelBlue;
            logout.Font = new Font("Segoe UI", 9F);
            logout.Location = new Point(37, 432);
            logout.Margin = new Padding(2, 2, 2, 2);
            logout.Name = "logout";
            logout.Size = new Size(142, 37);
            logout.TabIndex = 3;
            logout.Text = "LogOut";
            logout.UseVisualStyleBackColor = false;
            // 
            // navappointment
            // 
            navappointment.BackColor = Color.LightSteelBlue;
            navappointment.Font = new Font("Segoe UI", 9F);
            navappointment.Location = new Point(37, 166);
            navappointment.Margin = new Padding(2, 2, 2, 2);
            navappointment.Name = "navappointment";
            navappointment.Size = new Size(142, 41);
            navappointment.TabIndex = 1;
            navappointment.Text = "My Appointment";
            navappointment.UseVisualStyleBackColor = false;
            // 
            // navpatient
            // 
            navpatient.BackColor = Color.LightSteelBlue;
            navpatient.Font = new Font("Segoe UI", 9F);
            navpatient.Location = new Point(37, 120);
            navpatient.Margin = new Padding(2, 2, 2, 2);
            navpatient.Name = "navpatient";
            navpatient.Size = new Size(142, 41);
            navpatient.TabIndex = 0;
            navpatient.Text = "My Patients";
            navpatient.UseVisualStyleBackColor = false;
            // 
            // welcome_msg
            // 
            welcome_msg.AutoSize = true;
            welcome_msg.BackColor = Color.Transparent;
            welcome_msg.Font = new Font("Lucida Bright", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcome_msg.Location = new Point(21, 31);
            welcome_msg.Margin = new Padding(2, 0, 2, 0);
            welcome_msg.Name = "welcome_msg";
            welcome_msg.Size = new Size(192, 27);
            welcome_msg.TabIndex = 2;
            welcome_msg.Text = "Welcome back!\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.patient_icon;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(93, 278);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 50);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.upcomingappointments_icon;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(435, 278);
            pictureBox2.Margin = new Padding(2, 2, 2, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(58, 50);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // dash_pastpatient
            // 
            dash_pastpatient.ActiveLinkColor = SystemColors.ActiveCaptionText;
            dash_pastpatient.AutoSize = true;
            dash_pastpatient.BackColor = Color.Transparent;
            dash_pastpatient.Font = new Font("Yu Gothic UI", 10F);
            dash_pastpatient.LinkBehavior = LinkBehavior.NeverUnderline;
            dash_pastpatient.LinkColor = Color.Black;
            dash_pastpatient.Location = new Point(164, 292);
            dash_pastpatient.Margin = new Padding(2, 0, 2, 0);
            dash_pastpatient.Name = "dash_pastpatient";
            dash_pastpatient.Size = new Size(108, 23);
            dash_pastpatient.TabIndex = 9;
            dash_pastpatient.TabStop = true;
            dash_pastpatient.Text = "Past Patients";
            dash_pastpatient.LinkClicked += dash_pastpatient_LinkClicked;
            // 
            // dash_upcomingappointments
            // 
            dash_upcomingappointments.ActiveLinkColor = SystemColors.ActiveCaptionText;
            dash_upcomingappointments.AutoSize = true;
            dash_upcomingappointments.BackColor = Color.Transparent;
            dash_upcomingappointments.Font = new Font("Yu Gothic UI", 10F);
            dash_upcomingappointments.LinkBehavior = LinkBehavior.NeverUnderline;
            dash_upcomingappointments.LinkColor = Color.Black;
            dash_upcomingappointments.Location = new Point(505, 292);
            dash_upcomingappointments.Margin = new Padding(2, 0, 2, 0);
            dash_upcomingappointments.Name = "dash_upcomingappointments";
            dash_upcomingappointments.Size = new Size(202, 23);
            dash_upcomingappointments.TabIndex = 11;
            dash_upcomingappointments.TabStop = true;
            dash_upcomingappointments.Text = "Upcoming Appointments";
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.dashboard_bg;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(269, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1027, 716);
            panel1.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.dashboard_bg1;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(dash_upcomingappointments);
            panel2.Controls.Add(dash_pastpatient);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(welcome_msg);
            panel2.Location = new Point(221, 0);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(858, 597);
            panel2.TabIndex = 13;
            // 
            // DoctorDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1076, 597);
            Controls.Add(panel2);
            Controls.Add(sidenav);
            Margin = new Padding(2, 2, 2, 2);
            Name = "DoctorDashboard";
            Text = "DoctorDashboard";
            sidenav.ResumeLayout(false);
            sidenav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel sidenav;
        private Button navprofile;
        private Button logout;
        private Button navappointment;
        private Button navpatient;
        private Label welcome_msg;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private LinkLabel dash_pastpatient;
        private LinkLabel dash_upcomingappointments;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
    }
}