using System;
using System.Collections.Generic;
using System.Text;
using Bussiness_Logic_Layer;
using DataAccessLayer; 

namespace BussinessLogicLayer
{
    public   class clsLogin 
    {

        public static bool CheckLoginInfo(string UserName , string Password)
        {
            if(String.IsNullOrEmpty(UserName) && String.IsNullOrEmpty(Password)) 
                return false;

           return  AdminLoginDataAccess.CheckLoginCardenalites(UserName.Trim(), Password.Trim());
        }




    }


}
