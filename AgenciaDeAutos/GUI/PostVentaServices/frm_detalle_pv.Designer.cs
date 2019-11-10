namespace AgenciaDeAutos.GUI.PostVentaServices
{
    partial class frm_detalle_pv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_detalle_pv));
            this.txt_km_limite = new System.Windows.Forms.TextBox();
            this.lbl_km_limite = new System.Windows.Forms.Label();
            this.lbl_vehiculo = new System.Windows.Forms.Label();
            this.lbl_detalles_services = new System.Windows.Forms.Label();
            this.txt_detalles_realizados = new System.Windows.Forms.TextBox();
            this.lbl_descripcion_trabajos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tareas_trabajos = new System.Windows.Forms.TextBox();
            this.dgv_detalles = new System.Windows.Forms.DataGridView();
            this.lbl_detalles = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_total_dolar = new System.Windows.Forms.Label();
            this.txt_total_dolar = new System.Windows.Forms.TextBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.col_nro_orden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_trabajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_precio_dolar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tareas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_km_limite
            // 
            this.txt_km_limite.Location = new System.Drawing.Point(559, 319);
            this.txt_km_limite.Name = "txt_km_limite";
            this.txt_km_limite.ReadOnly = true;
            this.txt_km_limite.Size = new System.Drawing.Size(130, 20);
            this.txt_km_limite.TabIndex = 47;
            // 
            // lbl_km_limite
            // 
            this.lbl_km_limite.AutoSize = true;
            this.lbl_km_limite.Location = new System.Drawing.Point(502, 322);
            this.lbl_km_limite.Name = "lbl_km_limite";
            this.lbl_km_limite.Size = new System.Drawing.Size(51, 13);
            this.lbl_km_limite.TabIndex = 46;
            this.lbl_km_limite.Text = "Km limite:";
            // 
            // lbl_vehiculo
            // 
            this.lbl_vehiculo.AutoSize = true;
            this.lbl_vehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vehiculo.ForeColor = System.Drawing.Color.Blue;
            this.lbl_vehiculo.Location = new System.Drawing.Point(73, 29);
            this.lbl_vehiculo.Name = "lbl_vehiculo";
            this.lbl_vehiculo.Size = new System.Drawing.Size(78, 15);
            this.lbl_vehiculo.TabIndex = 43;
            this.lbl_vehiculo.Text = "datos unidad";
            // 
            // lbl_detalles_services
            // 
            this.lbl_detalles_services.AutoSize = true;
            this.lbl_detalles_services.Location = new System.Drawing.Point(19, 426);
            this.lbl_detalles_services.Name = "lbl_detalles_services";
            this.lbl_detalles_services.Size = new System.Drawing.Size(128, 13);
            this.lbl_detalles_services.TabIndex = 34;
            this.lbl_detalles_services.Text = "Describir trabajo realizado";
            // 
            // txt_detalles_realizados
            // 
            this.txt_detalles_realizados.Location = new System.Drawing.Point(22, 442);
            this.txt_detalles_realizados.Multiline = true;
            this.txt_detalles_realizados.Name = "txt_detalles_realizados";
            this.txt_detalles_realizados.ReadOnly = true;
            this.txt_detalles_realizados.Size = new System.Drawing.Size(667, 121);
            this.txt_detalles_realizados.TabIndex = 33;
            // 
            // lbl_descripcion_trabajos
            // 
            this.lbl_descripcion_trabajos.AutoSize = true;
            this.lbl_descripcion_trabajos.Location = new System.Drawing.Point(16, 303);
            this.lbl_descripcion_trabajos.Name = "lbl_descripcion_trabajos";
            this.lbl_descripcion_trabajos.Size = new System.Drawing.Size(40, 13);
            this.lbl_descripcion_trabajos.TabIndex = 32;
            this.lbl_descripcion_trabajos.Text = "Tareas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = " ";
            // 
            // txt_tareas_trabajos
            // 
            this.txt_tareas_trabajos.Location = new System.Drawing.Point(19, 319);
            this.txt_tareas_trabajos.Multiline = true;
            this.txt_tareas_trabajos.Name = "txt_tareas_trabajos";
            this.txt_tareas_trabajos.ReadOnly = true;
            this.txt_tareas_trabajos.Size = new System.Drawing.Size(342, 84);
            this.txt_tareas_trabajos.TabIndex = 30;
            // 
            // dgv_detalles
            // 
            this.dgv_detalles.AllowUserToAddRows = false;
            this.dgv_detalles.AllowUserToDeleteRows = false;
            this.dgv_detalles.AllowUserToOrderColumns = true;
            this.dgv_detalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_nro_orden,
            this.col_trabajo,
            this.col_precio_dolar,
            this.tareas,
            this.descripcion});
            this.dgv_detalles.Location = new System.Drawing.Point(19, 112);
            this.dgv_detalles.Name = "dgv_detalles";
            this.dgv_detalles.ReadOnly = true;
            this.dgv_detalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_detalles.Size = new System.Drawing.Size(670, 150);
            this.dgv_detalles.TabIndex = 48;
            this.dgv_detalles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_detalles_CellClick);
            this.dgv_detalles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_detalles_CellDoubleClick);
            // 
            // lbl_detalles
            // 
            this.lbl_detalles.AutoSize = true;
            this.lbl_detalles.Location = new System.Drawing.Point(16, 96);
            this.lbl_detalles.Name = "lbl_detalles";
            this.lbl_detalles.Size = new System.Drawing.Size(97, 13);
            this.lbl_detalles.TabIndex = 49;
            this.lbl_detalles.Text = "Detalles de service";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(614, 584);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 51;
            this.btn_exit.Text = "Salir";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_total_dolar
            // 
            this.lbl_total_dolar.AutoSize = true;
            this.lbl_total_dolar.Location = new System.Drawing.Point(661, 388);
            this.lbl_total_dolar.Name = "lbl_total_dolar";
            this.lbl_total_dolar.Size = new System.Drawing.Size(28, 13);
            this.lbl_total_dolar.TabIndex = 55;
            this.lbl_total_dolar.Text = "US$";
            // 
            // txt_total_dolar
            // 
            this.txt_total_dolar.Location = new System.Drawing.Point(559, 365);
            this.txt_total_dolar.Name = "txt_total_dolar";
            this.txt_total_dolar.ReadOnly = true;
            this.txt_total_dolar.Size = new System.Drawing.Size(130, 20);
            this.txt_total_dolar.TabIndex = 54;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(519, 368);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(34, 13);
            this.lbl_total.TabIndex = 52;
            this.lbl_total.Text = "Total:";
            // 
            // col_nro_orden
            // 
            this.col_nro_orden.HeaderText = "N° ";
            this.col_nro_orden.Name = "col_nro_orden";
            this.col_nro_orden.ReadOnly = true;
            // 
            // col_trabajo
            // 
            this.col_trabajo.HeaderText = "Trabajo";
            this.col_trabajo.Name = "col_trabajo";
            this.col_trabajo.ReadOnly = true;
            this.col_trabajo.Width = 250;
            // 
            // col_precio_dolar
            // 
            this.col_precio_dolar.HeaderText = "Precio US$";
            this.col_precio_dolar.Name = "col_precio_dolar";
            this.col_precio_dolar.ReadOnly = true;
            this.col_precio_dolar.Width = 250;
            // 
            // tareas
            // 
            this.tareas.HeaderText = "Column1";
            this.tareas.Name = "tareas";
            this.tareas.ReadOnly = true;
            this.tareas.Visible = false;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Column1";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AgenciaDeAutos.Properties.Resources.icons8_retro_car_48px_1;
            this.pictureBox1.InitialImage = global::AgenciaDeAutos.Properties.Resources.icons8_retro_car_48px_1;
            this.pictureBox1.Location = new System.Drawing.Point(19, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // frm_detalle_pv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 615);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_total_dolar);
            this.Controls.Add(this.txt_total_dolar);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lbl_detalles);
            this.Controls.Add(this.dgv_detalles);
            this.Controls.Add(this.txt_km_limite);
            this.Controls.Add(this.lbl_km_limite);
            this.Controls.Add(this.lbl_vehiculo);
            this.Controls.Add(this.lbl_detalles_services);
            this.Controls.Add(this.txt_detalles_realizados);
            this.Controls.Add(this.lbl_descripcion_trabajos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_tareas_trabajos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_detalle_pv";
            this.Text = "Detalles";
            this.Load += new System.EventHandler(this.frm_detalle_pv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_km_limite;
        private System.Windows.Forms.Label lbl_km_limite;
        private System.Windows.Forms.Label lbl_vehiculo;
        private System.Windows.Forms.Label lbl_detalles_services;
        private System.Windows.Forms.TextBox txt_detalles_realizados;
        private System.Windows.Forms.Label lbl_descripcion_trabajos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tareas_trabajos;
        private System.Windows.Forms.DataGridView dgv_detalles;
        private System.Windows.Forms.Label lbl_detalles;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_total_dolar;
        private System.Windows.Forms.TextBox txt_total_dolar;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nro_orden;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_trabajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_precio_dolar;
        private System.Windows.Forms.DataGridViewTextBoxColumn tareas;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}