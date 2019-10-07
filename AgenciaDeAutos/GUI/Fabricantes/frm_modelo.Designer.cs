﻿namespace AgenciaDeAutos.GUI.Vehiculos
{
    partial class frm_modelo
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
            this.pic_vehiculo = new System.Windows.Forms.PictureBox();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.combo_serie = new System.Windows.Forms.ComboBox();
            this.combo_modelo = new System.Windows.Forms.ComboBox();
            this.combo_generacion = new System.Windows.Forms.ComboBox();
            this.lbl_serie = new System.Windows.Forms.Label();
            this.lbl_generacion = new System.Windows.Forms.Label();
            this.lbl_modelo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_stock = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.txt_precio_dolar = new System.Windows.Forms.TextBox();
            this.lbl_precio_dolar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_precio_arg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_precio_arg = new System.Windows.Forms.Label();
            this.lbl_cotizacion = new System.Windows.Forms.Label();
            this.txt_cotizacion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pic_vehiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_vehiculo
            // 
            this.pic_vehiculo.Image = global::AgenciaDeAutos.Properties.Resources.NoImage;
            this.pic_vehiculo.Location = new System.Drawing.Point(746, 30);
            this.pic_vehiculo.Name = "pic_vehiculo";
            this.pic_vehiculo.Size = new System.Drawing.Size(480, 320);
            this.pic_vehiculo.TabIndex = 0;
            this.pic_vehiculo.TabStop = false;
            // 
            // pic_logo
            // 
            this.pic_logo.Location = new System.Drawing.Point(12, 30);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(180, 180);
            this.pic_logo.TabIndex = 1;
            this.pic_logo.TabStop = false;
            // 
            // combo_serie
            // 
            this.combo_serie.FormattingEnabled = true;
            this.combo_serie.Location = new System.Drawing.Point(107, 13);
            this.combo_serie.Name = "combo_serie";
            this.combo_serie.Size = new System.Drawing.Size(178, 21);
            this.combo_serie.TabIndex = 3;
            // 
            // combo_modelo
            // 
            this.combo_modelo.FormattingEnabled = true;
            this.combo_modelo.Location = new System.Drawing.Point(107, 97);
            this.combo_modelo.Name = "combo_modelo";
            this.combo_modelo.Size = new System.Drawing.Size(178, 21);
            this.combo_modelo.TabIndex = 4;
            // 
            // combo_generacion
            // 
            this.combo_generacion.FormattingEnabled = true;
            this.combo_generacion.Location = new System.Drawing.Point(107, 54);
            this.combo_generacion.Name = "combo_generacion";
            this.combo_generacion.Size = new System.Drawing.Size(178, 21);
            this.combo_generacion.TabIndex = 5;
            // 
            // lbl_serie
            // 
            this.lbl_serie.AutoSize = true;
            this.lbl_serie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_serie.Location = new System.Drawing.Point(43, 13);
            this.lbl_serie.Name = "lbl_serie";
            this.lbl_serie.Size = new System.Drawing.Size(45, 17);
            this.lbl_serie.TabIndex = 6;
            this.lbl_serie.Text = "Serie:";
            // 
            // lbl_generacion
            // 
            this.lbl_generacion.AutoSize = true;
            this.lbl_generacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_generacion.Location = new System.Drawing.Point(2, 54);
            this.lbl_generacion.Name = "lbl_generacion";
            this.lbl_generacion.Size = new System.Drawing.Size(86, 17);
            this.lbl_generacion.TabIndex = 7;
            this.lbl_generacion.Text = "Generacion:";
            // 
            // lbl_modelo
            // 
            this.lbl_modelo.AutoSize = true;
            this.lbl_modelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_modelo.Location = new System.Drawing.Point(30, 101);
            this.lbl_modelo.Name = "lbl_modelo";
            this.lbl_modelo.Size = new System.Drawing.Size(58, 17);
            this.lbl_modelo.TabIndex = 8;
            this.lbl_modelo.Text = "Modelo:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(596, 368);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(727, 278);
            this.dataGridView1.TabIndex = 10;
            // 
            // btn_stock
            // 
            this.btn_stock.Location = new System.Drawing.Point(596, 652);
            this.btn_stock.Name = "btn_stock";
            this.btn_stock.Size = new System.Drawing.Size(132, 23);
            this.btn_stock.TabIndex = 11;
            this.btn_stock.Text = "Stock en existencia";
            this.btn_stock.UseVisualStyleBackColor = true;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(1248, 694);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 12;
            this.btn_back.Text = "Atras";
            this.btn_back.UseVisualStyleBackColor = true;
            // 
            // txt_precio_dolar
            // 
            this.txt_precio_dolar.Location = new System.Drawing.Point(107, 11);
            this.txt_precio_dolar.Name = "txt_precio_dolar";
            this.txt_precio_dolar.Size = new System.Drawing.Size(133, 20);
            this.txt_precio_dolar.TabIndex = 13;
            // 
            // lbl_precio_dolar
            // 
            this.lbl_precio_dolar.AutoSize = true;
            this.lbl_precio_dolar.Location = new System.Drawing.Point(1, 14);
            this.lbl_precio_dolar.Name = "lbl_precio_dolar";
            this.lbl_precio_dolar.Size = new System.Drawing.Size(85, 13);
            this.lbl_precio_dolar.TabIndex = 14;
            this.lbl_precio_dolar.Text = "Precio Sugerido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 16;
            // 
            // txt_precio_arg
            // 
            this.txt_precio_arg.Location = new System.Drawing.Point(107, 37);
            this.txt_precio_arg.Name = "txt_precio_arg";
            this.txt_precio_arg.Size = new System.Drawing.Size(133, 20);
            this.txt_precio_arg.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "$ USD";
            // 
            // lbl_precio_arg
            // 
            this.lbl_precio_arg.AutoSize = true;
            this.lbl_precio_arg.Location = new System.Drawing.Point(1, 40);
            this.lbl_precio_arg.Name = "lbl_precio_arg";
            this.lbl_precio_arg.Size = new System.Drawing.Size(85, 13);
            this.lbl_precio_arg.TabIndex = 18;
            this.lbl_precio_arg.Text = "Precio Sugerido:";
            // 
            // lbl_cotizacion
            // 
            this.lbl_cotizacion.AutoSize = true;
            this.lbl_cotizacion.Location = new System.Drawing.Point(27, 66);
            this.lbl_cotizacion.Name = "lbl_cotizacion";
            this.lbl_cotizacion.Size = new System.Drawing.Size(59, 13);
            this.lbl_cotizacion.TabIndex = 19;
            this.lbl_cotizacion.Text = "Cotizacion:";
            // 
            // txt_cotizacion
            // 
            this.txt_cotizacion.Location = new System.Drawing.Point(107, 63);
            this.txt_cotizacion.Name = "txt_cotizacion";
            this.txt_cotizacion.Size = new System.Drawing.Size(133, 20);
            this.txt_cotizacion.TabIndex = 20;
            this.txt_cotizacion.TextChanged += new System.EventHandler(this.txt_cotizacion_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(246, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "$ ARS";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_precio_arg);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_precio_dolar);
            this.panel1.Controls.Add(this.txt_cotizacion);
            this.panel1.Controls.Add(this.lbl_precio_dolar);
            this.panel1.Controls.Add(this.lbl_cotizacion);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbl_precio_arg);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(291, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 100);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_serie);
            this.panel2.Controls.Add(this.combo_generacion);
            this.panel2.Controls.Add(this.combo_modelo);
            this.panel2.Controls.Add(this.lbl_modelo);
            this.panel2.Controls.Add(this.combo_serie);
            this.panel2.Controls.Add(this.lbl_generacion);
            this.panel2.Location = new System.Drawing.Point(291, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(301, 128);
            this.panel2.TabIndex = 23;
            // 
            // frm_modelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_stock);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pic_logo);
            this.Controls.Add(this.pic_vehiculo);
            this.Name = "frm_modelo";
            ((System.ComponentModel.ISupportInitialize)(this.pic_vehiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_vehiculo;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.ComboBox combo_serie;
        private System.Windows.Forms.ComboBox combo_modelo;
        private System.Windows.Forms.ComboBox combo_generacion;
        private System.Windows.Forms.Label lbl_serie;
        private System.Windows.Forms.Label lbl_generacion;
        private System.Windows.Forms.Label lbl_modelo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_stock;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox txt_precio_dolar;
        private System.Windows.Forms.Label lbl_precio_dolar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_precio_arg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_precio_arg;
        private System.Windows.Forms.Label lbl_cotizacion;
        private System.Windows.Forms.TextBox txt_cotizacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}