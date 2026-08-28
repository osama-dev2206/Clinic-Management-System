using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLogicLayer;
using Clinc_Management_System_Presentation_Layer;

namespace Clinc_Management_System
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private string UserName { get; set; }
        private string Password { get; set; }

        private void frmLogin_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;

            switch (tb.Tag.ToString().Trim())
            {
                case "UserName":
                    UserName = tb.Text;
                    break;

                case "Password":
                    Password = tb.Text;
                    break;
            }

        }

        private void CheckLoginInfo()
        {
            if (!String.IsNullOrEmpty(Password) && !String.IsNullOrEmpty(UserName) && clsLogin.CheckLoginInfo(UserName, Password))
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Invalid UserName or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // check the login info
            CheckLoginInfo();

        }



   
    }
}
