using System;
using System.Collections.Generic;
using System.Text;

namespace MoveFiles
{
    public static class Bancomat_lca
    {
        const string _password = "88661";
        const decimal _amount = 2500;

        public static bool CheckPassword(string password)
        {
            bool res = false;

            if (CheckPasswordLength(password))
            {
                if (_password== password)
                {
                    res = true;
                }   
            }
        return res;
        }
        static bool CheckPasswordLength(string password)
        {
            bool res = false;

            if (password.Length==5)
            {
                res = true;
            }
            return res;
        }
        public static bool CheckAmount(decimal amount)
        {
            bool res = false;

            if (_amount>=amount)
            {
                res = true;
            }
 
            return res;
        }



    }
}
