namespace Ventana_Inicial
{
    partial class frm_inicio_sesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_inicio_sesion));
            this.lbl_titulo_cliente = new System.Windows.Forms.Label();
            this.txt_usuario_sesion = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_usuario_sesion = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.btn_iniciar_sesion = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.lbl_id_usuario = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.lbl_tipo_acceso = new System.Windows.Forms.Label();
            this.txt_encriptado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_titulo_cliente
            // 
            this.lbl_titulo_cliente.AutoSize = true;
            this.lbl_titulo_cliente.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_cliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.lbl_titulo_cliente.Location = new System.Drawing.Point(72, 43);
            this.lbl_titulo_cliente.Name = "lbl_titulo_cliente";
            this.lbl_titulo_cliente.Size = new System.Drawing.Size(218, 32);
            this.lbl_titulo_cliente.TabIndex = 59;
            this.lbl_titulo_cliente.Text = "Inicio de Sesión";
            // 
            // txt_usuario_sesion
            // 
            this.txt_usuario_sesion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario_sesion.Location = new System.Drawing.Point(74, 157);
            this.txt_usuario_sesion.Name = "txt_usuario_sesion";
            this.txt_usuario_sesion.Size = new System.Drawing.Size(216, 23);
            this.txt_usuario_sesion.TabIndex = 1;
            this.txt_usuario_sesion.TextChanged += new System.EventHandler(this.txt_usuario_sesion_TextChanged);
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(74, 240);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(216, 23);
            this.txt_password.TabIndex = 2;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            // 
            // lbl_usuario_sesion
            // 
            this.lbl_usuario_sesion.AutoSize = true;
            this.lbl_usuario_sesion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario_sesion.Location = new System.Drawing.Point(71, 120);
            this.lbl_usuario_sesion.Name = "lbl_usuario_sesion";
            this.lbl_usuario_sesion.Size = new System.Drawing.Size(62, 18);
            this.lbl_usuario_sesion.TabIndex = 68;
            this.lbl_usuario_sesion.Text = "Usuario";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(71, 208);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(93, 18);
            this.lbl_password.TabIndex = 68;
            this.lbl_password.Text = "Contraseña";
            // 
            // btn_iniciar_sesion
            // 
            this.btn_iniciar_sesion.Enabled = false;
            this.btn_iniciar_sesion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_iniciar_sesion.FlatAppearance.BorderSize = 2;
            this.btn_iniciar_sesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iniciar_sesion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iniciar_sesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_iniciar_sesion.Location = new System.Drawing.Point(71, 315);
            this.btn_iniciar_sesion.Name = "btn_iniciar_sesion";
            this.btn_iniciar_sesion.Size = new System.Drawing.Size(200, 40);
            this.btn_iniciar_sesion.TabIndex = 3;
            this.btn_iniciar_sesion.Text = "Iniciar Sesión";
            this.btn_iniciar_sesion.UseVisualStyleBackColor = true;
            this.btn_iniciar_sesion.Click += new System.EventHandler(this.btn_iniciar_sesion_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_salir.FlatAppearance.BorderSize = 2;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_salir.Location = new System.Drawing.Point(119, 378);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(104, 40);
            this.btn_salir.TabIndex = 4;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // lbl_id_usuario
            // 
            this.lbl_id_usuario.AutoSize = true;
            this.lbl_id_usuario.Location = new System.Drawing.Point(68, 93);
            this.lbl_id_usuario.Name = "lbl_id_usuario";
            this.lbl_id_usuario.Size = new System.Drawing.Size(60, 13);
            this.lbl_id_usuario.TabIndex = 69;
            this.lbl_id_usuario.Text = "ID_Usuario";
            this.lbl_id_usuario.Visible = false;
            this.lbl_id_usuario.TextChanged += new System.EventHandler(this.lbl_id_usuario_TextChanged);
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Location = new System.Drawing.Point(170, 93);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(53, 13);
            this.lbl_pass.TabIndex = 69;
            this.lbl_pass.Text = "Password";
            this.lbl_pass.Visible = false;
            this.lbl_pass.Click += new System.EventHandler(this.lbl_pass_Click);
            // 
            // lbl_tipo_acceso
            // 
            this.lbl_tipo_acceso.AutoSize = true;
            this.lbl_tipo_acceso.Location = new System.Drawing.Point(254, 93);
            this.lbl_tipo_acceso.Name = "lbl_tipo_acceso";
            this.lbl_tipo_acceso.Size = new System.Drawing.Size(70, 13);
            this.lbl_tipo_acceso.TabIndex = 69;
            this.lbl_tipo_acceso.Text = "Tipo_Acceso";
            this.lbl_tipo_acceso.Visible = false;
            // 
            // txt_encriptado
            // 
            this.txt_encriptado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_encriptado.Location = new System.Drawing.Point(74, 269);
            this.txt_encriptado.Name = "txt_encriptado";
            this.txt_encriptado.PasswordChar = '*';
            this.txt_encriptado.Size = new System.Drawing.Size(216, 23);
            this.txt_encriptado.TabIndex = 2;
            this.txt_encriptado.Visible = false;
            this.txt_encriptado.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            // 
            // frm_inicio_sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(363, 474);
            this.Controls.Add(this.lbl_tipo_acceso);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_id_usuario);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_iniciar_sesion);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_usuario_sesion);
            this.Controls.Add(this.txt_encriptado);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_usuario_sesion);
            this.Controls.Add(this.lbl_titulo_cliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_inicio_sesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN EMDPSYS";
            this.Load += new System.EventHandler(this.frm_inicio_sesion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo_cliente;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_usuario_sesion;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Button btn_iniciar_sesion;
        private System.Windows.Forms.Button btn_salir;
        public System.Windows.Forms.Label lbl_id_usuario;
        public System.Windows.Forms.Label lbl_pass;
        public System.Windows.Forms.Label lbl_tipo_acceso;
        public System.Windows.Forms.TextBox txt_usuario_sesion;
        private System.Windows.Forms.TextBox txt_encriptado;
    }
}