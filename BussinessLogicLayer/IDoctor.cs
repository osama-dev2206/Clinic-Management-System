using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Bussiness_Logic_Layer
{
    public interface IDoctor
    {
        
        protected bool AddNewDoctor();

        public  bool DeleteDoctor(int PersonDoctorId);

        protected  bool UpdateDoctor();

        public bool Save();


    }

}
