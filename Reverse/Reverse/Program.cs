using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
     class Program
    {
        static void Main(string[] args)
        {
            int[] rollNums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<string> names = new List<string>() {"Sagar","akash","saurabh","Dayan","Yogesh","Bob"};
            var mq = rollNums.Reverse();
            foreach(var item in mq)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("****####****####****####*#*#*#");
            names.Reverse();
            foreach (var item in names) 
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
