//namespace CMS.View.Doctor
//{
//    partial class DocViewProfile
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            SuspendLayout();
//            // 
//            // DocViewProfile
//            // 
//            AutoScaleDimensions = new SizeF(7F, 15F);
//            AutoScaleMode = AutoScaleMode.Font;
//            ClientSize = new Size(800, 450);
//            Name = "DocViewProfile";
//            Text = "DocViewProfilecs";
//            Load += DocViewProfile_Load_1;
//            ResumeLayout(false);
//        }

//        #endregion
//    }
//}


namespace CMS.View.Doctor
{
    partial class DocViewProfile
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel sidenav;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button navmedicalhistory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button navprofile;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button navprescription;
        private System.Windows.Forms.Button navappointment;
        private System.Windows.Forms.Button navdoc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4; // Contact
        private System.Windows.Forms.TextBox textBox5; // Description
        private System.Windows.Forms.TextBox textBox2; // Email
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1; // Speciality
        private System.Windows.Forms.Label label4; // Doctor Name label

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        //declare the field
        private System.Windows.Forms.TextBox DocName;


        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            sidenav = new Panel();
            label3 = new Label();
            navmedicalhistory = new Button();
            label2 = new Label();
            navprofile = new Button();
            logout = new Button();
            navprescription = new Button();
            navappointment = new Button();
            navdoc = new Button();
            label1 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            Speciality = new Label();
            label7 = new Label();
            label8 = new Label();
            txtDescription = new TextBox();
            txtSpeciality = new TextBox();
            txtEmail = new TextBox();
            txtContact = new TextBox();
            panel3 = new Panel();
            button1 = new Button();
            label10 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            DocName = new TextBox();
            label6 = new Label();
            label11 = new Label();
            panel1.SuspendLayout();
            sidenav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(sidenav);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(867, 686);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 100);
            panel2.TabIndex = 0;
            // 
            // sidenav
            // 
            sidenav.BackColor = Color.CornflowerBlue;
            sidenav.Controls.Add(label3);
            sidenav.Controls.Add(navmedicalhistory);
            sidenav.Controls.Add(label2);
            sidenav.Controls.Add(navprofile);
            sidenav.Controls.Add(logout);
            sidenav.Controls.Add(navprescription);
            sidenav.Controls.Add(navappointment);
            sidenav.Controls.Add(navdoc);
            sidenav.Dock = DockStyle.Left;
            sidenav.Location = new Point(0, 0);
            sidenav.Name = "sidenav";
            sidenav.Size = new Size(192, 686);
            sidenav.TabIndex = 1;
            // 
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 0;
            // 
            // navmedicalhistory
            // 
            navmedicalhistory.Location = new Point(0, 0);
            navmedicalhistory.Name = "navmedicalhistory";
            navmedicalhistory.Size = new Size(75, 23);
            navmedicalhistory.TabIndex = 1;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 2;
            // 
            // navprofile
            // 
            navprofile.Location = new Point(0, 0);
            navprofile.Name = "navprofile";
            navprofile.Size = new Size(75, 23);
            navprofile.TabIndex = 3;
            // 
            // logout
            // 
            logout.Location = new Point(0, 0);
            logout.Name = "logout";
            logout.Size = new Size(75, 23);
            logout.TabIndex = 4;
            // 
            // navprescription
            // 
            navprescription.Location = new Point(0, 0);
            navprescription.Name = "navprescription";
            navprescription.Size = new Size(75, 23);
            navprescription.TabIndex = 5;
            // 
            // navappointment
            // 
            navappointment.Location = new Point(0, 0);
            navappointment.Name = "navappointment";
            navappointment.Size = new Size(75, 23);
            navappointment.TabIndex = 6;
            // 
            // navdoc
            // 
            navdoc.Location = new Point(0, 0);
            navdoc.Name = "navdoc";
            navdoc.Size = new Size(75, 23);
            navdoc.TabIndex = 7;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(0, 0);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 27);
            textBox4.TabIndex = 0;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(0, 0);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 27);
            textBox5.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(0, 0);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 27);
            textBox2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 27);
            textBox1.TabIndex = 0;
            // 
            // label4
            // 
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaption;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(325, 139);
            label5.Name = "label5";
            label5.Size = new Size(110, 27);
            label5.TabIndex = 0;
            label5.Text = "Description";
            // 
            // Speciality
            // 
            Speciality.AutoSize = true;
            Speciality.BackColor = SystemColors.ActiveCaption;
            Speciality.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Speciality.Location = new Point(325, 193);
            Speciality.Name = "Speciality";
            Speciality.Size = new Size(92, 25);
            Speciality.TabIndex = 1;
            Speciality.Text = "Speciality";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ActiveCaption;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(325, 245);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.Yes;
            label7.Size = new Size(58, 25);
            label7.TabIndex = 2;
            label7.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ActiveCaption;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(325, 300);
            label8.Name = "label8";
            label8.Size = new Size(77, 25);
            label8.TabIndex = 3;
            label8.Text = "Contact";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(428, 138);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(300, 27);
            txtDescription.TabIndex = 4;
            // 
            // txtSpeciality
            // 
            txtSpeciality.Location = new Point(428, 190);
            txtSpeciality.Name = "txtSpeciality";
            txtSpeciality.Size = new Size(204, 27);
            txtSpeciality.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(428, 242);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(204, 27);
            txtEmail.TabIndex = 6;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(428, 300);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(204, 27);
            txtContact.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = Color.CornflowerBlue;
            panel3.Controls.Add(button1);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button6);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(192, 404);
            panel3.TabIndex = 22;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSteelBlue;
            button1.Location = new Point(34, 170);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(125, 29);
            button1.TabIndex = 5;
            button1.Text = "Medical History";
            button1.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Kristen ITC", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonFace;
            label10.Location = new Point(60, 29);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(79, 33);
            label10.TabIndex = 21;
            label10.Text = "CMS";
            // 
            // button2
            // 
            button2.BackColor = Color.LightSteelBlue;
            button2.Location = new Point(34, 331);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(125, 29);
            button2.TabIndex = 4;
            button2.Text = "MyProfile";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSteelBlue;
            button3.Location = new Point(34, 364);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(125, 28);
            button3.TabIndex = 3;
            button3.Text = "LogOut";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.LightSteelBlue;
            button4.Location = new Point(34, 139);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(125, 28);
            button4.TabIndex = 2;
            button4.Text = "Prescriptions";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.LightSteelBlue;
            button5.Location = new Point(34, 107);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(125, 28);
            button5.TabIndex = 1;
            button5.Text = "Appointment";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.LightSteelBlue;
            button6.Location = new Point(34, 78);
            button6.Margin = new Padding(2);
            button6.Name = "button6";
            button6.Size = new Size(125, 26);
            button6.TabIndex = 0;
            button6.Text = "View Doctor";
            button6.UseVisualStyleBackColor = false;
            // 
            // DocName
            // 
            DocName.Location = new Point(432, 88);
            DocName.Name = "DocName";
            DocName.Size = new Size(188, 27);
            DocName.TabIndex = 23;
            DocName.TextChanged += DocName_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaption;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(326, 89);
            label6.Name = "label6";
            label6.Size = new Size(124, 25);
            label6.TabIndex = 24;
            label6.Text = "Doctor Name";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.GradientActiveCaption;
            label11.BorderStyle = BorderStyle.Fixed3D;
            label11.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(401, 24);
            label11.Name = "label11";
            label11.Size = new Size(248, 39);
            label11.TabIndex = 25;
            label11.Text = "View Doctor Profile";
            // 
            // DocViewProfile
            // 
            ClientSize = new Size(792, 404);
            Controls.Add(label11);
            Controls.Add(label6);
            Controls.Add(DocName);
            Controls.Add(panel3);
            Controls.Add(txtContact);
            Controls.Add(txtEmail);
            Controls.Add(txtSpeciality);
            Controls.Add(txtDescription);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(Speciality);
            Controls.Add(label5);
            Name = "DocViewProfile";
            Load += DocViewProfile_Load_1;
            panel1.ResumeLayout(false);
            sidenav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Label label5;
        private Label Speciality;
        private Label label7;
        private Label label8;
        private TextBox txtDescription;
        private TextBox txtSpeciality;
        private TextBox txtEmail;
        private TextBox txtContact;
        private Panel panel3;
        private Button button1;
        private Label label10;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label6;
        private Label label11;

        ////Doctor name text box
        //this.private TextBox DocName;

        //txtDoctorName = new System.Windows.Forms.TextBox();
        //this.Controls.Add(this.txtDoctorName);

        //// 
        //// txtDoctorName
        //// 
        //this.txtDoctorName.Location = new System.Drawing.Point(50, 30); // adjust position as needed
        //this.txtDoctorName.Name = "txtDoctorName";
        //this.txtDoctorName.Size = new System.Drawing.Size(200, 22);
        //this.txtDoctorName.ReadOnly = true;

    }
}
