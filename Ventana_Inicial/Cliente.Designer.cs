namespace Ventana_Inicial
{
    partial class frm_cliente
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
            this.lbl_control_cliente = new System.Windows.Forms.Label();
            this.btn_actualizar_cliente = new System.Windows.Forms.Button();
            this.btn_registrar_cliente = new System.Windows.Forms.Button();
            this.cbo_sexo = new System.Windows.Forms.ComboBox();
            this.lbl_familia = new System.Windows.Forms.Label();
            this.lbl_ocasion = new System.Windows.Forms.Label();
            this.lbl_subcategoria = new System.Windows.Forms.Label();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.lbl_precio_venta = new System.Windows.Forms.Label();
            this.lbl_detalle_diferencial = new System.Windows.Forms.Label();
            this.lbl_numero_documento = new System.Windows.Forms.Label();
            this.txt_nombre_cliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_tipo_documento = new System.Windows.Forms.ComboBox();
            this.txt_direccion_cliente = new System.Windows.Forms.TextBox();
            this.dtp_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.txt_email_cliente = new System.Windows.Forms.TextBox();
            this.pic_volver = new System.Windows.Forms.PictureBox();
            this.lbl_id_cliente = new System.Windows.Forms.Label();
            this.txt_documento_cliente = new System.Windows.Forms.TextBox();
            this.txt_telefono_cliente = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_volver)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_control_cliente
            // 
            this.lbl_control_cliente.AutoSize = true;
            this.lbl_control_cliente.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_control_cliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.lbl_control_cliente.Location = new System.Drawing.Point(398, 35);
            this.lbl_control_cliente.Name = "lbl_control_cliente";
            this.lbl_control_cliente.Size = new System.Drawing.Size(226, 32);
            this.lbl_control_cliente.TabIndex = 37;
            this.lbl_control_cliente.Text = "[Control] Cliente";
            // 
            // btn_actualizar_cliente
            // 
            this.btn_actualizar_cliente.Enabled = false;
            this.btn_actualizar_cliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_actualizar_cliente.FlatAppearance.BorderSize = 2;
            this.btn_actualizar_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizar_cliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar_cliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_actualizar_cliente.Location = new System.Drawing.Point(768, 510);
            this.btn_actualizar_cliente.Name = "btn_actualizar_cliente";
            this.btn_actualizar_cliente.Size = new System.Drawing.Size(200, 45);
            this.btn_actualizar_cliente.TabIndex = 9;
            this.btn_actualizar_cliente.Text = "Actualizar Cliente";
            this.btn_actualizar_cliente.UseVisualStyleBackColor = true;
            this.btn_actualizar_cliente.Click += new System.EventHandler(this.btn_actualizar_cliente_Click);
            // 
            // btn_registrar_cliente
            // 
            this.btn_registrar_cliente.Enabled = false;
            this.btn_registrar_cliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_registrar_cliente.FlatAppearance.BorderSize = 2;
            this.btn_registrar_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar_cliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar_cliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_registrar_cliente.Location = new System.Drawing.Point(768, 510);
            this.btn_registrar_cliente.Name = "btn_registrar_cliente";
            this.btn_registrar_cliente.Size = new System.Drawing.Size(200, 45);
            this.btn_registrar_cliente.TabIndex = 9;
            this.btn_registrar_cliente.Text = "Registrar Cliente";
            this.btn_registrar_cliente.UseVisualStyleBackColor = true;
            this.btn_registrar_cliente.Click += new System.EventHandler(this.btn_registrar_cliente_Click);
            // 
            // cbo_sexo
            // 
            this.cbo_sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_sexo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_sexo.FormattingEnabled = true;
            this.cbo_sexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Empresa"});
            this.cbo_sexo.Location = new System.Drawing.Point(381, 422);
            this.cbo_sexo.Name = "cbo_sexo";
            this.cbo_sexo.Size = new System.Drawing.Size(216, 28);
            this.cbo_sexo.TabIndex = 8;
            // 
            // lbl_familia
            // 
            this.lbl_familia.AutoSize = true;
            this.lbl_familia.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_familia.Location = new System.Drawing.Point(299, 425);
            this.lbl_familia.Name = "lbl_familia";
            this.lbl_familia.Size = new System.Drawing.Size(44, 18);
            this.lbl_familia.TabIndex = 24;
            this.lbl_familia.Text = "Sexo";
            // 
            // lbl_ocasion
            // 
            this.lbl_ocasion.AutoSize = true;
            this.lbl_ocasion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ocasion.Location = new System.Drawing.Point(295, 385);
            this.lbl_ocasion.Name = "lbl_ocasion";
            this.lbl_ocasion.Size = new System.Drawing.Size(48, 18);
            this.lbl_ocasion.TabIndex = 23;
            this.lbl_ocasion.Text = "Email";
            // 
            // lbl_subcategoria
            // 
            this.lbl_subcategoria.AutoSize = true;
            this.lbl_subcategoria.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subcategoria.Location = new System.Drawing.Point(272, 345);
            this.lbl_subcategoria.Name = "lbl_subcategoria";
            this.lbl_subcategoria.Size = new System.Drawing.Size(71, 18);
            this.lbl_subcategoria.TabIndex = 22;
            this.lbl_subcategoria.Text = "Teléfono";
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_direccion.Location = new System.Drawing.Point(262, 265);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(81, 18);
            this.lbl_direccion.TabIndex = 21;
            this.lbl_direccion.Text = "Dirección";
            // 
            // lbl_precio_venta
            // 
            this.lbl_precio_venta.AutoSize = true;
            this.lbl_precio_venta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio_venta.Location = new System.Drawing.Point(175, 305);
            this.lbl_precio_venta.Name = "lbl_precio_venta";
            this.lbl_precio_venta.Size = new System.Drawing.Size(168, 18);
            this.lbl_precio_venta.TabIndex = 17;
            this.lbl_precio_venta.Text = "Fecha de Nacimiento";
            // 
            // lbl_detalle_diferencial
            // 
            this.lbl_detalle_diferencial.AutoSize = true;
            this.lbl_detalle_diferencial.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_detalle_diferencial.Location = new System.Drawing.Point(162, 225);
            this.lbl_detalle_diferencial.Name = "lbl_detalle_diferencial";
            this.lbl_detalle_diferencial.Size = new System.Drawing.Size(181, 18);
            this.lbl_detalle_diferencial.TabIndex = 16;
            this.lbl_detalle_diferencial.Text = "Nombre o Razón Social";
            // 
            // lbl_numero_documento
            // 
            this.lbl_numero_documento.AutoSize = true;
            this.lbl_numero_documento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numero_documento.Location = new System.Drawing.Point(161, 185);
            this.lbl_numero_documento.Name = "lbl_numero_documento";
            this.lbl_numero_documento.Size = new System.Drawing.Size(182, 18);
            this.lbl_numero_documento.TabIndex = 15;
            this.lbl_numero_documento.Text = "Número de Documento";
            // 
            // txt_nombre_cliente
            // 
            this.txt_nombre_cliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nombre_cliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_cliente.Location = new System.Drawing.Point(381, 227);
            this.txt_nombre_cliente.Name = "txt_nombre_cliente";
            this.txt_nombre_cliente.Size = new System.Drawing.Size(587, 23);
            this.txt_nombre_cliente.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tipo de Documento";
            // 
            // cbo_tipo_documento
            // 
            this.cbo_tipo_documento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tipo_documento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_tipo_documento.FormattingEnabled = true;
            this.cbo_tipo_documento.Items.AddRange(new object[] {
            "DNI",
            "RUC",
            "Pasaporte"});
            this.cbo_tipo_documento.Location = new System.Drawing.Point(381, 141);
            this.cbo_tipo_documento.Name = "cbo_tipo_documento";
            this.cbo_tipo_documento.Size = new System.Drawing.Size(216, 28);
            this.cbo_tipo_documento.TabIndex = 1;
            this.cbo_tipo_documento.SelectedIndexChanged += new System.EventHandler(this.cbo_tipo_documento_SelectedIndexChanged);
            // 
            // txt_direccion_cliente
            // 
            this.txt_direccion_cliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_direccion_cliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_direccion_cliente.Location = new System.Drawing.Point(381, 265);
            this.txt_direccion_cliente.Name = "txt_direccion_cliente";
            this.txt_direccion_cliente.Size = new System.Drawing.Size(587, 23);
            this.txt_direccion_cliente.TabIndex = 4;
            // 
            // dtp_nacimiento
            // 
            this.dtp_nacimiento.CalendarFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_nacimiento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_nacimiento.Location = new System.Drawing.Point(381, 303);
            this.dtp_nacimiento.Name = "dtp_nacimiento";
            this.dtp_nacimiento.Size = new System.Drawing.Size(128, 26);
            this.dtp_nacimiento.TabIndex = 5;
            // 
            // txt_email_cliente
            // 
            this.txt_email_cliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email_cliente.Location = new System.Drawing.Point(381, 382);
            this.txt_email_cliente.Name = "txt_email_cliente";
            this.txt_email_cliente.Size = new System.Drawing.Size(587, 23);
            this.txt_email_cliente.TabIndex = 7;
            // 
            // pic_volver
            // 
            this.pic_volver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_volver.Image = global::Ventana_Inicial.Properties.Resources.Atras;
            this.pic_volver.Location = new System.Drawing.Point(94, 35);
            this.pic_volver.Name = "pic_volver";
            this.pic_volver.Size = new System.Drawing.Size(20, 32);
            this.pic_volver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_volver.TabIndex = 39;
            this.pic_volver.TabStop = false;
            this.pic_volver.Click += new System.EventHandler(this.pic_volver_Click);
            // 
            // lbl_id_cliente
            // 
            this.lbl_id_cliente.AutoSize = true;
            this.lbl_id_cliente.Location = new System.Drawing.Point(378, 110);
            this.lbl_id_cliente.Name = "lbl_id_cliente";
            this.lbl_id_cliente.Size = new System.Drawing.Size(56, 13);
            this.lbl_id_cliente.TabIndex = 40;
            this.lbl_id_cliente.Text = "ID_Cliente";
            this.lbl_id_cliente.Visible = false;
            // 
            // txt_documento_cliente
            // 
            this.txt_documento_cliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_documento_cliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_documento_cliente.Location = new System.Drawing.Point(381, 188);
            this.txt_documento_cliente.Name = "txt_documento_cliente";
            this.txt_documento_cliente.Size = new System.Drawing.Size(216, 23);
            this.txt_documento_cliente.TabIndex = 2;
            this.txt_documento_cliente.TextChanged += new System.EventHandler(this.txt_documento_cliente_TextChanged);
            this.txt_documento_cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_documento_cliente_KeyPress);
            // 
            // txt_telefono_cliente
            // 
            this.txt_telefono_cliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono_cliente.HideSelection = false;
            this.txt_telefono_cliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_telefono_cliente.Location = new System.Drawing.Point(381, 345);
            this.txt_telefono_cliente.Mask = "(+00)000-000-000-00000";
            this.txt_telefono_cliente.Name = "txt_telefono_cliente";
            this.txt_telefono_cliente.Size = new System.Drawing.Size(318, 23);
            this.txt_telefono_cliente.SkipLiterals = false;
            this.txt_telefono_cliente.TabIndex = 6;
            this.txt_telefono_cliente.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txt_telefono_cliente_MaskInputRejected);
            this.txt_telefono_cliente.TextChanged += new System.EventHandler(this.txt_telefono_cliente_TextChanged_1);
            // 
            // frm_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.txt_telefono_cliente);
            this.Controls.Add(this.lbl_id_cliente);
            this.Controls.Add(this.dtp_nacimiento);
            this.Controls.Add(this.pic_volver);
            this.Controls.Add(this.lbl_control_cliente);
            this.Controls.Add(this.btn_actualizar_cliente);
            this.Controls.Add(this.btn_registrar_cliente);
            this.Controls.Add(this.cbo_sexo);
            this.Controls.Add(this.cbo_tipo_documento);
            this.Controls.Add(this.lbl_familia);
            this.Controls.Add(this.lbl_ocasion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_subcategoria);
            this.Controls.Add(this.lbl_direccion);
            this.Controls.Add(this.lbl_precio_venta);
            this.Controls.Add(this.lbl_detalle_diferencial);
            this.Controls.Add(this.lbl_numero_documento);
            this.Controls.Add(this.txt_email_cliente);
            this.Controls.Add(this.txt_direccion_cliente);
            this.Controls.Add(this.txt_nombre_cliente);
            this.Controls.Add(this.txt_documento_cliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_cliente";
            this.Text = "Nuevo_Cliente";
            this.Load += new System.EventHandler(this.frm_cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_volver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_volver;
        private System.Windows.Forms.Label lbl_familia;
        private System.Windows.Forms.Label lbl_ocasion;
        private System.Windows.Forms.Label lbl_subcategoria;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.Label lbl_precio_venta;
        private System.Windows.Forms.Label lbl_detalle_diferencial;
        private System.Windows.Forms.Label lbl_numero_documento;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lbl_control_cliente;
        public System.Windows.Forms.ComboBox cbo_sexo;
        public System.Windows.Forms.TextBox txt_nombre_cliente;
        public System.Windows.Forms.ComboBox cbo_tipo_documento;
        public System.Windows.Forms.TextBox txt_direccion_cliente;
        public System.Windows.Forms.DateTimePicker dtp_nacimiento;
        public System.Windows.Forms.TextBox txt_email_cliente;
        public System.Windows.Forms.Label lbl_id_cliente;
        public System.Windows.Forms.TextBox txt_documento_cliente;
        public System.Windows.Forms.Button btn_actualizar_cliente;
        public System.Windows.Forms.Button btn_registrar_cliente;
        public System.Windows.Forms.MaskedTextBox txt_telefono_cliente;
    }
}