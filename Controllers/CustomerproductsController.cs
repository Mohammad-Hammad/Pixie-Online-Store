using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication11.Models;

namespace WebApplication11.Controllers
{
    public class CustomerproductsController : Controller
    {
        private readonly ModelContext _context;

        public CustomerproductsController(ModelContext context)
        {
            _context = context;
        }

        // GET: Customerproducts
        public async Task<IActionResult> Index()
        {
            var modelContext = _context.Customerproducts.Include(c => c.Customer).Include(c => c.Product);
            return View(await modelContext.ToListAsync());
        }

        // GET: Customerproducts/Details/5
        public async Task<IActionResult> Details(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerproduct = await _context.Customerproducts
                .Include(c => c.Customer)
                .Include(c => c.Product)
                .FirstOrDefaultAsync(m => m.CpId == id);
            if (customerproduct == null)
            {
                return NotFound();
            }

            return View(customerproduct);
        }

        // GET: Customerproducts/Create
        public IActionResult Create()
        {
            ViewData["Customerid"] = new SelectList(_context.Customers, "CusId", "CusId");
            ViewData["Productid"] = new SelectList(_context.Products, "ProId", "ProId");
            return View();
        }

        // POST: Customerproducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CpId,Productid,Customerid,Quantity,Datefrom,Dateto")] Customerproduct customerproduct)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customerproduct);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Customerid"] = new SelectList(_context.Customers, "CusId", "CusId", customerproduct.Customerid);
            ViewData["Productid"] = new SelectList(_context.Products, "ProId", "ProId", customerproduct.Productid);
            return View(customerproduct);
        }

        // GET: Customerproducts/Edit/5
        public async Task<IActionResult> Edit(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerproduct = await _context.Customerproducts.FindAsync(id);
            if (customerproduct == null)
            {
                return NotFound();
            }
            ViewData["Customerid"] = new SelectList(_context.Customers, "CusId", "CusId", customerproduct.Customerid);
            ViewData["Productid"] = new SelectList(_context.Products, "ProId", "ProId", customerproduct.Productid);
            return View(customerproduct);
        }

        // POST: Customerproducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(decimal id, [Bind("CpId,Productid,Customerid,Quantity,Datefrom,Dateto")] Customerproduct customerproduct)
        {
            if (id != customerproduct.CpId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customerproduct);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerproductExists(customerproduct.CpId))
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
            ViewData["Customerid"] = new SelectList(_context.Customers, "CusId", "CusId", customerproduct.Customerid);
            ViewData["Productid"] = new SelectList(_context.Products, "ProId", "ProId", customerproduct.Productid);
            return View(customerproduct);
        }

        // GET: Customerproducts/Delete/5
        public async Task<IActionResult> Delete(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerproduct = await _context.Customerproducts
                .Include(c => c.Customer)
                .Include(c => c.Product)
                .FirstOrDefaultAsync(m => m.CpId == id);
            if (customerproduct == null)
            {
                return NotFound();
            }

            return View(customerproduct);
        }

        // POST: Customerproducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(decimal id)
        {
            var customerproduct = await _context.Customerproducts.FindAsync(id);
            _context.Customerproducts.Remove(customerproduct);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerproductExists(decimal id)
        {
            return _context.Customerproducts.Any(e => e.CpId == id);
        }
    }
}
