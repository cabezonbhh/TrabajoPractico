namespace AgenciaDeAutos.GUI.PostVentaServices
{
    partial class frm_new_service
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
            this.lbl_trabajo = new System.Windows.Forms.Label();
            this.combo_trabajos = new System.Windows.Forms.ComboBox();
            this.txt_tareas_trabajos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_descripcion_trabajos = new System.Windows.Forms.Label();
            this.lbl_detalles_services = new System.Windows.Forms.Label();
            this.txt_detalles_realizados = new System.Windows.Forms.TextBox();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.txt_precio_arg = new System.Windows.Forms.TextBox();
            this.lbl_ar = new System.Windows.Forms.Label();
            this.txt_cotizacion = new System.Windows.Forms.TextBox();
            this.lbl_cotizacion = new System.Windows.Forms.Label();
            this.lbl_dolar = new System.Windows.Forms.Label();
            this.txt_precio_dolar = new System.Windows.Forms.TextBox();
            this.dgv_detalles = new System.Windows.Forms.DataGridView();
            this.col_nro_orden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_precio_arg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_precio_dolar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_add_detail = new System.Windows.Forms.Button();
            this.lbl_vehiculo = new System.Windows.Forms.Label();
            this.lbl_total_dolar = new System.Windows.Forms.Label();
            this.txt_total_dolar = new System.Windows.Forms.TextBox();
            this.lbl_total_peso = new System.Windows.Forms.Label();
            this.txt_total_peso = new System.Windows.Forms.TextBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.txt_km_actual = new System.Windows.Forms.TextBox();
            this.lbl_km_actual = new System.Windows.Forms.Label();
            this.txt_km_limite = new System.Windows.Forms.TextBox();
            this.lbl_km_limite = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalles)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_trabajo
            // 
            this.lbl_trabajo.AutoSize = true;
            this.lbl_trabajo.Location = new System.Drawing.Point(337, 7);
            this.lbl_trabajo.Name = "lbl_trabajo";
            this.lbl_trabajo.Size = new System.Drawing.Size(48, 13);
            this.lbl_trabajo.TabIndex = 0;
            this.lbl_trabajo.Text = "Trabajos";
            // 
            // combo_trabajos
            // 
            this.combo_trabajos.FormattingEnabled = true;
            this.combo_trabajos.Location = new System.Drawing.Point(340, 23);
            this.combo_trabajos.Name = "combo_trabajos";
            this.combo_trabajos.Size = new System.Drawing.Size(189, 21);
            this.combo_trabajos.TabIndex = 1;
            this.combo_trabajos.SelectionChangeCommitted += new System.EventHandler(this.combo_trabajos_SelectionChangeCommitted);
            // 
            // txt_tareas_trabajos
            // 
            this.txt_tareas_trabajos.Location = new System.Drawing.Point(340, 74);
            this.txt_tareas_trabajos.Multiline = true;
            this.txt_tareas_trabajos.Name = "txt_tareas_trabajos";
            this.txt_tareas_trabajos.Size = new System.Drawing.Size(342, 84);
            this.txt_tareas_trabajos.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = " ";
            // 
            // lbl_descripcion_trabajos
            // 
            this.lbl_descripcion_trabajos.AutoSize = true;
            this.lbl_descripcion_trabajos.Location = new System.Drawing.Point(337, 57);
            this.lbl_descripcion_trabajos.Name = "lbl_descripcion_trabajos";
            this.lbl_descripcion_trabajos.Size = new System.Drawing.Size(40, 13);
            this.lbl_descripcion_trabajos.TabIndex = 4;
            this.lbl_descripcion_trabajos.Text = "Tareas";
            // 
            // lbl_detalles_services
            // 
            this.lbl_detalles_services.AutoSize = true;
            this.lbl_detalles_services.Location = new System.Drawing.Point(9, 159);
            this.lbl_detalles_services.Name = "lbl_detalles_services";
            this.lbl_detalles_services.Size = new System.Drawing.Size(128, 13);
            this.lbl_detalles_services.TabIndex = 6;
            this.lbl_detalles_services.Text = "Describir trabajo realizado";
            // 
            // txt_detalles_realizados
            // 
            this.txt_detalles_realizados.Location = new System.Drawing.Point(12, 175);
            this.txt_detalles_realizados.Multiline = true;
            this.txt_detalles_realizados.Name = "txt_detalles_realizados";
            this.txt_detalles_realizados.Size = new System.Drawing.Size(670, 121);
            this.txt_detalles_realizados.TabIndex = 5;
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Location = new System.Drawing.Point(464, 308);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(40, 13);
            this.lbl_precio.TabIndex = 7;
            this.lbl_precio.Text = "Precio:";
            // 
            // txt_precio_arg
            // 
            this.txt_precio_arg.Location = new System.Drawing.Point(510, 340);
            this.txt_precio_arg.Name = "txt_precio_arg";
            this.txt_precio_arg.ReadOnly = true;
            this.txt_precio_arg.Size = new System.Drawing.Size(130, 20);
            this.txt_precio_arg.TabIndex = 8;
            // 
            // lbl_ar
            // 
            this.lbl_ar.AutoSize = true;
            this.lbl_ar.Location = new System.Drawing.Point(646, 349);
            this.lbl_ar.Name = "lbl_ar";
            this.lbl_ar.Size = new System.Drawing.Size(28, 13);
            this.lbl_ar.TabIndex = 9;
            this.lbl_ar.Text = "AR$";
            // 
            // txt_cotizacion
            // 
            this.txt_cotizacion.Location = new System.Drawing.Point(317, 305);
            this.txt_cotizacion.Name = "txt_cotizacion";
            this.txt_cotizacion.Size = new System.Drawing.Size(130, 20);
            this.txt_cotizacion.TabIndex = 11;
            this.txt_cotizacion.TextChanged += new System.EventHandler(this.txt_cotizacion_TextChanged);
            // 
            // lbl_cotizacion
            // 
            this.lbl_cotizacion.AutoSize = true;
            this.lbl_cotizacion.Location = new System.Drawing.Point(252, 308);
            this.lbl_cotizacion.Name = "lbl_cotizacion";
            this.lbl_cotizacion.Size = new System.Drawing.Size(59, 13);
            this.lbl_cotizacion.TabIndex = 10;
            this.lbl_cotizacion.Text = "Cotizacion:";
            // 
            // lbl_dolar
            // 
            this.lbl_dolar.AutoSize = true;
            this.lbl_dolar.Location = new System.Drawing.Point(646, 314);
            this.lbl_dolar.Name = "lbl_dolar";
            this.lbl_dolar.Size = new System.Drawing.Size(28, 13);
            this.lbl_dolar.TabIndex = 13;
            this.lbl_dolar.Text = "US$";
            // 
            // txt_precio_dolar
            // 
            this.txt_precio_dolar.Location = new System.Drawing.Point(510, 305);
            this.txt_precio_dolar.Name = "txt_precio_dolar";
            this.txt_precio_dolar.Size = new System.Drawing.Size(130, 20);
            this.txt_precio_dolar.TabIndex = 12;
            this.txt_precio_dolar.TextChanged += new System.EventHandler(this.txt_precio_dolar_TextChanged);
            // 
            // dgv_detalles
            // 
            this.dgv_detalles.AllowUserToAddRows = false;
            this.dgv_detalles.AllowUserToDeleteRows = false;
            this.dgv_detalles.AllowUserToOrderColumns = true;
            this.dgv_detalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_nro_orden,
            this.col_titulo,
            this.col_descripcion,
            this.col_precio_arg,
            this.col_precio_dolar});
            this.dgv_detalles.Location = new System.Drawing.Point(12, 400);
            this.dgv_detalles.Name = "dgv_detalles";
            this.dgv_detalles.ReadOnly = true;
            this.dgv_detalles.Size = new System.Drawing.Size(670, 150);
            this.dgv_detalles.TabIndex = 14;
            // 
            // col_nro_orden
            // 
            this.col_nro_orden.HeaderText = "N° ";
            this.col_nro_orden.Name = "col_nro_orden";
            this.col_nro_orden.ReadOnly = true;
            // 
            // col_titulo
            // 
            this.col_titulo.HeaderText = "Tareas";
            this.col_titulo.Name = "col_titulo";
            this.col_titulo.ReadOnly = true;
            // 
            // col_descripcion
            // 
            this.col_descripcion.HeaderText = "Descripcion";
            this.col_descripcion.Name = "col_descripcion";
            this.col_descripcion.ReadOnly = true;
            // 
            // col_precio_arg
            // 
            this.col_precio_arg.HeaderText = "Precio AR$";
            this.col_precio_arg.Name = "col_precio_arg";
            this.col_precio_arg.ReadOnly = true;
            // 
            // col_precio_dolar
            // 
            this.col_precio_dolar.HeaderText = "Precio US$";
            this.col_precio_dolar.Name = "col_precio_dolar";
            this.col_precio_dolar.ReadOnly = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(591, 650);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(91, 32);
            this.btn_cancelar.TabIndex = 15;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_save.Location = new System.Drawing.Point(483, 650);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(91, 32);
            this.btn_save.TabIndex = 16;
            this.btn_save.Text = "Confirmar";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_add_detail
            // 
            this.btn_add_detail.Location = new System.Drawing.Point(12, 305);
            this.btn_add_detail.Name = "btn_add_detail";
            this.btn_add_detail.Size = new System.Drawing.Size(91, 32);
            this.btn_add_detail.TabIndex = 17;
            this.btn_add_detail.Text = "Agregar";
            this.btn_add_detail.UseVisualStyleBackColor = true;
            this.btn_add_detail.Click += new System.EventHandler(this.btn_add_detail_Click);
            // 
            // lbl_vehiculo
            // 
            this.lbl_vehiculo.AutoSize = true;
            this.lbl_vehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vehiculo.ForeColor = System.Drawing.Color.Blue;
            this.lbl_vehiculo.Location = new System.Drawing.Point(12, 24);
            this.lbl_vehiculo.Name = "lbl_vehiculo";
            this.lbl_vehiculo.Size = new System.Drawing.Size(78, 15);
            this.lbl_vehiculo.TabIndex = 18;
            this.lbl_vehiculo.Text = "datos unidad";
            // 
            // lbl_total_dolar
            // 
            this.lbl_total_dolar.AutoSize = true;
            this.lbl_total_dolar.Location = new System.Drawing.Point(452, 579);
            this.lbl_total_dolar.Name = "lbl_total_dolar";
            this.lbl_total_dolar.Size = new System.Drawing.Size(28, 13);
            this.lbl_total_dolar.TabIndex = 23;
            this.lbl_total_dolar.Text = "US$";
            // 
            // txt_total_dolar
            // 
            this.txt_total_dolar.Location = new System.Drawing.Point(350, 556);
            this.txt_total_dolar.Name = "txt_total_dolar";
            this.txt_total_dolar.ReadOnly = true;
            this.txt_total_dolar.Size = new System.Drawing.Size(130, 20);
            this.txt_total_dolar.TabIndex = 22;
            this.txt_total_dolar.TextChanged += new System.EventHandler(this.txt_total_dolar_TextChanged);
            // 
            // lbl_total_peso
            // 
            this.lbl_total_peso.AutoSize = true;
            this.lbl_total_peso.Location = new System.Drawing.Point(646, 579);
            this.lbl_total_peso.Name = "lbl_total_peso";
            this.lbl_total_peso.Size = new System.Drawing.Size(28, 13);
            this.lbl_total_peso.TabIndex = 21;
            this.lbl_total_peso.Text = "AR$";
            // 
            // txt_total_peso
            // 
            this.txt_total_peso.Location = new System.Drawing.Point(544, 556);
            this.txt_total_peso.Name = "txt_total_peso";
            this.txt_total_peso.ReadOnly = true;
            this.txt_total_peso.Size = new System.Drawing.Size(130, 20);
            this.txt_total_peso.TabIndex = 20;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(310, 559);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(34, 13);
            this.lbl_total.TabIndex = 19;
            this.lbl_total.Text = "Total:";
            // 
            // txt_km_actual
            // 
            this.txt_km_actual.Location = new System.Drawing.Point(78, 57);
            this.txt_km_actual.Name = "txt_km_actual";
            this.txt_km_actual.Size = new System.Drawing.Size(130, 20);
            this.txt_km_actual.TabIndex = 25;
            // 
            // lbl_km_actual
            // 
            this.lbl_km_actual.AutoSize = true;
            this.lbl_km_actual.Location = new System.Drawing.Point(15, 60);
            this.lbl_km_actual.Name = "lbl_km_actual";
            this.lbl_km_actual.Size = new System.Drawing.Size(57, 13);
            this.lbl_km_actual.TabIndex = 24;
            this.lbl_km_actual.Text = "Km actual:";
            // 
            // txt_km_limite
            // 
            this.txt_km_limite.Location = new System.Drawing.Point(78, 95);
            this.txt_km_limite.Name = "txt_km_limite";
            this.txt_km_limite.Size = new System.Drawing.Size(130, 20);
            this.txt_km_limite.TabIndex = 27;
            // 
            // lbl_km_limite
            // 
            this.lbl_km_limite.AutoSize = true;
            this.lbl_km_limite.Location = new System.Drawing.Point(21, 98);
            this.lbl_km_limite.Name = "lbl_km_limite";
            this.lbl_km_limite.Size = new System.Drawing.Size(51, 13);
            this.lbl_km_limite.TabIndex = 26;
            this.lbl_km_limite.Text = "Km limite:";
            // 
            // frm_new_service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 712);
            this.Controls.Add(this.txt_km_limite);
            this.Controls.Add(this.lbl_km_limite);
            this.Controls.Add(this.txt_km_actual);
            this.Controls.Add(this.lbl_km_actual);
            this.Controls.Add(this.lbl_total_dolar);
            this.Controls.Add(this.txt_total_dolar);
            this.Controls.Add(this.lbl_total_peso);
            this.Controls.Add(this.txt_total_peso);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_vehiculo);
            this.Controls.Add(this.btn_add_detail);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.dgv_detalles);
            this.Controls.Add(this.lbl_dolar);
            this.Controls.Add(this.txt_precio_dolar);
            this.Controls.Add(this.txt_cotizacion);
            this.Controls.Add(this.lbl_cotizacion);
            this.Controls.Add(this.lbl_ar);
            this.Controls.Add(this.txt_precio_arg);
            this.Controls.Add(this.lbl_precio);
            this.Controls.Add(this.lbl_detalles_services);
            this.Controls.Add(this.txt_detalles_realizados);
            this.Controls.Add(this.lbl_descripcion_trabajos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_tareas_trabajos);
            this.Controls.Add(this.combo_trabajos);
            this.Controls.Add(this.lbl_trabajo);
            this.Name = "frm_new_service";
            this.Text = "frm_detalles_service";
            this.Load += new System.EventHandler(this.frm_new_service_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_trabajo;
        private System.Windows.Forms.ComboBox combo_trabajos;
        private System.Windows.Forms.TextBox txt_tareas_trabajos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_descripcion_trabajos;
        private System.Windows.Forms.Label lbl_detalles_services;
        private System.Windows.Forms.TextBox txt_detalles_realizados;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.TextBox txt_precio_arg;
        private System.Windows.Forms.Label lbl_ar;
        private System.Windows.Forms.TextBox txt_cotizacion;
        private System.Windows.Forms.Label lbl_cotizacion;
        private System.Windows.Forms.Label lbl_dolar;
        private System.Windows.Forms.TextBox txt_precio_dolar;
        private System.Windows.Forms.DataGridView dgv_detalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nro_orden;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_precio_arg;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_precio_dolar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_add_detail;
        private System.Windows.Forms.Label lbl_vehiculo;
        private System.Windows.Forms.Label lbl_total_dolar;
        private System.Windows.Forms.TextBox txt_total_dolar;
        private System.Windows.Forms.Label lbl_total_peso;
        private System.Windows.Forms.TextBox txt_total_peso;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.TextBox txt_km_actual;
        private System.Windows.Forms.Label lbl_km_actual;
        private System.Windows.Forms.TextBox txt_km_limite;
        private System.Windows.Forms.Label lbl_km_limite;
    }
}