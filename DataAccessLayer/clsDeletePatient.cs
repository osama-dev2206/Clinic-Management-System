using DataAccessLayer;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Access_Layer
{
    public static class clsDeletePatient
    {
        private static string query = @"Delete Phone
Where Phone.PersonId = (Select Patient.PatientPersonId 
from Person
Inner Join Patient  On Patient.PatientPersonId = PersonId
Where Patient.PatientPersonId = @ID )


Delete Email 
Where Email.PersonId = (Select Patient.PatientPersonId 
from Person
Inner Join Patient  On Patient.PatientPersonId = PersonId
Where Patient.PatientPersonId = @ID )


Delete Appointment
where Appointment.APatientId = (Select Patient.PatientPersonId 
from Person
Inner Join Patient  On Patient.PatientPersonId = PersonId
Where Patient.PatientPersonId = @ID )

Delete Patient
Where Patient.PatientPersonId= 
(Select Patient.PatientPersonId 
from Person
Inner Join Patient  On Patient.PatientPersonId = PersonId
Where Patient.PatientPersonId = @ID ) ;";

        // the person cann't be deleted at first as all tables are related to it 
        // so we will delete the person that is related to the patient after deleting the patient and all related records
        private static int GetThePersonOfPatient(int PersonPatinetId)
        {
            string query = @" Select Person.PersonId 
         From Person
     Inner Join Patient 
      On Patient.PatientPersonId = Person.PersonId
     where Patient.PatientPersonId = @ID;";
            int res = 0;
            SqlConnection connection = dbSettings.DbConnection();
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", PersonPatinetId);

                object result = command.ExecuteScalar();
                if(result != null && result != DBNull.Value)
                {
                    res = Convert.ToInt32(result);
                }
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return res;
        }

        private static bool DeletePerson(int PersonPatinetId)
        {
            string query = @" Delete Person 
            where PersonId = @ID; ";

            SqlConnection connection = dbSettings.DbConnection();
            int AffectedRows = -1;
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", PersonPatinetId);

                AffectedRows = command.ExecuteNonQuery();
      
            }
            catch { }
            finally
            { 
                connection.Close(); 
            }

            return (AffectedRows > 0);
        }

        public static bool DeletePatient(int PersonPatinetId)
        {
            int AffectedRows = 0;
            bool res = false;
            SqlConnection connection = dbSettings.DbConnection();

            int PersonPatientId = GetThePersonOfPatient(PersonPatinetId); // to delete person later if the patient is deleted

            try
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ID", PersonPatinetId);

                AffectedRows = cmd.ExecuteNonQuery();

                if(AffectedRows>0)
                    res= true;

                DeletePerson(PersonPatientId); // to delete the person after deleting the patient and related records
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
