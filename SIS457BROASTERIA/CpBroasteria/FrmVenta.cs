using CadBroasteria;
using ClnBroasteria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpBroasteria
{
    public partial class FrmVenta : Form
    {
        private string idProductoSeleccionado;
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
        public void SetListaCliente(string documento, string nombreCompleto)
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
            var colIdProducto = new DataGridViewTextBoxColumn
            {
                Name = "idProducto",
                Visible = false //para que oculte la columna idPro
            };
            dgvVentas.Columns.Add(colIdProducto);

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
        public void SetListaProducto(string idProducto,string codigo, string nombre, string descripcion, string stock, string precioVenta)
        {
            idProductoSeleccionado = idProducto;
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

        private bool validar(bool RegistroVenta = false)
        {
            bool esValido = true;
            erpDocumentoCliente.SetError(txtdocumento, "");
            erpCodigoProducto.SetError(txtCodigoProducto, "");
            erpCantidadVender.SetError(nudCantidadVenta, "");
            erpPagaCon.SetError(txtPagaCon, "");

            // Validación del documento del cliente
            if (string.IsNullOrEmpty(txtdocumento.Text))
            {
                esValido = false;
                erpDocumentoCliente.SetError(txtdocumento, "Este campo no debe estar vacío");
            }

            // Validación de productos
            if (!RegistroVenta) // Solo valida cuando no es el registro de la venta
            {
                if (string.IsNullOrEmpty(txtCodigoProducto.Text))
                {
                    esValido = false;
                    erpCodigoProducto.SetError(txtCodigoProducto, "Este campo no debe estar vacío");
                }

                if (nudCantidadVenta.Value <= 0)
                {
                    esValido = false;
                    erpCantidadVender.SetError(nudCantidadVenta, "El campo Cantidad no debe ser negativo o cero");
                }
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

            dgvVentas.Rows.Add(idProductoSeleccionado, codigo, nombre, descripcion, precioVenta, cantidad, total);

            LimpiarCampos();
            CalcularTotalPagar();
        }

        private void LimpiarCampos()
        {
            idProductoSeleccionado = null;
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

        private void ActualizarStockVenta()
        {
            foreach (DataGridViewRow row in dgvVentas.Rows)
            {
                if (row.Cells["IdProducto"].Value != null)
                {
                    var idProducto = Convert.ToInt32(row.Cells["IdProducto"].Value);
                    var cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);

                    try
                    {
                        // Llama al método ActualizarStock para reducir el stock
                        bool actualizado = ProductoCln.ActualizarDisminuirStock(idProducto, cantidad);

                        if (!actualizado)
                        {
                            MessageBox.Show($"No se pudo actualizar el stock para el producto ID {idProducto}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al actualizar el producto ID {idProducto}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void RegistrarDetallesVenta(int idVentaRegistrada)
        {
            foreach (DataGridViewRow row in dgvVentas.Rows)
            {
                if (row.Cells["idProducto"].Value != null)
                {
                    // Similar a ValidarDetallesCompra, adapta para ventas
                    var detalleVenta = new DetalleVenta
                    {
                        idVenta = idVentaRegistrada,
                        idProducto = Convert.ToInt32(row.Cells["idProducto"].Value),
                        precioVenta = Convert.ToDecimal(row.Cells["precioVenta"].Value),
                        cantidad = Convert.ToInt32(row.Cells["cantidad"].Value),
                        subTotal = Convert.ToDecimal(row.Cells["total"].Value),
                    };
                    try
                    {
                        DetalleVentaCln.RegistrarDetalleVenta(detalleVenta);
                    }
                    catch (Exception ex)
                    {
                        ManejarErrorRegistro(ex, "Error al registrar detalle de venta");
                    }
                }
            }
        }
        private void ManejarErrorRegistro(Exception ex, string mensaje)
             {
        MessageBox.Show($"{mensaje}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            if (dgvVentas.Rows.Count == 0)
            {
                MessageBox.Show("No hay productos para registrar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            decimal montoTotal;
            if (!decimal.TryParse(txtMontoAPagar.Text, out montoTotal))
            {
                MessageBox.Show("El monto total a pagar no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            decimal montoPago;
            if (string.IsNullOrEmpty(txtPagaCon.Text) || !decimal.TryParse(txtPagaCon.Text, out montoPago))
            {
                MessageBox.Show("El monto de pago no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (montoPago < montoTotal)
            {
                MessageBox.Show("El monto de pago debe ser mayor o igual al total a pagar.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            decimal montoCambio = montoPago - montoTotal;

            var venta = CrearVenta( montoTotal, montoPago, montoCambio);

            if (venta == null)
            {
                return;
            }
            try
            {
                int idVentaRegistrada = VentaCln.RegistrarVenta(venta);
                RegistrarDetallesVenta(idVentaRegistrada);
                ActualizarStockVenta();

                MessageBox.Show("Venta registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var eve in ex.EntityValidationErrors)
                {
                    Console.WriteLine($"Entidad \"{eve.Entry.Entity.GetType().Name}\" en estado \"{eve.Entry.State}\" tiene los siguientes errores de validación:");
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine($"- Propiedad: \"{ve.PropertyName}\", Error: \"{ve.ErrorMessage}\"");
                    }
                }
                MessageBox.Show("Error al registrar la venta: verifique los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                ManejarErrorRegistro(ex, "Error al registrar la venta");
            }
            dgvVentas.Rows.Clear();
            txtMontoAPagar.Text = "0.00";
            txtPagaCon.Text = string.Empty;
            txtCambio.Text = "0.00"; 
            LimpiarTodo();

        }

        private Venta CrearVenta(decimal montoTotal, decimal montoPago, decimal montoCambio)
        {
            string tipoDocumento = "Factura";
            string numeroDocumento = GenerarNumeroDocumento(); 

            string documentoCliente = txtdocumento.Text;
            string nombreCliente = txtNombre.Text;
            string usuarioRegistro = Util.usuario.usuario1 ?? "Usuario Desconocido";

            return new Venta
            {
                tipoDocumento = tipoDocumento,
                numeroDocumento = numeroDocumento,
                documentoCliente = documentoCliente,
                nombreCliente = nombreCliente,
                montoTotal = montoTotal,
                montoPago = montoPago,
                montoCambio = montoCambio,
                fechaRegistro = DateTime.Now,
                usuarioRegistro = usuarioRegistro,
                estado = 1
            };
        }

        private string GenerarNumeroDocumento()
        {
            return "FACT" + DateTime.Now.Ticks.ToString();
        }
        private void LimpiarTodo()
        {
            txtCodigoProducto.Text = string.Empty;
            txtProducto.Text = string.Empty;
            txtPrecioVenta.Text = string.Empty;
            nudCantidadVenta.Text = string.Empty;
            txtdocumento.Text = string.Empty;
            txtNombre.Text = string.Empty;
        }
    }
}
