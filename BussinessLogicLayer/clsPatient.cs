using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Bussiness_Logic_Layer
{
    public  class clsPatient : abPerson
    {
        enObjectStatus Status; 

        public clsPatient() // Add New Patient Constructor
        {  
            this.Status = enObjectStatus.enAdd;
        }

        // To Get Patient As DataTable  From Db 
        public int PatinetId {  get; set; }

        private clsPatient(int PatinetId , int PersonID,string Name , string Email ,string Phone , string Gender , DateOnly dateOfBirth , string Address)
        {
            this.PatinetId = PatinetId;
            this.PersonID = PersonID;
            this.Name = Name;
            this.Email = Email;
            this.Phone = Phone;
            this.Gender = Gender;
            this.DateOfBirth = dateOfBirth;
            this.Address = Address;
            this.Status = enObjectStatus.enUpdate;
        }


        public static clsPatient ? FindPatientByPersonID(int PersonID)
        {
            if (!int.TryParse(PersonID.ToString(), out _)) return null;

            DataTable dt = clsFindPatientByID.FindPatinetByPersonID(PersonID); // get record of patient from database as DataTable

            clsPatient patient =null;
            foreach (DataRow R in dt.Rows)
           {
                DateTime datetime = Convert.ToDateTime(R["DateOfBirth"]);
                DateOnly dateonly  = DateOnly.FromDateTime(datetime);

                patient = new clsPatient(Convert.ToInt32(R["PatientId"]) ,
                Convert.ToInt32(R["PersonId"]),R["Name"].ToString(), R["Email"].ToString(), R["PhoneNumber"].ToString(), R["Gender"].ToString(), 
                dateonly, R["Address"].ToString());
            }

            return patient;
        }

        public static  DataTable GetPatientRecordFromDb(int PersonID)
        {
            return clsFindPatientByID.FindPatinetByPersonID(PersonID);
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

         private  bool UpdatePatient()
        {
            return clsUpdatePatient.UpdatePatientByPersonID(this.PersonID , Name:this.Name , Gender: this.Gender ,
                Address: this.Address , DateOfBirth: this.DateOfBirth , Email : this.Email , Phone: this.Phone   );
        }


        public bool Save()
        {

            if (((String.IsNullOrEmpty(this.Name) || String.IsNullOrEmpty(this.Address) || String.IsNullOrEmpty(this.Gender) ||
(this.DateOfBirth == null || this.DateOfBirth == DateOnly.FromDateTime(DateTime.MinValue) ||
 this.DateOfBirth == DateOnly.FromDateTime(DateTime.Now))
 || String.IsNullOrEmpty(this.Email) || String.IsNullOrEmpty(this.Phone))))
            {
                return false;
            }

            switch (this.Status)
            {
                case  enObjectStatus.enAdd:
                    if (AddNewPatient()) return true;
                    Status = enObjectStatus.enUpdate; 
                    break;

                case enObjectStatus.enUpdate:
                   if (UpdatePatient() ) return true;
                    break;
            }

            return false;
        }


        public  static clsPatient FindPatientByName(string Name)
        {

            if (String.IsNullOrEmpty(Name)) return null;

            DataTable dt = clsGetPatientRecordByName.GetPatientRecordByName(Name); // get record of patient from database as DataTable

            clsPatient patient = null;
            foreach (DataRow R in dt.Rows)
            {
                DateTime datetime = Convert.ToDateTime(R["DateOfBirth"]);
                DateOnly dateonly = DateOnly.FromDateTime(datetime);

                patient = new clsPatient(Convert.ToInt32(R["PatientId"]), 
                Convert.ToInt32(R["PersonId"]), R["Name"].ToString(), R["Email"].ToString(), R["PhoneNumber"].ToString(), R["Gender"].ToString(),
                dateonly, R["Address"].ToString());
            }

            return patient;

        }




    }
}
