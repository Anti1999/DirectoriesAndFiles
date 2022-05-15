using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyWishListFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = @"C:\Users\Anti\Samples\MyWishList";
            string fileName = @"\\MyWishList.txt";

            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");
            List<string> myshoppinglist = arrayFromFile.ToList<string>();

            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Would you to add items to shoping list? Y/N:");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if(userInput == 'y')
                {
                    Console.WriteLine("Enter you wish:");
                    string userWish = Console.ReadLine();
                    myshoppinglist.Add(userWish);
                }
                else
                {
                    loopActive = false;
                    Console.WriteLine("Take care!");
                }
            }

            Console.Clear();

            foreach(string wish in myshoppinglist)
            {
                Console.WriteLine($"You wish: {wish}");
            }

            File.WriteAllLines($"{fileLocation}{fileName}", myshoppinglist);
        }
    }
}
