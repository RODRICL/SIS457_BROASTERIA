﻿using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebBroasteria.Models;

namespace WebBroasteria.Controllers
{
    [Authorize]
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
                .Where(p => p.Estado != -1);

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
            ViewBag.IdCategoria = new SelectList(
                _context.Categoria.Where(c => c.Estado != -1), // categorías con estado diferente a -1
                "Id",          // Valor que se almacena en el modelo (Id de la categoría)
                "Descripcion"  // (Descripción de la categoría)
            );

            return View();
        }

        // POST: Productos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdCategoria,Codigo,Nombre,Descripcion,Stock,PrecioVenta")] Producto producto)
        {
            // Validación de campos requeridos
            if (!string.IsNullOrEmpty(producto.Codigo) &&
            !string.IsNullOrEmpty(producto.Nombre) &&
            !string.IsNullOrEmpty(producto.Descripcion) &&
            producto.Stock.HasValue && producto.Stock > 0 &&  // Validación para Stock no nulo y mayor a 0
            producto.PrecioVenta.HasValue && producto.PrecioVenta > 0)
            {
                // Asignar valores adicionales
                producto.UsuarioRegistro = User.Identity.Name;
                producto.FechaRegistro = DateTime.Now;
                producto.Estado = 1;

                // Guardar el producto en la base de datos
                _context.Add(producto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            // Si la validación falla, cargar las categorías nuevamente
            ViewBag.IdCategoria = new SelectList(
                _context.Categoria.Where(c => c.Estado != -1),
                "Id",
                "Descripcion"
            );

            // Devolver la vista con el modelo para corregir errores
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

            // Se muestra la descripción de la categoría, no solo el Id
            ViewData["IdCategoria"] = new SelectList(_context.Categoria.Where(c => c.Estado != -1), "Id", "Descripcion", producto.IdCategoria);
            return View(producto);
        }

        // POST: Productos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdCategoria,Codigo,Nombre,Descripcion,Stock,PrecioVenta,UsuarioRegistro,FechaRegistro,Estado")] Producto producto)
        {
            if (id != producto.Id)
            {
                return NotFound();
            }

            // Comprobar si el modelo es válido antes de proceder
            if (!string.IsNullOrEmpty(producto.Codigo) && !string.IsNullOrEmpty(producto.Nombre) && !string.IsNullOrEmpty(producto.Descripcion))
            {
                try
                {
                    _context.Update(producto);  // Actualiza el producto
                    await _context.SaveChangesAsync();  // Guarda los cambios en la base de datos
                    return RedirectToAction(nameof(Index));  // Redirige al Index con los datos actualizados
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductoExists(producto.Id))
                    {
                        return NotFound();  // Si no existe el producto, muestra un error
                    }
                    else
                    {
                        throw;  // Lanza la excepción si hay un problema con la actualización
                    }
                }
            }

            // Si hay un error de validación, se vuelve a cargar la vista de edición
            ViewData["IdCategoria"] = new SelectList(_context.Categoria.Where(c => c.Estado != -1), "Id", "Descripcion", producto.IdCategoria);
            return View(producto);  // Retorna a la vista Edit con los datos que no pasaron la validación
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