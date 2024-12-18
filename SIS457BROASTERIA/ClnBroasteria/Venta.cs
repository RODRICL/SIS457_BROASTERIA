﻿using CadBroasteria;
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
        public static int RegistrarVenta(Venta venta)
        {
            using (var context = new LabBroasteriaEntities())
            {
                context.Venta.Add(venta);
                context.SaveChanges();
                return venta.id;
            }
        }
        public void Insertar(Venta venta, DetalleVenta[] detalles, Cliente cliente)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    // Verificar o agregar cliente
                    var clienteExistente = _context.Cliente.FirstOrDefault(c => c.documento == cliente.documento);
                    if (clienteExistente == null)
                    {
                        clienteExistente = _context.Cliente.Add(cliente);
                    }
                    else
                    {
                        clienteExistente.nombreCompleto = cliente.nombreCompleto;
                    }

                    // Asignar el cliente a la venta
                    venta.documentoCliente = clienteExistente.documento;
                    _context.Venta.Add(venta);

                    foreach (var detalle in detalles)
                    {
                        detalle.idVenta = venta.id;
                        _context.DetalleVenta.Add(detalle);

                        var producto = _context.Producto.Find(detalle.idProducto);
                        if (producto == null)
                        {
                            throw new Exception($"El producto con ID {detalle.idProducto} no existe.");
                        }

                        // Verificar stock
                        if (producto.stock < detalle.cantidad)
                        {
                            throw new Exception($"Stock insuficiente para el producto {producto.nombre}. Solo quedan {producto.stock} unidades.");
                        }

                        // Actualizar stock del producto
                        producto.stock -= detalle.cantidad;
                        _context.Entry(producto).State = EntityState.Modified;
                    }

                    // Guardar cambios y confirmar transacción
                    _context.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    // Si ocurre un error, revertir la transacción
                    transaction.Rollback();
                    throw new Exception($"Ocurrió un error al registrar la venta: {ex.Message}");
                }

            }
        }
    }
}