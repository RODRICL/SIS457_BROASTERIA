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
    public partial class FrmListarProducto : Form
    {
        private FrmVenta frmVenta;
        public FrmListarProducto(FrmVenta venta)
        {
            InitializeComponent();
            frmVenta = venta;
        }
        public void listar()
        {
            var lista = ProductoCln.listarPro(txtParametroProducto.Text);
            dgvLista.DataSource = lista;
            dgvLista.Columns["id"].Visible = false;
            dgvLista.Columns["codigo"].HeaderText = "Código";
            dgvLista.Columns["nombre"].HeaderText = "Nombre";
            dgvLista.Columns["descripcion"].HeaderText = "Descripción";
            dgvLista.Columns["stock"].HeaderText = "Stock";
            dgvLista.Columns["precioVenta"].HeaderText = "Precio Venta";
            if (lista.Count > 0) dgvLista.CurrentCell = dgvLista.Rows[0].Cells["codigo"];
        }

        private void FrmListarProducto_Load(object sender, EventArgs e)
        {
            listar();
        }

        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = dgvLista.Rows[e.RowIndex].Cells["id"].Value.ToString();
                string codigo = dgvLista.Rows[e.RowIndex].Cells["codigo"].Value.ToString();
                string nombre = dgvLista.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                string descripcion = dgvLista.Rows[e.RowIndex].Cells["descripcion"].Value.ToString();
                string stock = dgvLista.Rows[e.RowIndex].Cells["stock"].Value.ToString();
                string precioVenta = dgvLista.Rows[e.RowIndex].Cells["precioVenta"].Value.ToString();

                frmVenta.SetListaProducto(id, codigo, nombre, descripcion, stock, precioVenta);
                this.Close();

            }
        }
    }
}
