namespace User_Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string selectedItem = comboxRole.SelectedItem.ToString();
            if (selectedItem == "Admin")
            {
                AdminSignIn adminSignInform = new AdminSignIn();
                adminSignInform.Show();
                this.Hide();

            }
            else if (selectedItem == "Instructor")
            {

            }
            else
            {

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
