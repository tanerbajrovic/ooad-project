using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FitnessFusion.Data;
using FitnessFusion.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

namespace FitnessFusion.Controllers
{
    public class GymProgramController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public GymProgramController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: GymProgram
        [Authorize(Roles = "User")]
        [HttpPost]
        public async Task<IActionResult> Index(IFormCollection answers = null)

        {
            var programs = await processAnswers(answers);
            calculateAverageRatings(programs);
            return View(programs);
        }

        [Authorize(Roles = "User")]
        public async Task<IActionResult> AllPrograms()
        { 
            var programs = await _context.GymProgram.ToListAsync();
            calculateAverageRatings(programs);
            return View(programs);
        }

        [Authorize(Roles = "User")]
        public async Task<IActionResult> AddToUser(int programId)
        {
            var currentUser = await _userManager.GetUserAsync(User);
            var id = currentUser.Id;
            var user = await _context.User.FindAsync(id);
            if (currentUser != null)
            {
                user.GymProgramId = programId;
                await _userManager.UpdateAsync(currentUser);
            }
            return RedirectToAction("Details", "GymProgram", new { id = programId });
        }

        [Authorize(Roles = "User")]
        private void calculateAverageRatings(List<GymProgram> programs)
        {
            foreach (var program in programs)
            {
                List<Rating> ratingsList = _context.Rating.Where(r => r.GymProgramId == program.Id).ToList();
                List<double> ratingValues = new List<double>();
                foreach (var rating in ratingsList)
                {
                    ratingValues.Add(rating.RatingValue);
                }
                program.calculateAverageRating(ratingValues);
            }
        }

        /*
        Objasnjenje formata poslanih odgovora:

         question index	      list<string> SubmittedAnswer indexes
            [0]	                    [0] “23” npr., age
            [1]	                    [0] “M” / “Ž”, spol
            [2]	                    [0] “80”, masa [1] “175”, visina
            [3]	                    [0] "1-3 dana sedmično" npr.
            [4]	                    [0], [1], [2], [3] mogu ali ne moraju biti popunjeni
                                    "Cardio",
                                    "Weight loss",
                                    "Building muscle",
                                    "Stay in shape (mild)"
            [5]	                    [0] "Zainteresovan/a sam za programe sa naglaskom na mišićnu hipertrofiju" npr.
            [6]	                    [0] "Aktivnosti niskog intenziteta" npr.
            [7]	                    [0] “DA” npr.
            [8]	                    [0], [1], [2], [3] mogu ali ne moraju biti popunjeni
                                    "Srčani problemi",
                                    "Hronična oboljenja",
                                    "Fizički problemi",
                                    "NE",
        */
        [Authorize(Roles = "User")]
        private async Task<List<GymProgram>> processAnswers(IFormCollection answers)

        {
            List<GymProgram> programs = await _context.GymProgram.ToListAsync();
            if (int.Parse(answers["Model[0].SubmittedAnswer[0]"]) > 60)
            {
                programs.RemoveAll(program => program.Type == GymProgramType.Strength);
            }
            if (answers["Model[1].SubmittedAnswer[0]"] == "M")
            {
                programs.RemoveAll(program => program.Name == "Glutes&Abs");
                programs.RemoveAll(program => program.Name == "Hourglass Body Program");
            }
            else
            {
                programs.RemoveAll(program => program.Name == "Push Pull Legs");
                programs.RemoveAll(program => program.Name == "Upper Lower");
                programs.RemoveAll(program => program.Name == "Full Body");
                programs.RemoveAll(program => program.Name == "Power Program");
                programs.RemoveAll(program => program.Name == "5x5");
            }
            if (answers["Model[3].SubmittedAnswer[0]"] == "1-3 dana sedmično")
            {
                programs.RemoveAll(program => program.Name == "Push Pull Legs");
                programs.RemoveAll(program => program.Name == "Upper Lower");
                programs.RemoveAll(program => program.Name == "Power Program");
                programs.RemoveAll(program => program.Name == "Pyramid");
                programs.RemoveAll(program => program.Name == "Yoga");
                programs.RemoveAll(program => program.Name == "Pilates");
            }
            else if (answers["Model[3].SubmittedAnswer[0]"] == "3-5 dana sedmično")
            {
                programs.RemoveAll(program => program.Name == "Push Pull Legs");
            }
            // odabran cardio a ostali nisu
            if ((answers["Model[4].SubmittedAnswer[0]"] != "" || answers["Model[4].SubmittedAnswer[1]"] != "") && answers["Model[4].SubmittedAnswer[2]"] == "" && answers["Model[4].SubmittedAnswer[3]"] == "")
            {
                programs.RemoveAll(program => program.Type != GymProgramType.Endurance);
            }
            // odabran cardio i muscle building
            else if ((answers["Model[4].SubmittedAnswer[0]"] != "" || answers["Model[4].SubmittedAnswer[1]"] != "") && answers["Model[4].SubmittedAnswer[2]"] != "" && answers["Model[4].SubmittedAnswer[3]"] == "")
            {
                programs.RemoveAll(program => program.Type == GymProgramType.Flexibility);
                programs.RemoveAll(program => program.Type == GymProgramType.Balance);
            }
            // odabran cardio i mild exercise
            else if ((answers["Model[4].SubmittedAnswer[0]"] != "" || answers["Model[4].SubmittedAnswer[1]"] != "") && answers["Model[4].SubmittedAnswer[2]"] == "" && answers["Model[4].SubmittedAnswer[3]"] != "")
            {
                programs.RemoveAll(program => program.Type == GymProgramType.Strength);
            }
            // odabran muscle building a ostali nisu
            else if ((answers["Model[4].SubmittedAnswer[0]"] == "" || answers["Model[4].SubmittedAnswer[1]"] == "") && answers["Model[4].SubmittedAnswer[2]"] != "" && answers["Model[4].SubmittedAnswer[3]"] == "")
            {
                programs.RemoveAll(program => program.Type != GymProgramType.Strength);
            }
            // odabran muscle building i mild exercise
            else if ((answers["Model[4].SubmittedAnswer[0]"] == "" || answers["Model[4].SubmittedAnswer[1]"] == "") && answers["Model[4].SubmittedAnswer[3]"] != "")
            {
                programs.RemoveAll(program => program.Type == GymProgramType.Endurance && program.Name != "Zumba");
            }
            // odabran mild exercise a ostali nisu
            else if ((answers["Model[4].SubmittedAnswer[0]"] == "" || answers["Model[4].SubmittedAnswer[1]"] == "") && answers["Model[4].SubmittedAnswer[2]"] == "" && answers["Model[4].SubmittedAnswer[3]"] != "")
            {
                programs.RemoveAll(program => program.Type == GymProgramType.Endurance && program.Name != "Zumba");
                programs.RemoveAll(program => program.Type == GymProgramType.Strength);
            }
            if (answers["Model[5].SubmittedAnswer[0]"] == "Zainteresovan/a sam za programe sa naglaskom na mišićnu hipertrofiju")
            {
                programs.RemoveAll(program => program.Name == "5x5");
                programs.RemoveAll(program => program.Name == "Power Program");
            }
            else if (answers["Model[5].SubmittedAnswer[0]"] == "Zainteresovan/a sam za programe koji maksimiziraju napredovanje u snazi")
            {
                programs.RemoveAll(program => program.Name == "Push Pull Legs");
                programs.RemoveAll(program => program.Name == "Upper Lower");
                programs.RemoveAll(program => program.Name == "Full Body");
            }
            if (answers["Model[6].SubmittedAnswer[0]"] == "Aktivnosti niskog intenziteta")
            {
                programs.RemoveAll(program => program.Name == "Zumba");
                programs.RemoveAll(program => program.Name == "Aerobic");
            }
            else
            {
                programs.RemoveAll(program => program.Name == "Yoga");
                programs.RemoveAll(program => program.Name == "Pilates");
            }
            if (answers["Model[7].SubmittedAnswer[0]"] == "DA")
            {
                programs.RemoveAll(program => program.Type == GymProgramType.Endurance && program.Name != "FitnessFusion Light" && program.Name != "Zumba");
            }
            // srcana oboljenja
            if (answers["Model[8].SubmittedAnswer[0]"] != "" && answers["Model[8].SubmittedAnswer[3]"] == "")
            {
                programs.RemoveAll(program => program.Type == GymProgramType.Endurance && program.Name != "FitnessFusion Light" && program.Name != "Zumba");
                programs.RemoveAll(program => program.Name == "Power Program");
                programs.RemoveAll(program => program.Name == "5x5");
            }
            // hronicna oboljenja
            if (answers["Model[8].SubmittedAnswer[1]"] != "" && answers["Model[8].SubmittedAnswer[3]"] == "")
            {
                programs.RemoveAll(program => program.Type == GymProgramType.Endurance && program.Name != "FitnessFusion Light" && program.Name != "Zumba");
                programs.RemoveAll(program => program.Name == "Power Program");
                programs.RemoveAll(program => program.Name == "Full Body");
                programs.RemoveAll(program => program.Name == "5x5");
            }
            // fizicki problemi
            if (answers["Model[8].SubmittedAnswer[2]"] != "" && answers["Model[8].SubmittedAnswer[3]"] == "")
            {
                programs.RemoveAll(program => program.Type == GymProgramType.Strength);
                programs.RemoveAll(program => program.Type == GymProgramType.Endurance && program.Name != "Zumba");
            }
            return programs;
        }


        // GET: GymProgram/Details/5
        [Authorize(Roles = "User")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gymProgram = await _context.GymProgram
                .FirstOrDefaultAsync(m => m.Id == id);
            if (gymProgram == null)
            {
                return NotFound();
            }

            return View(gymProgram);
        }

        /*

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
        public async Task<IActionResult> Create([Bind("Id,Name,Description,Overview,Type")] GymProgram gymProgram)
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
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,Overview,Type")] GymProgram gymProgram)
        {
            if (id != gymProgram.Id)
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
                    if (!GymProgramExists(gymProgram.Id))
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
                .FirstOrDefaultAsync(m => m.Id == id);
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
            return _context.GymProgram.Any(e => e.Id == id);
        }
        */
    }
}
