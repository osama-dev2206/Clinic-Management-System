using Bussiness_Logic_Layer;
using BussinessLogicLayer;
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
        clsAdmin admin; // in main form we need to get admin only (the admin already exists as i have successed to login ) 

        public MainForm()
        {
            InitializeComponent();
            DialogResult = DialogResult.OK;
            StartDashboard();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        internal string CurrentLoggedInUserName { get; set; }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.labCurrentLoggedUser.Text += CurrentLoggedInUserName;
            admin = clsAdmin.GetAdminByUserName(CurrentLoggedInUserName); // fill the object with admin info 
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

        //Patient Managemnet 
        private void btnManagePatients_Click(object sender, EventArgs e)
        {
            if (admin.CheckPermission(clsAdmin.enPersmissions.ManagePatients))
            {
                frmManagePatients frmManagePatients = new frmManagePatients();
                frmManagePatients.ShowDialog();
                frmManagePatients.Dispose();
            }
            else
            {
                MessageBox.Show("You Don't Have Permission To Manage Patients", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Doctor Management 
        private void btnManageDoctors_Click(object sender, EventArgs e)
        {
            if (this.admin.CheckPermission(clsAdmin.enPersmissions.ManageDoctors))
            {
                frmManageDoctors Doctors = new frmManageDoctors();
                Doctors.ShowDialog();
                Doctors.Dispose();
            }
            else
            {
                MessageBox.Show("You Don't Have Permission To Manage Doctors", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }



        /// / /////////////////// Handle The Appointments Context Menu Strip /////////////////////////////////

        //Appointment Management 
        void RefreshAppointments()
        {
            DataView dataView = clsAppointment.ListAllAppointments().DefaultView;
            dataView.Sort = "AppointmentId ASC";
            dgvListAllAppointments.DataSource = dataView;

            P1NumOfAppointements.Text = clsAppointment.GetNumOfAppointments().ToString();
        }


        void AddNewAppointment()
        {

            if (this.admin.CheckPermission(clsAdmin.enPersmissions.ManageAppointments))
            {
                // -1 means that we are adding a new appointment, not editing an existing one
                fmManageAppointments manageAppointments = new fmManageAppointments(-1);
                manageAppointments.ShowDialog();
                manageAppointments.Dispose();

                RefreshAppointments();
            }
            else
            {
                MessageBox.Show("You Don't Have Permission To Manage Appointments", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        void EditAppointment()
        {
            if (admin.CheckPermission(clsAdmin.enPersmissions.ManageAppointments))
            {
                fmManageAppointments manageAppointments = new fmManageAppointments(this.AppointmentID);
                manageAppointments.ShowDialog();
                manageAppointments.Dispose();
                RefreshAppointments();
            }
            else
            {
                MessageBox.Show("You Don't Have Permission To Manage Appointments", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        void DeleteAppointemts()
        {
            if (admin.CheckPermission(clsAdmin.enPersmissions.ManageAppointments))
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
            else
            {
                MessageBox.Show("You Don't Have Permission To Manage Appointments", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

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

        // Manage Admins
        private void btnManageAdmins_Click(object sender, EventArgs e)
        {
            if(admin.CheckPermission(clsAdmin.enPersmissions.ManageAdmins))
            {
                frmManageAdmins manageAdmins = new frmManageAdmins();
                manageAdmins.ShowDialog();
                manageAdmins.Dispose();
            }
            else
            {
                MessageBox.Show("You Don't Have Permission To Manage Admins", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }



    }
}
