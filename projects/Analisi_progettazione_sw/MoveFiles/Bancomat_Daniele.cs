using System;
using System.Collections.Generic;
using System.Text;

namespace MoveFiles
{
    public static class Bancomat
    {
        const string code = "88866";
        const double money = 5000;
        public static bool checkPassword(string password)
        {
            bool response = false;
            if (checkPasswordLength(password))
            {
                if (password == code)
                {
                    response = true;
                }
            }
            return response;
        }

        static bool checkPasswordLength(string password)
        {
            bool response = false;
            if (password.Length == code.Length)
            {
                response = true;
            }
            return response;
        }

        public static bool checkMoney(double amount)
        {
            bool moneyresp = false;

            if(amount <= money)
            {
                moneyresp = true;
            }
            else
            {
                Console.WriteLine("Importo richiesto non disponibile.");
                Console.WriteLine("Inserire un altro importo.");
            }

            return moneyresp;
        }
        
    }
}
