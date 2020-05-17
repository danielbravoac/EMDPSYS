namespace Ventana_Inicial
{
    partial class frm_empleado
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
            this.pic_volver = new System.Windows.Forms.PictureBox();
            this.lbl_control_empleado = new System.Windows.Forms.Label();
            this.btn_registrar_empleado = new System.Windows.Forms.Button();
            this.lbl_fecha_nacimiento = new System.Windows.Forms.Label();
            this.lbl_nivel_seguridad = new System.Windows.Forms.Label();
            this.lbl_contrasena = new System.Windows.Forms.Label();
            this.lbl_fecha_contrato = new System.Windows.Forms.Label();
            this.lbl_sueldo = new System.Windows.Forms.Label();
            this.lbl_nombre_empleado = new System.Windows.Forms.Label();
            this.lbl_numero_documento = new System.Windows.Forms.Label();
            this.txt_contrasena = new System.Windows.Forms.TextBox();
            this.txt_nombre_empleado = new System.Windows.Forms.TextBox();
            this.dtp_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.dtp_contrato = new System.Windows.Forms.DateTimePicker();
            this.lbl_sexo = new System.Windows.Forms.Label();
            this.cbo_sexo = new System.Windows.Forms.ComboBox();
            this.cbo_nivel_seguridad = new System.Windows.Forms.ComboBox();
            this.lbl_estado_empleado = new System.Windows.Forms.Label();
            this.cbo_estado_empleado = new System.Windows.Forms.ComboBox();
            this.lbl_cargo = new System.Windows.Forms.Label();
            this.cbo_cargo = new System.Windows.Forms.ComboBox();
            this.nud_sueldo = new System.Windows.Forms.NumericUpDown();
            this.lbl_id_empleado = new System.Windows.Forms.Label();
            this.btn_actualizar_empleado = new System.Windows.Forms.Button();
            this.txt_dni_empleado = new System.Windows.Forms.TextBox();
            this.txt_encriptado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_volver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_sueldo)).BeginInit();
            this.SuspendLayout();
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
            // lbl_control_empleado
            // 
            this.lbl_control_empleado.AutoSize = true;
            this.lbl_control_empleado.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_control_empleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.lbl_control_empleado.Location = new System.Drawing.Point(392, 35);
            this.lbl_control_empleado.Name = "lbl_control_empleado";
            this.lbl_control_empleado.Size = new System.Drawing.Size(268, 32);
            this.lbl_control_empleado.TabIndex = 58;
            this.lbl_control_empleado.Text = "[Control] Empleado";
            // 
            // btn_registrar_empleado
            // 
            this.btn_registrar_empleado.Enabled = false;
            this.btn_registrar_empleado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_registrar_empleado.FlatAppearance.BorderSize = 2;
            this.btn_registrar_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar_empleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar_empleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_registrar_empleado.Location = new System.Drawing.Point(767, 497);
            this.btn_registrar_empleado.Name = "btn_registrar_empleado";
            this.btn_registrar_empleado.Size = new System.Drawing.Size(200, 45);
            this.btn_registrar_empleado.TabIndex = 11;
            this.btn_registrar_empleado.Text = "Registrar Empleado";
            this.btn_registrar_empleado.UseVisualStyleBackColor = true;
            this.btn_registrar_empleado.Click += new System.EventHandler(this.btn_registrar_empleado_Click);
            // 
            // lbl_fecha_nacimiento
            // 
            this.lbl_fecha_nacimiento.AutoSize = true;
            this.lbl_fecha_nacimiento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_nacimiento.Location = new System.Drawing.Point(150, 206);
            this.lbl_fecha_nacimiento.Name = "lbl_fecha_nacimiento";
            this.lbl_fecha_nacimiento.Size = new System.Drawing.Size(172, 18);
            this.lbl_fecha_nacimiento.TabIndex = 72;
            this.lbl_fecha_nacimiento.Text = "Fecha  de Nacimiento";
            // 
            // lbl_nivel_seguridad
            // 
            this.lbl_nivel_seguridad.AutoSize = true;
            this.lbl_nivel_seguridad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nivel_seguridad.Location = new System.Drawing.Point(114, 407);
            this.lbl_nivel_seguridad.Name = "lbl_nivel_seguridad";
            this.lbl_nivel_seguridad.Size = new System.Drawing.Size(208, 18);
            this.lbl_nivel_seguridad.TabIndex = 73;
            this.lbl_nivel_seguridad.Text = "Nivel de Acceso al Sistema";
            // 
            // lbl_contrasena
            // 
            this.lbl_contrasena.AutoSize = true;
            this.lbl_contrasena.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contrasena.Location = new System.Drawing.Point(229, 360);
            this.lbl_contrasena.Name = "lbl_contrasena";
            this.lbl_contrasena.Size = new System.Drawing.Size(93, 18);
            this.lbl_contrasena.TabIndex = 71;
            this.lbl_contrasena.Text = "Contraseña";
            // 
            // lbl_fecha_contrato
            // 
            this.lbl_fecha_contrato.AutoSize = true;
            this.lbl_fecha_contrato.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_contrato.Location = new System.Drawing.Point(176, 281);
            this.lbl_fecha_contrato.Name = "lbl_fecha_contrato";
            this.lbl_fecha_contrato.Size = new System.Drawing.Size(146, 18);
            this.lbl_fecha_contrato.TabIndex = 70;
            this.lbl_fecha_contrato.Text = "Fecha de Contrato";
            // 
            // lbl_sueldo
            // 
            this.lbl_sueldo.AutoSize = true;
            this.lbl_sueldo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sueldo.Location = new System.Drawing.Point(263, 320);
            this.lbl_sueldo.Name = "lbl_sueldo";
            this.lbl_sueldo.Size = new System.Drawing.Size(59, 18);
            this.lbl_sueldo.TabIndex = 68;
            this.lbl_sueldo.Text = "Sueldo";
            // 
            // lbl_nombre_empleado
            // 
            this.lbl_nombre_empleado.AutoSize = true;
            this.lbl_nombre_empleado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_empleado.Location = new System.Drawing.Point(146, 165);
            this.lbl_nombre_empleado.Name = "lbl_nombre_empleado";
            this.lbl_nombre_empleado.Size = new System.Drawing.Size(176, 18);
            this.lbl_nombre_empleado.TabIndex = 69;
            this.lbl_nombre_empleado.Text = "Nombre del Empleado";
            // 
            // lbl_numero_documento
            // 
            this.lbl_numero_documento.AutoSize = true;
            this.lbl_numero_documento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numero_documento.Location = new System.Drawing.Point(140, 125);
            this.lbl_numero_documento.Name = "lbl_numero_documento";
            this.lbl_numero_documento.Size = new System.Drawing.Size(182, 18);
            this.lbl_numero_documento.TabIndex = 67;
            this.lbl_numero_documento.Text = "Numero de Documento";
            // 
            // txt_contrasena
            // 
            this.txt_contrasena.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contrasena.Location = new System.Drawing.Point(329, 359);
            this.txt_contrasena.MaxLength = 100;
            this.txt_contrasena.Name = "txt_contrasena";
            this.txt_contrasena.PasswordChar = '■';
            this.txt_contrasena.Size = new System.Drawing.Size(216, 23);
            this.txt_contrasena.TabIndex = 7;
            this.txt_contrasena.TextChanged += new System.EventHandler(this.Txt_contrasena_TextChanged);
            // 
            // txt_nombre_empleado
            // 
            this.txt_nombre_empleado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nombre_empleado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_empleado.Location = new System.Drawing.Point(329, 164);
            this.txt_nombre_empleado.Name = "txt_nombre_empleado";
            this.txt_nombre_empleado.Size = new System.Drawing.Size(587, 23);
            this.txt_nombre_empleado.TabIndex = 2;
            this.txt_nombre_empleado.TextChanged += new System.EventHandler(this.txt_nombre_empleado_TextChanged);
            // 
            // dtp_nacimiento
            // 
            this.dtp_nacimiento.CalendarFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_nacimiento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_nacimiento.Location = new System.Drawing.Point(329, 206);
            this.dtp_nacimiento.Name = "dtp_nacimiento";
            this.dtp_nacimiento.Size = new System.Drawing.Size(120, 26);
            this.dtp_nacimiento.TabIndex = 3;
            // 
            // dtp_contrato
            // 
            this.dtp_contrato.CalendarFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_contrato.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_contrato.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_contrato.Location = new System.Drawing.Point(329, 281);
            this.dtp_contrato.Name = "dtp_contrato";
            this.dtp_contrato.Size = new System.Drawing.Size(120, 26);
            this.dtp_contrato.TabIndex = 5;
            // 
            // lbl_sexo
            // 
            this.lbl_sexo.AutoSize = true;
            this.lbl_sexo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sexo.Location = new System.Drawing.Point(278, 245);
            this.lbl_sexo.Name = "lbl_sexo";
            this.lbl_sexo.Size = new System.Drawing.Size(44, 18);
            this.lbl_sexo.TabIndex = 73;
            this.lbl_sexo.Text = "Sexo";
            // 
            // cbo_sexo
            // 
            this.cbo_sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_sexo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_sexo.FormattingEnabled = true;
            this.cbo_sexo.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.cbo_sexo.Location = new System.Drawing.Point(329, 241);
            this.cbo_sexo.Name = "cbo_sexo";
            this.cbo_sexo.Size = new System.Drawing.Size(305, 28);
            this.cbo_sexo.TabIndex = 4;
            // 
            // cbo_nivel_seguridad
            // 
            this.cbo_nivel_seguridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_nivel_seguridad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_nivel_seguridad.FormattingEnabled = true;
            this.cbo_nivel_seguridad.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Otro",
            "Empresa"});
            this.cbo_nivel_seguridad.Location = new System.Drawing.Point(329, 403);
            this.cbo_nivel_seguridad.Name = "cbo_nivel_seguridad";
            this.cbo_nivel_seguridad.Size = new System.Drawing.Size(305, 28);
            this.cbo_nivel_seguridad.TabIndex = 8;
            // 
            // lbl_estado_empleado
            // 
            this.lbl_estado_empleado.AutoSize = true;
            this.lbl_estado_empleado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estado_empleado.Location = new System.Drawing.Point(162, 449);
            this.lbl_estado_empleado.Name = "lbl_estado_empleado";
            this.lbl_estado_empleado.Size = new System.Drawing.Size(160, 18);
            this.lbl_estado_empleado.TabIndex = 73;
            this.lbl_estado_empleado.Text = "Estado de Empleado";
            // 
            // cbo_estado_empleado
            // 
            this.cbo_estado_empleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_estado_empleado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_estado_empleado.FormattingEnabled = true;
            this.cbo_estado_empleado.Items.AddRange(new object[] {
            "Trabajando",
            "En Recesión",
            "Inactivo"});
            this.cbo_estado_empleado.Location = new System.Drawing.Point(329, 445);
            this.cbo_estado_empleado.Name = "cbo_estado_empleado";
            this.cbo_estado_empleado.Size = new System.Drawing.Size(305, 28);
            this.cbo_estado_empleado.TabIndex = 9;
            // 
            // lbl_cargo
            // 
            this.lbl_cargo.AutoSize = true;
            this.lbl_cargo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cargo.Location = new System.Drawing.Point(173, 497);
            this.lbl_cargo.Name = "lbl_cargo";
            this.lbl_cargo.Size = new System.Drawing.Size(145, 18);
            this.lbl_cargo.TabIndex = 73;
            this.lbl_cargo.Text = "Cargo Empresarial";
            // 
            // cbo_cargo
            // 
            this.cbo_cargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_cargo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_cargo.FormattingEnabled = true;
            this.cbo_cargo.Items.AddRange(new object[] {
            "Administrador",
            "Empleado"});
            this.cbo_cargo.Location = new System.Drawing.Point(329, 493);
            this.cbo_cargo.Name = "cbo_cargo";
            this.cbo_cargo.Size = new System.Drawing.Size(305, 28);
            this.cbo_cargo.TabIndex = 10;
            // 
            // nud_sueldo
            // 
            this.nud_sueldo.DecimalPlaces = 2;
            this.nud_sueldo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_sueldo.Location = new System.Drawing.Point(329, 320);
            this.nud_sueldo.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nud_sueldo.Name = "nud_sueldo";
            this.nud_sueldo.Size = new System.Drawing.Size(120, 26);
            this.nud_sueldo.TabIndex = 6;
            // 
            // lbl_id_empleado
            // 
            this.lbl_id_empleado.AutoSize = true;
            this.lbl_id_empleado.Location = new System.Drawing.Point(326, 97);
            this.lbl_id_empleado.Name = "lbl_id_empleado";
            this.lbl_id_empleado.Size = new System.Drawing.Size(71, 13);
            this.lbl_id_empleado.TabIndex = 77;
            this.lbl_id_empleado.Text = "ID_Empleado";
            this.lbl_id_empleado.Visible = false;
            // 
            // btn_actualizar_empleado
            // 
            this.btn_actualizar_empleado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_actualizar_empleado.FlatAppearance.BorderSize = 2;
            this.btn_actualizar_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizar_empleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar_empleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_actualizar_empleado.Location = new System.Drawing.Point(767, 497);
            this.btn_actualizar_empleado.Name = "btn_actualizar_empleado";
            this.btn_actualizar_empleado.Size = new System.Drawing.Size(200, 45);
            this.btn_actualizar_empleado.TabIndex = 11;
            this.btn_actualizar_empleado.Text = "Actualizar Empleado";
            this.btn_actualizar_empleado.UseVisualStyleBackColor = true;
            this.btn_actualizar_empleado.Click += new System.EventHandler(this.btn_actualizar_empleado_Click);
            // 
            // txt_dni_empleado
            // 
            this.txt_dni_empleado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_dni_empleado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dni_empleado.Location = new System.Drawing.Point(329, 124);
            this.txt_dni_empleado.Name = "txt_dni_empleado";
            this.txt_dni_empleado.Size = new System.Drawing.Size(159, 23);
            this.txt_dni_empleado.TabIndex = 1;
            this.txt_dni_empleado.TextChanged += new System.EventHandler(this.Txt_dni_empleado_TextChanged);
            this.txt_dni_empleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_dni_empleado_KeyPress);
            // 
            // txt_encriptado
            // 
            this.txt_encriptado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_encriptado.Location = new System.Drawing.Point(551, 359);
            this.txt_encriptado.MaxLength = 100;
            this.txt_encriptado.Name = "txt_encriptado";
            this.txt_encriptado.PasswordChar = '■';
            this.txt_encriptado.Size = new System.Drawing.Size(216, 23);
            this.txt_encriptado.TabIndex = 7;
            this.txt_encriptado.Visible = false;
            this.txt_encriptado.TextChanged += new System.EventHandler(this.Txt_contrasena_TextChanged);
            // 
            // frm_empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.lbl_id_empleado);
            this.Controls.Add(this.nud_sueldo);
            this.Controls.Add(this.cbo_cargo);
            this.Controls.Add(this.cbo_estado_empleado);
            this.Controls.Add(this.cbo_nivel_seguridad);
            this.Controls.Add(this.cbo_sexo);
            this.Controls.Add(this.dtp_contrato);
            this.Controls.Add(this.dtp_nacimiento);
            this.Controls.Add(this.lbl_fecha_nacimiento);
            this.Controls.Add(this.lbl_cargo);
            this.Controls.Add(this.lbl_estado_empleado);
            this.Controls.Add(this.lbl_sexo);
            this.Controls.Add(this.lbl_nivel_seguridad);
            this.Controls.Add(this.lbl_contrasena);
            this.Controls.Add(this.lbl_fecha_contrato);
            this.Controls.Add(this.lbl_sueldo);
            this.Controls.Add(this.lbl_nombre_empleado);
            this.Controls.Add(this.lbl_numero_documento);
            this.Controls.Add(this.txt_encriptado);
            this.Controls.Add(this.txt_contrasena);
            this.Controls.Add(this.txt_dni_empleado);
            this.Controls.Add(this.txt_nombre_empleado);
            this.Controls.Add(this.pic_volver);
            this.Controls.Add(this.lbl_control_empleado);
            this.Controls.Add(this.btn_actualizar_empleado);
            this.Controls.Add(this.btn_registrar_empleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_empleado";
            this.Text = "frm_nuevo_empleado";
            this.Load += new System.EventHandler(this.frm_nuevo_empleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_volver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_sueldo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_volver;
        private System.Windows.Forms.Label lbl_fecha_nacimiento;
        private System.Windows.Forms.Label lbl_nivel_seguridad;
        private System.Windows.Forms.Label lbl_contrasena;
        private System.Windows.Forms.Label lbl_fecha_contrato;
        private System.Windows.Forms.Label lbl_sueldo;
        private System.Windows.Forms.Label lbl_nombre_empleado;
        private System.Windows.Forms.Label lbl_numero_documento;
        private System.Windows.Forms.Label lbl_sexo;
        private System.Windows.Forms.Label lbl_estado_empleado;
        private System.Windows.Forms.Label lbl_cargo;
        public System.Windows.Forms.TextBox txt_contrasena;
        public System.Windows.Forms.TextBox txt_nombre_empleado;
        public System.Windows.Forms.DateTimePicker dtp_nacimiento;
        public System.Windows.Forms.DateTimePicker dtp_contrato;
        public System.Windows.Forms.ComboBox cbo_sexo;
        public System.Windows.Forms.ComboBox cbo_nivel_seguridad;
        public System.Windows.Forms.ComboBox cbo_estado_empleado;
        public System.Windows.Forms.ComboBox cbo_cargo;
        public System.Windows.Forms.NumericUpDown nud_sueldo;
        public System.Windows.Forms.Label lbl_id_empleado;
        public System.Windows.Forms.Label lbl_control_empleado;
        public System.Windows.Forms.Button btn_registrar_empleado;
        public System.Windows.Forms.Button btn_actualizar_empleado;
        public System.Windows.Forms.TextBox txt_dni_empleado;
        public System.Windows.Forms.TextBox txt_encriptado;
    }
}