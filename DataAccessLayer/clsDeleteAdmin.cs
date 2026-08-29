using DataAccessLayer;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Access_Layer
{
    public static class clsDeleteAdmin
    {
        static readonly string Query = @"
Delete Phone
Where 
Phone.PersonId = @ID;


Delete Email 
Where Email.PersonId = @ID;

Delete AdminLogin
where AdminLogin.AdminPersonId =@ID ;

Delete Person
where Person.PersonId = @ID ;";

        public static bool DeleteAdmin(int PersonId)
        {
            if (PersonId == 9) return false; ///  you cann't delete the main admin !!! 
            SqlConnection connection = dbSettings.DbConnection();
            bool res = false;

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);

                cmd.Parameters.AddWithValue("@ID", PersonId);

                if (cmd.ExecuteNonQuery() > 0)
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
