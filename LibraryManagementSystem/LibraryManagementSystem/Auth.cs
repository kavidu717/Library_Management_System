using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void Auth_Load(object sender, EventArgs e)
        {

        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
            // visible button
            if (Password.PasswordChar == '*')
            {
                btnNovi2.BringToFront();
                Password.PasswordChar = '\0';
            }
        }

        private void btnNovi2_Click(object sender, EventArgs e)
        {
            // invisible button
            if (Password.PasswordChar == '\0')
            {
                btnNovi.BringToFront();
                Password.PasswordChar = '*';
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // submit button
            if (UserName.Text =="Auth" && Password.Text=="auth123")
            {
                Signup Signup = new Signup();
                Signup.Show();
                this.Hide();
            }
            else
            {
                // if password or username is invalid
                MessageBox.Show("Invalid Username or Password", "Error");
                UserName.Clear();
                Password.Clear();
                UserName.Focus();
            }

        }

        private void btnCncel_Click(object sender, EventArgs e)
        {
            // cancel button
            Application.Exit();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            // clean button
            UserName.Clear();
            Password.Clear();
            UserName.Focus();
        }
    }
}
