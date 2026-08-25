using Clinc_Management_System_Presentation_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinc_Management_System
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmLogin loginForm ;
            MainForm Main = new MainForm();
            while ( Main.DialogResult == DialogResult.OK)
            {

                loginForm = new frmLogin();
                loginForm.ShowDialog();
                if (loginForm.DialogResult == DialogResult.Cancel) break; 
                
                else if (loginForm.DialogResult == DialogResult.OK)
                { 
                    Main.ShowDialog();
                    loginForm.Dispose();
                }

            }


        }


    }
}
