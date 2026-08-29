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
    public partial class fmManageAppointments : Form
    {

        enum enFormOption : byte { AddNewAppointment = 1, EditAppointment = 2, }

        enFormOption Status;
 
        clsAppointment appointment = new clsAppointment(); // paramter-less constructor = add new 

        public fmManageAppointments(int AppointmentID)
        {
            InitializeComponent();
            this.dtDateTime.Value = DateTime.Now;

            if (AppointmentID == -1)
            {
                Status = enFormOption.AddNewAppointment;
                this.labManageFormMainText.Text = "Add New Appointment";
                this.btnAddEdit.Text = "Add";
            }
            else
            {
                Status = enFormOption.EditAppointment;
                this.appointment = clsAppointment.FindAppointmentByID(AppointmentID); // the mode of object wil be  update 
                FillFormWithAppointmentData();
                this.labManageFormMainText.Text = "Edit Appointment";
                this.btnAddEdit.Text = "Save";
            }

        }

        private void fmManageAppointments_Load(object sender, EventArgs e)
        {
            FillCbWithPatientsNames();
            FillCbWithDoctorsNames();
        }

        void FillCbWithPatientsNames()
        {
            DataTable dt = clsPatient.ListAllPatients();

            foreach (DataRow R in dt.Rows)
            {
                cbPatient.Items.Add(R["Name"].ToString());
            }
        }

        void FillCbWithDoctorsNames()
        {
            DataTable dt = clsDoctor.ListAllDoctors();
            foreach (DataRow R in dt.Rows)
            {
                cbDoctor.Items.Add(R["DoctorName"].ToString());
            }

        }

        // Form Changes 
        private void cbPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPatient != null && cbPatient.SelectedIndex != -1 && !String.IsNullOrEmpty(cbPatient.SelectedItem.ToString()))
            {
               
                this.appointment.APatientId = clsPatient.FindPatientByName(cbPatient.Text).PatinetId;
            }

        }

        private void cbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDoctor != null && cbDoctor.SelectedIndex != -1 && !String.IsNullOrEmpty(cbDoctor.SelectedItem.ToString()))
            {
              
                this.appointment.ADoctorId = clsDoctor.FindDoctorByName(cbDoctor.Text).DoctorId;
            }

        }

        private void cbAppointmentStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAppointmentStatus != null && !String.IsNullOrEmpty(cbAppointmentStatus.SelectedItem.ToString()))
            {
                appointment.AppointmentStatus = cbAppointmentStatus.Text;
            }

        }

        private void dtDateTime_ValueChanged(object sender, EventArgs e)
        {
            if (dtDateTime != null && dtDateTime.Value != dtDateTime.MinDate)
            {
                this.appointment.AppointmentDateTime = this.dtDateTime.Value;
            }
        }


        /// ///// /// /////// /// ///// /// ////// /// ////// /// ///// /// ///// /// ///// /// ///// /// ///// /// /////

        private void FillFormWithAppointmentData()
        {
            if (this.Status == enFormOption.EditAppointment && appointment != null)
            {
                this.dtDateTime.Value = this.appointment.AppointmentDateTime;
                this.cbAppointmentStatus.Text = this.appointment.AppointmentStatus;

                //   You MUST Use Person id
               this.cbDoctor.Text = clsDoctor.GetDoctorRecordFromDbAsObjByDoctorID(this.appointment.ADoctorId).Name;
               this.cbPatient.Text = clsPatient.FindPatinetByPatientID(this.appointment.APatientId).Name;
            }
            else
            {
                MessageBox.Show("Failed to Load Appointment Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private bool CheckBeforeSaving()
        {
            return !(
                (this.appointment.ADoctorId ==0 || this.appointment.APatientId ==0 || this.appointment.AppointmentDateTime == null 
                ||  this.appointment.AppointmentStatus == string.Empty )
                );
        }

        // Button to add or edit appointment
        private void btnAddEdit_Click(object sender, EventArgs e)
        {

            if (CheckBeforeSaving())
            {
                if (this.Status == enFormOption.AddNewAppointment)
                {
                    if (appointment.Save())
                    {
                        MessageBox.Show("Appointment Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }

                    else
                    {
                        MessageBox.Show("Failed to Add Appointment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }

                if(this.Status== enFormOption.EditAppointment) 
                {
                    if (appointment.Save())
                    {
                        MessageBox.Show("Appointment Edited Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }

                    else
                    {
                        MessageBox.Show("Failed to Edit Appointment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
            else
            {
                MessageBox.Show("Please Fill All Required Fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }




    }
}
