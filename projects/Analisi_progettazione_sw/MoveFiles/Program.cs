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
        }
    }





