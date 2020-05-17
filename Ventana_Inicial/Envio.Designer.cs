namespace Ventana_Inicial
{
    partial class frm_enviosrpt
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
            this.nud_costo_envio = new System.Windows.Forms.NumericUpDown();
            this.lbl_venta = new System.Windows.Forms.Label();
            this.lbl_costo_envio = new System.Windows.Forms.Label();
            this.lbl_remitente_envio = new System.Windows.Forms.Label();
            this.txt_remitente_envio = new System.Windows.Forms.TextBox();
            this.lbl_control_envio = new System.Windows.Forms.Label();
            this.btn_registrar_envio = new System.Windows.Forms.Button();
            this.cbo_ventas = new System.Windows.Forms.ComboBox();
            this.lbl_documento_receptor = new System.Windows.Forms.Label();
            this.txt_destinatario_envio = new System.Windows.Forms.TextBox();
            this.lbl_destinatario_envio = new System.Windows.Forms.Label();
            this.txt_direccion_destinatario = new System.Windows.Forms.TextBox();
            this.lbl_direccion_destinatario = new System.Windows.Forms.Label();
            this.dtp_fec_env = new System.Windows.Forms.DateTimePicker();
            this.lbl_fecha_envio = new System.Windows.Forms.Label();
            this.txt_nombre_receptor = new System.Windows.Forms.TextBox();
            this.lbl_nombre_receptor = new System.Windows.Forms.Label();
            this.lbl_fecha_recepcion = new System.Windows.Forms.Label();
            this.dtp_fec_rec = new System.Windows.Forms.DateTimePicker();
            this.lbl_empleado = new System.Windows.Forms.Label();
            this.cbo_empleado = new System.Windows.Forms.ComboBox();
            this.lbl_telefono_destinatario = new System.Windows.Forms.Label();
            this.lbl_telefono_remitente = new System.Windows.Forms.Label();
            this.btn_actualizar_envio = new System.Windows.Forms.Button();
            this.lbl_id_envio = new System.Windows.Forms.Label();
            this.cbo_estado = new System.Windows.Forms.ComboBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.txt_telefono_remitente = new System.Windows.Forms.MaskedTextBox();
            this.txt_telefono_destinatario = new System.Windows.Forms.MaskedTextBox();
            this.txt_dni_receptor = new System.Windows.Forms.TextBox();
            this.mtxt_envio_hora = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_tipo_comp = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_volver = new System.Windows.Forms.PictureBox();
            this.cbo_comp_imp = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_cliente = new System.Windows.Forms.ComboBox();
            this.lbl_nom_cliente = new System.Windows.Forms.Label();
            this.grp_facturacion = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_costo_envio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_volver)).BeginInit();
            this.grp_facturacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // nud_costo_envio
            // 
            this.nud_costo_envio.DecimalPlaces = 2;
            this.nud_costo_envio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_costo_envio.Location = new System.Drawing.Point(335, 293);
            this.nud_costo_envio.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nud_costo_envio.Name = "nud_costo_envio";
            this.nud_costo_envio.Size = new System.Drawing.Size(120, 23);
            this.nud_costo_envio.TabIndex = 7;
            // 
            // lbl_venta
            // 
            this.lbl_venta.AutoSize = true;
            this.lbl_venta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_venta.Location = new System.Drawing.Point(134, 98);
            this.lbl_venta.Name = "lbl_venta";
            this.lbl_venta.Size = new System.Drawing.Size(184, 18);
            this.lbl_venta.TabIndex = 116;
            this.lbl_venta.Text = "Comprobante de Venta";
            // 
            // lbl_costo_envio
            // 
            this.lbl_costo_envio.AutoSize = true;
            this.lbl_costo_envio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_costo_envio.Location = new System.Drawing.Point(201, 294);
            this.lbl_costo_envio.Name = "lbl_costo_envio";
            this.lbl_costo_envio.Size = new System.Drawing.Size(117, 18);
            this.lbl_costo_envio.TabIndex = 117;
            this.lbl_costo_envio.Text = "Costo de Envio";
            // 
            // lbl_remitente_envio
            // 
            this.lbl_remitente_envio.AutoSize = true;
            this.lbl_remitente_envio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_remitente_envio.Location = new System.Drawing.Point(169, 134);
            this.lbl_remitente_envio.Name = "lbl_remitente_envio";
            this.lbl_remitente_envio.Size = new System.Drawing.Size(149, 18);
            this.lbl_remitente_envio.TabIndex = 118;
            this.lbl_remitente_envio.Text = "Remitente de Envio";
            // 
            // txt_remitente_envio
            // 
            this.txt_remitente_envio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_remitente_envio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_remitente_envio.Location = new System.Drawing.Point(335, 132);
            this.txt_remitente_envio.Name = "txt_remitente_envio";
            this.txt_remitente_envio.Size = new System.Drawing.Size(587, 23);
            this.txt_remitente_envio.TabIndex = 2;
            // 
            // lbl_control_envio
            // 
            this.lbl_control_envio.AutoSize = true;
            this.lbl_control_envio.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_control_envio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.lbl_control_envio.Location = new System.Drawing.Point(434, 25);
            this.lbl_control_envio.Name = "lbl_control_envio";
            this.lbl_control_envio.Size = new System.Drawing.Size(203, 32);
            this.lbl_control_envio.TabIndex = 113;
            this.lbl_control_envio.Text = "[Control] Envio";
            // 
            // btn_registrar_envio
            // 
            this.btn_registrar_envio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_registrar_envio.FlatAppearance.BorderSize = 2;
            this.btn_registrar_envio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar_envio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar_envio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_registrar_envio.Location = new System.Drawing.Point(738, 543);
            this.btn_registrar_envio.Name = "btn_registrar_envio";
            this.btn_registrar_envio.Size = new System.Drawing.Size(200, 45);
            this.btn_registrar_envio.TabIndex = 14;
            this.btn_registrar_envio.Text = "Registrar Envio";
            this.btn_registrar_envio.UseVisualStyleBackColor = true;
            this.btn_registrar_envio.Click += new System.EventHandler(this.btn_registrar_envio_Click);
            // 
            // cbo_ventas
            // 
            this.cbo_ventas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbo_ventas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_ventas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_ventas.FormattingEnabled = true;
            this.cbo_ventas.Location = new System.Drawing.Point(335, 97);
            this.cbo_ventas.Name = "cbo_ventas";
            this.cbo_ventas.Size = new System.Drawing.Size(191, 25);
            this.cbo_ventas.TabIndex = 1;
            this.cbo_ventas.SelectedIndexChanged += new System.EventHandler(this.Cbo_ventas_SelectedIndexChanged);
            // 
            // lbl_documento_receptor
            // 
            this.lbl_documento_receptor.AutoSize = true;
            this.lbl_documento_receptor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_documento_receptor.Location = new System.Drawing.Point(151, 398);
            this.lbl_documento_receptor.Name = "lbl_documento_receptor";
            this.lbl_documento_receptor.Size = new System.Drawing.Size(167, 18);
            this.lbl_documento_receptor.TabIndex = 118;
            this.lbl_documento_receptor.Text = "Documento Receptor";
            // 
            // txt_destinatario_envio
            // 
            this.txt_destinatario_envio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_destinatario_envio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_destinatario_envio.Location = new System.Drawing.Point(335, 196);
            this.txt_destinatario_envio.Name = "txt_destinatario_envio";
            this.txt_destinatario_envio.Size = new System.Drawing.Size(587, 23);
            this.txt_destinatario_envio.TabIndex = 4;
            // 
            // lbl_destinatario_envio
            // 
            this.lbl_destinatario_envio.AutoSize = true;
            this.lbl_destinatario_envio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_destinatario_envio.Location = new System.Drawing.Point(156, 199);
            this.lbl_destinatario_envio.Name = "lbl_destinatario_envio";
            this.lbl_destinatario_envio.Size = new System.Drawing.Size(162, 18);
            this.lbl_destinatario_envio.TabIndex = 118;
            this.lbl_destinatario_envio.Text = "Destinatario de Envio";
            // 
            // txt_direccion_destinatario
            // 
            this.txt_direccion_destinatario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_direccion_destinatario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_direccion_destinatario.Location = new System.Drawing.Point(335, 231);
            this.txt_direccion_destinatario.Name = "txt_direccion_destinatario";
            this.txt_direccion_destinatario.Size = new System.Drawing.Size(587, 23);
            this.txt_direccion_destinatario.TabIndex = 5;
            // 
            // lbl_direccion_destinatario
            // 
            this.lbl_direccion_destinatario.AutoSize = true;
            this.lbl_direccion_destinatario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_direccion_destinatario.Location = new System.Drawing.Point(151, 232);
            this.lbl_direccion_destinatario.Name = "lbl_direccion_destinatario";
            this.lbl_direccion_destinatario.Size = new System.Drawing.Size(172, 18);
            this.lbl_direccion_destinatario.TabIndex = 118;
            this.lbl_direccion_destinatario.Text = "Direccion Destinatario";
            // 
            // dtp_fec_env
            // 
            this.dtp_fec_env.CalendarFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fec_env.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fec_env.Location = new System.Drawing.Point(335, 322);
            this.dtp_fec_env.Name = "dtp_fec_env";
            this.dtp_fec_env.Size = new System.Drawing.Size(338, 26);
            this.dtp_fec_env.TabIndex = 8;
            // 
            // lbl_fecha_envio
            // 
            this.lbl_fecha_envio.AutoSize = true;
            this.lbl_fecha_envio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_envio.Location = new System.Drawing.Point(197, 329);
            this.lbl_fecha_envio.Name = "lbl_fecha_envio";
            this.lbl_fecha_envio.Size = new System.Drawing.Size(116, 18);
            this.lbl_fecha_envio.TabIndex = 117;
            this.lbl_fecha_envio.Text = "Fecha a Enviar";
            // 
            // txt_nombre_receptor
            // 
            this.txt_nombre_receptor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nombre_receptor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_receptor.Location = new System.Drawing.Point(335, 435);
            this.txt_nombre_receptor.Name = "txt_nombre_receptor";
            this.txt_nombre_receptor.Size = new System.Drawing.Size(587, 23);
            this.txt_nombre_receptor.TabIndex = 11;
            // 
            // lbl_nombre_receptor
            // 
            this.lbl_nombre_receptor.AutoSize = true;
            this.lbl_nombre_receptor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_receptor.Location = new System.Drawing.Point(178, 437);
            this.lbl_nombre_receptor.Name = "lbl_nombre_receptor";
            this.lbl_nombre_receptor.Size = new System.Drawing.Size(140, 18);
            this.lbl_nombre_receptor.TabIndex = 118;
            this.lbl_nombre_receptor.Text = "Nombre Receptor";
            // 
            // lbl_fecha_recepcion
            // 
            this.lbl_fecha_recepcion.AutoSize = true;
            this.lbl_fecha_recepcion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_recepcion.Location = new System.Drawing.Point(154, 480);
            this.lbl_fecha_recepcion.Name = "lbl_fecha_recepcion";
            this.lbl_fecha_recepcion.Size = new System.Drawing.Size(164, 18);
            this.lbl_fecha_recepcion.TabIndex = 117;
            this.lbl_fecha_recepcion.Text = "Fecha de Recepcion";
            // 
            // dtp_fec_rec
            // 
            this.dtp_fec_rec.CalendarFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fec_rec.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fec_rec.Location = new System.Drawing.Point(335, 473);
            this.dtp_fec_rec.Name = "dtp_fec_rec";
            this.dtp_fec_rec.Size = new System.Drawing.Size(338, 26);
            this.dtp_fec_rec.TabIndex = 12;
            // 
            // lbl_empleado
            // 
            this.lbl_empleado.AutoSize = true;
            this.lbl_empleado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empleado.Location = new System.Drawing.Point(234, 518);
            this.lbl_empleado.Name = "lbl_empleado";
            this.lbl_empleado.Size = new System.Drawing.Size(84, 18);
            this.lbl_empleado.TabIndex = 116;
            this.lbl_empleado.Text = "Empleado";
            // 
            // cbo_empleado
            // 
            this.cbo_empleado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbo_empleado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_empleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_empleado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_empleado.FormattingEnabled = true;
            this.cbo_empleado.Location = new System.Drawing.Point(335, 517);
            this.cbo_empleado.Name = "cbo_empleado";
            this.cbo_empleado.Size = new System.Drawing.Size(191, 25);
            this.cbo_empleado.TabIndex = 13;
            // 
            // lbl_telefono_destinatario
            // 
            this.lbl_telefono_destinatario.AutoSize = true;
            this.lbl_telefono_destinatario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefono_destinatario.Location = new System.Drawing.Point(170, 266);
            this.lbl_telefono_destinatario.Name = "lbl_telefono_destinatario";
            this.lbl_telefono_destinatario.Size = new System.Drawing.Size(148, 18);
            this.lbl_telefono_destinatario.TabIndex = 118;
            this.lbl_telefono_destinatario.Text = "Telefono Destinario";
            // 
            // lbl_telefono_remitente
            // 
            this.lbl_telefono_remitente.AutoSize = true;
            this.lbl_telefono_remitente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefono_remitente.Location = new System.Drawing.Point(169, 169);
            this.lbl_telefono_remitente.Name = "lbl_telefono_remitente";
            this.lbl_telefono_remitente.Size = new System.Drawing.Size(149, 18);
            this.lbl_telefono_remitente.TabIndex = 118;
            this.lbl_telefono_remitente.Text = "Telefono Remitente";
            // 
            // btn_actualizar_envio
            // 
            this.btn_actualizar_envio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_actualizar_envio.FlatAppearance.BorderSize = 2;
            this.btn_actualizar_envio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizar_envio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar_envio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_actualizar_envio.Location = new System.Drawing.Point(738, 543);
            this.btn_actualizar_envio.Name = "btn_actualizar_envio";
            this.btn_actualizar_envio.Size = new System.Drawing.Size(200, 45);
            this.btn_actualizar_envio.TabIndex = 14;
            this.btn_actualizar_envio.Text = "Actualizar Envio";
            this.btn_actualizar_envio.UseVisualStyleBackColor = true;
            this.btn_actualizar_envio.Click += new System.EventHandler(this.btn_actualizar_envio_Click);
            // 
            // lbl_id_envio
            // 
            this.lbl_id_envio.AutoSize = true;
            this.lbl_id_envio.Location = new System.Drawing.Point(332, 25);
            this.lbl_id_envio.Name = "lbl_id_envio";
            this.lbl_id_envio.Size = new System.Drawing.Size(51, 13);
            this.lbl_id_envio.TabIndex = 124;
            this.lbl_id_envio.Text = "ID_Envio";
            this.lbl_id_envio.Visible = false;
            // 
            // cbo_estado
            // 
            this.cbo_estado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbo_estado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_estado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_estado.FormattingEnabled = true;
            this.cbo_estado.Items.AddRange(new object[] {
            "En Tienda",
            "Enviado",
            "Recepcionado"});
            this.cbo_estado.Location = new System.Drawing.Point(335, 553);
            this.cbo_estado.Name = "cbo_estado";
            this.cbo_estado.Size = new System.Drawing.Size(191, 25);
            this.cbo_estado.TabIndex = 14;
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estado.Location = new System.Drawing.Point(262, 555);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(56, 18);
            this.lbl_estado.TabIndex = 149;
            this.lbl_estado.Text = "Estado";
            // 
            // txt_telefono_remitente
            // 
            this.txt_telefono_remitente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono_remitente.HideSelection = false;
            this.txt_telefono_remitente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_telefono_remitente.Location = new System.Drawing.Point(335, 164);
            this.txt_telefono_remitente.Mask = "(+00)000-000-000-00000";
            this.txt_telefono_remitente.Name = "txt_telefono_remitente";
            this.txt_telefono_remitente.Size = new System.Drawing.Size(318, 23);
            this.txt_telefono_remitente.SkipLiterals = false;
            this.txt_telefono_remitente.TabIndex = 3;
            this.txt_telefono_remitente.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Txt_telefono_remitente_MaskInputRejected);
            this.txt_telefono_remitente.TextChanged += new System.EventHandler(this.txt_telefono_remitente_TextChanged);
            // 
            // txt_telefono_destinatario
            // 
            this.txt_telefono_destinatario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono_destinatario.Location = new System.Drawing.Point(335, 261);
            this.txt_telefono_destinatario.Mask = "(+00)000-000-000-00000";
            this.txt_telefono_destinatario.Name = "txt_telefono_destinatario";
            this.txt_telefono_destinatario.Size = new System.Drawing.Size(318, 23);
            this.txt_telefono_destinatario.TabIndex = 6;
            this.txt_telefono_destinatario.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txt_telefono_destinatario_MaskInputRejected);
            this.txt_telefono_destinatario.TextChanged += new System.EventHandler(this.txt_telefono_destinatario_TextChanged);
            // 
            // txt_dni_receptor
            // 
            this.txt_dni_receptor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_dni_receptor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dni_receptor.Location = new System.Drawing.Point(335, 397);
            this.txt_dni_receptor.Name = "txt_dni_receptor";
            this.txt_dni_receptor.Size = new System.Drawing.Size(191, 23);
            this.txt_dni_receptor.TabIndex = 10;
            this.txt_dni_receptor.TextChanged += new System.EventHandler(this.txt_dni_receptor_TextChanged);
            // 
            // mtxt_envio_hora
            // 
            this.mtxt_envio_hora.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxt_envio_hora.Location = new System.Drawing.Point(335, 363);
            this.mtxt_envio_hora.Mask = "00:00:00";
            this.mtxt_envio_hora.Name = "mtxt_envio_hora";
            this.mtxt_envio_hora.Size = new System.Drawing.Size(59, 23);
            this.mtxt_envio_hora.TabIndex = 9;
            this.mtxt_envio_hora.ValidatingType = typeof(System.DateTime);
            this.mtxt_envio_hora.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txt_telefono_destinatario_MaskInputRejected);
            this.mtxt_envio_hora.TextChanged += new System.EventHandler(this.txt_telefono_destinatario_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 18);
            this.label1.TabIndex = 117;
            this.label1.Text = "Hora a Enviar";
            // 
            // cbo_tipo_comp
            // 
            this.cbo_tipo_comp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbo_tipo_comp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_tipo_comp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tipo_comp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_tipo_comp.FormattingEnabled = true;
            this.cbo_tipo_comp.Items.AddRange(new object[] {
            "Boleta",
            "Factura"});
            this.cbo_tipo_comp.Location = new System.Drawing.Point(335, 61);
            this.cbo_tipo_comp.Name = "cbo_tipo_comp";
            this.cbo_tipo_comp.Size = new System.Drawing.Size(191, 25);
            this.cbo_tipo_comp.TabIndex = 150;
            this.cbo_tipo_comp.SelectedIndexChanged += new System.EventHandler(this.Cbo_tipo_comp_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 18);
            this.label2.TabIndex = 151;
            this.label2.Text = "Tipo de Comprobante";
            // 
            // pic_volver
            // 
            this.pic_volver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_volver.Image = global::Ventana_Inicial.Properties.Resources.Atras;
            this.pic_volver.Location = new System.Drawing.Point(94, 47);
            this.pic_volver.Name = "pic_volver";
            this.pic_volver.Size = new System.Drawing.Size(20, 32);
            this.pic_volver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_volver.TabIndex = 114;
            this.pic_volver.TabStop = false;
            this.pic_volver.Click += new System.EventHandler(this.pic_volver_Click);
            // 
            // cbo_comp_imp
            // 
            this.cbo_comp_imp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbo_comp_imp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_comp_imp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_comp_imp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_comp_imp.FormattingEnabled = true;
            this.cbo_comp_imp.Items.AddRange(new object[] {
            "Boleta",
            "Factura"});
            this.cbo_comp_imp.Location = new System.Drawing.Point(32, 56);
            this.cbo_comp_imp.Name = "cbo_comp_imp";
            this.cbo_comp_imp.Size = new System.Drawing.Size(245, 25);
            this.cbo_comp_imp.TabIndex = 150;
            this.cbo_comp_imp.SelectedIndexChanged += new System.EventHandler(this.Cbo_tipo_comp_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 18);
            this.label3.TabIndex = 152;
            this.label3.Text = "Comprobante a Imprimir";
            // 
            // cbo_cliente
            // 
            this.cbo_cliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbo_cliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_cliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_cliente.FormattingEnabled = true;
            this.cbo_cliente.Location = new System.Drawing.Point(32, 100);
            this.cbo_cliente.Name = "cbo_cliente";
            this.cbo_cliente.Size = new System.Drawing.Size(170, 25);
            this.cbo_cliente.TabIndex = 153;
            this.cbo_cliente.SelectedIndexChanged += new System.EventHandler(this.Cbo_cliente_SelectedIndexChanged);
            // 
            // lbl_nom_cliente
            // 
            this.lbl_nom_cliente.AutoSize = true;
            this.lbl_nom_cliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nom_cliente.Location = new System.Drawing.Point(29, 131);
            this.lbl_nom_cliente.Name = "lbl_nom_cliente";
            this.lbl_nom_cliente.Size = new System.Drawing.Size(153, 18);
            this.lbl_nom_cliente.TabIndex = 154;
            this.lbl_nom_cliente.Text = "Nombre del Cliente";
            // 
            // grp_facturacion
            // 
            this.grp_facturacion.Controls.Add(this.label4);
            this.grp_facturacion.Controls.Add(this.cbo_comp_imp);
            this.grp_facturacion.Controls.Add(this.cbo_cliente);
            this.grp_facturacion.Controls.Add(this.lbl_nom_cliente);
            this.grp_facturacion.Controls.Add(this.label3);
            this.grp_facturacion.Location = new System.Drawing.Point(697, 266);
            this.grp_facturacion.Name = "grp_facturacion";
            this.grp_facturacion.Size = new System.Drawing.Size(322, 154);
            this.grp_facturacion.TabIndex = 155;
            this.grp_facturacion.TabStop = false;
            this.grp_facturacion.Text = "Facturación";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 155;
            this.label4.Text = "Cliente";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // frm_enviosrpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.grp_facturacion);
            this.Controls.Add(this.cbo_tipo_comp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtxt_envio_hora);
            this.Controls.Add(this.txt_telefono_destinatario);
            this.Controls.Add(this.txt_telefono_remitente);
            this.Controls.Add(this.cbo_estado);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.lbl_id_envio);
            this.Controls.Add(this.dtp_fec_rec);
            this.Controls.Add(this.dtp_fec_env);
            this.Controls.Add(this.cbo_empleado);
            this.Controls.Add(this.cbo_ventas);
            this.Controls.Add(this.nud_costo_envio);
            this.Controls.Add(this.lbl_empleado);
            this.Controls.Add(this.lbl_fecha_recepcion);
            this.Controls.Add(this.lbl_venta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_fecha_envio);
            this.Controls.Add(this.lbl_costo_envio);
            this.Controls.Add(this.lbl_telefono_remitente);
            this.Controls.Add(this.lbl_telefono_destinatario);
            this.Controls.Add(this.lbl_documento_receptor);
            this.Controls.Add(this.lbl_nombre_receptor);
            this.Controls.Add(this.lbl_direccion_destinatario);
            this.Controls.Add(this.lbl_destinatario_envio);
            this.Controls.Add(this.lbl_remitente_envio);
            this.Controls.Add(this.txt_nombre_receptor);
            this.Controls.Add(this.txt_direccion_destinatario);
            this.Controls.Add(this.txt_destinatario_envio);
            this.Controls.Add(this.txt_dni_receptor);
            this.Controls.Add(this.txt_remitente_envio);
            this.Controls.Add(this.pic_volver);
            this.Controls.Add(this.lbl_control_envio);
            this.Controls.Add(this.btn_actualizar_envio);
            this.Controls.Add(this.btn_registrar_envio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_enviosrpt";
            this.Text = "Nuevo_Envio";
            this.Load += new System.EventHandler(this.frm_nuevo_envio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_costo_envio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_volver)).EndInit();
            this.grp_facturacion.ResumeLayout(false);
            this.grp_facturacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_venta;
        private System.Windows.Forms.Label lbl_costo_envio;
        private System.Windows.Forms.Label lbl_remitente_envio;
        private System.Windows.Forms.PictureBox pic_volver;
        public System.Windows.Forms.ComboBox cbo_ventas;
        private System.Windows.Forms.Label lbl_documento_receptor;
        private System.Windows.Forms.Label lbl_destinatario_envio;
        private System.Windows.Forms.Label lbl_direccion_destinatario;
        public System.Windows.Forms.DateTimePicker dtp_fec_env;
        private System.Windows.Forms.Label lbl_fecha_envio;
        private System.Windows.Forms.Label lbl_nombre_receptor;
        private System.Windows.Forms.Label lbl_fecha_recepcion;
        public System.Windows.Forms.DateTimePicker dtp_fec_rec;
        private System.Windows.Forms.Label lbl_empleado;
        public System.Windows.Forms.ComboBox cbo_empleado;
        private System.Windows.Forms.Label lbl_telefono_destinatario;
        private System.Windows.Forms.Label lbl_telefono_remitente;
        public System.Windows.Forms.NumericUpDown nud_costo_envio;
        public System.Windows.Forms.TextBox txt_remitente_envio;
        public System.Windows.Forms.Label lbl_control_envio;
        public System.Windows.Forms.Button btn_registrar_envio;
        public System.Windows.Forms.TextBox txt_destinatario_envio;
        public System.Windows.Forms.TextBox txt_direccion_destinatario;
        public System.Windows.Forms.TextBox txt_nombre_receptor;
        public System.Windows.Forms.Button btn_actualizar_envio;
        public System.Windows.Forms.Label lbl_id_envio;
        public System.Windows.Forms.ComboBox cbo_estado;
        public System.Windows.Forms.Label lbl_estado;
        public System.Windows.Forms.MaskedTextBox txt_telefono_remitente;
        public System.Windows.Forms.MaskedTextBox txt_telefono_destinatario;
        public System.Windows.Forms.TextBox txt_dni_receptor;
        public System.Windows.Forms.MaskedTextBox mtxt_envio_hora;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbo_tipo_comp;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cbo_comp_imp;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cbo_cliente;
        private System.Windows.Forms.Label lbl_nom_cliente;
        private System.Windows.Forms.GroupBox grp_facturacion;
        private System.Windows.Forms.Label label4;
    }
}