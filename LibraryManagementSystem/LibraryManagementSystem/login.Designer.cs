namespace LibraryManagementSystem
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            panel1 = new Panel();
            btnclear = new Button();
            btnNovi2 = new Button();
            btnNovi = new Button();
            label5 = new Label();
            btnExit = new Button();
            btnSignup = new Button();
            btnLogin = new Button();
            label4 = new Label();
            label3 = new Label();
            Password = new TextBox();
            UserName = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(71, 183, 165);
            panel1.Controls.Add(btnclear);
            panel1.Controls.Add(btnNovi2);
            panel1.Controls.Add(btnNovi);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnSignup);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(Password);
            panel1.Controls.Add(UserName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(23, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(539, 722);
            panel1.TabIndex = 0;
            // 
            // btnclear
            // 
            btnclear.BackgroundImage = (Image)resources.GetObject("btnclear.BackgroundImage");
            btnclear.Location = new Point(433, 502);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(34, 37);
            btnclear.TabIndex = 13;
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // btnNovi2
            // 
            btnNovi2.BackgroundImage = (Image)resources.GetObject("btnNovi2.BackgroundImage");
            btnNovi2.Location = new Point(437, 465);
            btnNovi2.Name = "btnNovi2";
            btnNovi2.Size = new Size(29, 33);
            btnNovi2.TabIndex = 12;
            btnNovi2.UseVisualStyleBackColor = true;
            btnNovi2.Click += btnNovi2_Click;
            // 
            // btnNovi
            // 
            btnNovi.BackgroundImage = (Image)resources.GetObject("btnNovi.BackgroundImage");
            btnNovi.Location = new Point(401, 465);
            btnNovi.Name = "btnNovi";
            btnNovi.Size = new Size(29, 33);
            btnNovi.TabIndex = 11;
            btnNovi.UseVisualStyleBackColor = true;
            btnNovi.Click += btnNovi_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(128, 673);
            label5.Name = "label5";
            label5.Size = new Size(275, 30);
            label5.TabIndex = 10;
            label5.Text = "Library Managemet System";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(50, 128, 223);
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(347, 540);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(110, 37);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnSignup
            // 
            btnSignup.BackColor = Color.FromArgb(50, 128, 223);
            btnSignup.FlatAppearance.BorderSize = 0;
            btnSignup.FlatStyle = FlatStyle.Flat;
            btnSignup.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignup.Location = new Point(206, 540);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(110, 37);
            btnSignup.TabIndex = 8;
            btnSignup.Text = "Sign Up";
            btnSignup.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(50, 128, 223);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(65, 540);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(110, 37);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(61, 438);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 6;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(62, 366);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 5;
            label3.Text = "User Name";
            // 
            // Password
            // 
            Password.Location = new Point(62, 461);
            Password.Multiline = true;
            Password.Name = "Password";
            Password.PasswordChar = '*';
            Password.Size = new Size(402, 37);
            Password.TabIndex = 4;
            // 
            // UserName
            // 
            UserName.Location = new Point(62, 392);
            UserName.Multiline = true;
            UserName.Name = "UserName";
            UserName.Size = new Size(402, 37);
            UserName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(111, 283);
            label2.Name = "label2";
            label2.Size = new Size(280, 30);
            label2.TabIndex = 2;
            label2.Text = "Library Managemet System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(164, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(165, 163);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(171, 33);
            label1.Name = "label1";
            label1.Size = new Size(150, 64);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(199, 239, 207);
            ClientSize = new Size(588, 780);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox UserName;
        private TextBox Password;
        private Label label4;
        private Label label3;
        private Button btnExit;
        private Button btnSignup;
        private Button btnLogin;
        private Label label5;
        private Button btnNovi;
        private Button btnNovi2;
        private Button btnclear;
    }
}
