using CadBroasteria;
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
    public partial class FrmVenta : Form
    {
        public FrmVenta()
        {
            InitializeComponent();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            string documento = txtdocumento.Text;

            if (string.IsNullOrWhiteSpace(documento))
            {
                MessageBox.Show("Por favor, ingrese el documento del cliente.");
                return;
            }

            using (var context = new LabBroasteriaEntities())
            {
                var cliente = context.Cliente.FirstOrDefault(c => c.documento == documento);

                if (cliente != null)
                {
                    txtNombre.Text = cliente.nombreCompleto;
                }
                else
                {
                    MessageBox.Show("Cliente no encontrado. Puede agregar un nuevo cliente.");
                    limpiarDocumento();
                }
            }
        }
        public void SetListaCliente( string documento, string nombreCompleto)
        {
            txtdocumento.Text = documento;
            txtNombre.Text = nombreCompleto;
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            new FrmCliente().ShowDialog();
        }
        private void limpiarDocumento()
        {
            txtdocumento.Text = string.Empty;
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            FrmListarProducto productoFrm = new FrmListarProducto(this);
			productoFrm.ShowDialog();
        }
        public void SetListaProducto(string codigo, string nombre, string stock, string precioVenta)
        {
            txtCodigoProducto.Text = codigo;
            txtProducto.Text = nombre;
            txtStock.Text = stock;
            txtPrecioVenta.Text = precioVenta;
        }
    }
}
