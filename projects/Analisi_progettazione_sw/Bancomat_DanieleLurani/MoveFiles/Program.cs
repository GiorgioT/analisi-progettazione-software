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
                Console.WriteLine("Inserisci la tua password");
                var input = Console.ReadLine();
                var checkP = Bancomat.CheckPassword(input);
                if (!checkP)
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
            Console.WriteLine("Scegli operazione");
            Console.WriteLine("Scegli 1 per deposito");
            Console.WriteLine("Scegli 2 per prelievo");
            var operation =  Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hai scelto di fare un " + 
                Enum.GetName(typeof(BacomatEnums.OperationType), operation));
            Console.WriteLine("Inserisci l'importo");
            var amount = Convert.ToDecimal(Console.ReadLine());

            switch (operation)
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
                    break;
                default:
                    break;
            }


        }
    }
}




