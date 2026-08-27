using DataAccessLayer;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Access_Layer
{
    public static class clsUpdateDoctor
    {
        static string Query = @"
----- person 
Update Person Set
Person.Name = @Name , Person.Gender = @Gender ,
Person.Address = @Address , Person.DateOfBirth = @DateOfBirth 
where Person.PersonId = @ID ;

-- Email
Update Email Set
Email.Email = @Email
Where Email.PersonId = @ID ;

-- Phone
Update Phone Set 
PhoneNumber = @Phone
Where Phone.PersonId = @ID ;

-- Specialization
Update Doctor Set
Specialization = @Specialization
Where Doctor.DoctorPersonId = @ID  ;"  ;

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

        public static bool UpdateDoctor(int PersonId,DoctorInfo info)
        {
         
            SqlConnection connection = dbSettings.DbConnection();
            bool result = false;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@ID", PersonId);
                cmd.Parameters.AddWithValue("@Name", info.Name);
                cmd.Parameters.AddWithValue("@Gender", info.Gender);
                cmd.Parameters.AddWithValue("@Address", info.Address);
                cmd.Parameters.AddWithValue("@DateOfBirth", info.DateOfBirth);
                cmd.Parameters.AddWithValue("@Email", info.Email);
                cmd.Parameters.AddWithValue("@Phone", info.Phone);
                cmd.Parameters.AddWithValue("@Specialization", info.Specialization);

              
               

                if (int.TryParse(cmd.ExecuteNonQuery().ToString(), out  int NumOfAffectedRows ))
                {
                    if(NumOfAffectedRows > 1) result = true;
                }

            }
            catch { }
            finally
            {
                connection.Close();
            }

            return result;
        }



    }
}
