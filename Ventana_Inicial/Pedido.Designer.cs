namespace Ventana_Inicial
{
    partial class frm_pedido
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
            this.cbo_proveedor = new System.Windows.Forms.ComboBox();
            this.nud_costo_envio_pedido = new System.Windows.Forms.NumericUpDown();
            this.dtp_fecha_llegada_pedido = new System.Windows.Forms.DateTimePicker();
            this.dtp_fecha_pedido = new System.Windows.Forms.DateTimePicker();
            this.cbo_tipo_documento = new System.Windows.Forms.ComboBox();
            this.lbl_tipo_documento = new System.Windows.Forms.Label();
            this.lbl_numero_documento = new System.Windows.Forms.Label();
            this.lbl_costo_envio_pedido = new System.Windows.Forms.Label();
            this.lbl_fecha_llegada_pedido = new System.Windows.Forms.Label();
            this.lbl_fecha_pedido = new System.Windows.Forms.Label();
            this.lbl_proveedor = new System.Windows.Forms.Label();
            this.lbl_control_pedido = new System.Windows.Forms.Label();
            this.btn_registrar_pedido = new System.Windows.Forms.Button();
            this.grp_monetario = new System.Windows.Forms.GroupBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.txt_subtotal = new System.Windows.Forms.TextBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_subtotal = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.grp_datos_pedido = new System.Windows.Forms.GroupBox();
            this.txt_numero_documento = new System.Windows.Forms.TextBox();
            this.btn_actualizar_pedido = new System.Windows.Forms.Button();
            this.lbl_id_pedido = new System.Windows.Forms.Label();
            this.grp_producto = new System.Windows.Forms.GroupBox();
            this.btn_quitar = new System.Windows.Forms.Button();
            this.txt_lote = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_codigo_producto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_fecha_vencimiento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_precio_unitario = new System.Windows.Forms.Label();
            this.lbl_lote = new System.Windows.Forms.Label();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.cbo_producto = new System.Windows.Forms.ComboBox();
            this.nud_precio_compra = new System.Windows.Forms.NumericUpDown();
            this.nud_descuento = new System.Windows.Forms.NumericUpDown();
            this.nud_precio_venta = new System.Windows.Forms.NumericUpDown();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.nud_cantidad = new System.Windows.Forms.NumericUpDown();
            this.lbl_nom_prod = new System.Windows.Forms.Label();
            this.lbl_id_producto = new System.Windows.Forms.Label();
            this.dgv_pedido = new System.Windows.Forms.DataGridView();
            this.pic_volver = new System.Windows.Forms.PictureBox();
            this.lbl_nom_pro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_costo_envio_pedido)).BeginInit();
            this.grp_monetario.SuspendLayout();
            this.grp_datos_pedido.SuspendLayout();
            this.grp_producto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_precio_compra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_descuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_precio_venta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_volver)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_proveedor
            // 
            this.cbo_proveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_proveedor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_proveedor.FormattingEnabled = true;
            this.cbo_proveedor.Location = new System.Drawing.Point(218, 40);
            this.cbo_proveedor.Name = "cbo_proveedor";
            this.cbo_proveedor.Size = new System.Drawing.Size(189, 25);
            this.cbo_proveedor.TabIndex = 1;
            // 
            // nud_costo_envio_pedido
            // 
            this.nud_costo_envio_pedido.DecimalPlaces = 2;
            this.nud_costo_envio_pedido.Location = new System.Drawing.Point(198, 118);
            this.nud_costo_envio_pedido.Maximum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.nud_costo_envio_pedido.Name = "nud_costo_envio_pedido";
            this.nud_costo_envio_pedido.Size = new System.Drawing.Size(70, 23);
            this.nud_costo_envio_pedido.TabIndex = 15;
            // 
            // dtp_fecha_llegada_pedido
            // 
            this.dtp_fecha_llegada_pedido.Enabled = false;
            this.dtp_fecha_llegada_pedido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha_llegada_pedido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_llegada_pedido.Location = new System.Drawing.Point(218, 126);
            this.dtp_fecha_llegada_pedido.Name = "dtp_fecha_llegada_pedido";
            this.dtp_fecha_llegada_pedido.Size = new System.Drawing.Size(100, 23);
            this.dtp_fecha_llegada_pedido.TabIndex = 3;
            this.dtp_fecha_llegada_pedido.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // dtp_fecha_pedido
            // 
            this.dtp_fecha_pedido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha_pedido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_pedido.Location = new System.Drawing.Point(218, 84);
            this.dtp_fecha_pedido.Name = "dtp_fecha_pedido";
            this.dtp_fecha_pedido.Size = new System.Drawing.Size(100, 23);
            this.dtp_fecha_pedido.TabIndex = 2;
            // 
            // cbo_tipo_documento
            // 
            this.cbo_tipo_documento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tipo_documento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_tipo_documento.FormattingEnabled = true;
            this.cbo_tipo_documento.Items.AddRange(new object[] {
            "Factura",
            "Guía de Remisión"});
            this.cbo_tipo_documento.Location = new System.Drawing.Point(218, 164);
            this.cbo_tipo_documento.Name = "cbo_tipo_documento";
            this.cbo_tipo_documento.Size = new System.Drawing.Size(179, 25);
            this.cbo_tipo_documento.TabIndex = 4;
            this.cbo_tipo_documento.SelectedIndexChanged += new System.EventHandler(this.Cbo_tipo_documento_SelectedIndexChanged);
            // 
            // lbl_tipo_documento
            // 
            this.lbl_tipo_documento.AutoSize = true;
            this.lbl_tipo_documento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo_documento.Location = new System.Drawing.Point(63, 167);
            this.lbl_tipo_documento.Name = "lbl_tipo_documento";
            this.lbl_tipo_documento.Size = new System.Drawing.Size(137, 17);
            this.lbl_tipo_documento.TabIndex = 26;
            this.lbl_tipo_documento.Text = "Tipo de Documento";
            // 
            // lbl_numero_documento
            // 
            this.lbl_numero_documento.AutoSize = true;
            this.lbl_numero_documento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numero_documento.Location = new System.Drawing.Point(37, 203);
            this.lbl_numero_documento.Name = "lbl_numero_documento";
            this.lbl_numero_documento.Size = new System.Drawing.Size(163, 17);
            this.lbl_numero_documento.TabIndex = 25;
            this.lbl_numero_documento.Text = "Número de Documento";
            // 
            // lbl_costo_envio_pedido
            // 
            this.lbl_costo_envio_pedido.AutoSize = true;
            this.lbl_costo_envio_pedido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_costo_envio_pedido.Location = new System.Drawing.Point(54, 120);
            this.lbl_costo_envio_pedido.Name = "lbl_costo_envio_pedido";
            this.lbl_costo_envio_pedido.Size = new System.Drawing.Size(128, 17);
            this.lbl_costo_envio_pedido.TabIndex = 24;
            this.lbl_costo_envio_pedido.Text = "Flete (Egreso Extra)";
            // 
            // lbl_fecha_llegada_pedido
            // 
            this.lbl_fecha_llegada_pedido.AutoSize = true;
            this.lbl_fecha_llegada_pedido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_llegada_pedido.Location = new System.Drawing.Point(4, 130);
            this.lbl_fecha_llegada_pedido.Name = "lbl_fecha_llegada_pedido";
            this.lbl_fecha_llegada_pedido.Size = new System.Drawing.Size(196, 17);
            this.lbl_fecha_llegada_pedido.TabIndex = 22;
            this.lbl_fecha_llegada_pedido.Text = "Fecha de Llegada de Pedido";
            // 
            // lbl_fecha_pedido
            // 
            this.lbl_fecha_pedido.AutoSize = true;
            this.lbl_fecha_pedido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_pedido.Location = new System.Drawing.Point(103, 85);
            this.lbl_fecha_pedido.Name = "lbl_fecha_pedido";
            this.lbl_fecha_pedido.Size = new System.Drawing.Size(97, 17);
            this.lbl_fecha_pedido.TabIndex = 21;
            this.lbl_fecha_pedido.Text = "Fecha Pedido";
            // 
            // lbl_proveedor
            // 
            this.lbl_proveedor.AutoSize = true;
            this.lbl_proveedor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_proveedor.Location = new System.Drawing.Point(125, 43);
            this.lbl_proveedor.Name = "lbl_proveedor";
            this.lbl_proveedor.Size = new System.Drawing.Size(75, 17);
            this.lbl_proveedor.TabIndex = 20;
            this.lbl_proveedor.Text = "Proveedor";
            // 
            // lbl_control_pedido
            // 
            this.lbl_control_pedido.AutoSize = true;
            this.lbl_control_pedido.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_control_pedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.lbl_control_pedido.Location = new System.Drawing.Point(388, 9);
            this.lbl_control_pedido.Name = "lbl_control_pedido";
            this.lbl_control_pedido.Size = new System.Drawing.Size(232, 32);
            this.lbl_control_pedido.TabIndex = 38;
            this.lbl_control_pedido.Text = "[Control] Ingreso";
            // 
            // btn_registrar_pedido
            // 
            this.btn_registrar_pedido.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_registrar_pedido.FlatAppearance.BorderSize = 2;
            this.btn_registrar_pedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar_pedido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar_pedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_registrar_pedido.Location = new System.Drawing.Point(838, 543);
            this.btn_registrar_pedido.Name = "btn_registrar_pedido";
            this.btn_registrar_pedido.Size = new System.Drawing.Size(200, 45);
            this.btn_registrar_pedido.TabIndex = 17;
            this.btn_registrar_pedido.Text = "Registrar Ingreso";
            this.btn_registrar_pedido.UseVisualStyleBackColor = true;
            this.btn_registrar_pedido.Click += new System.EventHandler(this.btn_registrar_pedido_Click);
            // 
            // grp_monetario
            // 
            this.grp_monetario.Controls.Add(this.txt_total);
            this.grp_monetario.Controls.Add(this.txt_subtotal);
            this.grp_monetario.Controls.Add(this.lbl_total);
            this.grp_monetario.Controls.Add(this.lbl_subtotal);
            this.grp_monetario.Controls.Add(this.nud_costo_envio_pedido);
            this.grp_monetario.Controls.Add(this.btn_calcular);
            this.grp_monetario.Controls.Add(this.lbl_costo_envio_pedido);
            this.grp_monetario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_monetario.Location = new System.Drawing.Point(601, 45);
            this.grp_monetario.Name = "grp_monetario";
            this.grp_monetario.Size = new System.Drawing.Size(392, 231);
            this.grp_monetario.TabIndex = 43;
            this.grp_monetario.TabStop = false;
            this.grp_monetario.Text = "Monetario";
            // 
            // txt_total
            // 
            this.txt_total.Enabled = false;
            this.txt_total.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(198, 161);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(123, 23);
            this.txt_total.TabIndex = 137;
            // 
            // txt_subtotal
            // 
            this.txt_subtotal.Enabled = false;
            this.txt_subtotal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_subtotal.Location = new System.Drawing.Point(198, 70);
            this.txt_subtotal.Name = "txt_subtotal";
            this.txt_subtotal.Size = new System.Drawing.Size(123, 23);
            this.txt_subtotal.TabIndex = 138;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(140, 161);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(42, 18);
            this.lbl_total.TabIndex = 135;
            this.lbl_total.Text = "Total";
            // 
            // lbl_subtotal
            // 
            this.lbl_subtotal.AutoSize = true;
            this.lbl_subtotal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subtotal.Location = new System.Drawing.Point(125, 70);
            this.lbl_subtotal.Name = "lbl_subtotal";
            this.lbl_subtotal.Size = new System.Drawing.Size(67, 18);
            this.lbl_subtotal.TabIndex = 136;
            this.lbl_subtotal.Text = "Subtotal";
            // 
            // btn_calcular
            // 
            this.btn_calcular.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_calcular.FlatAppearance.BorderSize = 2;
            this.btn_calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calcular.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_calcular.Location = new System.Drawing.Point(285, 104);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(101, 45);
            this.btn_calcular.TabIndex = 16;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // grp_datos_pedido
            // 
            this.grp_datos_pedido.Controls.Add(this.dtp_fecha_llegada_pedido);
            this.grp_datos_pedido.Controls.Add(this.txt_numero_documento);
            this.grp_datos_pedido.Controls.Add(this.lbl_proveedor);
            this.grp_datos_pedido.Controls.Add(this.lbl_fecha_pedido);
            this.grp_datos_pedido.Controls.Add(this.lbl_fecha_llegada_pedido);
            this.grp_datos_pedido.Controls.Add(this.dtp_fecha_pedido);
            this.grp_datos_pedido.Controls.Add(this.cbo_proveedor);
            this.grp_datos_pedido.Controls.Add(this.cbo_tipo_documento);
            this.grp_datos_pedido.Controls.Add(this.lbl_numero_documento);
            this.grp_datos_pedido.Controls.Add(this.lbl_tipo_documento);
            this.grp_datos_pedido.Location = new System.Drawing.Point(141, 39);
            this.grp_datos_pedido.Name = "grp_datos_pedido";
            this.grp_datos_pedido.Size = new System.Drawing.Size(423, 237);
            this.grp_datos_pedido.TabIndex = 44;
            this.grp_datos_pedido.TabStop = false;
            this.grp_datos_pedido.Text = "Datos de Pedido";
            // 
            // txt_numero_documento
            // 
            this.txt_numero_documento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_numero_documento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numero_documento.Location = new System.Drawing.Point(218, 200);
            this.txt_numero_documento.Name = "txt_numero_documento";
            this.txt_numero_documento.Size = new System.Drawing.Size(179, 23);
            this.txt_numero_documento.TabIndex = 138;
            // 
            // btn_actualizar_pedido
            // 
            this.btn_actualizar_pedido.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_actualizar_pedido.FlatAppearance.BorderSize = 2;
            this.btn_actualizar_pedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizar_pedido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar_pedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_actualizar_pedido.Location = new System.Drawing.Point(838, 543);
            this.btn_actualizar_pedido.Name = "btn_actualizar_pedido";
            this.btn_actualizar_pedido.Size = new System.Drawing.Size(200, 45);
            this.btn_actualizar_pedido.TabIndex = 41;
            this.btn_actualizar_pedido.Text = "Actualizar Ingreso";
            this.btn_actualizar_pedido.UseVisualStyleBackColor = true;
            this.btn_actualizar_pedido.Click += new System.EventHandler(this.btn_actualizar_pedido_Click);
            // 
            // lbl_id_pedido
            // 
            this.lbl_id_pedido.AutoSize = true;
            this.lbl_id_pedido.Location = new System.Drawing.Point(736, 29);
            this.lbl_id_pedido.Name = "lbl_id_pedido";
            this.lbl_id_pedido.Size = new System.Drawing.Size(57, 13);
            this.lbl_id_pedido.TabIndex = 45;
            this.lbl_id_pedido.Text = "ID_Pedido";
            this.lbl_id_pedido.Visible = false;
            // 
            // grp_producto
            // 
            this.grp_producto.Controls.Add(this.lbl_nom_pro);
            this.grp_producto.Controls.Add(this.btn_quitar);
            this.grp_producto.Controls.Add(this.txt_lote);
            this.grp_producto.Controls.Add(this.label2);
            this.grp_producto.Controls.Add(this.lbl_codigo_producto);
            this.grp_producto.Controls.Add(this.label1);
            this.grp_producto.Controls.Add(this.dtp_fecha_vencimiento);
            this.grp_producto.Controls.Add(this.label3);
            this.grp_producto.Controls.Add(this.lbl_precio_unitario);
            this.grp_producto.Controls.Add(this.lbl_lote);
            this.grp_producto.Controls.Add(this.lbl_cantidad);
            this.grp_producto.Controls.Add(this.cbo_producto);
            this.grp_producto.Controls.Add(this.nud_precio_compra);
            this.grp_producto.Controls.Add(this.nud_descuento);
            this.grp_producto.Controls.Add(this.nud_precio_venta);
            this.grp_producto.Controls.Add(this.btn_agregar);
            this.grp_producto.Controls.Add(this.nud_cantidad);
            this.grp_producto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_producto.Location = new System.Drawing.Point(496, 293);
            this.grp_producto.Name = "grp_producto";
            this.grp_producto.Size = new System.Drawing.Size(497, 244);
            this.grp_producto.TabIndex = 140;
            this.grp_producto.TabStop = false;
            this.grp_producto.Text = "Producto";
            // 
            // btn_quitar
            // 
            this.btn_quitar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_quitar.FlatAppearance.BorderSize = 2;
            this.btn_quitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quitar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quitar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_quitar.Location = new System.Drawing.Point(390, 192);
            this.btn_quitar.Name = "btn_quitar";
            this.btn_quitar.Size = new System.Drawing.Size(101, 45);
            this.btn_quitar.TabIndex = 13;
            this.btn_quitar.Text = "Quitar";
            this.btn_quitar.UseVisualStyleBackColor = true;
            this.btn_quitar.Click += new System.EventHandler(this.btn_quitar_Click);
            // 
            // txt_lote
            // 
            this.txt_lote.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lote.Location = new System.Drawing.Point(10, 205);
            this.txt_lote.Name = "txt_lote";
            this.txt_lote.Size = new System.Drawing.Size(191, 23);
            this.txt_lote.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Fecha Vencimiento";
            // 
            // lbl_codigo_producto
            // 
            this.lbl_codigo_producto.AutoSize = true;
            this.lbl_codigo_producto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo_producto.Location = new System.Drawing.Point(7, 44);
            this.lbl_codigo_producto.Name = "lbl_codigo_producto";
            this.lbl_codigo_producto.Size = new System.Drawing.Size(158, 18);
            this.lbl_codigo_producto.TabIndex = 88;
            this.lbl_codigo_producto.Text = "Código de Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 88;
            this.label1.Text = "Precio Compra";
            // 
            // dtp_fecha_vencimiento
            // 
            this.dtp_fecha_vencimiento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha_vencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_vencimiento.Location = new System.Drawing.Point(221, 205);
            this.dtp_fecha_vencimiento.Name = "dtp_fecha_vencimiento";
            this.dtp_fecha_vencimiento.Size = new System.Drawing.Size(100, 23);
            this.dtp_fecha_vencimiento.TabIndex = 11;
            this.dtp_fecha_vencimiento.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(339, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 88;
            this.label3.Text = "Descuento";
            // 
            // lbl_precio_unitario
            // 
            this.lbl_precio_unitario.AutoSize = true;
            this.lbl_precio_unitario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio_unitario.Location = new System.Drawing.Point(218, 125);
            this.lbl_precio_unitario.Name = "lbl_precio_unitario";
            this.lbl_precio_unitario.Size = new System.Drawing.Size(103, 18);
            this.lbl_precio_unitario.TabIndex = 88;
            this.lbl_precio_unitario.Text = "Precio Venta";
            // 
            // lbl_lote
            // 
            this.lbl_lote.AutoSize = true;
            this.lbl_lote.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lote.Location = new System.Drawing.Point(7, 182);
            this.lbl_lote.Name = "lbl_lote";
            this.lbl_lote.Size = new System.Drawing.Size(39, 18);
            this.lbl_lote.TabIndex = 88;
            this.lbl_lote.Text = "Lote";
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad.Location = new System.Drawing.Point(7, 124);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(77, 18);
            this.lbl_cantidad.TabIndex = 88;
            this.lbl_cantidad.Text = "Cantidad";
            // 
            // cbo_producto
            // 
            this.cbo_producto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbo_producto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_producto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_producto.FormattingEnabled = true;
            this.cbo_producto.Location = new System.Drawing.Point(10, 75);
            this.cbo_producto.Name = "cbo_producto";
            this.cbo_producto.Size = new System.Drawing.Size(155, 25);
            this.cbo_producto.TabIndex = 6;
            this.cbo_producto.SelectedIndexChanged += new System.EventHandler(this.cbo_producto_SelectedIndexChanged);
            // 
            // nud_precio_compra
            // 
            this.nud_precio_compra.DecimalPlaces = 2;
            this.nud_precio_compra.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_precio_compra.Location = new System.Drawing.Point(182, 75);
            this.nud_precio_compra.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nud_precio_compra.Name = "nud_precio_compra";
            this.nud_precio_compra.Size = new System.Drawing.Size(120, 23);
            this.nud_precio_compra.TabIndex = 9;
            // 
            // nud_descuento
            // 
            this.nud_descuento.DecimalPlaces = 2;
            this.nud_descuento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_descuento.Location = new System.Drawing.Point(342, 75);
            this.nud_descuento.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nud_descuento.Name = "nud_descuento";
            this.nud_descuento.Size = new System.Drawing.Size(100, 23);
            this.nud_descuento.TabIndex = 10;
            // 
            // nud_precio_venta
            // 
            this.nud_precio_venta.DecimalPlaces = 2;
            this.nud_precio_venta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_precio_venta.Location = new System.Drawing.Point(221, 148);
            this.nud_precio_venta.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nud_precio_venta.Name = "nud_precio_venta";
            this.nud_precio_venta.Size = new System.Drawing.Size(100, 23);
            this.nud_precio_venta.TabIndex = 10;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Enabled = false;
            this.btn_agregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_agregar.FlatAppearance.BorderSize = 2;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_agregar.Location = new System.Drawing.Point(390, 131);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(101, 45);
            this.btn_agregar.TabIndex = 12;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // nud_cantidad
            // 
            this.nud_cantidad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_cantidad.Location = new System.Drawing.Point(10, 148);
            this.nud_cantidad.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.nud_cantidad.Name = "nud_cantidad";
            this.nud_cantidad.Size = new System.Drawing.Size(89, 23);
            this.nud_cantidad.TabIndex = 7;
            this.nud_cantidad.ValueChanged += new System.EventHandler(this.Nud_cantidad_ValueChanged);
            // 
            // lbl_nom_prod
            // 
            this.lbl_nom_prod.AutoSize = true;
            this.lbl_nom_prod.Location = new System.Drawing.Point(613, 29);
            this.lbl_nom_prod.Name = "lbl_nom_prod";
            this.lbl_nom_prod.Size = new System.Drawing.Size(87, 13);
            this.lbl_nom_prod.TabIndex = 143;
            this.lbl_nom_prod.Text = "NombreProducto";
            this.lbl_nom_prod.Visible = false;
            // 
            // lbl_id_producto
            // 
            this.lbl_id_producto.AutoSize = true;
            this.lbl_id_producto.Location = new System.Drawing.Point(855, 29);
            this.lbl_id_producto.Name = "lbl_id_producto";
            this.lbl_id_producto.Size = new System.Drawing.Size(67, 13);
            this.lbl_id_producto.TabIndex = 142;
            this.lbl_id_producto.Text = "ID_Producto";
            this.lbl_id_producto.Visible = false;
            this.lbl_id_producto.TextChanged += new System.EventHandler(this.lbl_id_producto_TextChanged);
            this.lbl_id_producto.Click += new System.EventHandler(this.lbl_id_producto_Click);
            // 
            // dgv_pedido
            // 
            this.dgv_pedido.AllowUserToAddRows = false;
            this.dgv_pedido.AllowUserToDeleteRows = false;
            this.dgv_pedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_pedido.BackgroundColor = System.Drawing.Color.White;
            this.dgv_pedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pedido.Location = new System.Drawing.Point(29, 303);
            this.dgv_pedido.MultiSelect = false;
            this.dgv_pedido.Name = "dgv_pedido";
            this.dgv_pedido.ReadOnly = true;
            this.dgv_pedido.RowHeadersVisible = false;
            this.dgv_pedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_pedido.Size = new System.Drawing.Size(447, 250);
            this.dgv_pedido.TabIndex = 144;
            // 
            // pic_volver
            // 
            this.pic_volver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_volver.Image = global::Ventana_Inicial.Properties.Resources.Atras;
            this.pic_volver.Location = new System.Drawing.Point(98, 9);
            this.pic_volver.Name = "pic_volver";
            this.pic_volver.Size = new System.Drawing.Size(20, 32);
            this.pic_volver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_volver.TabIndex = 42;
            this.pic_volver.TabStop = false;
            this.pic_volver.Click += new System.EventHandler(this.pic_volver_Click);
            // 
            // lbl_nom_pro
            // 
            this.lbl_nom_pro.AutoSize = true;
            this.lbl_nom_pro.Location = new System.Drawing.Point(7, 103);
            this.lbl_nom_pro.Name = "lbl_nom_pro";
            this.lbl_nom_pro.Size = new System.Drawing.Size(149, 17);
            this.lbl_nom_pro.TabIndex = 131;
            this.lbl_nom_pro.Text = "Nombre del Producto";
            // 
            // frm_pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.dgv_pedido);
            this.Controls.Add(this.lbl_nom_prod);
            this.Controls.Add(this.lbl_id_producto);
            this.Controls.Add(this.grp_producto);
            this.Controls.Add(this.lbl_id_pedido);
            this.Controls.Add(this.grp_datos_pedido);
            this.Controls.Add(this.grp_monetario);
            this.Controls.Add(this.pic_volver);
            this.Controls.Add(this.btn_actualizar_pedido);
            this.Controls.Add(this.btn_registrar_pedido);
            this.Controls.Add(this.lbl_control_pedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_pedido";
            this.Text = "Nuevo_Pedido";
            this.Load += new System.EventHandler(this.Nuevo_Pedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_costo_envio_pedido)).EndInit();
            this.grp_monetario.ResumeLayout(false);
            this.grp_monetario.PerformLayout();
            this.grp_datos_pedido.ResumeLayout(false);
            this.grp_datos_pedido.PerformLayout();
            this.grp_producto.ResumeLayout(false);
            this.grp_producto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_precio_compra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_descuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_precio_venta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_volver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tipo_documento;
        private System.Windows.Forms.Label lbl_numero_documento;
        private System.Windows.Forms.Label lbl_costo_envio_pedido;
        private System.Windows.Forms.Label lbl_fecha_llegada_pedido;
        private System.Windows.Forms.Label lbl_fecha_pedido;
        private System.Windows.Forms.Label lbl_proveedor;
        public System.Windows.Forms.Button btn_registrar_pedido;
        private System.Windows.Forms.PictureBox pic_volver;
        private System.Windows.Forms.GroupBox grp_monetario;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_subtotal;
        private System.Windows.Forms.GroupBox grp_datos_pedido;
        public System.Windows.Forms.Button btn_actualizar_pedido;
        private System.Windows.Forms.GroupBox grp_producto;
        private System.Windows.Forms.Label lbl_codigo_producto;
        private System.Windows.Forms.Label lbl_precio_unitario;
        private System.Windows.Forms.Label lbl_cantidad;
        public System.Windows.Forms.ComboBox cbo_producto;
        public System.Windows.Forms.ComboBox cbo_proveedor;
        public System.Windows.Forms.NumericUpDown nud_costo_envio_pedido;
        public System.Windows.Forms.DateTimePicker dtp_fecha_llegada_pedido;
        public System.Windows.Forms.DateTimePicker dtp_fecha_pedido;
        public System.Windows.Forms.ComboBox cbo_tipo_documento;
        public System.Windows.Forms.TextBox txt_total;
        public System.Windows.Forms.TextBox txt_subtotal;
        public System.Windows.Forms.NumericUpDown nud_precio_venta;
        public System.Windows.Forms.NumericUpDown nud_cantidad;
        public System.Windows.Forms.Label lbl_id_pedido;
        public System.Windows.Forms.Label lbl_control_pedido;
        private System.Windows.Forms.Label lbl_nom_prod;
        private System.Windows.Forms.Label lbl_id_producto;
        public System.Windows.Forms.DataGridView dgv_pedido;
        public System.Windows.Forms.TextBox txt_lote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dtp_fecha_vencimiento;
        private System.Windows.Forms.Label lbl_lote;
        public System.Windows.Forms.NumericUpDown nud_precio_compra;
        public System.Windows.Forms.Button btn_quitar;
        public System.Windows.Forms.Button btn_agregar;
        public System.Windows.Forms.Button btn_calcular;
        public System.Windows.Forms.TextBox txt_numero_documento;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.NumericUpDown nud_descuento;
        private System.Windows.Forms.Label lbl_nom_pro;
    }
}