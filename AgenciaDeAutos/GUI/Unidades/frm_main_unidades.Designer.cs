﻿namespace AgenciaDeAutos.GUI.Unidades
{
    partial class frm_main_unidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main_unidades));
            this.gpBox_filters = new System.Windows.Forms.GroupBox();
            this.lbl_modelo = new System.Windows.Forms.Label();
            this.lbl_generacion = new System.Windows.Forms.Label();
            this.lbl_serie = new System.Windows.Forms.Label();
            this.lbl_fabricante = new System.Windows.Forms.Label();
            this.combo_modelo = new System.Windows.Forms.ComboBox();
            this.combo_generacion = new System.Windows.Forms.ComboBox();
            this.combo_serie = new System.Windows.Forms.ComboBox();
            this.combo_fabricante = new System.Windows.Forms.ComboBox();
            this.lbl_cv = new System.Windows.Forms.Label();
            this.lbl_hp = new System.Windows.Forms.Label();
            this.lbl_potencia = new System.Windows.Forms.Label();
            this.lbl_km = new System.Windows.Forms.Label();
            this.lbl_precio_venta = new System.Windows.Forms.Label();
            this.txt_hp = new System.Windows.Forms.TextBox();
            this.txt_cv = new System.Windows.Forms.TextBox();
            this.txt_km = new System.Windows.Forms.TextBox();
            this.txt_precio_dolar = new System.Windows.Forms.TextBox();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.lbl_stock = new System.Windows.Forms.Label();
            this.txt_precio_peso = new System.Windows.Forms.TextBox();
            this.lbl_cotizacion = new System.Windows.Forms.Label();
            this.lbl_peso_Arg = new System.Windows.Forms.Label();
            this.txt_cotizacion = new System.Windows.Forms.TextBox();
            this.lbl_dolar = new System.Windows.Forms.Label();
            this.labelhp = new System.Windows.Forms.Label();
            this.dgv_stock_unidades = new System.Windows.Forms.DataGridView();
            this.col_id_unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_añoModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_generacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_exit = new System.Windows.Forms.Button();
            this.add_shopping = new System.Windows.Forms.Button();
            this.pic_unidad = new System.Windows.Forms.PictureBox();
            this.gpBox_filters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stock_unidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_unidad)).BeginInit();
            this.SuspendLayout();
            // 
            // gpBox_filters
            // 
            this.gpBox_filters.Controls.Add(this.lbl_modelo);
            this.gpBox_filters.Controls.Add(this.lbl_generacion);
            this.gpBox_filters.Controls.Add(this.lbl_serie);
            this.gpBox_filters.Controls.Add(this.lbl_fabricante);
            this.gpBox_filters.Controls.Add(this.combo_modelo);
            this.gpBox_filters.Controls.Add(this.combo_generacion);
            this.gpBox_filters.Controls.Add(this.combo_serie);
            this.gpBox_filters.Controls.Add(this.combo_fabricante);
            this.gpBox_filters.Location = new System.Drawing.Point(23, 15);
            this.gpBox_filters.Name = "gpBox_filters";
            this.gpBox_filters.Size = new System.Drawing.Size(720, 185);
            this.gpBox_filters.TabIndex = 0;
            this.gpBox_filters.TabStop = false;
            this.gpBox_filters.Text = "Filtros";
            // 
            // lbl_modelo
            // 
            this.lbl_modelo.AutoSize = true;
            this.lbl_modelo.Location = new System.Drawing.Point(390, 115);
            this.lbl_modelo.Name = "lbl_modelo";
            this.lbl_modelo.Size = new System.Drawing.Size(45, 13);
            this.lbl_modelo.TabIndex = 12;
            this.lbl_modelo.Text = "Modelo:";
            // 
            // lbl_generacion
            // 
            this.lbl_generacion.AutoSize = true;
            this.lbl_generacion.Location = new System.Drawing.Point(370, 58);
            this.lbl_generacion.Name = "lbl_generacion";
            this.lbl_generacion.Size = new System.Drawing.Size(65, 13);
            this.lbl_generacion.TabIndex = 11;
            this.lbl_generacion.Text = "Generacion:";
            // 
            // lbl_serie
            // 
            this.lbl_serie.AutoSize = true;
            this.lbl_serie.Location = new System.Drawing.Point(57, 115);
            this.lbl_serie.Name = "lbl_serie";
            this.lbl_serie.Size = new System.Drawing.Size(34, 13);
            this.lbl_serie.TabIndex = 10;
            this.lbl_serie.Text = "Serie:";
            // 
            // lbl_fabricante
            // 
            this.lbl_fabricante.AutoSize = true;
            this.lbl_fabricante.Location = new System.Drawing.Point(31, 58);
            this.lbl_fabricante.Name = "lbl_fabricante";
            this.lbl_fabricante.Size = new System.Drawing.Size(60, 13);
            this.lbl_fabricante.TabIndex = 9;
            this.lbl_fabricante.Text = "Fabricante:";
            // 
            // combo_modelo
            // 
            this.combo_modelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_modelo.FormattingEnabled = true;
            this.combo_modelo.Location = new System.Drawing.Point(441, 112);
            this.combo_modelo.Name = "combo_modelo";
            this.combo_modelo.Size = new System.Drawing.Size(201, 21);
            this.combo_modelo.TabIndex = 3;
            this.combo_modelo.SelectedIndexChanged += new System.EventHandler(this.combo_modelo_SelectedIndexChanged);
            this.combo_modelo.SelectionChangeCommitted += new System.EventHandler(this.combo_modelo_SelectionChangeCommitted);
            // 
            // combo_generacion
            // 
            this.combo_generacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_generacion.FormattingEnabled = true;
            this.combo_generacion.Location = new System.Drawing.Point(441, 55);
            this.combo_generacion.Name = "combo_generacion";
            this.combo_generacion.Size = new System.Drawing.Size(201, 21);
            this.combo_generacion.TabIndex = 2;
            this.combo_generacion.SelectionChangeCommitted += new System.EventHandler(this.combo_generacion_SelectionChangeCommitted);
            // 
            // combo_serie
            // 
            this.combo_serie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_serie.FormattingEnabled = true;
            this.combo_serie.Location = new System.Drawing.Point(97, 112);
            this.combo_serie.Name = "combo_serie";
            this.combo_serie.Size = new System.Drawing.Size(201, 21);
            this.combo_serie.TabIndex = 1;
            this.combo_serie.SelectionChangeCommitted += new System.EventHandler(this.combo_serie_SelectionChangeCommitted);
            // 
            // combo_fabricante
            // 
            this.combo_fabricante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_fabricante.FormattingEnabled = true;
            this.combo_fabricante.Location = new System.Drawing.Point(97, 55);
            this.combo_fabricante.Name = "combo_fabricante";
            this.combo_fabricante.Size = new System.Drawing.Size(201, 21);
            this.combo_fabricante.TabIndex = 0;
            this.combo_fabricante.SelectedIndexChanged += new System.EventHandler(this.combo_fabricante_SelectedIndexChanged);
            this.combo_fabricante.SelectionChangeCommitted += new System.EventHandler(this.combo_fabricante_SelectionChangeCommitted);
            // 
            // lbl_cv
            // 
            this.lbl_cv.AutoSize = true;
            this.lbl_cv.Location = new System.Drawing.Point(1222, 419);
            this.lbl_cv.Name = "lbl_cv";
            this.lbl_cv.Size = new System.Drawing.Size(21, 13);
            this.lbl_cv.TabIndex = 24;
            this.lbl_cv.Text = "CV";
            // 
            // lbl_hp
            // 
            this.lbl_hp.AutoSize = true;
            this.lbl_hp.Location = new System.Drawing.Point(1225, 419);
            this.lbl_hp.Name = "lbl_hp";
            this.lbl_hp.Size = new System.Drawing.Size(22, 13);
            this.lbl_hp.TabIndex = 23;
            this.lbl_hp.Text = "HP";
            // 
            // lbl_potencia
            // 
            this.lbl_potencia.AutoSize = true;
            this.lbl_potencia.Location = new System.Drawing.Point(1161, 399);
            this.lbl_potencia.Name = "lbl_potencia";
            this.lbl_potencia.Size = new System.Drawing.Size(52, 13);
            this.lbl_potencia.TabIndex = 16;
            this.lbl_potencia.Text = "Potencia:";
            // 
            // lbl_km
            // 
            this.lbl_km.AutoSize = true;
            this.lbl_km.Location = new System.Drawing.Point(1161, 362);
            this.lbl_km.Name = "lbl_km";
            this.lbl_km.Size = new System.Drawing.Size(58, 13);
            this.lbl_km.TabIndex = 15;
            this.lbl_km.Text = "Kilometros:";
            // 
            // lbl_precio_venta
            // 
            this.lbl_precio_venta.AutoSize = true;
            this.lbl_precio_venta.Location = new System.Drawing.Point(771, 402);
            this.lbl_precio_venta.Name = "lbl_precio_venta";
            this.lbl_precio_venta.Size = new System.Drawing.Size(70, 13);
            this.lbl_precio_venta.TabIndex = 13;
            this.lbl_precio_venta.Text = "Precio venta:";
            // 
            // txt_hp
            // 
            this.txt_hp.Location = new System.Drawing.Point(1225, 435);
            this.txt_hp.Name = "txt_hp";
            this.txt_hp.ReadOnly = true;
            this.txt_hp.Size = new System.Drawing.Size(100, 20);
            this.txt_hp.TabIndex = 8;
            // 
            // txt_cv
            // 
            this.txt_cv.Location = new System.Drawing.Point(1225, 396);
            this.txt_cv.Name = "txt_cv";
            this.txt_cv.ReadOnly = true;
            this.txt_cv.Size = new System.Drawing.Size(100, 20);
            this.txt_cv.TabIndex = 7;
            this.txt_cv.TextChanged += new System.EventHandler(this.txt_cv_TextChanged);
            // 
            // txt_km
            // 
            this.txt_km.Location = new System.Drawing.Point(1225, 359);
            this.txt_km.Name = "txt_km";
            this.txt_km.ReadOnly = true;
            this.txt_km.Size = new System.Drawing.Size(100, 20);
            this.txt_km.TabIndex = 6;
            // 
            // txt_precio_dolar
            // 
            this.txt_precio_dolar.Location = new System.Drawing.Point(847, 399);
            this.txt_precio_dolar.Name = "txt_precio_dolar";
            this.txt_precio_dolar.ReadOnly = true;
            this.txt_precio_dolar.Size = new System.Drawing.Size(100, 20);
            this.txt_precio_dolar.TabIndex = 4;
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Location = new System.Drawing.Point(769, 470);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(66, 13);
            this.lbl_descripcion.TabIndex = 3;
            this.lbl_descripcion.Text = "Descripcion:";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(772, 490);
            this.txt_descripcion.MaxLength = 1000;
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.ReadOnly = true;
            this.txt_descripcion.Size = new System.Drawing.Size(553, 109);
            this.txt_descripcion.TabIndex = 25;
            // 
            // lbl_stock
            // 
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.Location = new System.Drawing.Point(764, 15);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(38, 13);
            this.lbl_stock.TabIndex = 25;
            this.lbl_stock.Text = "Stock:";
            // 
            // txt_precio_peso
            // 
            this.txt_precio_peso.Location = new System.Drawing.Point(847, 438);
            this.txt_precio_peso.Name = "txt_precio_peso";
            this.txt_precio_peso.ReadOnly = true;
            this.txt_precio_peso.Size = new System.Drawing.Size(100, 20);
            this.txt_precio_peso.TabIndex = 27;
            // 
            // lbl_cotizacion
            // 
            this.lbl_cotizacion.AutoSize = true;
            this.lbl_cotizacion.Location = new System.Drawing.Point(785, 362);
            this.lbl_cotizacion.Name = "lbl_cotizacion";
            this.lbl_cotizacion.Size = new System.Drawing.Size(59, 13);
            this.lbl_cotizacion.TabIndex = 28;
            this.lbl_cotizacion.Text = "Cotizacion:";
            // 
            // lbl_peso_Arg
            // 
            this.lbl_peso_Arg.AutoSize = true;
            this.lbl_peso_Arg.Location = new System.Drawing.Point(953, 442);
            this.lbl_peso_Arg.Name = "lbl_peso_Arg";
            this.lbl_peso_Arg.Size = new System.Drawing.Size(28, 13);
            this.lbl_peso_Arg.TabIndex = 29;
            this.lbl_peso_Arg.Text = "AR$";
            // 
            // txt_cotizacion
            // 
            this.txt_cotizacion.Location = new System.Drawing.Point(847, 359);
            this.txt_cotizacion.Name = "txt_cotizacion";
            this.txt_cotizacion.Size = new System.Drawing.Size(100, 20);
            this.txt_cotizacion.TabIndex = 31;
            this.txt_cotizacion.TextChanged += new System.EventHandler(this.txt_cotizacion_TextChanged);
            // 
            // lbl_dolar
            // 
            this.lbl_dolar.AutoSize = true;
            this.lbl_dolar.Location = new System.Drawing.Point(953, 402);
            this.lbl_dolar.Name = "lbl_dolar";
            this.lbl_dolar.Size = new System.Drawing.Size(28, 13);
            this.lbl_dolar.TabIndex = 32;
            this.lbl_dolar.Text = "US$";
            // 
            // labelhp
            // 
            this.labelhp.AutoSize = true;
            this.labelhp.Location = new System.Drawing.Point(1225, 458);
            this.labelhp.Name = "labelhp";
            this.labelhp.Size = new System.Drawing.Size(22, 13);
            this.labelhp.TabIndex = 33;
            this.labelhp.Text = "HP";
            // 
            // dgv_stock_unidades
            // 
            this.dgv_stock_unidades.AllowUserToAddRows = false;
            this.dgv_stock_unidades.AllowUserToDeleteRows = false;
            this.dgv_stock_unidades.AllowUserToOrderColumns = true;
            this.dgv_stock_unidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_stock_unidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id_unidad,
            this.col_fabricante,
            this.col_modelo,
            this.col_añoModelo,
            this.col_generacion});
            this.dgv_stock_unidades.Location = new System.Drawing.Point(765, 31);
            this.dgv_stock_unidades.Name = "dgv_stock_unidades";
            this.dgv_stock_unidades.ReadOnly = true;
            this.dgv_stock_unidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_stock_unidades.Size = new System.Drawing.Size(560, 315);
            this.dgv_stock_unidades.TabIndex = 34;
            this.dgv_stock_unidades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_stock_unidades_CellClick);
            this.dgv_stock_unidades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_stock_unidades_CellContentClick);
            this.dgv_stock_unidades.CurrentCellChanged += new System.EventHandler(this.dgv_stock_unidades_CurrentCellChanged);
            // 
            // col_id_unidad
            // 
            this.col_id_unidad.HeaderText = "NºUnidad";
            this.col_id_unidad.Name = "col_id_unidad";
            this.col_id_unidad.ReadOnly = true;
            // 
            // col_fabricante
            // 
            this.col_fabricante.HeaderText = "Fabricante";
            this.col_fabricante.Name = "col_fabricante";
            this.col_fabricante.ReadOnly = true;
            // 
            // col_modelo
            // 
            this.col_modelo.HeaderText = "Modelo";
            this.col_modelo.Name = "col_modelo";
            this.col_modelo.ReadOnly = true;
            // 
            // col_añoModelo
            // 
            this.col_añoModelo.HeaderText = "Año";
            this.col_añoModelo.Name = "col_añoModelo";
            this.col_añoModelo.ReadOnly = true;
            // 
            // col_generacion
            // 
            this.col_generacion.HeaderText = "Generacion";
            this.col_generacion.Name = "col_generacion";
            this.col_generacion.ReadOnly = true;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(1263, 694);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 35;
            this.btn_exit.Text = "Salir";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // add_shopping
            // 
            this.add_shopping.Image = global::AgenciaDeAutos.Properties.Resources.icons8_add_shopping_cart_96px;
            this.add_shopping.Location = new System.Drawing.Point(772, 615);
            this.add_shopping.Name = "add_shopping";
            this.add_shopping.Size = new System.Drawing.Size(106, 92);
            this.add_shopping.TabIndex = 26;
            this.add_shopping.Text = ".";
            this.add_shopping.UseVisualStyleBackColor = true;
            this.add_shopping.Click += new System.EventHandler(this.add_shopping_Click);
            // 
            // pic_unidad
            // 
            this.pic_unidad.Cursor = System.Windows.Forms.Cursors.Default;
            this.pic_unidad.Image = global::AgenciaDeAutos.Properties.Resources.errorUnidadBig;
            this.pic_unidad.InitialImage = global::AgenciaDeAutos.Properties.Resources.errorUnidad;
            this.pic_unidad.Location = new System.Drawing.Point(23, 227);
            this.pic_unidad.Name = "pic_unidad";
            this.pic_unidad.Size = new System.Drawing.Size(720, 480);
            this.pic_unidad.TabIndex = 2;
            this.pic_unidad.TabStop = false;
            // 
            // frm_main_unidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.dgv_stock_unidades);
            this.Controls.Add(this.labelhp);
            this.Controls.Add(this.lbl_dolar);
            this.Controls.Add(this.txt_cotizacion);
            this.Controls.Add(this.lbl_peso_Arg);
            this.Controls.Add(this.lbl_cotizacion);
            this.Controls.Add(this.txt_precio_peso);
            this.Controls.Add(this.add_shopping);
            this.Controls.Add(this.lbl_stock);
            this.Controls.Add(this.lbl_cv);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.lbl_hp);
            this.Controls.Add(this.lbl_km);
            this.Controls.Add(this.lbl_potencia);
            this.Controls.Add(this.lbl_descripcion);
            this.Controls.Add(this.pic_unidad);
            this.Controls.Add(this.lbl_precio_venta);
            this.Controls.Add(this.gpBox_filters);
            this.Controls.Add(this.txt_hp);
            this.Controls.Add(this.txt_precio_dolar);
            this.Controls.Add(this.txt_cv);
            this.Controls.Add(this.txt_km);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_main_unidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock unidades";
            this.Load += new System.EventHandler(this.frm_main_unidades_Load);
            this.gpBox_filters.ResumeLayout(false);
            this.gpBox_filters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stock_unidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_unidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpBox_filters;
        private System.Windows.Forms.ComboBox combo_fabricante;
        private System.Windows.Forms.ComboBox combo_modelo;
        private System.Windows.Forms.ComboBox combo_generacion;
        private System.Windows.Forms.ComboBox combo_serie;
        private System.Windows.Forms.TextBox txt_hp;
        private System.Windows.Forms.TextBox txt_cv;
        private System.Windows.Forms.TextBox txt_km;
        private System.Windows.Forms.TextBox txt_precio_dolar;
        private System.Windows.Forms.Label lbl_modelo;
        private System.Windows.Forms.Label lbl_generacion;
        private System.Windows.Forms.Label lbl_serie;
        private System.Windows.Forms.Label lbl_fabricante;
        private System.Windows.Forms.Label lbl_potencia;
        private System.Windows.Forms.Label lbl_km;
        private System.Windows.Forms.Label lbl_precio_venta;
        private System.Windows.Forms.Label lbl_cv;
        private System.Windows.Forms.Label lbl_hp;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label lbl_stock;
        private System.Windows.Forms.Button add_shopping;
        private System.Windows.Forms.TextBox txt_precio_peso;
        private System.Windows.Forms.Label lbl_cotizacion;
        private System.Windows.Forms.Label lbl_peso_Arg;
        private System.Windows.Forms.TextBox txt_cotizacion;
        private System.Windows.Forms.Label lbl_dolar;
        private System.Windows.Forms.Label labelhp;
        private System.Windows.Forms.DataGridView dgv_stock_unidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id_unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fabricante;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_añoModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_generacion;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.PictureBox pic_unidad;
    }
}