using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VolleyDamois.Models;

namespace VolleyDamois.Controllers
{
    public class PoulesController : Controller
    {
        private readonly VolleyDamoisDbContext _context;

        public PoulesController(VolleyDamoisDbContext context)
        {
            _context = context;
        }

        // GET: Poules
        public async Task<IActionResult> Index()
        {
            return View(await _context.Poules
                .Include( p => p.Teams).ThenInclude(t => t.Category)
                .ToListAsync());
        }

        // GET: Poules/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var poule = await _context.Poules
                .FirstOrDefaultAsync(m => m.id == id);
            if (poule == null)
            {
                return NotFound();
            }

            return View(poule);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create()
        {
            PouleBuilder builderPoule = new PouleBuilder();
            MatchBuilderDay1 builderMatch = new MatchBuilderDay1(_context.Level.Where(l => l.LevelConfrotation == LevelMatch.Poule).First());
            var teamsRequest = _context.Team.Include(x => x.Players).Include(x => x.Category);
            IList<Team> teams = teamsRequest.ToList();
            IList<Poule> poules = builderPoule.createPoulesForEachCategories(teams);
            foreach (Poule poul in poules)
            {
                _context.Poules.Add(poul);
                _context.SaveChanges();
            }

            _context.Matches.AddRange(
                builderMatch.createMatchesforPoule(
                    _context.Poules.ToList(),
                    _context.Field.Where(f => f.FieldCategory.Category == Category.Nationale).ToList(),
                    _context.State.Where(s => s.StateMatch == StateMatch.planned).First())
            );
            _context.SaveChanges();
            

            

            return RedirectToAction(nameof(Index));
        }

        // POST: Poules/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Name")] Poule poule)
        {
            return View();
        }

        // GET: Poules/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var poule = await _context.Poules.FindAsync(id);
            if (poule == null)
            {
                return NotFound();
            }
            return View(poule);
        }

        // POST: Poules/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Name")] Poule poule)
        {
            if (id != poule.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(poule);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PouleExists(poule.id))
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
            return View(poule);
        }

        // GET: Poules/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var poule = await _context.Poules
                .FirstOrDefaultAsync(m => m.id == id);
            if (poule == null)
            {
                return NotFound();
            }

            return View(poule);
        }

        // POST: Poules/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var poule = await _context.Poules.FindAsync(id);
            _context.Poules.Remove(poule);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PouleExists(int id)
        {
            return _context.Poules.Any(e => e.id == id);
        }
    }
}
