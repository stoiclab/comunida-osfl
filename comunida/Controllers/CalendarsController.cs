using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using comunida.Data;
using comunida.Models;

namespace comunida.Controllers
{
    public class CalendarsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CalendarsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Calendars
        public async Task<IActionResult> Index()
        {
            return View(await _context.Calendars.ToListAsync());
        }

        // GET: Calendars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var calendar = await _context.Calendars
                .SingleOrDefaultAsync(m => m.ID == id);
            if (calendar == null)
            {
                return NotFound();
            }

            return View(calendar);
        }

        // GET: Calendars/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Calendars/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Description,Start,End,Status,SlotLimit")] Calendar calendar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(calendar);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(calendar);
        }

        // GET: Calendars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var calendar = await _context.Calendars.SingleOrDefaultAsync(m => m.ID == id);
            if (calendar == null)
            {
                return NotFound();
            }
            return View(calendar);
        }

        // POST: Calendars/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Description,Start,End,Status,SlotLimit")] Calendar calendar)
        {
            if (id != calendar.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(calendar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CalendarExists(calendar.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(calendar);
        }

        // GET: Calendars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var calendar = await _context.Calendars
                .SingleOrDefaultAsync(m => m.ID == id);
            if (calendar == null)
            {
                return NotFound();
            }

            return View(calendar);
        }

        // POST: Calendars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var calendar = await _context.Calendars.SingleOrDefaultAsync(m => m.ID == id);
            _context.Calendars.Remove(calendar);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool CalendarExists(int id)
        {
            return _context.Calendars.Any(e => e.ID == id);
        }
    }
}
