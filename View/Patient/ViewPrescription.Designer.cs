namespace CMS.View.Patient
{
    partial class ViewPrescription
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
            lblTitle = new Label();
            dataGridView1 = new DataGridView();
            PrescriptionID = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            DoctorName = new DataGridViewTextBoxColumn();
            Diagnosis = new DataGridViewTextBoxColumn();
            Medicines = new DataGridViewTextBoxColumn();
            btnBack = new Button();
            lblNote = new Label();
            sidenav = new Panel();
            label3 = new Label();
            navmedicalhistory = new Button();
            label2 = new Label();
            navprofile = new Button();
            logout = new Button();
            navprescription = new Button();
            navappointment = new Button();
            navdoc = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            sidenav.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = SystemColors.GradientActiveCaption;
            lblTitle.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(601, 39);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(276, 41);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Your Prescriptions";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { PrescriptionID, Date, DoctorName, Diagnosis, Medicines });
            dataGridView1.Location = new Point(273, 104);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(918, 496);
            dataGridView1.TabIndex = 3;
            // 
            // PrescriptionID
            // 
            PrescriptionID.HeaderText = "Prescription ID";
            PrescriptionID.MinimumWidth = 6;
            PrescriptionID.Name = "PrescriptionID";
            PrescriptionID.Visible = false;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            // 
            // DoctorName
            // 
            DoctorName.HeaderText = "Doctor Name";
            DoctorName.MinimumWidth = 6;
            DoctorName.Name = "DoctorName";
            // 
            // Diagnosis
            // 
            Diagnosis.HeaderText = "Diagnosis";
            Diagnosis.MinimumWidth = 6;
            Diagnosis.Name = "Diagnosis";
            // 
            // Medicines
            // 
            Medicines.HeaderText = "Medicines";
            Medicines.MinimumWidth = 6;
            Medicines.Name = "Medicines";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.LightSkyBlue;
            btnBack.Location = new Point(273, 616);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Location = new Point(902, 622);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(289, 23);
            lblNote.TabIndex = 5;
            lblNote.Text = "* Select a prescription to view details";
            lblNote.Click += lblNote_Click;
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
            sidenav.Size = new Size(247, 684);
            sidenav.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(74, 80);
            label3.Name = "label3";
            label3.Size = new Size(130, 23);
            label3.TabIndex = 22;
            label3.Text = "Patient ID-2346";
            // 
            // navmedicalhistory
            // 
            navmedicalhistory.BackColor = Color.LightSteelBlue;
            navmedicalhistory.Location = new Point(44, 261);
            navmedicalhistory.Name = "navmedicalhistory";
            navmedicalhistory.Size = new Size(160, 44);
            navmedicalhistory.TabIndex = 5;
            navmedicalhistory.Text = "Medical History";
            navmedicalhistory.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kristen ITC", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(44, 44);
            label2.Name = "label2";
            label2.Size = new Size(139, 33);
            label2.TabIndex = 21;
            label2.Text = "John Doe";
            // 
            // navprofile
            // 
            navprofile.BackColor = Color.LightSteelBlue;
            navprofile.Location = new Point(44, 507);
            navprofile.Name = "navprofile";
            navprofile.Size = new Size(160, 45);
            navprofile.TabIndex = 4;
            navprofile.Text = "MyProfile";
            navprofile.UseVisualStyleBackColor = false;
            // 
            // logout
            // 
            logout.BackColor = Color.LightSteelBlue;
            logout.Location = new Point(44, 558);
            logout.Name = "logout";
            logout.Size = new Size(160, 42);
            logout.TabIndex = 3;
            logout.Text = "LogOut";
            logout.UseVisualStyleBackColor = false;
            // 
            // navprescription
            // 
            navprescription.BackColor = Color.LightSteelBlue;
            navprescription.Location = new Point(44, 213);
            navprescription.Name = "navprescription";
            navprescription.Size = new Size(160, 43);
            navprescription.TabIndex = 2;
            navprescription.Text = "Prescriptions";
            navprescription.UseVisualStyleBackColor = false;
            // 
            // navappointment
            // 
            navappointment.BackColor = Color.LightSteelBlue;
            navappointment.Location = new Point(44, 165);
            navappointment.Name = "navappointment";
            navappointment.Size = new Size(160, 42);
            navappointment.TabIndex = 1;
            navappointment.Text = "Appointment";
            navappointment.UseVisualStyleBackColor = false;
            // 
            // navdoc
            // 
            navdoc.BackColor = Color.LightSteelBlue;
            navdoc.Location = new Point(44, 120);
            navdoc.Name = "navdoc";
            navdoc.Size = new Size(160, 40);
            navdoc.TabIndex = 0;
            navdoc.Text = "Doctor";
            navdoc.UseVisualStyleBackColor = false;
            // 
            // ViewPrescription
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 684);
            Controls.Add(sidenav);
            Controls.Add(lblNote);
            Controls.Add(btnBack);
            Controls.Add(dataGridView1);
            Controls.Add(lblTitle);
            Name = "ViewPrescription";
            Text = "ViewPrescription";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            sidenav.ResumeLayout(false);
            sidenav.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitle;
        private DataGridView dataGridView1;
        private Button btnBack;
        private Label lblNote;
        private DataGridViewTextBoxColumn PrescriptionID;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn DoctorName;
        private DataGridViewTextBoxColumn Diagnosis;
        private DataGridViewTextBoxColumn Medicines;
        private Panel sidenav;
        private Label label3;
        private Button navmedicalhistory;
        private Label label2;
        private Button navprofile;
        private Button logout;
        private Button navprescription;
        private Button navappointment;
        private Button navdoc;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}