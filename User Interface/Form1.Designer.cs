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
            label1 = new Label();
            comboxRole = new ComboBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnSignIn = new Button();
            btnSignUp = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(290, 63);
            label1.Name = "label1";
            label1.Size = new Size(116, 31);
            label1.TabIndex = 0;
            label1.Text = "Your Role";
            // 
            // comboxRole
            // 
            comboxRole.FormattingEnabled = true;
            comboxRole.Items.AddRange(new object[] { "Admin", "Instructor", "Student" });
            comboxRole.Location = new Point(412, 66);
            comboxRole.Name = "comboxRole";
            comboxRole.Size = new Size(239, 28);
            comboxRole.TabIndex = 1;
            comboxRole.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.DarkOrange;
            btnSignIn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnSignIn.ForeColor = Color.Black;
            btnSignIn.Location = new Point(266, 297);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(156, 48);
            btnSignIn.TabIndex = 2;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.DarkOrange;
            btnSignUp.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnSignUp.ForeColor = Color.Black;
            btnSignUp.Location = new Point(565, 297);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(159, 48);
            btnSignUp.TabIndex = 3;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleGreen;
            panel1.Controls.Add(btnSignUp);
            panel1.Controls.Add(btnSignIn);
            panel1.Controls.Add(comboxRole);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(128, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(949, 409);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
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
        private ComboBox comboxRole;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnSignIn;
        private Button btnSignUp;
        private Panel panel1;
    }
}
