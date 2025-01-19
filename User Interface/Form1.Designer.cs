namespace User_Interface
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label3 = new Label();
            Email = new TextBox();
            label1 = new Label();
            Pass = new TextBox();
            label2 = new Label();
            comboxRole2 = new ComboBox();
            btnSignIn = new Button();
            labelRole = new Label();
            labelPassword = new Label();
            labelEmail = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label3.Location = new Point(391, 449);
            label3.Name = "label3";
            label3.Size = new Size(73, 31);
            label3.TabIndex = 0;
            label3.Text = "Email";
            // 
            // Email
            // 
            Email.Location = new Point(506, 449);
            Email.Name = "Email";
            Email.Size = new Size(337, 27);
            Email.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(375, 376);
            label1.Name = "label1";
            label1.Size = new Size(116, 31);
            label1.TabIndex = 0;
            label1.Text = "Your Role";
            // 
            // Pass
            // 
            Pass.Location = new Point(509, 523);
            Pass.Name = "Pass";
            Pass.Size = new Size(336, 27);
            Pass.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.Location = new Point(375, 523);
            label2.Name = "label2";
            label2.Size = new Size(114, 31);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // comboxRole2
            // 
            comboxRole2.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboxRole2.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboxRole2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboxRole2.FormattingEnabled = true;
            comboxRole2.Location = new Point(509, 379);
            comboxRole2.Name = "comboxRole2";
            comboxRole2.Size = new Size(336, 28);
            comboxRole2.TabIndex = 1;
            comboxRole2.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.DarkSlateGray;
            btnSignIn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignIn.ForeColor = SystemColors.ButtonHighlight;
            btnSignIn.Location = new Point(539, 622);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(229, 75);
            btnSignIn.TabIndex = 4;
            btnSignIn.Text = "Login";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += button1_Click;
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            labelRole.ForeColor = Color.Red;
            labelRole.Location = new Point(526, 407);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(0, 23);
            labelRole.TabIndex = 5;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPassword.ForeColor = Color.Red;
            labelPassword.Location = new Point(526, 553);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(0, 23);
            labelPassword.TabIndex = 6;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            labelEmail.ForeColor = Color.Red;
            labelEmail.Location = new Point(526, 479);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(0, 23);
            labelEmail.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.th__1_;
            pictureBox1.Location = new Point(522, 95);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(272, 223);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(1382, 753);
            Controls.Add(labelEmail);
            Controls.Add(pictureBox1);
            Controls.Add(labelPassword);
            Controls.Add(labelRole);
            Controls.Add(label1);
            Controls.Add(btnSignIn);
            Controls.Add(label3);
            Controls.Add(comboxRole2);
            Controls.Add(Email);
            Controls.Add(label2);
            Controls.Add(Pass);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label3;
        private TextBox Email;
        private Label label1;
        private TextBox Pass;
        private Label label2;
        private ComboBox comboxRole2;
        private Button btnSignIn;
        private Label labelRole;
        private Label labelPassword;
        private Label labelEmail;
        private PictureBox pictureBox1;
    }
}
