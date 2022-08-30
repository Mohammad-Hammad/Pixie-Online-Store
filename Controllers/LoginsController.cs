using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebApplication11.Models;

namespace WebApplication11.Controllers
{
    public class LoginsController : Controller
    {
        private readonly ModelContext _context;
        public LoginsController(ModelContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var item = _context.Userlogins.Where(x => x.Username == username && x.Password == password).SingleOrDefault();
            const string id = "id";
            if (item != null)
            {
                switch (item.Roleid)
                {
                    case 1:
                        {
                            HttpContext.Session.SetInt32(id,(int)item.Customerid.Value);
                            return RedirectToAction("Index", "Admindashboard");
                            break;
                        }
                    case 2:
                        {
                            HttpContext.Session.SetInt32(id, (int)item.Customerid.Value);
                            return RedirectToAction("Index", "Homepageview");
                            break;
                        }
                    case 3:
                        {
                            HttpContext.Session.SetInt32(id, (int)item.Customerid.Value);
                            return RedirectToAction("Index", "Accountantdashboard");
                            break;
                        }
                }
            }
            else
            {

                return View();
            }
            return View();
        }
    }
}
