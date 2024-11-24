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
    public class ProductosController : Controller
    {
        private readonly LabBroasteriaContext _context;

        public ProductosController(LabBroasteriaContext context)
        {
            _context = context;
        }

        // GET: Productos
        public async Task<IActionResult> Index()
        {
            var labBroasteriaContext = _context.Productos
                .Include(p => p.IdCategoriaNavigation)
                .Where(p => p.Estado != -1); // Filtrar productos con estado diferente de -1

            return View(await labBroasteriaContext.ToListAsync());
        }

        // GET: Productos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Productos
                .Include(p => p.IdCategoriaNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        // GET: Productos/Create
        public IActionResult Create()
        {
            // Filtrar categorías con estado diferente a -1
            ViewBag.IdCategoria = new SelectList(
                _context.Categoria.Where(c => c.Estado != -1), // Filtramos las categorías con estado diferente a -1
                "Id",          // Valor que se almacena en el modelo (Id de la categoría)
                "Descripcion"  // Texto visible para el usuario (Descripción de la categoría)
            );

            return View();
        }

        // POST: Productos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdCategoria,Codigo,Nombre,Descripcion,Stock,PrecioVenta")] Producto producto)
        {
            if (!string.IsNullOrEmpty(producto.Codigo) && !string.IsNullOrEmpty(producto.Nombre) && !string.IsNullOrEmpty(producto.Descripcion))
            {
                producto.UsuarioRegistro = "SIS457";
                producto.FechaRegistro = DateTime.Now;
                producto.Estado = 1;

                _context.Add(producto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            // Usamos ViewBag en vez de ViewData
            ViewBag.IdCategoria = new SelectList(
                _context.Categoria.Where(c => c.Estado != -1), // Excluimos las categorías con estado -1
                "Id",          // Valor de la opción (Id de la categoría que se almacenará en el modelo)
                "Descripcion"  // Texto que se mostrará en la opción (Descripcion de la categoría)
            );

            return View(producto);
        }

        // GET: Productos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Productos.FindAsync(id);
            if (producto == null)
            {
                return NotFound();
            }
            ViewData["IdCategoria"] = new SelectList(_context.Categoria, "Id", "Id", producto.IdCategoria);
            return View(producto);
        }

        // POST: Productos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdCategoria,Codigo,Nombre,Descripcion,Stock,PrecioVenta,UsuarioRegistro,FechaRegistro,Estado")] Producto producto)
        {
            if (id != producto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(producto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductoExists(producto.Id))
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
            ViewData["IdCategoria"] = new SelectList(_context.Categoria, "Id", "Id", producto.IdCategoria);
            return View(producto);
        }

        // GET: Productos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Productos
                .Include(p => p.IdCategoriaNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        // POST: Productos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producto = await _context.Productos.FindAsync(id);
            if (producto != null)
            {
                _context.Productos.Remove(producto);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductoExists(int id)
        {
            return _context.Productos.Any(e => e.Id == id);
        }
    }
}
