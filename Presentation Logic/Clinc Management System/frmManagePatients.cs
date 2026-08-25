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

        // return true if there is error 
        bool CheckObjBeforeSave()
        {
            if (String.IsNullOrEmpty(Patient.Name) || String.IsNullOrEmpty(this.Patient.Address) || String.IsNullOrEmpty(this.Patient.Gender) || (this.Patient.DateOfBirth == null))
                return true;
            else return false;
        }

        bool CheckObjBeforeUpdate()
        {
            if (String.IsNullOrEmpty(tbAddress.Text) || String.IsNullOrEmpty(tbFullName.Text) || String.IsNullOrEmpty(cbGender.SelectedItem.ToString()) || (dtDatefBirth.Value == null))
                return true;
            else return false;
        }

        void RefreshGrid()
        {
            this.GrdPatient.DataSource = clsPatient.ListAllPatients();
        }

        private void AddpictureBox_Click(object sender, EventArgs e)
        {
            if (CheckObjBeforeSave() || CheckObjBeforeUpdate())
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
                if (clsPatient.Delete(this.SelectedPatientId))
                {
                    MessageBox.Show("Patient deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    RefreshGrid();
                }
            }
            else if (e.ClickedItem.Text == "Update")
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

        // Later 
        private void frmManagePatients_FormClosing(object sender, FormClosingEventArgs e)
        {
           DialogResult = DialogResult.OK;
        }


    }
}
