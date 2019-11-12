namespace AgenciaDeAutos.GUI.Otros
{
    partial class frm_main_normal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main_normal));
            this.menu_main = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionNegocioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_brands = new System.Windows.Forms.Button();
            this.btn_sale = new System.Windows.Forms.Button();
            this.btn_postVenta = new System.Windows.Forms.Button();
            this.menu_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_main
            // 
            this.menu_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menu_main.Location = new System.Drawing.Point(0, 0);
            this.menu_main.Name = "menu_main";
            this.menu_main.Size = new System.Drawing.Size(800, 24);
            this.menu_main.TabIndex = 0;
            this.menu_main.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionNegocioToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // gestionNegocioToolStripMenuItem
            // 
            this.gestionNegocioToolStripMenuItem.Name = "gestionNegocioToolStripMenuItem";
            this.gestionNegocioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestionNegocioToolStripMenuItem.Text = "Nuevo cliente";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar sesion";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // btn_brands
            // 
            this.btn_brands.Location = new System.Drawing.Point(103, 214);
            this.btn_brands.Name = "btn_brands";
            this.btn_brands.Size = new System.Drawing.Size(75, 46);
            this.btn_brands.TabIndex = 1;
            this.btn_brands.Text = "Fabricantes";
            this.btn_brands.UseVisualStyleBackColor = true;
            this.btn_brands.Click += new System.EventHandler(this.btn_brands_Click);
            // 
            // btn_sale
            // 
            this.btn_sale.Location = new System.Drawing.Point(338, 214);
            this.btn_sale.Name = "btn_sale";
            this.btn_sale.Size = new System.Drawing.Size(75, 46);
            this.btn_sale.TabIndex = 2;
            this.btn_sale.Text = "Ventas";
            this.btn_sale.UseVisualStyleBackColor = true;
            this.btn_sale.Click += new System.EventHandler(this.btn_sale_Click);
            // 
            // btn_postVenta
            // 
            this.btn_postVenta.Location = new System.Drawing.Point(571, 214);
            this.btn_postVenta.Name = "btn_postVenta";
            this.btn_postVenta.Size = new System.Drawing.Size(75, 46);
            this.btn_postVenta.TabIndex = 3;
            this.btn_postVenta.Text = "Post venta";
            this.btn_postVenta.UseVisualStyleBackColor = true;
            this.btn_postVenta.Click += new System.EventHandler(this.btn_postVenta_Click);
            // 
            // frm_main_normal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_postVenta);
            this.Controls.Add(this.btn_sale);
            this.Controls.Add(this.btn_brands);
            this.Controls.Add(this.menu_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu_main;
            this.Name = "frm_main_normal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.menu_main.ResumeLayout(false);
            this.menu_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu_main;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionNegocioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Button btn_brands;
        private System.Windows.Forms.Button btn_sale;
        private System.Windows.Forms.Button btn_postVenta;
    }
}