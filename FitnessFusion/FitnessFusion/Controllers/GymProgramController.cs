using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FitnessFusion.Data;
using FitnessFusion.Models;

namespace FitnessFusion.Controllers
{
    public class GymProgramController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GymProgramController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: GymProgram
        public async Task<IActionResult> Index()
        {
            return View(await _context.GymProgram.ToListAsync());
        }

        // GET: GymProgram/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gymProgram = await _context.GymProgram
                .FirstOrDefaultAsync(m => m.ID == id);
            if (gymProgram == null)
            {
                return NotFound();
            }

            return View(gymProgram);
        }

        // GET: GymProgram/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GymProgram/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Description,Overview,Type")] GymProgram gymProgram)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gymProgram);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(gymProgram);
        }

        // GET: GymProgram/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gymProgram = await _context.GymProgram.FindAsync(id);
            if (gymProgram == null)
            {
                return NotFound();
            }
            return View(gymProgram);
        }

        // POST: GymProgram/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Description,Overview,Type")] GymProgram gymProgram)
        {
            if (id != gymProgram.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gymProgram);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GymProgramExists(gymProgram.ID))
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
            return View(gymProgram);
        }

        // GET: GymProgram/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gymProgram = await _context.GymProgram
                .FirstOrDefaultAsync(m => m.ID == id);
            if (gymProgram == null)
            {
                return NotFound();
            }

            return View(gymProgram);
        }

        // POST: GymProgram/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gymProgram = await _context.GymProgram.FindAsync(id);
            _context.GymProgram.Remove(gymProgram);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GymProgramExists(int id)
        {
            return _context.GymProgram.Any(e => e.ID == id);
        }
    }
}
