namespace CMS.View.Admin
{
    partial class Reportadmin : Form
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            logoutbtn = new Button();
            navappointmentbtn = new Button();
            navpatientbtn = new Button();
            navdocbtn = new Button();
            panel2 = new Panel();
            generatepatienttrendsbtn = new Button();
            generateDoctorShedule = new Button();
            patienttrenddateto = new DateTimePicker();
            patienttrenddatefrom = new DateTimePicker();
            doctorsheduledateto = new DateTimePicker();
            doctorsheduledatefrom = new DateTimePicker();
            dataGridViewpatienttrend = new DataGridView();
            PatientNameColumn = new DataGridViewTextBoxColumn();
            Totalappointmentscolumn = new DataGridViewTextBoxColumn();
            Lastappointmentcolumn = new DataGridViewTextBoxColumn();
            label10 = new Label();
            label11 = new Label();
            label8 = new Label();
            label7 = new Label();
            combodoctorshedule = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            dataGriddoctorshedule = new DataGridView();
            patientcolumnshedule = new DataGridViewTextBoxColumn();
            appointmentdatecolumnshedule = new DataGridViewTextBoxColumn();
            appointmenttimecolumnshedule = new DataGridViewTextBoxColumn();
            statuscolumnshedule = new DataGridViewTextBoxColumn();
            label1 = new Label();
            button1 = new Button();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewpatienttrend).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGriddoctorshedule).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(840, 651);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(logoutbtn);
            panel1.Controls.Add(navappointmentbtn);
            panel1.Controls.Add(navpatientbtn);
            panel1.Controls.Add(navdocbtn);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(166, 653);
            panel1.TabIndex = 0;
            // 
            // logoutbtn
            // 
            logoutbtn.BackColor = Color.LightSteelBlue;
            logoutbtn.Location = new Point(24, 387);
            logoutbtn.Margin = new Padding(2);
            logoutbtn.Name = "logoutbtn";
            logoutbtn.Size = new Size(113, 28);
            logoutbtn.TabIndex = 10;
            logoutbtn.Text = "LogOut";
            logoutbtn.UseVisualStyleBackColor = false;
            logoutbtn.Click += logoutbtn_Click;
            // 
            // navappointmentbtn
            // 
            navappointmentbtn.BackColor = Color.LightSteelBlue;
            navappointmentbtn.Location = new Point(24, 138);
            navappointmentbtn.Margin = new Padding(2);
            navappointmentbtn.Name = "navappointmentbtn";
            navappointmentbtn.Size = new Size(113, 28);
            navappointmentbtn.TabIndex = 9;
            navappointmentbtn.Text = "Appointment Schedules";
            navappointmentbtn.UseVisualStyleBackColor = false;
            navappointmentbtn.Click += navappointmentbtn_Click;
            // 
            // navpatientbtn
            // 
            navpatientbtn.BackColor = Color.LightSteelBlue;
            navpatientbtn.Location = new Point(24, 107);
            navpatientbtn.Margin = new Padding(2);
            navpatientbtn.Name = "navpatientbtn";
            navpatientbtn.Size = new Size(113, 28);
            navpatientbtn.TabIndex = 8;
            navpatientbtn.Text = "Patients";
            navpatientbtn.UseVisualStyleBackColor = false;
            navpatientbtn.Click += navpatientbtn_Click;
            // 
            // navdocbtn
            // 
            navdocbtn.BackColor = Color.LightSteelBlue;
            navdocbtn.Location = new Point(24, 77);
            navdocbtn.Margin = new Padding(2);
            navdocbtn.Name = "navdocbtn";
            navdocbtn.Size = new Size(113, 28);
            navdocbtn.TabIndex = 7;
            navdocbtn.Text = "Doctors";
            navdocbtn.UseVisualStyleBackColor = false;
            navdocbtn.Click += navdocbtn_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(generatepatienttrendsbtn);
            panel2.Controls.Add(generateDoctorShedule);
            panel2.Controls.Add(patienttrenddateto);
            panel2.Controls.Add(patienttrenddatefrom);
            panel2.Controls.Add(doctorsheduledateto);
            panel2.Controls.Add(doctorsheduledatefrom);
            panel2.Controls.Add(dataGridViewpatienttrend);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(combodoctorshedule);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(dataGriddoctorshedule);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(166, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(665, 653);
            panel2.TabIndex = 1;
            // 
            // generatepatienttrendsbtn
            // 
            generatepatienttrendsbtn.Location = new Point(524, 393);
            generatepatienttrendsbtn.Name = "generatepatienttrendsbtn";
            generatepatienttrendsbtn.Size = new Size(75, 23);
            generatepatienttrendsbtn.TabIndex = 23;
            generatepatienttrendsbtn.Text = "Generate";
            generatepatienttrendsbtn.UseVisualStyleBackColor = true;
            generatepatienttrendsbtn.Click += generatepatienttrendsbtn_Click;
            // 
            // generateDoctorShedule
            // 
            generateDoctorShedule.Location = new Point(543, 65);
            generateDoctorShedule.Name = "generateDoctorShedule";
            generateDoctorShedule.Size = new Size(75, 23);
            generateDoctorShedule.TabIndex = 22;
            generateDoctorShedule.Text = "Generate ";
            generateDoctorShedule.UseVisualStyleBackColor = true;
            generateDoctorShedule.Click += generateDoctorShedule_Click;
            // 
            // patienttrenddateto
            // 
            patienttrenddateto.Location = new Point(279, 393);
            patienttrenddateto.Name = "patienttrenddateto";
            patienttrenddateto.Size = new Size(196, 23);
            patienttrenddateto.TabIndex = 21;
            // 
            // patienttrenddatefrom
            // 
            patienttrenddatefrom.Location = new Point(56, 393);
            patienttrenddatefrom.Name = "patienttrenddatefrom";
            patienttrenddatefrom.Size = new Size(196, 23);
            patienttrenddatefrom.TabIndex = 20;
            // 
            // doctorsheduledateto
            // 
            doctorsheduledateto.Location = new Point(422, 108);
            doctorsheduledateto.Name = "doctorsheduledateto";
            doctorsheduledateto.Size = new Size(196, 23);
            doctorsheduledateto.TabIndex = 19;
            // 
            // doctorsheduledatefrom
            // 
            doctorsheduledatefrom.Location = new Point(211, 108);
            doctorsheduledatefrom.Name = "doctorsheduledatefrom";
            doctorsheduledatefrom.Size = new Size(196, 23);
            doctorsheduledatefrom.TabIndex = 18;
            // 
            // dataGridViewpatienttrend
            // 
            dataGridViewpatienttrend.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridViewpatienttrend.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewpatienttrend.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewpatienttrend.Columns.AddRange(new DataGridViewColumn[] { PatientNameColumn, Totalappointmentscolumn, Lastappointmentcolumn });
            dataGridViewpatienttrend.Location = new Point(56, 429);
            dataGridViewpatienttrend.Name = "dataGridViewpatienttrend";
            dataGridViewpatienttrend.Size = new Size(543, 178);
            dataGridViewpatienttrend.TabIndex = 17;
            // 
            // PatientNameColumn
            // 
            PatientNameColumn.HeaderText = "Patient Name";
            PatientNameColumn.MinimumWidth = 10;
            PatientNameColumn.Name = "PatientNameColumn";
            PatientNameColumn.Width = 120;
            // 
            // Totalappointmentscolumn
            // 
            Totalappointmentscolumn.HeaderText = "Total Appointments";
            Totalappointmentscolumn.Name = "Totalappointmentscolumn";
            Totalappointmentscolumn.Width = 200;
            // 
            // Lastappointmentcolumn
            // 
            Lastappointmentcolumn.HeaderText = "Last Appointment Date";
            Lastappointmentcolumn.Name = "Lastappointmentcolumn";
            Lastappointmentcolumn.Width = 180;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(96, 370);
            label10.Name = "label10";
            label10.Size = new Size(35, 15);
            label10.TabIndex = 13;
            label10.Text = "From";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(312, 370);
            label11.Name = "label11";
            label11.Size = new Size(19, 15);
            label11.TabIndex = 12;
            label11.Text = "To";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Navy;
            label8.Location = new Point(45, 342);
            label8.Name = "label8";
            label8.Size = new Size(214, 18);
            label8.TabIndex = 9;
            label8.Text = "View Patient appointment trends";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Navy;
            label7.Location = new Point(45, 65);
            label7.Name = "label7";
            label7.Size = new Size(138, 18);
            label7.TabIndex = 8;
            label7.Text = "View Doctor Shedule";
            // 
            // combodoctorshedule
            // 
            combodoctorshedule.BackColor = SystemColors.InactiveBorder;
            combodoctorshedule.FormattingEnabled = true;
            combodoctorshedule.Location = new Point(46, 108);
            combodoctorshedule.Name = "combodoctorshedule";
            combodoctorshedule.Size = new Size(116, 23);
            combodoctorshedule.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(275, 90);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 4;
            label6.Text = "From";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(470, 90);
            label5.Name = "label5";
            label5.Size = new Size(19, 15);
            label5.TabIndex = 3;
            label5.Text = "To";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 90);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 2;
            label4.Text = "Select Doctor";
            // 
            // dataGriddoctorshedule
            // 
            dataGriddoctorshedule.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGriddoctorshedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGriddoctorshedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGriddoctorshedule.Columns.AddRange(new DataGridViewColumn[] { patientcolumnshedule, appointmentdatecolumnshedule, appointmenttimecolumnshedule, statuscolumnshedule });
            dataGriddoctorshedule.Location = new Point(56, 149);
            dataGriddoctorshedule.Name = "dataGriddoctorshedule";
            dataGriddoctorshedule.Size = new Size(583, 178);
            dataGriddoctorshedule.TabIndex = 1;
            // 
            // patientcolumnshedule
            // 
            patientcolumnshedule.HeaderText = "Patient Name";
            patientcolumnshedule.MinimumWidth = 10;
            patientcolumnshedule.Name = "patientcolumnshedule";
            patientcolumnshedule.Width = 130;
            // 
            // appointmentdatecolumnshedule
            // 
            appointmentdatecolumnshedule.HeaderText = "Appointment Date ";
            appointmentdatecolumnshedule.Name = "appointmentdatecolumnshedule";
            appointmentdatecolumnshedule.Width = 140;
            // 
            // appointmenttimecolumnshedule
            // 
            appointmenttimecolumnshedule.HeaderText = "Appointment Time";
            appointmenttimecolumnshedule.Name = "appointmenttimecolumnshedule";
            appointmenttimecolumnshedule.Width = 140;
            // 
            // statuscolumnshedule
            // 
            statuscolumnshedule.HeaderText = "Status";
            statuscolumnshedule.Name = "statuscolumnshedule";
            statuscolumnshedule.Width = 130;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Book", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(245, 19);
            label1.Name = "label1";
            label1.Size = new Size(162, 24);
            label1.TabIndex = 0;
            label1.Text = "Generate reports";
            // 
            // button1
            // 
            button1.BackColor = Color.LightSteelBlue;
            button1.Location = new Point(24, 170);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(113, 28);
            button1.TabIndex = 11;
            button1.Text = "Generate Reports";
            button1.UseVisualStyleBackColor = false;
            // 
            // Reportadmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 651);
            Controls.Add(flowLayoutPanel1);
            Name = "Reportadmin";
            Text = "reportadmin";
            Load += Reportadmin_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewpatienttrend).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGriddoctorshedule).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Button logoutbtn;
        private Button navappointmentbtn;
        private Button navpatientbtn;
        private Button navdocbtn;
        private Panel panel2;
        private Label label1;
        private DataGridView dataGriddoctorshedule;
        private ComboBox combodoctorshedule;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label8;
        private Label label7;
        private Label label10;
        private Label label11;
        private DataGridView dataGridViewpatienttrend;
        private DateTimePicker doctorsheduledateto;
        private DateTimePicker doctorsheduledatefrom;
        private DateTimePicker patienttrenddatefrom;
        private DateTimePicker patienttrenddateto;
        private DataGridViewTextBoxColumn patientcolumnshedule;
        private DataGridViewTextBoxColumn appointmentdatecolumnshedule;
        private DataGridViewTextBoxColumn appointmenttimecolumnshedule;
        private DataGridViewTextBoxColumn statuscolumnshedule;
        private Button generateDoctorShedule;
        private Button generatepatienttrendsbtn;
        private DataGridViewTextBoxColumn PatientNameColumn;
        private DataGridViewTextBoxColumn Totalappointmentscolumn;
        private DataGridViewTextBoxColumn Lastappointmentcolumn;
        private Button button1;
    }
}