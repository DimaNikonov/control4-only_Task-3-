using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> collection = new List<int> { 54, 55, 14, 77, 33,20, 23, 13, 32 };
            Console.WriteLine(string.Join(" ", collection.OrderBy((t => collection.Max(x => t / 10))).ThenByDescending(t => collection.Min(y => t%10))));
            
        }
    }
}
