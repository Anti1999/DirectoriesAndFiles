using System;
using System.Collections.Generic;

namespace WishList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> myWishList = new List<string>();

            Console.WriteLine(myWishList.Count);

            myWishList.Add("coffe machine");
            myWishList.Add("new pair of socks");
            myWishList.Add("box of chocolates");

            Console.WriteLine(myWishList.Count);

            foreach(string wish in myWishList)
            {
                Console.WriteLine(wish);
            }
             
        }
    }
}
