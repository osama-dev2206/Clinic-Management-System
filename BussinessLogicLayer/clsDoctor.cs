using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Bussiness_Logic_Layer
{
    /// <summary>
    ///  Bussiness Logic Layer Class for Doctor Entity
    /// </summary>
    public class clsDoctor : abPerson , IDoctor
    {
        enObjectStatus Status;
       public string Specialization {  get; set; }

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

         bool AddNewDoctor()
        {
            return (clsInsertNewDoctor.InsertNewDoctor (   new clsInsertNewDoctor.DoctorInfo
            { Name= this.Name ,  DateOfBirth = this.DateOfBirth , Gender = this.Gender ,
                Address = this.Address , Email = this.Email, Phone = this.Phone , Specialization = this.Specialization }  )  != -1  );
           
        }

        public bool DeleteDoctor(int PersonDoctorId)
        {
            return false; // Not Implemented Yet
        }

        bool UpdateDoctor()
        {
            return false; //
        }

        public bool Save()
        {
            switch(this.Status)
            {
                case enObjectStatus.enAdd:
                    if(AddNewDoctor())
                    {
                        this.Status = enObjectStatus.enUpdate;
                        return true;
                    }
                    break;

                    case enObjectStatus.enUpdate:
                    if(this.UpdateDoctor() ) 
                        return true;
                    break;

            }
            return false;
        }




    }

}
