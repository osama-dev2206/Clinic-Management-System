using DataAccessLayer;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Access_Layer
{
    public static class clsAddNewAppointment
    {

        readonly private static string Query = @"Insert Into AppointmentDoctorPatient(ADoctorId,APatientId,AppointmentDateTime,AppoitmentStatus)
          values 
        (@DoctorId , @PatientId , @DateTime , @Status  );
          Select SCOPE_IDENTITY(); ";

        public static bool AddNewAppointment(int DoctorId , int PatientId , DateTime dateTime , string Status)
        {
            SqlConnection connection = dbSettings.DbConnection();
            bool res = false;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@DoctorId", DoctorId);
                cmd.Parameters.AddWithValue("@PatientId", PatientId);
                cmd.Parameters.AddWithValue("@DateTime", dateTime);
                cmd.Parameters.AddWithValue("@Status", Status);

                object Reader = cmd.ExecuteScalar();
                if (Reader != null && int.TryParse(Reader.ToString(), out int _))
                {
                    res = true;
                }

            }
            catch { }
            finally { connection.Close(); }

            return res;

        }

    }



}
