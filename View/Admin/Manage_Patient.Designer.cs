namespace CMS.View.Admin
{
    partial class Manage_Patient
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            dataGridViewPatients = new DataGridView();
            btnAdd = new Button();
            btnRemove = new Button();
            btnEdit = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            label2 = new Label();
            label3 = new Label();
            First_Name = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            DateOfBirth = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPatients).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Highlight;
            pictureBox1.Location = new Point(1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(260, 619);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(474, 40);
            label1.Name = "label1";
            label1.Size = new Size(240, 41);
            label1.TabIndex = 1;
            label1.Text = "Manage Patient";
            // 
            // dataGridViewPatients
            // 
            dataGridViewPatients.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.NullValue = "Vithu";
            dataGridViewPatients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewPatients.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPatients.Columns.AddRange(new DataGridViewColumn[] { First_Name, Name, DateOfBirth, Column1 });
            dataGridViewPatients.GridColor = SystemColors.InactiveCaptionText;
            dataGridViewPatients.Location = new Point(316, 129);
            dataGridViewPatients.Name = "dataGridViewPatients";
            dataGridViewPatients.RowHeadersWidth = 51;
            dataGridViewPatients.Size = new Size(556, 291);
            dataGridViewPatients.TabIndex = 2;
            dataGridViewPatients.CellContentClick += dataGridViewPatients_CellContentClick;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(391, 465);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(102, 46);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemove.Location = new Point(529, 465);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(145, 46);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "REMOVE";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(721, 465);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 46);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.LightSteelBlue;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(35, 164);
            button4.Name = "button4";
            button4.Size = new Size(179, 39);
            button4.TabIndex = 6;
            button4.Text = "Doctors";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.LightSteelBlue;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(35, 209);
            button5.Name = "button5";
            button5.Size = new Size(179, 41);
            button5.TabIndex = 7;
            button5.Text = "Patient";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.LightSteelBlue;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(35, 256);
            button6.Name = "button6";
            button6.Size = new Size(179, 41);
            button6.TabIndex = 8;
            button6.Text = "Appointments";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.LightSteelBlue;
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(35, 454);
            button7.Name = "button7";
            button7.Size = new Size(168, 41);
            button7.TabIndex = 9;
            button7.Text = "My Profile";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.LightSteelBlue;
            button8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.Location = new Point(35, 501);
            button8.Name = "button8";
            button8.Size = new Size(168, 37);
            button8.TabIndex = 10;
            button8.Text = "Log Out";
            button8.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Kristen ITC", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 31);
            label2.Name = "label2";
            label2.Size = new Size(132, 30);
            label2.TabIndex = 11;
            label2.Text = "John Doe";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(102, 75);
            label3.Name = "label3";
            label3.Size = new Size(135, 25);
            label3.TabIndex = 12;
            label3.Text = "Admin-ID 2346";
            // 
            // First_Name
            // 
            First_Name.HeaderText = "First_Name";
            First_Name.MinimumWidth = 6;
            First_Name.Name = "First_Name";
            First_Name.ToolTipText = "vithu";
            First_Name.Width = 125;
            // 
            // Name
            // 
            Name.HeaderText = "Last_Name";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.ToolTipText = "kamal";
            Name.Width = 125;
            // 
            // DateOfBirth
            // 
            DateOfBirth.HeaderText = "DateOfBirth";
            DateOfBirth.MinimumWidth = 6;
            DateOfBirth.Name = "DateOfBirth";
            DateOfBirth.ToolTipText = "2003.05.07";
            DateOfBirth.Width = 125;
            // 
            // Column1
            // 
            Column1.HeaderText = "Email";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ToolTipText = "kamal@gmail.com";
            Column1.Width = 125;
            // 
            // Manage_Patient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(933, 620);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(btnEdit);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(dataGridViewPatients);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            //Name = "Manage_Patient";
            Text = "Manage_Patient";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPatients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView dataGridViewPatients;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnEdit;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Label label2;
        private Label label3;
        private DataGridViewTextBoxColumn First_Name;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn DateOfBirth;
        private DataGridViewTextBoxColumn Column1;
    }
}