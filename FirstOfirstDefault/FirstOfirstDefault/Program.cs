﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstOfirstDefault
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1,2,3,4,5,6,7,8,9,10};
            var ms = numbers.First();
            var ms1 = numbers.First(x=>x>5);
            Console.ReadLine();
        }
    }
}
