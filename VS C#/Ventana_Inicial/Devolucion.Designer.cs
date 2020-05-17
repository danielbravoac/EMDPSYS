namespace Ventana_Inicial
{
    partial class frm_devolucion
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
            this.lbl_nom_prod = new System.Windows.Forms.Label();
            this.lbl_id_producto = new System.Windows.Forms.Label();
            this.dgv_control_producto = new System.Windows.Forms.DataGridView();
            this.lbl_control_devolucion = new System.Windows.Forms.Label();
            this.pic_volver = new System.Windows.Forms.PictureBox();
            this.btn_registrar_devolucion = new System.Windows.Forms.Button();
            this.lbl_id_devolucion = new System.Windows.Forms.Label();
            this.lbl_proveedor = new System.Windows.Forms.Label();
            this.lbl_stock = new System.Windows.Forms.Label();
            this.dgv_pedido = new System.Windows.Forms.DataGridView();
            this.cbo_ingresos = new System.Windows.Forms.ComboBox();
            this.lbl_venta = new System.Windows.Forms.Label();
            this.cbo_tipo_documento = new System.Windows.Forms.ComboBox();
            this.grp_producto = new System.Windows.Forms.GroupBox();
            this.nud_cantidad = new System.Windows.Forms.NumericUpDown();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.cbo_producto = new System.Windows.Forms.ComboBox();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.lbl_codigo_producto = new System.Windows.Forms.Label();
            this.btn_quitar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_control_producto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_volver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pedido)).BeginInit();
            this.grp_producto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nom_prod
            // 
            this.lbl_nom_prod.AutoSize = true;
            this.lbl_nom_prod.Location = new System.Drawing.Point(535, 47);
            this.lbl_nom_prod.Name = "lbl_nom_prod";
            this.lbl_nom_prod.Size = new System.Drawing.Size(87, 13);
            this.lbl_nom_prod.TabIndex = 143;
            this.lbl_nom_prod.Text = "NombreProducto";
            this.lbl_nom_prod.Visible = false;
            // 
            // lbl_id_producto
            // 
            this.lbl_id_producto.AutoSize = true;
            this.lbl_id_producto.Location = new System.Drawing.Point(777, 47);
            this.lbl_id_producto.Name = "lbl_id_producto";
            this.lbl_id_producto.Size = new System.Drawing.Size(67, 13);
            this.lbl_id_producto.TabIndex = 142;
            this.lbl_id_producto.Text = "ID_Producto";
            this.lbl_id_producto.TextChanged += new System.EventHandler(this.lbl_id_producto_TextChanged);
            // 
            // dgv_control_producto
            // 
            this.dgv_control_producto.AllowUserToAddRows = false;
            this.dgv_control_producto.AllowUserToDeleteRows = false;
            this.dgv_control_producto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_control_producto.BackgroundColor = System.Drawing.Color.White;
            this.dgv_control_producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_control_producto.Enabled = false;
            this.dgv_control_producto.Location = new System.Drawing.Point(527, 279);
            this.dgv_control_producto.MultiSelect = false;
            this.dgv_control_producto.Name = "dgv_control_producto";
            this.dgv_control_producto.ReadOnly = true;
            this.dgv_control_producto.RowHeadersVisible = false;
            this.dgv_control_producto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_control_producto.Size = new System.Drawing.Size(465, 250);
            this.dgv_control_producto.TabIndex = 141;
            // 
            // lbl_control_devolucion
            // 
            this.lbl_control_devolucion.AutoSize = true;
            this.lbl_control_devolucion.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_control_devolucion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.lbl_control_devolucion.Location = new System.Drawing.Point(390, 15);
            this.lbl_control_devolucion.Name = "lbl_control_devolucion";
            this.lbl_control_devolucion.Size = new System.Drawing.Size(281, 32);
            this.lbl_control_devolucion.TabIndex = 140;
            this.lbl_control_devolucion.Text = "[Control] Devolucion";
            // 
            // pic_volver
            // 
            this.pic_volver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_volver.Image = global::Ventana_Inicial.Properties.Resources.Atras;
            this.pic_volver.Location = new System.Drawing.Point(26, 15);
            this.pic_volver.Name = "pic_volver";
            this.pic_volver.Size = new System.Drawing.Size(20, 32);
            this.pic_volver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_volver.TabIndex = 145;
            this.pic_volver.TabStop = false;
            this.pic_volver.Click += new System.EventHandler(this.pic_volver_Click);
            // 
            // btn_registrar_devolucion
            // 
            this.btn_registrar_devolucion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_registrar_devolucion.FlatAppearance.BorderSize = 2;
            this.btn_registrar_devolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar_devolucion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar_devolucion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_registrar_devolucion.Location = new System.Drawing.Point(838, 543);
            this.btn_registrar_devolucion.Name = "btn_registrar_devolucion";
            this.btn_registrar_devolucion.Size = new System.Drawing.Size(200, 45);
            this.btn_registrar_devolucion.TabIndex = 146;
            this.btn_registrar_devolucion.Text = "Registrar Devolucion";
            this.btn_registrar_devolucion.UseVisualStyleBackColor = true;
            this.btn_registrar_devolucion.Click += new System.EventHandler(this.btn_registrar_devolucion_Click);
            // 
            // lbl_id_devolucion
            // 
            this.lbl_id_devolucion.AutoSize = true;
            this.lbl_id_devolucion.Location = new System.Drawing.Point(194, 47);
            this.lbl_id_devolucion.Name = "lbl_id_devolucion";
            this.lbl_id_devolucion.Size = new System.Drawing.Size(78, 13);
            this.lbl_id_devolucion.TabIndex = 143;
            this.lbl_id_devolucion.Text = "ID_Devolucion";
            this.lbl_id_devolucion.Visible = false;
            // 
            // lbl_proveedor
            // 
            this.lbl_proveedor.AutoSize = true;
            this.lbl_proveedor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_proveedor.Location = new System.Drawing.Point(123, 109);
            this.lbl_proveedor.Name = "lbl_proveedor";
            this.lbl_proveedor.Size = new System.Drawing.Size(153, 17);
            this.lbl_proveedor.TabIndex = 22;
            this.lbl_proveedor.Text = "Tipo de Comprobante";
            // 
            // lbl_stock
            // 
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.Location = new System.Drawing.Point(881, 47);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(35, 13);
            this.lbl_stock.TabIndex = 148;
            this.lbl_stock.Text = "Stock";
            this.lbl_stock.Visible = false;
            // 
            // dgv_pedido
            // 
            this.dgv_pedido.AllowUserToAddRows = false;
            this.dgv_pedido.AllowUserToDeleteRows = false;
            this.dgv_pedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_pedido.BackgroundColor = System.Drawing.Color.White;
            this.dgv_pedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pedido.Location = new System.Drawing.Point(37, 279);
            this.dgv_pedido.MultiSelect = false;
            this.dgv_pedido.Name = "dgv_pedido";
            this.dgv_pedido.ReadOnly = true;
            this.dgv_pedido.RowHeadersVisible = false;
            this.dgv_pedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_pedido.Size = new System.Drawing.Size(465, 250);
            this.dgv_pedido.TabIndex = 141;
            this.dgv_pedido.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgv_pedido_ColumnAdded);
            this.dgv_pedido.CurrentCellChanged += new System.EventHandler(this.dgv_pedido_CurrentCellChanged);
            this.dgv_pedido.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv_pedido_RowsAdded);
            // 
            // cbo_ingresos
            // 
            this.cbo_ingresos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbo_ingresos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_ingresos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_ingresos.FormattingEnabled = true;
            this.cbo_ingresos.Location = new System.Drawing.Point(299, 164);
            this.cbo_ingresos.Name = "cbo_ingresos";
            this.cbo_ingresos.Size = new System.Drawing.Size(191, 25);
            this.cbo_ingresos.TabIndex = 149;
            this.cbo_ingresos.SelectedIndexChanged += new System.EventHandler(this.Cbo_ingresos_SelectedIndexChanged);
            // 
            // lbl_venta
            // 
            this.lbl_venta.AutoSize = true;
            this.lbl_venta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_venta.Location = new System.Drawing.Point(84, 165);
            this.lbl_venta.Name = "lbl_venta";
            this.lbl_venta.Size = new System.Drawing.Size(192, 18);
            this.lbl_venta.TabIndex = 150;
            this.lbl_venta.Text = "Comprobante de Pedido";
            // 
            // cbo_tipo_documento
            // 
            this.cbo_tipo_documento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tipo_documento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_tipo_documento.FormattingEnabled = true;
            this.cbo_tipo_documento.Items.AddRange(new object[] {
            "Factura",
            "Guía de Remisión"});
            this.cbo_tipo_documento.Location = new System.Drawing.Point(299, 109);
            this.cbo_tipo_documento.Name = "cbo_tipo_documento";
            this.cbo_tipo_documento.Size = new System.Drawing.Size(191, 25);
            this.cbo_tipo_documento.TabIndex = 151;
            this.cbo_tipo_documento.SelectedIndexChanged += new System.EventHandler(this.Cbo_tipo_documento_SelectedIndexChanged);
            // 
            // grp_producto
            // 
            this.grp_producto.Controls.Add(this.btn_quitar);
            this.grp_producto.Controls.Add(this.lbl_codigo_producto);
            this.grp_producto.Controls.Add(this.lbl_cantidad);
            this.grp_producto.Controls.Add(this.cbo_producto);
            this.grp_producto.Controls.Add(this.btn_agregar);
            this.grp_producto.Controls.Add(this.nud_cantidad);
            this.grp_producto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_producto.Location = new System.Drawing.Point(538, 63);
            this.grp_producto.Name = "grp_producto";
            this.grp_producto.Size = new System.Drawing.Size(402, 201);
            this.grp_producto.TabIndex = 144;
            this.grp_producto.TabStop = false;
            this.grp_producto.Text = "Producto";
            // 
            // nud_cantidad
            // 
            this.nud_cantidad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_cantidad.Location = new System.Drawing.Point(20, 157);
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
            // btn_agregar
            // 
            this.btn_agregar.Enabled = false;
            this.btn_agregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_agregar.FlatAppearance.BorderSize = 2;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_agregar.Location = new System.Drawing.Point(246, 71);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(101, 45);
            this.btn_agregar.TabIndex = 4;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // cbo_producto
            // 
            this.cbo_producto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbo_producto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_producto.Enabled = false;
            this.cbo_producto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_producto.FormattingEnabled = true;
            this.cbo_producto.Location = new System.Drawing.Point(20, 84);
            this.cbo_producto.Name = "cbo_producto";
            this.cbo_producto.Size = new System.Drawing.Size(191, 25);
            this.cbo_producto.TabIndex = 1;
            this.cbo_producto.SelectedIndexChanged += new System.EventHandler(this.cbo_producto_SelectedIndexChanged);
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad.Location = new System.Drawing.Point(17, 133);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(77, 18);
            this.lbl_cantidad.TabIndex = 88;
            this.lbl_cantidad.Text = "Cantidad";
            // 
            // lbl_codigo_producto
            // 
            this.lbl_codigo_producto.AutoSize = true;
            this.lbl_codigo_producto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo_producto.Location = new System.Drawing.Point(17, 53);
            this.lbl_codigo_producto.Name = "lbl_codigo_producto";
            this.lbl_codigo_producto.Size = new System.Drawing.Size(158, 18);
            this.lbl_codigo_producto.TabIndex = 88;
            this.lbl_codigo_producto.Text = "Código de Producto";
            // 
            // btn_quitar
            // 
            this.btn_quitar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_quitar.FlatAppearance.BorderSize = 2;
            this.btn_quitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quitar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quitar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_quitar.Location = new System.Drawing.Point(246, 132);
            this.btn_quitar.Name = "btn_quitar";
            this.btn_quitar.Size = new System.Drawing.Size(101, 45);
            this.btn_quitar.TabIndex = 5;
            this.btn_quitar.Text = "Quitar";
            this.btn_quitar.UseVisualStyleBackColor = true;
            this.btn_quitar.Click += new System.EventHandler(this.btn_quitar_Click);
            // 
            // frm_devolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.cbo_tipo_documento);
            this.Controls.Add(this.cbo_ingresos);
            this.Controls.Add(this.lbl_venta);
            this.Controls.Add(this.lbl_stock);
            this.Controls.Add(this.lbl_proveedor);
            this.Controls.Add(this.btn_registrar_devolucion);
            this.Controls.Add(this.pic_volver);
            this.Controls.Add(this.grp_producto);
            this.Controls.Add(this.lbl_id_devolucion);
            this.Controls.Add(this.lbl_nom_prod);
            this.Controls.Add(this.lbl_id_producto);
            this.Controls.Add(this.dgv_pedido);
            this.Controls.Add(this.dgv_control_producto);
            this.Controls.Add(this.lbl_control_devolucion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_devolucion";
            this.Text = "Devolucion";
            this.Load += new System.EventHandler(this.frm_devolucion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_control_producto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_volver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pedido)).EndInit();
            this.grp_producto.ResumeLayout(false);
            this.grp_producto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dgv_control_producto;
        private System.Windows.Forms.PictureBox pic_volver;
        public System.Windows.Forms.Label lbl_nom_prod;
        public System.Windows.Forms.Label lbl_id_producto;
        public System.Windows.Forms.Label lbl_control_devolucion;
        public System.Windows.Forms.Button btn_registrar_devolucion;
        public System.Windows.Forms.Label lbl_id_devolucion;
        private System.Windows.Forms.Label lbl_proveedor;
        private System.Windows.Forms.Label lbl_stock;
        public System.Windows.Forms.DataGridView dgv_pedido;
        public System.Windows.Forms.ComboBox cbo_ingresos;
        private System.Windows.Forms.Label lbl_venta;
        public System.Windows.Forms.ComboBox cbo_tipo_documento;
        private System.Windows.Forms.GroupBox grp_producto;
        public System.Windows.Forms.Button btn_quitar;
        public System.Windows.Forms.Label lbl_codigo_producto;
        public System.Windows.Forms.Label lbl_cantidad;
        public System.Windows.Forms.ComboBox cbo_producto;
        public System.Windows.Forms.Button btn_agregar;
        public System.Windows.Forms.NumericUpDown nud_cantidad;
    }
}