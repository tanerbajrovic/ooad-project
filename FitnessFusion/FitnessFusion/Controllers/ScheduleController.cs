using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FitnessFusion.Data;
using FitnessFusion.Models;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace FitnessFusion.Controllers
{
    public class ScheduleController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ScheduleController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Schedule
        [Authorize(Roles = "User,Trainer")]
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Schedule.Include(s => s.Trainer).Include(s => s.User);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Schedule/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var schedule = await _context.Schedule
                .Include(s => s.Trainer)
                .Include(s => s.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (schedule == null)
            {
                return NotFound();
            }

            return View(schedule);
        }

        // GET: Schedule/Create
        [Authorize(Roles = "Trainer")]
        public IActionResult Create()
        {
            ViewData["TrainerId"] = new SelectList(_context.Set<Trainer>(), "Id", "Id");
            ViewData["UserId"] = new SelectList(_context.Set<User>(), "Id", "Id");
            return View();
        }

        [Authorize(Roles = "Trainer")]
        // POST: Schedule/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,TrainerId,StartDate,EndDate")] Schedule schedule)
        {
            if (ModelState.IsValid)
            {
                _context.Add(schedule);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TrainerId"] = new SelectList(_context.Set<Trainer>(), "Id", "Id", schedule.TrainerId);
            ViewData["UserId"] = new SelectList(_context.Set<User>(), "Id", "Id", schedule.UserId);
            return View(schedule);
        }

        // GET: Schedule/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var schedule = await _context.Schedule.FindAsync(id);
            if (schedule == null)
            {
                return NotFound();
            }
            ViewData["TrainerId"] = new SelectList(_context.Set<ApplicationUser>(), "Id", "Id", schedule.TrainerId);
            ViewData["UserId"] = new SelectList(_context.Set<ApplicationUser>(), "Id", "Id", schedule.UserId);
            return View(schedule);
        }

        // POST: Schedule/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "User,Trainer")]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,TrainerId,StartDate,EndDate")] Schedule schedule)
        {
            if (id != schedule.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(schedule);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ScheduleExists(schedule.Id))
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
            ViewData["TrainerId"] = new SelectList(_context.Set<Trainer>(), "Id", "Id", schedule.TrainerId);
            ViewData["UserId"] = new SelectList(_context.Set<User>(), "Id", "Id", schedule.UserId);
            return View(schedule);
        }

        // GET: Schedule/Delete/5
        [Authorize(Roles = "Trainer")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var schedule = await _context.Schedule
                .Include(s => s.Trainer)
                .Include(s => s.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (schedule == null)
            {
                return NotFound();
            }

            return View(schedule);
        }

        // POST: Schedule/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Trainer")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var schedule = await _context.Schedule.FindAsync(id);
            _context.Schedule.Remove(schedule);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ScheduleExists(int id)
        {
            return _context.Schedule.Any(e => e.Id == id);
        }
    }
}
