using System;
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
    public class VentaController : Controller
    {
        private readonly LabBroasteriaContext _context;

        public VentaController(LabBroasteriaContext context)
        {
            _context = context;
        }

        // GET: Venta
        public async Task<IActionResult> Index()
        {
            var labBroasteriaContext = _context.Venta
                .Where(v => v.Estado != -1);  // Filtra las ventas activas
            return View(await labBroasteriaContext.ToListAsync());
        }

        // GET: Venta/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ventum = await _context.Venta
                .Include(v => v.DetalleVenta) // Incluye detalles de la venta
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ventum == null)
            {
                return NotFound();
            }

            return View(ventum);
        }

        // GET: Venta/Create
        public IActionResult Create()
        {
            // Obtener la lista de productos
            ViewBag.Productos = _context.Productos
                .Where(p => p.Estado != -1)  // Filtra productos activos
                .ToList();  // Convierte a lista

            return View();
        }


        // POST: Venta/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TipoDocumento,NumeroDocumento,DocumentoCliente,NombreCliente,MontoPago,MontoCambio,MontoTotal")] Ventum ventum, int[] productos, int[] cantidades)
        {
            if (ModelState.IsValid)
            {
                ventum.UsuarioRegistro = User.Identity.Name;
                ventum.FechaRegistro = DateTime.Now;
                ventum.Estado = 1;

                // Agregar la venta a la base de datos
                _context.Add(ventum);
                await _context.SaveChangesAsync();

                // Crear los detalles de la venta
                for (int i = 0; i < productos.Length; i++)
                {
                    var producto = _context.Productos.Find(productos[i]);
                    if (producto == null)
                    {
                        ModelState.AddModelError("", "Producto no encontrado.");
                        return View(ventum);
                    }

                    var detalle = new DetalleVentum
                    {
                        IdVenta = ventum.Id,
                        IdProducto = productos[i],
                        Cantidad = cantidades[i],
                        PrecioVenta = producto.PrecioVenta,
                        SubTotal = cantidades[i] * (decimal)producto.PrecioVenta,  // Conversión explícita a decimal
                        UsuarioRegistro = User.Identity.Name,
                        FechaRegistro = DateTime.Now,
                        Estado = 1
                    };
                    _context.Add(detalle);
                }

                // Guardar los detalles
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            // Si algo falla, recargar los productos
            ViewBag.Productos = _context.Productos.Where(p => p.Estado != -1).ToList();
            return View(ventum);
        }

        // GET: Venta/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ventum = await _context.Venta.FindAsync(id);
            if (ventum == null)
            {
                return NotFound();
            }
            return View(ventum);
        }

        // POST: Venta/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TipoDocumento,NumeroDocumento,DocumentoCliente,NombreCliente,MontoPago,MontoCambio,MontoTotal,UsuarioRegistro,FechaRegistro,Estado")] Ventum ventum)
        {
            if (id != ventum.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // Validar montos
                    if (ventum.MontoPago <= 0 || ventum.MontoCambio < 0 || ventum.MontoTotal <= 0)
                    {
                        ModelState.AddModelError("", "Los montos deben ser mayores que cero.");
                        return View(ventum);
                    }

                    _context.Update(ventum);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VentumExists(ventum.Id))
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
            return View(ventum);
        }

        // GET: Venta/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ventum = await _context.Venta
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ventum == null)
            {
                return NotFound();
            }

            return View(ventum);
        }

        // POST: Venta/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ventum = await _context.Venta.FindAsync(id);
            if (ventum != null)
            {
                ventum.Estado = -1;  // Cambiar estado a "eliminado"
                _context.Update(ventum);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }

        private bool VentumExists(int id)
        {
            return _context.Venta.Any(e => e.Id == id && e.Estado != -1);
        }
    }
}
