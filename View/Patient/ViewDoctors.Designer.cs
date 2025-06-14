namespace CMS.View.Patient
{
    partial class ViewDoctors
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvDoctors;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dgvDoctors = new DataGridView();
            sidenav = new Panel();
            navmedicalhistory = new Button();
            label2 = new Label();
            navprofile = new Button();
            logout = new Button();
            navprescription = new Button();
            navappointment = new Button();
            navdoc = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDoctors).BeginInit();
            sidenav.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDoctors
            // 
            dgvDoctors.AllowUserToAddRows = false;
            dgvDoctors.AllowUserToDeleteRows = false;
            dgvDoctors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDoctors.BackgroundColor = SystemColors.ActiveCaption;
            dgvDoctors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDoctors.Location = new Point(235, 143);
            dgvDoctors.Name = "dgvDoctors";
            dgvDoctors.ReadOnly = true;
            dgvDoctors.RowHeadersWidth = 51;
            dgvDoctors.Size = new Size(690, 212);
            dgvDoctors.TabIndex = 0;
            dgvDoctors.CellContentClick += dgvDoctors_CellContentClick;
            // 
            // sidenav
            // 
            sidenav.BackColor = Color.CornflowerBlue;
            sidenav.Controls.Add(navmedicalhistory);
            sidenav.Controls.Add(label2);
            sidenav.Controls.Add(navprofile);
            sidenav.Controls.Add(logout);
            sidenav.Controls.Add(navprescription);
            sidenav.Controls.Add(navappointment);
            sidenav.Controls.Add(navdoc);
            sidenav.Dock = DockStyle.Left;
            sidenav.Location = new Point(0, 0);
            sidenav.Margin = new Padding(2, 3, 2, 3);
            sidenav.Name = "sidenav";
            sidenav.Size = new Size(230, 515);
            sidenav.TabIndex = 22;
            // 
            // navmedicalhistory
            // 
            navmedicalhistory.BackColor = Color.LightSteelBlue;
            navmedicalhistory.Location = new Point(39, 227);
            navmedicalhistory.Margin = new Padding(2, 3, 2, 3);
            navmedicalhistory.Name = "navmedicalhistory";
            navmedicalhistory.Size = new Size(143, 39);
            navmedicalhistory.TabIndex = 5;
            navmedicalhistory.Text = "Medical History";
            navmedicalhistory.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kristen ITC", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(67, 39);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(79, 33);
            label2.TabIndex = 21;
            label2.Text = "CMS";
            label2.Click += label2_Click;
            // 
            // navprofile
            // 
            navprofile.BackColor = Color.LightSteelBlue;
            navprofile.Location = new Point(39, 388);
            navprofile.Margin = new Padding(2, 3, 2, 3);
            navprofile.Name = "navprofile";
            navprofile.Size = new Size(143, 39);
            navprofile.TabIndex = 4;
            navprofile.Text = "MyProfile";
            navprofile.UseVisualStyleBackColor = false;
            // 
            // logout
            // 
            logout.BackColor = Color.LightSteelBlue;
            logout.Location = new Point(39, 447);
            logout.Margin = new Padding(2, 3, 2, 3);
            logout.Name = "logout";
            logout.Size = new Size(143, 37);
            logout.TabIndex = 3;
            logout.Text = "LogOut";
            logout.UseVisualStyleBackColor = false;
            // 
            // navprescription
            // 
            navprescription.BackColor = Color.LightSteelBlue;
            navprescription.Location = new Point(39, 185);
            navprescription.Margin = new Padding(2, 3, 2, 3);
            navprescription.Name = "navprescription";
            navprescription.Size = new Size(143, 37);
            navprescription.TabIndex = 2;
            navprescription.Text = "Prescriptions";
            navprescription.UseVisualStyleBackColor = false;
            // 
            // navappointment
            // 
            navappointment.BackColor = Color.LightSteelBlue;
            navappointment.Location = new Point(39, 143);
            navappointment.Margin = new Padding(2, 3, 2, 3);
            navappointment.Name = "navappointment";
            navappointment.Size = new Size(143, 37);
            navappointment.TabIndex = 1;
            navappointment.Text = "Appointment";
            navappointment.UseVisualStyleBackColor = false;
            // 
            // navdoc
            // 
            navdoc.BackColor = Color.LightSteelBlue;
            navdoc.Location = new Point(39, 104);
            navdoc.Margin = new Padding(2, 3, 2, 3);
            navdoc.Name = "navdoc";
            navdoc.Size = new Size(143, 35);
            navdoc.TabIndex = 0;
            navdoc.Text = "View Doctor";
            navdoc.UseVisualStyleBackColor = false;
            navdoc.Click += navdoc_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(503, 33);
            label1.Name = "label1";
            label1.Size = new Size(188, 37);
            label1.TabIndex = 23;
            label1.Text = "View Doctors";
            label1.Click += label1_Click;
            // 
            // ViewDoctors
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 515);
            Controls.Add(label1);
            Controls.Add(sidenav);
            Controls.Add(dgvDoctors);
            Name = "ViewDoctors";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Doctor List";
            Load += ViewDoctor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDoctors).EndInit();
            sidenav.ResumeLayout(false);
            sidenav.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel sidenav;
        private Button navmedicalhistory;
        private Label label2;
        private Button navprofile;
        private Button logout;
        private Button navprescription;
        private Button navappointment;
        private Button navdoc;
        private Label label1;
    }
}