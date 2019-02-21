using System;

namespace ConsoleExercises
{
    class Program
    {
        static void Main(string[] args)
        {
         //CreateLoop();
            TestDoWhile();
        }

        static void CreateLoop()
        {
            var a = 1;
            while (a > 0)
            {
                Console.WriteLine("I'm creating a loop! a == {0}", a);
                a++;
            }
        }

        static void TestDoWhile()
        {
            char c;
            do
            {
                Console.WriteLine("premi q per uscire");
                c = Console.ReadKey().KeyChar;
            }
            while (c != 'q');
        }
    }
}
