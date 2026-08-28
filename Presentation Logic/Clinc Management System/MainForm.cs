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
            RefreshAppointments();

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

        void RefreshAppointments()
        {
            DataView dataView = clsAppointment.ListAllAppointments().DefaultView;
            dataView.Sort = "AppointmentId ASC"; 
            dgvListAllAppointments.DataSource = dataView;

            P1NumOfAppointements.Text = clsAppointment.GetNumOfAppointments().ToString();
        }

        /// / /////////////////// Handle The Appointments Context Menu Strip /////////////////////////////////

        void AddNewAppointment()
        {
            // -1 means that we are adding a new appointment, not editing an existing one
            fmManageAppointments manageAppointments = new fmManageAppointments(-1);
            manageAppointments.ShowDialog();
            manageAppointments.Dispose();

            RefreshAppointments();
        }

        void EditAppointment()
        {
            fmManageAppointments manageAppointments = new fmManageAppointments(this.AppointmentID);
            manageAppointments.ShowDialog();
            manageAppointments.Dispose();
            RefreshAppointments();
        }

        void DeleteAppointemts()
        {
            this.contextMenuStrip1.Visible = false;
            if (DialogResult.OK == MessageBox.Show("Are you sure you want to delete this appointment?", "Delete Appointment", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
            {
                if (clsAppointment.DeleteAppointment(this.AppointmentID))
                {
                    MessageBox.Show("Appointment deleted successfully.", "Delete Appointment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshAppointments();

                }
                else
                {
                    MessageBox.Show("Failed to delete the appointment. Please try again.", "Delete Appointment", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

            this.contextMenuStrip1.Visible = true;

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
                    EditAppointment();
                    break;

                case "Delete Appointment":
                    DeleteAppointemts();
                    break;
            }


        }

        // Assign the selected appointment ID to the AppointmentID property when a row is selected in the DataGridView
        private void P1ListAllAppointments_SelectionChanged(object sender, EventArgs e)
        {
            
            
                if (this.dgvListAllAppointments != null && dgvListAllAppointments.CurrentRow != null
                && int.TryParse(dgvListAllAppointments.CurrentRow.Cells[0].Value.ToString(), out int ID))
                {
                    this.AppointmentID = ID;
                }
            
        
        }



    }
}
