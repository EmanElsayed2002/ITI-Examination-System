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
            comboxRole2 = new ComboBox();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1 = new Panel();
            labelEmail = new Label();
            labelPassword = new Label();
            labelRole = new Label();
            btnSignIn = new Button();
            label2 = new Label();
            Pass = new TextBox();
            Email = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // comboxRole2
            // 
            comboxRole2.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboxRole2.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboxRole2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboxRole2.FormattingEnabled = true;
            comboxRole2.Location = new Point(361, 47);
            comboxRole2.Name = "comboxRole2";
            comboxRole2.Size = new Size(336, 28);
            comboxRole2.TabIndex = 1;
            comboxRole2.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(227, 44);
            label1.Name = "label1";
            label1.Size = new Size(116, 31);
            label1.TabIndex = 0;
            label1.Text = "Your Role";
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleGreen;
            panel1.Controls.Add(labelEmail);
            panel1.Controls.Add(labelPassword);
            panel1.Controls.Add(labelRole);
            panel1.Controls.Add(btnSignIn);
            panel1.Controls.Add(comboxRole2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Pass);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Email);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(128, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(949, 409);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            labelEmail.ForeColor = Color.Red;
            labelEmail.Location = new Point(378, 147);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(0, 23);
            labelEmail.TabIndex = 7;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPassword.ForeColor = Color.Red;
            labelPassword.Location = new Point(378, 221);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(0, 23);
            labelPassword.TabIndex = 6;
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            labelRole.ForeColor = Color.Red;
            labelRole.Location = new Point(378, 75);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(0, 23);
            labelRole.TabIndex = 5;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.DarkOrange;
            btnSignIn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignIn.Location = new Point(391, 306);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(229, 59);
            btnSignIn.TabIndex = 4;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.Location = new Point(227, 191);
            label2.Name = "label2";
            label2.Size = new Size(114, 31);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // Pass
            // 
            Pass.Location = new Point(361, 191);
            Pass.Name = "Pass";
            Pass.Size = new Size(336, 27);
            Pass.TabIndex = 3;
            // 
            // Email
            // 
            Email.Location = new Point(358, 117);
            Email.Name = "Email";
            Email.Size = new Size(337, 27);
            Email.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label3.Location = new Point(243, 117);
            label3.Name = "label3";
            label3.Size = new Size(73, 31);
            label3.TabIndex = 0;
            label3.Text = "Email";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(1182, 543);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ComboBox comboxRole2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel1;
        private Button btnSignIn;
        private Label label2;
        private TextBox Pass;
        private TextBox Email;
        private Label label3;
        private Label labelEmail;
        private Label labelPassword;
        private Label labelRole;
    }
}
