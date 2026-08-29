using DataAccessLayer;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Access_Layer
{
    public static class clsDeleteDoctor
    {


        readonly static string QueryDeleteDoctorRelatedRecords = @"

Delete AppointmentDoctorPatient
where AppointmentDoctorPatient.ADoctorId = 
(Select DoctorsFullDetails.DoctorId 
from DoctorsFullDetails
Where PersonId = @ID );

Delete Phone
Where 
Phone.PersonId = @ID;


Delete Email 
Where Email.PersonId = @ID;

Delete Doctor
Where Doctor.DoctorPersonId = @ID ;


    Delete Person
            Where Person.PersonId = @ID   ; "; 



        public static bool DeleteDoctor(int PersonID)
        {
            SqlConnection connection = dbSettings.DbConnection();
            bool res = false;
            
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(QueryDeleteDoctorRelatedRecords, connection);
                command.Parameters.AddWithValue("@ID", PersonID);

                object ExecutionResult = command.ExecuteNonQuery();

                if(ExecutionResult!=null && int.TryParse(ExecutionResult.ToString() , out int NumOfAffectedRows) 
                    && NumOfAffectedRows >0)
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
