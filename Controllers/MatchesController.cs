using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VolleyDamois.Models;
using VolleyDamois.Models.Builder;
using VolleyDamois.Models.ViewModel;

namespace VolleyDamois.Controllers
{
    public class MatchesController : Controller
    {
        private readonly VolleyDamoisDbContext _context;

        public MatchesController(VolleyDamoisDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index() {
            ViewModelMatches vmMatches = new ViewModelMatches();
            vmMatches.FormatMatches(await getMatches());
            return View(vmMatches);
        }

       

        // GET: Matches/Details/5
        public async Task<IActionResult> Result()
        {
            ViewModelMatches vmMatches = new ViewModelMatches();
            vmMatches.FormatMatches(await getMatches());
            return View(vmMatches);
        }


        [Authorize(Roles="Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateMatches(List<ViewModelMatchesToUpdate> vmMtu) {

            List<Match> matches = await getMatches();
            foreach (ViewModelMatchesToUpdate vm in vmMtu)
            {
                Match currentMatch = matches.Where(m => m.Id == vm.Id).First();
                CheckValue(vm, currentMatch);
            }
            _context.SaveChanges();
            return Redirect("Result");
        }

        private static void CheckValue(ViewModelMatchesToUpdate vm, Match currentMatch)
        {
            if (vm.Set11 > 0) currentMatch.Team1Set1 = vm.Set11; else currentMatch.Team1Set1 = 0;
            if (vm.Set12 > 0) currentMatch.Team1Set2 = vm.Set12; else currentMatch.Team1Set2 = 0;
            if (vm.Set21 > 0) currentMatch.Team2Set1 = vm.Set21; else currentMatch.Team2Set1 = 0;
            if (vm.Set22 > 0) currentMatch.Team2Set2 = vm.Set22; else currentMatch.Team2Set2 = 0;
        }

        public async Task<IActionResult> Classement()
        {
            ClassementPoule classementPoule = new ClassementPoule(await getMatches(), await _context.Poules.Include(p => p.Teams).ToListAsync());
            ClassementDay2 classementDay2 = new ClassementDay2(await getMatches());
            ViewModelClassement vmClassement = new ViewModelClassement();
            vmClassement.classementDay1 = classementPoule.createClassementPoules();
            vmClassement.classementDay2 = classementDay2.MakeClassement();
            return View(vmClassement);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateMatchDay2()
        {
            ClassementPoule classementPoule = new ClassementPoule(await getMatches(),_context.Poules.Include(p => p.Teams).ToList());
            List<Level>levels = _context.Level.ToList();
            MatchBuilderDay1 mbuild = new MatchBuilderDay1(levels.Where(l => l.LevelConfrotation == LevelMatch.Seizième).First());
            List<Dictionary<Team, int[]>> poules = classementPoule.createClassementPoules();
            
            MatchBuilderDay2 day2Builder = new MatchBuilderDay2(await _context.Level.Where(l => l.LevelConfrotation == LevelMatch.Seizième).FirstAsync());
            List<Match> matchDay2 = day2Builder.createMatchesforDay2(poules,
                _context.Field.Include(f => f.FieldCategory).ToList(),
                _context.State.Where(s => s.StateMatch == StateMatch.planned).First());
            _context.Matches.AddRange(matchDay2);
            _context.SaveChanges();
            return Redirect("Classement");
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateFinalsMatch()
        {
            
            return Redirect("Classement");
        }

        private Task<List<Match>> getMatches()
        {
            return _context.Matches.Include(m => m.Team1)
                .Include(m => m.Team2)
                .Include(m => m.Arbitre)
                .Include(m => m.Terrain)
                .Include(m => m.State)
                .Include(m => m.level)
                .ToListAsync();
        }
    }


}
