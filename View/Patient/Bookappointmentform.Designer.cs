namespace CMS
{
    partial class Bookappointmentform
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
            flowLayoutPanelmain = new FlowLayoutPanel();
            panel1 = new Panel();
            logoutbtn = new Button();
            profilebtn = new Button();
            historybtn = new Button();
            prescrbtn = new Button();
            doctorbtn = new Button();
            appointmentbtn = new Button();
            lablid = new Label();
            lablpatient1 = new Label();
            panel5 = new Panel();
            panel2 = new Panel();
            bookappobtn = new Button();
            notes = new TextBox();
            label6 = new Label();
            time = new TextBox();
            label5 = new Label();
            date = new TextBox();
            label4 = new Label();
            combodoctor = new ComboBox();
            patientname = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            managelbl = new Label();
            appoinmentslbl = new Label();
            flowLayoutPanelmain.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanelmain
            // 
            flowLayoutPanelmain.AutoScroll = true;
            flowLayoutPanelmain.Controls.Add(panel1);
            flowLayoutPanelmain.Controls.Add(panel5);
            flowLayoutPanelmain.Dock = DockStyle.Fill;
            flowLayoutPanelmain.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelmain.Location = new Point(0, 0);
            flowLayoutPanelmain.Name = "flowLayoutPanelmain";
            flowLayoutPanelmain.Size = new Size(968, 663);
            flowLayoutPanelmain.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(logoutbtn);
            panel1.Controls.Add(profilebtn);
            panel1.Controls.Add(historybtn);
            panel1.Controls.Add(prescrbtn);
            panel1.Controls.Add(doctorbtn);
            panel1.Controls.Add(appointmentbtn);
            panel1.Controls.Add(lablid);
            panel1.Controls.Add(lablpatient1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(155, 663);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // logoutbtn
            // 
            logoutbtn.BackColor = Color.LightSteelBlue;
            logoutbtn.Location = new Point(21, 394);
            logoutbtn.Name = "logoutbtn";
            logoutbtn.Size = new Size(113, 26);
            logoutbtn.TabIndex = 7;
            logoutbtn.Text = "Log Out";
            logoutbtn.UseVisualStyleBackColor = false;
            // 
            // profilebtn
            // 
            profilebtn.BackColor = Color.LightSteelBlue;
            profilebtn.Location = new Point(21, 362);
            profilebtn.Name = "profilebtn";
            profilebtn.Size = new Size(113, 26);
            profilebtn.TabIndex = 6;
            profilebtn.Text = "My Profile";
            profilebtn.UseVisualStyleBackColor = false;
            // 
            // historybtn
            // 
            historybtn.BackColor = Color.LightSteelBlue;
            historybtn.Location = new Point(21, 202);
            historybtn.Name = "historybtn";
            historybtn.Size = new Size(113, 26);
            historybtn.TabIndex = 5;
            historybtn.Text = "Medical History";
            historybtn.UseVisualStyleBackColor = false;
            // 
            // prescrbtn
            // 
            prescrbtn.BackColor = Color.LightSteelBlue;
            prescrbtn.Location = new Point(21, 170);
            prescrbtn.Name = "prescrbtn";
            prescrbtn.Size = new Size(113, 26);
            prescrbtn.TabIndex = 4;
            prescrbtn.Text = "Prescriptions";
            prescrbtn.UseVisualStyleBackColor = false;
            // 
            // doctorbtn
            // 
            doctorbtn.BackColor = Color.LightSteelBlue;
            doctorbtn.Location = new Point(21, 105);
            doctorbtn.Name = "doctorbtn";
            doctorbtn.Size = new Size(113, 28);
            doctorbtn.TabIndex = 3;
            doctorbtn.Text = "Doctor";
            doctorbtn.UseVisualStyleBackColor = false;
            // 
            // appointmentbtn
            // 
            appointmentbtn.BackColor = Color.LightSteelBlue;
            appointmentbtn.Location = new Point(21, 138);
            appointmentbtn.Name = "appointmentbtn";
            appointmentbtn.Size = new Size(113, 26);
            appointmentbtn.TabIndex = 2;
            appointmentbtn.Text = "Appointments";
            appointmentbtn.UseVisualStyleBackColor = false;
            // 
            // lablid
            // 
            lablid.AutoSize = true;
            lablid.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lablid.ForeColor = SystemColors.ButtonHighlight;
            lablid.Location = new Point(39, 50);
            lablid.Name = "lablid";
            lablid.Size = new Size(105, 17);
            lablid.TabIndex = 1;
            lablid.Text = "Patient ID -2356";
            // 
            // lablpatient1
            // 
            lablpatient1.AutoSize = true;
            lablpatient1.Font = new Font("Kristen ITC", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lablpatient1.ForeColor = SystemColors.ControlLightLight;
            lablpatient1.Location = new Point(21, 23);
            lablpatient1.Name = "lablpatient1";
            lablpatient1.Size = new Size(113, 27);
            lablpatient1.TabIndex = 0;
            lablpatient1.Text = "John Doe";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Lavender;
            panel5.Controls.Add(panel2);
            panel5.Controls.Add(dataGridView1);
            panel5.Controls.Add(managelbl);
            panel5.Controls.Add(appoinmentslbl);
            panel5.Location = new Point(155, 0);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(813, 663);
            panel5.TabIndex = 3;
            panel5.Paint += panel5_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 192, 255);
            panel2.Controls.Add(bookappobtn);
            panel2.Controls.Add(notes);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(time);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(date);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(combodoctor);
            panel2.Controls.Add(patientname);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(239, 317);
            panel2.Name = "panel2";
            panel2.Size = new Size(306, 320);
            panel2.TabIndex = 13;
            // 
            // bookappobtn
            // 
            bookappobtn.BackColor = SystemColors.ActiveCaption;
            bookappobtn.FlatStyle = FlatStyle.Flat;
            bookappobtn.Location = new Point(82, 279);
            bookappobtn.Name = "bookappobtn";
            bookappobtn.Size = new Size(155, 23);
            bookappobtn.TabIndex = 24;
            bookappobtn.Text = "Book appointment";
            bookappobtn.UseVisualStyleBackColor = false;
            // 
            // notes
            // 
            notes.Location = new Point(19, 236);
            notes.Name = "notes";
            notes.Size = new Size(273, 23);
            notes.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 218);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 22;
            label6.Text = "Notes";
            // 
            // time
            // 
            time.Location = new Point(156, 183);
            time.Name = "time";
            time.Size = new Size(97, 23);
            time.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(156, 165);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 20;
            label5.Text = "Time";
            // 
            // date
            // 
            date.Location = new Point(19, 183);
            date.Name = "date";
            date.Size = new Size(97, 23);
            date.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 165);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 18;
            label4.Text = "Date";
            // 
            // combodoctor
            // 
            combodoctor.FormattingEnabled = true;
            combodoctor.Location = new Point(19, 132);
            combodoctor.Name = "combodoctor";
            combodoctor.Size = new Size(258, 23);
            combodoctor.TabIndex = 17;
            // 
            // patientname
            // 
            patientname.Location = new Point(19, 73);
            patientname.Name = "patientname";
            patientname.Size = new Size(273, 23);
            patientname.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 114);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 15;
            label3.Text = "Doctor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 55);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 13;
            label2.Text = "Patient Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(69, 12);
            label1.Name = "label1";
            label1.Size = new Size(168, 20);
            label1.TabIndex = 12;
            label1.Text = "Book new appointment";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridView1.Location = new Point(22, 90);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(742, 210);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Doctor";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Time";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Date";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Consultation";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Status";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Reshedule";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Cancel";
            Column7.Name = "Column7";
            // 
            // managelbl
            // 
            managelbl.AutoSize = true;
            managelbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            managelbl.Location = new Point(22, 45);
            managelbl.Name = "managelbl";
            managelbl.Size = new Size(219, 17);
            managelbl.TabIndex = 1;
            managelbl.Text = "Manage your medical appointments";
            // 
            // appoinmentslbl
            // 
            appoinmentslbl.AutoSize = true;
            appoinmentslbl.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            appoinmentslbl.Location = new Point(22, 22);
            appoinmentslbl.Name = "appoinmentslbl";
            appoinmentslbl.Size = new Size(126, 23);
            appoinmentslbl.TabIndex = 0;
            appoinmentslbl.Text = "Appointments";
            // 
            // Bookappointmentform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(968, 663);
            Controls.Add(flowLayoutPanelmain);
            Name = "Bookappointmentform";
            Text = "Bookappoinmentform";
            flowLayoutPanelmain.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelmain;
        private Panel panel1;
        private Button doctorbtn;
        private Button appointmentbtn;
        private Label lablid;
        private Label lablpatient1;
        private Panel panel5;
        private Label managelbl;
        private Label appoinmentslbl;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private Button logoutbtn;
        private Button profilebtn;
        private Button historybtn;
        private Button prescrbtn;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private TextBox patientname;
        private TextBox time;
        private Label label5;
        private TextBox date;
        private Label label4;
        private ComboBox combodoctor;
        private Label label3;
        private TextBox notes;
        private Label label6;
        private Button bookappobtn;
    }
}