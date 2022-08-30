using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebApplication11.Models;

namespace WebApplication11.Controllers
{
    public class HomepageviewController : Controller
    {
        private readonly ModelContext _context;
        public HomepageviewController(ModelContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var item = _context.Productpages.ToList();
            return View(item);
        }
        public IActionResult Products()
        {
            var item = _context.Productpages.ToList();
            return View(item);
        }       
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
    }
}
