namespace User_Interface
{
    partial class AdminSignIn
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
            label1 = new Label();
            label2 = new Label();
            adminEmail = new TextBox();
            AdminPass = new TextBox();
            btnSignIn = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label1.Location = new Point(76, 49);
            label1.Name = "label1";
            label1.Size = new Size(73, 31);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.Location = new Point(62, 148);
            label2.Name = "label2";
            label2.Size = new Size(114, 31);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // adminEmail
            // 
            adminEmail.Location = new Point(188, 49);
            adminEmail.Name = "adminEmail";
            adminEmail.Size = new Size(337, 27);
            adminEmail.TabIndex = 2;
            // 
            // AdminPass
            // 
            AdminPass.Location = new Point(189, 147);
            AdminPass.Name = "AdminPass";
            AdminPass.Size = new Size(336, 27);
            AdminPass.TabIndex = 3;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.DarkOrange;
            btnSignIn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignIn.Location = new Point(215, 248);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(229, 59);
            btnSignIn.TabIndex = 4;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleGreen;
            panel1.Controls.Add(btnSignIn);
            panel1.Controls.Add(AdminPass);
            panel1.Controls.Add(adminEmail);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(317, 99);
            panel1.Name = "panel1";
            panel1.Size = new Size(618, 359);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // AdminSignIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(1182, 543);
            Controls.Add(panel1);
            Name = "AdminSignIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminSignIn";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox adminEmail;
        private TextBox AdminPass;
        private Button btnSignIn;
        private Panel panel1;
    }
}