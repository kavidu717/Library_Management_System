using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
