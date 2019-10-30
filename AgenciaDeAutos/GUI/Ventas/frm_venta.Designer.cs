namespace AgenciaDeAutos.GUI.Ventas
{
    partial class frm_venta
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
            this.lbl_dni = new System.Windows.Forms.Label();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.lbl_name_cliente = new System.Windows.Forms.Label();
            this.lbl_last_name_cliente = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.dgv_details = new System.Windows.Forms.DataGridView();
            this.col_id_unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_añoModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_generacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_precio2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_total_peso = new System.Windows.Forms.TextBox();
            this.lbl_total_peso = new System.Windows.Forms.Label();
            this.lbl_total_dolar = new System.Windows.Forms.Label();
            this.txt_total_dolar = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lbl_cotizacion = new System.Windows.Forms.Label();
            this.txt_cotizacion = new System.Windows.Forms.TextBox();
            this.btn_new_venta = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.dtp_fechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.lbl_fecha_entrega = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_details)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.Location = new System.Drawing.Point(41, 45);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(26, 13);
            this.lbl_dni.TabIndex = 0;
            this.lbl_dni.Text = "DNI";
            // 
            // txt_dni
            // 
            this.txt_dni.Location = new System.Drawing.Point(73, 42);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(100, 20);
            this.txt_dni.TabIndex = 1;
            this.txt_dni.TextChanged += new System.EventHandler(this.txt_dni_TextChanged);
            // 
            // lbl_name_cliente
            // 
            this.lbl_name_cliente.AutoSize = true;
            this.lbl_name_cliente.Location = new System.Drawing.Point(209, 45);
            this.lbl_name_cliente.Name = "lbl_name_cliente";
            this.lbl_name_cliente.Size = new System.Drawing.Size(47, 13);
            this.lbl_name_cliente.TabIndex = 2;
            this.lbl_name_cliente.Text = "Nombre:";
            // 
            // lbl_last_name_cliente
            // 
            this.lbl_last_name_cliente.AutoSize = true;
            this.lbl_last_name_cliente.Location = new System.Drawing.Point(446, 45);
            this.lbl_last_name_cliente.Name = "lbl_last_name_cliente";
            this.lbl_last_name_cliente.Size = new System.Drawing.Size(47, 13);
            this.lbl_last_name_cliente.TabIndex = 3;
            this.lbl_last_name_cliente.Text = "Apellido:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(262, 42);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(178, 20);
            this.txt_name.TabIndex = 4;
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(499, 42);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(178, 20);
            this.txt_lastName.TabIndex = 5;
            // 
            // dgv_details
            // 
            this.dgv_details.AllowUserToAddRows = false;
            this.dgv_details.AllowUserToDeleteRows = false;
            this.dgv_details.AllowUserToOrderColumns = true;
            this.dgv_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id_unidad,
            this.col_fabricante,
            this.col_modelo,
            this.col_añoModelo,
            this.col_generacion,
            this.col_precio,
            this.col_precio2});
            this.dgv_details.Location = new System.Drawing.Point(44, 111);
            this.dgv_details.Name = "dgv_details";
            this.dgv_details.ReadOnly = true;
            this.dgv_details.Size = new System.Drawing.Size(633, 208);
            this.dgv_details.TabIndex = 6;
            // 
            // col_id_unidad
            // 
            this.col_id_unidad.HeaderText = "NºUnidad";
            this.col_id_unidad.Name = "col_id_unidad";
            this.col_id_unidad.ReadOnly = true;
            this.col_id_unidad.Visible = false;
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
            // col_precio
            // 
            this.col_precio.HeaderText = "Precio (US$)";
            this.col_precio.Name = "col_precio";
            this.col_precio.ReadOnly = true;
            // 
            // col_precio2
            // 
            this.col_precio2.HeaderText = "Precio(AR$)";
            this.col_precio2.Name = "col_precio2";
            this.col_precio2.ReadOnly = true;
            // 
            // txt_total_peso
            // 
            this.txt_total_peso.Location = new System.Drawing.Point(577, 410);
            this.txt_total_peso.Name = "txt_total_peso";
            this.txt_total_peso.Size = new System.Drawing.Size(100, 20);
            this.txt_total_peso.TabIndex = 7;
            // 
            // lbl_total_peso
            // 
            this.lbl_total_peso.AutoSize = true;
            this.lbl_total_peso.Location = new System.Drawing.Point(510, 413);
            this.lbl_total_peso.Name = "lbl_total_peso";
            this.lbl_total_peso.Size = new System.Drawing.Size(61, 13);
            this.lbl_total_peso.TabIndex = 8;
            this.lbl_total_peso.Text = "AR$ Total: ";
            // 
            // lbl_total_dolar
            // 
            this.lbl_total_dolar.AutoSize = true;
            this.lbl_total_dolar.Location = new System.Drawing.Point(510, 460);
            this.lbl_total_dolar.Name = "lbl_total_dolar";
            this.lbl_total_dolar.Size = new System.Drawing.Size(61, 13);
            this.lbl_total_dolar.TabIndex = 9;
            this.lbl_total_dolar.Text = "US$ Total: ";
            // 
            // txt_total_dolar
            // 
            this.txt_total_dolar.Location = new System.Drawing.Point(577, 460);
            this.txt_total_dolar.Name = "txt_total_dolar";
            this.txt_total_dolar.Size = new System.Drawing.Size(100, 20);
            this.txt_total_dolar.TabIndex = 10;
            // 
            // btn_delete
            // 
            this.btn_delete.Enabled = false;
            this.btn_delete.Location = new System.Drawing.Point(44, 344);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.Text = "quitar";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // lbl_cotizacion
            // 
            this.lbl_cotizacion.AutoSize = true;
            this.lbl_cotizacion.Location = new System.Drawing.Point(512, 365);
            this.lbl_cotizacion.Name = "lbl_cotizacion";
            this.lbl_cotizacion.Size = new System.Drawing.Size(59, 13);
            this.lbl_cotizacion.TabIndex = 13;
            this.lbl_cotizacion.Text = "Cotizacion:";
            // 
            // txt_cotizacion
            // 
            this.txt_cotizacion.Enabled = false;
            this.txt_cotizacion.Location = new System.Drawing.Point(577, 362);
            this.txt_cotizacion.Name = "txt_cotizacion";
            this.txt_cotizacion.Size = new System.Drawing.Size(100, 20);
            this.txt_cotizacion.TabIndex = 12;
            // 
            // btn_new_venta
            // 
            this.btn_new_venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new_venta.ForeColor = System.Drawing.Color.Blue;
            this.btn_new_venta.Location = new System.Drawing.Point(472, 506);
            this.btn_new_venta.Name = "btn_new_venta";
            this.btn_new_venta.Size = new System.Drawing.Size(89, 23);
            this.btn_new_venta.TabIndex = 14;
            this.btn_new_venta.Text = "Confirmar";
            this.btn_new_venta.UseVisualStyleBackColor = true;
            this.btn_new_venta.Click += new System.EventHandler(this.btn_new_venta_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(588, 506);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(89, 23);
            this.btn_salir.TabIndex = 15;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            // 
            // dtp_fechaEntrega
            // 
            this.dtp_fechaEntrega.Location = new System.Drawing.Point(262, 362);
            this.dtp_fechaEntrega.Name = "dtp_fechaEntrega";
            this.dtp_fechaEntrega.Size = new System.Drawing.Size(200, 20);
            this.dtp_fechaEntrega.TabIndex = 16;
            // 
            // lbl_fecha_entrega
            // 
            this.lbl_fecha_entrega.AutoSize = true;
            this.lbl_fecha_entrega.Location = new System.Drawing.Point(180, 365);
            this.lbl_fecha_entrega.Name = "lbl_fecha_entrega";
            this.lbl_fecha_entrega.Size = new System.Drawing.Size(76, 13);
            this.lbl_fecha_entrega.TabIndex = 17;
            this.lbl_fecha_entrega.Text = "fecha entrega:";
            // 
            // frm_venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 557);
            this.Controls.Add(this.lbl_fecha_entrega);
            this.Controls.Add(this.dtp_fechaEntrega);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_new_venta);
            this.Controls.Add(this.lbl_cotizacion);
            this.Controls.Add(this.txt_cotizacion);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.txt_total_dolar);
            this.Controls.Add(this.lbl_total_dolar);
            this.Controls.Add(this.lbl_total_peso);
            this.Controls.Add(this.txt_total_peso);
            this.Controls.Add(this.dgv_details);
            this.Controls.Add(this.txt_lastName);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_last_name_cliente);
            this.Controls.Add(this.lbl_name_cliente);
            this.Controls.Add(this.txt_dni);
            this.Controls.Add(this.lbl_dni);
            this.Name = "frm_venta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_venta";
            this.Load += new System.EventHandler(this.frm_venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_details)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_dni;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.Label lbl_name_cliente;
        private System.Windows.Forms.Label lbl_last_name_cliente;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.DataGridView dgv_details;
        private System.Windows.Forms.TextBox txt_total_peso;
        private System.Windows.Forms.Label lbl_total_peso;
        private System.Windows.Forms.Label lbl_total_dolar;
        private System.Windows.Forms.TextBox txt_total_dolar;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lbl_cotizacion;
        private System.Windows.Forms.TextBox txt_cotizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id_unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fabricante;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_añoModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_generacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_precio2;
        private System.Windows.Forms.Button btn_new_venta;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.DateTimePicker dtp_fechaEntrega;
        private System.Windows.Forms.Label lbl_fecha_entrega;
    }
}