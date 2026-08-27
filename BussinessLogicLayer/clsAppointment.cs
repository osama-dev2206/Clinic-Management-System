using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
namespace Bussiness_Logic_Layer
{
    public  class clsAppointment : abAppointment
    {
      
        enMode Status; 

        public clsAppointment()
        {
            this.Status = enMode.Add; 
        }

        public static DataTable ListAllAppointments()
        {
            return clsListAllAppointments.ListAllAppointments();
        }

        public static int GetNumOfAppointments()
        {
            return clsGetNumOfAppointments.GetNumOfAppointments();
        }


        private bool AddNewAppointment()
        {
            return clsAddNewAppointment.AddNewAppointment(this.ADoctorId, this.APatientId, this.AppointmentDateTime, this.AppointmentStatus);
        }


        public bool Save()
        {
            switch (this.Status)
            {
                    case enMode.Add:
                    {
                    if (AddNewAppointment())
                    {
                        this.Status = enMode.Update;
                        return true;
                    }
                    else return false;
                }

                    case enMode.Update:
                    {
                        return false; 
                    }
            }

            return false;
        }



    }


}
