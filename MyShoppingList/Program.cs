using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MyShoppingList
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

            CreateDirectoryFiles(rootDirectory,newDirectory,fileName);
        }
        public static void CreateDirectoryFiles(string root,string directory,string file)
        {
            if (!Directory.Exists($"{root}\\{directory}")) Directory.CreateDirectory($"{root}\\{directory}");
            if (!File.Exists($"{root}\\{directory}\\{file}"))
            {
                var createNewFile = File.Create($"{root}\\{directory}\\{file}");
                createNewFile.Close();
            }
            AddShoppingList(root, directory, file);
        }
        public static void AddShoppingList(string root, string directory, string file)
        {
            bool loopActive = true;

            string[] arrayFromFile = File.ReadAllLines($"{root}//{directory}//{file}");
            List<string> myshoppinglist = arrayFromFile.ToList<string>();
            while (loopActive)
            {
                Console.WriteLine("Would you to add a wish? Y/N:");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userInput == 'y')
                {
                    Console.WriteLine("Enter you wish:");
                    string userProduct = Console.ReadLine();
                    myshoppinglist.Add(userProduct);
                }
                else
                {
                    loopActive = false;
                    Console.WriteLine("Take care!");

                }


            }
            Console.Clear();

            foreach (string product in myshoppinglist)
            {
                Console.WriteLine($"Your products: {product}");
            }

            File.WriteAllLines($"{root}\\{directory}\\{file}", myshoppinglist);

        }

            

    }
}