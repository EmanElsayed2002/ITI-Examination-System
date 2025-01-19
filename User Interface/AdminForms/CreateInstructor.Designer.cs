namespace User_Interface.AdminForms
{
    partial class CreateInstructor
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
            button1 = new Button();
            panel1 = new Panel();
            button4 = new Button();
            special = new TextBox();
            email = new TextBox();
            password = new TextBox();
            instrName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button7 = new Button();
            button3 = new Button();
            button12 = new Button();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            button5 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button6
            // 
            button6.BackColor = Color.Ivory;
            button6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button6.ForeColor = Color.Black;
            button6.Image = Properties.Resources.icons8_pin_pad_64;
            button6.Location = new Point(12, 108);
            button6.Name = "button6";
            button6.Size = new Size(219, 88);
            button6.TabIndex = 49;
            button6.Text = "View Student";
            button6.TextImageRelation = TextImageRelation.ImageBeforeText;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Ivory;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.Image = Properties.Resources.icons8_view_64;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(12, 222);
            button1.Name = "button1";
            button1.Size = new Size(219, 89);
            button1.TabIndex = 46;
            button1.Text = "Create Students";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(special);
            panel1.Controls.Add(email);
            panel1.Controls.Add(password);
            panel1.Controls.Add(instrName);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(256, 108);
            panel1.Name = "panel1";
            panel1.Size = new Size(1114, 441);
            panel1.TabIndex = 45;
            // 
            // button4
            // 
            button4.BackColor = Color.Pink;
            button4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(440, 344);
            button4.Name = "button4";
            button4.Size = new Size(293, 62);
            button4.TabIndex = 8;
            button4.Text = "Create Instructors";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // special
            // 
            special.Location = new Point(462, 139);
            special.Name = "special";
            special.Size = new Size(315, 27);
            special.TabIndex = 7;
            // 
            // email
            // 
            email.Location = new Point(462, 201);
            email.Name = "email";
            email.Size = new Size(315, 27);
            email.TabIndex = 6;
            // 
            // password
            // 
            password.Location = new Point(462, 273);
            password.Name = "password";
            password.Size = new Size(315, 27);
            password.TabIndex = 5;
            // 
            // instrName
            // 
            instrName.Location = new Point(462, 71);
            instrName.Name = "instrName";
            instrName.Size = new Size(315, 27);
            instrName.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(288, 139);
            label4.Name = "label4";
            label4.Size = new Size(164, 31);
            label4.TabIndex = 3;
            label4.Text = "Specialization";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(376, 201);
            label3.Name = "label3";
            label3.Size = new Size(73, 31);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(338, 273);
            label2.Name = "label2";
            label2.Size = new Size(114, 31);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(273, 67);
            label1.Name = "label1";
            label1.Size = new Size(183, 31);
            label1.TabIndex = 0;
            label1.Text = "InstructorName";
            // 
            // button7
            // 
            button7.BackColor = Color.Ivory;
            button7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button7.ForeColor = Color.Black;
            button7.Image = Properties.Resources.icons8_back_64;
            button7.Location = new Point(12, 26);
            button7.Name = "button7";
            button7.Size = new Size(108, 76);
            button7.TabIndex = 51;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Ivory;
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button3.ForeColor = Color.Black;
            button3.Image = Properties.Resources.icons8_event_accepted_tentatively_64;
            button3.Location = new Point(12, 342);
            button3.Name = "button3";
            button3.Size = new Size(226, 88);
            button3.TabIndex = 48;
            button3.Text = "Delete/Update Student";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.Ivory;
            button12.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button12.ForeColor = Color.Black;
            button12.Image = Properties.Resources.icons8_event_accepted_tentatively_64;
            button12.Location = new Point(12, 452);
            button12.Name = "button12";
            button12.Size = new Size(226, 97);
            button12.TabIndex = 55;
            button12.Text = "Profile";
            button12.TextImageRelation = TextImageRelation.ImageBeforeText;
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.Ivory;
            button11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button11.ForeColor = Color.Black;
            button11.Image = Properties.Resources.icons8_training_64;
            button11.Location = new Point(904, 26);
            button11.Name = "button11";
            button11.Size = new Size(314, 76);
            button11.TabIndex = 54;
            button11.Text = "Assign instructor to student";
            button11.TextImageRelation = TextImageRelation.ImageBeforeText;
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.Ivory;
            button10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button10.ForeColor = Color.Black;
            button10.Image = Properties.Resources.icons8_edit_account_64;
            button10.Location = new Point(602, 26);
            button10.Name = "button10";
            button10.Size = new Size(296, 76);
            button10.TabIndex = 53;
            button10.Text = "Delete/Update";
            button10.TextImageRelation = TextImageRelation.ImageBeforeText;
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.Ivory;
            button9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button9.ForeColor = Color.Black;
            button9.Image = Properties.Resources.icons8_training_64;
            button9.Location = new Point(362, 26);
            button9.Name = "button9";
            button9.Size = new Size(230, 76);
            button9.TabIndex = 52;
            button9.Text = "View Instructors";
            button9.TextImageRelation = TextImageRelation.ImageBeforeText;
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
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
            button5.TabIndex = 50;
            button5.Text = "Exit";
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Ivory;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button2.ForeColor = Color.Black;
            button2.Image = Properties.Resources.icons8_create_64;
            button2.Location = new Point(126, 26);
            button2.Name = "button2";
            button2.Size = new Size(230, 76);
            button2.TabIndex = 47;
            button2.Text = "Create Instructors";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // CreateInstructor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(1382, 582);
            Controls.Add(button6);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(button7);
            Controls.Add(button3);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button5);
            Controls.Add(button2);
            Name = "CreateInstructor";
            Text = "CreateInstructor";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button6;
        private Button button1;
        private Panel panel1;
        private Button button4;
        private TextBox special;
        private TextBox email;
        private TextBox password;
        private TextBox instrName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button7;
        private Button button3;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button5;
        private Button button2;
    }
}