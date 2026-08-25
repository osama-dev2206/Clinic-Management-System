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

        private void labManagePatients_Click(object sender, EventArgs e)
        {

        }

        private void labManageDoctors_Click(object sender, EventArgs e)
        {

        }

        private void backToDashboard_Click(object sender, EventArgs e)
        {
            P1gb.Visible = true;
            this.labDashboard.Visible = true;
            P1ListAllAppointments.Visible = true;
            P1ListAllAppointments.DataSource = clsDasboard.ListAllAppointments();
            P1NumOfAppointements.Visible = true;
            P1NumOfAppointements.Text = clsDasboard.GetNumOfAppointments().ToString();
            label1.Visible = true;
        }


    }
}
