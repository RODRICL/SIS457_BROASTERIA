using CadBroasteria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnBroasteria
{
    public class ProductoCln
    {
        public static int insertar(Producto producto)
        {
            using (var context = new LabBroasteriaEntities())
            {
                context.Producto.Add(producto);
                context.SaveChanges();
                return producto.id;
            }
        }

        public static int actualizar(Producto producto)
        {
            using (var context = new LabBroasteriaEntities())
            {
                var existente = context.Producto.Find(producto.id);
                existente.codigo = producto.codigo;
                existente.nombre = producto.nombre;
                existente.descripcion = producto.descripcion;  
                existente.stock = producto.stock;
                existente.precioVenta = producto.precioVenta;
                return context.SaveChanges();
            }
        }
        public static int eliminar(int id, string usuario)
        {
            using (var context = new LabBroasteriaEntities())
            {
                var producto = context.Producto.Find(id);
                producto.estado = -1;
                producto.usuarioRegistro = usuario;
                return context.SaveChanges();
            }
        }
        public static Producto obtenerUno(int id)
        {
            using (var context = new LabBroasteriaEntities())
            {
                return context.Producto.Find(id);
            }
        }

        public static List<Producto> listar()
        {
            using (var context = new LabBroasteriaEntities())
            {
                return context.Producto.Where(x => x.estado != - 1).ToList(); 
            }
        }

        public static List<paProductoListar_Result> listarPa(string parametro)
        {
            using (var context = new LabBroasteriaEntities())
            {
                return context.paProductoListar(parametro).ToList();
            }
        }
        public static bool ExisteCodigo(string codigo)
        {
            using (var context = new LabBroasteriaEntities())
            {
                return context.Producto.Any(p => p.codigo == codigo && p.estado != -1);
            }
        }
    }
}
