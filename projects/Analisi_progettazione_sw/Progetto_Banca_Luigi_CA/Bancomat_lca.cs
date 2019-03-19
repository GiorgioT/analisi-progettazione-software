using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Progetto_Banca_Luigi_CA
{
    public static class Bancomat_lca
    {
        static string _password = string.Empty;
        static decimal _amount = 0;
        static string sourceDirectory = @"C:\Users\aghed\Documents\IERFOP\GitHub\Analisi_progettazione-software\projects\Analisi_progettazione_sw\Progetto_Banca_Luigi_CA\Resources";

        static string fileName = "credenziali.csv";

        public static bool CheckPassword(string password)
        {
            bool res = false;

            if (CheckPasswordLength(password))
            {
                if (password == _password)
                {
                    res = true;
                }  
            }
            return res; 
        
        }
        static bool CheckPasswordLength(string password)
        {
            bool res = false;

            if (password.Length == 5)
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

        public static void GetCredentials()
        {
            DirectoryInfo diSource = new DirectoryInfo(sourceDirectory);
            if (diSource.Exists)
            {
                var path = Path.Combine(sourceDirectory,fileName);
                FileInfo fileInfo = new FileInfo(path);
                if (fileInfo.Exists)
                {
                    
                    foreach (var line in File.ReadLines(path))
                    {
                        var lineField = line.Split(";");
                        _password = lineField[1];
                        _amount = Convert.ToDecimal(lineField[4]);

                            
                    }
                }
            }

        }

    }
}
