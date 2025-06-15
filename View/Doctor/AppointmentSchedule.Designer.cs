namespace CMS.View.Doctor
{
    partial class AppointmentSchedule
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
            label2 = new Label();
            logout = new Button();
            navappointment = new Button();
            navpatient = new Button();
            dataGridView1 = new DataGridView();
            AppointmentID = new DataGridViewTextBoxColumn();
            PatientName = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Time = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Consultation = new DataGridViewTextBoxColumn();
            Cancel = new DataGridViewButtonColumn();
            vScrollBar1 = new VScrollBar();
            appointmentschedulelabel = new Label();
            sidenav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // sidenav
            // 
            sidenav.BackColor = Color.CornflowerBlue;
            sidenav.Controls.Add(navprofile);
            sidenav.Controls.Add(label2);
            sidenav.Controls.Add(logout);
            sidenav.Controls.Add(navappointment);
            sidenav.Controls.Add(navpatient);
            sidenav.Dock = DockStyle.Left;
            sidenav.Location = new Point(0, 0);
            sidenav.Name = "sidenav";
            sidenav.Size = new Size(274, 763);
            sidenav.TabIndex = 2;
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
            navprofile.Click += navprofile_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kristen ITC", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(16, 45);
            label2.Name = "label2";
            label2.Size = new Size(246, 39);
            label2.TabIndex = 23;
            label2.Text = "MedLine Clinic";
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
            logout.Click += logout_Click;
            // 
            // navappointment
            // 
            navappointment.BackColor = Color.LightSteelBlue;
            navappointment.Font = new Font("Segoe UI", 9F);
            navappointment.Location = new Point(46, 176);
            navappointment.Name = "navappointment";
            navappointment.Size = new Size(177, 51);
            navappointment.TabIndex = 1;
            navappointment.Text = "My Appointment";
            navappointment.UseVisualStyleBackColor = false;
            navappointment.Click += navappointment_Click;
            // 
            // navpatient
            // 
            navpatient.BackColor = Color.LightSteelBlue;
            navpatient.Font = new Font("Segoe UI", 9F);
            navpatient.Location = new Point(46, 230);
            navpatient.Name = "navpatient";
            navpatient.Size = new Size(177, 51);
            navpatient.TabIndex = 0;
            navpatient.Text = "Prescriptions";
            navpatient.UseVisualStyleBackColor = false;
            navpatient.Click += navpatient_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { AppointmentID, PatientName, Date, Time, Status, Consultation, Cancel });
            dataGridView1.Location = new Point(294, 203);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1136, 371);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // AppointmentID
            // 
            AppointmentID.HeaderText = "AppointmentID";
            AppointmentID.MinimumWidth = 8;
            AppointmentID.Name = "AppointmentID";
            AppointmentID.ReadOnly = true;
            AppointmentID.Width = 150;
            // 
            // PatientName
            // 
            PatientName.HeaderText = "PatientName";
            PatientName.MinimumWidth = 8;
            PatientName.Name = "PatientName";
            PatientName.ReadOnly = true;
            PatientName.Width = 150;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.MinimumWidth = 8;
            Date.Name = "Date";
            Date.Width = 150;
            // 
            // Time
            // 
            Time.HeaderText = "Time";
            Time.MinimumWidth = 8;
            Time.Name = "Time";
            Time.Width = 150;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 8;
            Status.Name = "Status";
            Status.Width = 150;
            // 
            // Consultation
            // 
            Consultation.HeaderText = "Consultation";
            Consultation.MinimumWidth = 8;
            Consultation.Name = "Consultation";
            Consultation.ReadOnly = true;
            Consultation.Width = 150;
            // 
            // Cancel
            // 
            Cancel.HeaderText = "Cancel";
            Cancel.MinimumWidth = 8;
            Cancel.Name = "Cancel";
            Cancel.Width = 150;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(1408, 203);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(25, 371);
            vScrollBar1.TabIndex = 4;
            // 
            // appointmentschedulelabel
            // 
            appointmentschedulelabel.AutoSize = true;
            appointmentschedulelabel.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            appointmentschedulelabel.ForeColor = Color.MidnightBlue;
            appointmentschedulelabel.Location = new Point(695, 62);
            appointmentschedulelabel.Name = "appointmentschedulelabel";
            appointmentschedulelabel.Size = new Size(336, 38);
            appointmentschedulelabel.TabIndex = 5;
            appointmentschedulelabel.Text = "Appointment Schedule";
            // 
            // AppointmentSchedule
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1452, 763);
            Controls.Add(appointmentschedulelabel);
            Controls.Add(vScrollBar1);
            Controls.Add(dataGridView1);
            Controls.Add(sidenav);
            Name = "AppointmentSchedule";
            Text = "AppointmentSchedule";
            Load += AppointmentSchedule_Load;
            sidenav.ResumeLayout(false);
            sidenav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel sidenav;
        private Button navprofile;
        private Label label2;
        private Button logout;
        private Button navappointment;
        private Button navpatient;
        private DataGridView dataGridView1;
        private VScrollBar vScrollBar1;
        private Label appointmentschedulelabel;
        private DataGridViewTextBoxColumn AppointmentID;
        private DataGridViewTextBoxColumn PatientName;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Time;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Consultation;
        private DataGridViewButtonColumn Cancel;
    }
}