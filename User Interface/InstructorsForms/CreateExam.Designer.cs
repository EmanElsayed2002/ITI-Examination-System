namespace User_Interface
{
    partial class CreateExam
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
            panel1 = new Panel();
            label5 = new Label();
            Durtaion = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label17 = new Label();
            label11 = new Label();
            button7 = new Button();
            dateTimePicker1 = new DateTimePicker();
            examSubject = new TextBox();
            examName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            label7 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleGreen;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(Durtaion);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(examSubject);
            panel1.Controls.Add(examName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 104);
            panel1.Name = "panel1";
            panel1.Size = new Size(1358, 737);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(544, 489);
            label5.Name = "label5";
            label5.Size = new Size(0, 21);
            label5.TabIndex = 34;
            // 
            // Durtaion
            // 
            Durtaion.Font = new Font("Tahoma", 12F);
            Durtaion.Location = new Point(530, 454);
            Durtaion.Name = "Durtaion";
            Durtaion.Size = new Size(410, 32);
            Durtaion.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label6.Location = new Point(422, 454);
            label6.Name = "label6";
            label6.Size = new Size(98, 24);
            label6.TabIndex = 32;
            label6.Text = "Duration";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(514, 110);
            label4.Name = "label4";
            label4.Size = new Size(354, 54);
            label4.TabIndex = 31;
            label4.Text = "Create Your Exam";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.Red;
            label17.Location = new Point(544, 338);
            label17.Name = "label17";
            label17.Size = new Size(0, 21);
            label17.TabIndex = 30;
            label17.Click += label17_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(544, 263);
            label11.Name = "label11";
            label11.Size = new Size(0, 21);
            label11.TabIndex = 22;
            // 
            // button7
            // 
            button7.BackColor = Color.DarkOrange;
            button7.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            button7.Location = new Point(599, 524);
            button7.Name = "button7";
            button7.Size = new Size(246, 74);
            button7.TabIndex = 20;
            button7.Text = "Create Exam";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Tahoma", 12F);
            dateTimePicker1.Location = new Point(530, 380);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(410, 32);
            dateTimePicker1.TabIndex = 10;
            // 
            // examSubject
            // 
            examSubject.Font = new Font("Tahoma", 12F);
            examSubject.Location = new Point(530, 303);
            examSubject.Name = "examSubject";
            examSubject.Size = new Size(410, 32);
            examSubject.TabIndex = 6;
            // 
            // examName
            // 
            examName.Font = new Font("Tahoma", 12F);
            examName.Location = new Point(530, 228);
            examName.Name = "examName";
            examName.Size = new Size(410, 32);
            examName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label3.Location = new Point(408, 386);
            label3.Name = "label3";
            label3.Size = new Size(112, 24);
            label3.TabIndex = 2;
            label3.Text = "ExamDate";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label2.Location = new Point(433, 303);
            label2.Name = "label2";
            label2.Size = new Size(87, 24);
            label2.TabIndex = 1;
            label2.Text = "Subject";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label1.Location = new Point(401, 228);
            label1.Name = "label1";
            label1.Size = new Size(123, 24);
            label1.TabIndex = 0;
            label1.Text = "ExamName";
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
            button8.TabIndex = 30;
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
            button9.TabIndex = 29;
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
            button10.TabIndex = 28;
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
            button11.TabIndex = 27;
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
            button12.TabIndex = 26;
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
            button13.TabIndex = 25;
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
            button14.TabIndex = 24;
            button14.Text = "View Your Exams";
            button14.TextImageRelation = TextImageRelation.ImageBeforeText;
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(139, 99);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 35;
            label7.Text = "label7";
            // 
            // CreateExam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrange;
            ClientSize = new Size(1382, 853);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(button13);
            Controls.Add(button14);
            Controls.Add(panel1);
            Name = "CreateExam";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateExam";
            Load += CreateExam_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox examSubject;
        private TextBox examName;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Button button7;
        private Label label11;
        private Label label17;
        private Label label4;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Label label5;
        private TextBox Durtaion;
        private Label label6;
        private Label label7;
    }
}