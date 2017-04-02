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
    public class UserOrganizationInterestsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserOrganizationInterestsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: UserOrganizationInterests
        public async Task<IActionResult> Index()
        {
            return View(await _context.UserOrganizationInterest.ToListAsync());
        }

        // GET: UserOrganizationInterests/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userOrganizationInterest = await _context.UserOrganizationInterest
                .SingleOrDefaultAsync(m => m.Id == id);
            if (userOrganizationInterest == null)
            {
                return NotFound();
            }

            return View(userOrganizationInterest);
        }

        // GET: UserOrganizationInterests/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UserOrganizationInterests/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,OrganizationId,InterestId")] PersonOrganizationInterest userOrganizationInterest)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userOrganizationInterest);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(userOrganizationInterest);
        }

        // GET: UserOrganizationInterests/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userOrganizationInterest = await _context.UserOrganizationInterest.SingleOrDefaultAsync(m => m.Id == id);
            if (userOrganizationInterest == null)
            {
                return NotFound();
            }
            return View(userOrganizationInterest);
        }

        // POST: UserOrganizationInterests/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,OrganizationId,InterestId")] PersonOrganizationInterest userOrganizationInterest)
        {
            if (id != userOrganizationInterest.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userOrganizationInterest);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserOrganizationInterestExists(userOrganizationInterest.Id))
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
            return View(userOrganizationInterest);
        }

        // GET: UserOrganizationInterests/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userOrganizationInterest = await _context.UserOrganizationInterest
                .SingleOrDefaultAsync(m => m.Id == id);
            if (userOrganizationInterest == null)
            {
                return NotFound();
            }

            return View(userOrganizationInterest);
        }

        // POST: UserOrganizationInterests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userOrganizationInterest = await _context.UserOrganizationInterest.SingleOrDefaultAsync(m => m.Id == id);
            _context.UserOrganizationInterest.Remove(userOrganizationInterest);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool UserOrganizationInterestExists(int id)
        {
            return _context.UserOrganizationInterest.Any(e => e.Id == id);
        }
    }
}
