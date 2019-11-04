namespace AgenciaDeAutos.GUI.Unidades
{
    partial class frm_new_unidad
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
            this.combo_fab = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_serie = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_gen = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.combo_modelo = new System.Windows.Forms.ComboBox();
            this.lbl_precio_venta = new System.Windows.Forms.Label();
            this.txt_precio_venta = new System.Windows.Forms.TextBox();
            this.lbl_año = new System.Windows.Forms.Label();
            this.lbl_km = new System.Windows.Forms.Label();
            this.lbl_potencia = new System.Windows.Forms.Label();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.txt_año_modelo = new System.Windows.Forms.TextBox();
            this.txt_km = new System.Windows.Forms.TextBox();
            this.txt_potencia_hp = new System.Windows.Forms.TextBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_hp = new System.Windows.Forms.Label();
            this.txt_potencia_cv = new System.Windows.Forms.TextBox();
            this.lbl_cv = new System.Windows.Forms.Label();
            this.txt_patente = new System.Windows.Forms.TextBox();
            this.lbl_patente = new System.Windows.Forms.Label();
            this.check_edit = new System.Windows.Forms.CheckBox();
            this.txt_precio_compra = new System.Windows.Forms.TextBox();
            this.lbl_precio_compra = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // combo_fab
            // 
            this.combo_fab.FormattingEnabled = true;
            this.combo_fab.Location = new System.Drawing.Point(79, 27);
            this.combo_fab.Name = "combo_fab";
            this.combo_fab.Size = new System.Drawing.Size(162, 21);
            this.combo_fab.TabIndex = 0;
            this.combo_fab.SelectionChangeCommitted += new System.EventHandler(this.combo_fab_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fabricante:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Serie:";
            // 
            // combo_serie
            // 
            this.combo_serie.FormattingEnabled = true;
            this.combo_serie.Location = new System.Drawing.Point(79, 73);
            this.combo_serie.Name = "combo_serie";
            this.combo_serie.Size = new System.Drawing.Size(162, 21);
            this.combo_serie.TabIndex = 2;
            this.combo_serie.SelectionChangeCommitted += new System.EventHandler(this.combo_serie_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Generacion:";
            // 
            // combo_gen
            // 
            this.combo_gen.FormattingEnabled = true;
            this.combo_gen.Location = new System.Drawing.Point(79, 119);
            this.combo_gen.Name = "combo_gen";
            this.combo_gen.Size = new System.Drawing.Size(162, 21);
            this.combo_gen.TabIndex = 4;
            this.combo_gen.SelectionChangeCommitted += new System.EventHandler(this.combo_gen_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Modelo:";
            // 
            // combo_modelo
            // 
            this.combo_modelo.FormattingEnabled = true;
            this.combo_modelo.Location = new System.Drawing.Point(79, 164);
            this.combo_modelo.Name = "combo_modelo";
            this.combo_modelo.Size = new System.Drawing.Size(162, 21);
            this.combo_modelo.TabIndex = 7;
            // 
            // lbl_precio_venta
            // 
            this.lbl_precio_venta.AutoSize = true;
            this.lbl_precio_venta.Location = new System.Drawing.Point(281, 30);
            this.lbl_precio_venta.Name = "lbl_precio_venta";
            this.lbl_precio_venta.Size = new System.Drawing.Size(70, 13);
            this.lbl_precio_venta.TabIndex = 8;
            this.lbl_precio_venta.Text = "Precio venta:";
            // 
            // txt_precio_venta
            // 
            this.txt_precio_venta.Location = new System.Drawing.Point(358, 27);
            this.txt_precio_venta.MaxLength = 18;
            this.txt_precio_venta.Name = "txt_precio_venta";
            this.txt_precio_venta.Size = new System.Drawing.Size(104, 20);
            this.txt_precio_venta.TabIndex = 9;
            // 
            // lbl_año
            // 
            this.lbl_año.AutoSize = true;
            this.lbl_año.Location = new System.Drawing.Point(326, 122);
            this.lbl_año.Name = "lbl_año";
            this.lbl_año.Size = new System.Drawing.Size(29, 13);
            this.lbl_año.TabIndex = 10;
            this.lbl_año.Text = "Año:";
            // 
            // lbl_km
            // 
            this.lbl_km.AutoSize = true;
            this.lbl_km.Location = new System.Drawing.Point(297, 168);
            this.lbl_km.Name = "lbl_km";
            this.lbl_km.Size = new System.Drawing.Size(58, 13);
            this.lbl_km.TabIndex = 11;
            this.lbl_km.Text = "Kilometros:";
            // 
            // lbl_potencia
            // 
            this.lbl_potencia.AutoSize = true;
            this.lbl_potencia.Location = new System.Drawing.Point(303, 213);
            this.lbl_potencia.Name = "lbl_potencia";
            this.lbl_potencia.Size = new System.Drawing.Size(52, 13);
            this.lbl_potencia.TabIndex = 12;
            this.lbl_potencia.Text = "Potencia:";
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Location = new System.Drawing.Point(7, 326);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(66, 13);
            this.lbl_descripcion.TabIndex = 13;
            this.lbl_descripcion.Text = "Descripcion:";
            // 
            // txt_año_modelo
            // 
            this.txt_año_modelo.Location = new System.Drawing.Point(358, 119);
            this.txt_año_modelo.MaxLength = 4;
            this.txt_año_modelo.Name = "txt_año_modelo";
            this.txt_año_modelo.Size = new System.Drawing.Size(60, 20);
            this.txt_año_modelo.TabIndex = 14;
            // 
            // txt_km
            // 
            this.txt_km.Location = new System.Drawing.Point(358, 165);
            this.txt_km.MaxLength = 10;
            this.txt_km.Name = "txt_km";
            this.txt_km.Size = new System.Drawing.Size(104, 20);
            this.txt_km.TabIndex = 15;
            // 
            // txt_potencia_hp
            // 
            this.txt_potencia_hp.Enabled = false;
            this.txt_potencia_hp.Location = new System.Drawing.Point(358, 254);
            this.txt_potencia_hp.MaxLength = 5;
            this.txt_potencia_hp.Name = "txt_potencia_hp";
            this.txt_potencia_hp.Size = new System.Drawing.Size(60, 20);
            this.txt_potencia_hp.TabIndex = 16;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(79, 323);
            this.txt_descripcion.MaxLength = 1000;
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(383, 140);
            this.txt_descripcion.TabIndex = 17;
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(279, 484);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(75, 23);
            this.btn_register.TabIndex = 18;
            this.btn_register.Text = "Registrar";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(387, 484);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 19;
            this.btn_exit.Text = "Salir";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // lbl_hp
            // 
            this.lbl_hp.AutoSize = true;
            this.lbl_hp.Location = new System.Drawing.Point(355, 277);
            this.lbl_hp.Name = "lbl_hp";
            this.lbl_hp.Size = new System.Drawing.Size(22, 13);
            this.lbl_hp.TabIndex = 20;
            this.lbl_hp.Text = "HP";
            // 
            // txt_potencia_cv
            // 
            this.txt_potencia_cv.Location = new System.Drawing.Point(358, 210);
            this.txt_potencia_cv.MaxLength = 5;
            this.txt_potencia_cv.Name = "txt_potencia_cv";
            this.txt_potencia_cv.Size = new System.Drawing.Size(60, 20);
            this.txt_potencia_cv.TabIndex = 21;
            this.txt_potencia_cv.TextChanged += new System.EventHandler(this.txt_potencia_cv_TextChanged);
            // 
            // lbl_cv
            // 
            this.lbl_cv.AutoSize = true;
            this.lbl_cv.Location = new System.Drawing.Point(355, 233);
            this.lbl_cv.Name = "lbl_cv";
            this.lbl_cv.Size = new System.Drawing.Size(21, 13);
            this.lbl_cv.TabIndex = 22;
            this.lbl_cv.Text = "CV";
            // 
            // txt_patente
            // 
            this.txt_patente.Location = new System.Drawing.Point(79, 208);
            this.txt_patente.MaxLength = 7;
            this.txt_patente.Name = "txt_patente";
            this.txt_patente.Size = new System.Drawing.Size(104, 20);
            this.txt_patente.TabIndex = 23;
            // 
            // lbl_patente
            // 
            this.lbl_patente.AutoSize = true;
            this.lbl_patente.Location = new System.Drawing.Point(28, 211);
            this.lbl_patente.Name = "lbl_patente";
            this.lbl_patente.Size = new System.Drawing.Size(47, 13);
            this.lbl_patente.TabIndex = 24;
            this.lbl_patente.Text = "Patente:";
            // 
            // check_edit
            // 
            this.check_edit.AutoSize = true;
            this.check_edit.Location = new System.Drawing.Point(190, 210);
            this.check_edit.Name = "check_edit";
            this.check_edit.Size = new System.Drawing.Size(53, 17);
            this.check_edit.TabIndex = 25;
            this.check_edit.Text = "Editar";
            this.check_edit.UseVisualStyleBackColor = true;
            this.check_edit.CheckedChanged += new System.EventHandler(this.check_edit_CheckedChanged);
            // 
            // txt_precio_compra
            // 
            this.txt_precio_compra.Location = new System.Drawing.Point(358, 73);
            this.txt_precio_compra.MaxLength = 18;
            this.txt_precio_compra.Name = "txt_precio_compra";
            this.txt_precio_compra.Size = new System.Drawing.Size(104, 20);
            this.txt_precio_compra.TabIndex = 27;
            // 
            // lbl_precio_compra
            // 
            this.lbl_precio_compra.AutoSize = true;
            this.lbl_precio_compra.Location = new System.Drawing.Point(273, 76);
            this.lbl_precio_compra.Name = "lbl_precio_compra";
            this.lbl_precio_compra.Size = new System.Drawing.Size(78, 13);
            this.lbl_precio_compra.TabIndex = 26;
            this.lbl_precio_compra.Text = "Precio compra:";
            // 
            // frm_new_unidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 519);
            this.Controls.Add(this.txt_precio_compra);
            this.Controls.Add(this.lbl_precio_compra);
            this.Controls.Add(this.check_edit);
            this.Controls.Add(this.lbl_patente);
            this.Controls.Add(this.txt_patente);
            this.Controls.Add(this.lbl_cv);
            this.Controls.Add(this.txt_potencia_cv);
            this.Controls.Add(this.lbl_hp);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.txt_potencia_hp);
            this.Controls.Add(this.txt_km);
            this.Controls.Add(this.txt_año_modelo);
            this.Controls.Add(this.lbl_descripcion);
            this.Controls.Add(this.lbl_potencia);
            this.Controls.Add(this.lbl_km);
            this.Controls.Add(this.lbl_año);
            this.Controls.Add(this.txt_precio_venta);
            this.Controls.Add(this.lbl_precio_venta);
            this.Controls.Add(this.combo_modelo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combo_gen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combo_serie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_fab);
            this.Name = "frm_new_unidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unidades";
            this.Load += new System.EventHandler(this.frm_new_unidad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_fab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_serie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_gen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combo_modelo;
        private System.Windows.Forms.Label lbl_precio_venta;
        private System.Windows.Forms.TextBox txt_precio_venta;
        private System.Windows.Forms.Label lbl_año;
        private System.Windows.Forms.Label lbl_km;
        private System.Windows.Forms.Label lbl_potencia;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.TextBox txt_año_modelo;
        private System.Windows.Forms.TextBox txt_km;
        private System.Windows.Forms.TextBox txt_potencia_hp;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_hp;
        private System.Windows.Forms.TextBox txt_potencia_cv;
        private System.Windows.Forms.Label lbl_cv;
        private System.Windows.Forms.TextBox txt_patente;
        private System.Windows.Forms.Label lbl_patente;
        private System.Windows.Forms.CheckBox check_edit;
        private System.Windows.Forms.TextBox txt_precio_compra;
        private System.Windows.Forms.Label lbl_precio_compra;
    }
}