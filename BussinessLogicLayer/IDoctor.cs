using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Bussiness_Logic_Layer
{
    public interface IDoctor
    {
        DataTable GetDoctorRecordFromDb(int PersonID);

        DataTable ListAllDoctors();

        bool AddNewDoctor();

        bool DeleteDoctor(int PersonDoctorId);

        bool UpdateDoctor();

        bool Save();


    }

}
