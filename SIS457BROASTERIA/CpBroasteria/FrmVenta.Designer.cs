namespace CpBroasteria
{
    partial class FrmVenta
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVenta));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxInformacionVenta = new System.Windows.Forms.GroupBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.gbxInformacionCliente = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtdocumento = new System.Windows.Forms.TextBox();
            this.lblCedulaIdentidad = new System.Windows.Forms.Label();
            this.gbxInformacionProducto = new System.Windows.Forms.GroupBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.nudCantidadVenta = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.lblCodigoProducto = new System.Windows.Forms.Label();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.lblPagoCon = new System.Windows.Forms.Label();
            this.lblCambio = new System.Windows.Forms.Label();
            this.txtMontoAPagar = new System.Windows.Forms.TextBox();
            this.txtPagaCon = new System.Windows.Forms.TextBox();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.btnRegistrarVenta = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.erpDocumentoCliente = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpCodigoProducto = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpCantidadVender = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpPagaCon = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbxLista = new System.Windows.Forms.GroupBox();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.gbxInformacionVenta.SuspendLayout();
            this.gbxInformacionCliente.SuspendLayout();
            this.gbxInformacionProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDocumentoCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCodigoProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCantidadVender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpPagaCon)).BeginInit();
            this.gbxLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(-3, -2);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1272, 78);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "VENTA";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 78);
            this.label1.TabIndex = 34;
            this.label1.Text = "Sistema de Ventas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 32);
            this.label2.TabIndex = 35;
            this.label2.Text = "Registrar Venta";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(4, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1249, 652);
            this.label3.TabIndex = 36;
            // 
            // gbxInformacionVenta
            // 
            this.gbxInformacionVenta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbxInformacionVenta.BackColor = System.Drawing.Color.White;
            this.gbxInformacionVenta.Controls.Add(this.txtFecha);
            this.gbxInformacionVenta.Controls.Add(this.lblFecha);
            this.gbxInformacionVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxInformacionVenta.Location = new System.Drawing.Point(21, 127);
            this.gbxInformacionVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxInformacionVenta.Name = "gbxInformacionVenta";
            this.gbxInformacionVenta.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxInformacionVenta.Size = new System.Drawing.Size(416, 105);
            this.gbxInformacionVenta.TabIndex = 37;
            this.gbxInformacionVenta.TabStop = false;
            this.gbxInformacionVenta.Text = "Información Venta";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(16, 57);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(5);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(128, 34);
            this.txtFecha.TabIndex = 3;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(5, 30);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(75, 24);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha:";
            // 
            // gbxInformacionCliente
            // 
            this.gbxInformacionCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbxInformacionCliente.BackColor = System.Drawing.Color.White;
            this.gbxInformacionCliente.Controls.Add(this.txtNombre);
            this.gbxInformacionCliente.Controls.Add(this.btnAgregarCliente);
            this.gbxInformacionCliente.Controls.Add(this.lblNombre);
            this.gbxInformacionCliente.Controls.Add(this.btnBuscarCliente);
            this.gbxInformacionCliente.Controls.Add(this.txtdocumento);
            this.gbxInformacionCliente.Controls.Add(this.lblCedulaIdentidad);
            this.gbxInformacionCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxInformacionCliente.Location = new System.Drawing.Point(460, 127);
            this.gbxInformacionCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxInformacionCliente.Name = "gbxInformacionCliente";
            this.gbxInformacionCliente.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxInformacionCliente.Size = new System.Drawing.Size(772, 105);
            this.gbxInformacionCliente.TabIndex = 38;
            this.gbxInformacionCliente.TabStop = false;
            this.gbxInformacionCliente.Text = "Información Cliente";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(427, 60);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(328, 30);
            this.txtNombre.TabIndex = 50;
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgregarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCliente.Location = new System.Drawing.Point(304, 41);
            this.btnAgregarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAgregarCliente.Size = new System.Drawing.Size(97, 62);
            this.btnAgregarCliente.TabIndex = 49;
            this.btnAgregarCliente.Text = "Crear Cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = false;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(423, 30);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(91, 24);
            this.lblNombre.TabIndex = 19;
            this.lblNombre.Text = "Nombre:";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarCliente.Image = global::CpBroasteria.Properties.Resources.search;
            this.btnBuscarCliente.Location = new System.Drawing.Point(225, 38);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBuscarCliente.Size = new System.Drawing.Size(73, 62);
            this.btnBuscarCliente.TabIndex = 18;
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtdocumento
            // 
            this.txtdocumento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdocumento.Location = new System.Drawing.Point(11, 60);
            this.txtdocumento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdocumento.Name = "txtdocumento";
            this.txtdocumento.Size = new System.Drawing.Size(196, 30);
            this.txtdocumento.TabIndex = 2;
            // 
            // lblCedulaIdentidad
            // 
            this.lblCedulaIdentidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCedulaIdentidad.AutoSize = true;
            this.lblCedulaIdentidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedulaIdentidad.Location = new System.Drawing.Point(7, 36);
            this.lblCedulaIdentidad.Name = "lblCedulaIdentidad";
            this.lblCedulaIdentidad.Size = new System.Drawing.Size(204, 24);
            this.lblCedulaIdentidad.TabIndex = 1;
            this.lblCedulaIdentidad.Text = "Cédula de Identidad:";
            // 
            // gbxInformacionProducto
            // 
            this.gbxInformacionProducto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbxInformacionProducto.BackColor = System.Drawing.Color.White;
            this.gbxInformacionProducto.Controls.Add(this.txtDescripcion);
            this.gbxInformacionProducto.Controls.Add(this.label4);
            this.gbxInformacionProducto.Controls.Add(this.txtStock);
            this.gbxInformacionProducto.Controls.Add(this.txtPrecioVenta);
            this.gbxInformacionProducto.Controls.Add(this.txtProducto);
            this.gbxInformacionProducto.Controls.Add(this.txtCodigoProducto);
            this.gbxInformacionProducto.Controls.Add(this.lblStock);
            this.gbxInformacionProducto.Controls.Add(this.lblPrecio);
            this.gbxInformacionProducto.Controls.Add(this.nudCantidadVenta);
            this.gbxInformacionProducto.Controls.Add(this.lblCantidad);
            this.gbxInformacionProducto.Controls.Add(this.lblProducto);
            this.gbxInformacionProducto.Controls.Add(this.btnBuscarProducto);
            this.gbxInformacionProducto.Controls.Add(this.lblCodigoProducto);
            this.gbxInformacionProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxInformacionProducto.Location = new System.Drawing.Point(31, 250);
            this.gbxInformacionProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxInformacionProducto.Name = "gbxInformacionProducto";
            this.gbxInformacionProducto.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxInformacionProducto.Size = new System.Drawing.Size(997, 129);
            this.gbxInformacionProducto.TabIndex = 39;
            this.gbxInformacionProducto.TabStop = false;
            this.gbxInformacionProducto.Text = "Información Producto";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(405, 84);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(257, 30);
            this.txtDescripcion.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(401, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 24);
            this.label4.TabIndex = 35;
            this.label4.Text = "Descripción:";
            // 
            // txtStock
            // 
            this.txtStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(787, 84);
            this.txtStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(92, 30);
            this.txtStock.TabIndex = 34;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVenta.Location = new System.Drawing.Point(681, 84);
            this.txtPrecioVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(99, 30);
            this.txtPrecioVenta.TabIndex = 33;
            // 
            // txtProducto
            // 
            this.txtProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(184, 85);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(201, 30);
            this.txtProducto.TabIndex = 32;
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProducto.Location = new System.Drawing.Point(17, 89);
            this.txtCodigoProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(84, 30);
            this.txtCodigoProducto.TabIndex = 31;
            // 
            // lblStock
            // 
            this.lblStock.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(783, 53);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(67, 24);
            this.lblStock.TabIndex = 27;
            this.lblStock.Text = "Stock:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(683, 53);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(76, 24);
            this.lblPrecio.TabIndex = 25;
            this.lblPrecio.Text = "Precio:";
            // 
            // nudCantidadVenta
            // 
            this.nudCantidadVenta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudCantidadVenta.Location = new System.Drawing.Point(885, 81);
            this.nudCantidadVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudCantidadVenta.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCantidadVenta.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidadVenta.Name = "nudCantidadVenta";
            this.nudCantidadVenta.Size = new System.Drawing.Size(93, 34);
            this.nudCantidadVenta.TabIndex = 24;
            this.nudCantidadVenta.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCantidad
            // 
            this.lblCantidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(881, 54);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(98, 24);
            this.lblCantidad.TabIndex = 23;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblProducto
            // 
            this.lblProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(180, 54);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(100, 24);
            this.lblProducto.TabIndex = 19;
            this.lblProducto.Text = "Producto:";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBuscarProducto.Image = global::CpBroasteria.Properties.Resources.search;
            this.btnBuscarProducto.Location = new System.Drawing.Point(108, 74);
            this.btnBuscarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBuscarProducto.Size = new System.Drawing.Size(64, 52);
            this.btnBuscarProducto.TabIndex = 18;
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // lblCodigoProducto
            // 
            this.lblCodigoProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCodigoProducto.AutoSize = true;
            this.lblCodigoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoProducto.Location = new System.Drawing.Point(13, 54);
            this.lblCodigoProducto.Name = "lblCodigoProducto";
            this.lblCodigoProducto.Size = new System.Drawing.Size(83, 24);
            this.lblCodigoProducto.TabIndex = 1;
            this.lblCodigoProducto.Text = "Código:";
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.BackColor = System.Drawing.Color.White;
            this.lblTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagar.Location = new System.Drawing.Point(1064, 464);
            this.lblTotalPagar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(139, 24);
            this.lblTotalPagar.TabIndex = 43;
            this.lblTotalPagar.Text = "Total a Pagar:";
            // 
            // lblPagoCon
            // 
            this.lblPagoCon.AutoSize = true;
            this.lblPagoCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagoCon.Location = new System.Drawing.Point(1076, 533);
            this.lblPagoCon.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPagoCon.Name = "lblPagoCon";
            this.lblPagoCon.Size = new System.Drawing.Size(104, 24);
            this.lblPagoCon.TabIndex = 44;
            this.lblPagoCon.Text = "Paga con:";
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambio.Location = new System.Drawing.Point(1093, 602);
            this.lblCambio.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(87, 24);
            this.lblCambio.TabIndex = 45;
            this.lblCambio.Text = "Cambio:";
            // 
            // txtMontoAPagar
            // 
            this.txtMontoAPagar.Location = new System.Drawing.Point(1057, 491);
            this.txtMontoAPagar.Margin = new System.Windows.Forms.Padding(5);
            this.txtMontoAPagar.Name = "txtMontoAPagar";
            this.txtMontoAPagar.Size = new System.Drawing.Size(157, 22);
            this.txtMontoAPagar.TabIndex = 46;
            // 
            // txtPagaCon
            // 
            this.txtPagaCon.Location = new System.Drawing.Point(1057, 560);
            this.txtPagaCon.Margin = new System.Windows.Forms.Padding(5);
            this.txtPagaCon.Name = "txtPagaCon";
            this.txtPagaCon.Size = new System.Drawing.Size(157, 22);
            this.txtPagaCon.TabIndex = 47;
            this.txtPagaCon.TextChanged += new System.EventHandler(this.txtPagaCon_TextChanged);
            // 
            // txtCambio
            // 
            this.txtCambio.Location = new System.Drawing.Point(1057, 629);
            this.txtCambio.Margin = new System.Windows.Forms.Padding(5);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.Size = new System.Drawing.Size(157, 22);
            this.txtCambio.TabIndex = 48;
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRegistrarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarVenta.Image = global::CpBroasteria.Properties.Resources.venta;
            this.btnRegistrarVenta.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRegistrarVenta.Location = new System.Drawing.Point(1080, 672);
            this.btnRegistrarVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(136, 82);
            this.btnRegistrarVenta.TabIndex = 41;
            this.btnRegistrarVenta.Text = "Registrar";
            this.btnRegistrarVenta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegistrarVenta.UseVisualStyleBackColor = true;
            this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.Image = global::CpBroasteria.Properties.Resources.quitar_2;
            this.btnQuitar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQuitar.Location = new System.Drawing.Point(1071, 372);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(145, 76);
            this.btnQuitar.TabIndex = 40;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.Image = global::CpBroasteria.Properties.Resources.carrito_agregar;
            this.btnAgregarProducto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarProducto.Location = new System.Drawing.Point(1071, 234);
            this.btnAgregarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(156, 132);
            this.btnAgregarProducto.TabIndex = 33;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // erpDocumentoCliente
            // 
            this.erpDocumentoCliente.ContainerControl = this;
            // 
            // erpCodigoProducto
            // 
            this.erpCodigoProducto.ContainerControl = this;
            // 
            // erpCantidadVender
            // 
            this.erpCantidadVender.ContainerControl = this;
            // 
            // erpPagaCon
            // 
            this.erpPagaCon.ContainerControl = this;
            // 
            // gbxLista
            // 
            this.gbxLista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxLista.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.gbxLista.Controls.Add(this.dgvVentas);
            this.gbxLista.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxLista.Location = new System.Drawing.Point(30, 385);
            this.gbxLista.Margin = new System.Windows.Forms.Padding(4);
            this.gbxLista.Name = "gbxLista";
            this.gbxLista.Padding = new System.Windows.Forms.Padding(4);
            this.gbxLista.Size = new System.Drawing.Size(998, 369);
            this.gbxLista.TabIndex = 88;
            this.gbxLista.TabStop = false;
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvVentas.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(8, 16);
            this.dgvVentas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVentas.MultiSelect = false;
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.RowHeadersWidth = 51;
            this.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentas.Size = new System.Drawing.Size(982, 345);
            this.dgvVentas.TabIndex = 0;
            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 770);
            this.Controls.Add(this.gbxLista);
            this.Controls.Add(this.txtCambio);
            this.Controls.Add(this.txtPagaCon);
            this.Controls.Add(this.txtMontoAPagar);
            this.Controls.Add(this.lblCambio);
            this.Controls.Add(this.lblPagoCon);
            this.Controls.Add(this.lblTotalPagar);
            this.Controls.Add(this.btnRegistrarVenta);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.gbxInformacionProducto);
            this.Controls.Add(this.gbxInformacionCliente);
            this.Controls.Add(this.gbxInformacionVenta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BROASTERIA ~ VENTA 🍗🍗";
            this.Load += new System.EventHandler(this.FrmVenta_Load);
            this.gbxInformacionVenta.ResumeLayout(false);
            this.gbxInformacionVenta.PerformLayout();
            this.gbxInformacionCliente.ResumeLayout(false);
            this.gbxInformacionCliente.PerformLayout();
            this.gbxInformacionProducto.ResumeLayout(false);
            this.gbxInformacionProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDocumentoCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCodigoProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCantidadVender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpPagaCon)).EndInit();
            this.gbxLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbxInformacionVenta;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.GroupBox gbxInformacionCliente;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtdocumento;
        private System.Windows.Forms.Label lblCedulaIdentidad;
        private System.Windows.Forms.GroupBox gbxInformacionProducto;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.NumericUpDown nudCantidadVenta;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Label lblCodigoProducto;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnRegistrarVenta;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.Label lblPagoCon;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.TextBox txtMontoAPagar;
        private System.Windows.Forms.TextBox txtPagaCon;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.ErrorProvider erpDocumentoCliente;
        private System.Windows.Forms.ErrorProvider erpCodigoProducto;
        private System.Windows.Forms.ErrorProvider erpCantidadVender;
        private System.Windows.Forms.ErrorProvider erpPagaCon;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.GroupBox gbxLista;
        private System.Windows.Forms.DataGridView dgvVentas;
    }
}