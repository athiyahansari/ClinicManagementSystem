namespace CMS.View.Admin
{
    partial class ManageDoctors
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
            label2 = new Label();
            navprofile = new Button();
            logout = new Button();
            navappointment = new Button();
            navpatient = new Button();
            navdoc = new Button();
            label1 = new Label();
            docID = new Label();
            fullName = new Label();
            speciality = new Label();
            email = new Label();
            phoneNo = new Label();
            docIDtxt = new TextBox();
            fullNametxt = new TextBox();
            specialitytxt = new TextBox();
            emailtxt = new TextBox();
            phoneNotxt = new TextBox();
            addbtn = new Button();
            updatebtn = new Button();
            deletebtn = new Button();
            clearbtn = new Button();
            dataGridView1 = new DataGridView();
            doctorID = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            docspecilaity = new DataGridViewTextBoxColumn();
            emailNo = new DataGridViewTextBoxColumn();
            phone = new DataGridViewTextBoxColumn();
            sidenav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            sidenav.Name = "sidenav";
            sidenav.Size = new Size(247, 639);
            sidenav.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(64, 72);
            label3.Name = "label3";
            label3.Size = new Size(126, 23);
            label3.TabIndex = 6;
            label3.Text = "Admin ID-2346";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kristen ITC", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(34, 36);
            label2.Name = "label2";
            label2.Size = new Size(139, 33);
            label2.TabIndex = 5;
            label2.Text = "John Doe";
            // 
            // navprofile
            // 
            navprofile.BackColor = Color.LightSteelBlue;
            navprofile.Location = new Point(26, 510);
            navprofile.Name = "navprofile";
            navprofile.Size = new Size(193, 39);
            navprofile.TabIndex = 4;
            navprofile.Text = "MyProfile";
            navprofile.UseVisualStyleBackColor = false;
            // 
            // logout
            // 
            logout.BackColor = Color.LightSteelBlue;
            logout.Location = new Point(26, 554);
            logout.Name = "logout";
            logout.Size = new Size(193, 40);
            logout.TabIndex = 3;
            logout.Text = "LogOut";
            logout.UseVisualStyleBackColor = false;
            // 
            // navappointment
            // 
            navappointment.BackColor = Color.LightSteelBlue;
            navappointment.Location = new Point(26, 224);
            navappointment.Name = "navappointment";
            navappointment.Size = new Size(193, 43);
            navappointment.TabIndex = 2;
            navappointment.Text = "Appointment Schedules";
            navappointment.UseVisualStyleBackColor = false;
            // 
            // navpatient
            // 
            navpatient.BackColor = Color.LightSteelBlue;
            navpatient.Location = new Point(26, 177);
            navpatient.Name = "navpatient";
            navpatient.Size = new Size(193, 42);
            navpatient.TabIndex = 1;
            navpatient.Text = "Patients";
            navpatient.UseVisualStyleBackColor = false;
            // 
            // navdoc
            // 
            navdoc.BackColor = Color.LightSteelBlue;
            navdoc.Location = new Point(26, 130);
            navdoc.Name = "navdoc";
            navdoc.Size = new Size(193, 41);
            navdoc.TabIndex = 0;
            navdoc.Text = "Doctors";
            navdoc.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(588, 26);
            label1.Name = "label1";
            label1.Size = new Size(252, 41);
            label1.TabIndex = 4;
            label1.Text = "Manage Doctors";
            // 
            // docID
            // 
            docID.AutoSize = true;
            docID.Location = new Point(311, 102);
            docID.Name = "docID";
            docID.Size = new Size(93, 23);
            docID.TabIndex = 5;
            docID.Text = "Doctor ID :";
            // 
            // fullName
            // 
            fullName.AutoSize = true;
            fullName.Location = new Point(311, 148);
            fullName.Name = "fullName";
            fullName.Size = new Size(96, 23);
            fullName.TabIndex = 6;
            fullName.Text = "Full Name :";
            // 
            // speciality
            // 
            speciality.AutoSize = true;
            speciality.Location = new Point(311, 199);
            speciality.Name = "speciality";
            speciality.Size = new Size(90, 23);
            speciality.TabIndex = 7;
            speciality.Text = "Speciality :";
            // 
            // email
            // 
            email.AutoSize = true;
            email.Location = new Point(311, 254);
            email.Name = "email";
            email.Size = new Size(60, 23);
            email.TabIndex = 8;
            email.Text = "Email :";
            // 
            // phoneNo
            // 
            phoneNo.AutoSize = true;
            phoneNo.Location = new Point(311, 305);
            phoneNo.Name = "phoneNo";
            phoneNo.Size = new Size(96, 23);
            phoneNo.TabIndex = 9;
            phoneNo.Text = "Phone No :";
            // 
            // docIDtxt
            // 
            docIDtxt.Location = new Point(439, 102);
            docIDtxt.Name = "docIDtxt";
            docIDtxt.Size = new Size(125, 30);
            docIDtxt.TabIndex = 10;
            // 
            // fullNametxt
            // 
            fullNametxt.Location = new Point(439, 148);
            fullNametxt.Name = "fullNametxt";
            fullNametxt.Size = new Size(125, 30);
            fullNametxt.TabIndex = 11;
            // 
            // specialitytxt
            // 
            specialitytxt.Location = new Point(439, 196);
            specialitytxt.Name = "specialitytxt";
            specialitytxt.Size = new Size(125, 30);
            specialitytxt.TabIndex = 12;
            // 
            // emailtxt
            // 
            emailtxt.Location = new Point(439, 251);
            emailtxt.Name = "emailtxt";
            emailtxt.Size = new Size(125, 30);
            emailtxt.TabIndex = 13;
            emailtxt.TextChanged += emailtxt_TextChanged;
            // 
            // phoneNotxt
            // 
            phoneNotxt.Location = new Point(439, 298);
            phoneNotxt.Name = "phoneNotxt";
            phoneNotxt.Size = new Size(125, 30);
            phoneNotxt.TabIndex = 14;
            phoneNotxt.TextChanged += phoneNotxt_TextChanged;
            // 
            // addbtn
            // 
            addbtn.BackColor = Color.DarkTurquoise;
            addbtn.Location = new Point(981, 96);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(94, 29);
            addbtn.TabIndex = 15;
            addbtn.Text = "Add";
            addbtn.UseVisualStyleBackColor = false;
            // 
            // updatebtn
            // 
            updatebtn.BackColor = Color.DarkTurquoise;
            updatebtn.Location = new Point(981, 160);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(94, 29);
            updatebtn.TabIndex = 16;
            updatebtn.Text = "Update";
            updatebtn.UseVisualStyleBackColor = false;
            // 
            // deletebtn
            // 
            deletebtn.BackColor = Color.DarkTurquoise;
            deletebtn.Location = new Point(981, 224);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(94, 29);
            deletebtn.TabIndex = 17;
            deletebtn.Text = "Delete";
            deletebtn.UseVisualStyleBackColor = false;
            // 
            // clearbtn
            // 
            clearbtn.BackColor = Color.DarkTurquoise;
            clearbtn.Location = new Point(981, 282);
            clearbtn.Name = "clearbtn";
            clearbtn.Size = new Size(94, 29);
            clearbtn.TabIndex = 18;
            clearbtn.Text = "Clear";
            clearbtn.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { doctorID, name, docspecilaity, emailNo, phone });
            dataGridView1.Location = new Point(290, 369);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(843, 243);
            dataGridView1.TabIndex = 19;
            // 
            // doctorID
            // 
            doctorID.HeaderText = "Doctor ID";
            doctorID.MinimumWidth = 6;
            doctorID.Name = "doctorID";
            // 
            // name
            // 
            name.HeaderText = "Full Name";
            name.MinimumWidth = 6;
            name.Name = "name";
            // 
            // docspecilaity
            // 
            docspecilaity.HeaderText = "Speciality";
            docspecilaity.MinimumWidth = 6;
            docspecilaity.Name = "docspecilaity";
            // 
            // emailNo
            // 
            emailNo.HeaderText = "Email";
            emailNo.MinimumWidth = 6;
            emailNo.Name = "emailNo";
            // 
            // phone
            // 
            phone.HeaderText = "Phone No";
            phone.MinimumWidth = 6;
            phone.Name = "phone";
            // 
            // ManageDoctors
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1174, 639);
            Controls.Add(dataGridView1);
            Controls.Add(clearbtn);
            Controls.Add(deletebtn);
            Controls.Add(updatebtn);
            Controls.Add(addbtn);
            Controls.Add(phoneNotxt);
            Controls.Add(emailtxt);
            Controls.Add(specialitytxt);
            Controls.Add(fullNametxt);
            Controls.Add(docIDtxt);
            Controls.Add(phoneNo);
            Controls.Add(email);
            Controls.Add(speciality);
            Controls.Add(fullName);
            Controls.Add(docID);
            Controls.Add(label1);
            Controls.Add(sidenav);
            Name = "ManageDoctors";
            Text = "ManageDoctors";
            sidenav.ResumeLayout(false);
            sidenav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel sidenav;
        private Label label3;
        private Label label2;
        private Button navprofile;
        private Button logout;
        private Button navappointment;
        private Button navpatient;
        private Button navdoc;
        private Label label1;
        private Label docID;
        private Label fullName;
        private Label speciality;
        private Label email;
        private Label phoneNo;
        private TextBox docIDtxt;
        private TextBox fullNametxt;
        private TextBox specialitytxt;
        private TextBox emailtxt;
        private TextBox phoneNotxt;
        private Button addbtn;
        private Button updatebtn;
        private Button deletebtn;
        private Button clearbtn;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn doctorID;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn docspecilaity;
        private DataGridViewTextBoxColumn emailNo;
        private DataGridViewTextBoxColumn phone;
    }
}