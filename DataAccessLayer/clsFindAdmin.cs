using DataAccessLayer;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Data_Access_Layer
{
    public static class clsFindAdmin
    {
        enum enFindAdminBy : byte
        {
            ByPersonId = 1,
            ByAdminId = 2,
            ByUserName = 3 
        }

        static string Query(enFindAdminBy enFind)
        {
            switch(enFind)
            {
                case enFindAdminBy.ByPersonId:
                    return @" select * from AdminFullInfo
                 where AdminFullInfo.PersonId =@PersonId ;";

                case enFindAdminBy.ByAdminId:
                    return @"   select * from AdminFullInfo
              where AdminFullInfo.AdminId = @AdminId; ";

                    case enFindAdminBy.ByUserName:
                    return @"      select * from AdminFullInfo
                where AdminFullInfo.UserName = @UserName ; ";

            }

            return "";
        }


        public static DataTable FindAdminByPersonID(int PersonId)
        {
            SqlConnection connection = dbSettings.DbConnection();
            DataTable dataTable = new DataTable();

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query(enFindAdminBy.ByPersonId), connection);
                cmd.Parameters.AddWithValue("@PersonId", PersonId);    

                SqlDataReader reader = cmd.ExecuteReader();

                if(reader.HasRows) dataTable.Load(reader);
                reader.Close();

            }
            catch { }
            finally { connection.Close(); }

            return dataTable;

        }


        public static DataTable FindAdminByAdminID(int AdminId)
        {
            SqlConnection connection = dbSettings.DbConnection();
            DataTable dataTable = new DataTable();

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query(enFindAdminBy.ByAdminId), connection);
                cmd.Parameters.AddWithValue("@AdminId", AdminId);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows) dataTable.Load(reader);
                reader.Close();

            }
            catch { }
            finally { connection.Close(); }

            return dataTable;
        }


        public static DataTable FindAdminByUserName(string UserName)
        {
            SqlConnection connection = dbSettings.DbConnection();
            DataTable dataTable = new DataTable();

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query(enFindAdminBy.ByUserName), connection);
                cmd.Parameters.AddWithValue("@UserName", UserName);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows) dataTable.Load(reader);
                reader.Close();

            }
            catch { }
            finally { connection.Close(); }

            return dataTable;
        }



    }
}
