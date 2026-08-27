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

        private clsAppointment(int AppointmentID, int DoctorID, int PatientID, DateTime AppointmentDateTime, string AppointmentStatus)
        {
            this.AppointmentId = AppointmentID;
            this.ADoctorId = DoctorID;
            this.APatientId = PatientID;
            this.AppointmentDateTime = AppointmentDateTime;
            this.AppointmentStatus = AppointmentStatus;

            this.Status = enMode.Update;
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

        public  static clsAppointment FindAppointmentByID(int AppointmentID)
        {
            DataTable dt = clsFindAppointmentByID.FindAppointmentByID(AppointmentID);
            if (!int.TryParse(AppointmentID.ToString(), out _) || dt == null ) return null; 

         
            clsAppointment appointment = null;

            foreach (DataRow R in dt.Rows)
            {
                appointment = new clsAppointment(
                    Convert.ToInt32(R["AppointmentId"]) ,
                   Convert.ToInt32(R["ADoctorId"] ,
                   Convert.ToInt32(R["APatientId"] ,
                   Convert.ToDateTime(R["AppointmentDateTime"] ,
                   R["AppoitmentStatus"].ToString()
                   );
            }

            return appointment;

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

                    case enMode.Update: // not implemented yet
                    {
                        return false; 
                    }
            }

            return false;
        }

        public static bool DeleteAppointment(int AppointmentID)
        {
            return clsDeleteAppointment.DeleteAppointment(AppointmentID);
        }


    }


}
