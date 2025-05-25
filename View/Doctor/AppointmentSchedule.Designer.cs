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
            label3 = new Label();
            navprofile = new Button();
            label2 = new Label();
            logout = new Button();
            navappointment = new Button();
            navpatient = new Button();
            sidenav.SuspendLayout();
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
            sidenav.Size = new Size(274, 736);
            sidenav.TabIndex = 2;
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
            // AppointmentSchedule
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 736);
            Controls.Add(sidenav);
            Name = "AppointmentSchedule";
            Text = "AppointmentSchedule";
            sidenav.ResumeLayout(false);
            sidenav.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel sidenav;
        private Label label3;
        private Button navprofile;
        private Label label2;
        private Button logout;
        private Button navappointment;
        private Button navpatient;
    }
}