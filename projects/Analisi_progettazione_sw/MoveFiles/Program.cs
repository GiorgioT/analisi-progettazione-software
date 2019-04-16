using System;
using System.IO;

namespace MoveFiles
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            var input = Console.ReadLine();
            Bancomant_Giovanni.GetCredenziali(input);
            var checkP = Bancomant_Giovanni.CheckPassword(input);
            for (int i = 0; i<3; i++)
		    {
             Console.WriteLine("inserisci la tua password");             
                if (checkP)
                {
                    Console.WriteLine("Password corretta");
                    break;
                }
                else
                {
                    Console.WriteLine("La tua password non è stata confermata");
                    Console.WriteLine("riprova ad inserire la password");                    
                }
            }
=======
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

>>>>>>> 2be2111a4e3e84bc0a9284ecbf0bddd0d90073db

            Console.WriteLine("scegli operazione");
            Console.WriteLine("1-Deposita");
            Console.WriteLine("2-Prelieva");
            var operation = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hai selezionato: "+Enum.GetName(typeof(Bancomat_enums.OperationType),operation));
            Console.WriteLine("Inserisci l'importo");
            var amont = Convert.ToDecimal(Console.ReadLine());

            switch (operation)
            {
                case (int)Bancomat_enums.OperationType.Deposito:                                       
                    break;
                case (int)Bancomat_enums.OperationType.Prelievo:
                    var checkA = Bancomant_Giovanni.CheckManny(amont);
                    break;
                default:
                    break;
            }
        }
               
    }
}




