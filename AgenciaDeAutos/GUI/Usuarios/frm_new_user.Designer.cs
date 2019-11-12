namespace AgenciaDeAutos.GUI.Otros
{
    partial class frm_new_user
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_new_user));
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.lbl_profile = new System.Windows.Forms.Label();
            this.combo_perfil = new System.Windows.Forms.ComboBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.lbl_info_name = new System.Windows.Forms.Label();
            this.lbl_info_pass = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(39, 25);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(47, 13);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Nombre:";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Location = new System.Drawing.Point(22, 73);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(64, 13);
            this.lbl_pass.TabIndex = 1;
            this.lbl_pass.Text = "Contraseña:";
            // 
            // lbl_profile
            // 
            this.lbl_profile.AutoSize = true;
            this.lbl_profile.Location = new System.Drawing.Point(53, 123);
            this.lbl_profile.Name = "lbl_profile";
            this.lbl_profile.Size = new System.Drawing.Size(33, 13);
            this.lbl_profile.TabIndex = 2;
            this.lbl_profile.Text = "Perfil:";
            // 
            // combo_perfil
            // 
            this.combo_perfil.FormattingEnabled = true;
            this.combo_perfil.Location = new System.Drawing.Point(92, 120);
            this.combo_perfil.Name = "combo_perfil";
            this.combo_perfil.Size = new System.Drawing.Size(157, 21);
            this.combo_perfil.TabIndex = 3;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(92, 22);
            this.txt_name.MaxLength = 30;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(157, 20);
            this.txt_name.TabIndex = 4;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarNombre);
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(92, 70);
            this.txt_pass.MaxLength = 50;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(157, 20);
            this.txt_pass.TabIndex = 5;
            this.txt_pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarContraseña);
            // 
            // lbl_info_name
            // 
            this.lbl_info_name.AutoSize = true;
            this.lbl_info_name.ForeColor = System.Drawing.Color.Red;
            this.lbl_info_name.Location = new System.Drawing.Point(255, 25);
            this.lbl_info_name.Name = "lbl_info_name";
            this.lbl_info_name.Size = new System.Drawing.Size(110, 13);
            this.lbl_info_name.TabIndex = 6;
            this.lbl_info_name.Text = "maximo 30 caracteres";
            // 
            // lbl_info_pass
            // 
            this.lbl_info_pass.AutoSize = true;
            this.lbl_info_pass.ForeColor = System.Drawing.Color.Red;
            this.lbl_info_pass.Location = new System.Drawing.Point(255, 73);
            this.lbl_info_pass.Name = "lbl_info_pass";
            this.lbl_info_pass.Size = new System.Drawing.Size(111, 13);
            this.lbl_info_pass.TabIndex = 7;
            this.lbl_info_pass.Text = "Maximo 50 caracteres";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(209, 159);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "Crear";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(290, 159);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 9;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // frm_new_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 196);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_info_pass);
            this.Controls.Add(this.lbl_info_name);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.combo_perfil);
            this.Controls.Add(this.lbl_profile);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_new_user";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Nuevo usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_profile;
        private System.Windows.Forms.ComboBox combo_perfil;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label lbl_info_name;
        private System.Windows.Forms.Label lbl_info_pass;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_salir;
    }
}