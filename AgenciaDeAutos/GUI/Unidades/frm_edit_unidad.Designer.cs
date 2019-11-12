namespace AgenciaDeAutos.GUI.Unidades
{
    partial class frm_edit_unidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_edit_unidad));
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.txt_precio_compra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_cv = new System.Windows.Forms.Label();
            this.txt_potencia_cv = new System.Windows.Forms.TextBox();
            this.lbl_hp = new System.Windows.Forms.Label();
            this.txt_potencia_hp = new System.Windows.Forms.TextBox();
            this.txt_km = new System.Windows.Forms.TextBox();
            this.txt_año_modelo = new System.Windows.Forms.TextBox();
            this.lbl_potencia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_año = new System.Windows.Forms.Label();
            this.txt_precio_venta = new System.Windows.Forms.TextBox();
            this.lbl_precio_venta = new System.Windows.Forms.Label();
            this.lbl_patente = new System.Windows.Forms.Label();
            this.txt_patente = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(317, 366);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 33;
            this.btn_exit.Text = "Salir";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(209, 366);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(75, 23);
            this.btn_register.TabIndex = 32;
            this.btn_register.Text = "Guardar";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(9, 205);
            this.txt_descripcion.MaxLength = 1000;
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(383, 140);
            this.txt_descripcion.TabIndex = 31;
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Location = new System.Drawing.Point(6, 189);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(66, 13);
            this.lbl_descripcion.TabIndex = 37;
            this.lbl_descripcion.Text = "Descripcion:";
            // 
            // txt_precio_compra
            // 
            this.txt_precio_compra.Location = new System.Drawing.Point(288, 64);
            this.txt_precio_compra.MaxLength = 18;
            this.txt_precio_compra.Name = "txt_precio_compra";
            this.txt_precio_compra.Size = new System.Drawing.Size(104, 20);
            this.txt_precio_compra.TabIndex = 50;
            this.txt_precio_compra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio_compra_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Precio compra:";
            // 
            // lbl_cv
            // 
            this.lbl_cv.AutoSize = true;
            this.lbl_cv.Location = new System.Drawing.Point(285, 129);
            this.lbl_cv.Name = "lbl_cv";
            this.lbl_cv.Size = new System.Drawing.Size(21, 13);
            this.lbl_cv.TabIndex = 48;
            this.lbl_cv.Text = "CV";
            // 
            // txt_potencia_cv
            // 
            this.txt_potencia_cv.Location = new System.Drawing.Point(288, 106);
            this.txt_potencia_cv.MaxLength = 5;
            this.txt_potencia_cv.Name = "txt_potencia_cv";
            this.txt_potencia_cv.Size = new System.Drawing.Size(60, 20);
            this.txt_potencia_cv.TabIndex = 47;
            this.txt_potencia_cv.TextChanged += new System.EventHandler(this.txt_potencia_cv_TextChanged);
            this.txt_potencia_cv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_potencia_cv_KeyPress);
            // 
            // lbl_hp
            // 
            this.lbl_hp.AutoSize = true;
            this.lbl_hp.Location = new System.Drawing.Point(285, 173);
            this.lbl_hp.Name = "lbl_hp";
            this.lbl_hp.Size = new System.Drawing.Size(22, 13);
            this.lbl_hp.TabIndex = 46;
            this.lbl_hp.Text = "HP";
            // 
            // txt_potencia_hp
            // 
            this.txt_potencia_hp.Enabled = false;
            this.txt_potencia_hp.Location = new System.Drawing.Point(288, 150);
            this.txt_potencia_hp.MaxLength = 5;
            this.txt_potencia_hp.Name = "txt_potencia_hp";
            this.txt_potencia_hp.ReadOnly = true;
            this.txt_potencia_hp.Size = new System.Drawing.Size(60, 20);
            this.txt_potencia_hp.TabIndex = 45;
            // 
            // txt_km
            // 
            this.txt_km.Location = new System.Drawing.Point(68, 60);
            this.txt_km.MaxLength = 10;
            this.txt_km.Name = "txt_km";
            this.txt_km.Size = new System.Drawing.Size(104, 20);
            this.txt_km.TabIndex = 44;
            this.txt_km.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_km_KeyPress);
            // 
            // txt_año_modelo
            // 
            this.txt_año_modelo.Location = new System.Drawing.Point(68, 18);
            this.txt_año_modelo.MaxLength = 4;
            this.txt_año_modelo.Name = "txt_año_modelo";
            this.txt_año_modelo.Size = new System.Drawing.Size(60, 20);
            this.txt_año_modelo.TabIndex = 43;
            this.txt_año_modelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_año_modelo_KeyPress);
            // 
            // lbl_potencia
            // 
            this.lbl_potencia.AutoSize = true;
            this.lbl_potencia.Location = new System.Drawing.Point(229, 109);
            this.lbl_potencia.Name = "lbl_potencia";
            this.lbl_potencia.Size = new System.Drawing.Size(52, 13);
            this.lbl_potencia.TabIndex = 42;
            this.lbl_potencia.Text = "Potencia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Kilometros:";
            // 
            // lbl_año
            // 
            this.lbl_año.AutoSize = true;
            this.lbl_año.Location = new System.Drawing.Point(36, 21);
            this.lbl_año.Name = "lbl_año";
            this.lbl_año.Size = new System.Drawing.Size(29, 13);
            this.lbl_año.TabIndex = 40;
            this.lbl_año.Text = "Año:";
            // 
            // txt_precio_venta
            // 
            this.txt_precio_venta.Location = new System.Drawing.Point(288, 18);
            this.txt_precio_venta.MaxLength = 18;
            this.txt_precio_venta.Name = "txt_precio_venta";
            this.txt_precio_venta.Size = new System.Drawing.Size(104, 20);
            this.txt_precio_venta.TabIndex = 39;
            this.txt_precio_venta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio_venta_KeyPress);
            // 
            // lbl_precio_venta
            // 
            this.lbl_precio_venta.AutoSize = true;
            this.lbl_precio_venta.Location = new System.Drawing.Point(211, 21);
            this.lbl_precio_venta.Name = "lbl_precio_venta";
            this.lbl_precio_venta.Size = new System.Drawing.Size(70, 13);
            this.lbl_precio_venta.TabIndex = 38;
            this.lbl_precio_venta.Text = "Precio venta:";
            // 
            // lbl_patente
            // 
            this.lbl_patente.AutoSize = true;
            this.lbl_patente.Location = new System.Drawing.Point(17, 112);
            this.lbl_patente.Name = "lbl_patente";
            this.lbl_patente.Size = new System.Drawing.Size(47, 13);
            this.lbl_patente.TabIndex = 52;
            this.lbl_patente.Text = "Patente:";
            // 
            // txt_patente
            // 
            this.txt_patente.Location = new System.Drawing.Point(68, 109);
            this.txt_patente.MaxLength = 7;
            this.txt_patente.Name = "txt_patente";
            this.txt_patente.Size = new System.Drawing.Size(104, 20);
            this.txt_patente.TabIndex = 51;
            this.txt_patente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_patente_KeyPress);
            // 
            // frm_edit_unidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 398);
            this.Controls.Add(this.lbl_patente);
            this.Controls.Add(this.txt_patente);
            this.Controls.Add(this.txt_precio_compra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_cv);
            this.Controls.Add(this.txt_potencia_cv);
            this.Controls.Add(this.lbl_hp);
            this.Controls.Add(this.txt_potencia_hp);
            this.Controls.Add(this.txt_km);
            this.Controls.Add(this.txt_año_modelo);
            this.Controls.Add(this.lbl_potencia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_año);
            this.Controls.Add(this.txt_precio_venta);
            this.Controls.Add(this.lbl_precio_venta);
            this.Controls.Add(this.lbl_descripcion);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.txt_descripcion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_edit_unidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar unidad";
            this.Load += new System.EventHandler(this.frm_edit_unidad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.TextBox txt_precio_compra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_cv;
        private System.Windows.Forms.TextBox txt_potencia_cv;
        private System.Windows.Forms.Label lbl_hp;
        private System.Windows.Forms.TextBox txt_potencia_hp;
        private System.Windows.Forms.TextBox txt_km;
        private System.Windows.Forms.TextBox txt_año_modelo;
        private System.Windows.Forms.Label lbl_potencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_año;
        private System.Windows.Forms.TextBox txt_precio_venta;
        private System.Windows.Forms.Label lbl_precio_venta;
        private System.Windows.Forms.Label lbl_patente;
        private System.Windows.Forms.TextBox txt_patente;
    }
}