namespace CMS.View.Doctor
{
    partial class Reportdoctor
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            navprofilebtn = new Button();
            logoutbtn = new Button();
            navappointmentbtn = new Button();
            navpatientbtn = new Button();
            navdocbtn = new Button();
            panel2 = new Panel();
            label1 = new Label();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            todatepick = new TextBox();
            fromdatepick = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label8 = new Label();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 450);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(navprofilebtn);
            panel1.Controls.Add(logoutbtn);
            panel1.Controls.Add(navappointmentbtn);
            panel1.Controls.Add(navpatientbtn);
            panel1.Controls.Add(navdocbtn);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(160, 452);
            panel1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(44, 65);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(106, 19);
            label3.TabIndex = 13;
            label3.Text = "Admin ID-2346";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kristen ITC", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(21, 41);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(113, 27);
            label2.TabIndex = 12;
            label2.Text = "John Doe";
            // 
            // navprofilebtn
            // 
            navprofilebtn.BackColor = Color.LightSteelBlue;
            navprofilebtn.Location = new Point(21, 358);
            navprofilebtn.Margin = new Padding(2);
            navprofilebtn.Name = "navprofilebtn";
            navprofilebtn.Size = new Size(113, 28);
            navprofilebtn.TabIndex = 11;
            navprofilebtn.Text = "MyProfile";
            navprofilebtn.UseVisualStyleBackColor = false;
            // 
            // logoutbtn
            // 
            logoutbtn.BackColor = Color.LightSteelBlue;
            logoutbtn.Location = new Point(21, 387);
            logoutbtn.Margin = new Padding(2);
            logoutbtn.Name = "logoutbtn";
            logoutbtn.Size = new Size(113, 28);
            logoutbtn.TabIndex = 10;
            logoutbtn.Text = "LogOut";
            logoutbtn.UseVisualStyleBackColor = false;
            // 
            // navappointmentbtn
            // 
            navappointmentbtn.BackColor = Color.LightSteelBlue;
            navappointmentbtn.Location = new Point(21, 168);
            navappointmentbtn.Margin = new Padding(2);
            navappointmentbtn.Name = "navappointmentbtn";
            navappointmentbtn.Size = new Size(113, 28);
            navappointmentbtn.TabIndex = 9;
            navappointmentbtn.Text = "Appointment Schedules";
            navappointmentbtn.UseVisualStyleBackColor = false;
            // 
            // navpatientbtn
            // 
            navpatientbtn.BackColor = Color.LightSteelBlue;
            navpatientbtn.Location = new Point(21, 137);
            navpatientbtn.Margin = new Padding(2);
            navpatientbtn.Name = "navpatientbtn";
            navpatientbtn.Size = new Size(113, 28);
            navpatientbtn.TabIndex = 8;
            navpatientbtn.Text = "Patients";
            navpatientbtn.UseVisualStyleBackColor = false;
            // 
            // navdocbtn
            // 
            navdocbtn.BackColor = Color.LightSteelBlue;
            navdocbtn.Location = new Point(21, 107);
            navdocbtn.Margin = new Padding(2);
            navdocbtn.Name = "navdocbtn";
            navdocbtn.Size = new Size(113, 28);
            navdocbtn.TabIndex = 7;
            navdocbtn.Text = "Doctors";
            navdocbtn.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView2);
            panel2.Controls.Add(todatepick);
            panel2.Controls.Add(fromdatepick);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(160, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(622, 450);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Book", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(196, 25);
            label1.Name = "label1";
            label1.Size = new Size(162, 24);
            label1.TabIndex = 1;
            label1.Text = "Generate reports";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dataGridView2.Location = new Point(52, 165);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(543, 178);
            dataGridView2.TabIndex = 23;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Patient Name";
            dataGridViewTextBoxColumn1.MinimumWidth = 10;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Total Appointments";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Last Appointment Date";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 180;
            // 
            // todatepick
            // 
            todatepick.BackColor = SystemColors.InactiveBorder;
            todatepick.Location = new Point(247, 124);
            todatepick.Name = "todatepick";
            todatepick.Size = new Size(100, 23);
            todatepick.TabIndex = 22;
            // 
            // fromdatepick
            // 
            fromdatepick.BackColor = SystemColors.InactiveBorder;
            fromdatepick.Location = new Point(63, 124);
            fromdatepick.Name = "fromdatepick";
            fromdatepick.Size = new Size(95, 23);
            fromdatepick.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(92, 106);
            label10.Name = "label10";
            label10.Size = new Size(35, 15);
            label10.TabIndex = 20;
            label10.Text = "From";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(287, 106);
            label11.Name = "label11";
            label11.Size = new Size(19, 15);
            label11.TabIndex = 19;
            label11.Text = "To";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Navy;
            label8.Location = new Point(41, 78);
            label8.Name = "label8";
            label8.Size = new Size(214, 18);
            label8.TabIndex = 18;
            label8.Text = "View Patient appointment trends";
            // 
            // Reportdoctor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Name = "Reportdoctor";
            Text = "Reportdoctor";
            Load += Reportdoctor_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Button navprofilebtn;
        private Button logoutbtn;
        private Button navappointmentbtn;
        private Button navpatientbtn;
        private Button navdocbtn;
        private Panel panel2;
        private Label label1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private TextBox todatepick;
        private TextBox fromdatepick;
        private Label label10;
        private Label label11;
        private Label label8;
    }
}