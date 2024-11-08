﻿using CadBroasteria;
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
    public partial class FrmCliente : Form
    {
        private bool esNuevo = false;
        public FrmCliente()
        {
            InitializeComponent();
        }
        public void listar()
        {
            var lista = ClienteCln.listarPa(txtParametroCliente.Text);
            dgvListaCliente.DataSource = lista;
            dgvListaCliente.Columns["id"].Visible = false;
            dgvListaCliente.Columns["estado"].Visible = false;
            //esto es para cambiar los nombres visibles en la tabla
            dgvListaCliente.Columns["nombreCompleto"].HeaderText = "Nombre Completo";
            dgvListaCliente.Columns["documento"].HeaderText = "N° Documento";
            dgvListaCliente.Columns["email"].HeaderText = "Correo";
            dgvListaCliente.Columns["telefono"].HeaderText = "Teléfono";


            btnEditar.Enabled = lista.Count() > 0;
            btnEliminar.Enabled = lista.Count() > 0;

            if (lista.Count > 0) dgvListaCliente.CurrentCell = dgvListaCliente.Rows[0].Cells["documento"];
        }
        private void FrmCliente_Load(object sender, EventArgs e)
        {
            txtNombreCompleto.KeyPress += Util.onlyLetters;
            txtTelefonoCliente.KeyPress += Util.onlyNumbers;
            DesactivarCampos();
            listar();
        }
        private void DesactivarCampos()
        {
            txtDocumentoCliente.Enabled = false;
            txtNombreCompleto.Enabled = false;
            txtCorreoCliente.Enabled = false;
            txtTelefonoCliente.Enabled = false;
        }
        private void HabilitarCampos()
        {
            txtDocumentoCliente.Enabled = true;
            txtNombreCompleto.Enabled = true;
            txtCorreoCliente.Enabled = true;
            txtTelefonoCliente.Enabled = true;
        }
        private void limpiar()
        {
            txtDocumentoCliente.Text = string.Empty;
            txtNombreCompleto.Text = string.Empty;
            txtCorreoCliente.Text = string.Empty;
            txtTelefonoCliente.Text = string.Empty;
        }

        private void txtParametroCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) listar();
        }
        private bool validar()
        {
            bool esValido = true;
            erpDocumentoCliente.SetError(txtDocumentoCliente, "");
            erpNombreCompleto.SetError(txtNombreCompleto, "");
            erpCorreoCliente.SetError(txtCorreoCliente, "");
            erpTelefonoCliente.SetError(txtTelefonoCliente, "");

            if (string.IsNullOrEmpty(txtDocumentoCliente.Text))
            {
                esValido = false;
                erpDocumentoCliente.SetError(txtDocumentoCliente, "El campo documento es obligatorio");
            }
            if (string.IsNullOrEmpty(txtNombreCompleto.Text))
            {
                esValido = false;
                erpNombreCompleto.SetError(txtNombreCompleto, "El campo razon social es obligatorio");
            }
            if (string.IsNullOrEmpty(txtCorreoCliente.Text))
            {
                esValido = false;
                erpCorreoCliente.SetError(txtCorreoCliente, "El campo correo es obligatorio");
            }
            if (string.IsNullOrEmpty(txtTelefonoCliente.Text))
            {
                esValido = false;
                erpTelefonoCliente.SetError(txtTelefonoCliente, "El campo telefono es obligatorio");
            }
            return esValido;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            txtDocumentoCliente.Focus(); 
            HabilitarCampos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                var cliente = new Cliente();
                cliente.documento = txtDocumentoCliente.Text.Trim();
                cliente.nombreCompleto = txtNombreCompleto.Text.Trim();
                cliente.email = txtCorreoCliente.Text.Trim();
                cliente.telefono = txtTelefonoCliente.Text.Trim();
                cliente.usuarioRegistro = Util.usuario.usuario1;
                if (esNuevo)
                {
                    if (ClienteCln.ExisteDocumento(cliente.documento))
                    {
                        MessageBox.Show("NO SE PUEDE AGREGAR, documento ya existente.", ":::Broasteria - Mensaje :::",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    cliente.fechaRegistro = DateTime.Now;
                    cliente.estado = 1;
                    ClienteCln.insertar(cliente);
                }
                else
                {
                    int index = dgvListaCliente.CurrentCell.RowIndex;
                    int id = Convert.ToInt32(dgvListaCliente.Rows[index].Cells["id"].Value);
                    var clienteExistente = ClienteCln.obtenerUno(id);

                    if (cliente.documento != clienteExistente.documento && ClienteCln.ExisteDocumento(cliente.documento))
                    {
                        MessageBox.Show("NO SE PUEDE ACTUALIZAR, documento ya existente.", ":::Broasteria - Mensaje :::",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; 
                    }

                    cliente.id = id;
                    ClienteCln.actualizar(cliente);
                }
                listar();
                MessageBox.Show("Cliente guardado correctamente", ":::Broasteria - Mensaje :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            limpiar();
            DesactivarCampos();
        
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            int index = dgvListaCliente.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvListaCliente.Rows[index].Cells["id"].Value);
            var cliente = ClienteCln.obtenerUno(id);
            txtDocumentoCliente.Text = cliente.documento;
            txtNombreCompleto.Text = cliente.nombreCompleto;
            txtCorreoCliente.Text = cliente.email;
            txtTelefonoCliente.Text = cliente.telefono;
            txtDocumentoCliente.Focus();
            HabilitarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = dgvListaCliente.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvListaCliente.Rows[index].Cells["id"].Value);
            string documento = dgvListaCliente.Rows[index].Cells["documento"].Value.ToString();
            DialogResult dialog =
                MessageBox.Show($"¿Está seguro que desea dar de baja al Cliente con N° de documento {documento}?",
                "::: Broasteria - Mensaje :::", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                ClienteCln.eliminar(id, Util.usuario.usuario1);
                listar();
                MessageBox.Show("Cliente dado de baja correctamente", "::: Broasteria - Mensaje :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
