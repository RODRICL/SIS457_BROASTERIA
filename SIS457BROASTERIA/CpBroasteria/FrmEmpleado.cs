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
	public partial class FrmEmpleado : Form
	{
		public FrmEmpleado()
		{
			InitializeComponent();
		}

		private void btnCerrar_Click(object sender, EventArgs e)
		{
			Close();
		}

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {

        }
    }
}
