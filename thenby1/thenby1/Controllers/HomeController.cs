using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using thenby1.Models;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace thenby1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var dataSource = new List<object>() {"Adam","Sagar","Dayan","Vaibhav",1,2,3,4, };
            var ms = dataSource.OfType<string>().ToList();
            Console.WriteLine(ms);
           
           return View  (ms);
        }
    }
}