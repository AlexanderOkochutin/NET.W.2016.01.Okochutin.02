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
            string fst = "abcdefghijklmnopqrstuvwxyz";
            string scnd = "abcdefghijklmnopqrstuvwxyz";
            Console.WriteLine(ExtensionToolsForString.UnionAndSortLINQ(fst, scnd));
            Console.ReadLine();
        }
    }
}
