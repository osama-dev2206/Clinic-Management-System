using Bussiness_Logic_Layer;
using Data_Access_Layer;
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

            if (AppointmentID == -1)
            {
                Status = enFormOption.AddNewAppointment;
                this.labManageFormMainText.Text = "Add New Appointment";
                this.btnAddEdit.Text = "Add";
            }
            else
            {
                Status = enFormOption.EditAppointment;
                this.labManageFormMainText.Text = "Edit Appointment";
                this.btnAddEdit.Text = "Save Changes";
            }

        }

        private void fmManageAppointments_Load(object sender, EventArgs e)
        {
            FillCbWithPatientsNames();
            FillCbWithDoctorsNames();
        }

        void FillCbWithPatientsNames()
        {
            DataTable dt = clsListAllPatients.ListAllPatients();

            foreach (DataRow R in dt.Rows)
            {
                cbPatient.Items.Add(R["Name"].ToString());
            }
        }

        void FillCbWithDoctorsNames()
        {
            DataTable dt = clsListAllDoctors.ListAllDoctors();
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


        /// ///// /// /////v /// ///// /// /////v /// /////v /// ///// /// ///// /// ///// /// ///// /// ///// /// /////

        private bool CheckBeforeSaving()
        {
            return !(
                ()
                );
        }

        private void btnAddEdit_Click(object sender, EventArgs e)
        {

        }


    }
}
