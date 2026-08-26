using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Bussiness_Logic_Layer
{

    public class clsDoctor : abPerson
    {
        enObjectStatus Status;

       
        public clsDoctor()  // Constructor for Adding New Doctor
        {
            this.Status = enObjectStatus.enAdd;
        }

        public static DataTable ListAllDoctors()
        {
          return clsListAllDoctors.ListAllDoctors();
        }

        public static DataTable GetDoctorRecordFromDb(int PersonID)
        {
            return clsGetDoctorRecordByPersonId.GetDoctorByPersonID(PersonID) ; 
        }

    }

}
