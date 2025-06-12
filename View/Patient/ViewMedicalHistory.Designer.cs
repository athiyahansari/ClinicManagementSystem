namespace ClinicManagementSystem.Views.Patients

{
    partial class ViewMedicalHistory
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
            label3 = new Label();
            navmedicalhistory = new Button();
            label2 = new Label();
            navprofile = new Button();
            logout = new Button();
            navprescription = new Button();
            navappointment = new Button();
            navdoc = new Button();
            sidenav = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            txtPatientName = new TextBox();
            btnLoad = new Button();
            textBox1 = new TextBox();
            dvgMedicalHistory = new DataGridView();
            Column6 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            sidenav.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgMedicalHistory).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(57, 52);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(109, 19);
            label3.TabIndex = 22;
            label3.Text = "Patient ID-2346";
            // 
            // navmedicalhistory
            // 
            navmedicalhistory.BackColor = Color.LightSteelBlue;
            navmedicalhistory.Location = new Point(34, 170);
            navmedicalhistory.Margin = new Padding(2);
            navmedicalhistory.Name = "navmedicalhistory";
            navmedicalhistory.Size = new Size(125, 29);
            navmedicalhistory.TabIndex = 5;
            navmedicalhistory.Text = "Medical History";
            navmedicalhistory.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kristen ITC", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(34, 29);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(113, 27);
            label2.TabIndex = 21;
            label2.Text = "John Doe";
            // 
            // navprofile
            // 
            navprofile.BackColor = Color.LightSteelBlue;
            navprofile.Location = new Point(34, 331);
            navprofile.Margin = new Padding(2);
            navprofile.Name = "navprofile";
            navprofile.Size = new Size(125, 29);
            navprofile.TabIndex = 4;
            navprofile.Text = "MyProfile";
            navprofile.UseVisualStyleBackColor = false;
            // 
            // logout
            // 
            logout.BackColor = Color.LightSteelBlue;
            logout.Location = new Point(34, 364);
            logout.Margin = new Padding(2);
            logout.Name = "logout";
            logout.Size = new Size(125, 28);
            logout.TabIndex = 3;
            logout.Text = "LogOut";
            logout.UseVisualStyleBackColor = false;
            // 
            // navprescription
            // 
            navprescription.BackColor = Color.LightSteelBlue;
            navprescription.Location = new Point(34, 139);
            navprescription.Margin = new Padding(2);
            navprescription.Name = "navprescription";
            navprescription.Size = new Size(125, 28);
            navprescription.TabIndex = 2;
            navprescription.Text = "Prescriptions";
            navprescription.UseVisualStyleBackColor = false;
            // 
            // navappointment
            // 
            navappointment.BackColor = Color.LightSteelBlue;
            navappointment.Location = new Point(34, 107);
            navappointment.Margin = new Padding(2);
            navappointment.Name = "navappointment";
            navappointment.Size = new Size(125, 28);
            navappointment.TabIndex = 1;
            navappointment.Text = "Appointment";
            navappointment.UseVisualStyleBackColor = false;
            // 
            // navdoc
            // 
            navdoc.BackColor = Color.LightSteelBlue;
            navdoc.Location = new Point(34, 78);
            navdoc.Margin = new Padding(2);
            navdoc.Name = "navdoc";
            navdoc.Size = new Size(125, 26);
            navdoc.TabIndex = 0;
            navdoc.Text = "Doctor";
            navdoc.UseVisualStyleBackColor = false;
            navdoc.Click += navdoc_Click;
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
            sidenav.Margin = new Padding(2);
            sidenav.Name = "sidenav";
            sidenav.Size = new Size(192, 460);
            sidenav.TabIndex = 21;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtPatientName);
            panel1.Controls.Add(btnLoad);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(dvgMedicalHistory);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(192, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(709, 460);
            panel1.TabIndex = 22;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkGray;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(59, 151);
            label1.Name = "label1";
            label1.Padding = new Padding(4);
            label1.Size = new Size(138, 29);
            label1.TabIndex = 5;
            label1.Text = "Enter Patient Name";
            // 
            // txtPatientName
            // 
            txtPatientName.Location = new Point(60, 188);
            txtPatientName.Name = "txtPatientName";
            txtPatientName.Size = new Size(100, 23);
            txtPatientName.TabIndex = 4;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.LightBlue;
            btnLoad.BackgroundImageLayout = ImageLayout.None;
            btnLoad.Location = new Point(60, 229);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(125, 30);
            btnLoad.TabIndex = 3;
            btnLoad.Text = "Load History";
            btnLoad.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(60, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(500, 39);
            textBox1.TabIndex = 0;
            textBox1.Text = "View Medical History";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // dvgMedicalHistory
            // 
            dvgMedicalHistory.BackgroundColor = SystemColors.Control;
            dvgMedicalHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgMedicalHistory.Columns.AddRange(new DataGridViewColumn[] { Column6, Column1, Column2, Column4, Column3, Column5 });
            dvgMedicalHistory.Location = new Point(60, 283);
            dvgMedicalHistory.Name = "dvgMedicalHistory";
            dvgMedicalHistory.Size = new Size(636, 150);
            dvgMedicalHistory.TabIndex = 2;
            dvgMedicalHistory.CellContentClick += dvgMedicalHistory_CellContentClick;
            // 
            // Column6
            // 
            Column6.HeaderText = "Patient Name";
            Column6.Name = "Column6";
            // 
            // Column1
            // 
            Column1.HeaderText = "Visit Date";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Diagnosis";
            Column2.Name = "Column2";
            // 
            // Column4
            // 
            Column4.HeaderText = "Doctor Name";
            Column4.Name = "Column4";
            // 
            // Column3
            // 
            Column3.HeaderText = "Prescription";
            Column3.Name = "Column3";
            // 
            // Column5
            // 
            Column5.HeaderText = "Notes";
            Column5.Name = "Column5";
            // 
            // ViewMedicalHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 460);
            Controls.Add(panel1);
            Controls.Add(sidenav);
            Name = "ViewMedicalHistory";
            Text = "ViewMedicalHistory";
            Load += ViewMedicalHistory_Load;
            sidenav.ResumeLayout(false);
            sidenav.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgMedicalHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label3;
        private Button navmedicalhistory;
        private Label label2;
        private Button navprofile;
        private Button logout;
        private Button navprescription;
        private Button navappointment;
        private Button navdoc;
        private Panel sidenav;
        private Panel panel1;
        private Button btnLoad;
        private TextBox textBox1;
        private DataGridView dvgMedicalHistory;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private TextBox txtPatientName;
        private Label label1;
    }
}