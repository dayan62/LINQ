using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thenby
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataSource = new List<Employee>()
            {
                new Employee()
                {
                    Id=3,
                    Email="smith@gmail.com",
                    FirstName="Foo",
                    LastName="Smith"
                },
                new Employee()
                {
                    Id=2,
                    Email="Thomas@gmail.com",
                    FirstName="Mark",
                    LastName="Thomas"
                },
                new Employee()
                {
                    Id=1,
                    Email="allen@gmail.com",
                    FirstName="Mark",
                    LastName="Allen"
                },
                new Employee()
                {
                    Id=4,
                    Email="andreson@gmail.com",
                    FirstName="Foo ",
                    LastName="Anderson"
                },
            };
            var ms = dataSource.OrderBy(emp => emp.FirstName).ThenBy(emp=>emp.LastName).ToList();
            foreach(var item in ms)
            {
                Console.WriteLine($"{item.Id},first-Name={item.FirstName},last-Name={item.LastName}Email={item.Email}");

            }
            Console.ReadLine();

        }
    }
}
