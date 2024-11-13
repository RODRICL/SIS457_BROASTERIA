namespace CpBroasteria
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.c1Ribbon1 = new C1.Win.Ribbon.C1Ribbon();
            this.ribbonApplicationMenu1 = new C1.Win.Ribbon.RibbonApplicationMenu();
            this.ribbonBottomToolBar1 = new C1.Win.Ribbon.RibbonBottomToolBar();
            this.ribbonConfigToolBar1 = new C1.Win.Ribbon.RibbonConfigToolBar();
            this.ribbonQat1 = new C1.Win.Ribbon.RibbonQat();
            this.ribbonTab1 = new C1.Win.Ribbon.RibbonTab();
            this.ribbonGroup1 = new C1.Win.Ribbon.RibbonGroup();
            this.btnCaCategoria = new C1.Win.Ribbon.RibbonButton();
            this.btnCaProductos = new C1.Win.Ribbon.RibbonButton();
            this.ribbonGroup2 = new C1.Win.Ribbon.RibbonGroup();
            this.btnCaProveedor = new C1.Win.Ribbon.RibbonButton();
            this.ribbonGroup3 = new C1.Win.Ribbon.RibbonGroup();
            this.btnCaCliente = new C1.Win.Ribbon.RibbonButton();
            this.ribbonTab2 = new C1.Win.Ribbon.RibbonTab();
            this.ribbonGroup4 = new C1.Win.Ribbon.RibbonGroup();
            this.ribbonTab3 = new C1.Win.Ribbon.RibbonTab();
            this.ribbonGroup5 = new C1.Win.Ribbon.RibbonGroup();
            this.btnCaVenta = new C1.Win.Ribbon.RibbonButton();
            this.ribbonTab4 = new C1.Win.Ribbon.RibbonTab();
            this.ribbonGroup6 = new C1.Win.Ribbon.RibbonGroup();
            this.btnCaCompra = new C1.Win.Ribbon.RibbonButton();
            this.ribbonTab5 = new C1.Win.Ribbon.RibbonTab();
            this.ribbonGroup7 = new C1.Win.Ribbon.RibbonGroup();
            this.ribbonTopToolBar1 = new C1.Win.Ribbon.RibbonTopToolBar();
            this.pctPrincipal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // c1Ribbon1
            // 
            this.c1Ribbon1.ApplicationMenuHolder = this.ribbonApplicationMenu1;
          
            this.c1Ribbon1.BottomToolBarHolder = this.ribbonBottomToolBar1;
            this.c1Ribbon1.ConfigToolBarHolder = this.ribbonConfigToolBar1;
            this.c1Ribbon1.Location = new System.Drawing.Point(0, 0);
            this.c1Ribbon1.Name = "c1Ribbon1";
            this.c1Ribbon1.QatHolder = this.ribbonQat1;
            this.c1Ribbon1.Size = new System.Drawing.Size(803, 161);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab1);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab2);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab3);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab4);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab5);
            this.c1Ribbon1.TopToolBarHolder = this.ribbonTopToolBar1;
            // 
            // ribbonApplicationMenu1
            // 
            this.ribbonApplicationMenu1.Name = "ribbonApplicationMenu1";
            // 
            // ribbonBottomToolBar1
            // 
            this.ribbonBottomToolBar1.Name = "ribbonBottomToolBar1";
            // 
            // ribbonConfigToolBar1
            // 
            this.ribbonConfigToolBar1.Name = "ribbonConfigToolBar1";
            // 
            // ribbonQat1
            // 
            this.ribbonQat1.Name = "ribbonQat1";
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Groups.Add(this.ribbonGroup1);
            this.ribbonTab1.Groups.Add(this.ribbonGroup2);
            this.ribbonTab1.Groups.Add(this.ribbonGroup3);
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "Cátalogos";
            // 
            // ribbonGroup1
            // 
            this.ribbonGroup1.Items.Add(this.btnCaCategoria);
            this.ribbonGroup1.Items.Add(this.btnCaProductos);
            this.ribbonGroup1.Name = "ribbonGroup1";
            // 
            // btnCaCategoria
            // 
            this.btnCaCategoria.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.btnCaCategoria.IconSet.Add(new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(96, 96), System.Drawing.Color.Transparent, ((System.Drawing.Image)(resources.GetObject("btnCaCategoria.IconSet")))));
            this.btnCaCategoria.Name = "btnCaCategoria";
            this.btnCaCategoria.Text = "Categorias";
            this.btnCaCategoria.Click += new System.EventHandler(this.btnCaCategoria_Click);
            // 
            // btnCaProductos
            // 
            this.btnCaProductos.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.btnCaProductos.IconSet.Add(new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(96, 96), System.Drawing.Color.Transparent, ((System.Drawing.Image)(resources.GetObject("btnCaProductos.IconSet")))));
            this.btnCaProductos.Name = "btnCaProductos";
            this.btnCaProductos.Text = "Productos";
            this.btnCaProductos.Click += new System.EventHandler(this.btnCaProductos_Click);
            // 
            // ribbonGroup2
            // 
            this.ribbonGroup2.Items.Add(this.btnCaProveedor);
            this.ribbonGroup2.Name = "ribbonGroup2";
            // 
            // btnCaProveedor
            // 
            this.btnCaProveedor.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.btnCaProveedor.IconSet.Add(new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(96, 96), System.Drawing.Color.Transparent, ((System.Drawing.Image)(resources.GetObject("btnCaProveedor.IconSet")))));
            this.btnCaProveedor.Name = "btnCaProveedor";
            this.btnCaProveedor.Text = "Clientes";
            this.btnCaProveedor.Click += new System.EventHandler(this.btnCaProveedor_Click);
            // 
            // ribbonGroup3
            // 
            this.ribbonGroup3.Items.Add(this.btnCaCliente);
            this.ribbonGroup3.Name = "ribbonGroup3";
            // 
            // btnCaCliente
            // 
            this.btnCaCliente.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.btnCaCliente.IconSet.Add(new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(256, 256), System.Drawing.Color.Transparent, ((System.Drawing.Image)(resources.GetObject("btnCaCliente.IconSet")))));
            this.btnCaCliente.Name = "btnCaCliente";
            this.btnCaCliente.Text = "Proveedor";
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.Groups.Add(this.ribbonGroup4);
            this.ribbonTab2.Name = "ribbonTab2";
            // 
            // ribbonGroup4
            // 
            this.ribbonGroup4.Name = "ribbonGroup4";
            this.ribbonGroup4.Text = "Group";
            // 
            // ribbonTab3
            // 
            this.ribbonTab3.Groups.Add(this.ribbonGroup5);
            this.ribbonTab3.Name = "ribbonTab3";
            this.ribbonTab3.Text = "Venta";
            // 
            // ribbonGroup5
            // 
            this.ribbonGroup5.Items.Add(this.btnCaVenta);
            this.ribbonGroup5.Name = "ribbonGroup5";
            // 
            // btnCaVenta
            // 
            this.btnCaVenta.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.btnCaVenta.IconSet.Add(new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(128, 128), System.Drawing.Color.Transparent, ((System.Drawing.Image)(resources.GetObject("btnCaVenta.IconSet")))));
            this.btnCaVenta.Name = "btnCaVenta";
            this.btnCaVenta.Text = "Venta";
            this.btnCaVenta.Click += new System.EventHandler(this.btnCaVenta_Click);
            // 
            // ribbonTab4
            // 
            this.ribbonTab4.Groups.Add(this.ribbonGroup6);
            this.ribbonTab4.Name = "ribbonTab4";
            this.ribbonTab4.Text = "Compra";
            // 
            // ribbonGroup6
            // 
            this.ribbonGroup6.Items.Add(this.btnCaCompra);
            this.ribbonGroup6.Name = "ribbonGroup6";
            this.ribbonGroup6.Text = "Group";
            // 
            // btnCaCompra
            // 
            this.btnCaCompra.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.btnCaCompra.IconSet.Add(new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(128, 128), System.Drawing.Color.Transparent, ((System.Drawing.Image)(resources.GetObject("btnCaCompra.IconSet")))));
            this.btnCaCompra.Name = "btnCaCompra";
            this.btnCaCompra.Text = "Compra";
            // 
            // ribbonTab5
            // 
            this.ribbonTab5.Groups.Add(this.ribbonGroup7);
            this.ribbonTab5.Name = "ribbonTab5";
            this.ribbonTab5.Text = "Administracion";
            // 
            // ribbonGroup7
            // 
            this.ribbonGroup7.Name = "ribbonGroup7";
            this.ribbonGroup7.Text = "Group";
            // 
            // ribbonTopToolBar1
            // 
            this.ribbonTopToolBar1.Name = "ribbonTopToolBar1";
            // 
            // pctPrincipal
            // 
            this.pctPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctPrincipal.Image = global::CpBroasteria.Properties.Resources.fondoo1;
            this.pctPrincipal.Location = new System.Drawing.Point(0, 161);
            this.pctPrincipal.Name = "pctPrincipal";
            this.pctPrincipal.Size = new System.Drawing.Size(803, 289);
            this.pctPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPrincipal.TabIndex = 1;
            this.pctPrincipal.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.pctPrincipal);
            this.Controls.Add(this.c1Ribbon1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.Ribbon.C1Ribbon c1Ribbon1;
        private C1.Win.Ribbon.RibbonApplicationMenu ribbonApplicationMenu1;
        private C1.Win.Ribbon.RibbonBottomToolBar ribbonBottomToolBar1;
        private C1.Win.Ribbon.RibbonConfigToolBar ribbonConfigToolBar1;
        private C1.Win.Ribbon.RibbonQat ribbonQat1;
        private C1.Win.Ribbon.RibbonTab ribbonTab1;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup1;
        private C1.Win.Ribbon.RibbonButton btnCaCategoria;
        private C1.Win.Ribbon.RibbonTopToolBar ribbonTopToolBar1;
        private C1.Win.Ribbon.RibbonButton btnCaProductos;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup2;
        private C1.Win.Ribbon.RibbonButton btnCaProveedor;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup3;
        private C1.Win.Ribbon.RibbonButton btnCaCliente;
        private C1.Win.Ribbon.RibbonTab ribbonTab2;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup4;
        private C1.Win.Ribbon.RibbonTab ribbonTab3;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup5;
        private C1.Win.Ribbon.RibbonButton btnCaVenta;
        private C1.Win.Ribbon.RibbonTab ribbonTab4;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup6;
        private C1.Win.Ribbon.RibbonTab ribbonTab5;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup7;
        private C1.Win.Ribbon.RibbonButton btnCaCompra;
        private System.Windows.Forms.PictureBox pctPrincipal;
    }
}