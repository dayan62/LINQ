using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groupjoinc
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>()
            {
                new Student(){Id=1,Name="Maria",CategoryID=1},
                new Student(){Id=2,Name="Amelia",CategoryID=1},
                new Student(){Id=3,Name="Rebecca",CategoryID=2},
                new Student(){Id=4,Name="Uma",CategoryID=2 },
                new Student(){Id=5,Name="Victoria",CategoryID=3},
            };
            var categories = new List<Category>()
            {
                new Category(){Id=1,Name="Monitor"},
                new Category(){Id=1,Name="Discipline"},
                new Category(){Id=1,Name="Nothing"},
            };
            var ms = categories.GroupJoin(students, cat => cat.Id, std => std.CategoryID, (cat, std) => new { cat, std });
            foreach(var item in ms)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryID { get; set; }
    }
    class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
