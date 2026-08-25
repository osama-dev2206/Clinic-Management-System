using System;
using Microsoft.Data.SqlClient;
namespace DataAccessLayer
{
    // Data Access Class for Check Login Caredinalties 
    public static class AdminLoginDataAccess
    {

        private static string Query = @" Select  R= 'T' 
         From AdminLogin 
         where AdminPassword = @Password
         and UserName = @UserName ;";

        public static bool CheckLoginCardenalites(string username , string password)
        {
            bool res = false;
            SqlConnection Connection = dbSettings.DbConnection();
            try
            {
                Connection.Open(); // open the sql server connection 

                SqlCommand cmd = new SqlCommand(Query, Connection);
                cmd.Parameters.AddWithValue("@UserName", username);
                cmd.Parameters.AddWithValue("@Password", password);

              object Reader = cmd.ExecuteScalar(); // will execute the query then returns T if the record exists 

                if(Reader !=null && Reader.ToString() == "T" )
                {
                    res = true;
               }
         Connection.Close(); // close the sql server connection
          
            }
            catch (Exception e)
            {
                res = false;
            
            }
            finally
            {
            Connection.Close(); // close the sql server connection
            }


            return res;
        }

    }


}
