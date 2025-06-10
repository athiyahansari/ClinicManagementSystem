namespace CMS.View.Doctor
{
    partial class CreatePrescription
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
            label1 = new Label();
            PatientID = new Label();
            Diagnosis = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            medicine = new Label();
            textBox3 = new TextBox();
            addbtn = new Button();
            updatebtn = new Button();
            deletebtn = new Button();
            clearbtn = new Button();
            dateTimePicker1 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            PrescriptionID = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            ptID = new DataGridViewTextBoxColumn();
            disease = new DataGridViewTextBoxColumn();
            medi = new DataGridViewTextBoxColumn();
            sidenav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            sidenav.Size = new Size(247, 694);
            sidenav.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(71, 75);
            label3.Name = "label3";
            label3.Size = new Size(128, 23);
            label3.TabIndex = 24;
            label3.Text = "Doctor ID-2346";
            // 
            // navprofile
            // 
            navprofile.BackColor = Color.LightSteelBlue;
            navprofile.Font = new Font("Segoe UI", 9F);
            navprofile.Location = new Point(41, 446);
            navprofile.Name = "navprofile";
            navprofile.Size = new Size(159, 45);
            navprofile.TabIndex = 4;
            navprofile.Text = "MyProfile";
            navprofile.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kristen ITC", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(41, 40);
            label2.Name = "label2";
            label2.Size = new Size(139, 33);
            label2.TabIndex = 23;
            label2.Text = "John Doe";
            // 
            // logout
            // 
            logout.BackColor = Color.LightSteelBlue;
            logout.Font = new Font("Segoe UI", 9F);
            logout.Location = new Point(41, 497);
            logout.Name = "logout";
            logout.Size = new Size(159, 42);
            logout.TabIndex = 3;
            logout.Text = "LogOut";
            logout.UseVisualStyleBackColor = false;
            // 
            // navappointment
            // 
            navappointment.BackColor = Color.LightSteelBlue;
            navappointment.Font = new Font("Segoe UI", 9F);
            navappointment.Location = new Point(41, 172);
            navappointment.Name = "navappointment";
            navappointment.Size = new Size(159, 47);
            navappointment.TabIndex = 1;
            navappointment.Text = "My Appointment";
            navappointment.UseVisualStyleBackColor = false;
            // 
            // navpatient
            // 
            navpatient.BackColor = Color.LightSteelBlue;
            navpatient.Font = new Font("Segoe UI", 9F);
            navpatient.Location = new Point(41, 120);
            navpatient.Name = "navpatient";
            navpatient.Size = new Size(159, 47);
            navpatient.TabIndex = 0;
            navpatient.Text = "My Patients";
            navpatient.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(554, 32);
            label1.Name = "label1";
            label1.Size = new Size(324, 41);
            label1.TabIndex = 3;
            label1.Text = "Manage Prescriptions";
            label1.Click += label1_Click;
            // 
            // PatientID
            // 
            PatientID.AutoSize = true;
            PatientID.Location = new Point(317, 120);
            PatientID.Name = "PatientID";
            PatientID.Size = new Size(94, 23);
            PatientID.TabIndex = 4;
            PatientID.Text = "Patient ID :";
            // 
            // Diagnosis
            // 
            Diagnosis.AutoSize = true;
            Diagnosis.Location = new Point(316, 192);
            Diagnosis.Name = "Diagnosis";
            Diagnosis.Size = new Size(92, 23);
            Diagnosis.TabIndex = 5;
            Diagnosis.Text = "Diagnosis :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(429, 120);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 30);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(429, 192);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 30);
            textBox2.TabIndex = 7;
            // 
            // medicine
            // 
            medicine.AutoSize = true;
            medicine.Location = new Point(317, 268);
            medicine.Name = "medicine";
            medicine.Size = new Size(95, 23);
            medicine.TabIndex = 8;
            medicine.Text = "Medicines :";
            medicine.Click += medicine_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(429, 265);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 30);
            textBox3.TabIndex = 9;
            // 
            // addbtn
            // 
            addbtn.BackColor = Color.PaleGreen;
            addbtn.Location = new Point(1019, 103);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(94, 29);
            addbtn.TabIndex = 10;
            addbtn.Text = "Add";
            addbtn.UseVisualStyleBackColor = false;
            // 
            // updatebtn
            // 
            updatebtn.BackColor = Color.Aquamarine;
            updatebtn.Location = new Point(1019, 180);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(94, 29);
            updatebtn.TabIndex = 11;
            updatebtn.Text = "Update";
            updatebtn.UseVisualStyleBackColor = false;
            // 
            // deletebtn
            // 
            deletebtn.BackColor = Color.Pink;
            deletebtn.Location = new Point(1019, 254);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(94, 29);
            deletebtn.TabIndex = 12;
            deletebtn.Text = "Delete";
            deletebtn.UseVisualStyleBackColor = false;
            // 
            // clearbtn
            // 
            clearbtn.BackColor = Color.LightCoral;
            clearbtn.Location = new Point(1019, 322);
            clearbtn.Name = "clearbtn";
            clearbtn.Size = new Size(94, 29);
            clearbtn.TabIndex = 13;
            clearbtn.Text = "Clear";
            clearbtn.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(317, 336);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(306, 30);
            dateTimePicker1.TabIndex = 14;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { PrescriptionID, date, ptID, disease, medi });
            dataGridView1.Location = new Point(283, 405);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(864, 268);
            dataGridView1.TabIndex = 15;
            // 
            // PrescriptionID
            // 
            PrescriptionID.HeaderText = "Prescription ID";
            PrescriptionID.MinimumWidth = 6;
            PrescriptionID.Name = "PrescriptionID";
            PrescriptionID.Visible = false;
            // 
            // date
            // 
            date.HeaderText = "Date";
            date.MinimumWidth = 6;
            date.Name = "date";
            // 
            // ptID
            // 
            ptID.HeaderText = "Patient ID";
            ptID.MinimumWidth = 6;
            ptID.Name = "ptID";
            // 
            // disease
            // 
            disease.HeaderText = "Diagnosis";
            disease.MinimumWidth = 6;
            disease.Name = "disease";
            // 
            // medi
            // 
            medi.HeaderText = "Medicines";
            medi.MinimumWidth = 6;
            medi.Name = "medi";
            // 
            // CreatePrescription
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1181, 694);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker1);
            Controls.Add(clearbtn);
            Controls.Add(deletebtn);
            Controls.Add(updatebtn);
            Controls.Add(addbtn);
            Controls.Add(textBox3);
            Controls.Add(medicine);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Diagnosis);
            Controls.Add(PatientID);
            Controls.Add(label1);
            Controls.Add(sidenav);
            Name = "CreatePrescription";
            Text = "CreatePrescription";
            sidenav.ResumeLayout(false);
            sidenav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel sidenav;
        private Label label3;
        private Button navprofile;
        private Label label2;
        private Button logout;
        private Button navappointment;
        private Button navpatient;
        private Label label1;
        private Label PatientID;
        private Label Diagnosis;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label medicine;
        private TextBox textBox3;
        private Button addbtn;
        private Button updatebtn;
        private Button deletebtn;
        private Button clearbtn;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn PrescriptionID;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn ptID;
        private DataGridViewTextBoxColumn disease;
        private DataGridViewTextBoxColumn medi;
    }
}