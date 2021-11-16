using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectinLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee>employees=new List<Employee>()
                {
                new Employee(){ID=1,Name="Shah Rukh Khan", Email="ShahRukh@gmail.com"},
                new Employee(){ID=2,Name="Dayan", Email="Dayan@gmail.com"},
                new Employee(){ID=3,Name="Sourabh", Email="Sourabh@gmail.com"},
                new Employee(){ID=4,Name="Makarand Anaspure", Email="MakarandAnaspure@gmail.com"},
                new Employee(){ID=4,Name="Sagar", Email="Sagar@gmail.com"},
                new Employee(){ID=5,Name="Shubham", Email="Shubham@gmail.com"},
                new Employee(){ID=6,Name="Yogesh", Email="Yogesh@gmail.com"},
                new Employee(){ID=7,Name="Admin", Email="admin@gmail.com"}


            };
            var seletQuery = (from emp in employees
                              select new Employee()
                              {
                                  ID = emp.ID,
                                  Email = emp.Email
                              }).ToList();
            foreach (var item in seletQuery)
            {
                Console.WriteLine($"ID = {item.ID} Name = {item.Name} Email = {item.Email}");
            }
            Console.WriteLine("######################################################################################");
            Console.ReadLine();
        }
    }
}
