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

        enum enObjectStatus : byte   {enAdd=1 , enUpdate = 2  }
        enObjectStatus Status; 

        public clsPatient() // Add New Patient Constructor
        {  
            this.Status = enObjectStatus.enAdd;
        }

        public static DataTable ListAllPatients()
        {
            return clsListAllPatients.ListAllPatients();
        }

        private bool AddNewPatient()
        {
            int ID = clsInsertNewPatient.InsertNewPatient(this.Name, this.DateOfBirth, this.Address, this.Gender);
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
