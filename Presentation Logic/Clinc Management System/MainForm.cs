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
            backToDashboard_Click(components, EventArgs.Empty);
        }

        void DisableAllControls()
        {
            // P1 
            P1gb.Visible = false;
            this.labDashboard.Visible = false;
            P1ListAllAppointments.Visible = false;
            P1NumOfAppointements.Visible = false;
            labNumHeader.Visible = false;

        }

        private void labManagePatients_Click(object sender, EventArgs e)
        {
          frmManagePatients frmManagePatients = new frmManagePatients();
            frmManagePatients.ShowDialog();
        }

        private void labManageDoctors_Click(object sender, EventArgs e)
        {
            DisableAllControls();
        }

        private void backToDashboard_Click(object sender, EventArgs e)
        {
            P1gb.Visible = true;
            this.labDashboard.Visible = true;
            P1ListAllAppointments.Visible = true;
            P1ListAllAppointments.DataSource = clsDasboard.ListAllAppointments();
            P1NumOfAppointements.Visible = true;
            P1NumOfAppointements.Text = clsDasboard.GetNumOfAppointments().ToString();
            labNumHeader.Visible = true;
        }


    }
}
