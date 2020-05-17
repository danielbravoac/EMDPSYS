namespace Ventana_Inicial
{
    partial class frm_proveedor
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
            this.lbl_control_proveedor = new System.Windows.Forms.Label();
            this.btn_actualizar_proveedor = new System.Windows.Forms.Button();
            this.btn_registrar_proveedor = new System.Windows.Forms.Button();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.lbl_razon_social = new System.Windows.Forms.Label();
            this.lbl_ruc = new System.Windows.Forms.Label();
            this.txt_email_proveedor = new System.Windows.Forms.TextBox();
            this.txt_direccion_proveedor = new System.Windows.Forms.TextBox();
            this.txt_razon_social = new System.Windows.Forms.TextBox();
            this.txt_nombre_contacto = new System.Windows.Forms.TextBox();
            this.lbl_nombre_contacto = new System.Windows.Forms.Label();
            this.txt_nombre_comercial = new System.Windows.Forms.TextBox();
            this.lbl_nombre_comercial = new System.Windows.Forms.Label();
            this.pic_volver = new System.Windows.Forms.PictureBox();
            this.lbl_id_proveedor = new System.Windows.Forms.Label();
            this.txt_ruc_proveedor = new System.Windows.Forms.TextBox();
            this.txt_telefono_proveedor = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_volver)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_control_proveedor
            // 
            this.lbl_control_proveedor.AutoSize = true;
            this.lbl_control_proveedor.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_control_proveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.lbl_control_proveedor.Location = new System.Drawing.Point(392, 35);
            this.lbl_control_proveedor.Name = "lbl_control_proveedor";
            this.lbl_control_proveedor.Size = new System.Drawing.Size(269, 32);
            this.lbl_control_proveedor.TabIndex = 58;
            this.lbl_control_proveedor.Text = "[Control] Proveedor";
            // 
            // btn_actualizar_proveedor
            // 
            this.btn_actualizar_proveedor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_actualizar_proveedor.FlatAppearance.BorderSize = 2;
            this.btn_actualizar_proveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizar_proveedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar_proveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_actualizar_proveedor.Location = new System.Drawing.Point(730, 509);
            this.btn_actualizar_proveedor.Name = "btn_actualizar_proveedor";
            this.btn_actualizar_proveedor.Size = new System.Drawing.Size(200, 45);
            this.btn_actualizar_proveedor.TabIndex = 8;
            this.btn_actualizar_proveedor.Text = "Actualizar Proveedor";
            this.btn_actualizar_proveedor.UseVisualStyleBackColor = true;
            this.btn_actualizar_proveedor.Click += new System.EventHandler(this.btn_actualizar_proveedor_Click);
            // 
            // btn_registrar_proveedor
            // 
            this.btn_registrar_proveedor.Enabled = false;
            this.btn_registrar_proveedor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_registrar_proveedor.FlatAppearance.BorderSize = 2;
            this.btn_registrar_proveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar_proveedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar_proveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_registrar_proveedor.Location = new System.Drawing.Point(730, 509);
            this.btn_registrar_proveedor.Name = "btn_registrar_proveedor";
            this.btn_registrar_proveedor.Size = new System.Drawing.Size(200, 45);
            this.btn_registrar_proveedor.TabIndex = 8;
            this.btn_registrar_proveedor.Text = "Registrar Proveedor";
            this.btn_registrar_proveedor.UseVisualStyleBackColor = true;
            this.btn_registrar_proveedor.Click += new System.EventHandler(this.btn_registrar_proveedor_Click);
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(276, 404);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(48, 18);
            this.lbl_email.TabIndex = 52;
            this.lbl_email.Text = "Email";
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefono.Location = new System.Drawing.Point(253, 361);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(71, 18);
            this.lbl_telefono.TabIndex = 51;
            this.lbl_telefono.Text = "Telefono";
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_direccion.Location = new System.Drawing.Point(243, 282);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(81, 18);
            this.lbl_direccion.TabIndex = 49;
            this.lbl_direccion.Text = "Direccion";
            // 
            // lbl_razon_social
            // 
            this.lbl_razon_social.AutoSize = true;
            this.lbl_razon_social.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_razon_social.Location = new System.Drawing.Point(221, 204);
            this.lbl_razon_social.Name = "lbl_razon_social";
            this.lbl_razon_social.Size = new System.Drawing.Size(103, 18);
            this.lbl_razon_social.TabIndex = 47;
            this.lbl_razon_social.Text = "Razón Social";
            // 
            // lbl_ruc
            // 
            this.lbl_ruc.AutoSize = true;
            this.lbl_ruc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ruc.Location = new System.Drawing.Point(285, 164);
            this.lbl_ruc.Name = "lbl_ruc";
            this.lbl_ruc.Size = new System.Drawing.Size(39, 18);
            this.lbl_ruc.TabIndex = 46;
            this.lbl_ruc.Text = "RUC";
            // 
            // txt_email_proveedor
            // 
            this.txt_email_proveedor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email_proveedor.Location = new System.Drawing.Point(343, 398);
            this.txt_email_proveedor.Name = "txt_email_proveedor";
            this.txt_email_proveedor.Size = new System.Drawing.Size(587, 23);
            this.txt_email_proveedor.TabIndex = 7;
            // 
            // txt_direccion_proveedor
            // 
            this.txt_direccion_proveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_direccion_proveedor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_direccion_proveedor.Location = new System.Drawing.Point(343, 281);
            this.txt_direccion_proveedor.Name = "txt_direccion_proveedor";
            this.txt_direccion_proveedor.Size = new System.Drawing.Size(587, 23);
            this.txt_direccion_proveedor.TabIndex = 4;
            // 
            // txt_razon_social
            // 
            this.txt_razon_social.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_razon_social.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_razon_social.Location = new System.Drawing.Point(343, 203);
            this.txt_razon_social.Name = "txt_razon_social";
            this.txt_razon_social.Size = new System.Drawing.Size(587, 23);
            this.txt_razon_social.TabIndex = 2;
            this.txt_razon_social.TabIndexChanged += new System.EventHandler(this.txt_razon_social_TabIndexChanged);
            // 
            // txt_nombre_contacto
            // 
            this.txt_nombre_contacto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nombre_contacto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_contacto.Location = new System.Drawing.Point(343, 320);
            this.txt_nombre_contacto.Name = "txt_nombre_contacto";
            this.txt_nombre_contacto.Size = new System.Drawing.Size(587, 23);
            this.txt_nombre_contacto.TabIndex = 5;
            // 
            // lbl_nombre_contacto
            // 
            this.lbl_nombre_contacto.AutoSize = true;
            this.lbl_nombre_contacto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_contacto.Location = new System.Drawing.Point(159, 321);
            this.lbl_nombre_contacto.Name = "lbl_nombre_contacto";
            this.lbl_nombre_contacto.Size = new System.Drawing.Size(165, 18);
            this.lbl_nombre_contacto.TabIndex = 47;
            this.lbl_nombre_contacto.Text = "Nombre de Contacto";
            // 
            // txt_nombre_comercial
            // 
            this.txt_nombre_comercial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nombre_comercial.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_comercial.Location = new System.Drawing.Point(343, 244);
            this.txt_nombre_comercial.Name = "txt_nombre_comercial";
            this.txt_nombre_comercial.Size = new System.Drawing.Size(587, 23);
            this.txt_nombre_comercial.TabIndex = 3;
            this.txt_nombre_comercial.TextChanged += new System.EventHandler(this.txt_nombre_comercial_TextChanged);
            // 
            // lbl_nombre_comercial
            // 
            this.lbl_nombre_comercial.AutoSize = true;
            this.lbl_nombre_comercial.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_comercial.Location = new System.Drawing.Point(173, 245);
            this.lbl_nombre_comercial.Name = "lbl_nombre_comercial";
            this.lbl_nombre_comercial.Size = new System.Drawing.Size(151, 18);
            this.lbl_nombre_comercial.TabIndex = 52;
            this.lbl_nombre_comercial.Text = "Nombre Comercial";
            // 
            // pic_volver
            // 
            this.pic_volver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_volver.Image = global::Ventana_Inicial.Properties.Resources.Atras;
            this.pic_volver.Location = new System.Drawing.Point(88, 35);
            this.pic_volver.Name = "pic_volver";
            this.pic_volver.Size = new System.Drawing.Size(20, 32);
            this.pic_volver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_volver.TabIndex = 59;
            this.pic_volver.TabStop = false;
            this.pic_volver.Click += new System.EventHandler(this.pic_volver_Click);
            // 
            // lbl_id_proveedor
            // 
            this.lbl_id_proveedor.AutoSize = true;
            this.lbl_id_proveedor.Location = new System.Drawing.Point(343, 130);
            this.lbl_id_proveedor.Name = "lbl_id_proveedor";
            this.lbl_id_proveedor.Size = new System.Drawing.Size(73, 13);
            this.lbl_id_proveedor.TabIndex = 60;
            this.lbl_id_proveedor.Text = "ID_Proveedor";
            this.lbl_id_proveedor.Visible = false;
            // 
            // txt_ruc_proveedor
            // 
            this.txt_ruc_proveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_ruc_proveedor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ruc_proveedor.Location = new System.Drawing.Point(343, 159);
            this.txt_ruc_proveedor.Name = "txt_ruc_proveedor";
            this.txt_ruc_proveedor.Size = new System.Drawing.Size(205, 23);
            this.txt_ruc_proveedor.TabIndex = 1;
            this.txt_ruc_proveedor.TabIndexChanged += new System.EventHandler(this.txt_ruc_proveedor_TabIndexChanged);
            this.txt_ruc_proveedor.TextChanged += new System.EventHandler(this.Txt_ruc_proveedor_TextChanged);
            this.txt_ruc_proveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_ruc_proveedor_KeyPress);
            // 
            // txt_telefono_proveedor
            // 
            this.txt_telefono_proveedor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono_proveedor.HideSelection = false;
            this.txt_telefono_proveedor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_telefono_proveedor.Location = new System.Drawing.Point(346, 360);
            this.txt_telefono_proveedor.Mask = "(+00)000-000-000-00000";
            this.txt_telefono_proveedor.Name = "txt_telefono_proveedor";
            this.txt_telefono_proveedor.Size = new System.Drawing.Size(318, 23);
            this.txt_telefono_proveedor.SkipLiterals = false;
            this.txt_telefono_proveedor.TabIndex = 61;
            this.txt_telefono_proveedor.TextChanged += new System.EventHandler(this.txt_telefono_proveedor_TextChanged_1);
            // 
            // frm_proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.txt_telefono_proveedor);
            this.Controls.Add(this.lbl_id_proveedor);
            this.Controls.Add(this.pic_volver);
            this.Controls.Add(this.lbl_control_proveedor);
            this.Controls.Add(this.btn_actualizar_proveedor);
            this.Controls.Add(this.btn_registrar_proveedor);
            this.Controls.Add(this.lbl_nombre_comercial);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_telefono);
            this.Controls.Add(this.lbl_direccion);
            this.Controls.Add(this.lbl_nombre_contacto);
            this.Controls.Add(this.lbl_razon_social);
            this.Controls.Add(this.lbl_ruc);
            this.Controls.Add(this.txt_nombre_comercial);
            this.Controls.Add(this.txt_email_proveedor);
            this.Controls.Add(this.txt_direccion_proveedor);
            this.Controls.Add(this.txt_ruc_proveedor);
            this.Controls.Add(this.txt_nombre_contacto);
            this.Controls.Add(this.txt_razon_social);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_proveedor";
            this.Text = "Nuevo_Proveedor";
            this.Load += new System.EventHandler(this.frm_proveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_volver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_volver;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.Label lbl_razon_social;
        private System.Windows.Forms.Label lbl_ruc;
        private System.Windows.Forms.Label lbl_nombre_contacto;
        private System.Windows.Forms.Label lbl_nombre_comercial;
        public System.Windows.Forms.TextBox txt_email_proveedor;
        public System.Windows.Forms.TextBox txt_direccion_proveedor;
        public System.Windows.Forms.TextBox txt_razon_social;
        public System.Windows.Forms.TextBox txt_nombre_contacto;
        public System.Windows.Forms.TextBox txt_nombre_comercial;
        public System.Windows.Forms.Label lbl_id_proveedor;
        public System.Windows.Forms.Button btn_actualizar_proveedor;
        public System.Windows.Forms.Button btn_registrar_proveedor;
        public System.Windows.Forms.Label lbl_control_proveedor;
        public System.Windows.Forms.TextBox txt_ruc_proveedor;
        public System.Windows.Forms.MaskedTextBox txt_telefono_proveedor;
    }
}