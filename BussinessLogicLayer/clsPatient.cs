using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Bussiness_Logic_Layer
{
    public  class clsPatient
    {
        public string Name { get; set; }
        public DateOnly DateOfBirth { get; set; }

        public string Gender { get; set; }

        public string Address { get; set; }

        public int Id { get; private set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        enum enObjectStatus : byte   {enAdd=1 , enUpdate = 2  }
        enObjectStatus Status; 

        public clsPatient() // Add New Patient Constructor
        {  
            this.Status = enObjectStatus.enAdd;
        }

        // To Get Patient As DataTable  From Db 
        private clsPatient(int PatinetID,string Name , string Email ,string Phone , string Gender , DateOnly dateOfBirth , string Address)
        {
            this.Id = PatinetID;
            this.Name = Name;
            this.Email = Email;
            this.Phone = Phone;
            this.Gender = Gender;
            this.DateOfBirth = dateOfBirth;
            this.Address = Address;
            this.Status = enObjectStatus.enUpdate;
        }


        public clsPatient ? FindPatientByID(int PatientId)
        {
            if (!int.TryParse(PatientId.ToString(), out _)) return null;

            DataTable dt = clsFindPatientByID.FindPatinetByID(PatientId); // get record of patient from database as DataTable

            DateTime dateTime = Convert.ToDateTime(dt.Columns["DateOFBirth"].ToString() + " 1:1:1 PM" ) ;
            DateOnly dateonly = DateOnly.FromDateTime(dateTime);

            return new clsPatient(
                Convert.ToInt32(dt.Columns["PatientId"]) ,
                dt.Columns["Name"].ToString() ,
                dt.Columns["Email"].ToString(),
                dt.Columns["PhoneNumber"].ToString(),
               dt.Columns["Gender"].ToString(),
                 dateonly,
               dt.Columns["Address"].ToString()
          );

        }

        public static  DataTable GetPatientRecordFromDb(int PatinetID)
        {
            return clsFindPatientByID.FindPatinetByID(PatinetID);
        }

        public static DataTable ListAllPatients()
        {
            return clsListAllPatients.ListAllPatients();
        }

        private bool AddNewPatient()
        {
            int ID = clsInsertNewPatient.InsertNewPatient(this.Name, this.DateOfBirth, this.Address, this.Gender,this.Phone,this.Email);
            return (ID != -1); 
        }

        public static bool Delete(int PersonPatinetId)
        {
            if(!int.TryParse(PersonPatinetId.ToString(), out int id))
            {
                return false; 
            }
            return clsDeletePatient.DeletePatient(PersonPatinetId);
        }

        public bool Save()
        {
            switch(this.Status)
            {
                case  enObjectStatus.enAdd:
                    if (AddNewPatient()) return true;
                    Status = enObjectStatus.enUpdate; 
                    break;
            }

            return false;
        }

    }
}
