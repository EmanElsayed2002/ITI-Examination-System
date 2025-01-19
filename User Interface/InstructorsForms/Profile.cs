using Business_Logic_Layer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Interface
{

    public partial class Profile : Form
    {
        public Instructor InstructorDetails { get; set; } = new Instructor();
        public Profile(int InstructorID)
        {
            InitializeComponent();

            InstructorDetails.InstructorID = InstructorID;
            password.PasswordChar = '*';
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Profile_Load(object sender, EventArgs e)
        {
            try
            {
                InstructorDetails = Business_Logic_Layer.EntityManager.InstructorManager.GetInstructor(InstructorDetails.InstructorID);

                if (InstructorDetails != null)
                {
                    instrName.Text = InstructorDetails.InstructorName;
                    specification.Text = InstructorDetails.Specialization;
                    password.Text = InstructorDetails.Password;
                    email.Text = InstructorDetails.Email;
                }
                else
                {
                    MessageBox.Show("Failed to load instructor details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //InstructorDetails = Business_Logic_Layer.EntityManager.InstructorManager.GetInstructor(InstructorDetails.InstructorID);
            //instrName.Text = InstructorDetails.InstructorName;
            //specification.Text = InstructorDetails.Specialization;
            //password.Text = InstructorDetails.Password;
            //email.Text = InstructorDetails.Email;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(instrName.Text.Trim()) ||
                string.IsNullOrEmpty(specification.Text.Trim()) ||
                string.IsNullOrEmpty(email.Text.Trim()) ||
                string.IsNullOrEmpty(password.Text.Trim()))
            {
                MessageBox.Show("Please Fill all Fields", "error", MessageBoxButtons.OK);
            }
            else
            {
                InstructorDetails.InstructorName = instrName.Text;
                InstructorDetails.Email = email.Text;
                InstructorDetails.Specialization = specification.Text;
                InstructorDetails.Password = password.Text;
                int rowsAffected = Business_Logic_Layer.EntitiyManager.AdminManager.UpdateInstructor(InstructorDetails);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Your profile is Updated", "Confirm", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Error Try Again Later!!", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            InstructorDashboard instructorDashboard = new InstructorDashboard(InstructorDetails.InstructorID);
            instructorDashboard.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ViewYourExams viewExams = new ViewYourExams(InstructorDetails.InstructorID);
            viewExams.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ViewYourStudent viewstudent = new ViewYourStudent(InstructorDetails.InstructorID);
            viewstudent.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            CreateExam createExam = new CreateExam(InstructorDetails.InstructorID);
            createExam.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            UpdateDeleteExam updateDeleteExam = new UpdateDeleteExam(InstructorDetails.InstructorID);
            updateDeleteExam.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(InstructorDetails.InstructorID);
            profile.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("would you like to Logout?", "confirm", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
            else
            {
                InstructorDashboard instructorDashboard = new InstructorDashboard(InstructorDetails.InstructorID);
                instructorDashboard.Show();
                this.Hide();
            }
        }
    }
}
