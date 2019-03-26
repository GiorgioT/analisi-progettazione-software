using System;
using System.IO;

namespace MoveFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
<<<<<<< HEAD
                Console.WriteLine("Inserisci la tua password qui:");
                string inputOne = Console.ReadLine();
                Bancomat.getCredentials(inputOne);
                var checkpsw = Bancomat.checkPassword(inputOne);
                if (!checkpsw)
=======
                Console.WriteLine("Inserisci la tua password");
                var input = Console.ReadLine();
                var checkP = Bancomat.CheckPassword(input);
                if (!checkP)
>>>>>>> de5c598f5e5872ead05699a267bd05352e8058e9
                {
                    Console.WriteLine("La tua password non è stata confermata");
                    Console.WriteLine("Riprova ad inserire la password");
                }
                else
                {
                    Console.WriteLine("password verificata");
                    break;
                }
            }
<<<<<<< HEAD
            Console.WriteLine("Scegli il tipo di operazione:");
            Console.WriteLine("1 - Per prelevare;");
            Console.WriteLine("2 - Per depositare;");
            var inputTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hai scelto di fare un " +
                Enum.GetName(typeof(Bancomat_enums.operationType), inputTwo));
            Console.WriteLine("Inserisci l'importo:");
            var amount = Convert.ToInt32(Console.ReadLine());

            switch (inputTwo)
=======
            Console.WriteLine("Scegli operazione");
            Console.WriteLine("Scegli 1 per deposito");
            Console.WriteLine("Scegli 2 per prelievo");
            var operation =  Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hai scelto di fare un " + 
                Enum.GetName(typeof(BacomatEnums.OperationType), operation));
            Console.WriteLine("Inserisci l'importo");
            var amount = Convert.ToDecimal(Console.ReadLine());

            switch (operation)
>>>>>>> de5c598f5e5872ead05699a267bd05352e8058e9
            {
                case (int)BacomatEnums.OperationType.Deposito:
                    break;
                case (int)BacomatEnums.OperationType.Prelievo:
                    var checkA = Bancomat.CheckAmount(amount);
                    while (!checkA)
                    {
                        Console.WriteLine("Importo richiesto non disponibile");
                        Console.WriteLine("Inserisci l'importo");
                        amount = Convert.ToDecimal(Console.ReadLine());
                        checkA = Bancomat.CheckAmount(amount);
                    }
                    if (checkA)
                    {
                        Bancomat.updateBalance(amount);
                    }
                    break;
                default:
                    break;
            }


        }
    }
}




