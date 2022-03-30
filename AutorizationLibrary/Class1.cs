using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutorizationLibrary
{
    public static class AutorizationClass
    {
        public static bool CheckValues(string login,string password)
        {
            if (login == "admin" && password == "admin")
            {
                return true;
            }
            else return false;
        }
    }
}
