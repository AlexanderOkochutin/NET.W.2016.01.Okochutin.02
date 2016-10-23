using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task06.Logic;


namespace Task06.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
           
            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("enter first string, must contain only a-z or A-Z");
                Console.ForegroundColor = ConsoleColor.Gray;
                string fst = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("enter second string, must contain only a-z or A-Z");
                Console.ForegroundColor = ConsoleColor.Gray;
                string scnd = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(ExtensionToolsForString.UnionAndSortLINQ(fst,scnd));
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("enter 'stop' to exit or press enter to continue");
            } while (Console.ReadLine() != "stop");
        }
    }
}
