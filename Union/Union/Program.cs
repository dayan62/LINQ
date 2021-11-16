using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Union
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<student> student1 = new List<student>()
            {
                new student(){Id=1,Name="John"},
                new student(){Id=2,Name="Kim"},
                new student(){Id=3,Name="John"},
                new student(){Id=4,Name="Mark"},
            };
            List<student> student2 = new List<student>()
            {
                new student(){Id=1,Name="John"},
                new student(){Id=2,Name="Kim"},
                new student(){Id=3,Name="John"},
                new student(){Id=4,Name="Mark"},
            };
            var ms = student1.Union(student2,new studentComparer()).ToList(); 
            Console.ReadLine();
        }
        class student
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        class studentComparer : IEqualityComparer<student>
        {
            public bool Equals(student x, student y)
            {
                return x.Id.Equals(y.Id) && x.Name.Equals(y.Name);
            }

            public int GetHashCode(student obj)
            {
                int idHashCode = obj.Id.GetHashCode();
                int nameHashCode = obj.Name.GetHashCode();

                return idHashCode ^ nameHashCode;
            }
        }
    }
}
