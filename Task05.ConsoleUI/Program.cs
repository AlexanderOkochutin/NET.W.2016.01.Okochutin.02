using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task05.Logic;


namespace Task05.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Enter array of int in next format  a0,a1,a2,a3  or a0 a1 a2 a3");
                Console.WriteLine("example of input info: 1,14,3,8,19 or  1 14 3 8 19");                
                Console.WriteLine(new string('*', 67));
                string inputData = Console.ReadLine(); 
                int[] rsltArray = null;
                bool tryAgain = true;
                while (tryAgain) // in case of fail repeat 
                {
                    try
                    {
                        rsltArray = Array.ConvertAll(inputData.Split(new char[] { ' ', ',' }), int.Parse); // parse string[] into int[]
                        tryAgain = false; // set in case of success
                        int indexOfEqu = ExtensionToolsForArray.IndexOfEquilibriumFinder(rsltArray);
                        Console.ForegroundColor = ConsoleColor.Green;
                        switch (indexOfEqu)
                        {
                            
                            case -1:
                                
                                Console.WriteLine("index of equilibrium not found");
                                break;
                            case -2:
                                Console.WriteLine("array length is less than 3");
                                break;
                            default:
                                Console.WriteLine("index of equilibrium is : {0}",indexOfEqu);
                                break;
                        }
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine();
                        Console.WriteLine("****Please check input information, and try again!****");
                        Console.WriteLine("****example of input info:  1,2,3  or   1 2 3 ****");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        inputData = Console.ReadLine(); // in case of fail repeat enter of info
                   
                    }
                    Console.WriteLine();
                }



                Console.WriteLine("Enter 'stop' to exit or press enter to continue");
            } while (Console.ReadLine() != "stop");
        }
    }

}
   
