namespace Clinc_Management_System
{
    partial class frmLogin
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            tbUser = new TextBox();
            tbPassword = new TextBox();
            label2 = new Label();
            label4 = new Label();
            btnLogin = new Button();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(102, 163, 191);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(289, 383);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 164);
            label1.Name = "label1";
            label1.Size = new Size(283, 101);
            label1.TabIndex = 0;
            label1.Text = "Login";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbUser
            // 
            tbUser.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            tbUser.Location = new Point(416, 164);
            tbUser.MaxLength = 10;
            tbUser.Name = "tbUser";
            tbUser.Size = new Size(255, 28);
            tbUser.TabIndex = 0;
            tbUser.Tag = " UserName";
            tbUser.TextChanged += frmLogin_TextChanged;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            tbPassword.Location = new Point(416, 209);
            tbPassword.MaxLength = 10;
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(255, 28);
            tbPassword.TabIndex = 1;
            tbPassword.Tag = " Password";
            tbPassword.UseSystemPasswordChar = true;
            tbPassword.TextChanged += frmLogin_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(303, 164);
            label2.Name = "label2";
            label2.Size = new Size(89, 23);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(303, 212);
            label4.Name = "label4";
            label4.Size = new Size(85, 23);
            label4.TabIndex = 2;
            label4.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(242, 239, 231);
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 192);
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(416, 298);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(198, 52);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(36, 9);
            label3.Name = "label3";
            label3.Size = new Size(209, 24);
            label3.TabIndex = 1;
            label3.Text = "Clinic Management";
            // 
            // frmLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(200, 223, 219);
            ClientSize = new Size(689, 383);
            Controls.Add(btnLogin);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(tbPassword);
            Controls.Add(tbUser);
            Controls.Add(groupBox1);
            Font = new Font("Microsoft Sans Serif", 7.8F);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Button btnLogin;
        private Label label3;
    }
}