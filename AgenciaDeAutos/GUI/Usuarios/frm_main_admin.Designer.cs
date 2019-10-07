﻿namespace AgenciaDeAutos.GUI.Otros
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_user_on)).BeginInit();
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
            this.groupBox1.Location = new System.Drawing.Point(15, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(763, 250);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuarios";
            // 
            // btn_main
            // 
            this.btn_main.Location = new System.Drawing.Point(419, 21);
            this.btn_main.Name = "btn_main";
            this.btn_main.Size = new System.Drawing.Size(75, 40);
            this.btn_main.TabIndex = 6;
            this.btn_main.Text = "Menu Principal";
            this.btn_main.UseVisualStyleBackColor = true;
            this.btn_main.Click += new System.EventHandler(this.btn_main_Click);
            // 
            // btn_gerencial
            // 
            this.btn_gerencial.Location = new System.Drawing.Point(509, 21);
            this.btn_gerencial.Name = "btn_gerencial";
            this.btn_gerencial.Size = new System.Drawing.Size(75, 40);
            this.btn_gerencial.TabIndex = 7;
            this.btn_gerencial.Text = "Menu gerencial";
            this.btn_gerencial.UseVisualStyleBackColor = true;
            this.btn_gerencial.Click += new System.EventHandler(this.btn_gerencial_Click);
            // 
            // btn_cliente
            // 
            this.btn_cliente.Location = new System.Drawing.Point(601, 21);
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
            // frm_main_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(790, 699);
            this.Controls.Add(this.pic_user_on);
            this.Controls.Add(this.btn_cliente);
            this.Controls.Add(this.btn_gerencial);
            this.Controls.Add(this.btn_main);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_userOn);
            this.MaximizeBox = false;
            this.Name = "frm_main_admin";
            this.Text = "frm_main_admin";
            this.Load += new System.EventHandler(this.frm_main_admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_user_on)).EndInit();
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
    }
}