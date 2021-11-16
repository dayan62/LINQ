using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalPagePerView = 4;
            do
            {
                Console.WriteLine("Enter your page number");
                if (int.TryParse(Console.ReadLine(), out int pageNumber))
                {
                    var ms = GetEmployees().Skip((pageNumber - 1) * totalPagePerView).Take(totalPagePerView);
                    foreach (var item in ms)
                    {
                        Console.WriteLine($"Id={item.Id} and Name={item.Name}");
                    }

                }
                else
                {
                    Console.WriteLine("Enter a valid number ");
                } 
            } while (true);
        }
        public static List<Employee> GetEmployees()
        {
            return new List<Employee>()
            {
                new Employee(){Id=1,Name="Maria"},
                new Employee(){Id=2,Name="Saurabh"},
                new Employee(){Id=3,Name="Dayan"},
                new Employee(){Id=4,Name="Yogesh"},
                new Employee(){Id=5,Name="Bhushan"},
                new Employee(){Id=6,Name="Shubham"},
                new Employee(){Id=7,Name="Jyoti"},
                new Employee(){Id=8,Name="Durga"},
                new Employee(){Id=9,Name="Dhanshree"},
                new Employee(){Id=10,Name="Salman Khan"},
                new Employee(){Id=11,Name="Makarand Anaspure"},
                new Employee(){Id=12,Name="Ashok Saraf"},
                new Employee(){Id=13,Name="Nilu Phule"},
                new Employee(){Id=14,Name="Bhau Kadam"},
                new Employee(){Id=15,Name="Rajkumar rao"},
                new Employee(){Id=16,Name="Tony Stark"},
                new Employee(){Id=17,Name="Captain America"},
                new Employee(){Id=18,Name="Hulk"},
                new Employee(){Id=19,Name="Thor"},
                new Employee(){Id=20,Name="Loki"},
            };
        }

    }
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
