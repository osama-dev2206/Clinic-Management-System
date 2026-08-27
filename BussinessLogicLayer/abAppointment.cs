using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness_Logic_Layer
{
    public class abAppointment
    {
        public enum enMode { Add = 1, Update = 2 }
        public  int AppointmentId {  get; set; }
         
        public int ADoctorId { get; set; }

        public int APatientId { get; set; }

        public DateTime AppointmentDateTime { get; set; }

        public string  AppointmentStatus { get; set; }

        public int PatientPersonId { get; set; }

        public int DoctorPersonId { get; set; }
    }
}
