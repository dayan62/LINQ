using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skip
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<string> names = new List<string>() { "Kim", "John", "Mark", "Adam", "Dayan" };
            var ms = numbers.Where(x=>x>5).Skip(3).ToList();
            var ms1 = (from n in names select n).Skip(2).ToList();
            Console.ReadLine();
        }
    }
}
