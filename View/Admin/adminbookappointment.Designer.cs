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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            flowLayoutPanel1 = new FlowLayoutPanel();
            sidenav = new Panel();
            label3 = new Label();
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
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1037, 445);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // sidenav
            // 
            sidenav.BackColor = Color.CornflowerBlue;
            sidenav.Controls.Add(label3);
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
            sidenav.Size = new Size(174, 446);
            sidenav.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(41, 47);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(106, 19);
            label3.TabIndex = 6;
            label3.Text = "Admin ID-2346";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kristen ITC", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(18, 23);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(113, 27);
            label2.TabIndex = 5;
            label2.Text = "John Doe";
            // 
            // navprofile
            // 
            navprofile.BackColor = Color.LightSteelBlue;
            navprofile.Location = new Point(13, 342);
            navprofile.Margin = new Padding(2);
            navprofile.Name = "navprofile";
            navprofile.Size = new Size(145, 29);
            navprofile.TabIndex = 4;
            navprofile.Text = "MyProfile";
            navprofile.UseVisualStyleBackColor = false;
            // 
            // logout
            // 
            logout.BackColor = Color.LightSteelBlue;
            logout.Location = new Point(13, 375);
            logout.Margin = new Padding(2);
            logout.Name = "logout";
            logout.Size = new Size(145, 29);
            logout.TabIndex = 3;
            logout.Text = "LogOut";
            logout.UseVisualStyleBackColor = false;
            // 
            // navappointment
            // 
            navappointment.BackColor = Color.LightSteelBlue;
            navappointment.Location = new Point(13, 153);
            navappointment.Margin = new Padding(2);
            navappointment.Name = "navappointment";
            navappointment.Size = new Size(145, 28);
            navappointment.TabIndex = 2;
            navappointment.Text = "Appointment Schedules";
            navappointment.UseVisualStyleBackColor = false;
            // 
            // navpatient
            // 
            navpatient.BackColor = Color.LightSteelBlue;
            navpatient.Location = new Point(13, 121);
            navpatient.Margin = new Padding(2);
            navpatient.Name = "navpatient";
            navpatient.Size = new Size(145, 28);
            navpatient.TabIndex = 1;
            navpatient.Text = "Patients";
            navpatient.UseVisualStyleBackColor = false;
            // 
            // navdoc
            // 
            navdoc.BackColor = Color.LightSteelBlue;
            navdoc.Location = new Point(13, 91);
            navdoc.Margin = new Padding(2);
            navdoc.Name = "navdoc";
            navdoc.Size = new Size(145, 28);
            navdoc.TabIndex = 0;
            navdoc.Text = "Doctors";
            navdoc.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridAdminPatient);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(174, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(844, 446);
            panel1.TabIndex = 3;
            //panel1.Paint += panel1_Paint;
            // 
            // dataGridAdminPatient
            // 
            dataGridAdminPatient.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridAdminPatient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridAdminPatient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAdminPatient.Columns.AddRange(new DataGridViewColumn[] { AppointmentIDcolumn, Patientnamecolumn, Doctornamecolumn, DateColumn, TimeColumn, StatusColumn, ResheduleColumn, CancelColumn });
            dataGridAdminPatient.Location = new Point(43, 91);
            dataGridAdminPatient.Margin = new Padding(0);
            dataGridAdminPatient.Name = "dataGridAdminPatient";
            dataGridAdminPatient.Size = new Size(783, 272);
            dataGridAdminPatient.TabIndex = 1;
            dataGridAdminPatient.CellClick += dataGridAdminPatient_CellClick;
            //dataGridAdminPatient.CellContentClick += dataGridAdminPatient_CellContentClick;
            // 
            // AppointmentIDcolumn
            // 
            AppointmentIDcolumn.HeaderText = "Appointment ID";
            AppointmentIDcolumn.Name = "AppointmentIDcolumn";
            // 
            // Patientnamecolumn
            // 
            Patientnamecolumn.HeaderText = "Patient Name";
            Patientnamecolumn.Name = "Patientnamecolumn";
            Patientnamecolumn.Width = 120;
            // 
            // Doctornamecolumn
            // 
            Doctornamecolumn.HeaderText = "Doctor Name";
            Doctornamecolumn.Name = "Doctornamecolumn";
            Doctornamecolumn.Width = 120;
            // 
            // DateColumn
            // 
            DateColumn.HeaderText = "Date";
            DateColumn.Name = "DateColumn";
            // 
            // TimeColumn
            // 
            TimeColumn.HeaderText = "Time";
            TimeColumn.Name = "TimeColumn";
            // 
            // StatusColumn
            // 
            StatusColumn.HeaderText = "Status";
            StatusColumn.Name = "StatusColumn";
            // 
            // ResheduleColumn
            // 
            ResheduleColumn.HeaderText = "Reshedule";
            ResheduleColumn.Name = "ResheduleColumn";
            ResheduleColumn.Text = "Reshedule";
            ResheduleColumn.UseColumnTextForButtonValue = true;
            // 
            // CancelColumn
            // 
            CancelColumn.HeaderText = "Cancel";
            CancelColumn.Name = "CancelColumn";
            CancelColumn.Text = "Cancel";
            CancelColumn.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(273, 37);
            label1.Name = "label1";
            label1.Size = new Size(223, 29);
            label1.TabIndex = 0;
            label1.Text = "View Patient Appointments";
            // 
            // adminbookappointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 445);
            Controls.Add(flowLayoutPanel1);
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
        private Label label3;
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
    }
}