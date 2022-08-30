using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication11.Models;

namespace WebApplication11.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ModelContext _context;
        public HomeController(ILogger<HomeController> logger,ModelContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
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
        public IActionResult insertForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult insertForm(string fullname, string firstname, string lastname, string username, string password)
        {
            User u = new User();
            u.Fullname = fullname;
            _context.Users.Add(u);
            _context.SaveChanges();
            Customer c1 = new Customer();
            c1.Fname = firstname;
            c1.Lname = lastname;
            _context.Customers.Add(c1);
            _context.SaveChanges();
            Userlogin ul = new Userlogin();
            ul.Username = username;
            ul.Password = password;
            ul.Roleid = 2;
            _context.Userlogins.Add(ul);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
