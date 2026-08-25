using DataAccessLayer;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Data_Access_Layer
{
    public static class clsInsertNewPatient
    {
        static string Query = @"
INSERT  INTO Person (Name, DateOfBirth, Gender, Address)
VALUES             (@Name, @Date, @Gender, @Address);

INSERT  INTO Patient (PatientPersonId)
VALUES              ((SELECT Person.PersonId
                      FROM   Person
                      WHERE  Person.Name = @Name
                             AND Person.Address = @Address
                             AND Person.DateOfBirth = @Date
                             AND Person.Gender = @Gender));

INSERT  INTO Email (Email, Email.PersonId)
VALUES            (@Email, (SELECT Person.PersonId
                            FROM   Person
                            WHERE  Person.Name = @Name
                                   AND Person.Address = @Address
                                   AND Person.DateOfBirth = @Date
                                   AND Person.Gender = @Gender));

INSERT  INTO Phone (PhoneNumber, Phone.PersonId)
VALUES            (@Phone, (SELECT Person.PersonId
                            FROM   Person
                            WHERE  Person.Name = @Name
                                   AND Person.Address = @Address
                                   AND Person.DateOfBirth = @Date
                                   AND Person.Gender = @Gender));

SELECT SCOPE_IDENTITY();  ";

        struct Parameters
         {
            public string Name;
            public DateOnly DateOfBirth;
            public string Gender;
            public string Address;
            public string Phone;
            public string Email;

           }

            private static SqlCommand cmd (ref SqlConnection Connection , Parameters stInfo)
        {
            SqlCommand Command = new SqlCommand (Query, Connection);
            Command.Parameters.AddWithValue("@Name", stInfo.Name);
            Command.Parameters.AddWithValue("@Date", stInfo.DateOfBirth);
            Command.Parameters.AddWithValue("@Gender", stInfo.Gender);
            Command.Parameters.AddWithValue("@Address", stInfo.Address);
            Command.Parameters.AddWithValue("@Phone", stInfo.Phone);
            Command.Parameters.AddWithValue("@Email", stInfo.Email);
            return Command;
        }


        public static int InsertNewPatient(string Name, DateOnly DateOfBirth, string Address ,string Gender,string Phone , string Email)
        {
            SqlConnection connection = dbSettings.DbConnection();
            int LastInsertedId = -1;
            try
            {
                connection.Open();
                SqlCommand c = cmd(ref connection, new Parameters { Name = Name, DateOfBirth = DateOfBirth, Address = Address, Gender = Gender,Phone=Phone , Email =Email });

                object Res  = c.ExecuteScalar();

                if (Res != null && int.TryParse(Res.ToString() , out int id )) 
                {
                    LastInsertedId = id;
                }

            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return LastInsertedId;
        }

    }
}
