using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectMany
{
    class Program
    {
        static void Main(string[] args)
        {
            var datasource = new List<Employee>()
            {
                new Employee(){Id=1,Name="Tom",Email="tom@gmail.com",programming=new List<Techs>
                {
                    new Techs(){Technology="C#" },
                    new Techs(){Technology="Python" },
                    new Techs(){Technology=".NET" }
                }
                },
                  new Employee(){Id=2,Name="John",Email="johnm@gmail.com",programming=new List<Techs>
                {
                    new Techs(){Technology="C#" },
                    new Techs(){Technology="PHP" },
                    new Techs(){Technology="Java" }
                }
                },
                    new Employee(){Id=3,Name="Jack",Email="Jack@gmail.com",programming=new List<Techs>
                {
                    new Techs(){Technology="C" },
                    new Techs(){Technology="salesforce" },
                    new Techs(){Technology="ASP.Net MVC" }
                }
                },
                      new Employee(){Id=4,Name="Mark",Email="mark@gmail.com",programming=new List<Techs>
                {
                    new Techs(){Technology="c++" },
                    new Techs(){Technology="Pascle" },
                    new Techs(){Technology="R" }
                }
                },
                       new Employee(){Id=5,Name="Dayan",Email="dayan@gmail.com",programming=new List<Techs>() },
                        new Employee(){Id=6,Name="Bhushan",Email="bushan@gmail.com",programming=new List<Techs>() }
            };
            var methodquery = datasource.SelectMany(emp => emp.programming).ToList();
            
            Console.ReadLine();

        }
    }
}
