namespace AgenciaDeAutos.GUI.Clientes
{
    partial class frm_nuevo_cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_nuevo_cliente));
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
            this.lbl_dni_warning = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_obligatorios = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(291, 355);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 31;
            this.btn_save.Text = "Guardar";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_exit.Location = new System.Drawing.Point(372, 355);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 30;
            this.btn_exit.Text = "Salir";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // txt_mobile
            // 
            this.txt_mobile.Location = new System.Drawing.Point(78, 269);
            this.txt_mobile.MaxLength = 10;
            this.txt_mobile.Name = "txt_mobile";
            this.txt_mobile.Size = new System.Drawing.Size(181, 20);
            this.txt_mobile.TabIndex = 29;
            this.txt_mobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarCelular);
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(78, 232);
            this.txt_phone.MaxLength = 10;
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(181, 20);
            this.txt_phone.TabIndex = 28;
            this.txt_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarTelefono);
            // 
            // txt_nro
            // 
            this.txt_nro.Location = new System.Drawing.Point(78, 197);
            this.txt_nro.MaxLength = 6;
            this.txt_nro.Name = "txt_nro";
            this.txt_nro.Size = new System.Drawing.Size(104, 20);
            this.txt_nro.TabIndex = 27;
            this.txt_nro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarNroDireccion);
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(78, 120);
            this.txt_address.MaxLength = 50;
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(352, 71);
            this.txt_address.TabIndex = 26;
            this.txt_address.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarDireccion);
            // 
            // txt_dni
            // 
            this.txt_dni.Location = new System.Drawing.Point(78, 90);
            this.txt_dni.MaxLength = 12;
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(102, 20);
            this.txt_dni.TabIndex = 25;
            this.txt_dni.TextChanged += new System.EventHandler(this.txt_dni_TextChanged);
            this.txt_dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarDNI);
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(78, 58);
            this.txt_lastName.MaxLength = 30;
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(181, 20);
            this.txt_lastName.TabIndex = 24;
            this.txt_lastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarApellido);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(78, 28);
            this.txt_name.MaxLength = 30;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(181, 20);
            this.txt_name.TabIndex = 23;
            this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarNombre);
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.Location = new System.Drawing.Point(43, 93);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(29, 13);
            this.lbl_dni.TabIndex = 22;
            this.lbl_dni.Text = "DNI:";
            // 
            // lbl_mobile
            // 
            this.lbl_mobile.AutoSize = true;
            this.lbl_mobile.Location = new System.Drawing.Point(27, 272);
            this.lbl_mobile.Name = "lbl_mobile";
            this.lbl_mobile.Size = new System.Drawing.Size(42, 13);
            this.lbl_mobile.TabIndex = 21;
            this.lbl_mobile.Text = "Celular:";
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Location = new System.Drawing.Point(17, 235);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(52, 13);
            this.lbl_phone.TabIndex = 20;
            this.lbl_phone.Text = "Telefono:";
            // 
            // lbl_nro
            // 
            this.lbl_nro.AutoSize = true;
            this.lbl_nro.Location = new System.Drawing.Point(45, 200);
            this.lbl_nro.Name = "lbl_nro";
            this.lbl_nro.Size = new System.Drawing.Size(27, 13);
            this.lbl_nro.TabIndex = 19;
            this.lbl_nro.Text = "Nro:";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(17, 123);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(55, 13);
            this.lbl_address.TabIndex = 18;
            this.lbl_address.Text = "Direccion:";
            // 
            // lbl_lastName
            // 
            this.lbl_lastName.AutoSize = true;
            this.lbl_lastName.Location = new System.Drawing.Point(25, 61);
            this.lbl_lastName.Name = "lbl_lastName";
            this.lbl_lastName.Size = new System.Drawing.Size(47, 13);
            this.lbl_lastName.TabIndex = 17;
            this.lbl_lastName.Text = "Apellido:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(25, 31);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(47, 13);
            this.lbl_name.TabIndex = 16;
            this.lbl_name.Text = "Nombre:";
            // 
            // lbl_dni_warning
            // 
            this.lbl_dni_warning.AutoSize = true;
            this.lbl_dni_warning.Location = new System.Drawing.Point(186, 93);
            this.lbl_dni_warning.Name = "lbl_dni_warning";
            this.lbl_dni_warning.Size = new System.Drawing.Size(11, 13);
            this.lbl_dni_warning.TabIndex = 32;
            this.lbl_dni_warning.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(436, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(265, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(265, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "*";
            // 
            // lbl_obligatorios
            // 
            this.lbl_obligatorios.AutoSize = true;
            this.lbl_obligatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_obligatorios.ForeColor = System.Drawing.Color.Red;
            this.lbl_obligatorios.Location = new System.Drawing.Point(75, 309);
            this.lbl_obligatorios.Name = "lbl_obligatorios";
            this.lbl_obligatorios.Size = new System.Drawing.Size(145, 17);
            this.lbl_obligatorios.TabIndex = 39;
            this.lbl_obligatorios.Text = "* Campos obligatorios";
            // 
            // frm_nuevo_cliente
            // 
            this.AcceptButton = this.btn_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_exit;
            this.ClientSize = new System.Drawing.Size(460, 390);
            this.Controls.Add(this.lbl_obligatorios);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_dni_warning);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_nuevo_cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Label lbl_dni_warning;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_obligatorios;
    }
}