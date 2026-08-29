using DataAccessLayer;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Data_Access_Layer
{
    public static class clsListAllAdmins
    {
        private readonly static string Query = @" select * from AdminFullInfo; ";
  
        public static DataTable ListAllAdmins()
        {
            SqlConnection connection = dbSettings.DbConnection();
            DataTable dataTable = new DataTable();

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataReader sqlData = command.ExecuteReader();

                if(sqlData.HasRows) dataTable.Load(sqlData);
                
                sqlData.Close();

            }
            catch
            { }

            finally
            {
                connection.Close();
            }

            return dataTable;
        }

    }
}
