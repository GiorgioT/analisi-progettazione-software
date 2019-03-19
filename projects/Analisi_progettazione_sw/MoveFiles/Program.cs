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
                var checkpsw = Bancomat.checkPassword(inputOne);

<<<<<<< HEAD
            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine("Inserisci password");
                var input = Console.ReadLine();
                var checkpsw = Bancomat_Andrea.CheckPassword(input);
                if (!checkpsw)

                {
                    Console.WriteLine("La tua password non è stata confermata");
                    Console.WriteLine("Riprova ad inserire la password");
                }
                else
                {
                    Console.WriteLine("Password verificata");
                    break;
                }

            }
            Console.WriteLine("Scegli operazione");
            Console.WriteLine("Scegli 1 per deposito");
            Console.WriteLine("Scegli 2 per prelievo");
            var operation = Console.Read();
           

            switch (operation)
            {
                case (int)Bancomat_enum.operationType.Deposito:
                    break;
                case (int)Bancomat_enum.operationType.Prelievo:
                default:
                    break;
                    
            }
        } 
=======
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
                    break;
                case (int)Bancomat_enums.operationType.Deposito:
                    break;
                default:
                    break;
            }
            var checkmny = Bancomat.checkMoney(amount);
>>>>>>> 6e757c2c4c7b2dc0e71a3d9ffe41a68833ed6c97
        }
    }





