namespace CpBroasteria
{
    partial class FrmProveedores
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProveedores));
			this.txtprecioVenta = new System.Windows.Forms.TextBox();
			this.lblPrecioVenta = new System.Windows.Forms.Label();
			this.lblStock = new System.Windows.Forms.Label();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtParametroProducto = new System.Windows.Forms.TextBox();
			this.dgvListaProducto = new System.Windows.Forms.DataGridView();
			this.label4 = new System.Windows.Forms.Label();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.gbxLista = new System.Windows.Forms.GroupBox();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvListaProducto)).BeginInit();
			this.gbxLista.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtprecioVenta
			// 
			this.txtprecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtprecioVenta.Location = new System.Drawing.Point(14, 405);
			this.txtprecioVenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtprecioVenta.MaxLength = 6;
			this.txtprecioVenta.Name = "txtprecioVenta";
			this.txtprecioVenta.Size = new System.Drawing.Size(342, 31);
			this.txtprecioVenta.TabIndex = 117;
			// 
			// lblPrecioVenta
			// 
			this.lblPrecioVenta.AutoSize = true;
			this.lblPrecioVenta.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPrecioVenta.Location = new System.Drawing.Point(14, 368);
			this.lblPrecioVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblPrecioVenta.Name = "lblPrecioVenta";
			this.lblPrecioVenta.Size = new System.Drawing.Size(242, 32);
			this.lblPrecioVenta.TabIndex = 115;
			this.lblPrecioVenta.Text = "Producto / Servicio:";
			// 
			// lblStock
			// 
			this.lblStock.AutoSize = true;
			this.lblStock.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStock.Location = new System.Drawing.Point(8, 457);
			this.lblStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblStock.Name = "lblStock";
			this.lblStock.Size = new System.Drawing.Size(122, 32);
			this.lblStock.TabIndex = 114;
			this.lblStock.Text = "Télefono:";
			// 
			// btnBuscar
			// 
			this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscar.Image = global::CpBroasteria.Properties.Resources.search;
			this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBuscar.Location = new System.Drawing.Point(1240, 103);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(159, 66);
			this.btnBuscar.TabIndex = 109;
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
			this.label1.Location = new System.Drawing.Point(2, -5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(363, 97);
			this.label1.TabIndex = 112;
			this.label1.Text = "Sistema de Ventas";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtParametroProducto
			// 
			this.txtParametroProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.txtParametroProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtParametroProducto.Location = new System.Drawing.Point(780, 111);
			this.txtParametroProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtParametroProducto.Multiline = true;
			this.txtParametroProducto.Name = "txtParametroProducto";
			this.txtParametroProducto.Size = new System.Drawing.Size(434, 47);
			this.txtParametroProducto.TabIndex = 107;
			// 
			// dgvListaProducto
			// 
			this.dgvListaProducto.AllowUserToAddRows = false;
			this.dgvListaProducto.AllowUserToDeleteRows = false;
			this.dgvListaProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvListaProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvListaProducto.BackgroundColor = System.Drawing.Color.Snow;
			this.dgvListaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvListaProducto.Location = new System.Drawing.Point(39, 49);
			this.dgvListaProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvListaProducto.MultiSelect = false;
			this.dgvListaProducto.Name = "dgvListaProducto";
			this.dgvListaProducto.ReadOnly = true;
			this.dgvListaProducto.RowHeadersWidth = 51;
			this.dgvListaProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvListaProducto.Size = new System.Drawing.Size(942, 620);
			this.dgvListaProducto.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.BackColor = System.Drawing.Color.White;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(398, 98);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(375, 72);
			this.label4.TabIndex = 105;
			this.label4.Text = "Buscar por  Numero Documento:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnGuardar
			// 
			this.btnGuardar.BackColor = System.Drawing.Color.Peru;
			this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuardar.Image = global::CpBroasteria.Properties.Resources.save;
			this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardar.Location = new System.Drawing.Point(194, 574);
			this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(160, 82);
			this.btnGuardar.TabIndex = 97;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGuardar.UseVisualStyleBackColor = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(14, 295);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(166, 32);
			this.label6.TabIndex = 110;
			this.label6.Text = "Razón Social:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(14, 226);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(115, 32);
			this.label5.TabIndex = 108;
			this.label5.Text = "Nombre:";
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDescripcion.Location = new System.Drawing.Point(12, 332);
			this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(342, 31);
			this.txtDescripcion.TabIndex = 106;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(14, 154);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(256, 32);
			this.label3.TabIndex = 104;
			this.label3.Text = "Numero Documento:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 105);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(265, 42);
			this.label2.TabIndex = 103;
			this.label2.Text = "Detalle Proveedor";
			// 
			// btnCerrar
			// 
			this.btnCerrar.BackColor = System.Drawing.Color.White;
			this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCerrar.Image = global::CpBroasteria.Properties.Resources.close3;
			this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCerrar.Location = new System.Drawing.Point(98, 778);
			this.btnCerrar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(142, 75);
			this.btnCerrar.TabIndex = 100;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCerrar.UseVisualStyleBackColor = false;
			// 
			// btnEliminar
			// 
			this.btnEliminar.BackColor = System.Drawing.Color.Red;
			this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.Image = global::CpBroasteria.Properties.Resources.delete;
			this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEliminar.Location = new System.Drawing.Point(10, 691);
			this.btnEliminar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(148, 75);
			this.btnEliminar.TabIndex = 99;
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
			this.btnEditar.Location = new System.Drawing.Point(194, 689);
			this.btnEditar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(159, 77);
			this.btnEditar.TabIndex = 98;
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
			this.btnNuevo.Location = new System.Drawing.Point(10, 574);
			this.btnNuevo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(148, 80);
			this.btnNuevo.TabIndex = 96;
			this.btnNuevo.Text = "Nuevo";
			this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnNuevo.UseVisualStyleBackColor = false;
			// 
			// gbxLista
			// 
			this.gbxLista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gbxLista.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.gbxLista.Controls.Add(this.dgvListaProducto);
			this.gbxLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbxLista.Location = new System.Drawing.Point(394, 177);
			this.gbxLista.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbxLista.Name = "gbxLista";
			this.gbxLista.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbxLista.Size = new System.Drawing.Size(1032, 698);
			this.gbxLista.TabIndex = 102;
			this.gbxLista.TabStop = false;
			this.gbxLista.Text = "Lista de Proveedor";
			// 
			// txtCodigo
			// 
			this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCodigo.Location = new System.Drawing.Point(20, 191);
			this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(334, 31);
			this.txtCodigo.TabIndex = 101;
			// 
			// txtNombre
			// 
			this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.Location = new System.Drawing.Point(12, 260);
			this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(342, 31);
			this.txtNombre.TabIndex = 95;
			// 
			// lblTitulo
			// 
			this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTitulo.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(-9, -5);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(1448, 97);
			this.lblTitulo.TabIndex = 94;
			this.lblTitulo.Text = "PROVEEDOR";
			this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(9, 494);
			this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBox1.MaxLength = 6;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(342, 31);
			this.textBox1.TabIndex = 118;
			// 
			// FrmProveedores
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1428, 871);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.txtprecioVenta);
			this.Controls.Add(this.lblPrecioVenta);
			this.Controls.Add(this.lblStock);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtParametroProducto);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtDescripcion);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnNuevo);
			this.Controls.Add(this.gbxLista);
			this.Controls.Add(this.txtCodigo);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.lblTitulo);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "FrmProveedores";
			this.Text = " BROASTERIA ~ PROVEEDOR 🍗🍗";
			((System.ComponentModel.ISupportInitialize)(this.dgvListaProducto)).EndInit();
			this.gbxLista.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtprecioVenta;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtParametroProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox gbxLista;
        private System.Windows.Forms.DataGridView dgvListaProducto;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox textBox1;
    }
}