using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
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

        public clsDoctor()  // Constructor for Adding New Doctor
        {
            this.Status = enObjectStatus.enAdd;
        }

        private clsDoctor(int PersonID, string Name, DateOnly DateOfBirth, string Gender, string Address, string Specialization, string Email, string Phone) // Constructor for Updating Doctor
        {
            this.Id = PersonID;
            this.Name = Name;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
            this.Address = Address;
            this.Email = Email;
            this.Phone = Phone;
            this.Specialization = Specialization;

            this.Status = enObjectStatus.enUpdate;
        }

        public static DataTable ListAllDoctors()
        {
          return clsListAllDoctors.ListAllDoctors();
        }

        public static DataTable GetDoctorRecordFromDb(int PersonID)
        {
            return clsGetDoctorRecordByPersonId.GetDoctorByPersonID(PersonID) ; 
        }

        public static clsDoctor GetDoctorRecordFromDbAsObject(int PersonID)
        {
            DataTable table = GetDoctorRecordFromDb(PersonID);
            
            clsDoctor? doctor = null;

            foreach(DataRow R in table.Rows)
            {
                DateTime datetime = Convert.ToDateTime(R["DateOfBirth"]);
                DateOnly dateonly = DateOnly.FromDateTime(datetime);

                doctor = new clsDoctor(Convert.ToInt32(R["PersonId"]), R["DoctorName"].ToString(),
                    dateonly ,
                    R["Gender"].ToString(), R["Address"].ToString(), R["Specialization"].ToString(),  R["Email"].ToString(),
                    R["PhoneNumber"].ToString());
            }

            return doctor;
        }

         bool AddNewDoctor()
        {
            return (clsInsertNewDoctor.InsertNewDoctor (   new clsInsertNewDoctor.DoctorInfo
            { Name= this.Name ,  DateOfBirth = this.DateOfBirth , Gender = this.Gender ,
                Address = this.Address , Email = this.Email, Phone = this.Phone , Specialization = this.Specialization }  )  != -1  );
           
        }

        public static bool DeleteDoctor(int PersonDoctorId)
        {
            return false; // Not Implemented Yet
        }

        bool UpdateDoctor()
        {
            return ( clsUpdateDoctor.UpdateDoctor(this.Id, 
                new clsUpdateDoctor.DoctorInfo { Name=this.Name , Gender = this.Gender ,
                    Address = this.Address , DateOfBirth= this.DateOfBirth , 
                    Email = this.Email , Phone=this.Phone , Specialization = this.Specialization} )  );
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
