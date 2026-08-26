using Bussiness_Logic_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Clinc_Management_System_Presentation_Layer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            DialogResult = DialogResult.OK;
            StartDashboard();
        }

        private void StartDashboard()
        {

            P1ListAllAppointments.DataSource = clsDasboard.ListAllAppointments();

            P1NumOfAppointements.Text = clsDasboard.GetNumOfAppointments().ToString();

        }

        private void labManagePatients_Click(object sender, EventArgs e)
        {
            frmManagePatients frmManagePatients = new frmManagePatients();
            frmManagePatients.ShowDialog();
            frmManagePatients.Dispose();
        }

        private void labManageDoctors_Click(object sender, EventArgs e)
        {
         
        }



        private void labLogout_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK; // i will sign in with another account 
            this.Close();
       }


    }
}
