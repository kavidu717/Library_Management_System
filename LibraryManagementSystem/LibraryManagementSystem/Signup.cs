using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography;

namespace LibraryManagementSystem
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // submit button
            string username = txtUsername.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string role = cmbRole.SelectedItem.ToString();


              // check all fields are filled
            if( string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // hash the password
            string hashedPassword = HashPassword(password);

            DBConnection dbConnection = new DBConnection();

            string query = "INSERT INTO [user] (Username, Email, Password, Role) VALUES (@Username, @Email, @Password, @Role)";

            try
            {
                using (SqlConnection connection = dbConnection.GetConnection())

                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username",username);
                        command.Parameters.AddWithValue("@Email",email);
                        command.Parameters.AddWithValue("@Password",hashedPassword);
                        command.Parameters.AddWithValue("@Role",role);

                        connection.Open();
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("user registered successfully", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clearform();


                        }

                        else
                        {
                            MessageBox.Show("user registration failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }



                    }


                }

            }
            catch(SqlException ex)
            {
              if(ex.Number == 2627) // Unique constraint error
                {
                    MessageBox.Show("Username or Email already exists. Please choose a different one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("An error occurred while registering the user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


  
            }
            catch (Exception ex)
            {
            MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }
        // password hashing method
        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
              
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();

                for (int i=0; i<bytes.Length;i++)
                {
                 builder.Append(bytes[i].ToString("x2"));

                }
                return builder.ToString();

            }
        }

        private void Clearform()
        { 
            txtUsername.Clear();
            txtPassword.Clear();
            txtEmail.Clear();
            cmbRole.SelectedIndex = -1;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // back button
            this.Close();
            login back= new login();
            back.Show();

        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
            // visible button
            if (txtPassword.PasswordChar == '*')
            {
                btnNovi2.BringToFront();
                txtPassword.PasswordChar = '\0';
            }

        }

        private void btnNovi2_Click(object sender, EventArgs e)
        {
            // invisible button
            if (txtPassword.PasswordChar == '\0')
            {
                btnNovi.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            // clear button

            txtUsername.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            cmbRole.SelectedIndex = -1;
            txtUsername.Focus();

        }
    }
}
