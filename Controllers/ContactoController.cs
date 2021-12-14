using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MiPrimeraAplicacionWebASP.Models;

namespace MiPrimeraAplicacionWebASP.Controllers
{
    [Authorize]
    public class ContactoController : Controller
    {
        private readonly BaseContext _context;

        public ContactoController(BaseContext context)
        {
            _context = context;
        }

        // GET: Contacto
        public async Task<IActionResult> Index()
        {
            return View(await _context.Contactos.ToListAsync());
        }

        // GET: Contacto/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactos = await _context.Contactos
                .FirstOrDefaultAsync(m => m.idContacto == id);
            if (contactos == null)
            {
                return NotFound();
            }

            return View(contactos);
        }

        // GET: Contacto/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Contacto/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idContacto,Nombre,Apellido,Telefono,Direccion")] Contactos contactos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contactos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contactos);
        }

        // GET: Contacto/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactos = await _context.Contactos.FindAsync(id);
            if (contactos == null)
            {
                return NotFound();
            }
            return View(contactos);
        }

        // POST: Contacto/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idContacto,Nombre,Apellido,Telefono,Direccion")] Contactos contactos)
        {
            if (id != contactos.idContacto)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contactos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContactosExists(contactos.idContacto))
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
            return View(contactos);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactos = await _context.Contactos
                .FirstOrDefaultAsync(m => m.idContacto == id);
            if (contactos == null)
            {
                return NotFound();
            }

            return View(contactos);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contactos = await _context.Contactos.FindAsync(id);
            _context.Contactos.Remove(contactos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContactosExists(int id)
        {
            return _context.Contactos.Any(e => e.idContacto == id);
        }
    }
}
