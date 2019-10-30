namespace AgenciaDeAutos.GUI.Fabricantes
{
    partial class frm_menu_fabricantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_menu_fabricantes));
            this.tab_fabricantes = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_porsche = new System.Windows.Forms.Button();
            this.btn_mercedes = new System.Windows.Forms.Button();
            this.btn_lamborghini = new System.Windows.Forms.Button();
            this.btn_ferrari = new System.Windows.Forms.Button();
            this.btn_bmw = new System.Windows.Forms.Button();
            this.btn_audi = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_salir = new System.Windows.Forms.Button();
            this.tab_fabricantes.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_fabricantes
            // 
            this.tab_fabricantes.Controls.Add(this.tabPage1);
            this.tab_fabricantes.Controls.Add(this.tabPage2);
            this.tab_fabricantes.Location = new System.Drawing.Point(12, 12);
            this.tab_fabricantes.Name = "tab_fabricantes";
            this.tab_fabricantes.SelectedIndex = 0;
            this.tab_fabricantes.Size = new System.Drawing.Size(742, 474);
            this.tab_fabricantes.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_porsche);
            this.tabPage1.Controls.Add(this.btn_mercedes);
            this.tabPage1.Controls.Add(this.btn_lamborghini);
            this.tabPage1.Controls.Add(this.btn_ferrari);
            this.tabPage1.Controls.Add(this.btn_bmw);
            this.tabPage1.Controls.Add(this.btn_audi);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(734, 448);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Marcas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_porsche
            // 
            this.btn_porsche.BackColor = System.Drawing.Color.White;
            this.btn_porsche.Image = ((System.Drawing.Image)(resources.GetObject("btn_porsche.Image")));
            this.btn_porsche.Location = new System.Drawing.Point(57, 177);
            this.btn_porsche.Name = "btn_porsche";
            this.btn_porsche.Size = new System.Drawing.Size(96, 96);
            this.btn_porsche.TabIndex = 13;
            this.btn_porsche.UseVisualStyleBackColor = false;
            this.btn_porsche.Click += new System.EventHandler(this.btn_porsche_Click);
            // 
            // btn_mercedes
            // 
            this.btn_mercedes.BackColor = System.Drawing.Color.White;
            this.btn_mercedes.Image = ((System.Drawing.Image)(resources.GetObject("btn_mercedes.Image")));
            this.btn_mercedes.Location = new System.Drawing.Point(544, 55);
            this.btn_mercedes.Name = "btn_mercedes";
            this.btn_mercedes.Size = new System.Drawing.Size(96, 96);
            this.btn_mercedes.TabIndex = 12;
            this.btn_mercedes.UseVisualStyleBackColor = false;
            this.btn_mercedes.Click += new System.EventHandler(this.btn_mercedes_Click);
            // 
            // btn_lamborghini
            // 
            this.btn_lamborghini.BackColor = System.Drawing.Color.White;
            this.btn_lamborghini.Image = ((System.Drawing.Image)(resources.GetObject("btn_lamborghini.Image")));
            this.btn_lamborghini.Location = new System.Drawing.Point(419, 55);
            this.btn_lamborghini.Name = "btn_lamborghini";
            this.btn_lamborghini.Size = new System.Drawing.Size(96, 96);
            this.btn_lamborghini.TabIndex = 11;
            this.btn_lamborghini.UseVisualStyleBackColor = false;
            this.btn_lamborghini.Click += new System.EventHandler(this.btn_lamborghini_Click);
            // 
            // btn_ferrari
            // 
            this.btn_ferrari.BackColor = System.Drawing.Color.White;
            this.btn_ferrari.Image = ((System.Drawing.Image)(resources.GetObject("btn_ferrari.Image")));
            this.btn_ferrari.Location = new System.Drawing.Point(295, 55);
            this.btn_ferrari.Name = "btn_ferrari";
            this.btn_ferrari.Size = new System.Drawing.Size(96, 96);
            this.btn_ferrari.TabIndex = 10;
            this.btn_ferrari.UseVisualStyleBackColor = false;
            this.btn_ferrari.Click += new System.EventHandler(this.btn_ferrari_Click);
            // 
            // btn_bmw
            // 
            this.btn_bmw.BackColor = System.Drawing.Color.White;
            this.btn_bmw.Image = ((System.Drawing.Image)(resources.GetObject("btn_bmw.Image")));
            this.btn_bmw.Location = new System.Drawing.Point(175, 55);
            this.btn_bmw.Name = "btn_bmw";
            this.btn_bmw.Size = new System.Drawing.Size(96, 96);
            this.btn_bmw.TabIndex = 9;
            this.btn_bmw.UseVisualStyleBackColor = false;
            this.btn_bmw.Click += new System.EventHandler(this.btn_bmw_Click);
            // 
            // btn_audi
            // 
            this.btn_audi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_audi.BackColor = System.Drawing.Color.White;
            this.btn_audi.ForeColor = System.Drawing.Color.White;
            this.btn_audi.Image = ((System.Drawing.Image)(resources.GetObject("btn_audi.Image")));
            this.btn_audi.Location = new System.Drawing.Point(57, 55);
            this.btn_audi.Name = "btn_audi";
            this.btn_audi.Size = new System.Drawing.Size(96, 96);
            this.btn_audi.TabIndex = 8;
            this.btn_audi.UseVisualStyleBackColor = false;
            this.btn_audi.Click += new System.EventHandler(this.btn_audi_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(734, 448);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Busqueda";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(674, 498);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 9;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // frm_menu_fabricantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_salir;
            this.ClientSize = new System.Drawing.Size(766, 533);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.tab_fabricantes);
            this.Name = "frm_menu_fabricantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fabricantes";
            this.tab_fabricantes.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_fabricantes;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_porsche;
        private System.Windows.Forms.Button btn_mercedes;
        private System.Windows.Forms.Button btn_lamborghini;
        private System.Windows.Forms.Button btn_ferrari;
        private System.Windows.Forms.Button btn_bmw;
        private System.Windows.Forms.Button btn_audi;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_salir;
    }
}