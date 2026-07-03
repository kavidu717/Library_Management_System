using Microsoft.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

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
            Auth Auth = new Auth();
            Auth.Show();
            this.Hide();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // create the db connection object
            DBConnection db = new DBConnection();
            SqlConnection con = db.GetConnection();

            string enteredUsername = UserName.Text.Trim();
            string enteredPassword = Password.Text;

            string hashedPassword = HashPassword(enteredPassword);


            string query = "SELECT Role FROM [user] WHERE Username=@username AND Password=@password";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@username", enteredUsername);
                cmd.Parameters.AddWithValue("@password", hashedPassword);

                // use the try catch block to handle exceptions
                try
                {
                    // open the data base connection
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string role = reader["Role"].ToString();
                        if (role == "admin")
                        {
                            Dashboard adminForm = new Dashboard();
                            adminForm.Show();
                            this.Hide();
                        }
                        else if (role == "user")
                        {
                            UserDashboard userForm = new UserDashboard();
                            userForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("unknown role", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {

                        // if username or password incorrect show error message and clear the text boxes
                        MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        UserName.Clear();
                        Password.Clear();
                        UserName.Focus();

                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // close the database connection
                    con.Close();
                }

            }


        }
    


    // password hashing method
        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {

                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();

                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));

                }
                return builder.ToString();

            }
        }


    }
}
