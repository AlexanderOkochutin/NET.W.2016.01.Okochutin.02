using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task07.Logic;


namespace Task07.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            do {
                Console.WriteLine("Enter params in next format  num1,num2,startBit,endBit");
                Console.WriteLine(new string('*', 67));
                string inputData = Console.ReadLine();
                int[] rsltArray = null;
                bool tryAgain = true;
                while (tryAgain) // in case of fail repeat 
                {
                    try
                    {
                        rsltArray = Array.ConvertAll(inputData.Split(new char[] { ' ', ',' }), int.Parse); // parse string[] into int[] 
                        int? indexOfEqu = BitTools.BitInsertion(rsltArray[0], rsltArray[1], rsltArray[2], rsltArray[3]);
                        if (indexOfEqu == null)
                        {
                            throw new Exception();
                        }
                        else
                        {
                            tryAgain = false; // set in case of success
                            Console.WriteLine(indexOfEqu);
                        }

                    }

                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine();
                        Console.WriteLine("****Please check input information, and try again!****");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Enter params in next format  num1,num2,startBit,endBit");
                        Console.WriteLine(new string('*', 67));
                        inputData = Console.ReadLine(); // in case of fail repeat enter of info

                    }
                }
                Console.WriteLine("enter stop to exit");
            } while (Console.ReadLine() != "stop");
        }
    }
}

