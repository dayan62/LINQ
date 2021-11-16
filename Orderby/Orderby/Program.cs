using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orderby
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dataSourceInt = new List<int>() { 99, 100, 65, 999, 9090, 50505, 3434, 10, 1, 9484984, 0 };
            var datasourcestring = new List<string>() { "akashay", "Shubham", "yogesh", "Dayan", "saurabh", "wright" };
            var querysyntax = (from num in dataSourceInt
                               where num>5000
                               orderby num
                               select num).ToList();
            var methodsyntax = dataSourceInt.Where(num=>num>5000).OrderBy(num => num).ToList();
            foreach(var item in methodsyntax)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("#$%%$##$%%%$#*&%$#@!!@#$%^&**&^%$#@!");
            var querysyntax1 = (from str in datasourcestring
                                orderby str
                                select str).ToList();
            var methodsyntax1 = datasourcestring.OrderBy(str1 => str1).ToList();
            foreach(var item in methodsyntax1)
            {
                Console.WriteLine(item);
            }

             



            Console.ReadLine();
        }

    }
}
