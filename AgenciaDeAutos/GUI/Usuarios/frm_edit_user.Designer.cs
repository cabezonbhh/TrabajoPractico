namespace AgenciaDeAutos.GUI.Usuarios
{
    partial class frm_edit_user
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
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_info_pass = new System.Windows.Forms.Label();
            this.lbl_info_name = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.combo_perfil = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_profile = new System.Windows.Forms.TextBox();
            this.lbl_profile = new System.Windows.Forms.Label();
            this.check_profile = new System.Windows.Forms.CheckBox();
            this.btn_salir = new System.Windows.Forms.Button();
            this.check_name = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(210, 209);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 18;
            this.btn_save.Text = "Guardar";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_info_pass
            // 
            this.lbl_info_pass.AutoSize = true;
            this.lbl_info_pass.ForeColor = System.Drawing.Color.Red;
            this.lbl_info_pass.Location = new System.Drawing.Point(256, 74);
            this.lbl_info_pass.Name = "lbl_info_pass";
            this.lbl_info_pass.Size = new System.Drawing.Size(111, 13);
            this.lbl_info_pass.TabIndex = 17;
            this.lbl_info_pass.Text = "Maximo 50 caracteres";
            // 
            // lbl_info_name
            // 
            this.lbl_info_name.AutoSize = true;
            this.lbl_info_name.ForeColor = System.Drawing.Color.Red;
            this.lbl_info_name.Location = new System.Drawing.Point(256, 25);
            this.lbl_info_name.Name = "lbl_info_name";
            this.lbl_info_name.Size = new System.Drawing.Size(110, 13);
            this.lbl_info_name.TabIndex = 16;
            this.lbl_info_name.Text = "maximo 30 caracteres";
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(93, 71);
            this.txt_pass.MaxLength = 50;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(157, 20);
            this.txt_pass.TabIndex = 15;
            this.txt_pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarContraseña);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(93, 22);
            this.txt_name.MaxLength = 30;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(157, 20);
            this.txt_name.TabIndex = 14;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarNombre);
            // 
            // combo_perfil
            // 
            this.combo_perfil.FormattingEnabled = true;
            this.combo_perfil.Location = new System.Drawing.Point(93, 163);
            this.combo_perfil.Name = "combo_perfil";
            this.combo_perfil.Size = new System.Drawing.Size(157, 21);
            this.combo_perfil.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Perfil:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre:";
            // 
            // txt_profile
            // 
            this.txt_profile.Location = new System.Drawing.Point(93, 116);
            this.txt_profile.MaxLength = 50;
            this.txt_profile.Name = "txt_profile";
            this.txt_profile.Size = new System.Drawing.Size(157, 20);
            this.txt_profile.TabIndex = 20;
            // 
            // lbl_profile
            // 
            this.lbl_profile.AutoSize = true;
            this.lbl_profile.Location = new System.Drawing.Point(54, 119);
            this.lbl_profile.Name = "lbl_profile";
            this.lbl_profile.Size = new System.Drawing.Size(33, 13);
            this.lbl_profile.TabIndex = 21;
            this.lbl_profile.Text = "Perfil:";
            // 
            // check_profile
            // 
            this.check_profile.AutoSize = true;
            this.check_profile.Location = new System.Drawing.Point(256, 166);
            this.check_profile.Name = "check_profile";
            this.check_profile.Size = new System.Drawing.Size(90, 17);
            this.check_profile.TabIndex = 22;
            this.check_profile.Text = "Cambiar Perfil";
            this.check_profile.UseVisualStyleBackColor = true;
            this.check_profile.CheckedChanged += new System.EventHandler(this.check_profile_CheckedChanged);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(291, 209);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 23;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // check_name
            // 
            this.check_name.AutoSize = true;
            this.check_name.Location = new System.Drawing.Point(93, 48);
            this.check_name.Name = "check_name";
            this.check_name.Size = new System.Drawing.Size(53, 17);
            this.check_name.TabIndex = 24;
            this.check_name.Text = "Editar";
            this.check_name.UseVisualStyleBackColor = true;
            this.check_name.CheckedChanged += new System.EventHandler(this.check_name_CheckedChanged);
            // 
            // frm_edit_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 252);
            this.Controls.Add(this.check_name);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.check_profile);
            this.Controls.Add(this.lbl_profile);
            this.Controls.Add(this.txt_profile);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_info_pass);
            this.Controls.Add(this.lbl_info_name);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.combo_perfil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_edit_user";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_edit_user";
            this.Load += new System.EventHandler(this.frm_edit_user_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lbl_info_pass;
        private System.Windows.Forms.Label lbl_info_name;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.ComboBox combo_perfil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_profile;
        private System.Windows.Forms.Label lbl_profile;
        private System.Windows.Forms.CheckBox check_profile;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.CheckBox check_name;
    }
}