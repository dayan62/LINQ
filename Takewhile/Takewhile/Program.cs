using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Takewhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 5, 6, 7, 8, 9, 10, 2, 3, 4 };
            var ms = numbers.TakeWhile(x=>x<7).ToList();
            List<string> names = new List<string>() { "Kim", "John", "Mark", "Ada","Dayan" };
            var ms1 = names.TakeWhile((name, index) => name.Length > index).ToList();
            Console.ReadLine();

        }
    }
}
