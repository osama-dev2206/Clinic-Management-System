using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness_Logic_Layer
{
    public class clsAdmin : abPerson
    {
        enum enPersmissions : byte
        { none = 1, ManagePatients = 2, ManageDoctors = 4, ManageAppointments = 8 }

       public int Permissions { get; set; }
       public string UserName { get; set; }

        public string AdminPassword { get; set; }

        public int AdminId { get; private set; }

        enObjectStatus status; 

        // to Add  admin record to db
        public clsAdmin()
        {
            status = enObjectStatus.enAdd;
        }

        private clsAdmin(int PersonId, string Username , string Pass , int Permissions , string Name ,DateOnly DateOfBirth , string Gender ,
            string Address , string Email , string Phone , int AdminId)
        {
            this.PersonID = PersonId;
            this.UserName = Username;
            this.AdminPassword = Pass;
            this.Permissions = Permissions;
            this.Name = Name;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
            this.Address = Address;
            this.Email = Email;
            this.Phone = Phone;
            this.AdminId = AdminId;

            this.status = enObjectStatus.enUpdate;
        }




    }

}
