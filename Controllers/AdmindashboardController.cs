using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using WebApplication11.Models;

namespace WebApplication11.Controllers
{
    public class AdmindashboardController : Controller
    {
        private readonly ModelContext _context;
        public AdmindashboardController(ModelContext context)
        {
            _context = context;
        }
        string id = "id";
        public IActionResult Index()
        {
            ViewBag.id = HttpContext.Session.GetInt32(id);
            var item1 = _context.Users.Where(x=>x.UserId.Equals(id)).SingleOrDefault();
            return View();
        }
        public IActionResult SearchOrders()
        {
            return View(_context.Orders.ToList());
        }
        [HttpPost]
        public IActionResult SearchOrders(DateTime? start, DateTime? end)
        {
            var item = _context.Orders.Where(x => x.OrderAt >= start && x.OrderAt <= end).ToList();
            return View(item);
        }
        public IActionResult Profit()
        {
            ViewBag.Totalsale = _context.Orders.Sum(x => x.Totalprice);
            ViewBag.Totalsalary = _context.Users.Sum(x => x.Salary);
            var item1 = _context.Users.ToList();
            var item2 = _context.Orders.ToList();
            var model = Tuple.Create<IEnumerable<WebApplication11.Models.User>,IEnumerable<WebApplication11.Models.Order>>(item1,item2);
            return View(model);
        }
        public IActionResult ManagePages()
        {
            return View();
        }
    }
}
