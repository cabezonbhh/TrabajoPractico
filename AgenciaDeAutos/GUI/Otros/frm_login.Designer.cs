namespace AgenciaDeAutos
{
    partial class frm_login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.btn_in = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lbl_warning_name = new System.Windows.Forms.Label();
            this.lbl_warning_pass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_in
            // 
            this.btn_in.Location = new System.Drawing.Point(83, 140);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(75, 23);
            this.btn_in.TabIndex = 0;
            this.btn_in.Text = "Ingresar";
            this.btn_in.UseVisualStyleBackColor = true;
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(255, 140);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(31, 34);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(46, 13);
            this.lbl_user.TabIndex = 2;
            this.lbl_user.Text = "Usuario:";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Location = new System.Drawing.Point(12, 90);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(64, 13);
            this.lbl_pass.TabIndex = 3;
            this.lbl_pass.Text = "Contraseña:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(83, 31);
            this.txtUser.MaxLength = 30;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(247, 20);
            this.txtUser.TabIndex = 6;
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarNombre);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(83, 87);
            this.txtPass.MaxLength = 50;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(247, 20);
            this.txtPass.TabIndex = 7;
            this.txtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarContraseña);
            // 
            // lbl_warning_name
            // 
            this.lbl_warning_name.AutoSize = true;
            this.lbl_warning_name.Location = new System.Drawing.Point(83, 58);
            this.lbl_warning_name.Name = "lbl_warning_name";
            this.lbl_warning_name.Size = new System.Drawing.Size(0, 13);
            this.lbl_warning_name.TabIndex = 8;
            // 
            // lbl_warning_pass
            // 
            this.lbl_warning_pass.AutoSize = true;
            this.lbl_warning_pass.Location = new System.Drawing.Point(83, 110);
            this.lbl_warning_pass.Name = "lbl_warning_pass";
            this.lbl_warning_pass.Size = new System.Drawing.Size(0, 13);
            this.lbl_warning_pass.TabIndex = 9;
            // 
            // frm_login
            // 
            this.AcceptButton = this.btn_in;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(349, 176);
            this.Controls.Add(this.lbl_warning_pass);
            this.Controls.Add(this.lbl_warning_name);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_in);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar sesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_in;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lbl_warning_name;
        private System.Windows.Forms.Label lbl_warning_pass;
    }
}

