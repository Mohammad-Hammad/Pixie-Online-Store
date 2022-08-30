using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication11.Models;

namespace WebApplication11.Controllers
{
    public class ProductpagesController : Controller
    {
        private readonly ModelContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;
        public ProductpagesController(ModelContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }

        // GET: Productpages
        public async Task<IActionResult> Index()
        {
            return View(await _context.Productpages.ToListAsync());
        }

        // GET: Productpages/Details/5
        public async Task<IActionResult> Details(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productpage = await _context.Productpages
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productpage == null)
            {
                return NotFound();
            }

            return View(productpage);
        }

        // GET: Productpages/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Productpages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Imagename,Productname,Productprice,ImageFile")] Productpage productpage)
        {
            if (ModelState.IsValid)
            {
                string wwwroot = _hostEnvironment.WebRootPath;
                string name = Guid.NewGuid().ToString() + "_" + productpage.ImageFile.FileName;
                string pathofcopyofimage = Path.Combine(wwwroot + "/productpageimages/", name);
                using (var filestream = new FileStream(pathofcopyofimage, FileMode.Create))
                {
                    await productpage.ImageFile.CopyToAsync(filestream);
                }
                productpage.Imagename = name;//store name in DB
                _context.Add(productpage);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(productpage);
        }

        // GET: Productpages/Edit/5
        public async Task<IActionResult> Edit(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productpage = await _context.Productpages.FindAsync(id);
            if (productpage == null)
            {
                return NotFound();
            }
            return View(productpage);
        }

        // POST: Productpages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(decimal id, [Bind("Id,Imagename,Productname,Productprice")] Productpage productpage)
        {
            if (id != productpage.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productpage);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductpageExists(productpage.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(productpage);
        }

        // GET: Productpages/Delete/5
        public async Task<IActionResult> Delete(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productpage = await _context.Productpages
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productpage == null)
            {
                return NotFound();
            }

            return View(productpage);
        }

        // POST: Productpages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(decimal id)
        {
            var productpage = await _context.Productpages.FindAsync(id);
            _context.Productpages.Remove(productpage);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductpageExists(decimal id)
        {
            return _context.Productpages.Any(e => e.Id == id);
        }
    }
}
