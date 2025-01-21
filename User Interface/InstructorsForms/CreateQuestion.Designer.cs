namespace User_Interface
{
    partial class CreateQuestion
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
            button7 = new Button();
            label14 = new Label();
            Answer = new TextBox();
            button6 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            comboBoxQuestionType = new ComboBox();
            label6 = new Label();
            lblAnswer = new Label();
            label4 = new Label();
            label15 = new Label();
            QuestionBody = new TextBox();
            labelTypeOfQuestion = new Label();
            lblOp2 = new Label();
            Opt2 = new TextBox();
            label10 = new Label();
            label5 = new Label();
            Opt4 = new TextBox();
            Opt1 = new TextBox();
            label8 = new Label();
            Opt3 = new TextBox();
            label9 = new Label();
            label7 = new Label();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button7
            // 
            button7.BackColor = Color.LightSeaGreen;
            button7.Font = new Font("Tahoma", 13.8F, FontStyle.Bold);
            button7.Location = new Point(781, 521);
            button7.Name = "button7";
            button7.Size = new Size(252, 53);
            button7.TabIndex = 52;
            button7.Text = "Finish";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Tahoma", 13.8F, FontStyle.Bold);
            label14.ForeColor = SystemColors.ButtonHighlight;
            label14.Location = new Point(572, 412);
            label14.Name = "label14";
            label14.Size = new Size(99, 28);
            label14.TabIndex = 50;
            label14.Text = "Answer";
            // 
            // Answer
            // 
            Answer.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            Answer.Location = new Point(677, 416);
            Answer.Name = "Answer";
            Answer.PlaceholderText = "enter your answer";
            Answer.Size = new Size(258, 28);
            Answer.TabIndex = 51;
            // 
            // button6
            // 
            button6.BackColor = Color.LightSeaGreen;
            button6.Font = new Font("Tahoma", 13.8F, FontStyle.Bold);
            button6.Location = new Point(448, 521);
            button6.Name = "button6";
            button6.Size = new Size(252, 53);
            button6.TabIndex = 19;
            button6.Text = "Add new Question";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(Answer);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(comboBoxQuestionType);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(lblAnswer);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(QuestionBody);
            panel1.Controls.Add(labelTypeOfQuestion);
            panel1.Controls.Add(lblOp2);
            panel1.Controls.Add(Opt2);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(Opt4);
            panel1.Controls.Add(Opt1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(Opt3);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(12, 104);
            panel1.Name = "panel1";
            panel1.Size = new Size(1358, 637);
            panel1.TabIndex = 63;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(621, 34);
            label1.Name = "label1";
            label1.Size = new Size(229, 28);
            label1.TabIndex = 63;
            label1.Text = "Add Your Question";
            // 
            // comboBoxQuestionType
            // 
            comboBoxQuestionType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxQuestionType.FormattingEnabled = true;
            comboBoxQuestionType.Location = new Point(621, 145);
            comboBoxQuestionType.Name = "comboBoxQuestionType";
            comboBoxQuestionType.Size = new Size(382, 28);
            comboBoxQuestionType.TabIndex = 38;
            comboBoxQuestionType.SelectedIndexChanged += comboBoxQuestionType_SelectedIndexChanged_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 13.8F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(321, 141);
            label6.Name = "label6";
            label6.Size = new Size(274, 28);
            label6.TabIndex = 37;
            label6.Text = "Type Of Your Question";
            // 
            // lblAnswer
            // 
            lblAnswer.AutoSize = true;
            lblAnswer.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblAnswer.ForeColor = Color.Red;
            lblAnswer.Location = new Point(707, 446);
            lblAnswer.Name = "lblAnswer";
            lblAnswer.Size = new Size(0, 23);
            lblAnswer.TabIndex = 62;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 13.8F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(321, 210);
            label4.Name = "label4";
            label4.Size = new Size(292, 28);
            label4.TabIndex = 33;
            label4.Text = "Add Your Question Here";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label15.ForeColor = Color.Red;
            label15.Location = new Point(654, 240);
            label15.Name = "label15";
            label15.Size = new Size(0, 23);
            label15.TabIndex = 61;
            // 
            // QuestionBody
            // 
            QuestionBody.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            QuestionBody.Location = new Point(622, 210);
            QuestionBody.Name = "QuestionBody";
            QuestionBody.Size = new Size(382, 28);
            QuestionBody.TabIndex = 35;
            // 
            // labelTypeOfQuestion
            // 
            labelTypeOfQuestion.AutoSize = true;
            labelTypeOfQuestion.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            labelTypeOfQuestion.ForeColor = Color.Red;
            labelTypeOfQuestion.Location = new Point(654, 176);
            labelTypeOfQuestion.Name = "labelTypeOfQuestion";
            labelTypeOfQuestion.Size = new Size(0, 23);
            labelTypeOfQuestion.TabIndex = 60;
            // 
            // lblOp2
            // 
            lblOp2.AutoSize = true;
            lblOp2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblOp2.ForeColor = Color.Red;
            lblOp2.Location = new Point(870, 308);
            lblOp2.Name = "lblOp2";
            lblOp2.Size = new Size(0, 23);
            lblOp2.TabIndex = 59;
            // 
            // Opt2
            // 
            Opt2.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            Opt2.Location = new Point(881, 278);
            Opt2.Name = "Opt2";
            Opt2.Size = new Size(258, 28);
            Opt2.TabIndex = 44;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(485, 311);
            label10.Name = "label10";
            label10.Size = new Size(0, 23);
            label10.TabIndex = 58;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 13.8F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(339, 278);
            label5.Name = "label5";
            label5.Size = new Size(105, 28);
            label5.TabIndex = 34;
            label5.Text = "Option1";
            // 
            // Opt4
            // 
            Opt4.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            Opt4.Location = new Point(881, 336);
            Opt4.Name = "Opt4";
            Opt4.Size = new Size(258, 28);
            Opt4.TabIndex = 42;
            // 
            // Opt1
            // 
            Opt1.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            Opt1.Location = new Point(458, 281);
            Opt1.Name = "Opt1";
            Opt1.Size = new Size(258, 28);
            Opt1.TabIndex = 36;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 13.8F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(765, 336);
            label8.Name = "label8";
            label8.Size = new Size(105, 28);
            label8.TabIndex = 41;
            label8.Text = "Option4";
            // 
            // Opt3
            // 
            Opt3.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            Opt3.Location = new Point(458, 339);
            Opt3.Name = "Opt3";
            Opt3.Size = new Size(258, 28);
            Opt3.TabIndex = 40;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 13.8F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(765, 278);
            label9.Name = "label9";
            label9.Size = new Size(105, 28);
            label9.TabIndex = 43;
            label9.Text = "Option2";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 13.8F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(339, 339);
            label7.Name = "label7";
            label7.Size = new Size(105, 28);
            label7.TabIndex = 39;
            label7.Text = "Option3";
            // 
            // button8
            // 
            button8.BackColor = Color.LightSeaGreen;
            button8.Font = new Font("Tahoma", 13.8F, FontStyle.Bold);
            button8.ForeColor = SystemColors.ButtonHighlight;
            button8.Image = Properties.Resources.icons8_back_64;
            button8.Location = new Point(12, 12);
            button8.Name = "button8";
            button8.Size = new Size(108, 76);
            button8.TabIndex = 75;
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
            button9.TabIndex = 74;
            button9.Text = "Exit";
            button9.TextImageRelation = TextImageRelation.ImageBeforeText;
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.LightSeaGreen;
            button10.Font = new Font("Tahoma", 13.8F, FontStyle.Bold);
            button10.ForeColor = SystemColors.ButtonHighlight;
            button10.Image = Properties.Resources.icons8_update_64;
            button10.Location = new Point(765, 12);
            button10.Name = "button10";
            button10.Size = new Size(259, 76);
            button10.TabIndex = 73;
            button10.Text = "Update/Delete Exams";
            button10.TextImageRelation = TextImageRelation.ImageBeforeText;
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.LightSeaGreen;
            button11.Font = new Font("Tahoma", 13.8F, FontStyle.Bold);
            button11.ForeColor = SystemColors.ButtonHighlight;
            button11.Image = Properties.Resources.icons8_edit_account_64;
            button11.Location = new Point(1030, 12);
            button11.Name = "button11";
            button11.Size = new Size(187, 76);
            button11.TabIndex = 72;
            button11.Text = "Profile";
            button11.TextImageRelation = TextImageRelation.ImageBeforeText;
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.LightSeaGreen;
            button12.Font = new Font("Tahoma", 13.8F, FontStyle.Bold);
            button12.ForeColor = SystemColors.ButtonHighlight;
            button12.Image = Properties.Resources.icons8_create_64;
            button12.Location = new Point(572, 12);
            button12.Name = "button12";
            button12.Size = new Size(187, 76);
            button12.TabIndex = 71;
            button12.Text = "Create Exam";
            button12.TextImageRelation = TextImageRelation.ImageBeforeText;
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.LightSeaGreen;
            button13.Font = new Font("Tahoma", 13.8F, FontStyle.Bold);
            button13.ForeColor = SystemColors.ButtonHighlight;
            button13.Image = Properties.Resources.icons8_person_student_48;
            button13.Location = new Point(351, 12);
            button13.Name = "button13";
            button13.Size = new Size(215, 76);
            button13.TabIndex = 70;
            button13.Text = "View Your Student";
            button13.TextImageRelation = TextImageRelation.ImageBeforeText;
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.BackColor = Color.LightSeaGreen;
            button14.Font = new Font("Tahoma", 13.8F, FontStyle.Bold);
            button14.ForeColor = SystemColors.ButtonHighlight;
            button14.Image = Properties.Resources.icons8_view_64;
            button14.ImageAlign = ContentAlignment.MiddleLeft;
            button14.Location = new Point(126, 12);
            button14.Name = "button14";
            button14.Size = new Size(219, 76);
            button14.TabIndex = 69;
            button14.Text = "View Your Exams";
            button14.TextImageRelation = TextImageRelation.ImageBeforeText;
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click;
            // 
            // CreateQuestion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1382, 753);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(button13);
            Controls.Add(button14);
            Controls.Add(panel1);
            Name = "CreateQuestion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateQuestion";
            Load += CreateQuestion_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button7;
        private Label label14;
        private TextBox Answer;
        private Button button6;
        private Panel panel1;
        private ComboBox comboBoxQuestionType;
        private Label label6;
        private Label lblAnswer;
        private Label label4;
        private Label label15;
        private TextBox QuestionBody;
        private Label labelTypeOfQuestion;
        private Label lblOp2;
        private TextBox Opt2;
        private Label label10;
        private Label label5;
        private TextBox Opt4;
        private TextBox Opt1;
        private Label label8;
        private TextBox Opt3;
        private Label label9;
        private Label label7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Label label1;
    }
}