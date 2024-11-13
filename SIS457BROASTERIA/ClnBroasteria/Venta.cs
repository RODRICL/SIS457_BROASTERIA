using CadBroasteria;
using ClnBroasteria;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnBroasteria
{
    public class VentaCln
    {
        private readonly LabBroasteriaEntities _context;

        public VentaCln(LabBroasteriaEntities context)
        {
            _context = context;
        }

        public void Insertar(Venta venta, DetalleVenta[] detalles, Cliente cliente)
        {
            var clienteExistente = _context.Cliente.FirstOrDefault(c => c.documento == cliente.documento);
            if (clienteExistente == null)
            {
                clienteExistente = _context.Cliente.Add(cliente);
            }
            else
            {
                clienteExistente.nombreCompleto = cliente.nombreCompleto;
            }

            venta.documentoCliente = clienteExistente.documento;
            _context.Venta.Add(venta);

            foreach (var detalle in detalles)
            {
                detalle.idVenta = venta.id;
                _context.DetalleVenta.Add(detalle);

                // Validar y actualizar el stock del producto
                var producto = _context.Producto.Find(detalle.idProducto);
                if (producto.stock < detalle.cantidad)
                {
                    throw new Exception($"Stock insuficiente para el producto {producto.nombre}");
                }
                producto.stock -= detalle.cantidad;
                _context.Entry(producto).State = EntityState.Modified;
            }

            _context.SaveChanges();
        }
    }
}

