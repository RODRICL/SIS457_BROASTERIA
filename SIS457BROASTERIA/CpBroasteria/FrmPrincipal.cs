using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpBroasteria
{
    public partial class FrmPrincipal : Form
    {
        private FrmAutenticacion frmAutenticacion;
        public FrmPrincipal(FrmAutenticacion frmAutenticacion)
        {
            InitializeComponent();
            this.frmAutenticacion = frmAutenticacion;
        }

        private void btnCaProductos_Click(object sender, EventArgs e)
        {
            new FrmProducto().ShowDialog();
        }

        private void btnCaCategoria_Click(object sender, EventArgs e)
        {
            new FrmCategoria().ShowDialog();
        }

        private void btnCaProveedor_Click(object sender, EventArgs e)
        {

        }

        private void btnCaVenta_Click(object sender, EventArgs e)
        {
            new FrmVenta().ShowDialog();
        }


        private void btnCaCliente_Click(object sender, EventArgs e)
        {
            var frmVenta = new FrmVenta();
            new FrmCliente(frmVenta).ShowDialog();
        }

        private void btnCaProveedor_Click_1(object sender, EventArgs e)
        {
            new FrmProveedores().ShowDialog();
        }

		private void btnCaEmpleados_Click(object sender, EventArgs e)
		{
            new FrmEmpleado().ShowDialog();
		}
	}
}
