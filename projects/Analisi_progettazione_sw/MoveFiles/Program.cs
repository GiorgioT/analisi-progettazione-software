using System;
using System.IO;

namespace MoveFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string sourceDirectory = @"c:\file_uploaded";
            DirectoryInfo diSource = new DirectoryInfo(sourceDirectory);
            foreach (DirectoryInfo diSourceSubDir in diSource.GetDirectories())
            {
                Console.WriteLine(diSourceSubDir.Name);
                foreach (var fileInfo in diSourceSubDir.GetFiles())
                {
                    Console.WriteLine(fileInfo.Name);
                    if (fileInfo.Name.StartsWith("CV"))
                    {
                        Console.WriteLine("Questo è un curriculum");
                    }
                    else if (fileInfo.Name.StartsWith ("CERT"))
                    {
                        Console.WriteLine("Questa è una certificazione");
                    }
                    
                }
               
            }
        }
    }
}
