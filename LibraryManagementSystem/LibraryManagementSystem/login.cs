namespace LibraryManagementSystem
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnNovi2_Click(object sender, EventArgs e)
        {
            if (Password.PasswordChar == '\0')
            {
                btnNovi.BringToFront();
                Password.PasswordChar = '*';
            }
        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
            if (Password.PasswordChar == '*')
            {
                btnNovi2.BringToFront();
                Password.PasswordChar = '\0';
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            UserName.Clear();
            Password.Clear();
            UserName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            // Open the signup form
            Auth Auth=new Auth();
            Auth.Show();
            this.Hide();

        }
    }
}
