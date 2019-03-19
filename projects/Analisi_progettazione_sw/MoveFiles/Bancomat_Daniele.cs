using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MoveFiles
{
    public static class Bancomat
    {
        static string code = "235235@@@@@€235235rgfdegbebg434@@@4234";
        static decimal money = 0;
        static string sourceDirectory = @"C:\Users\Danny\Documents\Condivise GitHub\analisi-progettazione-software\projects\Analisi_progettazione_sw\MoveFiles\resources";
        static string fileName = "credentials.csv";
        static string path = Path.Combine(sourceDirectory, fileName);

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
        public static bool checkMoney(decimal amount)
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
        public static void getCredentials(string password)
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
                        if (lineField[1] == password)
                        {
                            code = lineField[1];
                            money = Convert.ToDecimal(lineField[4]);
                        }
                    }
                }
            }
        }
        public static void updateBalance(decimal withdrawal)
        {
            money -= withdrawal;
            var lines = File.ReadAllLines(path);
            var newLines = new List<string>();
            foreach (var line in lines)
            {
                var lineField = line.Split(";");
                if (lineField[1] == code)
                {
                    lineField[4] = money.ToString();
                }
                var lineN = string.Join(";", lineField, 0, 5);
                newLines.Add(lineN);
            }
            File.WriteAllLines(path, newLines.ToArray());
        }
    }
}
