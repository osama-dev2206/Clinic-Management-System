using DataAccessLayer;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Access_Layer
{
    public static class clsInsertNewPatient
    {
        static string Query = @" Insert Into Person(Name,DateOfBirth,Gender,Address)
    values(@Name,@Date,@Gender,@Address);
     Insert Into Patient(PatientPersonId)
 values
 (
   (
   Select Person.PersonId 
   from Person 
   where Person.Name = @Name And 
   Person.Address = @Address And
   Person.DateOfBirth = @Date And
   Person.Gender = @Gender 
   )
 ) ; 
 Select SCOPE_IDENTITY();  ";

        struct Parameters
         {
            public string Name;
            public DateOnly DateOfBirth;
            public string Gender;
            public string Address;
           }

            private static SqlCommand cmd (ref SqlConnection Connection , Parameters stInfo)
        {
            SqlCommand Command = new SqlCommand (Query, Connection);
            Command.Parameters.AddWithValue("@Name", stInfo.Name);
            Command.Parameters.AddWithValue("@Date", stInfo.DateOfBirth);
            Command.Parameters.AddWithValue("@Gender", stInfo.Gender);
            Command.Parameters.AddWithValue("@Address", stInfo.Address);
            return Command;
        }


        public static int InsertNewPatient(string Name, DateOnly DateOfBirth, string Address ,string Gender)
        {
            SqlConnection connection = dbSettings.DbConnection();
            int LastInsertedId = -1;
            try
            {
                connection.Open();
                SqlCommand c = cmd(ref connection, new Parameters { Name = Name, DateOfBirth = DateOfBirth, Address = Address, Gender = Gender });

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
