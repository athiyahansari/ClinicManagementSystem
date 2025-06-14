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
            navprofile = new Button();
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
            label3 = new Label();
            label2 = new Label();
            sidenav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
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
            welcome_msg.Font = new Font("Lucida Bright", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcome_msg.Location = new Point(338, 46);
            welcome_msg.Name = "welcome_msg";
            welcome_msg.Size = new Size(420, 62);
            welcome_msg.TabIndex = 2;
            welcome_msg.Text = "Welcome back, Dr. John Doe!\r\n\r\n";
            // 
            // namelogo
            // 
            namelogo.AutoSize = true;
            namelogo.Font = new Font("Gill Sans Ultra Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            namelogo.Location = new Point(1049, 50);
            namelogo.Name = "namelogo";
            namelogo.Size = new Size(210, 31);
            namelogo.TabIndex = 3;
            namelogo.Text = "MedLine Clinic";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(396, 306);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 62);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(396, 417);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(72, 62);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(824, 306);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(72, 62);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(824, 417);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(72, 62);
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // dash_pastpatient
            // 
            dash_pastpatient.ActiveLinkColor = SystemColors.ActiveCaptionText;
            dash_pastpatient.AutoSize = true;
            dash_pastpatient.Font = new Font("Yu Gothic UI", 10F);
            dash_pastpatient.LinkBehavior = LinkBehavior.NeverUnderline;
            dash_pastpatient.LinkColor = Color.Black;
            dash_pastpatient.Location = new Point(485, 323);
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
            dash_currentpatients.Font = new Font("Yu Gothic UI", 10F);
            dash_currentpatients.LinkBehavior = LinkBehavior.NeverUnderline;
            dash_currentpatients.LinkColor = Color.Black;
            dash_currentpatients.Location = new Point(485, 431);
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
            dash_upcomingappointments.Font = new Font("Yu Gothic UI", 10F);
            dash_upcomingappointments.LinkBehavior = LinkBehavior.NeverUnderline;
            dash_upcomingappointments.LinkColor = Color.Black;
            dash_upcomingappointments.Location = new Point(911, 323);
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
            dash_appointmenttrends.Font = new Font("Yu Gothic UI", 10F);
            dash_appointmenttrends.LinkBehavior = LinkBehavior.NeverUnderline;
            dash_appointmenttrends.LinkColor = Color.Black;
            dash_appointmenttrends.Location = new Point(911, 431);
            dash_appointmenttrends.Name = "dash_appointmenttrends";
            dash_appointmenttrends.Size = new Size(190, 28);
            dash_appointmenttrends.TabIndex = 12;
            dash_appointmenttrends.TabStop = true;
            dash_appointmenttrends.Text = "Appointment Trends";
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
            // DoctorDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1292, 716);
            Controls.Add(dash_appointmenttrends);
            Controls.Add(dash_upcomingappointments);
            Controls.Add(dash_currentpatients);
            Controls.Add(dash_pastpatient);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(namelogo);
            Controls.Add(welcome_msg);
            Controls.Add(sidenav);
            Name = "DoctorDashboard";
            Text = "DoctorDashboard";
            //Load += DoctorDashboard_Load;
            sidenav.ResumeLayout(false);
            sidenav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}