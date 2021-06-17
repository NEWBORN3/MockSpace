using System;
using System.Collections.Generic;
using System.Linq;

namespace FunctionalProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<string> names = Console.ReadLine()?.Split(new string[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries)
                            //   .ToList();            
            //  PrintName.PrintNames(names);

            List<int> RangeNum = Console.ReadLine()?.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x=>int.Parse(x)).Take(2)
                                       .ToList();
            // PrintName.PrintNamesWithTitle(names);
            
            // PrintName.PrintThat(PrintName.PrintTheSmallest(numbers));
            string options = Console.ReadLine();

            switch(options)
            {
                case "Even":
                    numbers.Where(PrintName.FindEven).ToList().ForEach(x=>PrintName.PrintThat(x));
                    break;
                case "Odd":
                    numbers.Where(PrintName.FindOdd).ToList().ForEach(x=>PrintName.PrintThat(x));
                    break;
                default :
                    Console.WriteLine("Only implmented for even and odd");
                    break;

            }
            
        }
    }
}
