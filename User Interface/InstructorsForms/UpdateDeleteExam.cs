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
    public partial class UpdateDeleteExam : Form
    {
        int ID;
        DataTable dt = new DataTable();
        public Exam exam { get; set; } = new Exam();
        public UpdateDeleteExam(int instructorID)
        {
            InitializeComponent();
            ID = instructorID;
            if(comboBoxExam.SelectedItem != null)
            exam.ExamID = Convert.ToInt32(comboBoxExam.SelectedValue);
        }


        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Business_Logic_Layer.EntityManager.ExamManager.SyncData(dt, exam.ExamID);
                MessageBox.Show("Sync Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("ERRORRR", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void UpdateDeleteExam_Load(object sender, EventArgs e)
        {

            dt = Business_Logic_Layer.EntityManager.ExamManager.selectAllExamsRelatedToInstructor(ID);

            if (dt != null && dt.Rows.Count > 0)
            {
                comboBoxExam.DataSource = dt;
                comboBoxExam.DisplayMember = "ExamName";
                comboBoxExam.ValueMember = "ExamID";
            }
            else
            {
                comboBoxExam.DataSource = null;
                MessageBox.Show("you have not Exams yet", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboBoxQuestionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxExam.SelectedValue != null && comboBoxExam.SelectedValue is int selectedId)
            {
                dt = Business_Logic_Layer.EntityManager.QuestionManager.GetAllQuestions(selectedId);
                dataGridView1.DataSource = dt;
                //UpdateDeleteExam_Load(sender , e);
                exam.ExamID = selectedId;
                //label1.Text = $"{comboBoxExam.SelectedValue}";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            InstructorDashboard instructorDashboard = new InstructorDashboard(ID);
            instructorDashboard.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ViewYourExams viewExams = new ViewYourExams(ID);
            viewExams.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ViewYourStudent viewstudent = new ViewYourStudent(ID);
            viewstudent.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            CreateExam createExam = new CreateExam(ID);
            createExam.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            UpdateDeleteExam updateDeleteExam = new UpdateDeleteExam(ID);
            updateDeleteExam.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(ID);
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
                InstructorDashboard instructorDashboard = new InstructorDashboard(ID);
                instructorDashboard.Show();
                this.Hide();
            }
        }
    }
}
