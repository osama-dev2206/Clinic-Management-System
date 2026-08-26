using DataAccessLayer;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Net;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Data_Access_Layer
{
    public static class clsInsertNewDoctor
    {
        static string Query = @"  INSERT INTO Person(Name, DateOfBirth, Gender, Address)
VALUES(@Name, @Date, @Gender, @Address);

        INSERT INTO Doctor(DoctorPersonId, Specialization)
VALUES( (SELECT Person.PersonId
                      FROM   Person
                      WHERE  Person.Name = @Name
                             AND Person.Address = @Address
                             AND Person.DateOfBirth = @Date
                             AND Person.Gender = @Gender)    ,  @Specialization );

INSERT INTO Email(Email, PersonId)
VALUES(@Email, (SELECT Person.PersonId
                            FROM   Person
                            WHERE  Person.Name = @Name
                                   AND Person.Address = @Address
                                   AND Person.DateOfBirth = @Date
                                   AND Person.Gender = @Gender) );

INSERT INTO Phone(PhoneNumber, PersonId)
VALUES(@Phone, (SELECT Person.PersonId
                            FROM   Person
                            WHERE  Person.Name = @Name
                                   AND Person.Address = @Address
                                   AND Person.DateOfBirth = @Date
                                   AND Person.Gender = @Gender) );

SELECT SCOPE_IDENTITY(); ";


        public struct DoctorInfo
        {
            public string Name;
            public DateOnly DateOfBirth; 
            public string Address;
            public string Email;
            public string Phone;
            public string Gender;
        
            public string Specialization;
        }

        public static int InsertNewDoctor(DoctorInfo info)
        {
            int id = -1; 
            SqlConnection connection = dbSettings.DbConnection();
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Query, connection);
                command.Parameters.AddWithValue("@Name", info.Name);
                command.Parameters.AddWithValue("@Date", info.DateOfBirth);
                command.Parameters.AddWithValue("@Address", info.Address);
                 command.Parameters.AddWithValue("@Gender", info.Gender);
                command.Parameters.AddWithValue("@Specialization", info.Specialization);
                command.Parameters.AddWithValue("@Email", info.Email); 
                command.Parameters.AddWithValue("@Phone", info.Phone);

                object reader = command.ExecuteScalar();

                if (reader != null && int.TryParse(reader.ToString(), out int Res))
                {
                    id = Res;
                }

            }
            catch
            { }
            finally
            {
                connection.Close(); 
            }
            return id;
        }


        }
}
