namespace User_Interface
{
    partial class ViewYourStudent
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
            dataGridViewStudent = new DataGridView();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudent).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewStudent
            // 
            dataGridViewStudent.AllowUserToAddRows = false;
            dataGridViewStudent.AllowUserToDeleteRows = false;
            dataGridViewStudent.AllowUserToResizeColumns = false;
            dataGridViewStudent.AllowUserToResizeRows = false;
            dataGridViewStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudent.Location = new Point(12, 103);
            dataGridViewStudent.Name = "dataGridViewStudent";
            dataGridViewStudent.ReadOnly = true;
            dataGridViewStudent.RowHeadersWidth = 51;
            dataGridViewStudent.Size = new Size(1358, 638);
            dataGridViewStudent.TabIndex = 0;
            // 
            // button8
            // 
            button8.BackColor = Color.PaleGreen;
            button8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button8.ForeColor = Color.Black;
            button8.Image = Properties.Resources.icons8_back_64;
            button8.Location = new Point(12, 12);
            button8.Name = "button8";
            button8.Size = new Size(108, 76);
            button8.TabIndex = 23;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.Red;
            button9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button9.ForeColor = Color.Black;
            button9.Image = Properties.Resources.icons8_power_off_button_64;
            button9.Location = new Point(1223, 12);
            button9.Name = "button9";
            button9.Size = new Size(147, 76);
            button9.TabIndex = 22;
            button9.Text = "Exit";
            button9.TextImageRelation = TextImageRelation.ImageBeforeText;
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.PaleGreen;
            button10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button10.ForeColor = Color.Black;
            button10.Image = Properties.Resources.icons8_update_64;
            button10.Location = new Point(765, 12);
            button10.Name = "button10";
            button10.Size = new Size(259, 76);
            button10.TabIndex = 21;
            button10.Text = "Update/Delete Exams";
            button10.TextImageRelation = TextImageRelation.ImageBeforeText;
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.PaleGreen;
            button11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button11.ForeColor = Color.Black;
            button11.Image = Properties.Resources.icons8_edit_account_64;
            button11.Location = new Point(1030, 12);
            button11.Name = "button11";
            button11.Size = new Size(187, 76);
            button11.TabIndex = 20;
            button11.Text = "Profile";
            button11.TextImageRelation = TextImageRelation.ImageBeforeText;
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.PaleGreen;
            button12.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button12.ForeColor = Color.Black;
            button12.Image = Properties.Resources.icons8_create_64;
            button12.Location = new Point(572, 12);
            button12.Name = "button12";
            button12.Size = new Size(187, 76);
            button12.TabIndex = 19;
            button12.Text = "Create Exam";
            button12.TextImageRelation = TextImageRelation.ImageBeforeText;
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.PaleGreen;
            button13.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button13.ForeColor = Color.Black;
            button13.Image = Properties.Resources.icons8_person_student_48;
            button13.Location = new Point(351, 12);
            button13.Name = "button13";
            button13.Size = new Size(215, 76);
            button13.TabIndex = 18;
            button13.Text = "View Your Student";
            button13.TextImageRelation = TextImageRelation.ImageBeforeText;
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.BackColor = Color.PaleGreen;
            button14.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button14.ForeColor = Color.Black;
            button14.Image = Properties.Resources.icons8_view_64;
            button14.ImageAlign = ContentAlignment.MiddleLeft;
            button14.Location = new Point(126, 12);
            button14.Name = "button14";
            button14.Size = new Size(219, 76);
            button14.TabIndex = 17;
            button14.Text = "View Your Exams";
            button14.TextImageRelation = TextImageRelation.ImageBeforeText;
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click;
            // 
            // ViewYourStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrange;
            ClientSize = new Size(1382, 753);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(dataGridViewStudent);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(button13);
            Controls.Add(button14);
            Name = "ViewYourStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewYourStudent";
            Load += ViewYourStudent_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudent).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridViewStudent;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
    }
}