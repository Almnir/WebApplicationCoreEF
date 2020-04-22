using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplicationCoreEF.Models;

namespace WebApplicationCoreEF.Views
{
    public class EntrantsController : Controller
    {
        private readonly gvuz_start_openContext _context;

        public EntrantsController(gvuz_start_openContext context)
        {
            _context = context;
        }

        // GET: Entrants
        public async Task<IActionResult> Index()
        {
            var gvuz_start_openContext = _context.Entrant.
                Include(e => e.FactAddress).
                Include(e => e.Gender).
                Include(e => e.IdentityDocument).
                Include(e => e.Institution).
                Include(e => e.Person).
                Include(e => e.RegistrationAddress).
                Take(50);
            return View(await gvuz_start_openContext.ToListAsync());
        }

        // GET: Entrants/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entrant = await _context.Entrant
                .Include(e => e.FactAddress)
                .Include(e => e.Gender)
                .Include(e => e.IdentityDocument)
                .Include(e => e.Institution)
                .Include(e => e.Person)
                .Include(e => e.RegistrationAddress)
                .FirstOrDefaultAsync(m => m.EntrantId == id);
            if (entrant == null)
            {
                return NotFound();
            }

            return View(entrant);
        }

        // GET: Entrants/Create
        public IActionResult Create()
        {
            ViewData["FactAddressId"] = new SelectList(_context.Address, "AddressId", "AddressId");
            ViewData["GenderId"] = new SelectList(_context.GenderType, "GenderId", "Name");
            ViewData["IdentityDocumentId"] = new SelectList(_context.EntrantDocument, "EntrantDocumentId", "DocumentSpecificData");
            ViewData["InstitutionId"] = new SelectList(_context.Institution, "InstitutionId", "Ogrn");
            ViewData["PersonId"] = new SelectList(_context.Rvipersons, "PersonId", "NormSurname");
            ViewData["RegistrationAddressId"] = new SelectList(_context.Address, "AddressId", "AddressId");
            return View();
        }

        // POST: Entrants/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EntrantId,IdentityDocumentId,CustomInformation,Snils,RegistrationAddressId,FactAddressId,MobilePhone,Email,Uid,CreatedDate,ModifiedDate,InstitutionId,LastName,FirstName,MiddleName,GenderId,PersonId,PersonLinkDate,EntrantGuid")] Entrant entrant)
        {
            if (ModelState.IsValid)
            {
                _context.Add(entrant);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FactAddressId"] = new SelectList(_context.Address, "AddressId", "AddressId", entrant.FactAddressId);
            ViewData["GenderId"] = new SelectList(_context.GenderType, "GenderId", "Name", entrant.GenderId);
            ViewData["IdentityDocumentId"] = new SelectList(_context.EntrantDocument, "EntrantDocumentId", "DocumentSpecificData", entrant.IdentityDocumentId);
            ViewData["InstitutionId"] = new SelectList(_context.Institution, "InstitutionId", "Ogrn", entrant.InstitutionId);
            ViewData["PersonId"] = new SelectList(_context.Rvipersons, "PersonId", "NormSurname", entrant.PersonId);
            ViewData["RegistrationAddressId"] = new SelectList(_context.Address, "AddressId", "AddressId", entrant.RegistrationAddressId);
            return View(entrant);
        }

        // GET: Entrants/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entrant = await _context.Entrant.FindAsync(id);
            if (entrant == null)
            {
                return NotFound();
            }
            ViewData["FactAddressId"] = new SelectList(_context.Address, "AddressId", "AddressId", entrant.FactAddressId);
            ViewData["GenderId"] = new SelectList(_context.GenderType, "GenderId", "Name", entrant.GenderId);
            ViewData["IdentityDocumentId"] = new SelectList(_context.EntrantDocument, "EntrantDocumentId", "DocumentSpecificData", entrant.IdentityDocumentId);
            ViewData["InstitutionId"] = new SelectList(_context.Institution, "InstitutionId", "Ogrn", entrant.InstitutionId);
            ViewData["PersonId"] = new SelectList(_context.Rvipersons, "PersonId", "NormSurname", entrant.PersonId);
            ViewData["RegistrationAddressId"] = new SelectList(_context.Address, "AddressId", "AddressId", entrant.RegistrationAddressId);
            return View(entrant);
        }

        // POST: Entrants/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EntrantId,IdentityDocumentId,CustomInformation,Snils,RegistrationAddressId,FactAddressId,MobilePhone,Email,Uid,CreatedDate,ModifiedDate,InstitutionId,LastName,FirstName,MiddleName,GenderId,PersonId,PersonLinkDate,EntrantGuid")] Entrant entrant)
        {
            if (id != entrant.EntrantId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(entrant);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EntrantExists(entrant.EntrantId))
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
            ViewData["FactAddressId"] = new SelectList(_context.Address, "AddressId", "AddressId", entrant.FactAddressId);
            ViewData["GenderId"] = new SelectList(_context.GenderType, "GenderId", "Name", entrant.GenderId);
            ViewData["IdentityDocumentId"] = new SelectList(_context.EntrantDocument, "EntrantDocumentId", "DocumentSpecificData", entrant.IdentityDocumentId);
            ViewData["InstitutionId"] = new SelectList(_context.Institution, "InstitutionId", "Ogrn", entrant.InstitutionId);
            ViewData["PersonId"] = new SelectList(_context.Rvipersons, "PersonId", "NormSurname", entrant.PersonId);
            ViewData["RegistrationAddressId"] = new SelectList(_context.Address, "AddressId", "AddressId", entrant.RegistrationAddressId);
            return View(entrant);
        }

        // GET: Entrants/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entrant = await _context.Entrant
                .Include(e => e.FactAddress)
                .Include(e => e.Gender)
                .Include(e => e.IdentityDocument)
                .Include(e => e.Institution)
                .Include(e => e.Person)
                .Include(e => e.RegistrationAddress)
                .FirstOrDefaultAsync(m => m.EntrantId == id);
            if (entrant == null)
            {
                return NotFound();
            }

            return View(entrant);
        }

        // POST: Entrants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var entrant = await _context.Entrant.FindAsync(id);
            _context.Entrant.Remove(entrant);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EntrantExists(int id)
        {
            return _context.Entrant.Any(e => e.EntrantId == id);
        }
    }
}
