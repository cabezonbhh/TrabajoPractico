namespace AgenciaDeAutos.GUI.Otros
{
    partial class frm_main_admin
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
            this.dgv_usuarios = new System.Windows.Forms.DataGridView();
            this.col_id_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_contraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_perfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lbl_userOn = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_new_user = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_main = new System.Windows.Forms.Button();
            this.btn_gerencial = new System.Windows.Forms.Button();
            this.btn_cliente = new System.Windows.Forms.Button();
            this.pic_user_on = new System.Windows.Forms.PictureBox();
            this.btn_unid = new System.Windows.Forms.Button();
            this.dgv_stock_unidades = new System.Windows.Forms.DataGridView();
            this.col_id_unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_añoModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_generacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_edit_uni = new System.Windows.Forms.Button();
            this.btn_delete_uni = new System.Windows.Forms.Button();
            this.txt_filter_name = new System.Windows.Forms.TextBox();
            this.lbl_name_uni = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_user_on)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stock_unidades)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_usuarios
            // 
            this.dgv_usuarios.AllowUserToAddRows = false;
            this.dgv_usuarios.AllowUserToDeleteRows = false;
            this.dgv_usuarios.AllowUserToOrderColumns = true;
            this.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id_usuario,
            this.col_nombre,
            this.col_contraseña,
            this.col_perfil});
            this.dgv_usuarios.Location = new System.Drawing.Point(216, 19);
            this.dgv_usuarios.Name = "dgv_usuarios";
            this.dgv_usuarios.ReadOnly = true;
            this.dgv_usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_usuarios.Size = new System.Drawing.Size(445, 206);
            this.dgv_usuarios.TabIndex = 0;
            this.dgv_usuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_usuarios_CellClick);
            // 
            // col_id_usuario
            // 
            this.col_id_usuario.HeaderText = "#Usuario";
            this.col_id_usuario.Name = "col_id_usuario";
            this.col_id_usuario.ReadOnly = true;
            this.col_id_usuario.Visible = false;
            // 
            // col_nombre
            // 
            this.col_nombre.HeaderText = "Nombre";
            this.col_nombre.Name = "col_nombre";
            this.col_nombre.ReadOnly = true;
            // 
            // col_contraseña
            // 
            this.col_contraseña.HeaderText = "Contraseña";
            this.col_contraseña.Name = "col_contraseña";
            this.col_contraseña.ReadOnly = true;
            // 
            // col_perfil
            // 
            this.col_perfil.HeaderText = "Perfil";
            this.col_perfil.Name = "col_perfil";
            this.col_perfil.ReadOnly = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(135, 77);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "Eliminar";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // lbl_userOn
            // 
            this.lbl_userOn.AutoSize = true;
            this.lbl_userOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userOn.Location = new System.Drawing.Point(69, 31);
            this.lbl_userOn.Name = "lbl_userOn";
            this.lbl_userOn.Size = new System.Drawing.Size(138, 20);
            this.lbl_userOn.TabIndex = 2;
            this.lbl_userOn.Text = "Usuario logueado:";
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(135, 48);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 3;
            this.btn_edit.Text = "Editar";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_new_user
            // 
            this.btn_new_user.Location = new System.Drawing.Point(135, 19);
            this.btn_new_user.Name = "btn_new_user";
            this.btn_new_user.Size = new System.Drawing.Size(75, 23);
            this.btn_new_user.TabIndex = 4;
            this.btn_new_user.Text = "Nuevo";
            this.btn_new_user.UseVisualStyleBackColor = true;
            this.btn_new_user.Click += new System.EventHandler(this.btn_new_user_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_new_user);
            this.groupBox1.Controls.Add(this.dgv_usuarios);
            this.groupBox1.Controls.Add(this.btn_edit);
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Location = new System.Drawing.Point(12, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(763, 250);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuarios";
            // 
            // btn_main
            // 
            this.btn_main.Location = new System.Drawing.Point(413, 21);
            this.btn_main.Name = "btn_main";
            this.btn_main.Size = new System.Drawing.Size(75, 40);
            this.btn_main.TabIndex = 6;
            this.btn_main.Text = "Menu Principal";
            this.btn_main.UseVisualStyleBackColor = true;
            this.btn_main.Click += new System.EventHandler(this.btn_main_Click);
            // 
            // btn_gerencial
            // 
            this.btn_gerencial.Location = new System.Drawing.Point(505, 21);
            this.btn_gerencial.Name = "btn_gerencial";
            this.btn_gerencial.Size = new System.Drawing.Size(75, 40);
            this.btn_gerencial.TabIndex = 7;
            this.btn_gerencial.Text = "Menu gerencial";
            this.btn_gerencial.UseVisualStyleBackColor = true;
            this.btn_gerencial.Click += new System.EventHandler(this.btn_gerencial_Click);
            // 
            // btn_cliente
            // 
            this.btn_cliente.Location = new System.Drawing.Point(597, 21);
            this.btn_cliente.Name = "btn_cliente";
            this.btn_cliente.Size = new System.Drawing.Size(75, 40);
            this.btn_cliente.TabIndex = 8;
            this.btn_cliente.Text = "Menu Clientes";
            this.btn_cliente.UseVisualStyleBackColor = true;
            this.btn_cliente.Click += new System.EventHandler(this.btn_cliente_Click);
            // 
            // pic_user_on
            // 
            this.pic_user_on.Image = global::AgenciaDeAutos.Properties.Resources.icons8_online_48px_3;
            this.pic_user_on.Location = new System.Drawing.Point(15, 21);
            this.pic_user_on.Name = "pic_user_on";
            this.pic_user_on.Size = new System.Drawing.Size(48, 48);
            this.pic_user_on.TabIndex = 9;
            this.pic_user_on.TabStop = false;
            // 
            // btn_unid
            // 
            this.btn_unid.Location = new System.Drawing.Point(61, 415);
            this.btn_unid.Name = "btn_unid";
            this.btn_unid.Size = new System.Drawing.Size(75, 40);
            this.btn_unid.TabIndex = 10;
            this.btn_unid.Text = "Nueva unidad";
            this.btn_unid.UseVisualStyleBackColor = true;
            this.btn_unid.Click += new System.EventHandler(this.btn_unid_Click);
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
            this.dgv_stock_unidades.Location = new System.Drawing.Point(142, 341);
            this.dgv_stock_unidades.Name = "dgv_stock_unidades";
            this.dgv_stock_unidades.ReadOnly = true;
            this.dgv_stock_unidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_stock_unidades.Size = new System.Drawing.Size(633, 315);
            this.dgv_stock_unidades.TabIndex = 35;
            this.dgv_stock_unidades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_stock_unidades_CellContentClick);
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
            // btn_edit_uni
            // 
            this.btn_edit_uni.Location = new System.Drawing.Point(61, 461);
            this.btn_edit_uni.Name = "btn_edit_uni";
            this.btn_edit_uni.Size = new System.Drawing.Size(75, 40);
            this.btn_edit_uni.TabIndex = 36;
            this.btn_edit_uni.Text = "Editar unidad";
            this.btn_edit_uni.UseVisualStyleBackColor = true;
            // 
            // btn_delete_uni
            // 
            this.btn_delete_uni.Location = new System.Drawing.Point(61, 507);
            this.btn_delete_uni.Name = "btn_delete_uni";
            this.btn_delete_uni.Size = new System.Drawing.Size(75, 40);
            this.btn_delete_uni.TabIndex = 37;
            this.btn_delete_uni.Text = "Borrar unidad";
            this.btn_delete_uni.UseVisualStyleBackColor = true;
            // 
            // txt_filter_name
            // 
            this.txt_filter_name.Location = new System.Drawing.Point(36, 363);
            this.txt_filter_name.Name = "txt_filter_name";
            this.txt_filter_name.Size = new System.Drawing.Size(100, 20);
            this.txt_filter_name.TabIndex = 38;
            this.txt_filter_name.TextChanged += new System.EventHandler(this.txt_filter_name_TextChanged);
            // 
            // lbl_name_uni
            // 
            this.lbl_name_uni.AutoSize = true;
            this.lbl_name_uni.Location = new System.Drawing.Point(33, 347);
            this.lbl_name_uni.Name = "lbl_name_uni";
            this.lbl_name_uni.Size = new System.Drawing.Size(42, 13);
            this.lbl_name_uni.TabIndex = 39;
            this.lbl_name_uni.Text = "Modelo";
            // 
            // frm_main_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(790, 699);
            this.Controls.Add(this.lbl_name_uni);
            this.Controls.Add(this.txt_filter_name);
            this.Controls.Add(this.btn_delete_uni);
            this.Controls.Add(this.btn_edit_uni);
            this.Controls.Add(this.dgv_stock_unidades);
            this.Controls.Add(this.btn_unid);
            this.Controls.Add(this.pic_user_on);
            this.Controls.Add(this.btn_cliente);
            this.Controls.Add(this.btn_gerencial);
            this.Controls.Add(this.btn_main);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_userOn);
            this.MaximizeBox = false;
            this.Name = "frm_main_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_main_admin";
            this.Load += new System.EventHandler(this.frm_main_admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_user_on)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stock_unidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_usuarios;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lbl_userOn;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_new_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_contraseña;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_perfil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_main;
        private System.Windows.Forms.Button btn_gerencial;
        private System.Windows.Forms.Button btn_cliente;
        private System.Windows.Forms.PictureBox pic_user_on;
        private System.Windows.Forms.Button btn_unid;
        private System.Windows.Forms.DataGridView dgv_stock_unidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id_unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fabricante;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_añoModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_generacion;
        private System.Windows.Forms.Button btn_edit_uni;
        private System.Windows.Forms.Button btn_delete_uni;
        private System.Windows.Forms.TextBox txt_filter_name;
        private System.Windows.Forms.Label lbl_name_uni;
    }
}