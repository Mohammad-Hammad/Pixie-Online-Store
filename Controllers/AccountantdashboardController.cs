using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using WebApplication11.Models;

namespace WebApplication11.Controllers
{
    public class AccountantdashboardController : Controller
    {
        private readonly ModelContext _context;
        public AccountantdashboardController(ModelContext context)
        {
            _context = context;
        }
            public IActionResult Index()
        {
            return View();
        }
        public IActionResult SearchReports()
        {
            return View(_context.Orders.ToList());
        }
        [HttpPost]
        public IActionResult SearchReports(DateTime? start, DateTime? end)
        {
            var item = _context.Orders.Where(x => x.OrderAt >= start && x.OrderAt <= end).ToList();
            return View(item);
        }
        public IActionResult users()
        {
            return View(_context.ContactUs.ToList());
        }
    }
}
