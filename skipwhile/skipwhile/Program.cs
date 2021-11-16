using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skipwhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 3, 4, 5, 6, 7, 8, 9, 10, 2 };
            List<string> names = new List<string>() { "Kim", "John", "Mark", "Adam", "Dayan" };
            var ms = numbers.SkipWhile(num => num < 6).ToArray();
            var mixedS = (from num in numbers select num).SkipWhile(x => x < 5).ToArray();
            var ms1 = names.SkipWhile(x => x.Length < 4).ToList();
            var ms2 = names.SkipWhile((value, index) => value.Length > index).ToList();
            foreach(int item in ms)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
