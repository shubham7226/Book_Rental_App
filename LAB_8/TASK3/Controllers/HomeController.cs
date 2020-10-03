using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Lab_8.Models;

namespace Lab_8.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Test1()
        {
            int n1 = 8;
            int n2 = 4;
            int sum = n1 + n2;
            ViewBag.n1 = 8;
            ViewBag.n2 = 4;
            ViewBag.Message = "8 + 4 =" + sum.ToString();
            return View();
        }
        public IActionResult Test2()
        {
            var model = new Sum();
            return View(model);
        }
        
        [HttpPost]
        public ActionResult test2(string n1,string n2)
        {
            int num1 = Int32.Parse(n1.ToString());
            int num2 = Int32.Parse(n2.ToString());
            int sum = num1 + num2;
            ViewBag.sum = "Sum = " + sum.ToString();
            return View("Test2");
        }
        public IActionResult user_registration()
        {
            var model1=new User();
            return View(model1);
        }
        [HttpPost]
        public ActionResult user_registration(string name, string password, string gender, string address, string number)
        {
            string aname = name.ToString();
            string apassword = password.ToString();
            string agender = gender.ToString();
            string aaddress = address.ToString();
            string anumber = number.ToString();
            ViewBag.name = "name: " + aname;
            ViewBag.password = "Password: " + apassword;
            ViewBag.gender = "Gender: " + agender;
            ViewBag.address = "Address: " + aaddress;
            ViewBag.number="Number: "+anumber;
            return View("user_registration");
        }
        public IActionResult Privacy()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
