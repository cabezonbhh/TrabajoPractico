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
            this.SuspendLayout();
            // 
            // combo_fab
            // 
            this.combo_fab.FormattingEnabled = true;
            this.combo_fab.Location = new System.Drawing.Point(102, 41);
            this.combo_fab.Name = "combo_fab";
            this.combo_fab.Size = new System.Drawing.Size(121, 21);
            this.combo_fab.TabIndex = 0;
            this.combo_fab.SelectionChangeCommitted += new System.EventHandler(this.combo_fab_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fabricante:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Serie:";
            // 
            // combo_serie
            // 
            this.combo_serie.FormattingEnabled = true;
            this.combo_serie.Location = new System.Drawing.Point(102, 87);
            this.combo_serie.Name = "combo_serie";
            this.combo_serie.Size = new System.Drawing.Size(121, 21);
            this.combo_serie.TabIndex = 2;
            this.combo_serie.SelectionChangeCommitted += new System.EventHandler(this.combo_serie_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Generacion:";
            // 
            // combo_gen
            // 
            this.combo_gen.FormattingEnabled = true;
            this.combo_gen.Location = new System.Drawing.Point(102, 133);
            this.combo_gen.Name = "combo_gen";
            this.combo_gen.Size = new System.Drawing.Size(121, 21);
            this.combo_gen.TabIndex = 4;
            this.combo_gen.SelectionChangeCommitted += new System.EventHandler(this.combo_gen_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Modelo:";
            // 
            // combo_modelo
            // 
            this.combo_modelo.FormattingEnabled = true;
            this.combo_modelo.Location = new System.Drawing.Point(102, 178);
            this.combo_modelo.Name = "combo_modelo";
            this.combo_modelo.Size = new System.Drawing.Size(121, 21);
            this.combo_modelo.TabIndex = 7;
            // 
            // frm_new_unidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 454);
            this.Controls.Add(this.combo_modelo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combo_gen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combo_serie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_fab);
            this.Name = "frm_new_unidad";
            this.Text = "frm_new_unidad";
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
    }
}