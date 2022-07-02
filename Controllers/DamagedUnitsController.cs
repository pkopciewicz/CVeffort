using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CVeffort.Data;
using CVeffort.Models;
using Microsoft.AspNetCore.Authorization;

namespace CVeffort.Controllers
{
    public class DamagedUnitsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DamagedUnitsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: DamagedUnits
        public async Task<IActionResult> Index()
        {
            return View(await _context.DamagedUnits.ToListAsync());
        }

        // GET: DamagedUnits/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var damagedUnits = await _context.DamagedUnits
                .FirstOrDefaultAsync(m => m.Id == id);
            if (damagedUnits == null)
            {
                return NotFound();
            }

            return View(damagedUnits);
        }

        // GET: DamagedUnits/Create

        public IActionResult Create()
        {
            return View();
        }

        // POST: DamagedUnits/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,A1,A2,A3,A4,A5,A6,A7,A8,A9,A10,A11,A12,A13,A14,A15,B1,B2,B3,B4,B5,B6,B7,B8,B9,B10,B11,B12,B13,B14,B15,C1,C2,C3,C4,C5,C6,C7,C8,C9,C10,C11,C12,C13,C14,C15,D1,D2,D3,D4,D5,D6,D7,D8,D9,D10,D11,D12,D13,D14,D15,E1,E2,E3,E4,E5,E6,E7,E8,E9,E10,E11,E12,E13,E14,E15,F1,F2,F3,F4,F5,F6,F7,F8,F9,F10,F11,F12,F13,F14,F15,G1,G2,G3,G4,G5,G6,G7,G8,G9,G10,G11,G12,G13,G14,G15,H1,H2,H3,H4,H5,H6,H7,H8,H9,H10,H11,H12,H13,H14,H15,PipeEnding,WhenAdded,WhoAdded")] DamagedUnits damagedUnits)
        {
            if (ModelState.IsValid)
            {
                //Checking if ID is avileable
                var Units = from U in _context.DamagedUnits
                            select U;
                //Units = Units.Where(U => U.Id.Equals(damagedUnits.Id));
                Units = Units.Where(U => U.Id == damagedUnits.Id);
                bool hasElements = Units.Any();
                if (hasElements)
                {
                    return RedirectToAction("IdAlreadyExist", "Home");
                    //cos musi zwracać co zahamuje dodanie powtorzonego Id
                }
                //checking finished

                _context.Add(damagedUnits);

                //adding time
                damagedUnits.WhenAdded = DateTime.Now;
                //adding author of added element
                damagedUnits.WhoAdded = User.Identity.Name;

                await _context.SaveChangesAsync();
                //return RedirectToAction(nameof(Index));
                return RedirectToAction("Raporting", "Home");
            }
            return RedirectToAction("Raporting", "Home");
        }

        [Authorize]
        public async Task<IActionResult> ListOfRaportedElements() 
        {
            return View(await _context.DamagedUnits.ToListAsync());
        }

        // GET: DamagedUnits/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var damagedUnits = await _context.DamagedUnits.FindAsync(id);
            if (damagedUnits == null)
            {
                return NotFound();
            }
            if (User.Identity.Name == damagedUnits.WhoAdded)
            {
                return View(damagedUnits);
            }
            return RedirectToAction("ListOfRaportedElements");
        }

        // POST: DamagedUnits/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,A1,A2,A3,A4,A5,A6,A7,A8,A9,A10,A11,A12,A13,A14,A15,B1,B2,B3,B4,B5,B6,B7,B8,B9,B10,B11,B12,B13,B14,B15,C1,C2,C3,C4,C5,C6,C7,C8,C9,C10,C11,C12,C13,C14,C15,D1,D2,D3,D4,D5,D6,D7,D8,D9,D10,D11,D12,D13,D14,D15,E1,E2,E3,E4,E5,E6,E7,E8,E9,E10,E11,E12,E13,E14,E15,F1,F2,F3,F4,F5,F6,F7,F8,F9,F10,F11,F12,F13,F14,F15,G1,G2,G3,G4,G5,G6,G7,G8,G9,G10,G11,G12,G13,G14,G15,H1,H2,H3,H4,H5,H6,H7,H8,H9,H10,H11,H12,H13,H14,H15,PipeEnding,WhenAdded,WhoAdded")] DamagedUnits damagedUnits)
        {
            if (id != damagedUnits.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    //adding time
                    damagedUnits.WhenAdded = DateTime.Now;
                    //adding author of added element
                    damagedUnits.WhoAdded = User.Identity.Name;
                    _context.Update(damagedUnits);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DamagedUnitsExists(damagedUnits.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("ListOfRaportedElements");
            }
            return View(damagedUnits);
        }

        // GET: DamagedUnits/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var damagedUnits = await _context.DamagedUnits.FirstOrDefaultAsync(m => m.Id == id);
            if (damagedUnits == null)
            {
                return NotFound();
            }
            if (User.Identity.Name == damagedUnits.WhoAdded) 
            {
                return View(damagedUnits);
            }
            return RedirectToAction("ListOfRaportedElements");
        }

        // POST: DamagedUnits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var damagedUnits = await _context.DamagedUnits.FindAsync(id);
            _context.DamagedUnits.Remove(damagedUnits);
            await _context.SaveChangesAsync();
            return RedirectToAction("ListOfRaportedElements");
        }

        private bool DamagedUnitsExists(int id)
        {
            return _context.DamagedUnits.Any(e => e.Id == id);
        }

    }
}
