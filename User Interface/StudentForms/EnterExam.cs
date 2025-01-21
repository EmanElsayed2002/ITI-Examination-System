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

namespace User_Interface.StudentForms
{
    public partial class EnterExam : Form
    {
        DataTable dt = new DataTable();
        int ID;
        int setlectedItem = -1;
        public EnterExam(int StudentID)
        {
            InitializeComponent();
            ID = StudentID;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EnterExam_Load(object sender, EventArgs e)
        {
               dt = Business_Logic_Layer.EntityManager.StudentExamManager.GetCurrectExamFroStudent(ID);
            currExams.DataSource = dt;
            currExams.DisplayMember = "ExamName";
            currExams.ValueMember = "ExamID";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (setlectedItem != -1)
            {
                MessageBox.Show("The exam is about to begin. Good luck!", "Start Exam", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ExamWindow examForm = new ExamWindow(setlectedItem, ID);
                this.Hide();
                examForm.Show();
            }
            else
            {
                MessageBox.Show("please Select your Exam!", "Select Exam", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void currExams_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (currExams.SelectedItem != null)
                setlectedItem = Convert.ToInt32(currExams.SelectedValue);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            StudentDashboard studentDashboard = new StudentDashboard(ID);
            studentDashboard.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            viewYourExams view = new viewYourExams(ID);
            view.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewYourInstructors view = new ViewYourInstructors(ID);
            view.Show();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            uncommingExams uncommingExams = new uncommingExams(ID);
            uncommingExams.Show();
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EnterExam enterExam = new EnterExam(ID);
            enterExam.Show();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProfileStudent profileStudent = new ProfileStudent(ID);
            profileStudent.Show();
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Close();
        }
    }
}
