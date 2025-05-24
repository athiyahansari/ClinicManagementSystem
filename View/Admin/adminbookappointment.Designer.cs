namespace CMS.View.Admin
{
    partial class adminbookappointment
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            sidenav = new Panel();
            label3 = new Label();
            label2 = new Label();
            navprofile = new Button();
            logout = new Button();
            navappointment = new Button();
            navpatient = new Button();
            navdoc = new Button();
            panel1 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            column = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            flowLayoutPanel1.SuspendLayout();
            sidenav.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(sidenav);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1037, 445);
            flowLayoutPanel1.TabIndex = 0;
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
            sidenav.Margin = new Padding(0);
            sidenav.Name = "sidenav";
            sidenav.Size = new Size(192, 446);
            sidenav.TabIndex = 2;
            //sidenav.Paint += this.sidenav_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(50, 47);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(106, 19);
            label3.TabIndex = 6;
            label3.Text = "Admin ID-2346";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kristen ITC", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(27, 23);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(113, 27);
            label2.TabIndex = 5;
            label2.Text = "John Doe";
            // 
            // navprofile
            // 
            navprofile.BackColor = Color.LightSteelBlue;
            navprofile.Location = new Point(20, 332);
            navprofile.Margin = new Padding(2);
            navprofile.Name = "navprofile";
            navprofile.Size = new Size(150, 25);
            navprofile.TabIndex = 4;
            navprofile.Text = "MyProfile";
            navprofile.UseVisualStyleBackColor = false;
            navprofile.Click += navprofile_Click;
            // 
            // logout
            // 
            logout.BackColor = Color.LightSteelBlue;
            logout.Location = new Point(20, 361);
            logout.Margin = new Padding(2);
            logout.Name = "logout";
            logout.Size = new Size(150, 26);
            logout.TabIndex = 3;
            logout.Text = "LogOut";
            logout.UseVisualStyleBackColor = false;
            // 
            // navappointment
            // 
            navappointment.BackColor = Color.LightSteelBlue;
            navappointment.Location = new Point(20, 146);
            navappointment.Margin = new Padding(2);
            navappointment.Name = "navappointment";
            navappointment.Size = new Size(150, 28);
            navappointment.TabIndex = 2;
            navappointment.Text = "Appointment Schedules";
            navappointment.UseVisualStyleBackColor = false;
            // 
            // navpatient
            // 
            navpatient.BackColor = Color.LightSteelBlue;
            navpatient.Location = new Point(20, 115);
            navpatient.Margin = new Padding(2);
            navpatient.Name = "navpatient";
            navpatient.Size = new Size(150, 28);
            navpatient.TabIndex = 1;
            navpatient.Text = "Patients";
            navpatient.UseVisualStyleBackColor = false;
            // 
            // navdoc
            // 
            navdoc.BackColor = Color.LightSteelBlue;
            navdoc.Location = new Point(20, 85);
            navdoc.Margin = new Padding(2);
            navdoc.Name = "navdoc";
            navdoc.Size = new Size(150, 27);
            navdoc.TabIndex = 0;
            navdoc.Text = "Doctors";
            navdoc.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(192, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(767, 446);
            panel1.TabIndex = 3;
            //panel1.Paint += this.panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 47);
            label1.Name = "label1";
            label1.Size = new Size(149, 15);
            label1.TabIndex = 0;
            label1.Text = "View Patient appointments";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { column, Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(25, 79);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(794, 261);
            dataGridView1.TabIndex = 1;
            // 
            // column
            // 
            column.HeaderText = "Appointment ID";
            column.Name = "column";
            // 
            // Column1
            // 
            Column1.HeaderText = "Patient Name";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Doctor Name";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Date";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Time";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Status";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Actions";
            Column6.Name = "Column6";
            // 
            // adminbookappointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 445);
            Controls.Add(flowLayoutPanel1);
            Name = "adminbookappointment";
            Text = "adminbookappointment";
            flowLayoutPanel1.ResumeLayout(false);
            sidenav.ResumeLayout(false);
            sidenav.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel sidenav;
        private Label label3;
        private Label label2;
        private Button navprofile;
        private Button logout;
        private Button navappointment;
        private Button navpatient;
        private Button navdoc;
        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn column;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}