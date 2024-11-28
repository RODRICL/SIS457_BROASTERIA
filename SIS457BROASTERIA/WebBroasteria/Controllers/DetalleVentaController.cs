using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebBroasteria.Models;

namespace WebBroasteria.Controllers
{
    public class DetalleVentaController : Controller
    {
        private readonly LabBroasteriaContext _context;

        public DetalleVentaController(LabBroasteriaContext context)
        {
            _context = context;
        }

        // GET: DetalleVenta
        public async Task<IActionResult> Index()
        {
            var labBroasteriaContext = _context.DetalleVenta.Include(d => d.IdProductoNavigation).Include(d => d.IdVentaNavigation);
            return View(await labBroasteriaContext.ToListAsync());
        }

        // GET: DetalleVenta/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalleVentum = await _context.DetalleVenta
                .Include(d => d.IdProductoNavigation)
                .Include(d => d.IdVentaNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (detalleVentum == null)
            {
                return NotFound();
            }

            return View(detalleVentum);
        }

        // GET: DetalleVenta/Create
        public IActionResult Create()
        {
            ViewData["IdProducto"] = new SelectList(_context.Productos, "Id", "Id");
            ViewData["IdVenta"] = new SelectList(_context.Venta, "Id", "Id");
            return View();
        }

        // POST: DetalleVenta/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdVenta,IdProducto,PrecioVenta,Cantidad,SubTotal,UsuarioRegistro,FechaRegistro,Estado")] DetalleVentum detalleVentum)
        {
            if (ModelState.IsValid)
            {
                _context.Add(detalleVentum);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdProducto"] = new SelectList(_context.Productos, "Id", "Id", detalleVentum.IdProducto);
            ViewData["IdVenta"] = new SelectList(_context.Venta, "Id", "Id", detalleVentum.IdVenta);
            return View(detalleVentum);
        }

        // GET: DetalleVenta/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalleVentum = await _context.DetalleVenta.FindAsync(id);
            if (detalleVentum == null)
            {
                return NotFound();
            }
            ViewData["IdProducto"] = new SelectList(_context.Productos, "Id", "Id", detalleVentum.IdProducto);
            ViewData["IdVenta"] = new SelectList(_context.Venta, "Id", "Id", detalleVentum.IdVenta);
            return View(detalleVentum);
        }

        // POST: DetalleVenta/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdVenta,IdProducto,PrecioVenta,Cantidad,SubTotal,UsuarioRegistro,FechaRegistro,Estado")] DetalleVentum detalleVentum)
        {
            if (id != detalleVentum.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(detalleVentum);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DetalleVentumExists(detalleVentum.Id))
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
            ViewData["IdProducto"] = new SelectList(_context.Productos, "Id", "Id", detalleVentum.IdProducto);
            ViewData["IdVenta"] = new SelectList(_context.Venta, "Id", "Id", detalleVentum.IdVenta);
            return View(detalleVentum);
        }

        // GET: DetalleVenta/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalleVentum = await _context.DetalleVenta
                .Include(d => d.IdProductoNavigation)
                .Include(d => d.IdVentaNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (detalleVentum == null)
            {
                return NotFound();
            }

            return View(detalleVentum);
        }

        // POST: DetalleVenta/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var detalleVentum = await _context.DetalleVenta.FindAsync(id);
            if (detalleVentum != null)
            {
                _context.DetalleVenta.Remove(detalleVentum);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DetalleVentumExists(int id)
        {
            return _context.DetalleVenta.Any(e => e.Id == id);
        }
    }
}
