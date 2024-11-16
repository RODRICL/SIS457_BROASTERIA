using CadBroasteria;
using ClnBroasteria;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpBroasteria
{
    public partial class FrmProducto : Form
        
    {
        private bool esNuevo = false;
        public FrmProducto()
        {
            InitializeComponent();
        }
        private void listar()
        {
            var lista = ProductoCln.listarPa(txtParametroProducto.Text);
            dgvListaProducto.DataSource = lista;
            dgvListaProducto.Columns["id"].Visible = false;
            dgvListaProducto.Columns["estado"].Visible = false;
            dgvListaProducto.Columns["idCategoria"].Visible = false;
            dgvListaProducto.Columns["codigo"].HeaderText = "CÓDIGO";
            dgvListaProducto.Columns["nombre"].HeaderText = "NOMBRE PRODUCTO";
            dgvListaProducto.Columns["descripcion"].HeaderText = "DESCRIPCIÓN";
            dgvListaProducto.Columns["categoriaDescripcion"].HeaderText = "CATEGORIA";
            dgvListaProducto.Columns["categoriaDescripcion"].DisplayIndex = 5;
            dgvListaProducto.Columns["stock"].HeaderText = "STOCK";
            dgvListaProducto.Columns["precioVenta"].HeaderText = "PRECIO DE VENTA";

            btnEditar.Enabled = lista.Count() > 0;
            btnEliminar.Enabled = lista.Count() > 0;

            if (lista.Count > 0) dgvListaProducto.CurrentCell = dgvListaProducto.Rows[0].Cells["codigo"];
        }

        private void CargarCategorias()
        {
            var categorias = CategoriaCln.listar();
            cbxCategoria.DataSource = categorias;
            cbxCategoria.DisplayMember = "descripcion";
            cbxCategoria.ValueMember = "id";
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            txtprecioVenta.KeyPress += Util.onlyNumbers;
            listar();
            CargarCategorias();
            DesactivarCampos();
        }
        private void DesactivarCampos()
        {
            txtCodigo.Enabled = false;
            txtNombre.Enabled = false;
            txtDescripcion.Enabled = false;
            txtprecioVenta.Enabled = false;
            nudStock.Enabled = false;
            cbxCategoria.Enabled = false;

        }
        private bool validar()
        {
            bool esValido = true;
            erpCodigo.SetError(txtCodigo, "");
            erpNombre.SetError(txtNombre, "");
            erpDescripcion.SetError(txtDescripcion, "");
            erpPrecioVenta.SetError(txtprecioVenta, "");
            erpStock.SetError(nudStock, "");


            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                esValido = false;
                erpCodigo.SetError(txtCodigo, "El campo codigo es obligatorio");
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                esValido = false;
                erpNombre.SetError(txtNombre, "El campo nombre Producto es obligatorio");
            }
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                esValido = false;
                erpDescripcion.SetError(txtDescripcion, "El campo Descripción es obligatorio");
            }
            if (string.IsNullOrEmpty(txtprecioVenta.Text))
            {
                esValido = false;
                erpPrecioVenta.SetError(txtprecioVenta, "El campo precio Venta es obligatorio");
            }

            return esValido;
        }
        private void HabilitarCampos()
        {
            txtCodigo.Enabled = true;
            txtNombre.Enabled = true;
            txtDescripcion.Enabled = true;
            txtprecioVenta.Enabled = true;
            nudStock.Enabled = true;
            cbxCategoria.Enabled = true;

        }
        private void limpiar()
        {
            txtCodigo.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtprecioVenta.Text = string.Empty;
            nudStock.Text = string.Empty; 

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                var producto = new Producto();
                producto.codigo = txtCodigo.Text.Trim();
                producto.nombre = txtNombre.Text.Trim();
                producto.descripcion = txtDescripcion.Text.Trim();
                producto.precioVenta = decimal.Parse(txtprecioVenta.Text);
                producto.stock = int.Parse(nudStock.Text);
                producto.idCategoria = (int)cbxCategoria.SelectedValue;
                producto.usuarioRegistro = Util.usuario.usuario1;

                if (esNuevo)
                {
                    if (ProductoCln.ExisteCodigo(producto.codigo))
                    {
                        MessageBox.Show("NO SE PUEDE AGREGAR, código ya existente.", ":::Broasteria - Mensaje :::",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    producto.fechaRegistro = DateTime.Now;
                    producto.estado = 1;
                    ProductoCln.insertar(producto);
                }
                else
                {
                    int index = dgvListaProducto.CurrentCell.RowIndex;
                    int id = Convert.ToInt32(dgvListaProducto.Rows[index].Cells["id"].Value);
                    var productoExistente = ProductoCln.obtenerUno(id);

                    if (producto.codigo != productoExistente.codigo && ProductoCln.ExisteCodigo(producto.codigo))
                    {
                        MessageBox.Show("No se puede actualizar, código ya existente.", ":::Broasteria - Mensaje :::",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    producto.id = id;
                    ProductoCln.actualizar(producto);
                }
                limpiar();
                MessageBox.Show("Producto guardado correctamente", ":::Broasteria - Mensaje :::",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                listar();
                DesactivarCampos();
            }
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            HabilitarCampos();
            txtCodigo.Focus();
        }

        private void txtParametroProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) listar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = dgvListaProducto.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvListaProducto.Rows[index].Cells["id"].Value);
            string nombre = dgvListaProducto.Rows[index].Cells["nombre"].Value.ToString();
            DialogResult dialog =
                MessageBox.Show($"¿Está seguro que desea dar de baja al producto: {nombre}?",
                "::: Broasteria - Mensaje :::", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                ProductoCln.eliminar(id, Util.usuario.usuario1);
                listar();
                MessageBox.Show("Producto dado de baja correctamente", "::: Broasteria - Mensaje :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            int index = dgvListaProducto.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvListaProducto.Rows[index].Cells["id"].Value);
            var producto = ProductoCln.obtenerUno(id);
            txtCodigo.Text = producto.codigo;
            txtNombre.Text = producto.nombre;
            txtDescripcion.Text = producto.descripcion;
            txtprecioVenta.Text = producto.precioVenta.ToString();
            nudStock.Text = producto.stock.ToString();

            HabilitarCampos();


            txtCodigo.Focus();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listar();
        }
    }
}
