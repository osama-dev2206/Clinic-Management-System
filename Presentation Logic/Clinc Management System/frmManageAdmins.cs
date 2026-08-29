using BussinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clinc_Management_System_Presentation_Layer
{
    // Presentation layer 
    public partial class frmManageAdmins : Form
    {
        clsAdmin admin = new clsAdmin(); // add new admin status
        int CurrentSelectedPersonId = -1; // to store the current selected admin id from the datagridview

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


        private void tbSearchAdminByPersonId_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbSearchAdminByPersonId.Text) && int.TryParse(tbSearchAdminByPersonId.Text, out int ID))
            {
                this.dgvAdmins.DataSource = clsAdmin.GetDTAdminByPersonId(ID);
            }
            else if (String.IsNullOrEmpty(tbSearchAdminByPersonId.Text))
            {
                RefreshAdminsDataGrid();
            }

        }


        // to manage the permissions of the admin
        private void chkPermissions_Click(object sender, EventArgs e)
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

        // Save Changes to the database

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
            if (CheckBeforeSave())
            {
                if (admin.SaveAdmin())
                {
                    MessageBox.Show("Admin Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshAdminsDataGrid();
                    RestAdminForm();
                }
                else
                {
                    MessageBox.Show("Failed To Save The Admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Fill All Required Fields Before Saving The Admin", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void dgvAdmins_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAdmins != null && dgvAdmins.CurrentRow != null && int.TryParse(dgvAdmins.CurrentRow.Cells[0].Value.ToString(), out int ID))
            {
                CurrentSelectedPersonId = ID;
            }

        }

        // Manage Form when You Edit It 

        void FillChkPermissions()
        {
            if (admin.CheckPermission(clsAdmin.enPersmissions.ManagePatients))
            {
                this.chkManagePatients.Checked = true;
            }

            if (admin.CheckPermission(clsAdmin.enPersmissions.ManageDoctors))
            {
                this.chkManageDoctors.Checked = true;
            }

            if (admin.CheckPermission(clsAdmin.enPersmissions.ManageAppointments))
            {
                this.chkManageAppointments.Checked = true;
            }

            if (admin.CheckPermission(clsAdmin.enPersmissions.ManageAdmins))
            {
                this.chkManageAdmins.Checked = true;
            }

        }

        void RestChkPermissions()
        {
            this.chkManagePatients.Checked = false;
            this.chkManageDoctors.Checked = false;
            this.chkManageAppointments.Checked = false;
            this.chkManageAdmins.Checked = false;
        }

        void FillAdminForm()
        {
            if (this.admin != null)
            {
                this.Name = this.admin.Name;
                this.dtDateOfBirth.Text = DateTime.Today.AddYears(-(admin.Age)).ToString(); // note the date of birth stored as age in object , you insert dt and i show age only 

                if (this.admin.Gender == "M")
                {
                    this.cbGender.Text = "Male";
                }
                else if(this.admin.Gender == "F")
                {
                    this.cbGender.Text = "Female";
                }

                this.tbAddress.Text = this.admin.Address;
                this.tbPhone.Text = this.admin.Phone;
                this.mtbEmail.Text = this.admin.Email;

                this.tbUserName.Text = this.admin.UserName;
                this.tbPassword.Text = this.admin.AdminPassword;

                // Permissions
                FillChkPermissions();


            }

        }

        void RestAdminForm()
        {
            this.tbFullName.Text = "";
            this.dtDateOfBirth.Text = "";
            this.cbGender.Text = "";
            this.tbAddress.Text = "";
            this.tbPhone.Text = "";
            this.mtbEmail.Text = "";

            this.tbUserName.Text = "";
            this.tbPassword.Text = "";

            RestChkPermissions();

        }

        // Context Menu 
        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string? SelectedItem = e.ClickedItem.Text;

            if (SelectedItem.Trim() == "Delete")
            {
                DialogResult res =
                    MessageBox.Show("Are you sure you want to delete this admin?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (res == DialogResult.Yes)
                {
                    if (clsAdmin.DeleteAdmin(CurrentSelectedPersonId))
                    {
                        MessageBox.Show("Admin Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.RefreshAdminsDataGrid();
                    }
                    else
                        MessageBox.Show("Failed To Delete The Admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

            else if (SelectedItem.Trim() == "Edit")
            {
                this.admin = clsAdmin.GetAdminByPersonID(this.CurrentSelectedPersonId);
                FillAdminForm();
                this.btnSaveEditing.Visible = true;
            }

        }

        private void btnSaveEditing_Click(object sender, EventArgs e)
        {
           
            if(admin.SaveAdmin())
            {
                MessageBox.Show("Admin Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                RefreshAdminsDataGrid();
                RestAdminForm();
                this.btnSaveEditing.Visible = false;
            }
            else
            {
                MessageBox.Show("Failed To Update The Admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
