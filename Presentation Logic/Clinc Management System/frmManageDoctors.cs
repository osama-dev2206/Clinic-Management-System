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
        public frmManageDoctors()
        {
            InitializeComponent();
            this.dgvDoctor.DataSource = clsDoctor.ListAllDoctors();
        }

        clsDoctor doctor = new clsDoctor();
        void RefershDoctorGridView()
        {
            this.dgvDoctor.DataSource = clsDoctor.ListAllDoctors();
        }

        private void tbSearchDoctorByPersonId_TextChanged(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(tbSearchDoctorByPersonId.Text ) && 
                int.TryParse(tbSearchDoctorByPersonId.Text.ToString(),out int id))
            {
                clsDoctor.GetDoctorRecordFromDb(id);
                this.dgvDoctor.DataSource = clsDoctor.GetDoctorRecordFromDb(id);
            }
            else if (String.IsNullOrEmpty(tbSearchDoctorByPersonId.Text))
            {
                RefershDoctorGridView();
            }

        }


    }
}
