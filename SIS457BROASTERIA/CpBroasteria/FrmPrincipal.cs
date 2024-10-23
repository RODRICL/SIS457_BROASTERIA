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
        private static Form formularioActual = null;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCaProductos_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmProducto());
        }
        private void abrirFormulario(Form formulario)
        {
            if (formularioActual != null)
            {
                formularioActual.Close();
            }
            formularioActual = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(formulario);
            formulario.Show();
        }
    }
}
