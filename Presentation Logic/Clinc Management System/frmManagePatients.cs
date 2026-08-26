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
    public partial class frmManagePatients : Form
    {
        public frmManagePatients()
        {
            InitializeComponent();
            this.GrdPatient.DataSource = clsPatient.ListAllPatients();
        }

        private clsPatient Patient = new clsPatient(); // add new patient 

        int SelectedPatientId = -1; // to store the selected patient id for update or delete

        private void tbFullName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(tbFullName.Text))
                Patient.Name = tbFullName.Text;
        }

        private void tbAddress_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbAddress.Text))
                Patient.Address = tbAddress.Text;
        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGender.SelectedItem == "Male")
            {
                Patient.Gender = "M";
            }
            else if (cbGender.SelectedItem == "Female")
            {
                Patient.Gender = "F";
            }
        }

        private void dtDatefBirth_ValueChanged(object sender, EventArgs e)
        {
            if (dtDatefBirth != null && !(dtDatefBirth.Value > DateTime.Now))
            {
                DateOnly dateOfBirth = DateOnly.FromDateTime(dtDatefBirth.Value);
                Patient.DateOfBirth = dateOfBirth;
            }
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(mtbEmail.Text) && mtbEmail.MaskCompleted)
                Patient.Email = mtbEmail.Text;
        }

        private void tbPhone_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(tbPhone.Text))
                Patient.Phone = tbPhone.Text;
        }

        // return true if there is error 
        bool CheckObjBeforeSave()
        {
            if (String.IsNullOrEmpty(Patient.Name) || String.IsNullOrEmpty(this.Patient.Address) || String.IsNullOrEmpty(this.Patient.Gender) || (this.Patient.DateOfBirth == null)
               || String.IsNullOrEmpty(mtbEmail.Text) || String.IsNullOrEmpty(tbPhone.Text))
                return true;
            else return false;
        }

        void RefreshGrid()
        {
            this.GrdPatient.DataSource = clsPatient.ListAllPatients();
        }

        private void tbSearchPatient_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbSearchPatient.Text) && int.TryParse(tbSearchPatient.Text, out int ID))
            {
                GrdPatient.DataSource = clsPatient.GetPatientRecordFromDb(ID);
            }
            else if (String.IsNullOrEmpty(tbSearchPatient.Text))
            {
                RefreshGrid();
            }
        }


        private void AddpictureBox_Click(object sender, EventArgs e)
        {
            if (CheckObjBeforeSave())
            {
                MessageBox.Show("Please fill all the required fields before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (Patient.Save())
                {
                    MessageBox.Show("Patient added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGrid();
                }
                else
                {
                    MessageBox.Show("Failed to add patient. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Delete" &&
             (DialogResult.OK == MessageBox.Show($"Are You Sure You Want To Delete  {this.SelectedPatientId} ?", "Warn", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)))
            {
                if (clsPatient.Delete(this.SelectedPatientId) && SelectedPatientId != -1)
                {
                    MessageBox.Show("Patient deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    RefreshGrid();
                }
                else
                {
                    MessageBox.Show("Failed to delete patient. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (e.ClickedItem.Text == "Update") /// <---- 
            {

            }

        }

        private void GrdPatient_SelectionChanged(object sender, EventArgs e)
        {
            if (GrdPatient != null && GrdPatient.CurrentRow.Cells[0].Value != null && int.TryParse(GrdPatient.CurrentRow.Cells[0].Value.ToString(), out int Res))
            {
                SelectedPatientId = Res;
            }
        }


        private void frmManagePatients_FormClosing(object sender, FormClosingEventArgs e)
        {
            // DialogResult = DialogResult.OK;
        }


    }
}
