using Bussiness_Logic_Layer;
using Data_Access_Layer;
using DataAccessLayer; 
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BussinessLogicLayer
{
    public  class clsAdmin  : abPerson
    {

      public  enum enPersmissions : byte
        { none = 1, ManagePatients = 2, ManageDoctors = 4, ManageAppointments = 8 , ManageAdmins=16 }

        public int Permissions { get; set; }
        public string UserName { get; set; }

        public string AdminPassword { get; set; }

        public int AdminId { get; private set; }

        enObjectStatus status;

        // to Add  admin record to db
        public clsAdmin()
        {
            status = enObjectStatus.enAdd;
            Permissions = 0; // none permission 
        }

        private clsAdmin(int PersonId, string Username, string Pass, int Permissions, string Name, int Age, string Gender,
            string Address, string Email, string Phone, int AdminId)
        {
            this.PersonID = PersonId;
            this.UserName = Username;
            this.AdminPassword = Pass;
            this.Permissions = Permissions;
            this.Name = Name;
            this.Age = Age;
            this.Gender = Gender;
            this.Address = Address;
            this.Email = Email;
            this.Phone = Phone;
            this.AdminId = AdminId;

            this.status = enObjectStatus.enUpdate;
        }

        public static clsAdmin GetAdminByAdminId(int AdminId)
        {
            if (!int.TryParse(AdminId.ToString(), out _)) return null;

            DataTable dt = clsFindAdmin.FindAdminByAdminID(AdminId);
            clsAdmin admin = null;
            foreach (DataRow R in dt.Rows)
            {
                admin = new clsAdmin
                    (
                   Convert.ToInt32(R["PersonId"]),
                   R["UserName"].ToString(),
                   R["AdminPassword"].ToString(),
                   Convert.ToInt32(R["AdminPermissions"]),
                   R["Name"].ToString(),
                   Convert.ToInt32(R["Age"]),
                   R["Gender"].ToString(),
                   R["Address"].ToString(),
                   R["Email"].ToString(),
                   R["PhoneNumber"].ToString(),
                   Convert.ToInt32(R["AdminId"])
                    );

            }

            return admin;
        }

        public static clsAdmin GetAdminByPersonID(int PersonId)
        {
            if (!int.TryParse(PersonId.ToString(), out _)) return null;

            DataTable dt = clsFindAdmin.FindAdminByPersonID(PersonId);
            clsAdmin admin = null;
            foreach (DataRow R in dt.Rows)
            {
                admin = new clsAdmin
                    (
                   Convert.ToInt32(R["PersonId"]),
                   R["UserName"].ToString(),
                   R["AdminPassword"].ToString(),
                   Convert.ToInt32(R["AdminPermissions"]),
                   R["Name"].ToString(),
                   Convert.ToInt32(R["Age"]),
                   R["Gender"].ToString(),
                   R["Address"].ToString(),
                   R["Email"].ToString(),
                   R["PhoneNumber"].ToString(),
                   Convert.ToInt32(R["AdminId"])
                    );

            }

            return admin;
        }


        public static clsAdmin GetAdminByUserName(string UserName)
        {
            if (String.IsNullOrEmpty(UserName)) return null;

            DataTable dt = clsFindAdmin.FindAdminByUserName(UserName);
            clsAdmin admin = null;
            foreach (DataRow R in dt.Rows)
            {
                admin = new clsAdmin
                    (
                   Convert.ToInt32(R["PersonId"]),
                   R["UserName"].ToString(),
                   R["AdminPassword"].ToString(),
                   Convert.ToInt32(R["AdminPermissions"]),
                   R["Name"].ToString(),
                   Convert.ToInt32(R["Age"]),
                   R["Gender"].ToString(),
                   R["Address"].ToString(),
                   R["Email"].ToString(),
                   R["PhoneNumber"].ToString(),
                   Convert.ToInt32(R["AdminId"])
                    );

            }

            return admin;
        }

        public static bool CheckAdminLoginInfo(string UserName , string Password)
        {
            if(String.IsNullOrEmpty(UserName) && String.IsNullOrEmpty(Password)) 
                return false;

           return  AdminLoginDataAccess.CheckLoginCardenalites(UserName.Trim(), Password.Trim());
        }


        public void AssignPermissionToAdmin(enPersmissions persmission)
        {
            this.Permissions |=(int)persmission;
        }
        
        public  bool CheckPermission(enPersmissions persmission)
        {
            return (this.Permissions & (int)persmission) == (int)persmission; 
        }


        public static DataTable ListAllAdmins()
        {
            return clsListAllAdmins.ListAllAdmins();
        }

    }


}
