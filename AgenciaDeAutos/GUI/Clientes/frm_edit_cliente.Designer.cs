﻿namespace AgenciaDeAutos.GUI.Clientes
{
    partial class frm_edit_cliente
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.txt_mobile = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_nro = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.lbl_mobile = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lbl_nro = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_lastName = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(72, 305);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(463, 269);
            this.dataGridView1.TabIndex = 49;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(72, 580);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 48;
            this.btn_save.Text = "Guardar";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(460, 580);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 47;
            this.btn_exit.Text = "Salir";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // txt_mobile
            // 
            this.txt_mobile.Location = new System.Drawing.Point(72, 235);
            this.txt_mobile.MaxLength = 10;
            this.txt_mobile.Name = "txt_mobile";
            this.txt_mobile.Size = new System.Drawing.Size(181, 20);
            this.txt_mobile.TabIndex = 46;
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(72, 203);
            this.txt_phone.MaxLength = 10;
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(181, 20);
            this.txt_phone.TabIndex = 45;
            // 
            // txt_nro
            // 
            this.txt_nro.Location = new System.Drawing.Point(72, 166);
            this.txt_nro.MaxLength = 6;
            this.txt_nro.Name = "txt_nro";
            this.txt_nro.Size = new System.Drawing.Size(104, 20);
            this.txt_nro.TabIndex = 44;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(74, 131);
            this.txt_address.MaxLength = 50;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(461, 20);
            this.txt_address.TabIndex = 43;
            // 
            // txt_dni
            // 
            this.txt_dni.Location = new System.Drawing.Point(74, 101);
            this.txt_dni.MaxLength = 12;
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(102, 20);
            this.txt_dni.TabIndex = 42;
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(74, 69);
            this.txt_lastName.MaxLength = 30;
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(181, 20);
            this.txt_lastName.TabIndex = 41;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(74, 39);
            this.txt_name.MaxLength = 30;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(181, 20);
            this.txt_name.TabIndex = 40;
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.Location = new System.Drawing.Point(39, 104);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(29, 13);
            this.lbl_dni.TabIndex = 39;
            this.lbl_dni.Text = "DNI:";
            // 
            // lbl_mobile
            // 
            this.lbl_mobile.AutoSize = true;
            this.lbl_mobile.Location = new System.Drawing.Point(26, 238);
            this.lbl_mobile.Name = "lbl_mobile";
            this.lbl_mobile.Size = new System.Drawing.Size(42, 13);
            this.lbl_mobile.TabIndex = 38;
            this.lbl_mobile.Text = "Celular:";
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Location = new System.Drawing.Point(16, 206);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(52, 13);
            this.lbl_phone.TabIndex = 37;
            this.lbl_phone.Text = "Telefono:";
            // 
            // lbl_nro
            // 
            this.lbl_nro.AutoSize = true;
            this.lbl_nro.Location = new System.Drawing.Point(39, 169);
            this.lbl_nro.Name = "lbl_nro";
            this.lbl_nro.Size = new System.Drawing.Size(27, 13);
            this.lbl_nro.TabIndex = 36;
            this.lbl_nro.Text = "Nro:";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(13, 134);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(55, 13);
            this.lbl_address.TabIndex = 35;
            this.lbl_address.Text = "Direccion:";
            // 
            // lbl_lastName
            // 
            this.lbl_lastName.AutoSize = true;
            this.lbl_lastName.Location = new System.Drawing.Point(21, 72);
            this.lbl_lastName.Name = "lbl_lastName";
            this.lbl_lastName.Size = new System.Drawing.Size(47, 13);
            this.lbl_lastName.TabIndex = 34;
            this.lbl_lastName.Text = "Apellido:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(21, 42);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(47, 13);
            this.lbl_name.TabIndex = 33;
            this.lbl_name.Text = "Nombre:";
            // 
            // frm_edit_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 682);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.txt_mobile);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txt_nro);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_dni);
            this.Controls.Add(this.txt_lastName);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_dni);
            this.Controls.Add(this.lbl_mobile);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.lbl_nro);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.lbl_lastName);
            this.Controls.Add(this.lbl_name);
            this.Name = "frm_edit_cliente";
            this.Text = "frm_edit_cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TextBox txt_mobile;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_nro;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_dni;
        private System.Windows.Forms.Label lbl_mobile;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Label lbl_nro;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_lastName;
        private System.Windows.Forms.Label lbl_name;
    }
}