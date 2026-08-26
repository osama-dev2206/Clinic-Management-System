using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness_Logic_Layer
{
    public class abPerson
    {
        public string Name { get; set; }
        public DateOnly DateOfBirth { get; set; }

        public string Gender { get; set; }

        public string Address { get; set; }

        public int Id { get; protected set; } // please note we depend on person id to get all patient details 

        public string Phone { get; set; }

        public string Email { get; set; }

        protected enum enObjectStatus : byte { enAdd = 1, enUpdate = 2 }
        
    }


}
