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
    public class OrderproductsController : Controller
    {
        private readonly ModelContext _context;

        public OrderproductsController(ModelContext context)
        {
            _context = context;
        }

        // GET: Orderproducts
        public async Task<IActionResult> Index()
        {
            var modelContext = _context.Orderproducts.Include(o => o.Order).Include(o => o.Product);
            return View(await modelContext.ToListAsync());
        }

        // GET: Orderproducts/Details/5
        public async Task<IActionResult> Details(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderproduct = await _context.Orderproducts
                .Include(o => o.Order)
                .Include(o => o.Product)
                .FirstOrDefaultAsync(m => m.OrderproductId == id);
            if (orderproduct == null)
            {
                return NotFound();
            }

            return View(orderproduct);
        }

        // GET: Orderproducts/Create
        public IActionResult Create()
        {
            ViewData["Orderid"] = new SelectList(_context.Orders, "OrdId", "OrdId");
            ViewData["Productid"] = new SelectList(_context.Products, "ProId", "ProId");
            return View();
        }

        // POST: Orderproducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderproductId,Orderid,Productid")] Orderproduct orderproduct)
        {
            if (ModelState.IsValid)
            {
                _context.Add(orderproduct);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Orderid"] = new SelectList(_context.Orders, "OrdId", "OrdId", orderproduct.Orderid);
            ViewData["Productid"] = new SelectList(_context.Products, "ProId", "ProId", orderproduct.Productid);
            return View(orderproduct);
        }

        // GET: Orderproducts/Edit/5
        public async Task<IActionResult> Edit(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderproduct = await _context.Orderproducts.FindAsync(id);
            if (orderproduct == null)
            {
                return NotFound();
            }
            ViewData["Orderid"] = new SelectList(_context.Orders, "OrdId", "OrdId", orderproduct.Orderid);
            ViewData["Productid"] = new SelectList(_context.Products, "ProId", "ProId", orderproduct.Productid);
            return View(orderproduct);
        }

        // POST: Orderproducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(decimal id, [Bind("OrderproductId,Orderid,Productid")] Orderproduct orderproduct)
        {
            if (id != orderproduct.OrderproductId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(orderproduct);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderproductExists(orderproduct.OrderproductId))
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
            ViewData["Orderid"] = new SelectList(_context.Orders, "OrdId", "OrdId", orderproduct.Orderid);
            ViewData["Productid"] = new SelectList(_context.Products, "ProId", "ProId", orderproduct.Productid);
            return View(orderproduct);
        }

        // GET: Orderproducts/Delete/5
        public async Task<IActionResult> Delete(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderproduct = await _context.Orderproducts
                .Include(o => o.Order)
                .Include(o => o.Product)
                .FirstOrDefaultAsync(m => m.OrderproductId == id);
            if (orderproduct == null)
            {
                return NotFound();
            }

            return View(orderproduct);
        }

        // POST: Orderproducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(decimal id)
        {
            var orderproduct = await _context.Orderproducts.FindAsync(id);
            _context.Orderproducts.Remove(orderproduct);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderproductExists(decimal id)
        {
            return _context.Orderproducts.Any(e => e.OrderproductId == id);
        }
    }
}
