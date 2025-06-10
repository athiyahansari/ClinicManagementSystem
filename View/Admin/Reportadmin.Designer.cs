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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            navprofilebtn = new Button();
            logoutbtn = new Button();
            navappointmentbtn = new Button();
            navpatientbtn = new Button();
            navdocbtn = new Button();
            panel2 = new Panel();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            patienttodatepick = new TextBox();
            patientdatepick = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label8 = new Label();
            label7 = new Label();
            combodoctor = new ComboBox();
            todatepick = new TextBox();
            datepick = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(navprofilebtn);
            panel1.Controls.Add(logoutbtn);
            panel1.Controls.Add(navappointmentbtn);
            panel1.Controls.Add(navpatientbtn);
            panel1.Controls.Add(navdocbtn);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(166, 653);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(44, 65);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(106, 19);
            label3.TabIndex = 13;
            label3.Text = "Admin ID-2346";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kristen ITC", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(21, 41);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(113, 27);
            label2.TabIndex = 12;
            label2.Text = "John Doe";
            // 
            // navprofilebtn
            // 
            navprofilebtn.BackColor = Color.LightSteelBlue;
            navprofilebtn.Location = new Point(21, 388);
            navprofilebtn.Margin = new Padding(2);
            navprofilebtn.Name = "navprofilebtn";
            navprofilebtn.Size = new Size(113, 28);
            navprofilebtn.TabIndex = 11;
            navprofilebtn.Text = "MyProfile";
            navprofilebtn.UseVisualStyleBackColor = false;
            // 
            // logoutbtn
            // 
            logoutbtn.BackColor = Color.LightSteelBlue;
            logoutbtn.Location = new Point(21, 417);
            logoutbtn.Margin = new Padding(2);
            logoutbtn.Name = "logoutbtn";
            logoutbtn.Size = new Size(113, 28);
            logoutbtn.TabIndex = 10;
            logoutbtn.Text = "LogOut";
            logoutbtn.UseVisualStyleBackColor = false;
            // 
            // navappointmentbtn
            // 
            navappointmentbtn.BackColor = Color.LightSteelBlue;
            navappointmentbtn.Location = new Point(21, 168);
            navappointmentbtn.Margin = new Padding(2);
            navappointmentbtn.Name = "navappointmentbtn";
            navappointmentbtn.Size = new Size(113, 28);
            navappointmentbtn.TabIndex = 9;
            navappointmentbtn.Text = "Appointment Schedules";
            navappointmentbtn.UseVisualStyleBackColor = false;
            // 
            // navpatientbtn
            // 
            navpatientbtn.BackColor = Color.LightSteelBlue;
            navpatientbtn.Location = new Point(21, 137);
            navpatientbtn.Margin = new Padding(2);
            navpatientbtn.Name = "navpatientbtn";
            navpatientbtn.Size = new Size(113, 28);
            navpatientbtn.TabIndex = 8;
            navpatientbtn.Text = "Patients";
            navpatientbtn.UseVisualStyleBackColor = false;
            // 
            // navdocbtn
            // 
            navdocbtn.BackColor = Color.LightSteelBlue;
            navdocbtn.Location = new Point(21, 107);
            navdocbtn.Margin = new Padding(2);
            navdocbtn.Name = "navdocbtn";
            navdocbtn.Size = new Size(113, 28);
            navdocbtn.TabIndex = 7;
            navdocbtn.Text = "Doctors";
            navdocbtn.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView2);
            panel2.Controls.Add(patienttodatepick);
            panel2.Controls.Add(patientdatepick);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(combodoctor);
            panel2.Controls.Add(todatepick);
            panel2.Controls.Add(datepick);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(166, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(665, 653);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint_1;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dataGridView2.Location = new Point(56, 429);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(543, 178);
            dataGridView2.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Patient Name";
            dataGridViewTextBoxColumn1.MinimumWidth = 10;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Total Appointments";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Last Appointment Date";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 180;
            // 
            // patienttodatepick
            // 
            patienttodatepick.BackColor = SystemColors.InactiveBorder;
            patienttodatepick.Location = new Point(251, 388);
            patienttodatepick.Name = "patienttodatepick";
            patienttodatepick.Size = new Size(100, 23);
            patienttodatepick.TabIndex = 15;
            // 
            // patientdatepick
            // 
            patientdatepick.BackColor = SystemColors.InactiveBorder;
            patientdatepick.Location = new Point(67, 388);
            patientdatepick.Name = "patientdatepick";
            patientdatepick.Size = new Size(95, 23);
            patientdatepick.TabIndex = 14;
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
            label11.Location = new Point(291, 370);
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
            // combodoctor
            // 
            combodoctor.BackColor = SystemColors.InactiveBorder;
            combodoctor.FormattingEnabled = true;
            combodoctor.Location = new Point(67, 107);
            combodoctor.Name = "combodoctor";
            combodoctor.Size = new Size(116, 23);
            combodoctor.TabIndex = 7;
            // 
            // todatepick
            // 
            todatepick.BackColor = SystemColors.InactiveBorder;
            todatepick.Location = new Point(451, 107);
            todatepick.Name = "todatepick";
            todatepick.Size = new Size(100, 23);
            todatepick.TabIndex = 6;
            // 
            // datepick
            // 
            datepick.BackColor = SystemColors.InactiveBorder;
            datepick.Location = new Point(267, 107);
            datepick.Name = "datepick";
            datepick.Size = new Size(95, 23);
            datepick.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(296, 89);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 4;
            label6.Text = "From";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(491, 89);
            label5.Name = "label5";
            label5.Size = new Size(19, 15);
            label5.TabIndex = 3;
            label5.Text = "To";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(82, 89);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 2;
            label4.Text = "Select Doctor";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location = new Point(67, 149);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(513, 178);
            dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "Patient Name";
            Column1.MinimumWidth = 10;
            Column1.Name = "Column1";
            Column1.Width = 120;
            // 
            // Column2
            // 
            Column2.HeaderText = "Appointment Date & Time";
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.HeaderText = "Status";
            Column3.Name = "Column3";
            Column3.Width = 150;
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
            // Reportadmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 651);
            Controls.Add(flowLayoutPanel1);
            Name = "Reportadmin";
            Text = "reportadmin";
            Load += Reportadmin_Load_1;
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Button navprofilebtn;
        private Button logoutbtn;
        private Button navappointmentbtn;
        private Button navpatientbtn;
        private Button navdocbtn;
        private Panel panel2;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private ComboBox combodoctor;
        private TextBox todatepick;
        private TextBox datepick;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label8;
        private Label label7;
        private TextBox patienttodatepick;
        private TextBox patientdatepick;
        private Label label10;
        private Label label11;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}