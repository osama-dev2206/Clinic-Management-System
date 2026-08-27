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
        int AppointmentID { set; get; }
        enum enFormOption : byte { AddNewAppointment = 1, EditAppointment = 2, }
        enFormOption Status;
        clsPatient Patient;
        clsDoctor doctor;

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

        private void cbPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPatient != null && cbPatient.SelectedIndex != -1 && !String.IsNullOrEmpty(cbPatient.SelectedItem.ToString()))
            {
                Patient = clsPatient.FindPatientByName(cbPatient.Text);

            }

        }

        private void cbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDoctor != null && cbDoctor.SelectedIndex != -1 && !String.IsNullOrEmpty(cbDoctor.SelectedItem.ToString()))
            {
                this.doctor = clsDoctor.FindDoctorByName(cbDoctor.Text);
         
            }

        }




    }
}
