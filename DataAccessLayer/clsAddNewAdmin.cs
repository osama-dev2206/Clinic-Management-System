using DataAccessLayer;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace Data_Access_Layer
{
    public static class clsAddNewAdmin
    {
        static readonly string Query = @"
INSERT  INTO Person (Name, DateOfBirth, Gender, Address)
VALUES             (@Name, @Date, @Gender, @Address);

insert Into AdminLogin(AdminPassword , AdminPermissions , UserName , AdminPersonId)
values(@AdminPassword , @AdminPermission , @UserName , 
 (SELECT Person.PersonId
                            FROM   Person
                            WHERE  Person.Name = @Name
                                   AND Person.Address = @Address
                                   AND Person.DateOfBirth = @Date
                                   AND Person.Gender = @Gender)    )
); 

INSERT  INTO Email (Email, PersonId)
VALUES            (@Email, (SELECT Person.PersonId
                            FROM   Person
                            WHERE  Person.Name = @Name
                                   AND Person.Address = @Address
                                   AND Person.DateOfBirth = @Date
                                   AND Person.Gender = @Gender));

INSERT  INTO Phone (PhoneNumber,PersonId)
VALUES            (@Phone, (SELECT Person.PersonId
                            FROM   Person
                            WHERE  Person.Name = @Name
                                   AND Person.Address = @Address
                                   AND Person.DateOfBirth = @Date
                                   AND Person.Gender = @Gender));

SELECT SCOPE_IDENTITY(); ";



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


        public static int AddNewAdmin(AdminInfo info)
        {
            SqlConnection connection = dbSettings.DbConnection();
            int ScopeIdentity = -1;

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Query, connection);
                command.Parameters.AddWithValue("@UserName", info.UserName);
                command.Parameters.AddWithValue("@AdminPassword", info.AdminPassword);
                command.Parameters.AddWithValue("@AdminPermission", info.AdminPermission);
                command.Parameters.AddWithValue("@Name", info.Name);
                command.Parameters.AddWithValue("@Date", info.DateOfBirth);
                command.Parameters.AddWithValue("@Gender", info.Gender);
                command.Parameters.AddWithValue("@Address", info.Address);
                command.Parameters.AddWithValue("@Email", info.Email);
                command.Parameters.AddWithValue("@Phone", info.Phone);

                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int ID) )
                {
                    ScopeIdentity= ID;
                }

            }
            catch { }
            finally
            {
                connection.Close();
            }

            return ScopeIdentity;
        }


    }


}
