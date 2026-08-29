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
    // Presentation layer 
    public partial class frmManageAdmins : Form
    {
        clsAdmin admin = new clsAdmin(); // add new admin status

        public frmManageAdmins()
        {
            InitializeComponent();
            RefreshAdminsDataGrid();
            dtDateOfBirth.Value = DateTime.Now;
        }

        void RefreshAdminsDataGrid()
        {
            dgvAdmins.DataSource = clsAdmin.ListAllAdmins();
        }

        // Set The Object properties when the textboxes are changed
        private void tbFullName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbFullName.Text))
            {
                admin.Name = tbFullName.Text;
            }
        }

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbUserName.Text))
            {
                admin.UserName = tbUserName.Text;
            }
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbPassword.Text))
            {
                admin.AdminPassword = tbPassword.Text;
            }

        }

        private void tbAddress_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbAddress.Text))
            {
                admin.Address = tbAddress.Text;
            }
        }

        private void dtDateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            if (dtDateOfBirth != null && dtDateOfBirth.Value != DateTime.MinValue)
            {
                admin.DateOfBirth = DateOnly.FromDateTime(dtDateOfBirth.Value);
            }
        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGender != null && cbGender.SelectedIndex != -1 && cbGender.SelectedItem != null)
            {
                this.admin.Gender = (cbGender.SelectedItem.ToString() == "Male") ? "M" : "F";
            }
        }

        private void mtbEmail_TextChanged(object sender, EventArgs e)
        {
            if (mtbEmail != null && mtbEmail.MaskCompleted)
            {
                this.admin.Email = mtbEmail.Text;
            }
        }

        private void tbPhone_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbPhone.Text))
            {
                this.admin.Phone = tbPhone.Text;
            }
        }

        // to manage the permissions of the admin
        private void chkManagePatients_Click(object sender, EventArgs e)
        {
            if (chkManagePatients.Checked)
            {
                admin.AssignPermissionToAdmin(clsAdmin.enPersmissions.ManagePatients);
            }
            else
            {
                admin.RemovePermissionFromAdmin(clsAdmin.enPersmissions.ManagePatients);
            }

            if (chkManageDoctors.Checked)
            {
                admin.AssignPermissionToAdmin(clsAdmin.enPersmissions.ManageDoctors);

            }
            else
            {
                admin.RemovePermissionFromAdmin(clsAdmin.enPersmissions.ManageDoctors);
            }

            if (chkManageAppointments.Checked)
            {
                admin.AssignPermissionToAdmin(clsAdmin.enPersmissions.ManageAppointments);
            }
            else
            {
                admin.RemovePermissionFromAdmin(clsAdmin.enPersmissions.ManageAppointments);
            }


            if (chkManageAdmins.Checked)
            {
                admin.AssignPermissionToAdmin(clsAdmin.enPersmissions.ManageAdmins);

            }
            else
            {
                admin.RemovePermissionFromAdmin(clsAdmin.enPersmissions.ManageAdmins);
            }


        }


        private bool CheckBeforeSave()
        {
            return !String.IsNullOrEmpty(admin.Name) &&
                   !String.IsNullOrEmpty(admin.UserName) &&
                   !String.IsNullOrEmpty(admin.AdminPassword) &&
                   !String.IsNullOrEmpty(admin.Address) &&
                   !String.IsNullOrEmpty(admin.Gender) &&
                   !String.IsNullOrEmpty(admin.Email) &&
                   !String.IsNullOrEmpty(admin.Phone) &&
                   !String.IsNullOrEmpty(admin.Gender);
        }

        private void pbAddAdmin_Click(object sender, EventArgs e)
        {
            if(CheckBeforeSave())
            {

            }
            else
            {
                MessageBox.Show("Please Fill All Required Fields Before Saving The Admin", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }



    }
}
