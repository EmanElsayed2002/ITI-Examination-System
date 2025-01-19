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
    public partial class ViewYourExams : Form
    {
        public int InstructorID { get; set; }
        public ViewYourExams(int ID)
        {
            InitializeComponent();
            InstructorID = ID;
        }

        //public ViewYourExams(int ID)
        //{
        //    InstructorID = ID;
        //}



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ViewYourExams_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = Business_Logic_Layer.EntityManager.InstructorManager.viewAllExamCreatedByExam(InstructorID);
            dataGridViewExams.DataSource = dt;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            InstructorDashboard instructorDashboard = new InstructorDashboard(InstructorID);
            instructorDashboard.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ViewYourExams viewExams = new ViewYourExams(InstructorID);
            viewExams.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ViewYourStudent viewstudent = new ViewYourStudent(InstructorID);
            viewstudent.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            CreateExam createExam = new CreateExam(InstructorID);
            createExam.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            UpdateDeleteExam updateDeleteExam = new UpdateDeleteExam(InstructorID);
            updateDeleteExam.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(InstructorID);
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
                frm.Hide();
            }
            else
            {
                InstructorDashboard instructorDashboard = new InstructorDashboard(InstructorID);
                instructorDashboard.Show();
                this.Hide();
            }
        }
    }
}
