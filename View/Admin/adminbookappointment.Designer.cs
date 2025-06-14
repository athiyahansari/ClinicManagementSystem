namespace CMS.View.Admin
{
    partial class adminbookappointment
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            flowLayoutPanel1 = new FlowLayoutPanel();
            sidenav = new Panel();
            navreports = new Button();
            label2 = new Label();
            navprofile = new Button();
            logout = new Button();
            navappointment = new Button();
            navpatient = new Button();
            navdoc = new Button();
            panel1 = new Panel();
            dataGridAdminPatient = new DataGridView();
            AppointmentIDcolumn = new DataGridViewTextBoxColumn();
            Patientnamecolumn = new DataGridViewTextBoxColumn();
            Doctornamecolumn = new DataGridViewTextBoxColumn();
            DateColumn = new DataGridViewTextBoxColumn();
            TimeColumn = new DataGridViewTextBoxColumn();
            StatusColumn = new DataGridViewTextBoxColumn();
            ResheduleColumn = new DataGridViewButtonColumn();
            CancelColumn = new DataGridViewButtonColumn();
            label1 = new Label();
            flowLayoutPanel1.SuspendLayout();
            sidenav.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridAdminPatient).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(sidenav);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1588, 725);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // sidenav
            // 
            sidenav.BackColor = Color.CornflowerBlue;
            sidenav.Controls.Add(navreports);
            sidenav.Controls.Add(label2);
            sidenav.Controls.Add(navprofile);
            sidenav.Controls.Add(logout);
            sidenav.Controls.Add(navappointment);
            sidenav.Controls.Add(navpatient);
            sidenav.Controls.Add(navdoc);
            sidenav.Dock = DockStyle.Left;
            sidenav.Location = new Point(0, 0);
            sidenav.Margin = new Padding(0);
            sidenav.Name = "sidenav";
            sidenav.Size = new Size(249, 716);
            sidenav.TabIndex = 2;
            // 
            // navreports
            // 
            navreports.BackColor = Color.LightSteelBlue;
            navreports.Location = new Point(21, 306);
            navreports.Name = "navreports";
            navreports.Size = new Size(207, 47);
            navreports.TabIndex = 6;
            navreports.Text = "Generate Reports";
            navreports.UseVisualStyleBackColor = false;
            navreports.Click += navreports_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kristen ITC", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(5, 51);
            label2.Name = "label2";
            label2.Size = new Size(246, 39);
            label2.TabIndex = 5;
            label2.Text = "MedLine Clinic";
            // 
            // navprofile
            // 
            navprofile.BackColor = Color.LightSteelBlue;
            navprofile.Location = new Point(19, 570);
            navprofile.Name = "navprofile";
            navprofile.Size = new Size(207, 48);
            navprofile.TabIndex = 4;
            navprofile.Text = "MyProfile";
            navprofile.UseVisualStyleBackColor = false;
            // 
            // logout
            // 
            logout.BackColor = Color.LightSteelBlue;
            logout.Location = new Point(19, 625);
            logout.Name = "logout";
            logout.Size = new Size(207, 48);
            logout.TabIndex = 3;
            logout.Text = "LogOut";
            logout.UseVisualStyleBackColor = false;
            // 
            // navappointment
            // 
            navappointment.Anchor = AnchorStyles.None;
            navappointment.BackColor = Color.LightSteelBlue;
            navappointment.Location = new Point(19, 255);
            navappointment.Name = "navappointment";
            navappointment.Size = new Size(207, 47);
            navappointment.TabIndex = 2;
            navappointment.Text = "Appointment Schedules";
            navappointment.UseVisualStyleBackColor = false;
            //navappointment.Click += navappointment_Click;
            // 
            // navpatient
            // 
            navpatient.BackColor = Color.LightSteelBlue;
            navpatient.Location = new Point(19, 202);
            navpatient.Name = "navpatient";
            navpatient.Size = new Size(207, 47);
            navpatient.TabIndex = 1;
            navpatient.Text = "Patients";
            navpatient.UseVisualStyleBackColor = false;
            navpatient.Click += navpatient_Click;
            // 
            // navdoc
            // 
            navdoc.BackColor = Color.LightSteelBlue;
            navdoc.Location = new Point(19, 152);
            navdoc.Name = "navdoc";
            navdoc.Size = new Size(207, 47);
            navdoc.TabIndex = 0;
            navdoc.Text = "Doctors";
            navdoc.UseVisualStyleBackColor = false;
            navdoc.Click += navdoc_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridAdminPatient);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(249, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1339, 716);
            panel1.TabIndex = 3;
            // 
            // dataGridAdminPatient
            // 
            dataGridAdminPatient.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridAdminPatient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridAdminPatient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAdminPatient.Columns.AddRange(new DataGridViewColumn[] { AppointmentIDcolumn, Patientnamecolumn, Doctornamecolumn, DateColumn, TimeColumn, StatusColumn, ResheduleColumn, CancelColumn });
            dataGridAdminPatient.Location = new Point(86, 152);
            dataGridAdminPatient.Margin = new Padding(0);
            dataGridAdminPatient.Name = "dataGridAdminPatient";
            dataGridAdminPatient.RowHeadersWidth = 62;
            dataGridAdminPatient.Size = new Size(1207, 485);
            dataGridAdminPatient.TabIndex = 1;
            dataGridAdminPatient.CellClick += dataGridAdminPatient_CellClick;
            // 
            // AppointmentIDcolumn
            // 
            AppointmentIDcolumn.HeaderText = "Appointment ID";
            AppointmentIDcolumn.MinimumWidth = 8;
            AppointmentIDcolumn.Name = "AppointmentIDcolumn";
            AppointmentIDcolumn.Width = 150;
            // 
            // Patientnamecolumn
            // 
            Patientnamecolumn.HeaderText = "Patient Name";
            Patientnamecolumn.MinimumWidth = 8;
            Patientnamecolumn.Name = "Patientnamecolumn";
            Patientnamecolumn.Width = 120;
            // 
            // Doctornamecolumn
            // 
            Doctornamecolumn.HeaderText = "Doctor Name";
            Doctornamecolumn.MinimumWidth = 8;
            Doctornamecolumn.Name = "Doctornamecolumn";
            Doctornamecolumn.Width = 120;
            // 
            // DateColumn
            // 
            DateColumn.HeaderText = "Date";
            DateColumn.MinimumWidth = 8;
            DateColumn.Name = "DateColumn";
            DateColumn.Width = 150;
            // 
            // TimeColumn
            // 
            TimeColumn.HeaderText = "Time";
            TimeColumn.MinimumWidth = 8;
            TimeColumn.Name = "TimeColumn";
            TimeColumn.Width = 150;
            // 
            // StatusColumn
            // 
            StatusColumn.HeaderText = "Status";
            StatusColumn.MinimumWidth = 8;
            StatusColumn.Name = "StatusColumn";
            StatusColumn.Width = 150;
            // 
            // ResheduleColumn
            // 
            ResheduleColumn.HeaderText = "Reshedule";
            ResheduleColumn.MinimumWidth = 8;
            ResheduleColumn.Name = "ResheduleColumn";
            ResheduleColumn.Text = "Reshedule";
            ResheduleColumn.UseColumnTextForButtonValue = true;
            ResheduleColumn.Width = 150;
            // 
            // CancelColumn
            // 
            CancelColumn.HeaderText = "Cancel";
            CancelColumn.MinimumWidth = 8;
            CancelColumn.Name = "CancelColumn";
            CancelColumn.Text = "Cancel";
            CancelColumn.UseColumnTextForButtonValue = true;
            CancelColumn.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(447, 62);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(332, 43);
            label1.TabIndex = 0;
            label1.Text = "View Patient Appointments";
            // 
            // adminbookappointment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1588, 725);
            Controls.Add(flowLayoutPanel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "adminbookappointment";
            Text = "adminbookappointment";
            Load += adminbookappointment_Load;
            flowLayoutPanel1.ResumeLayout(false);
            sidenav.ResumeLayout(false);
            sidenav.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridAdminPatient).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel sidenav;
        private Label label2;
        private Button navprofile;
        private Button logout;
        private Button navappointment;
        private Button navpatient;
        private Button navdoc;
        private Panel panel1;
        private Label label1;
        private DataGridView dataGridAdminPatient;
        private DataGridViewTextBoxColumn AppointmentIDcolumn;
        private DataGridViewTextBoxColumn Patientnamecolumn;
        private DataGridViewTextBoxColumn Doctornamecolumn;
        private DataGridViewTextBoxColumn DateColumn;
        private DataGridViewTextBoxColumn TimeColumn;
        private DataGridViewTextBoxColumn StatusColumn;
        private DataGridViewButtonColumn ResheduleColumn;
        private DataGridViewButtonColumn CancelColumn;
        private Button navreports;
    }
}