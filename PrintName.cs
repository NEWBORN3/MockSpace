using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FunctionalProgramming
{
    public static class PrintName
    {
       public static Action<List<string>> PrintNames = x => x.ForEach(x =>Console.WriteLine(x));
       public static Action<List<string>> PrintNamesWithTitle = x => x.ForEach(x =>Console.WriteLine("Sir {0}",x));

       public static Func<List<int>,int> PrintTheSmallest = x => x.Min();
       public static Action<int> PrintThat = x => Console.WriteLine(x);

       public static Func<int,bool> FindEven = x => x % 2 == 0;
       public static Func<int,bool> FindOdd = x => x % 2 != 0;

       public static Func<List<int>,List<int>> PopulateRange;
    }
}