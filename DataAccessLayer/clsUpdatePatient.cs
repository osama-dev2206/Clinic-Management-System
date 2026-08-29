using DataAccessLayer;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Access_Layer
{
    public static class clsUpdatePatient
    {
        static string Query = @"-- person 
Update Person Set
Person.Name = @Name , Person.Gender = @Gender ,
Person.Address = @Address, Person.DateOfBirth = @DateOfBirth
where Person.PersonId = @ID

-- Email
Update Email Set
Email.Email = @Email
Where Email.PersonId = @ID
-- Phone
Update Phone Set 
PhoneNumber = @Phone
Where Phone.PersonId = @ID ;" ; 

        public static bool UpdatePatientByPersonID(int PersonID,string Name , string Gender , 
            string Address,DateOnly DateOfBirth , string Email , string Phone )
        {
            bool Res = false;
            SqlConnection connection = dbSettings.DbConnection();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@ID", PersonID);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Gender", Gender);
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Phone", Phone);



                if (int.TryParse(cmd.ExecuteNonQuery().ToString() , out int NumOfAffectedRows) && NumOfAffectedRows>0 )
                    Res = true;
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return Res; 
        }

    }

}
