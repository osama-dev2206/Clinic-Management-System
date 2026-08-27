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
        int AppointmentID = -1;

        public MainForm()
        {
            InitializeComponent();
            DialogResult = DialogResult.OK;
            StartDashboard();
        }

        private void StartDashboard()
        {

            dgvListAllAppointments.DataSource = clsAppointment.ListAllAppointments();

            P1NumOfAppointements.Text = clsAppointment.GetNumOfAppointments().ToString();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK; // i will sign in with another account 
            this.Close();
        }

        private void btnManagePatients_Click(object sender, EventArgs e)
        {
            frmManagePatients frmManagePatients = new frmManagePatients();
            frmManagePatients.ShowDialog();
            frmManagePatients.Dispose();
        }

        private void btnManageDoctors_Click(object sender, EventArgs e)
        {
            frmManageDoctors Doctors = new frmManageDoctors();
            Doctors.ShowDialog();
            Doctors.Dispose();
        }


        /// / /////////////////// Handle The Appointments Context Menu Strip /////////////////////////////////

        void AddNewAppointment()
        {
            // -1 means that we are adding a new appointment, not editing an existing one
            fmManageAppointments manageAppointments = new fmManageAppointments(-1);
            manageAppointments.ShowDialog();
            manageAppointments.Dispose();
        }

        void EditAppointment()
        {
          
            fmManageAppointments manageAppointments = new fmManageAppointments(this.AppointmentID);
            manageAppointments.ShowDialog();
            manageAppointments.Dispose();
        }



        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string SelectedItem = e.ClickedItem.Text;
            switch (SelectedItem)
            {
                case "Add New Appointment":
                    AddNewAppointment();
                    break;

                case "Edit Appointment":
                    break;

                case "Delete Appointment":
                    break;
            }


        }

        // Assign the selected appointment ID to the AppointmentID property when a row is selected in the DataGridView
        private void P1ListAllAppointments_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dgvListAllAppointments != null && dgvListAllAppointments.CurrentRow.Cells[0].Value != null
                && int.TryParse(dgvListAllAppointments.CurrentRow.Cells[0].Value.ToString(), out int ID))
            {
                this.AppointmentID = ID;
            }
        }



    }
}
