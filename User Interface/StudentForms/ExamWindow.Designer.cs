namespace User_Interface.StudentForms
{
    partial class ExamWindow
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button6 = new Button();
            button4 = new Button();
            button3 = new Button();
            button7 = new Button();
            panel1 = new Panel();
            noOfQuestions = new Label();
            button8 = new Button();
            op4 = new RadioButton();
            op3 = new RadioButton();
            op2 = new RadioButton();
            op1 = new RadioButton();
            labelquestionText = new Label();
            panel2 = new Panel();
            examDurationTextBox = new TextBox();
            examDate = new TextBox();
            examSubject = new TextBox();
            examName = new TextBox();
            examID = new TextBox();
            lblTimer = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button5 = new Button();
            button2 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
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
            button1.TabIndex = 34;
            button1.Text = "View Your Exams";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            button6.TabIndex = 38;
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
            button4.TabIndex = 37;
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
            button3.TabIndex = 36;
            button3.Text = "uncoming Exam";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
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
            button7.TabIndex = 40;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleGreen;
            panel1.Controls.Add(noOfQuestions);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(op4);
            panel1.Controls.Add(op3);
            panel1.Controls.Add(op2);
            panel1.Controls.Add(op1);
            panel1.Controls.Add(labelquestionText);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 108);
            panel1.Name = "panel1";
            panel1.Size = new Size(1358, 619);
            panel1.TabIndex = 33;
            // 
            // noOfQuestions
            // 
            noOfQuestions.AutoSize = true;
            noOfQuestions.Location = new Point(586, 554);
            noOfQuestions.Name = "noOfQuestions";
            noOfQuestions.Size = new Size(0, 20);
            noOfQuestions.TabIndex = 7;
            // 
            // button8
            // 
            button8.BackColor = Color.SandyBrown;
            button8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(1033, 493);
            button8.Name = "button8";
            button8.Size = new Size(128, 50);
            button8.TabIndex = 6;
            button8.Text = "Next";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // op4
            // 
            op4.AutoSize = true;
            op4.Location = new Point(892, 484);
            op4.Name = "op4";
            op4.Size = new Size(17, 16);
            op4.TabIndex = 5;
            op4.TabStop = true;
            op4.UseVisualStyleBackColor = true;
            // 
            // op3
            // 
            op3.AutoSize = true;
            op3.Location = new Point(397, 484);
            op3.Name = "op3";
            op3.Size = new Size(17, 16);
            op3.TabIndex = 4;
            op3.TabStop = true;
            op3.UseVisualStyleBackColor = true;
            // 
            // op2
            // 
            op2.AutoSize = true;
            op2.Location = new Point(892, 372);
            op2.Name = "op2";
            op2.Size = new Size(17, 16);
            op2.TabIndex = 3;
            op2.TabStop = true;
            op2.UseVisualStyleBackColor = true;
            // 
            // op1
            // 
            op1.AutoSize = true;
            op1.Location = new Point(397, 372);
            op1.Name = "op1";
            op1.Size = new Size(17, 16);
            op1.TabIndex = 2;
            op1.TabStop = true;
            op1.UseVisualStyleBackColor = true;
            // 
            // labelquestionText
            // 
            labelquestionText.AutoSize = true;
            labelquestionText.BackColor = Color.DarkGreen;
            labelquestionText.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelquestionText.Location = new Point(513, 263);
            labelquestionText.Name = "labelquestionText";
            labelquestionText.Size = new Size(0, 23);
            labelquestionText.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGreen;
            panel2.Controls.Add(examDurationTextBox);
            panel2.Controls.Add(examDate);
            panel2.Controls.Add(examSubject);
            panel2.Controls.Add(examName);
            panel2.Controls.Add(examID);
            panel2.Controls.Add(lblTimer);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(8, 9);
            panel2.Name = "panel2";
            panel2.Size = new Size(1347, 214);
            panel2.TabIndex = 0;
            // 
            // examDurationTextBox
            // 
            examDurationTextBox.Location = new Point(877, 80);
            examDurationTextBox.Name = "examDurationTextBox";
            examDurationTextBox.ReadOnly = true;
            examDurationTextBox.Size = new Size(232, 27);
            examDurationTextBox.TabIndex = 11;
            // 
            // examDate
            // 
            examDate.Location = new Point(877, 23);
            examDate.Name = "examDate";
            examDate.ReadOnly = true;
            examDate.Size = new Size(232, 27);
            examDate.TabIndex = 10;
            // 
            // examSubject
            // 
            examSubject.Location = new Point(202, 158);
            examSubject.Name = "examSubject";
            examSubject.ReadOnly = true;
            examSubject.Size = new Size(204, 27);
            examSubject.TabIndex = 8;
            // 
            // examName
            // 
            examName.Location = new Point(202, 84);
            examName.Name = "examName";
            examName.ReadOnly = true;
            examName.Size = new Size(204, 27);
            examName.TabIndex = 7;
            examName.TextChanged += textBox2_TextChanged;
            // 
            // examID
            // 
            examID.Location = new Point(202, 23);
            examID.Name = "examID";
            examID.ReadOnly = true;
            examID.Size = new Size(204, 27);
            examID.TabIndex = 6;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.BackColor = Color.Ivory;
            lblTimer.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblTimer.Location = new Point(753, 143);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(0, 23);
            lblTimer.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label5.Location = new Point(75, 93);
            label5.Name = "label5";
            label5.Size = new Size(105, 23);
            label5.TabIndex = 4;
            label5.Text = "Exam Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.Location = new Point(75, 158);
            label4.Name = "label4";
            label4.Size = new Size(70, 23);
            label4.TabIndex = 3;
            label4.Text = "Subject";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.Location = new Point(753, 27);
            label3.Name = "label3";
            label3.Size = new Size(91, 23);
            label3.TabIndex = 2;
            label3.Text = "ExamDate";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(753, 84);
            label2.Name = "label2";
            label2.Size = new Size(81, 23);
            label2.TabIndex = 1;
            label2.Text = "Duration";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label1.Location = new Point(73, 27);
            label1.Name = "label1";
            label1.Size = new Size(71, 23);
            label1.TabIndex = 0;
            label1.Text = "ExamID";
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
            button5.TabIndex = 39;
            button5.Text = "Exit";
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
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
            button2.TabIndex = 35;
            button2.Text = "View Your Student";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // ExamWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(1382, 753);
            Controls.Add(button1);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button7);
            Controls.Add(panel1);
            Controls.Add(button5);
            Controls.Add(button2);
            Name = "ExamWindow";
            Text = "ExamInstructions";
            Load += ExamWindow_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button6;
        private Button button4;
        private Button button3;
        private Button button7;
        private Panel panel1;
        private Button button5;
        private Button button2;
        private Panel panel2;
        private Label labelquestionText;
        private RadioButton op4;
        private RadioButton op3;
        private RadioButton op2;
        private RadioButton op1;
        private Label noOfQuestions;
        private Button button8;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Label lblTimer;
        private TextBox examDate;
        private TextBox examDuration;
        private TextBox examDurationTextBox;
        private TextBox examSubject;
        private TextBox examName;
        private TextBox examID;
        //private TextBox examDuration;
    }
}