using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CodeGin.Data;
using CodeGin.Models;

namespace codegin_server.Controllers
{
    public class ReactionsController : Controller
    {
        private readonly CodeGinContext _context;

        public ReactionsController(CodeGinContext context)
        {
            _context = context;
        }

        // GET: Reactions
        public async Task<IActionResult> Index()
        {
            return View(await _context.Reactions.ToListAsync());
        }

        // GET: Reactions/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reaction = await _context.Reactions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reaction == null)
            {
                return NotFound();
            }

            return View(reaction);
        }

        // GET: Reactions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Reactions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PublicationId,UserId,Type")] Reaction reaction)
        {
            if (ModelState.IsValid)
            {
                reaction.Id = Guid.NewGuid();
                _context.Add(reaction);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(reaction);
        }

        // GET: Reactions/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reaction = await _context.Reactions.FindAsync(id);
            if (reaction == null)
            {
                return NotFound();
            }
            return View(reaction);
        }

        // POST: Reactions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,PublicationId,UserId,Type")] Reaction reaction)
        {
            if (id != reaction.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reaction);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReactionExists(reaction.Id))
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
            return View(reaction);
        }

        // GET: Reactions/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reaction = await _context.Reactions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reaction == null)
            {
                return NotFound();
            }

            return View(reaction);
        }

        // POST: Reactions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var reaction = await _context.Reactions.FindAsync(id);
            if (reaction != null)
            {
                _context.Reactions.Remove(reaction);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReactionExists(Guid id)
        {
            return _context.Reactions.Any(e => e.Id == id);
        }
    }
}
