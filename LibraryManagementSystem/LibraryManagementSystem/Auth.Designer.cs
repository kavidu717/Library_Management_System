namespace LibraryManagementSystem
{
    partial class Auth
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auth));
            panel1 = new Panel();
            btnBack = new Button();
            btnCncel = new Button();
            btnSubmit = new Button();
            btnclear = new Button();
            btnNovi2 = new Button();
            btnNovi = new Button();
            label4 = new Label();
            label3 = new Label();
            Password = new TextBox();
            UserName = new TextBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(71, 183, 165);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(btnCncel);
            panel1.Controls.Add(btnSubmit);
            panel1.Controls.Add(btnclear);
            panel1.Controls.Add(btnNovi2);
            panel1.Controls.Add(btnNovi);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(Password);
            panel1.Controls.Add(UserName);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(452, 604);
            panel1.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.Location = new Point(18, 20);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(45, 44);
            btnBack.TabIndex = 23;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnCncel
            // 
            btnCncel.BackColor = Color.FromArgb(50, 128, 223);
            btnCncel.FlatAppearance.BorderSize = 0;
            btnCncel.FlatStyle = FlatStyle.Flat;
            btnCncel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCncel.Location = new Point(65, 452);
            btnCncel.Name = "btnCncel";
            btnCncel.Size = new Size(315, 37);
            btnCncel.TabIndex = 22;
            btnCncel.Text = "Cancel";
            btnCncel.UseVisualStyleBackColor = false;
            btnCncel.Click += btnCncel_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(50, 128, 223);
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(65, 387);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(315, 37);
            btnSubmit.TabIndex = 21;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnclear
            // 
            btnclear.BackgroundImage = (Image)resources.GetObject("btnclear.BackgroundImage");
            btnclear.Location = new Point(392, 346);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(34, 37);
            btnclear.TabIndex = 20;
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // btnNovi2
            // 
            btnNovi2.BackgroundImage = (Image)resources.GetObject("btnNovi2.BackgroundImage");
            btnNovi2.Location = new Point(394, 307);
            btnNovi2.Name = "btnNovi2";
            btnNovi2.Size = new Size(29, 33);
            btnNovi2.TabIndex = 19;
            btnNovi2.UseVisualStyleBackColor = true;
            btnNovi2.Click += btnNovi2_Click;
            // 
            // btnNovi
            // 
            btnNovi.BackgroundImage = (Image)resources.GetObject("btnNovi.BackgroundImage");
            btnNovi.Location = new Point(362, 307);
            btnNovi.Name = "btnNovi";
            btnNovi.Size = new Size(29, 33);
            btnNovi.TabIndex = 18;
            btnNovi.UseVisualStyleBackColor = true;
            btnNovi.Click += btnNovi_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 280);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 17;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 208);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 16;
            label3.Text = "User Name";
            // 
            // Password
            // 
            Password.Location = new Point(23, 303);
            Password.Multiline = true;
            Password.Name = "Password";
            Password.PasswordChar = '*';
            Password.Size = new Size(402, 37);
            Password.TabIndex = 15;
            // 
            // UserName
            // 
            UserName.Location = new Point(25, 234);
            UserName.Multiline = true;
            UserName.Name = "UserName";
            UserName.Size = new Size(402, 37);
            UserName.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(138, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(169, 142);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Auth
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(199, 239, 207);
            ClientSize = new Size(482, 660);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Auth";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Auth";
            Load += Auth_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnclear;
        private Button btnNovi2;
        private Button btnNovi;
        private Label label4;
        private Label label3;
        private TextBox Password;
        private TextBox UserName;
        private Button btnCncel;
        private Button btnSubmit;
        private Button btnBack;
    }
}