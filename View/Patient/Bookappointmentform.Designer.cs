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
            flowLayoutPanelmain = new FlowLayoutPanel();
            panel1 = new Panel();
            profilebtn = new Button();
            appointmentbtn = new Button();
            lablid = new Label();
            lablpatient1 = new Label();
            panel5 = new Panel();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            totalappopanel = new Panel();
            label15 = new Label();
            label16 = new Label();
            upcomingpanel = new Panel();
            label17 = new Label();
            label18 = new Label();
            completedpnl = new Panel();
            label25 = new Label();
            label26 = new Label();
            managelbl = new Label();
            appoinmentslbl = new Label();
            flowLayoutPanelmain.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            totalappopanel.SuspendLayout();
            upcomingpanel.SuspendLayout();
            completedpnl.SuspendLayout();
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
            flowLayoutPanelmain.Size = new Size(923, 499);
            flowLayoutPanelmain.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(profilebtn);
            panel1.Controls.Add(appointmentbtn);
            panel1.Controls.Add(lablid);
            panel1.Controls.Add(lablpatient1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(135, 499);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // profilebtn
            // 
            profilebtn.Location = new Point(10, 137);
            profilebtn.Name = "profilebtn";
            profilebtn.Size = new Size(111, 24);
            profilebtn.TabIndex = 3;
            profilebtn.Text = "Patient profile";
            profilebtn.UseVisualStyleBackColor = true;
            // 
            // appointmentbtn
            // 
            appointmentbtn.Location = new Point(10, 105);
            appointmentbtn.Name = "appointmentbtn";
            appointmentbtn.Size = new Size(111, 26);
            appointmentbtn.TabIndex = 2;
            appointmentbtn.Text = "Appointments";
            appointmentbtn.UseVisualStyleBackColor = true;
            // 
            // lablid
            // 
            lablid.AutoSize = true;
            lablid.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lablid.ForeColor = SystemColors.ButtonHighlight;
            lablid.Location = new Point(21, 50);
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
            lablpatient1.Location = new Point(3, 23);
            lablpatient1.Name = "lablpatient1";
            lablpatient1.Size = new Size(113, 27);
            lablpatient1.TabIndex = 0;
            lablpatient1.Text = "John Doe";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Lavender;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(dataGridView1);
            panel5.Controls.Add(totalappopanel);
            panel5.Controls.Add(upcomingpanel);
            panel5.Controls.Add(completedpnl);
            panel5.Controls.Add(managelbl);
            panel5.Controls.Add(appoinmentslbl);
            panel5.Location = new Point(135, 0);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(788, 499);
            panel5.TabIndex = 3;
            panel5.Paint += panel5_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridView1.Location = new Point(22, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(743, 210);
            dataGridView1.TabIndex = 10;
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
            // totalappopanel
            // 
            totalappopanel.BorderStyle = BorderStyle.FixedSingle;
            totalappopanel.Controls.Add(label15);
            totalappopanel.Controls.Add(label16);
            totalappopanel.Location = new Point(70, 334);
            totalappopanel.Name = "totalappopanel";
            totalappopanel.Size = new Size(171, 35);
            totalappopanel.TabIndex = 8;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(148, 5);
            label15.Name = "label15";
            label15.Size = new Size(14, 15);
            label15.TabIndex = 6;
            label15.Text = "7";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(-1, 2);
            label16.Name = "label16";
            label16.Size = new Size(117, 17);
            label16.TabIndex = 0;
            label16.Text = "Total Appoinments";
            // 
            // upcomingpanel
            // 
            upcomingpanel.BorderStyle = BorderStyle.FixedSingle;
            upcomingpanel.Controls.Add(label17);
            upcomingpanel.Controls.Add(label18);
            upcomingpanel.Location = new Point(324, 334);
            upcomingpanel.Name = "upcomingpanel";
            upcomingpanel.Size = new Size(169, 35);
            upcomingpanel.TabIndex = 9;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(150, 2);
            label17.Name = "label17";
            label17.Size = new Size(14, 15);
            label17.TabIndex = 6;
            label17.Text = "2";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(3, 2);
            label18.Name = "label18";
            label18.Size = new Size(72, 17);
            label18.TabIndex = 0;
            label18.Text = "Upcoming ";
            // 
            // completedpnl
            // 
            completedpnl.BorderStyle = BorderStyle.FixedSingle;
            completedpnl.Controls.Add(label25);
            completedpnl.Controls.Add(label26);
            completedpnl.Location = new Point(555, 334);
            completedpnl.Name = "completedpnl";
            completedpnl.Size = new Size(160, 35);
            completedpnl.TabIndex = 8;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label25.Location = new Point(141, 1);
            label25.Name = "label25";
            label25.Size = new Size(14, 15);
            label25.TabIndex = 6;
            label25.Text = "5";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label26.Location = new Point(3, 2);
            label26.Name = "label26";
            label26.Size = new Size(72, 17);
            label26.TabIndex = 0;
            label26.Text = "Completed";
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
            ClientSize = new Size(923, 499);
            Controls.Add(flowLayoutPanelmain);
            Name = "Bookappointmentform";
            Text = "Bookappoinmentform";
            //Load += this.Bookappointmentform_Load;
            flowLayoutPanelmain.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            totalappopanel.ResumeLayout(false);
            totalappopanel.PerformLayout();
            upcomingpanel.ResumeLayout(false);
            upcomingpanel.PerformLayout();
            completedpnl.ResumeLayout(false);
            completedpnl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelmain;
        private Panel panel1;
        private Button profilebtn;
        private Button appointmentbtn;
        private Label lablid;
        private Label lablpatient1;
        private Panel panel5;
        private Panel totalappopanel;
        private Label label15;
        private Label label16;
        private Panel upcomingpanel;
        private Label label17;
        private Label label18;
        private Panel completedpnl;
        private Label label25;
        private Label label26;
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
    }
}