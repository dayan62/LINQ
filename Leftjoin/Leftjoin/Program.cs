using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leftjoin
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>()
            {
                new Student(){Id=1,Name="Maria",AddressId=1},
                new Student(){Id=2,Name="Amelia",AddressId=2},
                new Student(){Id=3,Name="Rebecca"},
                new Student(){Id=4,Name="Una",AddressId=4},
                new Student(){Id=5,Name="Victoria",AddressId=5},
            };
            var address = new List<Address>()
            {
                new Address(){Id=1,AddressLine="Maaria Address"},
                new Address(){Id=2,AddressLine="Amelia Address"},
                new Address(){Id=3,AddressLine="Una Address"},
            };
            var qs = (from std in students
                      join add in address on std.AddressId equals add.Id into stdAddress
                      from studentAddess in stdAddress.DefaultIfEmpty()
                      select new { std, studentAddess }).ToList();
            var ms = students.GroupJoin(address, std => std.AddressId, add => add.Id,
                (std, add) => new { std, add }
                ).SelectMany(x =>
                x.add.DefaultIfEmpty(),
                (studentData, addressData) =>
                new { studentData.std, addressData }).ToList();
            Console.ReadLine();
        }
    }
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AddressId { get; set; }
    }
    class Address
    {
        public int Id { get; set; }
        public string AddressLine { get; set; }

    }
}
