namespace User_Interface
{
    partial class Profile
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
            panel1 = new Panel();
            button5 = new Button();
            email = new TextBox();
            password = new TextBox();
            specification = new TextBox();
            instrName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
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
            // button6
            // 
            button6.BackColor = Color.PaleGreen;
            button6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button6.ForeColor = Color.Black;
            button6.Location = new Point(31, 328);
            button6.Name = "button6";
            button6.Size = new Size(0, 0);
            button6.TabIndex = 12;
            button6.Text = "Update/Delete Exams";
            button6.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(email);
            panel1.Controls.Add(password);
            panel1.Controls.Add(specification);
            panel1.Controls.Add(instrName);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 110);
            panel1.Name = "panel1";
            panel1.Size = new Size(1358, 553);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // button5
            // 
            button5.BackColor = Color.LightSeaGreen;
            button5.Font = new Font("Tahoma", 16.2F, FontStyle.Bold);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(618, 415);
            button5.Name = "button5";
            button5.Size = new Size(181, 53);
            button5.TabIndex = 9;
            button5.Text = "Update";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // email
            // 
            email.Font = new Font("Tahoma", 13.8F, FontStyle.Bold);
            email.Location = new Point(514, 344);
            email.Name = "email";
            email.Size = new Size(478, 35);
            email.TabIndex = 8;
            // 
            // password
            // 
            password.Font = new Font("Tahoma", 13.8F, FontStyle.Bold);
            password.Location = new Point(555, 292);
            password.Name = "password";
            password.Size = new Size(435, 35);
            password.TabIndex = 7;
            // 
            // specification
            // 
            specification.Font = new Font("Tahoma", 13.8F, FontStyle.Bold);
            specification.Location = new Point(618, 235);
            specification.Name = "specification";
            specification.Size = new Size(374, 35);
            specification.TabIndex = 6;
            // 
            // instrName
            // 
            instrName.Font = new Font("Tahoma", 13.8F, FontStyle.Bold);
            instrName.Location = new Point(652, 176);
            instrName.Name = "instrName";
            instrName.Size = new Size(340, 35);
            instrName.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 16.2F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(376, 293);
            label5.Name = "label5";
            label5.Size = new Size(150, 34);
            label5.TabIndex = 4;
            label5.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 16.2F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(376, 345);
            label4.Name = "label4";
            label4.Size = new Size(92, 34);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 16.2F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(376, 236);
            label3.Name = "label3";
            label3.Size = new Size(211, 34);
            label3.TabIndex = 2;
            label3.Text = "Specialization";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 16.2F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(376, 175);
            label2.Name = "label2";
            label2.Size = new Size(250, 34);
            label2.TabIndex = 1;
            label2.Text = "Instructor Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(508, 71);
            label1.Name = "label1";
            label1.Size = new Size(360, 34);
            label1.TabIndex = 0;
            label1.Text = "Welcome To Your Profile";
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Control;
            button4.Enabled = false;
            button4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(31, 425);
            button4.Name = "button4";
            button4.Size = new Size(0, 0);
            button4.TabIndex = 11;
            button4.Text = "Profile";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.PaleGreen;
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(31, 230);
            button3.Name = "button3";
            button3.Size = new Size(0, 0);
            button3.TabIndex = 10;
            button3.Text = "Create Exam";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.PaleGreen;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(76, 286);
            button2.Name = "button2";
            button2.Size = new Size(0, 0);
            button2.TabIndex = 9;
            button2.Text = "View Your Student";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.PaleGreen;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(76, 192);
            button1.Name = "button1";
            button1.Size = new Size(0, 0);
            button1.TabIndex = 8;
            button1.Text = "View Your Exams";
            button1.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.LightSeaGreen;
            button8.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            button8.ForeColor = SystemColors.ButtonHighlight;
            button8.Image = Properties.Resources.icons8_back_64;
            button8.Location = new Point(12, 12);
            button8.Name = "button8";
            button8.Size = new Size(108, 76);
            button8.TabIndex = 88;
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
            button9.TabIndex = 87;
            button9.Text = "Exit";
            button9.TextImageRelation = TextImageRelation.ImageBeforeText;
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.LightSeaGreen;
            button10.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            button10.ForeColor = SystemColors.ButtonHighlight;
            button10.Image = Properties.Resources.icons8_update_64;
            button10.Location = new Point(765, 12);
            button10.Name = "button10";
            button10.Size = new Size(259, 76);
            button10.TabIndex = 86;
            button10.Text = "Update/Delete Exams";
            button10.TextImageRelation = TextImageRelation.ImageBeforeText;
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.LightSeaGreen;
            button11.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            button11.ForeColor = SystemColors.ButtonHighlight;
            button11.Image = Properties.Resources.icons8_edit_account_64;
            button11.Location = new Point(1030, 12);
            button11.Name = "button11";
            button11.Size = new Size(187, 76);
            button11.TabIndex = 85;
            button11.Text = "Profile";
            button11.TextImageRelation = TextImageRelation.ImageBeforeText;
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.LightSeaGreen;
            button12.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            button12.ForeColor = SystemColors.ButtonHighlight;
            button12.Image = Properties.Resources.icons8_create_64;
            button12.Location = new Point(572, 12);
            button12.Name = "button12";
            button12.Size = new Size(187, 76);
            button12.TabIndex = 84;
            button12.Text = "Create Exam";
            button12.TextImageRelation = TextImageRelation.ImageBeforeText;
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.LightSeaGreen;
            button13.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            button13.ForeColor = SystemColors.ButtonHighlight;
            button13.Image = Properties.Resources.icons8_person_student_48;
            button13.Location = new Point(351, 12);
            button13.Name = "button13";
            button13.Size = new Size(215, 76);
            button13.TabIndex = 83;
            button13.Text = "View Your Student";
            button13.TextImageRelation = TextImageRelation.ImageBeforeText;
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.BackColor = Color.LightSeaGreen;
            button14.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            button14.ForeColor = SystemColors.ButtonHighlight;
            button14.Image = Properties.Resources.icons8_view_64;
            button14.ImageAlign = ContentAlignment.MiddleLeft;
            button14.Location = new Point(126, 12);
            button14.Name = "button14";
            button14.Size = new Size(219, 76);
            button14.TabIndex = 82;
            button14.Text = "View Your Exams";
            button14.TextImageRelation = TextImageRelation.ImageBeforeText;
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1382, 672);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(button13);
            Controls.Add(button14);
            Controls.Add(button6);
            Controls.Add(panel1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Profile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profile";
            Load += Profile_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button6;
        private Panel panel1;
        private Label label1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox email;
        private TextBox password;
        private TextBox specification;
        private TextBox instrName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button5;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
    }
}