namespace AgenciaDeAutos.GUI.Vehiculos
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
            this.combo_serie = new System.Windows.Forms.ComboBox();
            this.combo_modelo = new System.Windows.Forms.ComboBox();
            this.combo_generacion = new System.Windows.Forms.ComboBox();
            this.lbl_serie = new System.Windows.Forms.Label();
            this.lbl_generacion = new System.Windows.Forms.Label();
            this.lbl_modelo = new System.Windows.Forms.Label();
            this.btn_iniciar_venta = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_stock_unidades = new System.Windows.Forms.DataGridView();
            this.col_fabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_generacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_añoModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pic_front = new System.Windows.Forms.PictureBox();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.pic_rear = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stock_unidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_front)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_rear)).BeginInit();
            this.SuspendLayout();
            // 
            // combo_serie
            // 
            this.combo_serie.FormattingEnabled = true;
            this.combo_serie.Location = new System.Drawing.Point(107, 12);
            this.combo_serie.Name = "combo_serie";
            this.combo_serie.Size = new System.Drawing.Size(178, 21);
            this.combo_serie.TabIndex = 3;
            this.combo_serie.SelectedIndexChanged += new System.EventHandler(this.combo_serie_SelectedIndexChanged);
            this.combo_serie.SelectionChangeCommitted += new System.EventHandler(this.combo_serie_SelectionChangeCommitted);
            this.combo_serie.SelectedValueChanged += new System.EventHandler(this.combo_serie_SelectedValueChanged);
            // 
            // combo_modelo
            // 
            this.combo_modelo.FormattingEnabled = true;
            this.combo_modelo.Location = new System.Drawing.Point(107, 97);
            this.combo_modelo.Name = "combo_modelo";
            this.combo_modelo.Size = new System.Drawing.Size(178, 21);
            this.combo_modelo.TabIndex = 4;
            this.combo_modelo.SelectedIndexChanged += new System.EventHandler(this.combo_modelo_SelectedIndexChanged);
            this.combo_modelo.SelectionChangeCommitted += new System.EventHandler(this.combo_modelo_SelectionChangeCommitted);
            // 
            // combo_generacion
            // 
            this.combo_generacion.FormattingEnabled = true;
            this.combo_generacion.Location = new System.Drawing.Point(107, 54);
            this.combo_generacion.Name = "combo_generacion";
            this.combo_generacion.Size = new System.Drawing.Size(178, 21);
            this.combo_generacion.TabIndex = 5;
            this.combo_generacion.SelectedIndexChanged += new System.EventHandler(this.combo_generacion_SelectedIndexChanged);
            this.combo_generacion.SelectionChangeCommitted += new System.EventHandler(this.combo_generacion_SelectionChangeCommitted);
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
            // btn_iniciar_venta
            // 
            this.btn_iniciar_venta.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_iniciar_venta.Location = new System.Drawing.Point(693, 371);
            this.btn_iniciar_venta.Name = "btn_iniciar_venta";
            this.btn_iniciar_venta.Size = new System.Drawing.Size(132, 53);
            this.btn_iniciar_venta.TabIndex = 11;
            this.btn_iniciar_venta.Text = "Iniciar Venta";
            this.btn_iniciar_venta.UseVisualStyleBackColor = true;
            this.btn_iniciar_venta.Click += new System.EventHandler(this.btn_iniciar_venta_Click);
            // 
            // btn_back
            // 
            this.btn_back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_back.Location = new System.Drawing.Point(1248, 694);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 12;
            this.btn_back.Text = "Atras";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_serie);
            this.panel2.Controls.Add(this.combo_generacion);
            this.panel2.Controls.Add(this.combo_modelo);
            this.panel2.Controls.Add(this.lbl_modelo);
            this.panel2.Controls.Add(this.combo_serie);
            this.panel2.Controls.Add(this.lbl_generacion);
            this.panel2.Location = new System.Drawing.Point(38, 213);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(301, 128);
            this.panel2.TabIndex = 23;
            // 
            // dgv_stock_unidades
            // 
            this.dgv_stock_unidades.AllowUserToAddRows = false;
            this.dgv_stock_unidades.AllowUserToDeleteRows = false;
            this.dgv_stock_unidades.AllowUserToOrderColumns = true;
            this.dgv_stock_unidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_stock_unidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_fabricante,
            this.col_modelo,
            this.col_generacion,
            this.col_añoModelo});
            this.dgv_stock_unidades.Location = new System.Drawing.Point(843, 371);
            this.dgv_stock_unidades.Name = "dgv_stock_unidades";
            this.dgv_stock_unidades.ReadOnly = true;
            this.dgv_stock_unidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_stock_unidades.Size = new System.Drawing.Size(480, 315);
            this.dgv_stock_unidades.TabIndex = 36;
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
            // pic_front
            // 
            this.pic_front.Cursor = System.Windows.Forms.Cursors.Default;
            this.pic_front.Image = global::AgenciaDeAutos.Properties.Resources.NoImage;
            this.pic_front.Location = new System.Drawing.Point(345, 21);
            this.pic_front.Name = "pic_front";
            this.pic_front.Size = new System.Drawing.Size(480, 320);
            this.pic_front.TabIndex = 24;
            this.pic_front.TabStop = false;
            // 
            // pic_logo
            // 
            this.pic_logo.Location = new System.Drawing.Point(43, 21);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(180, 180);
            this.pic_logo.TabIndex = 1;
            this.pic_logo.TabStop = false;
            // 
            // pic_rear
            // 
            this.pic_rear.Image = global::AgenciaDeAutos.Properties.Resources.NoImage;
            this.pic_rear.Location = new System.Drawing.Point(843, 21);
            this.pic_rear.Name = "pic_rear";
            this.pic_rear.Size = new System.Drawing.Size(480, 320);
            this.pic_rear.TabIndex = 0;
            this.pic_rear.TabStop = false;
            // 
            // frm_modelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_back;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.dgv_stock_unidades);
            this.Controls.Add(this.pic_front);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_iniciar_venta);
            this.Controls.Add(this.pic_logo);
            this.Controls.Add(this.pic_rear);
            this.MaximizeBox = false;
            this.Name = "frm_modelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_modelo_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stock_unidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_front)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_rear)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_rear;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.ComboBox combo_serie;
        private System.Windows.Forms.ComboBox combo_modelo;
        private System.Windows.Forms.ComboBox combo_generacion;
        private System.Windows.Forms.Label lbl_serie;
        private System.Windows.Forms.Label lbl_generacion;
        private System.Windows.Forms.Label lbl_modelo;
        private System.Windows.Forms.Button btn_iniciar_venta;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pic_front;
        private System.Windows.Forms.DataGridView dgv_stock_unidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fabricante;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_generacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_añoModelo;
    }
}