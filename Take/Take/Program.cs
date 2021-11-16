using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Take
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var ms = numbers.Take(3).ToList();
            var mixeds = (from n in numbers
                          where n>3
                          select n).Take(5).ToList();
            Console.ReadLine();
        }
    }
}
