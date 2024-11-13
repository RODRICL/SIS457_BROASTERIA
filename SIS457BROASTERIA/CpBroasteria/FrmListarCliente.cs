
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
using System.Xml.Linq;

namespace CpBroasteria
{
    public partial class FrmListarCliente : Form
    {
        private FrmVenta frmVenta;
        public FrmListarCliente(FrmVenta venta)
        {
            InitializeComponent();
            frmVenta = venta;
        }
        public void listar()
        {
            var lista = ClienteCln.listarCli(txtParametrolistar.Text);
            dgvLista.DataSource = lista;
            dgvLista.Columns["id"].Visible =false;
            dgvLista.Columns["nombreCompleto"].HeaderText = "Nombre Completo";
            dgvLista.Columns["documento"].HeaderText = "N° Documento";
            if (lista.Count > 0) dgvLista.CurrentCell = dgvLista.Rows[0].Cells["documento"];
        }

        private void FrmListarCliente_Load(object sender, EventArgs e)
        {
            listar();
        }

        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                string documento = dgvLista.Rows[e.RowIndex].Cells["documento"].Value.ToString();
                string nombreCompleto = dgvLista.Rows[e.RowIndex].Cells["nombreCompleto"].Value.ToString();

                frmVenta.SetListaCliente(documento, nombreCompleto);
                this.Close();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listar();

        }
    }
}
