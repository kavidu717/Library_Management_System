namespace LibraryManagementSystem
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lblTitle = new Label();
            panel5 = new Panel();
            label2 = new Label();
            btnDashboard = new Button();
            btnLoan = new Button();
            btnReturn = new Button();
            btnInquiry = new Button();
            btnReservation = new Button();
            btnBookReg = new Button();
            btnMemberReg = new Button();
            btnLogOut = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(39, 210, 230);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(282, 212);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(39, 210, 230);
            panel2.Controls.Add(btnLogOut);
            panel2.Controls.Add(btnMemberReg);
            panel2.Controls.Add(btnBookReg);
            panel2.Controls.Add(btnReservation);
            panel2.Controls.Add(btnInquiry);
            panel2.Controls.Add(btnReturn);
            panel2.Controls.Add(btnLoan);
            panel2.Controls.Add(btnDashboard);
            panel2.Location = new Point(12, 230);
            panel2.Name = "panel2";
            panel2.Size = new Size(282, 465);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(39, 210, 230);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(lblTitle);
            panel3.Location = new Point(300, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(846, 86);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(39, 210, 230);
            panel4.Location = new Point(300, 104);
            panel4.Name = "panel4";
            panel4.Size = new Size(846, 591);
            panel4.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(74, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 155);
            label1.Name = "label1";
            label1.Size = new Size(267, 25);
            label1.TabIndex = 1;
            label1.Text = "Library Management System";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(10, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(265, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Admin Dashboard";
            // 
            // panel5
            // 
            panel5.Controls.Add(label2);
            panel5.Location = new Point(478, 26);
            panel5.Name = "panel5";
            panel5.Size = new Size(354, 38);
            panel5.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(2, 4);
            label2.Name = "label2";
            label2.Size = new Size(115, 25);
            label2.TabIndex = 0;
            label2.Text = "Search For...";
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(77, 230, 39);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.Location = new Point(10, 16);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(267, 41);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnLoan
            // 
            btnLoan.BackColor = Color.FromArgb(77, 230, 39);
            btnLoan.FlatAppearance.BorderSize = 0;
            btnLoan.FlatStyle = FlatStyle.Flat;
            btnLoan.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoan.Location = new Point(10, 67);
            btnLoan.Name = "btnLoan";
            btnLoan.Size = new Size(267, 41);
            btnLoan.TabIndex = 1;
            btnLoan.Text = "Loan Book";
            btnLoan.UseVisualStyleBackColor = false;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.FromArgb(77, 230, 39);
            btnReturn.FlatAppearance.BorderSize = 0;
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReturn.Location = new Point(8, 116);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(267, 41);
            btnReturn.TabIndex = 2;
            btnReturn.Text = "Return Book";
            btnReturn.UseVisualStyleBackColor = false;
            // 
            // btnInquiry
            // 
            btnInquiry.BackColor = Color.FromArgb(77, 230, 39);
            btnInquiry.FlatAppearance.BorderSize = 0;
            btnInquiry.FlatStyle = FlatStyle.Flat;
            btnInquiry.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInquiry.Location = new Point(8, 164);
            btnInquiry.Name = "btnInquiry";
            btnInquiry.Size = new Size(267, 43);
            btnInquiry.TabIndex = 3;
            btnInquiry.Text = "Inquiry Book";
            btnInquiry.UseVisualStyleBackColor = false;
            // 
            // btnReservation
            // 
            btnReservation.BackColor = Color.FromArgb(77, 230, 39);
            btnReservation.FlatAppearance.BorderSize = 0;
            btnReservation.FlatStyle = FlatStyle.Flat;
            btnReservation.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReservation.Location = new Point(8, 214);
            btnReservation.Name = "btnReservation";
            btnReservation.Size = new Size(267, 42);
            btnReservation.TabIndex = 4;
            btnReservation.Text = "Reservation Book";
            btnReservation.UseVisualStyleBackColor = false;
            // 
            // btnBookReg
            // 
            btnBookReg.BackColor = Color.FromArgb(77, 230, 39);
            btnBookReg.FlatAppearance.BorderSize = 0;
            btnBookReg.FlatStyle = FlatStyle.Flat;
            btnBookReg.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBookReg.Location = new Point(8, 265);
            btnBookReg.Name = "btnBookReg";
            btnBookReg.Size = new Size(267, 39);
            btnBookReg.TabIndex = 5;
            btnBookReg.Text = "Book Registration";
            btnBookReg.UseVisualStyleBackColor = false;
            // 
            // btnMemberReg
            // 
            btnMemberReg.BackColor = Color.FromArgb(77, 230, 39);
            btnMemberReg.FlatAppearance.BorderSize = 0;
            btnMemberReg.FlatStyle = FlatStyle.Flat;
            btnMemberReg.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMemberReg.Location = new Point(8, 317);
            btnMemberReg.Name = "btnMemberReg";
            btnMemberReg.Size = new Size(267, 40);
            btnMemberReg.TabIndex = 6;
            btnMemberReg.Text = "Member Registration";
            btnMemberReg.UseVisualStyleBackColor = false;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Red;
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogOut.Location = new Point(8, 415);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(267, 40);
            btnLogOut.TabIndex = 7;
            btnLogOut.Text = "Logout";
            btnLogOut.UseVisualStyleBackColor = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(77, 230, 39);
            ClientSize = new Size(1158, 707);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pictureBox1;
        private Label label1;
        private Label lblTitle;
        private Panel panel5;
        private Label label2;
        private Button btnMemberReg;
        private Button btnBookReg;
        private Button btnReservation;
        private Button btnInquiry;
        private Button btnReturn;
        private Button btnLoan;
        private Button btnDashboard;
        private Button btnLogOut;
    }
}