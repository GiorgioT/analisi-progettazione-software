using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MoveFiles
{
    public static class Bancomat
    {
<<<<<<< HEAD:projects/Analisi_progettazione_sw/MoveFiles/Bancomat_giorgioT.cs
        const string _password = "88661";
        const decimal _amount = 25000;
        public static bool CheckPassword (string password)
=======
        static string _password = string.Empty;
        static decimal _amount = 0;
        static string sourceDirectory = @"C:\Users\aghed\Documents\IERFOP\GitHub\Analisi_progettazione-software\projects\Analisi_progettazione_sw\Progetto_Banca_Luigi_CA\Resources";

        static string fileName = "credenziali.csv";
        static string path = Path.Combine(sourceDirectory, fileName);


        //metodi

        public static bool CheckPassword(string password)
>>>>>>> 04d1ecb62bd57c9ba22e162957adf4a6cfdddeff:projects/Analisi_progettazione_sw/Progetto_Banca_Luigi_CA/Bancomat_lca.cs
        {
            bool res = false;
            if (CheckPasswordLenght(password))
            {
                if (_password == password)
                {
                    res = true;
                }
            }
<<<<<<< HEAD:projects/Analisi_progettazione_sw/MoveFiles/Bancomat_giorgioT.cs

            return res;
=======
            return res;

>>>>>>> 04d1ecb62bd57c9ba22e162957adf4a6cfdddeff:projects/Analisi_progettazione_sw/Progetto_Banca_Luigi_CA/Bancomat_lca.cs
        }
        static bool CheckPasswordLenght(string password)
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
<<<<<<< HEAD:projects/Analisi_progettazione_sw/MoveFiles/Bancomat_giorgioT.cs
=======

>>>>>>> 04d1ecb62bd57c9ba22e162957adf4a6cfdddeff:projects/Analisi_progettazione_sw/Progetto_Banca_Luigi_CA/Bancomat_lca.cs
            if (_amount >= amount)
            {
                res = true;
            }
<<<<<<< HEAD:projects/Analisi_progettazione_sw/MoveFiles/Bancomat_giorgioT.cs
            return res;
        }
        public static void GetCredentials()
        {
           
        }
=======

            return res;
        }
        public static void GetCredentials(string password)
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
                            _password = lineField[1];
                            _amount = Convert.ToDecimal(lineField[4]);

                        }

                    }
                }
            }

        }
        public static void UpdateBalance(decimal withdrawal)
        {
            _amount -= withdrawal;
            var lines = File.ReadAllLines(path);
            var newLines = new List<string>(); 
    
            foreach (var line in lines)
            {
                var lineField = line.Split(";");


                if (lineField[1] == _password)
                {

                    //_amount = Convert.ToDecimal(lineField[4]);
                    lineField[4] = _amount.ToString();


                }
                var line1 = string.Join(";", lineField, 0, 5);
                newLines.Add(line1);
            }
            File.WriteAllLines(path, newLines.ToArray());
            
        }

>>>>>>> 04d1ecb62bd57c9ba22e162957adf4a6cfdddeff:projects/Analisi_progettazione_sw/Progetto_Banca_Luigi_CA/Bancomat_lca.cs
    }
}
