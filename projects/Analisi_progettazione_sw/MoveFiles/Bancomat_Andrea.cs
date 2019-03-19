using System;
using System.Collections.Generic;
using System.Text;

namespace MoveFiles
{
    public static class Bancomat_Andrea
    {
        const string code = "88661";
        const double money = 50000;
        public static bool CheckPassword(string password)
        {
            bool response = false;
            if (CheckPasswordLength(password))
            {
                if (code == password)
                {
                    response = true;
                }           
            }
            return response;
        }
        static bool CheckPasswordLength(string password)
        {
            bool response = false;
            if (password.Length == 5)
            {
                response = true;
            }
            return response;
        }
    }
}
