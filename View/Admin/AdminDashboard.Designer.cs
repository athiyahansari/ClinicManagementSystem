namespace CMS.View.Admin
{
    partial class AdminDashboard
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
            panel1 = new Panel();
            navprofile = new Button();
            logout = new Button();
            navappointment = new Button();
            navpatient = new Button();
            navdoc = new Button();
            welcome_msg = new Label();
            dash_appointmenttrends = new LinkLabel();
            dash_upcomingappointments = new LinkLabel();
            dash_newdoctors = new LinkLabel();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            sidenav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // sidenav
            // 
            sidenav.BackColor = Color.CornflowerBlue;
            sidenav.Controls.Add(label2);
            sidenav.Controls.Add(panel1);
            sidenav.Controls.Add(navprofile);
            sidenav.Controls.Add(logout);
            sidenav.Controls.Add(navappointment);
            sidenav.Controls.Add(navpatient);
            sidenav.Controls.Add(navdoc);
            sidenav.Dock = DockStyle.Left;
            sidenav.Location = new Point(0, 0);
            sidenav.Name = "sidenav";
            sidenav.Size = new Size(274, 741);
            sidenav.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kristen ITC", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(18, 71);
            label2.Name = "label2";
            label2.Size = new Size(246, 39);
            label2.TabIndex = 23;
            label2.Text = "MedLine Clinic";
            // 
            // panel1
            // 
            panel1.Location = new Point(275, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1035, 719);
            panel1.TabIndex = 7;
            // 
            // navprofile
            // 
            navprofile.BackColor = Color.LightSteelBlue;
            navprofile.Location = new Point(29, 554);
            navprofile.Name = "navprofile";
            navprofile.Size = new Size(214, 42);
            navprofile.TabIndex = 4;
            navprofile.Text = "MyProfile";
            navprofile.UseVisualStyleBackColor = false;
            // 
            // logout
            // 
            logout.BackColor = Color.LightSteelBlue;
            logout.Location = new Point(29, 602);
            logout.Name = "logout";
            logout.Size = new Size(214, 44);
            logout.TabIndex = 3;
            logout.Text = "LogOut";
            logout.UseVisualStyleBackColor = false;
            // 
            // navappointment
            // 
            navappointment.BackColor = Color.LightSteelBlue;
            navappointment.Location = new Point(29, 261);
            navappointment.Name = "navappointment";
            navappointment.Size = new Size(214, 47);
            navappointment.TabIndex = 2;
            navappointment.Text = "Appointment Schedules";
            navappointment.UseVisualStyleBackColor = false;
            // 
            // navpatient
            // 
            navpatient.BackColor = Color.LightSteelBlue;
            navpatient.Location = new Point(29, 210);
            navpatient.Name = "navpatient";
            navpatient.Size = new Size(214, 46);
            navpatient.TabIndex = 1;
            navpatient.Text = "Patients";
            navpatient.UseVisualStyleBackColor = false;
            // 
            // navdoc
            // 
            navdoc.BackColor = Color.LightSteelBlue;
            navdoc.Location = new Point(29, 159);
            navdoc.Name = "navdoc";
            navdoc.Size = new Size(214, 45);
            navdoc.TabIndex = 0;
            navdoc.Text = "Doctors";
            navdoc.UseVisualStyleBackColor = false;
            // 
            // welcome_msg
            // 
            welcome_msg.AutoSize = true;
            welcome_msg.BackColor = Color.Transparent;
            welcome_msg.Font = new Font("Lucida Bright", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcome_msg.Location = new Point(36, 59);
            welcome_msg.Name = "welcome_msg";
            welcome_msg.Size = new Size(223, 31);
            welcome_msg.TabIndex = 4;
            welcome_msg.Text = "Welcome back!";
            // 
            // dash_appointmenttrends
            // 
            dash_appointmenttrends.ActiveLinkColor = SystemColors.ActiveCaptionText;
            dash_appointmenttrends.AutoSize = true;
            dash_appointmenttrends.BackColor = Color.Transparent;
            dash_appointmenttrends.Font = new Font("Yu Gothic UI", 10F);
            dash_appointmenttrends.LinkBehavior = LinkBehavior.NeverUnderline;
            dash_appointmenttrends.LinkColor = Color.Black;
            dash_appointmenttrends.Location = new Point(471, 389);
            dash_appointmenttrends.Name = "dash_appointmenttrends";
            dash_appointmenttrends.Size = new Size(190, 28);
            dash_appointmenttrends.TabIndex = 28;
            dash_appointmenttrends.TabStop = true;
            dash_appointmenttrends.Text = "Appointment Trends";
            // 
            // dash_upcomingappointments
            // 
            dash_upcomingappointments.ActiveLinkColor = SystemColors.ActiveCaptionText;
            dash_upcomingappointments.AutoSize = true;
            dash_upcomingappointments.BackColor = Color.Transparent;
            dash_upcomingappointments.Font = new Font("Yu Gothic UI", 10F);
            dash_upcomingappointments.LinkBehavior = LinkBehavior.NeverUnderline;
            dash_upcomingappointments.LinkColor = Color.Black;
            dash_upcomingappointments.Location = new Point(810, 389);
            dash_upcomingappointments.Name = "dash_upcomingappointments";
            dash_upcomingappointments.Size = new Size(234, 28);
            dash_upcomingappointments.TabIndex = 27;
            dash_upcomingappointments.TabStop = true;
            dash_upcomingappointments.Text = "Upcoming Appointments";
            // 
            // dash_newdoctors
            // 
            dash_newdoctors.ActiveLinkColor = SystemColors.ActiveCaptionText;
            dash_newdoctors.AutoSize = true;
            dash_newdoctors.BackColor = Color.Transparent;
            dash_newdoctors.Font = new Font("Yu Gothic UI", 10F);
            dash_newdoctors.LinkBehavior = LinkBehavior.NeverUnderline;
            dash_newdoctors.LinkColor = Color.Black;
            dash_newdoctors.Location = new Point(148, 389);
            dash_newdoctors.Name = "dash_newdoctors";
            dash_newdoctors.Size = new Size(157, 28);
            dash_newdoctors.TabIndex = 25;
            dash_newdoctors.TabStop = true;
            dash_newdoctors.Text = "Register Doctors";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = Properties.Resources.appointmenttrends_icon;
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(384, 375);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(72, 62);
            pictureBox4.TabIndex = 24;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.upcomingappointments_icon;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(723, 372);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(72, 62);
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.doctor_icon;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(59, 372);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 62);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.dashboard_bg;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(271, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1041, 721);
            panel2.TabIndex = 29;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.dashboard_bg;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(dash_appointmenttrends);
            panel3.Controls.Add(dash_upcomingappointments);
            panel3.Controls.Add(dash_newdoctors);
            panel3.Controls.Add(pictureBox4);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(welcome_msg);
            panel3.Location = new Point(275, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(1105, 740);
            panel3.TabIndex = 29;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1375, 741);
            Controls.Add(panel3);
            Controls.Add(sidenav);
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            sidenav.ResumeLayout(false);
            sidenav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel sidenav;
        private Button navprofile;
        private Button logout;
        private Button navappointment;
        private Button navpatient;
        private Button navdoc;
        private Label welcome_msg;
        private LinkLabel dash_appointmenttrends;
        private LinkLabel dash_upcomingappointments;
        private LinkLabel dash_newdoctors;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
    }
}