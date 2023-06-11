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

namespace FitnessFusion.Controllers
{

    [Authorize(Roles = "User")]
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult TestCiljeva()
        {
            var questions = GetTestQuestions();
            return View(questions);
        }

        private List<Question> GetTestQuestions()
        {
            // Hardcoded list of questions
            return new List<Question>
        {
            new Question
            {
                Text = "1. Koliko imate godina?",
                Answers = new List<string>
                {
                },
                SubmittedAnswer = new List<string> { "" }
            },
                new Question
            {
                Text = "2. Spol",
                Answers = new List<string>
                {
                    "M",
                    "Ž",
                },
                SubmittedAnswer = new List<string> { "" }
            },
                    new Question
            {
                Text = "3. Masa i visina",
                Answers = new List<string>
                {
                },
                SubmittedAnswer = new List<string> { "", "" }
            },
                new Question
            {
                Text = "4. Koliko ste vremena spremni izdvojiti za vježbanje?",
                Answers = new List<string>
                {
                    "1-3 dana sedmično",
                    "3-5 dana sedmično",
                    "5-7 dana sedmično",
                },
                SubmittedAnswer = new List<string> { "" }
            },
                    new Question
            {
                Text = "5. Koji je vaš cilj? (moguće selektovati više)",
                Answers = new List<string>
                {
                    "Cardio",
                    "Weight loss",
                    "Building muscle",
                    "Stay in shape (mild)"
                },
                SubmittedAnswer = new List<string> { "", "", "", "" }

            },
                     new Question
            {
                Text = "6. Ako ste za cilj izabrali 'Building muscle', " +
                "da li ste posebno zainteresovani za fokus na gradnju mišića ili gradnju snage?",
                Answers = new List<string>
                {
                    "Zainteresovan/a sam za programe sa naglaskom na mišićnu hipertrofiju",
                    "Zainteresovan/a sam za programe koji maksimiziraju napredovanje u snazi",
                    "Svejedno mi je"
                },
                SubmittedAnswer = new List<string> { "" }

            },
                     new Question
            {
                Text = "7. Ako ste za cilj izabrali 'Stay in shape (mild)', " +
                "jeste li zainteresovani za aktivnosti nižeg intenziteta ili nešto dinamičniju vježbu?",
                Answers = new List<string>
                {
                    "Aktivnosti niskog intenziteta",
                    "Dinamičnije aktivnosti"
                },
                SubmittedAnswer = new List<string> { "" }

            },
                            new Question
            {
                Text = "8. Da li konzumirate cigarete?",
                Answers = new List<string>
                {
                    "DA",
                    "NE",
                },
                SubmittedAnswer = new List<string> { "" }

            },
                             new Question
            {
                Text = "9. Da li imate zdravstvene probleme? (moguće selektovati više)",
                Answers = new List<string>
                {
                    "Srčani problemi",
                    "Hronična oboljenja",
                    "Fizički problemi",
                    "NE",
                },
                SubmittedAnswer = new List<string> { "", "", "", "" }

            }

        };
        }

        // GET: User
        
        public async Task<IActionResult> Index()
        {
            return View();
            //var applicationDbContext = _context.User.Include(u => u.ApplicationUser).Include(u => u.GymProgram);
            //return View(await applicationDbContext.ToListAsync());
        }
        

        // GET: User/Details/5
        /*
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User
                .Include(u => u.ApplicationUser)
                .Include(u => u.GymProgram)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }
        */

        // GET: User/Create
        /*
        public IActionResult Create()
        {
            ViewData["ApplicationUserId"] = new SelectList(_context.Set<ApplicationUser>(), "Id", "Id");
            ViewData["GymProgramId"] = new SelectList(_context.GymProgram, "Id", "Id");
            return View();
        }
        */

        // POST: User/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        /*
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ApplicationUserId,GymProgramId,ActivityCoefficient")] User user)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ApplicationUserId"] = new SelectList(_context.Set<ApplicationUser>(), "Id", "Id", user.ApplicationUserId);
            ViewData["GymProgramId"] = new SelectList(_context.GymProgram, "Id", "Id", user.GymProgramId);
            return View(user);
        }
        */

        // GET: User/Edit/5
        /*
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            ViewData["ApplicationUserId"] = new SelectList(_context.Set<ApplicationUser>(), "Id", "Id", user.ApplicationUserId);
            ViewData["GymProgramId"] = new SelectList(_context.GymProgram, "Id", "Id", user.GymProgramId);
            return View(user);
        }
        */

        // POST: User/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        /*
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ApplicationUserId,GymProgramId,ActivityCoefficient")] User user)
        {
            if (id != user.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.Id))
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
            ViewData["ApplicationUserId"] = new SelectList(_context.Set<ApplicationUser>(), "Id", "Id", user.ApplicationUserId);
            ViewData["GymProgramId"] = new SelectList(_context.GymProgram, "Id", "Id", user.GymProgramId);
            return View(user);
        }
        */

        // GET: User/Delete/5
        /*
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User
                .Include(u => u.ApplicationUser)
                .Include(u => u.GymProgram)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }
        */

        // POST: User/Delete/5
        /*
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var user = await _context.User.FindAsync(id);
            _context.User.Remove(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        */

        /*
        private bool UserExists(int id)
        {
            return _context.User.Any(e => e.Id == id);
        }
        */
    }
}
