using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>()
            {
                new Student(){Id=1,Name="A 1",AddressId=1},
                new Student(){Id=2,Name="A 2",AddressId=0},
                new Student(){Id=3,Name="A 3",AddressId=2},
                new Student(){Id=4,Name="A 4",AddressId=0},
                new Student(){Id=5,Name="A 5",AddressId=3},
            };
            var addresses = new List<Address>()
            {
                new Address(){Id=1,AddressLine="Line 1"},
                new Address(){Id=2,AddressLine="Line 2"},
                new Address(){Id=3,AddressLine="Line 3"},
                new Address(){Id=4,AddressLine="Line 4"},
                new Address(){Id=5,AddressLine="Line 5"},
            };
            var marks = new List<Mark>()
            {
                new Mark(){Id=1,StudentId=1,TMarks=80},
                new Mark(){Id=2,StudentId=2,TMarks=90},
                new Mark(){Id=3,StudentId=3,TMarks=95},
            };
            var ms = students.Join(addresses,
                std => std.AddressId,
                addresss => addresss.Id,
                (std, address) => new
                {
                    studentName = std.Name,
                    Line = address.AddressLine
                }).ToList();

            var qs = (from Student in students
                      join Address in addresses
                      on Student.AddressId equals Address.Id
                      select new
                      {
                          studentsName = Student.Name,
                          Line = Address.AddressLine
                      }).ToList();
            var qsm = (from Student in students
                       join Address in addresses
                       on Student.AddressId equals Address.Id
                       join Mark in marks
                       on Student.Id equals Mark.StudentId
                       select new
                       {
                           studentName = Student.Name,
                           Line = Address.AddressLine ,
                           totalMarks = Mark.TMarks
                       }).ToList();
            Console.ReadLine();
        }
    }
}
