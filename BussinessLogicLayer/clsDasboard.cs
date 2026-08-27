using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
namespace Bussiness_Logic_Layer
{
    public static class clsDasboard
    {
        public static DataTable ListAllAppointments()
        {
            return clsListAllAppointments.ListAllAppointments();
        }

        public static int GetNumOfAppointments()
        {
            return clsGetNumOfAppointments.GetNumOfAppointments();
        }

    }
}
