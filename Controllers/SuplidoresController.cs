using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FAcT.Data;
using FAcT.Models;

namespace FAcT.Controllers
{
    public class SuplidoresController : Controller
    {
        private readonly FAcTContext _context;

        public SuplidoresController(FAcTContext context)
        {
            _context = context;
        }

        // GET: Suplidores
        public async Task<IActionResult> Index()
        {
            return View(await _context.Suplidores.ToListAsync());
        }

        // GET: Suplidores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suplidores = await _context.Suplidores
                .FirstOrDefaultAsync(m => m.SuplidoresID == id);
            if (suplidores == null)
            {
                return NotFound();
            }

            return View(suplidores);
        }

        // GET: Suplidores/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Suplidores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SuplidoresID,nombre,apellidos,Documento,Direccion,Telefono,Celular,Correo")] Suplidores suplidores)
        {
            if (ModelState.IsValid)
            {
                _context.Add(suplidores);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(suplidores);
        }

        // GET: Suplidores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suplidores = await _context.Suplidores.FindAsync(id);
            if (suplidores == null)
            {
                return NotFound();
            }
            return View(suplidores);
        }

        // POST: Suplidores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SuplidoresID,nombre,apellidos,Documento,Direccion,Telefono,Celular,Correo")] Suplidores suplidores)
        {
            if (id != suplidores.SuplidoresID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(suplidores);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SuplidoresExists(suplidores.SuplidoresID))
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
            return View(suplidores);
        }

        // GET: Suplidores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suplidores = await _context.Suplidores
                .FirstOrDefaultAsync(m => m.SuplidoresID == id);
            if (suplidores == null)
            {
                return NotFound();
            }

            return View(suplidores);
        }

        // POST: Suplidores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var suplidores = await _context.Suplidores.FindAsync(id);
            _context.Suplidores.Remove(suplidores);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SuplidoresExists(int id)
        {
            return _context.Suplidores.Any(e => e.SuplidoresID == id);
        }
    }
}
