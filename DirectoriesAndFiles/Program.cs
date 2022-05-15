using System;
using System.IO;

namespace DirectoriesAndFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\Anti\Samples";
            Console.WriteLine("Sisestage kausta nimi");
            string newDirectory = Console.ReadLine();
            Console.WriteLine("Sisestage faili nimi");
            string fileName = Console.ReadLine();


            

            //File.Create($"{rootDirectory}\\{newDirectory}\\{fileName}");

            if(Directory.Exists($"{rootDirectory}\\{newDirectory}") && File.Exists ($"{rootDirectory}\\{newDirectory}\\{fileName}"))
            {
                Console.WriteLine($"Directory and File exists. ");
            }
            else
            {
                Directory.CreateDirectory($"{rootDirectory}\\{newDirectory}");
                File.Create($"{rootDirectory}\\{newDirectory}\\ {fileName}");
            }
        }
    }
}
