namespace User_Interface.AdminForms
{
    partial class AdminViewInstructors
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
            viewInstructors = new DataGridView();
            button7 = new Button();
            button3 = new Button();
            button12 = new Button();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            button5 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewInstructors).BeginInit();
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
            panel1.Controls.Add(viewInstructors);
            panel1.Location = new Point(256, 108);
            panel1.Name = "panel1";
            panel1.Size = new Size(1114, 441);
            panel1.TabIndex = 45;
            // 
            // viewInstructors
            // 
            viewInstructors.AllowUserToAddRows = false;
            viewInstructors.AllowUserToDeleteRows = false;
            viewInstructors.AllowUserToResizeColumns = false;
            viewInstructors.AllowUserToResizeRows = false;
            viewInstructors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            viewInstructors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewInstructors.Location = new Point(26, 22);
            viewInstructors.Name = "viewInstructors";
            viewInstructors.RowHeadersWidth = 51;
            viewInstructors.Size = new Size(1065, 393);
            viewInstructors.TabIndex = 0;
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
            button10.Text = "Delete/Update Instructors";
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
            // AdminViewInstructors
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(1382, 561);
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
            Name = "AdminViewInstructors";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminViewInstructors";
            Load += AdminViewInstructors_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)viewInstructors).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button6;
        private Button button1;
        private Panel panel1;
        private DataGridView viewInstructors;
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