using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MoveFiles
{
    public static class Bancomant_Giovanni
    {
        static string _password = string.Empty;
        static decimal _manny = 0;
        static string sourceDirectory = @"C:\Users\user\Desktop\Corso\analisi-progettazione-software\projects\Analisi_progettazione_sw\MoveFiles\Resurces";
        static string path = Path.Combine(sourceDirectory, fileName);
        static string fileName = "credenziali.csv";
        public static bool CheckPassword (string password)
        {
            bool response = false;
            if (CheckPasswordLenght(password))
            {
                if (_password == password)
                {
                    response = true;
                }
            }            
            return response;
        }

        static bool CheckPasswordLenght(string password)
        {
            bool response = false;
            if (password.Length == 5)
            {
                response = true;
            }
            return response;
        }

        public static bool CheckManny (decimal manny)
        {
            bool response = false;
            if (_manny <= manny)
            {
                 response = true;
            }
            
            return response;
        }
        public static void GetCredenziali(string password)
        {
            DirectoryInfo diSource = new DirectoryInfo(sourceDirectory);
            if (diSource.Exists)
            {               
                FileInfo fileInfo = new FileInfo(path);
                if (fileInfo.Exists)
                {                    
                    foreach (var line in File.ReadLines(path))
                    {
                        var lineField = line.Split(";");
                        _password = lineField[1];
                        _manny = Convert.ToDecimal(lineField[4]);
                    }
                }
            }
        }
        public static void updateBalance(decimal withdrawl)
        {
            _manny -= withdrawl;
            var lines = File.ReadAllLines(path);
            foreach (var line in File.ReadLines(path))
            {
                var lineField = line.Split(";");
                if (lineField[1] == _password)
                {
                    lineField[4] = _manny.ToString();
                }
                
            }
            File.WriteAllLines(path, lines);
        }
    }

}
