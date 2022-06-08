using System;
using System.IO;

namespace ShoppingListConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Harri\source\repos\ShoppingListConsoleApp\shoppinglistitems.txt";

            while (true)
            {
            Console.WriteLine("Input a shopping item or \"quit\" to end: ");
            string input = Console.ReadLine();
                if(input != "quit")
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(input);
            }

                else
                {
                    break;
                }
            }

            Console.WriteLine();

            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

        }


    }
}
