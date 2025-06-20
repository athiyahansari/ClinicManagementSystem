﻿namespace CMS.View.Patient
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
            label1 = new Label();
            navmedicalhistory = new Button();
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
            lblNotification = new Label();
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
            sidenav.Controls.Add(label1);
            sidenav.Controls.Add(navmedicalhistory);
            sidenav.Controls.Add(navprofile);
            sidenav.Controls.Add(logout);
            sidenav.Controls.Add(navprescription);
            sidenav.Controls.Add(navappointment);
            sidenav.Controls.Add(navdoc);
            sidenav.Dock = DockStyle.Left;
            sidenav.Location = new Point(0, 0);
            sidenav.Margin = new Padding(2);
            sidenav.Name = "sidenav";
            sidenav.Size = new Size(274, 764);
            sidenav.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Kristen ITC", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(15, 41);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(246, 39);
            label1.TabIndex = 6;
            label1.Text = "MedLine Clinic";
            // 
            // navmedicalhistory
            // 
            navmedicalhistory.BackColor = Color.LightSteelBlue;
            navmedicalhistory.Location = new Point(49, 301);
            navmedicalhistory.Margin = new Padding(2);
            navmedicalhistory.Name = "navmedicalhistory";
            navmedicalhistory.Size = new Size(178, 48);
            navmedicalhistory.TabIndex = 5;
            navmedicalhistory.Text = "Medical History";
            navmedicalhistory.UseVisualStyleBackColor = false;
            navmedicalhistory.Click += navmedicalhistory_Click;
            // 
            // navprofile
            // 
            navprofile.BackColor = Color.LightSteelBlue;
            navprofile.Location = new Point(49, 551);
            navprofile.Margin = new Padding(2);
            navprofile.Name = "navprofile";
            navprofile.Size = new Size(178, 49);
            navprofile.TabIndex = 4;
            navprofile.Text = "MyProfile";
            navprofile.UseVisualStyleBackColor = false;
            navprofile.Click += navprofile_Click;
            // 
            // logout
            // 
            logout.BackColor = Color.LightSteelBlue;
            logout.Location = new Point(49, 606);
            logout.Margin = new Padding(2);
            logout.Name = "logout";
            logout.Size = new Size(178, 46);
            logout.TabIndex = 3;
            logout.Text = "LogOut";
            logout.UseVisualStyleBackColor = false;
            logout.Click += logout_Click;
            // 
            // navprescription
            // 
            navprescription.BackColor = Color.LightSteelBlue;
            navprescription.Location = new Point(49, 248);
            navprescription.Margin = new Padding(2);
            navprescription.Name = "navprescription";
            navprescription.Size = new Size(178, 48);
            navprescription.TabIndex = 2;
            navprescription.Text = "Prescriptions";
            navprescription.UseVisualStyleBackColor = false;
            navprescription.Click += navprescription_Click;
            // 
            // navappointment
            // 
            navappointment.BackColor = Color.LightSteelBlue;
            navappointment.Location = new Point(49, 196);
            navappointment.Margin = new Padding(2);
            navappointment.Name = "navappointment";
            navappointment.Size = new Size(178, 46);
            navappointment.TabIndex = 1;
            navappointment.Text = "Appointment";
            navappointment.UseVisualStyleBackColor = false;
            navappointment.Click += navappointment_Click;
            // 
            // navdoc
            // 
            navdoc.BackColor = Color.LightSteelBlue;
            navdoc.Location = new Point(49, 148);
            navdoc.Margin = new Padding(2);
            navdoc.Name = "navdoc";
            navdoc.Size = new Size(178, 42);
            navdoc.TabIndex = 0;
            navdoc.Text = "Doctor";
            navdoc.UseVisualStyleBackColor = false;
            navdoc.Click += navdoc_Click;
            // 
            // welcome_msg
            // 
            welcome_msg.AutoSize = true;
            welcome_msg.BackColor = Color.Transparent;
            welcome_msg.Font = new Font("Lucida Bright", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcome_msg.Location = new Point(58, 46);
            welcome_msg.Margin = new Padding(2, 0, 2, 0);
            welcome_msg.Name = "welcome_msg";
            welcome_msg.Size = new Size(223, 31);
            welcome_msg.TabIndex = 1;
            welcome_msg.Text = "Welcome back!";
            // 
            // dash_medicalhistory
            // 
            dash_medicalhistory.ActiveLinkColor = SystemColors.ActiveCaptionText;
            dash_medicalhistory.AutoSize = true;
            dash_medicalhistory.BackColor = Color.Transparent;
            dash_medicalhistory.Font = new Font("Yu Gothic UI", 10F);
            dash_medicalhistory.LinkBehavior = LinkBehavior.NeverUnderline;
            dash_medicalhistory.LinkColor = Color.Black;
            dash_medicalhistory.Location = new Point(639, 494);
            dash_medicalhistory.Margin = new Padding(2, 0, 2, 0);
            dash_medicalhistory.Name = "dash_medicalhistory";
            dash_medicalhistory.Size = new Size(182, 28);
            dash_medicalhistory.TabIndex = 20;
            dash_medicalhistory.TabStop = true;
            dash_medicalhistory.Text = "My Medical History";
            dash_medicalhistory.LinkClicked += dash_medicalhistory_LinkClicked;
            // 
            // dash_upcomingappointments
            // 
            dash_upcomingappointments.ActiveLinkColor = SystemColors.ActiveCaptionText;
            dash_upcomingappointments.AutoSize = true;
            dash_upcomingappointments.BackColor = Color.Transparent;
            dash_upcomingappointments.Font = new Font("Yu Gothic UI", 10F);
            dash_upcomingappointments.LinkBehavior = LinkBehavior.NeverUnderline;
            dash_upcomingappointments.LinkColor = Color.Black;
            dash_upcomingappointments.Location = new Point(639, 386);
            dash_upcomingappointments.Margin = new Padding(2, 0, 2, 0);
            dash_upcomingappointments.Name = "dash_upcomingappointments";
            dash_upcomingappointments.Size = new Size(234, 28);
            dash_upcomingappointments.TabIndex = 19;
            dash_upcomingappointments.TabStop = true;
            dash_upcomingappointments.Text = "Upcoming Appointments";
            dash_upcomingappointments.LinkClicked += dash_upcomingappointments_LinkClicked;
            // 
            // dash_prescriptions
            // 
            dash_prescriptions.ActiveLinkColor = SystemColors.ActiveCaptionText;
            dash_prescriptions.AutoSize = true;
            dash_prescriptions.BackColor = Color.Transparent;
            dash_prescriptions.Font = new Font("Yu Gothic UI", 10F);
            dash_prescriptions.LinkBehavior = LinkBehavior.NeverUnderline;
            dash_prescriptions.LinkColor = Color.Black;
            dash_prescriptions.Location = new Point(212, 494);
            dash_prescriptions.Margin = new Padding(2, 0, 2, 0);
            dash_prescriptions.Name = "dash_prescriptions";
            dash_prescriptions.Size = new Size(157, 28);
            dash_prescriptions.TabIndex = 18;
            dash_prescriptions.TabStop = true;
            dash_prescriptions.Text = "My Prescriptions";
            dash_prescriptions.LinkClicked += dash_prescriptions_LinkClicked;
            // 
            // dash_newdoctors
            // 
            dash_newdoctors.ActiveLinkColor = SystemColors.ActiveCaptionText;
            dash_newdoctors.AutoSize = true;
            dash_newdoctors.BackColor = Color.Transparent;
            dash_newdoctors.Font = new Font("Yu Gothic UI", 10F);
            dash_newdoctors.LinkBehavior = LinkBehavior.NeverUnderline;
            dash_newdoctors.LinkColor = Color.Black;
            dash_newdoctors.Location = new Point(212, 386);
            dash_newdoctors.Margin = new Padding(2, 0, 2, 0);
            dash_newdoctors.Name = "dash_newdoctors";
            dash_newdoctors.Size = new Size(151, 28);
            dash_newdoctors.TabIndex = 17;
            dash_newdoctors.TabStop = true;
            dash_newdoctors.Text = "Explore Doctors";
            dash_newdoctors.LinkClicked += dash_newdoctors_LinkClicked;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = Properties.Resources.medical_history_icon;
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(552, 480);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(72, 62);
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.upcomingappointments_icon;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(552, 369);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(72, 62);
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = Properties.Resources.prescription_icon;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(124, 480);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(72, 62);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.doctor_icon;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(124, 369);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 62);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.dashboard_bg;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(lblNotification);
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
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1118, 764);
            panel1.TabIndex = 21;
            // 
            // lblNotification
            // 
            lblNotification.AutoSize = true;
            lblNotification.BackColor = Color.Transparent;
            lblNotification.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            lblNotification.Location = new Point(681, 98);
            lblNotification.Margin = new Padding(2, 0, 2, 0);
            lblNotification.Name = "lblNotification";
            lblNotification.Size = new Size(18, 25);
            lblNotification.TabIndex = 22;
            lblNotification.Text = ".";
            // 
            // PatientDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1388, 764);
            Controls.Add(panel1);
            Controls.Add(sidenav);
            Margin = new Padding(2);
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
        private Label lblNotification;
        private Label label1;
    }
}