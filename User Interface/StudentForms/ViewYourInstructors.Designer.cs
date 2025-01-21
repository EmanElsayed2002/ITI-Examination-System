namespace User_Interface.StudentForms
{
    partial class ViewYourInstructors
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
            dataGridInstructors = new DataGridView();
            panel1 = new Panel();
            button1 = new Button();
            button7 = new Button();
            button5 = new Button();
            button6 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridInstructors).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridInstructors
            // 
            dataGridInstructors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridInstructors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridInstructors.Location = new Point(0, 0);
            dataGridInstructors.Name = "dataGridInstructors";
            dataGridInstructors.RowHeadersWidth = 51;
            dataGridInstructors.Size = new Size(1358, 619);
            dataGridInstructors.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleGreen;
            panel1.Controls.Add(dataGridInstructors);
            panel1.Location = new Point(12, 108);
            panel1.Name = "panel1";
            panel1.Size = new Size(1358, 619);
            panel1.TabIndex = 25;
            // 
            // button1
            // 
            button1.BackColor = Color.PaleGreen;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.Image = Properties.Resources.icons8_view_64;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(126, 26);
            button1.Name = "button1";
            button1.Size = new Size(219, 76);
            button1.TabIndex = 26;
            button1.Text = "View Your Exams";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.PaleGreen;
            button7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button7.ForeColor = Color.Black;
            button7.Image = Properties.Resources.icons8_back_64;
            button7.Location = new Point(12, 26);
            button7.Name = "button7";
            button7.Size = new Size(108, 76);
            button7.TabIndex = 32;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Red;
            button5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button5.ForeColor = Color.Black;
            button5.Image = Properties.Resources.icons8_power_off_button_64;
            button5.Location = new Point(1223, 26);
            button5.Name = "button5";
            button5.Size = new Size(147, 76);
            button5.TabIndex = 31;
            button5.Text = "Exit";
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.PaleGreen;
            button6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button6.ForeColor = Color.Black;
            button6.Image = Properties.Resources.icons8_pin_pad_64;
            button6.Location = new Point(841, 26);
            button6.Name = "button6";
            button6.Size = new Size(208, 76);
            button6.TabIndex = 30;
            button6.Text = "enter exam";
            button6.TextImageRelation = TextImageRelation.ImageBeforeText;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.PaleGreen;
            button4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button4.ForeColor = Color.Black;
            button4.Image = Properties.Resources.icons8_edit_account_64;
            button4.Location = new Point(1055, 26);
            button4.Name = "button4";
            button4.Size = new Size(162, 76);
            button4.TabIndex = 29;
            button4.Text = "Profile";
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.PaleGreen;
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button3.ForeColor = Color.Black;
            button3.Image = Properties.Resources.icons8_event_accepted_tentatively_64;
            button3.Location = new Point(609, 26);
            button3.Name = "button3";
            button3.Size = new Size(226, 76);
            button3.TabIndex = 28;
            button3.Text = "uncoming Exam";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.PaleGreen;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button2.ForeColor = Color.Black;
            button2.Image = Properties.Resources.icons8_training_64;
            button2.Location = new Point(351, 26);
            button2.Name = "button2";
            button2.Size = new Size(252, 76);
            button2.TabIndex = 27;
            button2.Text = "View Your Instructors";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // ViewYourInstructors
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(1382, 753);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(button7);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Name = "ViewYourInstructors";
            Text = "ViewYourInstructors";
            Load += ViewYourInstructors_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridInstructors).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridInstructors;
        private Panel panel1;
        private Button button1;
        private Button button7;
        private Button button5;
        private Button button6;
        private Button button4;
        private Button button3;
        private Button button2;
    }
}