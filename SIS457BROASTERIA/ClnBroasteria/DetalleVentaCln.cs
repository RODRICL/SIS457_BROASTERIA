using CadBroasteria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnBroasteria
{
    public class DetalleVentaCln
    {
        public static void RegistrarDetalleVenta(DetalleVenta detalle)
        {
            using (var context = new LabBroasteriaEntities())
            {
                try
                {
                    context.DetalleVenta.Add(detalle);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al registrar detalle de venta: " + ex.Message);
                }
            }
        }

    }
}
