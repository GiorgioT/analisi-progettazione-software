﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MoveFiles
{
    public class CopyAll
    {
        public static void MoveFiles(DirectoryInfo source, DirectoryInfo target)
        {
            Console.WriteLine("Hello World!");
            string sourceDirectory = @"C:\file_uploaded\";
            string CVdestinationDirectory = @"C:\Certificazioni";
            string CERTdestinationDirectory = @"C:\Curriculum";
            var destination = string.Empty;
            DirectoryInfo diSource = new DirectoryInfo(sourceDirectory);
            foreach (DirectoryInfo diSourceSubDir in diSource.GetDirectories())
            {
                Console.WriteLine(diSourceSubDir.Name);
                foreach (var filedentrolacartella in diSourceSubDir.GetFiles())
                {
                    Console.WriteLine(filedentrolacartella.Name);
                    if (filedentrolacartella.Name.StartsWith("CV"))
                    {
                        Console.WriteLine("Questo è un curriculum");
                        destination = CVdestinationDirectory + filedentrolacartella.Name;
                    }
                    else if (filedentrolacartella.Name.StartsWith("CERT"))
                    {
                        Console.WriteLine("Questa è una certificazione");
                        destination = CERTdestinationDirectory + filedentrolacartella.Name;
                    }
                    filedentrolacartella.MoveTo(destination);

                }
            }
        }
    }
}
