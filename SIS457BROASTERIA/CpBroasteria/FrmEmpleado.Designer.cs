﻿namespace CpBroasteria
{
	partial class FrmEmpleado
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpleado));
			this.dgvListaEmpleado = new System.Windows.Forms.DataGridView();
			this.txtTelefonoCliente = new System.Windows.Forms.TextBox();
			this.txtCorreoCliente = new System.Windows.Forms.TextBox();
			this.txtNombreCompleto = new System.Windows.Forms.TextBox();
			this.txtDocumentoCliente = new System.Windows.Forms.TextBox();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtParametroCliente = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lbl = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.gbxLista = new System.Windows.Forms.GroupBox();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.cbxCategoria = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvListaEmpleado)).BeginInit();
			this.gbxLista.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvListaEmpleado
			// 
			this.dgvListaEmpleado.AllowUserToAddRows = false;
			this.dgvListaEmpleado.AllowUserToDeleteRows = false;
			this.dgvListaEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvListaEmpleado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvListaEmpleado.BackgroundColor = System.Drawing.Color.Snow;
			this.dgvListaEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvListaEmpleado.Location = new System.Drawing.Point(39, 49);
			this.dgvListaEmpleado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvListaEmpleado.MultiSelect = false;
			this.dgvListaEmpleado.Name = "dgvListaEmpleado";
			this.dgvListaEmpleado.ReadOnly = true;
			this.dgvListaEmpleado.RowHeadersWidth = 51;
			this.dgvListaEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvListaEmpleado.Size = new System.Drawing.Size(954, 748);
			this.dgvListaEmpleado.TabIndex = 0;
			// 
			// txtTelefonoCliente
			// 
			this.txtTelefonoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTelefonoCliente.Location = new System.Drawing.Point(16, 415);
			this.txtTelefonoCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtTelefonoCliente.MaxLength = 8;
			this.txtTelefonoCliente.Name = "txtTelefonoCliente";
			this.txtTelefonoCliente.Size = new System.Drawing.Size(331, 35);
			this.txtTelefonoCliente.TabIndex = 125;
			// 
			// txtCorreoCliente
			// 
			this.txtCorreoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCorreoCliente.Location = new System.Drawing.Point(16, 335);
			this.txtCorreoCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtCorreoCliente.MaxLength = 50;
			this.txtCorreoCliente.Name = "txtCorreoCliente";
			this.txtCorreoCliente.Size = new System.Drawing.Size(332, 35);
			this.txtCorreoCliente.TabIndex = 124;
			// 
			// txtNombreCompleto
			// 
			this.txtNombreCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombreCompleto.Location = new System.Drawing.Point(18, 266);
			this.txtNombreCompleto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtNombreCompleto.MaxLength = 50;
			this.txtNombreCompleto.Name = "txtNombreCompleto";
			this.txtNombreCompleto.Size = new System.Drawing.Size(332, 35);
			this.txtNombreCompleto.TabIndex = 123;
			// 
			// txtDocumentoCliente
			// 
			this.txtDocumentoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDocumentoCliente.Location = new System.Drawing.Point(18, 194);
			this.txtDocumentoCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtDocumentoCliente.MaxLength = 10;
			this.txtDocumentoCliente.Name = "txtDocumentoCliente";
			this.txtDocumentoCliente.Size = new System.Drawing.Size(332, 35);
			this.txtDocumentoCliente.TabIndex = 122;
			// 
			// btnBuscar
			// 
			this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscar.Image = global::CpBroasteria.Properties.Resources.search;
			this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBuscar.Location = new System.Drawing.Point(1246, 108);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(159, 66);
			this.btnBuscar.TabIndex = 119;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnBuscar.UseVisualStyleBackColor = false;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(-10, -2);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(363, 97);
			this.label1.TabIndex = 121;
			this.label1.Text = "Sistema de Ventas";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtParametroCliente
			// 
			this.txtParametroCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.txtParametroCliente.Location = new System.Drawing.Point(734, 114);
			this.txtParametroCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtParametroCliente.Multiline = true;
			this.txtParametroCliente.Name = "txtParametroCliente";
			this.txtParametroCliente.Size = new System.Drawing.Size(480, 47);
			this.txtParametroCliente.TabIndex = 117;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.BackColor = System.Drawing.Color.White;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(387, 98);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(312, 72);
			this.label4.TabIndex = 115;
			this.label4.Text = "Buscar por Nombre de     Producto:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(10, 378);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(225, 32);
			this.label7.TabIndex = 120;
			this.label7.Text = "Segundo Apellido:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(12, 298);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(201, 32);
			this.label6.TabIndex = 118;
			this.label6.Text = "Primer Apellido:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 229);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(115, 32);
			this.label5.TabIndex = 116;
			this.label5.Text = "Nombre:";
			// 
			// lbl
			// 
			this.lbl.AutoSize = true;
			this.lbl.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl.Location = new System.Drawing.Point(12, 157);
			this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl.Name = "lbl";
			this.lbl.Size = new System.Drawing.Size(190, 32);
			this.lbl.TabIndex = 114;
			this.lbl.Text = "N° Documento:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(10, 108);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(319, 42);
			this.label2.TabIndex = 113;
			this.label2.Text = "Detalle de Empleados";
			// 
			// gbxLista
			// 
			this.gbxLista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gbxLista.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.gbxLista.Controls.Add(this.dgvListaEmpleado);
			this.gbxLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbxLista.Location = new System.Drawing.Point(393, 180);
			this.gbxLista.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbxLista.Name = "gbxLista";
			this.gbxLista.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbxLista.Size = new System.Drawing.Size(1044, 846);
			this.gbxLista.TabIndex = 112;
			this.gbxLista.TabStop = false;
			this.gbxLista.Text = "Lista de Empleados";
			// 
			// lblTitulo
			// 
			this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTitulo.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(-10, -2);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(1448, 97);
			this.lblTitulo.TabIndex = 111;
			this.lblTitulo.Text = "Empleados";
			this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnGuardar
			// 
			this.btnGuardar.BackColor = System.Drawing.Color.Peru;
			this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuardar.Image = global::CpBroasteria.Properties.Resources.save;
			this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardar.Location = new System.Drawing.Point(208, 725);
			this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(160, 82);
			this.btnGuardar.TabIndex = 126;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGuardar.UseVisualStyleBackColor = false;
			// 
			// btnCerrar
			// 
			this.btnCerrar.BackColor = System.Drawing.Color.White;
			this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCerrar.Image = global::CpBroasteria.Properties.Resources.close3;
			this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCerrar.Location = new System.Drawing.Point(105, 934);
			this.btnCerrar.Margin = new System.Windows.Forms.Padding(6);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(162, 75);
			this.btnCerrar.TabIndex = 130;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCerrar.UseVisualStyleBackColor = false;
			this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.BackColor = System.Drawing.Color.Red;
			this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.Image = global::CpBroasteria.Properties.Resources.delete;
			this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEliminar.Location = new System.Drawing.Point(21, 831);
			this.btnEliminar.Margin = new System.Windows.Forms.Padding(6);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(148, 75);
			this.btnEliminar.TabIndex = 129;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEliminar.UseVisualStyleBackColor = false;
			// 
			// btnEditar
			// 
			this.btnEditar.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditar.Image = global::CpBroasteria.Properties.Resources.edit;
			this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEditar.Location = new System.Drawing.Point(208, 831);
			this.btnEditar.Margin = new System.Windows.Forms.Padding(6);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(159, 77);
			this.btnEditar.TabIndex = 128;
			this.btnEditar.Text = "Editar";
			this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEditar.UseVisualStyleBackColor = false;
			// 
			// btnNuevo
			// 
			this.btnNuevo.BackColor = System.Drawing.Color.Yellow;
			this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNuevo.Image = global::CpBroasteria.Properties.Resources._new;
			this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNuevo.Location = new System.Drawing.Point(21, 725);
			this.btnNuevo.Margin = new System.Windows.Forms.Padding(6);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(148, 80);
			this.btnNuevo.TabIndex = 127;
			this.btnNuevo.Text = "Nuevo";
			this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnNuevo.UseVisualStyleBackColor = false;
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(18, 578);
			this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBox1.MaxLength = 50;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(332, 35);
			this.textBox1.TabIndex = 134;
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(16, 497);
			this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBox2.MaxLength = 10;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(332, 35);
			this.textBox2.TabIndex = 133;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 542);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(101, 32);
			this.label3.TabIndex = 132;
			this.label3.Text = "Celular:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(10, 460);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(130, 32);
			this.label8.TabIndex = 131;
			this.label8.Text = "Direccion:";
			// 
			// cbxCategoria
			// 
			this.cbxCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxCategoria.FormattingEnabled = true;
			this.cbxCategoria.Location = new System.Drawing.Point(21, 662);
			this.cbxCategoria.Margin = new System.Windows.Forms.Padding(6);
			this.cbxCategoria.Name = "cbxCategoria";
			this.cbxCategoria.Size = new System.Drawing.Size(146, 33);
			this.cbxCategoria.TabIndex = 136;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(18, 623);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(89, 32);
			this.label9.TabIndex = 135;
			this.label9.Text = "Cargo:";
			// 
			// textBox3
			// 
			this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox3.Location = new System.Drawing.Point(195, 660);
			this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBox3.MaxLength = 50;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(172, 35);
			this.textBox3.TabIndex = 138;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(189, 623);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(109, 32);
			this.label10.TabIndex = 137;
			this.label10.Text = "Usuario:";
			// 
			// FrmEmpleado
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1428, 1017);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.cbxCategoria);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnNuevo);
			this.Controls.Add(this.txtTelefonoCliente);
			this.Controls.Add(this.txtCorreoCliente);
			this.Controls.Add(this.txtNombreCompleto);
			this.Controls.Add(this.txtDocumentoCliente);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtParametroCliente);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lbl);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.gbxLista);
			this.Controls.Add(this.lblTitulo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.Name = "FrmEmpleado";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "BROASTERIA ~ EMPLEADOS 🍗🍗";
			this.Load += new System.EventHandler(this.FrmEmpleado_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvListaEmpleado)).EndInit();
			this.gbxLista.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvListaEmpleado;
		private System.Windows.Forms.TextBox txtTelefonoCliente;
		private System.Windows.Forms.TextBox txtCorreoCliente;
		private System.Windows.Forms.TextBox txtNombreCompleto;
		private System.Windows.Forms.TextBox txtDocumentoCliente;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtParametroCliente;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lbl;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox gbxLista;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Button btnCerrar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox cbxCategoria;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label10;
	}
}