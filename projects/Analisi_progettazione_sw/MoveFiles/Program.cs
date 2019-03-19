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
                Console.WriteLine("Inserisci la tua password qui:");
                string inputOne = Console.ReadLine();
                Bancomat.getCredentials(inputOne);
                var checkpsw = Bancomat.checkPassword(inputOne);
                if (!checkpsw)
                {
                    Console.WriteLine("La password non è corretta.");
                    Console.WriteLine("Reinserire la password.");
                }
                else
                {
                    Console.WriteLine("La password è corretta.");
                    break;
                }
 
            }
            Console.WriteLine("Scegli il tipo di operazione:");
            Console.WriteLine("1 - Per prelevare;");
            Console.WriteLine("2 - Per depositare;");
            var inputTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hai scelto di fare un " +
                Enum.GetName(typeof(Bancomat_enums.operationType), inputTwo));
            Console.WriteLine("Inserisci l'importo:");
            var amount = Convert.ToInt32(Console.ReadLine());

            switch (inputTwo)
            {
                case (int)Bancomat_enums.operationType.Prelievo:
                    var checkA = Bancomat.checkMoney(amount);
                    while (!checkA)
                    {
                        Console.WriteLine("Importo richiesto non disponibile.");
                        Console.WriteLine("Inserisci un altro importo.");
                        amount = Convert.ToInt32(Console.ReadLine());
                        checkA = Bancomat.checkMoney(amount);
                    }
                    if (checkA)
                    {
                        Bancomat.updateBalance(amount);
                    }
                    break;
                case (int)Bancomat_enums.operationType.Deposito:
                    break;
                default:
                    break;
            }
            var checkmny = Bancomat.checkMoney(amount);
        }
    }
}




