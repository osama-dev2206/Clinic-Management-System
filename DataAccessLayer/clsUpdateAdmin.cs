using DataAccessLayer;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Access_Layer
{
    public static class clsUpdateAdmin
    {
       static string  Query = @"-- person 
Update Person Set
Person.Name = @Name , Person.Gender = @Gender ,
Person.Address = @Address , Person.DateOfBirth = @DateOfBirth 
where Person.PersonId = @ID

-- Email
Update Email Set
Email.Email = @Email
Where Email.PersonId = @ID

-- Phone
Update Phone Set 
PhoneNumber = @Phone
Where Phone.PersonId = @ID

-- Admin
Update AdminLogin
Set UserName = @UserName ,
AdminPassword =@Pass ,
AdminPermissions = @Permission 
where AdminPersonId =  @ID  ; ";

        public struct AdminInfo
        {
            public string UserName;
            public string AdminPassword;
            public int AdminPermission;

            public string Name;
            public DateOnly DateOfBirth;

            public string Gender;

            public string Address;
            public string Email;

            public string Phone;


        }


        public static bool UpdateAdmin(int PersonId , AdminInfo info )
        {
            SqlConnection connection =  dbSettings.DbConnection();
            bool res = false;

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand( Query, connection );   
                cmd.Parameters.AddWithValue( "@ID", PersonId );
                cmd.Parameters.AddWithValue("@Name", info.Name);
                cmd.Parameters.AddWithValue("@Gender", info.Gender);
                cmd.Parameters.AddWithValue("@Address", info.Address);
                cmd.Parameters.AddWithValue("@DateOfBirth", info.DateOfBirth);
                cmd.Parameters.AddWithValue("@Email", info.Email);
                cmd.Parameters.AddWithValue("@Phone", info.Phone);
                cmd.Parameters.AddWithValue("@UserName", info.UserName);
                cmd.Parameters.AddWithValue("@Pass", info.AdminPassword);
                cmd.Parameters.AddWithValue("@Permission", info.AdminPermission);

                var Result = cmd.ExecuteNonQuery();

                if (Result != 0)
                {
                    res = true;
                }

            }
            catch { }
            finally
            {
                connection.Close();
            }

            return res;

        }

    }
}
