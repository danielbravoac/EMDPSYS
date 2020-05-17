namespace Ventana_Inicial
{
    partial class frm_nueva_venta
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
            this.lbl_nueva_venta = new System.Windows.Forms.Label();
            this.lbl_codigo_producto = new System.Windows.Forms.Label();
            this.cbo_producto = new System.Windows.Forms.ComboBox();
            this.lbl_numero_comprobante = new System.Windows.Forms.Label();
            this.txt_numero_comprobante = new System.Windows.Forms.TextBox();
            this.cbo_comprobante = new System.Windows.Forms.ComboBox();
            this.lbl_tipo_comprobante = new System.Windows.Forms.Label();
            this.lbl_metodo_pago = new System.Windows.Forms.Label();
            this.cbo_tipo_pago = new System.Windows.Forms.ComboBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_quitar = new System.Windows.Forms.Button();
            this.lbl_serie_comprobante = new System.Windows.Forms.Label();
            this.txt_serie_comprobante = new System.Windows.Forms.TextBox();
            this.dgv_control_producto = new System.Windows.Forms.DataGridView();
            this.btn_vender = new System.Windows.Forms.Button();
            this.cbo_cliente = new System.Windows.Forms.ComboBox();
            this.lbl_numero_doc_cliente = new System.Windows.Forms.Label();
            this.grp_monetario = new System.Windows.Forms.GroupBox();
            this.nud_mano_obra = new System.Windows.Forms.NumericUpDown();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.txt_subtotal = new System.Windows.Forms.TextBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_mano_obra = new System.Windows.Forms.Label();
            this.lbl_subtotal = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.nud_descuento = new System.Windows.Forms.NumericUpDown();
            this.lbl_descuento = new System.Windows.Forms.Label();
            this.lbl_id_producto = new System.Windows.Forms.Label();
            this.nud_cantidad = new System.Windows.Forms.NumericUpDown();
            this.nud_precio_venta = new System.Windows.Forms.NumericUpDown();
            this.lbl_precio_unitario = new System.Windows.Forms.Label();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.lbl_nom_prod = new System.Windows.Forms.Label();
            this.cbo_empleado = new System.Windows.Forms.ComboBox();
            this.lbl_atencion_empleado = new System.Windows.Forms.Label();
            this.grp_facturacion = new System.Windows.Forms.GroupBox();
            this.lbl_empleado = new System.Windows.Forms.Label();
            this.lbl_nom_cliente = new System.Windows.Forms.Label();
            this.grp_producto = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_stock = new System.Windows.Forms.Label();
            this.pic_volver = new System.Windows.Forms.PictureBox();
            this.lbl_advertencia = new System.Windows.Forms.Label();
            this.lbl_nom_pro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_control_producto)).BeginInit();
            this.grp_monetario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_mano_obra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_descuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_precio_venta)).BeginInit();
            this.grp_facturacion.SuspendLayout();
            this.grp_producto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_volver)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nueva_venta
            // 
            this.lbl_nueva_venta.AutoSize = true;
            this.lbl_nueva_venta.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nueva_venta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.lbl_nueva_venta.Location = new System.Drawing.Point(445, 9);
            this.lbl_nueva_venta.Name = "lbl_nueva_venta";
            this.lbl_nueva_venta.Size = new System.Drawing.Size(187, 32);
            this.lbl_nueva_venta.TabIndex = 38;
            this.lbl_nueva_venta.Text = "Nueva Venta";
            // 
            // lbl_codigo_producto
            // 
            this.lbl_codigo_producto.AutoSize = true;
            this.lbl_codigo_producto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo_producto.Location = new System.Drawing.Point(7, 52);
            this.lbl_codigo_producto.Name = "lbl_codigo_producto";
            this.lbl_codigo_producto.Size = new System.Drawing.Size(158, 18);
            this.lbl_codigo_producto.TabIndex = 88;
            this.lbl_codigo_producto.Text = "Código de Producto";
            // 
            // cbo_producto
            // 
            this.cbo_producto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbo_producto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_producto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_producto.FormattingEnabled = true;
            this.cbo_producto.Location = new System.Drawing.Point(10, 83);
            this.cbo_producto.Name = "cbo_producto";
            this.cbo_producto.Size = new System.Drawing.Size(191, 25);
            this.cbo_producto.TabIndex = 1;
            this.cbo_producto.SelectedIndexChanged += new System.EventHandler(this.cbo_producto_SelectedIndexChanged);
            // 
            // lbl_numero_comprobante
            // 
            this.lbl_numero_comprobante.AutoSize = true;
            this.lbl_numero_comprobante.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numero_comprobante.Location = new System.Drawing.Point(252, 145);
            this.lbl_numero_comprobante.Name = "lbl_numero_comprobante";
            this.lbl_numero_comprobante.Size = new System.Drawing.Size(175, 18);
            this.lbl_numero_comprobante.TabIndex = 88;
            this.lbl_numero_comprobante.Text = "Numero Comprobante";
            // 
            // txt_numero_comprobante
            // 
            this.txt_numero_comprobante.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numero_comprobante.Location = new System.Drawing.Point(255, 174);
            this.txt_numero_comprobante.Name = "txt_numero_comprobante";
            this.txt_numero_comprobante.Size = new System.Drawing.Size(176, 23);
            this.txt_numero_comprobante.TabIndex = 9;
            this.txt_numero_comprobante.Text = "00001";
            // 
            // cbo_comprobante
            // 
            this.cbo_comprobante.AutoCompleteCustomSource.AddRange(new string[] {
            "Boleta",
            "Factura"});
            this.cbo_comprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_comprobante.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_comprobante.FormattingEnabled = true;
            this.cbo_comprobante.Items.AddRange(new object[] {
            "Boleta",
            "Factura"});
            this.cbo_comprobante.Location = new System.Drawing.Point(9, 64);
            this.cbo_comprobante.Name = "cbo_comprobante";
            this.cbo_comprobante.Size = new System.Drawing.Size(223, 25);
            this.cbo_comprobante.TabIndex = 6;
            this.cbo_comprobante.SelectedIndexChanged += new System.EventHandler(this.cbo_comprobante_SelectedIndexChanged);
            // 
            // lbl_tipo_comprobante
            // 
            this.lbl_tipo_comprobante.AutoSize = true;
            this.lbl_tipo_comprobante.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo_comprobante.Location = new System.Drawing.Point(6, 31);
            this.lbl_tipo_comprobante.Name = "lbl_tipo_comprobante";
            this.lbl_tipo_comprobante.Size = new System.Drawing.Size(170, 18);
            this.lbl_tipo_comprobante.TabIndex = 88;
            this.lbl_tipo_comprobante.Text = "Tipo de Comprobante";
            // 
            // lbl_metodo_pago
            // 
            this.lbl_metodo_pago.AutoSize = true;
            this.lbl_metodo_pago.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_metodo_pago.Location = new System.Drawing.Point(157, 25);
            this.lbl_metodo_pago.Name = "lbl_metodo_pago";
            this.lbl_metodo_pago.Size = new System.Drawing.Size(132, 18);
            this.lbl_metodo_pago.TabIndex = 88;
            this.lbl_metodo_pago.Text = "Método de Pago";
            // 
            // cbo_tipo_pago
            // 
            this.cbo_tipo_pago.AutoCompleteCustomSource.AddRange(new string[] {
            "Boleta",
            "Factura"});
            this.cbo_tipo_pago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tipo_pago.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_tipo_pago.FormattingEnabled = true;
            this.cbo_tipo_pago.Items.AddRange(new object[] {
            "Efectivo",
            "Mastercard",
            "Visa"});
            this.cbo_tipo_pago.Location = new System.Drawing.Point(160, 56);
            this.cbo_tipo_pago.Name = "cbo_tipo_pago";
            this.cbo_tipo_pago.Size = new System.Drawing.Size(223, 25);
            this.cbo_tipo_pago.TabIndex = 12;
            this.cbo_tipo_pago.SelectedIndexChanged += new System.EventHandler(this.cbo_tipo_pago_SelectedIndexChanged);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Enabled = false;
            this.btn_agregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_agregar.FlatAppearance.BorderSize = 2;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_agregar.Location = new System.Drawing.Point(357, 70);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(101, 45);
            this.btn_agregar.TabIndex = 4;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_quitar
            // 
            this.btn_quitar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_quitar.FlatAppearance.BorderSize = 2;
            this.btn_quitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quitar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quitar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_quitar.Location = new System.Drawing.Point(357, 131);
            this.btn_quitar.Name = "btn_quitar";
            this.btn_quitar.Size = new System.Drawing.Size(101, 45);
            this.btn_quitar.TabIndex = 5;
            this.btn_quitar.Text = "Quitar";
            this.btn_quitar.UseVisualStyleBackColor = true;
            this.btn_quitar.Click += new System.EventHandler(this.btn_quitar_Click);
            // 
            // lbl_serie_comprobante
            // 
            this.lbl_serie_comprobante.AutoSize = true;
            this.lbl_serie_comprobante.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_serie_comprobante.Location = new System.Drawing.Point(6, 145);
            this.lbl_serie_comprobante.Name = "lbl_serie_comprobante";
            this.lbl_serie_comprobante.Size = new System.Drawing.Size(153, 18);
            this.lbl_serie_comprobante.TabIndex = 88;
            this.lbl_serie_comprobante.Text = "Serie Comprobante";
            // 
            // txt_serie_comprobante
            // 
            this.txt_serie_comprobante.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_serie_comprobante.Location = new System.Drawing.Point(9, 174);
            this.txt_serie_comprobante.Name = "txt_serie_comprobante";
            this.txt_serie_comprobante.Size = new System.Drawing.Size(150, 23);
            this.txt_serie_comprobante.TabIndex = 8;
            this.txt_serie_comprobante.Text = "002";
            // 
            // dgv_control_producto
            // 
            this.dgv_control_producto.AllowUserToAddRows = false;
            this.dgv_control_producto.AllowUserToDeleteRows = false;
            this.dgv_control_producto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_control_producto.BackgroundColor = System.Drawing.Color.White;
            this.dgv_control_producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_control_producto.Location = new System.Drawing.Point(520, 55);
            this.dgv_control_producto.MultiSelect = false;
            this.dgv_control_producto.Name = "dgv_control_producto";
            this.dgv_control_producto.ReadOnly = true;
            this.dgv_control_producto.RowHeadersVisible = false;
            this.dgv_control_producto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_control_producto.Size = new System.Drawing.Size(438, 234);
            this.dgv_control_producto.TabIndex = 126;
            this.dgv_control_producto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_control_producto_CellContentClick);
            this.dgv_control_producto.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv_control_producto_RowsAdded);
            // 
            // btn_vender
            // 
            this.btn_vender.Enabled = false;
            this.btn_vender.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_vender.FlatAppearance.BorderSize = 2;
            this.btn_vender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vender.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_vender.Location = new System.Drawing.Point(538, 549);
            this.btn_vender.Name = "btn_vender";
            this.btn_vender.Size = new System.Drawing.Size(101, 39);
            this.btn_vender.TabIndex = 14;
            this.btn_vender.Text = "Vender";
            this.btn_vender.UseVisualStyleBackColor = true;
            this.btn_vender.Click += new System.EventHandler(this.btn_vender_Click);
            // 
            // cbo_cliente
            // 
            this.cbo_cliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbo_cliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_cliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_cliente.FormattingEnabled = true;
            this.cbo_cliente.Location = new System.Drawing.Point(255, 64);
            this.cbo_cliente.Name = "cbo_cliente";
            this.cbo_cliente.Size = new System.Drawing.Size(223, 25);
            this.cbo_cliente.TabIndex = 7;
            this.cbo_cliente.SelectedIndexChanged += new System.EventHandler(this.Cbo_cliente_SelectedIndexChanged);
            // 
            // lbl_numero_doc_cliente
            // 
            this.lbl_numero_doc_cliente.AutoSize = true;
            this.lbl_numero_doc_cliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numero_doc_cliente.Location = new System.Drawing.Point(252, 31);
            this.lbl_numero_doc_cliente.Name = "lbl_numero_doc_cliente";
            this.lbl_numero_doc_cliente.Size = new System.Drawing.Size(157, 18);
            this.lbl_numero_doc_cliente.TabIndex = 127;
            this.lbl_numero_doc_cliente.Text = "RUC/DNI del Cliente";
            // 
            // grp_monetario
            // 
            this.grp_monetario.Controls.Add(this.nud_mano_obra);
            this.grp_monetario.Controls.Add(this.txt_total);
            this.grp_monetario.Controls.Add(this.txt_subtotal);
            this.grp_monetario.Controls.Add(this.lbl_total);
            this.grp_monetario.Controls.Add(this.lbl_mano_obra);
            this.grp_monetario.Controls.Add(this.lbl_subtotal);
            this.grp_monetario.Controls.Add(this.cbo_tipo_pago);
            this.grp_monetario.Controls.Add(this.btn_calcular);
            this.grp_monetario.Controls.Add(this.lbl_metodo_pago);
            this.grp_monetario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_monetario.Location = new System.Drawing.Point(538, 311);
            this.grp_monetario.Name = "grp_monetario";
            this.grp_monetario.Size = new System.Drawing.Size(394, 219);
            this.grp_monetario.TabIndex = 129;
            this.grp_monetario.TabStop = false;
            this.grp_monetario.Text = "Monetario";
            // 
            // nud_mano_obra
            // 
            this.nud_mano_obra.DecimalPlaces = 2;
            this.nud_mano_obra.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_mano_obra.Location = new System.Drawing.Point(9, 114);
            this.nud_mano_obra.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nud_mano_obra.Name = "nud_mano_obra";
            this.nud_mano_obra.Size = new System.Drawing.Size(120, 23);
            this.nud_mano_obra.TabIndex = 11;
            this.nud_mano_obra.ValueChanged += new System.EventHandler(this.nud_mano_obra_ValueChanged);
            // 
            // txt_total
            // 
            this.txt_total.Enabled = false;
            this.txt_total.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(6, 180);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(123, 23);
            this.txt_total.TabIndex = 133;
            // 
            // txt_subtotal
            // 
            this.txt_subtotal.Enabled = false;
            this.txt_subtotal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_subtotal.Location = new System.Drawing.Point(9, 56);
            this.txt_subtotal.Name = "txt_subtotal";
            this.txt_subtotal.Size = new System.Drawing.Size(123, 23);
            this.txt_subtotal.TabIndex = 134;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(6, 158);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(42, 18);
            this.lbl_total.TabIndex = 127;
            this.lbl_total.Text = "Total";
            // 
            // lbl_mano_obra
            // 
            this.lbl_mano_obra.AutoSize = true;
            this.lbl_mano_obra.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mano_obra.Location = new System.Drawing.Point(6, 92);
            this.lbl_mano_obra.Name = "lbl_mano_obra";
            this.lbl_mano_obra.Size = new System.Drawing.Size(117, 18);
            this.lbl_mano_obra.TabIndex = 128;
            this.lbl_mano_obra.Text = "Mano de Obra";
            // 
            // lbl_subtotal
            // 
            this.lbl_subtotal.AutoSize = true;
            this.lbl_subtotal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subtotal.Location = new System.Drawing.Point(6, 25);
            this.lbl_subtotal.Name = "lbl_subtotal";
            this.lbl_subtotal.Size = new System.Drawing.Size(67, 18);
            this.lbl_subtotal.TabIndex = 130;
            this.lbl_subtotal.Text = "Subtotal";
            // 
            // btn_calcular
            // 
            this.btn_calcular.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_calcular.FlatAppearance.BorderSize = 2;
            this.btn_calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calcular.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_calcular.Location = new System.Drawing.Point(222, 131);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(101, 39);
            this.btn_calcular.TabIndex = 13;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // nud_descuento
            // 
            this.nud_descuento.DecimalPlaces = 2;
            this.nud_descuento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_descuento.Location = new System.Drawing.Point(218, 153);
            this.nud_descuento.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nud_descuento.Name = "nud_descuento";
            this.nud_descuento.Size = new System.Drawing.Size(120, 23);
            this.nud_descuento.TabIndex = 3;
            // 
            // lbl_descuento
            // 
            this.lbl_descuento.AutoSize = true;
            this.lbl_descuento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descuento.Location = new System.Drawing.Point(215, 129);
            this.lbl_descuento.Name = "lbl_descuento";
            this.lbl_descuento.Size = new System.Drawing.Size(87, 18);
            this.lbl_descuento.TabIndex = 129;
            this.lbl_descuento.Text = "Descuento";
            // 
            // lbl_id_producto
            // 
            this.lbl_id_producto.AutoSize = true;
            this.lbl_id_producto.Location = new System.Drawing.Point(777, 39);
            this.lbl_id_producto.Name = "lbl_id_producto";
            this.lbl_id_producto.Size = new System.Drawing.Size(67, 13);
            this.lbl_id_producto.TabIndex = 130;
            this.lbl_id_producto.Text = "ID_Producto";
            this.lbl_id_producto.Visible = false;
            this.lbl_id_producto.TextChanged += new System.EventHandler(this.lbl_id_producto_TextChanged);
            // 
            // nud_cantidad
            // 
            this.nud_cantidad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_cantidad.Location = new System.Drawing.Point(10, 156);
            this.nud_cantidad.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nud_cantidad.Name = "nud_cantidad";
            this.nud_cantidad.Size = new System.Drawing.Size(120, 23);
            this.nud_cantidad.TabIndex = 2;
            this.nud_cantidad.ValueChanged += new System.EventHandler(this.nud_cantidad_ValueChanged);
            // 
            // nud_precio_venta
            // 
            this.nud_precio_venta.DecimalPlaces = 2;
            this.nud_precio_venta.Enabled = false;
            this.nud_precio_venta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_precio_venta.Location = new System.Drawing.Point(218, 80);
            this.nud_precio_venta.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nud_precio_venta.Name = "nud_precio_venta";
            this.nud_precio_venta.Size = new System.Drawing.Size(120, 23);
            this.nud_precio_venta.TabIndex = 136;
            // 
            // lbl_precio_unitario
            // 
            this.lbl_precio_unitario.AutoSize = true;
            this.lbl_precio_unitario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio_unitario.Location = new System.Drawing.Point(215, 49);
            this.lbl_precio_unitario.Name = "lbl_precio_unitario";
            this.lbl_precio_unitario.Size = new System.Drawing.Size(115, 18);
            this.lbl_precio_unitario.TabIndex = 88;
            this.lbl_precio_unitario.Text = "Precio Unitario";
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad.Location = new System.Drawing.Point(7, 132);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(77, 18);
            this.lbl_cantidad.TabIndex = 88;
            this.lbl_cantidad.Text = "Cantidad";
            // 
            // lbl_nom_prod
            // 
            this.lbl_nom_prod.AutoSize = true;
            this.lbl_nom_prod.Location = new System.Drawing.Point(535, 39);
            this.lbl_nom_prod.Name = "lbl_nom_prod";
            this.lbl_nom_prod.Size = new System.Drawing.Size(87, 13);
            this.lbl_nom_prod.TabIndex = 137;
            this.lbl_nom_prod.Text = "NombreProducto";
            this.lbl_nom_prod.Visible = false;
            // 
            // cbo_empleado
            // 
            this.cbo_empleado.AutoCompleteCustomSource.AddRange(new string[] {
            "Boleta",
            "Factura"});
            this.cbo_empleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_empleado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_empleado.FormattingEnabled = true;
            this.cbo_empleado.Location = new System.Drawing.Point(6, 241);
            this.cbo_empleado.Name = "cbo_empleado";
            this.cbo_empleado.Size = new System.Drawing.Size(223, 25);
            this.cbo_empleado.TabIndex = 10;
            this.cbo_empleado.SelectedIndexChanged += new System.EventHandler(this.Cbo_empleado_SelectedIndexChanged);
            // 
            // lbl_atencion_empleado
            // 
            this.lbl_atencion_empleado.AutoSize = true;
            this.lbl_atencion_empleado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_atencion_empleado.Location = new System.Drawing.Point(3, 218);
            this.lbl_atencion_empleado.Name = "lbl_atencion_empleado";
            this.lbl_atencion_empleado.Size = new System.Drawing.Size(179, 18);
            this.lbl_atencion_empleado.TabIndex = 88;
            this.lbl_atencion_empleado.Text = "Atención de Empleado";
            // 
            // grp_facturacion
            // 
            this.grp_facturacion.Controls.Add(this.txt_numero_comprobante);
            this.grp_facturacion.Controls.Add(this.lbl_tipo_comprobante);
            this.grp_facturacion.Controls.Add(this.lbl_atencion_empleado);
            this.grp_facturacion.Controls.Add(this.lbl_empleado);
            this.grp_facturacion.Controls.Add(this.lbl_nom_cliente);
            this.grp_facturacion.Controls.Add(this.lbl_numero_comprobante);
            this.grp_facturacion.Controls.Add(this.lbl_serie_comprobante);
            this.grp_facturacion.Controls.Add(this.cbo_comprobante);
            this.grp_facturacion.Controls.Add(this.cbo_empleado);
            this.grp_facturacion.Controls.Add(this.txt_serie_comprobante);
            this.grp_facturacion.Controls.Add(this.cbo_cliente);
            this.grp_facturacion.Controls.Add(this.lbl_numero_doc_cliente);
            this.grp_facturacion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_facturacion.Location = new System.Drawing.Point(26, 295);
            this.grp_facturacion.Name = "grp_facturacion";
            this.grp_facturacion.Size = new System.Drawing.Size(497, 293);
            this.grp_facturacion.TabIndex = 138;
            this.grp_facturacion.TabStop = false;
            this.grp_facturacion.Text = "Facturación";
            // 
            // lbl_empleado
            // 
            this.lbl_empleado.AutoSize = true;
            this.lbl_empleado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empleado.Location = new System.Drawing.Point(252, 242);
            this.lbl_empleado.Name = "lbl_empleado";
            this.lbl_empleado.Size = new System.Drawing.Size(176, 18);
            this.lbl_empleado.TabIndex = 88;
            this.lbl_empleado.Text = "Nombre del Empleado";
            // 
            // lbl_nom_cliente
            // 
            this.lbl_nom_cliente.AutoSize = true;
            this.lbl_nom_cliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nom_cliente.Location = new System.Drawing.Point(151, 111);
            this.lbl_nom_cliente.Name = "lbl_nom_cliente";
            this.lbl_nom_cliente.Size = new System.Drawing.Size(153, 18);
            this.lbl_nom_cliente.TabIndex = 88;
            this.lbl_nom_cliente.Text = "Nombre del Cliente";
            // 
            // grp_producto
            // 
            this.grp_producto.Controls.Add(this.btn_quitar);
            this.grp_producto.Controls.Add(this.lbl_codigo_producto);
            this.grp_producto.Controls.Add(this.lbl_precio_unitario);
            this.grp_producto.Controls.Add(this.lbl_nom_pro);
            this.grp_producto.Controls.Add(this.label1);
            this.grp_producto.Controls.Add(this.lbl_stock);
            this.grp_producto.Controls.Add(this.nud_descuento);
            this.grp_producto.Controls.Add(this.lbl_cantidad);
            this.grp_producto.Controls.Add(this.cbo_producto);
            this.grp_producto.Controls.Add(this.nud_precio_venta);
            this.grp_producto.Controls.Add(this.btn_agregar);
            this.grp_producto.Controls.Add(this.nud_cantidad);
            this.grp_producto.Controls.Add(this.lbl_descuento);
            this.grp_producto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_producto.Location = new System.Drawing.Point(26, 55);
            this.grp_producto.Name = "grp_producto";
            this.grp_producto.Size = new System.Drawing.Size(478, 234);
            this.grp_producto.TabIndex = 139;
            this.grp_producto.TabStop = false;
            this.grp_producto.Text = "Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 130;
            this.label1.Text = "Stock del Producto:";
            this.label1.TextChanged += new System.EventHandler(this.lbl_id_producto_TextChanged);
            // 
            // lbl_stock
            // 
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.Location = new System.Drawing.Point(148, 191);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(43, 17);
            this.lbl_stock.TabIndex = 130;
            this.lbl_stock.Text = "Stock";
            this.lbl_stock.TextChanged += new System.EventHandler(this.lbl_id_producto_TextChanged);
            // 
            // pic_volver
            // 
            this.pic_volver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_volver.Image = global::Ventana_Inicial.Properties.Resources.Atras;
            this.pic_volver.Location = new System.Drawing.Point(89, 9);
            this.pic_volver.Name = "pic_volver";
            this.pic_volver.Size = new System.Drawing.Size(20, 32);
            this.pic_volver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_volver.TabIndex = 39;
            this.pic_volver.TabStop = false;
            this.pic_volver.Click += new System.EventHandler(this.pic_volver_Click);
            // 
            // lbl_advertencia
            // 
            this.lbl_advertencia.AutoSize = true;
            this.lbl_advertencia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_advertencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_advertencia.Location = new System.Drawing.Point(535, 295);
            this.lbl_advertencia.Name = "lbl_advertencia";
            this.lbl_advertencia.Size = new System.Drawing.Size(87, 17);
            this.lbl_advertencia.TabIndex = 140;
            this.lbl_advertencia.Text = "Advertencia";
            this.lbl_advertencia.Visible = false;
            // 
            // lbl_nom_pro
            // 
            this.lbl_nom_pro.AutoSize = true;
            this.lbl_nom_pro.Location = new System.Drawing.Point(7, 115);
            this.lbl_nom_pro.Name = "lbl_nom_pro";
            this.lbl_nom_pro.Size = new System.Drawing.Size(149, 17);
            this.lbl_nom_pro.TabIndex = 130;
            this.lbl_nom_pro.Text = "Nombre del Producto";
            this.lbl_nom_pro.TextChanged += new System.EventHandler(this.lbl_id_producto_TextChanged);
            // 
            // frm_nueva_venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.lbl_advertencia);
            this.Controls.Add(this.grp_producto);
            this.Controls.Add(this.grp_facturacion);
            this.Controls.Add(this.lbl_nom_prod);
            this.Controls.Add(this.lbl_id_producto);
            this.Controls.Add(this.grp_monetario);
            this.Controls.Add(this.dgv_control_producto);
            this.Controls.Add(this.btn_vender);
            this.Controls.Add(this.pic_volver);
            this.Controls.Add(this.lbl_nueva_venta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_nueva_venta";
            this.Text = "Nueva_Venta";
            this.Load += new System.EventHandler(this.frm_nueva_venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_control_producto)).EndInit();
            this.grp_monetario.ResumeLayout(false);
            this.grp_monetario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_mano_obra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_descuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_precio_venta)).EndInit();
            this.grp_facturacion.ResumeLayout(false);
            this.grp_facturacion.PerformLayout();
            this.grp_producto.ResumeLayout(false);
            this.grp_producto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_volver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_volver;
        private System.Windows.Forms.Label lbl_nueva_venta;
        private System.Windows.Forms.Label lbl_codigo_producto;
        public System.Windows.Forms.ComboBox cbo_producto;
        private System.Windows.Forms.Label lbl_numero_comprobante;
        private System.Windows.Forms.TextBox txt_numero_comprobante;
        public System.Windows.Forms.ComboBox cbo_comprobante;
        private System.Windows.Forms.Label lbl_tipo_comprobante;
        private System.Windows.Forms.Label lbl_metodo_pago;
        public System.Windows.Forms.ComboBox cbo_tipo_pago;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_quitar;
        private System.Windows.Forms.Label lbl_serie_comprobante;
        private System.Windows.Forms.TextBox txt_serie_comprobante;
        public System.Windows.Forms.DataGridView dgv_control_producto;
        private System.Windows.Forms.Button btn_vender;
        public System.Windows.Forms.ComboBox cbo_cliente;
        private System.Windows.Forms.Label lbl_numero_doc_cliente;
        private System.Windows.Forms.GroupBox grp_monetario;
        private System.Windows.Forms.NumericUpDown nud_mano_obra;
        private System.Windows.Forms.NumericUpDown nud_descuento;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.TextBox txt_subtotal;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_mano_obra;
        private System.Windows.Forms.Label lbl_descuento;
        private System.Windows.Forms.Label lbl_subtotal;
        private System.Windows.Forms.Label lbl_id_producto;
        private System.Windows.Forms.NumericUpDown nud_cantidad;
        private System.Windows.Forms.NumericUpDown nud_precio_venta;
        private System.Windows.Forms.Label lbl_precio_unitario;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.Label lbl_nom_prod;
        public System.Windows.Forms.ComboBox cbo_empleado;
        private System.Windows.Forms.Label lbl_atencion_empleado;
        private System.Windows.Forms.GroupBox grp_facturacion;
        private System.Windows.Forms.GroupBox grp_producto;
        private System.Windows.Forms.Label lbl_stock;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label lbl_nom_cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_empleado;
        private System.Windows.Forms.Label lbl_advertencia;
        private System.Windows.Forms.Label lbl_nom_pro;
    }
}