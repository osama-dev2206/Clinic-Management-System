using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Bussiness_Logic_Layer
{
    public static class clsPatient
    {

        public static DataTable ListAllPatients()
        {
            return clsListAllPatients.ListAllPatients();
        }

    }
}
