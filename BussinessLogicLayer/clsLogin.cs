using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer; 

namespace BussinessLogicLayer
{
    public static  class clsLogin
    {

        public static bool CheckLogin(string UserName , string Password)
        {
            if(String.IsNullOrEmpty(UserName) && String.IsNullOrEmpty(Password)) 
                return false;

           return  AdminLoginDataAccess.CheckLoginCardenalites(UserName.Trim(), Password.Trim());
        }

    }


}
