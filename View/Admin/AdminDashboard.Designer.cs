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
            label3 = new Label();
            label2 = new Label();
            navprofile = new Button();
            logout = new Button();
            navappointment = new Button();
            navpatient = new Button();
            navdoc = new Button();
            label1 = new Label();
            welcome_msg = new Label();
            dash_appointmenttrends = new LinkLabel();
            dash_upcomingappointments = new LinkLabel();
            dash_patientedit = new LinkLabel();
            dash_newdoctors = new LinkLabel();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            sidenav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // sidenav
            // 
            sidenav.BackColor = Color.CornflowerBlue;
            sidenav.Controls.Add(panel1);
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
            sidenav.Size = new Size(274, 719);
            sidenav.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(71, 78);
            label3.Name = "label3";
            label3.Size = new Size(151, 28);
            label3.TabIndex = 6;
            label3.Text = "Admin ID-2346";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kristen ITC", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(38, 39);
            label2.Name = "label2";
            label2.Size = new Size(160, 39);
            label2.TabIndex = 5;
            label2.Text = "John Doe";
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
            navappointment.Location = new Point(29, 244);
            navappointment.Name = "navappointment";
            navappointment.Size = new Size(214, 47);
            navappointment.TabIndex = 2;
            navappointment.Text = "Appointment Schedules";
            navappointment.UseVisualStyleBackColor = false;
            // 
            // navpatient
            // 
            navpatient.BackColor = Color.LightSteelBlue;
            navpatient.Location = new Point(29, 192);
            navpatient.Name = "navpatient";
            navpatient.Size = new Size(214, 46);
            navpatient.TabIndex = 1;
            navpatient.Text = "Patients";
            navpatient.UseVisualStyleBackColor = false;
            // 
            // navdoc
            // 
            navdoc.BackColor = Color.LightSteelBlue;
            navdoc.Location = new Point(29, 141);
            navdoc.Name = "navdoc";
            navdoc.Size = new Size(214, 45);
            navdoc.TabIndex = 0;
            navdoc.Text = "Doctors";
            navdoc.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Gill Sans Ultra Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(797, 66);
            label1.Name = "label1";
            label1.Size = new Size(210, 31);
            label1.TabIndex = 3;
            label1.Text = "MedLine Clinic";
            // 
            // welcome_msg
            // 
            welcome_msg.AutoSize = true;
            welcome_msg.BackColor = Color.Transparent;
            welcome_msg.Font = new Font("Lucida Bright", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcome_msg.Location = new Point(58, 62);
            welcome_msg.Name = "welcome_msg";
            welcome_msg.Size = new Size(369, 62);
            welcome_msg.TabIndex = 4;
            welcome_msg.Text = "Welcome back, John Doe!\r\n\r\n";
            // 
            // dash_appointmenttrends
            // 
            dash_appointmenttrends.ActiveLinkColor = SystemColors.ActiveCaptionText;
            dash_appointmenttrends.AutoSize = true;
            dash_appointmenttrends.BackColor = Color.Transparent;
            dash_appointmenttrends.Font = new Font("Yu Gothic UI", 10F);
            dash_appointmenttrends.LinkBehavior = LinkBehavior.NeverUnderline;
            dash_appointmenttrends.LinkColor = Color.Black;
            dash_appointmenttrends.Location = new Point(650, 481);
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
            dash_upcomingappointments.Location = new Point(650, 373);
            dash_upcomingappointments.Name = "dash_upcomingappointments";
            dash_upcomingappointments.Size = new Size(234, 28);
            dash_upcomingappointments.TabIndex = 27;
            dash_upcomingappointments.TabStop = true;
            dash_upcomingappointments.Text = "Upcoming Appointments";
            // 
            // dash_patientedit
            // 
            dash_patientedit.ActiveLinkColor = SystemColors.ActiveCaptionText;
            dash_patientedit.AutoSize = true;
            dash_patientedit.BackColor = Color.Transparent;
            dash_patientedit.Font = new Font("Yu Gothic UI", 10F);
            dash_patientedit.LinkBehavior = LinkBehavior.NeverUnderline;
            dash_patientedit.LinkColor = Color.Black;
            dash_patientedit.Location = new Point(224, 481);
            dash_patientedit.Name = "dash_patientedit";
            dash_patientedit.Size = new Size(137, 28);
            dash_patientedit.TabIndex = 26;
            dash_patientedit.TabStop = true;
            dash_patientedit.Text = "Patient Details";
            // 
            // dash_newdoctors
            // 
            dash_newdoctors.ActiveLinkColor = SystemColors.ActiveCaptionText;
            dash_newdoctors.AutoSize = true;
            dash_newdoctors.BackColor = Color.Transparent;
            dash_newdoctors.Font = new Font("Yu Gothic UI", 10F);
            dash_newdoctors.LinkBehavior = LinkBehavior.NeverUnderline;
            dash_newdoctors.LinkColor = Color.Black;
            dash_newdoctors.Location = new Point(224, 373);
            dash_newdoctors.Name = "dash_newdoctors";
            dash_newdoctors.Size = new Size(157, 28);
            dash_newdoctors.TabIndex = 25;
            dash_newdoctors.TabStop = true;
            dash_newdoctors.Text = "Register Doctors";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.appointmenttrends_icon;
            pictureBox4.Location = new Point(563, 467);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(72, 62);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 24;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.upcomingappointments_icon;
            pictureBox2.Location = new Point(563, 356);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(72, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.patient_icon;
            pictureBox3.Location = new Point(135, 467);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(72, 62);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 22;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.doctor_icon;
            pictureBox1.Location = new Point(135, 356);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Location = new Point(275, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1035, 719);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.dashboard_bg;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(dash_appointmenttrends);
            panel2.Controls.Add(dash_upcomingappointments);
            panel2.Controls.Add(dash_patientedit);
            panel2.Controls.Add(dash_newdoctors);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(welcome_msg);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(271, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1041, 721);
            panel2.TabIndex = 29;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1310, 719);
            Controls.Add(panel2);
            Controls.Add(sidenav);
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            sidenav.ResumeLayout(false);
            sidenav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Button navdoc;
        private Label label1;
        private Label welcome_msg;
        private LinkLabel dash_appointmenttrends;
        private LinkLabel dash_upcomingappointments;
        private LinkLabel dash_patientedit;
        private LinkLabel dash_newdoctors;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
    }
}