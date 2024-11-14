using CadBroasteria;
using ClnBroasteria;
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
                MessageBox.Show("Por favor, ingrese el cedula de identidad del cliente ", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("El cliente no existe, puede crear un cliente si desea ", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            var frmCliente = new FrmCliente(this);
            frmCliente.ShowDialog();

        }
        private void limpiarDocumento()
        {
            txtdocumento.Text = string.Empty;
        }
        private void FrmVenta_Load(object sender, EventArgs e)
        {
            txtdocumento.KeyPress += Util.onlyNumbers;
            dgvVentas.Columns.Add("Codigo", "Código");
            dgvVentas.Columns.Add("Nombre", "Nombre");
            dgvVentas.Columns.Add("Descripcion", "Descripcion");
            dgvVentas.Columns.Add("PrecioVenta", "Precio de Venta");
            dgvVentas.Columns.Add("Cantidad", "Cantidad");
            dgvVentas.Columns.Add("Total", "Total");
            txtPagaCon.TextChanged += txtPagaCon_TextChanged;
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            FrmListarProducto productoFrm = new FrmListarProducto(this);
			productoFrm.ShowDialog();
        }
        public void SetListaProducto(string codigo, string nombre, string descripcion, string stock, string precioVenta)
        {
            txtCodigoProducto.Text = codigo;
            txtProducto.Text = nombre;
            txtDescripcion.Text = descripcion;
            txtStock.Text = stock;
            txtPrecioVenta.Text = precioVenta;
            if (int.TryParse(stock, out int stockDisponible))
            {
                nudCantidadVenta.Maximum = stockDisponible;
            }
            else
            {
                nudCantidadVenta.Maximum = 1;
            }
        }
        private bool validar()
        {
            bool esValido = true;
            erpDocumentoCliente.SetError(txtdocumento, "");
            erpCodigoProducto.SetError(txtCodigoProducto, "");
            erpCantidadVender.SetError(nudCantidadVenta, "");
            erpPagaCon.SetError(txtPagaCon, "");
            if (string.IsNullOrEmpty(txtdocumento.Text))
            {
                esValido = false;
                erpDocumentoCliente.SetError(txtdocumento, "Este campo no debe estar vacio");
            }
            if (string.IsNullOrEmpty(txtCodigoProducto.Text))
            {
                esValido = false;
                erpCodigoProducto.SetError(txtCodigoProducto, "Este campo no debe estar vacio");
            }

            if (nudCantidadVenta.Value <= 0)
            {
                esValido = false;
                erpCantidadVender.SetError(nudCantidadVenta, "El campo Cantidad no debe ser negativo");
            }

            return esValido;
        }
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (!validar())
            {
                MessageBox.Show("Por favor, corrige los errores antes de agregar el producto.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            var codigo = txtCodigoProducto.Text;
            var nombre = txtProducto.Text;
            var descripcion = txtProducto.Text;
            var precioVenta = decimal.Parse(txtPrecioVenta.Text);
            var cantidad = int.Parse(nudCantidadVenta.Text);
            var total = precioVenta * cantidad;

            dgvVentas.Rows.Add(codigo, nombre,descripcion, precioVenta, cantidad, total);

            LimpiarCampos();
            CalcularTotalPagar();
        }
        private void LimpiarCampos()
        {
            txtCodigoProducto.Text = string.Empty;
            txtProducto.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtStock.Text = string.Empty;
            txtPrecioVenta.Text = string.Empty;
            nudCantidadVenta.Text = string.Empty;
        }
        private void CalcularTotalPagar()
        {
            decimal totalPagar = 0;

            foreach (DataGridViewRow row in dgvVentas.Rows)
            {
                if (row.Cells["Total"].Value != null)
                {
                    totalPagar += Convert.ToDecimal(row.Cells["Total"].Value);
                }
            }

            txtMontoAPagar.Text = totalPagar.ToString("0.00"); 
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvVentas.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvVentas.SelectedRows)
                {
                    dgvVentas.Rows.RemoveAt(row.Index);
                }
                CalcularTotalPagar();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un producto para quitar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtPagaCon_TextChanged(object sender, EventArgs e)
        {
            decimal montoAPagar;
            decimal pagaCon;

            if (decimal.TryParse(txtMontoAPagar.Text, out montoAPagar) && decimal.TryParse(txtPagaCon.Text, out pagaCon))
            {
                if (pagaCon >= montoAPagar)
                {
                    decimal cambio = pagaCon - montoAPagar;
                    txtCambio.Text = cambio.ToString("0.00");
                }
                else
                {
                    txtCambio.Text = "0.00"; 
                }
            }
            else
            {
                txtCambio.Text = "0.00"; 
            }
        }
    }
}
