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
        enum enFormOption : byte { AddNewAppointment = 1,  EditAppointment = 2,  }
        enFormOption Status; 

        public fmManageAppointments(int AppointmentID)
        {
            InitializeComponent();

            if(AppointmentID  == -1)
            {
                Status= enFormOption.AddNewAppointment;
                this.labManageFormMainText.Text = "Add New Appointment";
                this.btnAddEdit.Text = "Add";
            }
            else
            {
                Status= enFormOption.EditAppointment;
                this.labManageFormMainText.Text = "Edit Appointment";
                this.btnAddEdit.Text = "Save Changes";
            }

        }



    }
}
