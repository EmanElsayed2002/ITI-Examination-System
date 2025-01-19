using System.Numerics;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Microsoft.VisualBasic.Logging;
namespace User_Interface
{
    public partial class Form1 : Form
    {
        public int ID { get; set; }
        public Form1()
        {
            InitializeComponent();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Pass.PasswordChar = '*';
            //if (cmbRole == null)
            //{
            //    throw new NullReferenceException("comboxRole is not initialized.");
            //}
            comboxRole2.Items.Add("Admin");
            comboxRole2.Items.Add("Instructor");
            comboxRole2.Items.Add("Student");
            comboxRole2.SelectedIndex = -1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearErrorMessages();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ClearErrorMessages()
        {
            labelRole.Text = string.Empty;
            labelEmail.Text = string.Empty;
            labelPassword.Text = string.Empty;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ClearErrorMessages();
            string? selectedItem = comboxRole2.SelectedItem?.ToString();
            string email = Email.Text;
            string password = Pass.Text;
            bool flag = false;
            if (string.IsNullOrEmpty(selectedItem))
            {
                labelRole.Text = "Please Specify your Role.";
                flag = true;
            }
            if (string.IsNullOrEmpty(email))
            {
                labelEmail.Text = "Please enter your Email.";
                flag = true;
                
            }
            else if (!IsValidEmail(email))
            {
                labelEmail.Text = "Please enter a valid email address.";
                flag = true;
            }
            if (string.IsNullOrEmpty(password))
            {
                labelPassword.Text = "Please enter your password";
                flag = true;
            }

            if (flag == false)
            {
                switch (selectedItem)
                {
                    case "Admin":
                        HandleAdminLogin(email, password);
                        break;
                    case "Instructor":
                        HandleInstructorLogin(email, password);
                        break;
                    case "Student":
                        HandleStudentLogin(email, password);
                        break;
                    default:
                        MessageBox.Show("Invalid Role Selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
        }
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }
        public void HandleAdminLogin(string email, string password)
        {

            bool isAdmin = Business_Logic_Layer.EntitiyManager.AdminManager.isAdmin(email, password);
            if (isAdmin)
            {
                ID = Business_Logic_Layer.EntitiyManager.AdminManager.GetId(email, password);
                AdminDashboard adminDas = new AdminDashboard(ID);
                adminDas.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Email or Password is Wrong Check Again!", "ERORR");

        }
        public void HandleInstructorLogin(string email, string password)
        {
            try
            {
                bool isInstructor = Business_Logic_Layer.EntityManager.InstructorManager.isInstructor(email, password);
                if (isInstructor)
                {
                    ID = Business_Logic_Layer.EntityManager.InstructorManager.GetId(email, password);
                    InstructorDashboard InstrutorDas = new InstructorDashboard(ID);
                    InstrutorDas.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Email or Password is Wrong Check Again!", "ERORR");
            }
        }

        public void HandleStudentLogin(string email, string password)
        {
            try
            {
                bool isStudent = Business_Logic_Layer.EntitiyManager.StudentManager.isStudent(email, password);
                if (isStudent)
                {
                    ID = Business_Logic_Layer.EntityManager.StudentExamManager.GetStudentusnigEP(email, password);
                    StudentDashboard StudentDash = new StudentDashboard(ID);
                    StudentDash.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");

                MessageBox.Show("Email or Password is Wrong Check Again!", "ERORR");
            }
        }


    }
}
