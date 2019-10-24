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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_name_cliente = new System.Windows.Forms.Label();
            this.lbl_last_name_cliente = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_details)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
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
            this.lbl_last_name_cliente.Location = new System.Drawing.Point(392, 45);
            this.lbl_last_name_cliente.Name = "lbl_last_name_cliente";
            this.lbl_last_name_cliente.Size = new System.Drawing.Size(47, 13);
            this.lbl_last_name_cliente.TabIndex = 3;
            this.lbl_last_name_cliente.Text = "Apellido:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(262, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(445, 42);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
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
            this.txt_total_peso.Location = new System.Drawing.Point(577, 347);
            this.txt_total_peso.Name = "txt_total_peso";
            this.txt_total_peso.Size = new System.Drawing.Size(100, 20);
            this.txt_total_peso.TabIndex = 7;
            // 
            // lbl_total_peso
            // 
            this.lbl_total_peso.AutoSize = true;
            this.lbl_total_peso.Location = new System.Drawing.Point(510, 350);
            this.lbl_total_peso.Name = "lbl_total_peso";
            this.lbl_total_peso.Size = new System.Drawing.Size(61, 13);
            this.lbl_total_peso.TabIndex = 8;
            this.lbl_total_peso.Text = "AR$ Total: ";
            // 
            // lbl_total_dolar
            // 
            this.lbl_total_dolar.AutoSize = true;
            this.lbl_total_dolar.Location = new System.Drawing.Point(510, 397);
            this.lbl_total_dolar.Name = "lbl_total_dolar";
            this.lbl_total_dolar.Size = new System.Drawing.Size(61, 13);
            this.lbl_total_dolar.TabIndex = 9;
            this.lbl_total_dolar.Text = "US$ Total: ";
            // 
            // txt_total_dolar
            // 
            this.txt_total_dolar.Location = new System.Drawing.Point(577, 397);
            this.txt_total_dolar.Name = "txt_total_dolar";
            this.txt_total_dolar.Size = new System.Drawing.Size(100, 20);
            this.txt_total_dolar.TabIndex = 10;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(44, 339);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.Text = "quitar";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // lbl_cotizacion
            // 
            this.lbl_cotizacion.AutoSize = true;
            this.lbl_cotizacion.Location = new System.Drawing.Point(328, 400);
            this.lbl_cotizacion.Name = "lbl_cotizacion";
            this.lbl_cotizacion.Size = new System.Drawing.Size(56, 13);
            this.lbl_cotizacion.TabIndex = 13;
            this.lbl_cotizacion.Text = "Cotizacion";
            // 
            // txt_cotizacion
            // 
            this.txt_cotizacion.Location = new System.Drawing.Point(395, 397);
            this.txt_cotizacion.Name = "txt_cotizacion";
            this.txt_cotizacion.Size = new System.Drawing.Size(100, 20);
            this.txt_cotizacion.TabIndex = 12;
            // 
            // btn_new_venta
            // 
            this.btn_new_venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new_venta.ForeColor = System.Drawing.Color.Blue;
            this.btn_new_venta.Location = new System.Drawing.Point(472, 462);
            this.btn_new_venta.Name = "btn_new_venta";
            this.btn_new_venta.Size = new System.Drawing.Size(89, 23);
            this.btn_new_venta.TabIndex = 14;
            this.btn_new_venta.Text = "Confirmar";
            this.btn_new_venta.UseVisualStyleBackColor = true;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(588, 462);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(89, 23);
            this.btn_salir.TabIndex = 15;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            // 
            // frm_venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 528);
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
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbl_last_name_cliente);
            this.Controls.Add(this.lbl_name_cliente);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "frm_venta";
            this.Text = "frm_venta";
            this.Load += new System.EventHandler(this.frm_venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_details)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_name_cliente;
        private System.Windows.Forms.Label lbl_last_name_cliente;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
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
    }
}