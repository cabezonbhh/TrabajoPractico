namespace AgenciaDeAutos.GUI.PostVenta
{
    partial class frm_main_service
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
            this.tab_main = new System.Windows.Forms.TabControl();
            this.tab_cliente = new System.Windows.Forms.TabPage();
            this.dgv_post_service = new System.Windows.Forms.DataGridView();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_last_name_cliente = new System.Windows.Forms.Label();
            this.lbl_name_cliente = new System.Windows.Forms.Label();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.dgv_stock_unidades = new System.Windows.Forms.DataGridView();
            this.col_id_unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_generacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_añoModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_patente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_interno = new System.Windows.Forms.TabPage();
            this.id_service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.km_limite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_more_detail = new System.Windows.Forms.Button();
            this.btn_new_service = new System.Windows.Forms.Button();
            this.txt_patente = new System.Windows.Forms.TextBox();
            this.txt_modelo = new System.Windows.Forms.TextBox();
            this.lbl_patente = new System.Windows.Forms.Label();
            this.lbl_modelo = new System.Windows.Forms.Label();
            this.txt_unidad = new System.Windows.Forms.TextBox();
            this.lbl_cod_unidad = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_main.SuspendLayout();
            this.tab_cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_post_service)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stock_unidades)).BeginInit();
            this.tab_interno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_main
            // 
            this.tab_main.Controls.Add(this.tab_cliente);
            this.tab_main.Controls.Add(this.tab_interno);
            this.tab_main.Location = new System.Drawing.Point(12, 12);
            this.tab_main.Name = "tab_main";
            this.tab_main.SelectedIndex = 0;
            this.tab_main.Size = new System.Drawing.Size(779, 479);
            this.tab_main.TabIndex = 0;
            // 
            // tab_cliente
            // 
            this.tab_cliente.Controls.Add(this.btn_new_service);
            this.tab_cliente.Controls.Add(this.btn_more_detail);
            this.tab_cliente.Controls.Add(this.dgv_post_service);
            this.tab_cliente.Controls.Add(this.txt_lastName);
            this.tab_cliente.Controls.Add(this.txt_name);
            this.tab_cliente.Controls.Add(this.lbl_last_name_cliente);
            this.tab_cliente.Controls.Add(this.lbl_name_cliente);
            this.tab_cliente.Controls.Add(this.txt_dni);
            this.tab_cliente.Controls.Add(this.lbl_dni);
            this.tab_cliente.Controls.Add(this.dgv_stock_unidades);
            this.tab_cliente.Location = new System.Drawing.Point(4, 22);
            this.tab_cliente.Name = "tab_cliente";
            this.tab_cliente.Padding = new System.Windows.Forms.Padding(3);
            this.tab_cliente.Size = new System.Drawing.Size(771, 453);
            this.tab_cliente.TabIndex = 0;
            this.tab_cliente.Text = "Cliente";
            this.tab_cliente.UseVisualStyleBackColor = true;
            // 
            // dgv_post_service
            // 
            this.dgv_post_service.AllowUserToAddRows = false;
            this.dgv_post_service.AllowUserToDeleteRows = false;
            this.dgv_post_service.AllowUserToOrderColumns = true;
            this.dgv_post_service.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_post_service.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_service,
            this.precio_total,
            this.fecha_service,
            this.km_limite});
            this.dgv_post_service.Location = new System.Drawing.Point(61, 229);
            this.dgv_post_service.Name = "dgv_post_service";
            this.dgv_post_service.ReadOnly = true;
            this.dgv_post_service.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_post_service.RowHeadersWidth = 30;
            this.dgv_post_service.Size = new System.Drawing.Size(394, 150);
            this.dgv_post_service.TabIndex = 49;
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(516, 22);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(178, 20);
            this.txt_lastName.TabIndex = 48;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(250, 22);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(178, 20);
            this.txt_name.TabIndex = 47;
            // 
            // lbl_last_name_cliente
            // 
            this.lbl_last_name_cliente.AutoSize = true;
            this.lbl_last_name_cliente.Location = new System.Drawing.Point(434, 25);
            this.lbl_last_name_cliente.Name = "lbl_last_name_cliente";
            this.lbl_last_name_cliente.Size = new System.Drawing.Size(47, 13);
            this.lbl_last_name_cliente.TabIndex = 46;
            this.lbl_last_name_cliente.Text = "Apellido:";
            // 
            // lbl_name_cliente
            // 
            this.lbl_name_cliente.AutoSize = true;
            this.lbl_name_cliente.Location = new System.Drawing.Point(197, 25);
            this.lbl_name_cliente.Name = "lbl_name_cliente";
            this.lbl_name_cliente.Size = new System.Drawing.Size(47, 13);
            this.lbl_name_cliente.TabIndex = 45;
            this.lbl_name_cliente.Text = "Nombre:";
            // 
            // txt_dni
            // 
            this.txt_dni.Location = new System.Drawing.Point(61, 22);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(100, 20);
            this.txt_dni.TabIndex = 44;
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.Location = new System.Drawing.Point(29, 25);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(26, 13);
            this.lbl_dni.TabIndex = 43;
            this.lbl_dni.Text = "DNI";
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
            this.col_generacion,
            this.col_añoModelo,
            this.col_patente});
            this.dgv_stock_unidades.Location = new System.Drawing.Point(61, 65);
            this.dgv_stock_unidades.Name = "dgv_stock_unidades";
            this.dgv_stock_unidades.ReadOnly = true;
            this.dgv_stock_unidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_stock_unidades.Size = new System.Drawing.Size(633, 141);
            this.dgv_stock_unidades.TabIndex = 42;
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
            // col_generacion
            // 
            this.col_generacion.HeaderText = "Generacion";
            this.col_generacion.Name = "col_generacion";
            this.col_generacion.ReadOnly = true;
            // 
            // col_añoModelo
            // 
            this.col_añoModelo.HeaderText = "Año";
            this.col_añoModelo.Name = "col_añoModelo";
            this.col_añoModelo.ReadOnly = true;
            // 
            // col_patente
            // 
            this.col_patente.HeaderText = "Patente";
            this.col_patente.Name = "col_patente";
            this.col_patente.ReadOnly = true;
            // 
            // tab_interno
            // 
            this.tab_interno.Controls.Add(this.txt_patente);
            this.tab_interno.Controls.Add(this.txt_modelo);
            this.tab_interno.Controls.Add(this.lbl_patente);
            this.tab_interno.Controls.Add(this.lbl_modelo);
            this.tab_interno.Controls.Add(this.txt_unidad);
            this.tab_interno.Controls.Add(this.lbl_cod_unidad);
            this.tab_interno.Controls.Add(this.dataGridView1);
            this.tab_interno.Location = new System.Drawing.Point(4, 22);
            this.tab_interno.Name = "tab_interno";
            this.tab_interno.Padding = new System.Windows.Forms.Padding(3);
            this.tab_interno.Size = new System.Drawing.Size(771, 453);
            this.tab_interno.TabIndex = 1;
            this.tab_interno.Text = "Interno";
            this.tab_interno.UseVisualStyleBackColor = true;
            // 
            // id_service
            // 
            this.id_service.HeaderText = "Nº Service";
            this.id_service.Name = "id_service";
            this.id_service.ReadOnly = true;
            this.id_service.Visible = false;
            // 
            // precio_total
            // 
            this.precio_total.HeaderText = "Precio Total (US$)";
            this.precio_total.Name = "precio_total";
            this.precio_total.ReadOnly = true;
            // 
            // fecha_service
            // 
            this.fecha_service.HeaderText = "Fecha";
            this.fecha_service.Name = "fecha_service";
            this.fecha_service.ReadOnly = true;
            // 
            // km_limite
            // 
            this.km_limite.HeaderText = "Km limite";
            this.km_limite.Name = "km_limite";
            this.km_limite.ReadOnly = true;
            // 
            // btn_more_detail
            // 
            this.btn_more_detail.Enabled = false;
            this.btn_more_detail.Location = new System.Drawing.Point(477, 229);
            this.btn_more_detail.Name = "btn_more_detail";
            this.btn_more_detail.Size = new System.Drawing.Size(75, 37);
            this.btn_more_detail.TabIndex = 50;
            this.btn_more_detail.Text = "Mas detalles";
            this.btn_more_detail.UseVisualStyleBackColor = true;
            // 
            // btn_new_service
            // 
            this.btn_new_service.Enabled = false;
            this.btn_new_service.Location = new System.Drawing.Point(477, 286);
            this.btn_new_service.Name = "btn_new_service";
            this.btn_new_service.Size = new System.Drawing.Size(75, 38);
            this.btn_new_service.TabIndex = 51;
            this.btn_new_service.Text = "Nuevo service";
            this.btn_new_service.UseVisualStyleBackColor = true;
            // 
            // txt_patente
            // 
            this.txt_patente.Location = new System.Drawing.Point(594, 34);
            this.txt_patente.MaxLength = 7;
            this.txt_patente.Name = "txt_patente";
            this.txt_patente.Size = new System.Drawing.Size(100, 20);
            this.txt_patente.TabIndex = 55;
            // 
            // txt_modelo
            // 
            this.txt_modelo.Location = new System.Drawing.Point(321, 34);
            this.txt_modelo.MaxLength = 20;
            this.txt_modelo.Name = "txt_modelo";
            this.txt_modelo.Size = new System.Drawing.Size(133, 20);
            this.txt_modelo.TabIndex = 54;
            // 
            // lbl_patente
            // 
            this.lbl_patente.AutoSize = true;
            this.lbl_patente.Location = new System.Drawing.Point(541, 37);
            this.lbl_patente.Name = "lbl_patente";
            this.lbl_patente.Size = new System.Drawing.Size(47, 13);
            this.lbl_patente.TabIndex = 53;
            this.lbl_patente.Text = "Patente:";
            // 
            // lbl_modelo
            // 
            this.lbl_modelo.AutoSize = true;
            this.lbl_modelo.Location = new System.Drawing.Point(270, 37);
            this.lbl_modelo.Name = "lbl_modelo";
            this.lbl_modelo.Size = new System.Drawing.Size(45, 13);
            this.lbl_modelo.TabIndex = 52;
            this.lbl_modelo.Text = "Modelo:";
            // 
            // txt_unidad
            // 
            this.txt_unidad.Location = new System.Drawing.Point(111, 34);
            this.txt_unidad.MaxLength = 3;
            this.txt_unidad.Name = "txt_unidad";
            this.txt_unidad.Size = new System.Drawing.Size(100, 20);
            this.txt_unidad.TabIndex = 51;
            // 
            // lbl_cod_unidad
            // 
            this.lbl_cod_unidad.AutoSize = true;
            this.lbl_cod_unidad.Location = new System.Drawing.Point(49, 37);
            this.lbl_cod_unidad.Name = "lbl_cod_unidad";
            this.lbl_cod_unidad.Size = new System.Drawing.Size(59, 13);
            this.lbl_cod_unidad.TabIndex = 50;
            this.lbl_cod_unidad.Text = "Nº Unidad:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView1.Location = new System.Drawing.Point(52, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(642, 141);
            this.dataGridView1.TabIndex = 49;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "NºUnidad";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Fabricante";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Modelo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Generacion";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Año";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Patente";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // frm_main_service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 506);
            this.Controls.Add(this.tab_main);
            this.Name = "frm_main_service";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_main_service";
            this.tab_main.ResumeLayout(false);
            this.tab_cliente.ResumeLayout(false);
            this.tab_cliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_post_service)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stock_unidades)).EndInit();
            this.tab_interno.ResumeLayout(false);
            this.tab_interno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_main;
        private System.Windows.Forms.TabPage tab_cliente;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_last_name_cliente;
        private System.Windows.Forms.Label lbl_name_cliente;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.Label lbl_dni;
        private System.Windows.Forms.DataGridView dgv_stock_unidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id_unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fabricante;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_generacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_añoModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_patente;
        private System.Windows.Forms.TabPage tab_interno;
        private System.Windows.Forms.DataGridView dgv_post_service;
        private System.Windows.Forms.Button btn_new_service;
        private System.Windows.Forms.Button btn_more_detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_service;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_service;
        private System.Windows.Forms.DataGridViewTextBoxColumn km_limite;
        private System.Windows.Forms.TextBox txt_patente;
        private System.Windows.Forms.TextBox txt_modelo;
        private System.Windows.Forms.Label lbl_patente;
        private System.Windows.Forms.Label lbl_modelo;
        private System.Windows.Forms.TextBox txt_unidad;
        private System.Windows.Forms.Label lbl_cod_unidad;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}