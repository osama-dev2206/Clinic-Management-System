using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Numerics;
using System.Runtime.CompilerServices;
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

        public int DoctorId { get; private set; }

        public clsDoctor()  // Constructor for Adding New Doctor
        {
            this.Status = enObjectStatus.enAdd;
        }

        private clsDoctor(int PersonID, string Name, DateOnly DateOfBirth, string Gender, string Address, string Specialization, string Email, string Phone , int DoctorId) // Constructor for Updating Doctor
        {
            this.PersonID = PersonID;
            this.Name = Name;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
            this.Address = Address;
            this.Email = Email;
            this.Phone = Phone;
            this.Specialization = Specialization;
            this.DoctorId = DoctorId;

            this.Status = enObjectStatus.enUpdate;
        }


        public static DataTable ListAllDoctors()
        {
          return clsListAllDoctors.ListAllDoctors();
        }

        public static DataTable GetDoctorRecordFromDbByPersonID(int PersonID)
        {
            return clsGetDoctorRecord.GetDoctorByPersonID(PersonID) ; 
        }

        public static clsDoctor GetDoctorRecordFromDbAsObjectByPersonID(int PersonID)
        {
            DataTable table = GetDoctorRecordFromDbByPersonID(PersonID);
            
            clsDoctor? doctor = null;

            foreach(DataRow R in table.Rows)
            {
                DateTime datetime = Convert.ToDateTime(R["DateOfBirth"]);
                DateOnly dateonly = DateOnly.FromDateTime(datetime);

                doctor = new clsDoctor(Convert.ToInt32(R["PersonId"]), R["DoctorName"].ToString(),
                    dateonly ,
                    R["Gender"].ToString(), R["Address"].ToString(), R["Specialization"].ToString(),  R["Email"].ToString(),
                    R["PhoneNumber"].ToString() , Convert.ToInt32 (R["DoctorId"] )  );
            }

            return doctor;
        }

        public static clsDoctor GetDoctorRecordFromDbAsObjByDoctorID(int DoctorID)
        {
            DataTable table = clsGetDoctorRecord.GetDoctorByDoctorID(DoctorID);

            clsDoctor? doctor = null;

            foreach (DataRow R in table.Rows)
            {
                DateTime datetime = Convert.ToDateTime(R["DateOfBirth"]);
                DateOnly dateonly = DateOnly.FromDateTime(datetime);

                doctor = new clsDoctor(Convert.ToInt32(R["PersonId"]), R["DoctorName"].ToString(),
                    dateonly,
                    R["Gender"].ToString(), R["Address"].ToString(), R["Specialization"].ToString(), R["Email"].ToString(),
                    R["PhoneNumber"].ToString(), Convert.ToInt32(R["DoctorId"]));
            }

            return doctor;
        }


         bool AddNewDoctor()
        {

            return (clsInsertNewDoctor.InsertNewDoctor (   new clsInsertNewDoctor.DoctorInfo
            { Name= this.Name ,  DateOfBirth = this.DateOfBirth , Gender = this.Gender ,
                Address = this.Address , Email = this.Email, Phone = this.Phone , Specialization = this.Specialization }  )  != -1  );
           
        }

        public static bool DeleteDoctor(int PersonId)
        {
            return clsDeleteDoctor.DeleteDoctor(PersonId) ; // Not Implemented Yet
        }

        bool UpdateDoctor()
        {
            return ( clsUpdateDoctor.UpdateDoctor(this.PersonID, 
                new clsUpdateDoctor.DoctorInfo { Name=this.Name , Gender = this.Gender ,
                    Address = this.Address , DateOfBirth= this.DateOfBirth , 
                    Email = this.Email , Phone=this.Phone , Specialization = this.Specialization} )  );
        }

        public bool Save()
        {
            if (((String.IsNullOrEmpty(this.Name) || String.IsNullOrEmpty(this.Address) || String.IsNullOrEmpty(this.Gender) ||
         (this.DateOfBirth == null || this.DateOfBirth == DateOnly.FromDateTime(DateTime.MinValue) ||
             this.DateOfBirth==  DateOnly.FromDateTime(DateTime.Now)  )
             || String.IsNullOrEmpty(this.Email) || String.IsNullOrEmpty(this.Phone))))
            {
                return false;
            }


            switch (this.Status)
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


        public static clsDoctor FindDoctorByName(string Name)
        {
            DataTable table = clsFindDoctorByName.FindDoctorByName(Name);

            clsDoctor? doctor = null;

            foreach (DataRow R in table.Rows)
            {
                DateTime datetime = Convert.ToDateTime(R["DateOfBirth"]);
                DateOnly dateonly = DateOnly.FromDateTime(datetime);

                doctor = new clsDoctor(Convert.ToInt32(R["PersonId"]), R["DoctorName"].ToString(),
                     dateonly,
                     R["Gender"].ToString(), R["Address"].ToString(), R["Specialization"].ToString(), R["Email"].ToString(),
                     R["PhoneNumber"].ToString(), Convert.ToInt32(R["DoctorId"]));
            }

            return doctor;

        }



    }

}
