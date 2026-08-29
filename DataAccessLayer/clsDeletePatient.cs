using DataAccessLayer;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Access_Layer
{
    public static class clsDeletePatient
    {
        private static string query = @"Delete AppointmentDoctorPatient
where AppointmentDoctorPatient.APatientId = 
(Select PatientFullDetails.PatientId 
from PatientFullDetails
Where PersonId = @ID );

Delete Phone
Where 
Phone.PersonId = @ID;


Delete Email 
Where Email.PersonId = @ID;

Delete Patient
Where Patient.PatientPersonId = @ID ;


    Delete Person
            Where Person.PersonId = @ID ;";


        public static bool DeletePatient(int PersonId)
        {
            int AffectedRows = 0;
            bool res = false;
            SqlConnection connection = dbSettings.DbConnection();

            try
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ID", PersonId);

                AffectedRows = cmd.ExecuteNonQuery();

                if (AffectedRows > 0)
                {
                    res = true;
                }
            }
            catch
            {
                res= false;
            }

            finally
            {
                connection.Close();
            }

            return res;
        }


    }
}
