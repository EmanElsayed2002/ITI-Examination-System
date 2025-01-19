namespace User_Interface
{
    partial class UpdateDeleteExam
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
            button6 = new Button();
            comboBoxExam = new ComboBox();
            label6 = new Label();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button6
            // 
            button6.BackColor = Color.LightSeaGreen;
            button6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(575, 557);
            button6.Name = "button6";
            button6.Size = new Size(252, 53);
            button6.TabIndex = 19;
            button6.Text = "sync";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // comboBoxExam
            // 
            comboBoxExam.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxExam.FormattingEnabled = true;
            comboBoxExam.Items.AddRange(new object[] { "MCQ", "True&False" });
            comboBoxExam.Location = new Point(560, 51);
            comboBoxExam.Name = "comboBoxExam";
            comboBoxExam.Size = new Size(382, 28);
            comboBoxExam.TabIndex = 38;
            comboBoxExam.SelectedIndexChanged += comboBoxQuestionType_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(296, 41);
            label6.Name = "label6";
            label6.Size = new Size(258, 38);
            label6.TabIndex = 37;
            label6.Text = "Choose Your Exam";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(comboBoxExam);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(12, 94);
            panel1.Name = "panel1";
            panel1.Size = new Size(1358, 647);
            panel1.TabIndex = 69;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(20, 96);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1320, 438);
            dataGridView1.TabIndex = 53;
            // 
            // button8
            // 
            button8.BackColor = Color.LightSeaGreen;
            button8.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            button8.ForeColor = SystemColors.ButtonHighlight;
            button8.Image = Properties.Resources.icons8_back_64;
            button8.Location = new Point(12, 12);
            button8.Name = "button8";
            button8.Size = new Size(108, 76);
            button8.TabIndex = 81;
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
            button9.TabIndex = 80;
            button9.Text = "Exit";
            button9.TextImageRelation = TextImageRelation.ImageBeforeText;
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.LightSeaGreen;
            button10.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            button10.ForeColor = SystemColors.ButtonHighlight;
            button10.Image = Properties.Resources.icons8_update_64;
            button10.Location = new Point(765, 12);
            button10.Name = "button10";
            button10.Size = new Size(259, 76);
            button10.TabIndex = 79;
            button10.Text = "Update/Delete Exams";
            button10.TextImageRelation = TextImageRelation.ImageBeforeText;
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.LightSeaGreen;
            button11.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            button11.ForeColor = SystemColors.ButtonHighlight;
            button11.Image = Properties.Resources.icons8_edit_account_64;
            button11.Location = new Point(1030, 12);
            button11.Name = "button11";
            button11.Size = new Size(187, 76);
            button11.TabIndex = 78;
            button11.Text = "Profile";
            button11.TextImageRelation = TextImageRelation.ImageBeforeText;
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.LightSeaGreen;
            button12.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            button12.ForeColor = SystemColors.ButtonHighlight;
            button12.Image = Properties.Resources.icons8_create_64;
            button12.Location = new Point(572, 12);
            button12.Name = "button12";
            button12.Size = new Size(187, 76);
            button12.TabIndex = 77;
            button12.Text = "Create Exam";
            button12.TextImageRelation = TextImageRelation.ImageBeforeText;
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.LightSeaGreen;
            button13.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            button13.ForeColor = SystemColors.ButtonHighlight;
            button13.Image = Properties.Resources.icons8_person_student_48;
            button13.Location = new Point(351, 12);
            button13.Name = "button13";
            button13.Size = new Size(215, 76);
            button13.TabIndex = 76;
            button13.Text = "View Your Student";
            button13.TextImageRelation = TextImageRelation.ImageBeforeText;
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.BackColor = Color.LightSeaGreen;
            button14.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            button14.ForeColor = SystemColors.ButtonHighlight;
            button14.Image = Properties.Resources.icons8_view_64;
            button14.ImageAlign = ContentAlignment.MiddleLeft;
            button14.Location = new Point(126, 12);
            button14.Name = "button14";
            button14.Size = new Size(219, 76);
            button14.TabIndex = 75;
            button14.Text = "View Your Exams";
            button14.TextImageRelation = TextImageRelation.ImageBeforeText;
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click;
            // 
            // UpdateDeleteExam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(1382, 753);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(button13);
            Controls.Add(button14);
            Controls.Add(panel1);
            Name = "UpdateDeleteExam";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateDeleteExam";
            Load += UpdateDeleteExam_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button6;
        private ComboBox comboBoxExam;
        private Label label6;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
    }
}