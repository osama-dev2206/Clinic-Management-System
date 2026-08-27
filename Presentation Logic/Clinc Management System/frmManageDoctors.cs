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
    public partial class frmManageDoctors : Form
    {
        int SelectedPersonId = -1; // to store the selected doctor  id for update or delete

        public frmManageDoctors()
        {
            InitializeComponent();
            this.dgvDoctor.DataSource = clsDoctor.ListAllDoctors();
         
            this.dtDateOfBirth.MaxDate = DateTime.Now ; // set the max date to today
        }

        clsDoctor doctor = new clsDoctor();

        void RefershDoctorGridView()
        {
            this.dgvDoctor.DataSource = clsDoctor.ListAllDoctors();
        }

        // Search Doctor By PersonID
        private void tbSearchDoctorByPersonId_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.tbSearchDoctorByPersonId.Text) &&
                int.TryParse(tbSearchDoctorByPersonId.Text.ToString(), out int id))
            {
                clsDoctor.GetDoctorRecordFromDb(id);
                this.dgvDoctor.DataSource = clsDoctor.GetDoctorRecordFromDb(id);
            }
            else if (String.IsNullOrEmpty(tbSearchDoctorByPersonId.Text))
            {
                RefershDoctorGridView();
            }

        }

        // To Set Doctor Object Properties when the user change the values in the textboxes //////////////////////////////////
        private void tbFullName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.tbFullName.Text))
            {
                this.doctor.Name = tbFullName.Text;
            }
        }

        private void tbAddress_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.tbAddress.Text))
            {
                this.doctor.Address = tbAddress.Text;
            }
        }

        private void mtbEmail_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.mtbEmail.Text) && mtbEmail.MaskCompleted)
            {
                this.doctor.Email = mtbEmail.Text;
            }
        }
        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbGender.SelectedItem == "Male")
            {
                doctor.Gender = "M";
            }
            else if (cbGender.SelectedItem == "Female")
            {
                doctor.Gender = "F";
            }
        }
        private void tbPhone_TextChanged(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(this.tbPhone.Text))
            {
                this.doctor.Phone = tbPhone.Text;
            }
        }
        private void dtDatefBirth_ValueChanged(object sender, EventArgs e)
        {
            if (dtDateOfBirth != null && !(this.dtDateOfBirth.Value >= DateTime.Now)
                && ! (this.dtDateOfBirth.Value ==DateTime.MinValue) )
            {
                DateOnly dateOfBirth = DateOnly.FromDateTime(dtDateOfBirth.Value);
                doctor.DateOfBirth = dateOfBirth;
            }
        }

        private void tbSpecialization_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.tbSpecialization.Text))
            {
                this.doctor.Specialization = tbSpecialization.Text;
            }
        }


        /// //////////////////////////////////////////////////////////////////////////////////////////////////////////

        bool CheckBeforeSave()
        {
            return !((String.IsNullOrEmpty(doctor.Name) || String.IsNullOrEmpty(this.doctor.Address) || String.IsNullOrEmpty(this.doctor.Gender) || 
                (this.doctor.DateOfBirth == null || this.doctor.DateOfBirth == DateOnly.FromDateTime(DateTime.MinValue) || this.dtDateOfBirth.Value == dtDateOfBirth.MinDate || 
                this.dtDateOfBirth.Value ==DateTime.Now)
  || String.IsNullOrEmpty(doctor.Email) || String.IsNullOrEmpty(doctor.Phone)));

        }

        void RestForm()
        {
            this.tbFullName.Text = "";
            this.tbPhone.Text = "";
            this.tbAddress.Text = "";
            this.mtbEmail.Text = "";
            this.tbSpecialization.Text = "";

        }

        // Update
        void FillFormForEditing()
        {
            this.doctor = clsDoctor.GetDoctorRecordFromDbAsObject(this.SelectedPersonId); // find doctor by id and get the doctor object
            if (doctor != null)
            {
                this.tbFullName.Text = doctor.Name;
                this.tbPhone.Text = doctor.Phone;
                this.tbAddress.Text = doctor.Address;
                this.mtbEmail.Text = doctor.Email;
                this.dtDateOfBirth.Text = doctor.DateOfBirth.ToString();
                if (doctor.Gender.Trim() == "F") this.cbGender.Text = "Female";
                else if (doctor.Gender.Trim() == "M")
                    this.cbGender.Text = "Male";
                this.tbSpecialization.Text = doctor.Specialization;
            }
        }

        private void dgvDoctor_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDoctor != null && dgvDoctor.CurrentRow.Cells[0].Value != null && int.TryParse(dgvDoctor.CurrentRow.Cells[0].Value.ToString(), out int Res))
            {
                SelectedPersonId = Res;
            }
        }


        // Add New Doctor 
        private void pbAddDoctor_Click(object sender, EventArgs e)
        {
            if (CheckBeforeSave())// if all required fields are  filled
            {
                if (doctor.Save())
                {
                    MessageBox.Show("Doctor added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefershDoctorGridView();
                    RestForm();
                }
                else
                {
                    MessageBox.Show("Failed to add doctor. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill all required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        // Update , Delete 
        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Delete" &&
            (DialogResult.OK == MessageBox.Show($"Are You Sure You Want To Delete  {this.SelectedPersonId} ?", "Warn", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)))
            {
                if (clsDoctor.DeleteDoctor(this.SelectedPersonId) && SelectedPersonId != -1)
                {
                    MessageBox.Show("Doctor deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.RefershDoctorGridView();
                }
                else
                {
                    MessageBox.Show("Failed to delete patient. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            else if (e.ClickedItem.Text == "Edit") /// <---- 
            {
                FillFormForEditing();
                this.pbAddDoctor.Visible = false;
                this.btnSaveEditing.Visible = true;
                this.labFormName.Text = "Editing Exist Doctor";
            }
        }

        private void btnSaveEditing_Click(object sender, EventArgs e)
        {
            if(DialogResult.OK == MessageBox.Show($"Are You Sure You Want To Update  {this.SelectedPersonId} ?", "Warn", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
            { 
                if (doctor.Save())
                {
                    MessageBox.Show("The New Edits Applied Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefershDoctorGridView();
                    RestForm();
                }
                else
                {
                    MessageBox.Show("Failed to update doctor. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.labFormName.Text = "Manage Doctors";
                this.pbAddDoctor.Visible = true;
                this.btnSaveEditing.Visible = false;
                RestForm();
            }
      

        }


    }
}
