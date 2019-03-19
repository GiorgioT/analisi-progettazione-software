using System;
using System.IO;

namespace Progetto_Banca_Luigi_CA
{
    class Program_lca
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Inserisci la tua password qui:");
                string inputOne = Console.ReadLine();
                var checkpsw = Bancomat_lca.CheckPassword(inputOne);
                
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
                Enum.GetName(typeof(Bancomat_enums_lca.operationType), inputTwo));
            Console.WriteLine("Inserisci l'importo:");
            var amount = Convert.ToInt32(Console.ReadLine());

            switch (inputTwo)
            {
                case (int)Bancomat_enums_lca.operationType.Prelievo:
                    var checkA = Bancomat_lca.CheckAmount(amount);
                    while (!checkA)
                    {
                        Console.WriteLine("Importo richiesto non disponibile.");
                        Console.WriteLine("Inserisci un altro importo.");
                        amount = Convert.ToInt32(Console.ReadLine());
                        checkA = Bancomat_lca.CheckAmount(amount);
                    }
                    break;
                case (int)Bancomat_enums_lca.operationType.Deposito:
                    break;
                default:
                    break;
            }

            var checkmny = Bancomat_lca.CheckAmount(amount);
        }

    }
}

