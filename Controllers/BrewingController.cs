using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FilteredCoffee;
using FilteredCoffee.Data;

namespace FilteredCoffee.Controllers
{
    public class BrewingController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BrewingController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Brewing
        public async Task<IActionResult> Index()
        {
            return View(await _context.Brewing.ToListAsync());
        }

        // GET: Brewing/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var brewing = await _context.Brewing
                .FirstOrDefaultAsync(m => m.Id == id);
            if (brewing == null)
            {
                return NotFound();
            }

            return View(brewing);
        }

        // GET: Brewing/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Brewing/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CoffeeAmountGrams,GrinderUsed,GrindLevelInClicks,WaterTemperature,BrewingTime")] Brewing brewing)
        {
            if (ModelState.IsValid)
            {
                _context.Add(brewing);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(brewing);
        }

        // GET: Brewing/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var brewing = await _context.Brewing.FindAsync(id);
            if (brewing == null)
            {
                return NotFound();
            }
            return View(brewing);
        }

        // POST: Brewing/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CoffeeAmountGrams,GrinderUsed,GrindLevelInClicks,WaterTemperature,BrewingTime")] Brewing brewing)
        {
            if (id != brewing.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(brewing);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BrewingExists(brewing.Id))
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
            return View(brewing);
        }

        // GET: Brewing/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var brewing = await _context.Brewing
                .FirstOrDefaultAsync(m => m.Id == id);
            if (brewing == null)
            {
                return NotFound();
            }

            return View(brewing);
        }

        // POST: Brewing/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var brewing = await _context.Brewing.FindAsync(id);
            if (brewing != null)
            {
                _context.Brewing.Remove(brewing);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BrewingExists(int id)
        {
            return _context.Brewing.Any(e => e.Id == id);
        }
    }
}
