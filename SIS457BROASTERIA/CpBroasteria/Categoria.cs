﻿using CadBroasteria;
using ClnBroasteria;
using CpBroasteria;
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
    public partial class FrmCategoria : Form
    {
        private bool esNuevo = false;
        public FrmCategoria()
        {
            InitializeComponent();
        }

        public void listar()
        {
            var lista = CategoriaCln.listarPa(txtParametroCategoria.Text);
            dgvListaCategoria.DataSource = lista;
            dgvListaCategoria.Columns["id"].Visible = false;
            dgvListaCategoria.Columns["estado"].Visible = false;
            //esto es para cambiar los nombres visibles en la tabla
            dgvListaCategoria.Columns["descripcion"].HeaderText = "Descripción";


            btnEditar.Enabled = lista.Count() > 0;
            btnEliminar.Enabled = lista.Count() > 0;

            if (lista.Count > 0) dgvListaCategoria.CurrentCell = dgvListaCategoria.Rows[0].Cells["descripcion"];

        }

        private void limpiar()
        {
            txtDescripcionCategoria.Text = string.Empty;
        }
        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            DesactivarCampos();
            listar();
        }
        private void DesactivarCampos()
        {
            txtDescripcionCategoria.Enabled = false;
        }
        private void HabilitarCampos()
        {
            txtDescripcionCategoria.Enabled = true;

        }
        private bool validar()
        {
            bool esValido = true;
            erpDescripcionCategoria.SetError(txtDescripcionCategoria, "");

            // evalua si la cadena esta vacia en el espacio de documento, visebersa para todos los campos 
            if (string.IsNullOrEmpty(txtDescripcionCategoria.Text))
            {
                esValido = false;
                erpDescripcionCategoria.SetError(txtDescripcionCategoria, "El campo descripción es obligatorio");
            }
            return esValido;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            esNuevo = true;
            txtDescripcionCategoria.Focus(); 
            limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                var categoria = new Categoria();
                categoria.descripcion = txtDescripcionCategoria.Text.Trim();
                categoria.usuarioRegistro = Util.usuario.usuario1;
                if (esNuevo)
                {

                    if (CategoriaCln.ExisteDescripcion(categoria.descripcion))
                    {
                        MessageBox.Show("NO SE PUEDE AGREGAR, descripción ya existente.", ":::Broasteria - Mensaje :::",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    categoria.fechaRegistro = DateTime.Now;
                    categoria.estado = 1;
                    CategoriaCln.insertar(categoria);
                }
                else
                {
                    int index = dgvListaCategoria.CurrentCell.RowIndex;
                    categoria.id = Convert.ToInt32(dgvListaCategoria.Rows[index].Cells["id"].Value);
                    var categoriaExistente = CategoriaCln.obtenerUno(categoria.id);
                    if (categoria.descripcion != categoriaExistente.descripcion && CategoriaCln.ExisteDescripcion(categoria.descripcion))
                    {
                        MessageBox.Show("NO SE PUEDE ACTUALIZAR, descripción ya existente.", ":::Broasteria - Mensaje :::",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; 
                    }

                    CategoriaCln.actualizar(categoria);
                }
                listar();
                MessageBox.Show("Categoria guardado correctamente", ":::Broasteria - Mensaje :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            limpiar();
            DesactivarCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            int index = dgvListaCategoria.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvListaCategoria.Rows[index].Cells["id"].Value);
            var categoria = CategoriaCln.obtenerUno(id);
            txtDescripcionCategoria.Text = categoria.descripcion;
            txtDescripcionCategoria.Focus();
            HabilitarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = dgvListaCategoria.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvListaCategoria.Rows[index].Cells["id"].Value);
            string descripcion = dgvListaCategoria.Rows[index].Cells["descripcion"].Value.ToString();
            DialogResult dialog =
                MessageBox.Show($"¿Está seguro que desea dar de baja la Categoria con descripción {descripcion}?",
                "::: Broasteria - Mensaje :::", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                CategoriaCln.eliminar(id, Util.usuario.usuario1);
                listar();
                MessageBox.Show("Categoria dado de baja correctamente", "::: Broasteria - Mensaje :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void txtParametroCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) listar();
        }
    }
}
