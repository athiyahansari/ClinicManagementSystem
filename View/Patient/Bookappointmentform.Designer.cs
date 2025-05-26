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
            totalappopanel = new Panel();
            label15 = new Label();
            label16 = new Label();
            upcomingpanel = new Panel();
            label17 = new Label();
            label18 = new Label();
            completedpnl = new Panel();
            label25 = new Label();
            label26 = new Label();
            panel12 = new Panel();
            label27 = new Label();
            timelbl2 = new Label();
            cancelbtn2 = new Button();
            label29 = new Label();
            reshedulebtn2 = new Button();
            datelbl2 = new Label();
            label31 = new Label();
            panel13 = new Panel();
            label32 = new Label();
            timelbl1 = new Label();
            cancelbtn1 = new Button();
            label34 = new Label();
            reshedulebtn1 = new Button();
            datelbl1 = new Label();
            label36 = new Label();
            newappointbtn = new Button();
            managelbl = new Label();
            appoinmentslbl = new Label();
            flowLayoutPanelmain.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            totalappopanel.SuspendLayout();
            upcomingpanel.SuspendLayout();
            completedpnl.SuspendLayout();
            panel12.SuspendLayout();
            panel13.SuspendLayout();
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
            panel5.Controls.Add(totalappopanel);
            panel5.Controls.Add(upcomingpanel);
            panel5.Controls.Add(completedpnl);
            panel5.Controls.Add(panel12);
            panel5.Controls.Add(panel13);
            panel5.Controls.Add(newappointbtn);
            panel5.Controls.Add(managelbl);
            panel5.Controls.Add(appoinmentslbl);
            panel5.Location = new Point(135, 0);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(788, 499);
            panel5.TabIndex = 3;
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
            // panel12
            // 
            panel12.BorderStyle = BorderStyle.FixedSingle;
            panel12.Controls.Add(label27);
            panel12.Controls.Add(timelbl2);
            panel12.Controls.Add(cancelbtn2);
            panel12.Controls.Add(label29);
            panel12.Controls.Add(reshedulebtn2);
            panel12.Controls.Add(datelbl2);
            panel12.Controls.Add(label31);
            panel12.Location = new Point(40, 203);
            panel12.Name = "panel12";
            panel12.Size = new Size(708, 107);
            panel12.TabIndex = 4;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.ForeColor = SystemColors.ControlDarkDark;
            label27.Location = new Point(11, 15);
            label27.Name = "label27";
            label27.Size = new Size(63, 15);
            label27.TabIndex = 6;
            label27.Text = "Upcoming";
            // 
            // timelbl2
            // 
            timelbl2.AutoSize = true;
            timelbl2.Font = new Font("Tahoma", 9.75F);
            timelbl2.Location = new Point(645, 36);
            timelbl2.Name = "timelbl2";
            timelbl2.Size = new Size(54, 16);
            timelbl2.TabIndex = 7;
            timelbl2.Text = "4.00 pm";
            // 
            // cancelbtn2
            // 
            cancelbtn2.Location = new Point(87, 79);
            cancelbtn2.Name = "cancelbtn2";
            cancelbtn2.Size = new Size(67, 22);
            cancelbtn2.TabIndex = 5;
            cancelbtn2.Text = "Cancel";
            cancelbtn2.UseVisualStyleBackColor = true;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label29.Location = new Point(11, 50);
            label29.Name = "label29";
            label29.Size = new Size(107, 17);
            label29.TabIndex = 1;
            label29.Text = "Dr. Michael Chen";
            // 
            // reshedulebtn2
            // 
            reshedulebtn2.Location = new Point(11, 79);
            reshedulebtn2.Name = "reshedulebtn2";
            reshedulebtn2.Size = new Size(70, 22);
            reshedulebtn2.TabIndex = 4;
            reshedulebtn2.Text = "Reshedule";
            reshedulebtn2.UseVisualStyleBackColor = true;
            // 
            // datelbl2
            // 
            datelbl2.AutoSize = true;
            datelbl2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            datelbl2.Location = new Point(604, 19);
            datelbl2.Name = "datelbl2";
            datelbl2.Size = new Size(99, 17);
            datelbl2.TabIndex = 6;
            datelbl2.Text = "April 28th 2025";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label31.Location = new Point(11, 30);
            label31.Name = "label31";
            label31.Size = new Size(118, 20);
            label31.TabIndex = 0;
            label31.Text = "Dental Cleaning";
            // 
            // panel13
            // 
            panel13.BorderStyle = BorderStyle.FixedSingle;
            panel13.Controls.Add(label32);
            panel13.Controls.Add(timelbl1);
            panel13.Controls.Add(cancelbtn1);
            panel13.Controls.Add(label34);
            panel13.Controls.Add(reshedulebtn1);
            panel13.Controls.Add(datelbl1);
            panel13.Controls.Add(label36);
            panel13.Location = new Point(41, 89);
            panel13.Name = "panel13";
            panel13.Size = new Size(707, 108);
            panel13.TabIndex = 3;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.ForeColor = SystemColors.ControlDarkDark;
            label32.Location = new Point(10, 13);
            label32.Name = "label32";
            label32.Size = new Size(63, 15);
            label32.TabIndex = 6;
            label32.Text = "Upcoming";
            // 
            // timelbl1
            // 
            timelbl1.AutoSize = true;
            timelbl1.Font = new Font("Tahoma", 9.75F);
            timelbl1.Location = new Point(638, 36);
            timelbl1.Name = "timelbl1";
            timelbl1.Size = new Size(61, 16);
            timelbl1.TabIndex = 7;
            timelbl1.Text = "10.30 am";
            // 
            // cancelbtn1
            // 
            cancelbtn1.Location = new Point(86, 77);
            cancelbtn1.Name = "cancelbtn1";
            cancelbtn1.Size = new Size(67, 22);
            cancelbtn1.TabIndex = 5;
            cancelbtn1.Text = "Cancel";
            cancelbtn1.UseVisualStyleBackColor = true;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label34.Location = new Point(10, 48);
            label34.Name = "label34";
            label34.Size = new Size(105, 17);
            label34.TabIndex = 1;
            label34.Text = "Dr. Sarah Wilson";
            // 
            // reshedulebtn1
            // 
            reshedulebtn1.Location = new Point(10, 77);
            reshedulebtn1.Name = "reshedulebtn1";
            reshedulebtn1.Size = new Size(70, 22);
            reshedulebtn1.TabIndex = 4;
            reshedulebtn1.Text = "Reshedule";
            reshedulebtn1.UseVisualStyleBackColor = true;
            // 
            // datelbl1
            // 
            datelbl1.AutoSize = true;
            datelbl1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            datelbl1.Location = new Point(604, 19);
            datelbl1.Name = "datelbl1";
            datelbl1.Size = new Size(95, 17);
            datelbl1.TabIndex = 6;
            datelbl1.Text = "May 15th 2025";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label36.Location = new Point(10, 28);
            label36.Name = "label36";
            label36.Size = new Size(125, 20);
            label36.TabIndex = 0;
            label36.Text = "General Checkup";
            // 
            // newappointbtn
            // 
            newappointbtn.BackColor = Color.CornflowerBlue;
            newappointbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newappointbtn.ForeColor = SystemColors.ButtonHighlight;
            newappointbtn.Location = new Point(570, 22);
            newappointbtn.Name = "newappointbtn";
            newappointbtn.Size = new Size(160, 38);
            newappointbtn.TabIndex = 2;
            newappointbtn.Text = "+New appoinment";
            newappointbtn.UseVisualStyleBackColor = false;
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
            totalappopanel.ResumeLayout(false);
            totalappopanel.PerformLayout();
            upcomingpanel.ResumeLayout(false);
            upcomingpanel.PerformLayout();
            completedpnl.ResumeLayout(false);
            completedpnl.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
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
        private Panel panel12;
        private Label label27;
        private Label timelbl2;
        private Button cancelbtn2;
        private Label label29;
        private Button reshedulebtn2;
        private Label datelbl2;
        private Label label31;
        private Panel panel13;
        private Label label32;
        private Label timelbl1;
        private Button cancelbtn1;
        private Label label34;
        private Button reshedulebtn1;
        private Label datelbl1;
        private Label label36;
        private Button newappointbtn;
        private Label managelbl;
        private Label appoinmentslbl;
    }
}