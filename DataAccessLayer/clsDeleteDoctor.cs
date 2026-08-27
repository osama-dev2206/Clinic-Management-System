using DataAccessLayer;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Access_Layer
{
    public static class clsDeleteDoctor
    {
        private static int GetPersonIDAsDoctor(int PersonId)
        {
            SqlConnection connection = dbSettings.DbConnection();
            const string query = @"
             Select DoctorPersonID.DocID 
            from DoctorPersonID
             Where DocID = @ID ";

            int res = -1;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ID", PersonId);
                object id = cmd.ExecuteScalar(); // as the res will be single value 

                if (id != null && int.TryParse(id.ToString(), out int ValidID))
                {
                    res = ValidID;
                }

            }
            catch
            { }
            finally
            {
                connection.Close();
            }

            return res;
        }

        private static bool DeletePersonAsDoctor(int PersonId)
        {
            SqlConnection connection = dbSettings.DbConnection();
            const string Query = @"Delete Person
            Where Person.PersonId = @ID ;";

            bool res = false;
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Query, connection);
                command.Parameters.AddWithValue("@ID", PersonId);


                if (int.TryParse(command.ExecuteNonQuery().ToString(), out int numberOfRowsAffected))
                {
                    res = (numberOfRowsAffected > 0);
                }

            }
            catch { }
            finally { connection.Close(); }

            return res;
        }


        readonly static string QueryDeleteDoctorRelatedRecords = @"
Delete Phone
Where 
Phone.PersonId =
(Select DoctorPersonID.DocID 
from DoctorPersonID
Where DocID = @ID );


Delete Email 
Where Email.PersonId = 
(Select DoctorPersonID.DocID 
from DoctorPersonID
Where DocID = @ID );


Delete Appointment
where Appointment.APatientId = 
(Select DoctorPersonID.DocID 
from DoctorPersonID
Where DocID = @ID );

Delete Doctor
Where Doctor.DoctorPersonId = 
(Select DoctorPersonID.DocID 
from DoctorPersonID
Where DocID = @ID  );";


        //1.we will delete all the records related to this doctor in the database(Email,Phone,etc... )
        //2. we will delete the person that is related to this doctor in the database (Person table)

        public static bool DeleteDoctor(int PersonID)
        {
            SqlConnection connection = dbSettings.DbConnection();
            bool res = false;
            int PersonAsDoctorID = GetPersonIDAsDoctor(PersonID);

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(QueryDeleteDoctorRelatedRecords, connection);
                command.Parameters.AddWithValue("@ID", PersonID);

                object ExecutionResult = command.ExecuteNonQuery();

                if(ExecutionResult!=null && int.TryParse(ExecutionResult.ToString() , out int NumOfAffectedRows) 
                    && NumOfAffectedRows >0)
                {
                    res = DeletePersonAsDoctor(PersonAsDoctorID);
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
