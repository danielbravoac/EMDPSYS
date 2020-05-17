namespace Ventana_Inicial
{
    partial class frm_producto
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
            this.txt_codigo_producto = new System.Windows.Forms.TextBox();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.txt_nombre_producto = new System.Windows.Forms.TextBox();
            this.lbl_nombre_producto = new System.Windows.Forms.Label();
            this.nud_precio_venta = new System.Windows.Forms.NumericUpDown();
            this.lbl_precio_venta = new System.Windows.Forms.Label();
            this.lbl_tamano = new System.Windows.Forms.Label();
            this.lbl_color = new System.Windows.Forms.Label();
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.lbl_subcategoria = new System.Windows.Forms.Label();
            this.lbl_ocasion = new System.Windows.Forms.Label();
            this.lbl_familia = new System.Windows.Forms.Label();
            this.cbo_categoria = new System.Windows.Forms.ComboBox();
            this.cbo_subcategoria = new System.Windows.Forms.ComboBox();
            this.cbo_ocasion = new System.Windows.Forms.ComboBox();
            this.cbo_familia = new System.Windows.Forms.ComboBox();
            this.cbo_color = new System.Windows.Forms.ComboBox();
            this.nud_tamano_producto = new System.Windows.Forms.NumericUpDown();
            this.lbl_cm = new System.Windows.Forms.Label();
            this.txt_detalle_diferencial = new System.Windows.Forms.TextBox();
            this.lbl_detalle_diferencial = new System.Windows.Forms.Label();
            this.btn_registrar_producto = new System.Windows.Forms.Button();
            this.lbl_control_producto = new System.Windows.Forms.Label();
            this.nud_stock_producto = new System.Windows.Forms.NumericUpDown();
            this.lbl_stock = new System.Windows.Forms.Label();
            this.lbl_id_codigo = new System.Windows.Forms.Label();
            this.pic_volver = new System.Windows.Forms.PictureBox();
            this.lbl_id_producto = new System.Windows.Forms.Label();
            this.btn_actualizar_producto = new System.Windows.Forms.Button();
            this.dtp_ultimo_pedido = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_precio_venta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_tamano_producto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_stock_producto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_volver)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_codigo_producto
            // 
            this.txt_codigo_producto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_codigo_producto.Enabled = false;
            this.txt_codigo_producto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo_producto.Location = new System.Drawing.Point(291, 122);
            this.txt_codigo_producto.Name = "txt_codigo_producto";
            this.txt_codigo_producto.Size = new System.Drawing.Size(338, 23);
            this.txt_codigo_producto.TabIndex = 1;
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.Location = new System.Drawing.Point(206, 122);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(64, 18);
            this.lbl_codigo.TabIndex = 1;
            this.lbl_codigo.Text = "Código";
            // 
            // txt_nombre_producto
            // 
            this.txt_nombre_producto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nombre_producto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_producto.Location = new System.Drawing.Point(291, 159);
            this.txt_nombre_producto.Name = "txt_nombre_producto";
            this.txt_nombre_producto.Size = new System.Drawing.Size(338, 23);
            this.txt_nombre_producto.TabIndex = 2;
            this.txt_nombre_producto.TextChanged += new System.EventHandler(this.txt_nombre_producto_TextChanged);
            // 
            // lbl_nombre_producto
            // 
            this.lbl_nombre_producto.AutoSize = true;
            this.lbl_nombre_producto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_producto.Location = new System.Drawing.Point(104, 159);
            this.lbl_nombre_producto.Name = "lbl_nombre_producto";
            this.lbl_nombre_producto.Size = new System.Drawing.Size(166, 18);
            this.lbl_nombre_producto.TabIndex = 1;
            this.lbl_nombre_producto.Text = "Nombre del Producto";
            // 
            // nud_precio_venta
            // 
            this.nud_precio_venta.DecimalPlaces = 2;
            this.nud_precio_venta.Enabled = false;
            this.nud_precio_venta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_precio_venta.Location = new System.Drawing.Point(291, 236);
            this.nud_precio_venta.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nud_precio_venta.Name = "nud_precio_venta";
            this.nud_precio_venta.Size = new System.Drawing.Size(120, 23);
            this.nud_precio_venta.TabIndex = 4;
            // 
            // lbl_precio_venta
            // 
            this.lbl_precio_venta.AutoSize = true;
            this.lbl_precio_venta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio_venta.Location = new System.Drawing.Point(143, 237);
            this.lbl_precio_venta.Name = "lbl_precio_venta";
            this.lbl_precio_venta.Size = new System.Drawing.Size(127, 18);
            this.lbl_precio_venta.TabIndex = 1;
            this.lbl_precio_venta.Text = "Precio de Venta";
            // 
            // lbl_tamano
            // 
            this.lbl_tamano.AutoSize = true;
            this.lbl_tamano.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tamano.Location = new System.Drawing.Point(203, 477);
            this.lbl_tamano.Name = "lbl_tamano";
            this.lbl_tamano.Size = new System.Drawing.Size(67, 18);
            this.lbl_tamano.TabIndex = 1;
            this.lbl_tamano.Text = "Tamaño";
            // 
            // lbl_color
            // 
            this.lbl_color.AutoSize = true;
            this.lbl_color.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_color.Location = new System.Drawing.Point(221, 437);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(49, 18);
            this.lbl_color.TabIndex = 1;
            this.lbl_color.Text = "Color";
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categoria.Location = new System.Drawing.Point(187, 277);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(83, 18);
            this.lbl_categoria.TabIndex = 1;
            this.lbl_categoria.Text = "Categoria";
            // 
            // lbl_subcategoria
            // 
            this.lbl_subcategoria.AutoSize = true;
            this.lbl_subcategoria.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subcategoria.Location = new System.Drawing.Point(162, 317);
            this.lbl_subcategoria.Name = "lbl_subcategoria";
            this.lbl_subcategoria.Size = new System.Drawing.Size(108, 18);
            this.lbl_subcategoria.TabIndex = 1;
            this.lbl_subcategoria.Text = "Subcategoria";
            // 
            // lbl_ocasion
            // 
            this.lbl_ocasion.AutoSize = true;
            this.lbl_ocasion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ocasion.Location = new System.Drawing.Point(200, 357);
            this.lbl_ocasion.Name = "lbl_ocasion";
            this.lbl_ocasion.Size = new System.Drawing.Size(70, 18);
            this.lbl_ocasion.TabIndex = 1;
            this.lbl_ocasion.Text = "Ocasion";
            // 
            // lbl_familia
            // 
            this.lbl_familia.AutoSize = true;
            this.lbl_familia.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_familia.Location = new System.Drawing.Point(209, 397);
            this.lbl_familia.Name = "lbl_familia";
            this.lbl_familia.Size = new System.Drawing.Size(61, 18);
            this.lbl_familia.TabIndex = 1;
            this.lbl_familia.Text = "Familia";
            // 
            // cbo_categoria
            // 
            this.cbo_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_categoria.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_categoria.FormattingEnabled = true;
            this.cbo_categoria.Location = new System.Drawing.Point(291, 273);
            this.cbo_categoria.Name = "cbo_categoria";
            this.cbo_categoria.Size = new System.Drawing.Size(216, 28);
            this.cbo_categoria.TabIndex = 5;
            this.cbo_categoria.SelectedIndexChanged += new System.EventHandler(this.cbo_categoria_SelectedIndexChanged);
            // 
            // cbo_subcategoria
            // 
            this.cbo_subcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_subcategoria.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_subcategoria.FormattingEnabled = true;
            this.cbo_subcategoria.Location = new System.Drawing.Point(291, 313);
            this.cbo_subcategoria.Name = "cbo_subcategoria";
            this.cbo_subcategoria.Size = new System.Drawing.Size(216, 28);
            this.cbo_subcategoria.TabIndex = 6;
            // 
            // cbo_ocasion
            // 
            this.cbo_ocasion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_ocasion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_ocasion.FormattingEnabled = true;
            this.cbo_ocasion.Location = new System.Drawing.Point(291, 353);
            this.cbo_ocasion.Name = "cbo_ocasion";
            this.cbo_ocasion.Size = new System.Drawing.Size(216, 28);
            this.cbo_ocasion.TabIndex = 7;
            // 
            // cbo_familia
            // 
            this.cbo_familia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_familia.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_familia.FormattingEnabled = true;
            this.cbo_familia.Location = new System.Drawing.Point(291, 393);
            this.cbo_familia.Name = "cbo_familia";
            this.cbo_familia.Size = new System.Drawing.Size(216, 28);
            this.cbo_familia.TabIndex = 8;
            // 
            // cbo_color
            // 
            this.cbo_color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_color.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_color.FormattingEnabled = true;
            this.cbo_color.Location = new System.Drawing.Point(291, 433);
            this.cbo_color.Name = "cbo_color";
            this.cbo_color.Size = new System.Drawing.Size(216, 28);
            this.cbo_color.TabIndex = 9;
            // 
            // nud_tamano_producto
            // 
            this.nud_tamano_producto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_tamano_producto.Location = new System.Drawing.Point(291, 477);
            this.nud_tamano_producto.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nud_tamano_producto.Name = "nud_tamano_producto";
            this.nud_tamano_producto.Size = new System.Drawing.Size(120, 23);
            this.nud_tamano_producto.TabIndex = 10;
            // 
            // lbl_cm
            // 
            this.lbl_cm.AutoSize = true;
            this.lbl_cm.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cm.Location = new System.Drawing.Point(427, 477);
            this.lbl_cm.Name = "lbl_cm";
            this.lbl_cm.Size = new System.Drawing.Size(32, 18);
            this.lbl_cm.TabIndex = 1;
            this.lbl_cm.Text = "cm";
            // 
            // txt_detalle_diferencial
            // 
            this.txt_detalle_diferencial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_detalle_diferencial.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_detalle_diferencial.Location = new System.Drawing.Point(291, 198);
            this.txt_detalle_diferencial.Name = "txt_detalle_diferencial";
            this.txt_detalle_diferencial.Size = new System.Drawing.Size(338, 23);
            this.txt_detalle_diferencial.TabIndex = 3;
            // 
            // lbl_detalle_diferencial
            // 
            this.lbl_detalle_diferencial.AutoSize = true;
            this.lbl_detalle_diferencial.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_detalle_diferencial.Location = new System.Drawing.Point(124, 198);
            this.lbl_detalle_diferencial.Name = "lbl_detalle_diferencial";
            this.lbl_detalle_diferencial.Size = new System.Drawing.Size(146, 18);
            this.lbl_detalle_diferencial.TabIndex = 1;
            this.lbl_detalle_diferencial.Text = "Detalle Diferencial";
            // 
            // btn_registrar_producto
            // 
            this.btn_registrar_producto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_registrar_producto.Enabled = false;
            this.btn_registrar_producto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_registrar_producto.FlatAppearance.BorderSize = 2;
            this.btn_registrar_producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar_producto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar_producto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_registrar_producto.Location = new System.Drawing.Point(672, 515);
            this.btn_registrar_producto.Name = "btn_registrar_producto";
            this.btn_registrar_producto.Size = new System.Drawing.Size(200, 45);
            this.btn_registrar_producto.TabIndex = 13;
            this.btn_registrar_producto.Text = "Registrar Producto";
            this.btn_registrar_producto.UseVisualStyleBackColor = true;
            this.btn_registrar_producto.Click += new System.EventHandler(this.btn_registrar_producto_Click);
            // 
            // lbl_control_producto
            // 
            this.lbl_control_producto.AutoSize = true;
            this.lbl_control_producto.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_control_producto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.lbl_control_producto.Location = new System.Drawing.Point(411, 39);
            this.lbl_control_producto.Name = "lbl_control_producto";
            this.lbl_control_producto.Size = new System.Drawing.Size(252, 32);
            this.lbl_control_producto.TabIndex = 6;
            this.lbl_control_producto.Text = "[Control] Producto";
            // 
            // nud_stock_producto
            // 
            this.nud_stock_producto.Enabled = false;
            this.nud_stock_producto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_stock_producto.Location = new System.Drawing.Point(291, 515);
            this.nud_stock_producto.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nud_stock_producto.Name = "nud_stock_producto";
            this.nud_stock_producto.Size = new System.Drawing.Size(120, 23);
            this.nud_stock_producto.TabIndex = 11;
            // 
            // lbl_stock
            // 
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stock.Location = new System.Drawing.Point(221, 515);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(49, 18);
            this.lbl_stock.TabIndex = 1;
            this.lbl_stock.Text = "Stock";
            // 
            // lbl_id_codigo
            // 
            this.lbl_id_codigo.AutoSize = true;
            this.lbl_id_codigo.Location = new System.Drawing.Point(288, 92);
            this.lbl_id_codigo.Name = "lbl_id_codigo";
            this.lbl_id_codigo.Size = new System.Drawing.Size(57, 13);
            this.lbl_id_codigo.TabIndex = 7;
            this.lbl_id_codigo.Text = "ID_Codigo";
            this.lbl_id_codigo.Visible = false;
            this.lbl_id_codigo.Click += new System.EventHandler(this.lbl_id_codigo_Click);
            // 
            // pic_volver
            // 
            this.pic_volver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_volver.Image = global::Ventana_Inicial.Properties.Resources.Atras;
            this.pic_volver.Location = new System.Drawing.Point(107, 39);
            this.pic_volver.Name = "pic_volver";
            this.pic_volver.Size = new System.Drawing.Size(20, 32);
            this.pic_volver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_volver.TabIndex = 8;
            this.pic_volver.TabStop = false;
            this.pic_volver.Click += new System.EventHandler(this.pic_volver_Click);
            // 
            // lbl_id_producto
            // 
            this.lbl_id_producto.AutoSize = true;
            this.lbl_id_producto.Location = new System.Drawing.Point(351, 92);
            this.lbl_id_producto.Name = "lbl_id_producto";
            this.lbl_id_producto.Size = new System.Drawing.Size(67, 13);
            this.lbl_id_producto.TabIndex = 9;
            this.lbl_id_producto.Text = "ID_Producto";
            this.lbl_id_producto.Visible = false;
            // 
            // btn_actualizar_producto
            // 
            this.btn_actualizar_producto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_actualizar_producto.FlatAppearance.BorderSize = 2;
            this.btn_actualizar_producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizar_producto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar_producto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_actualizar_producto.Location = new System.Drawing.Point(672, 515);
            this.btn_actualizar_producto.Name = "btn_actualizar_producto";
            this.btn_actualizar_producto.Size = new System.Drawing.Size(200, 45);
            this.btn_actualizar_producto.TabIndex = 13;
            this.btn_actualizar_producto.Text = "Actualizar Producto";
            this.btn_actualizar_producto.UseVisualStyleBackColor = true;
            this.btn_actualizar_producto.Click += new System.EventHandler(this.btn_actualizar_producto_Click);
            // 
            // dtp_ultimo_pedido
            // 
            this.dtp_ultimo_pedido.Enabled = false;
            this.dtp_ultimo_pedido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ultimo_pedido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ultimo_pedido.Location = new System.Drawing.Point(291, 545);
            this.dtp_ultimo_pedido.Name = "dtp_ultimo_pedido";
            this.dtp_ultimo_pedido.Size = new System.Drawing.Size(120, 23);
            this.dtp_ultimo_pedido.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 548);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ultimo Pedido";
            // 
            // frm_producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.dtp_ultimo_pedido);
            this.Controls.Add(this.lbl_id_producto);
            this.Controls.Add(this.pic_volver);
            this.Controls.Add(this.lbl_id_codigo);
            this.Controls.Add(this.lbl_control_producto);
            this.Controls.Add(this.btn_actualizar_producto);
            this.Controls.Add(this.btn_registrar_producto);
            this.Controls.Add(this.cbo_color);
            this.Controls.Add(this.cbo_familia);
            this.Controls.Add(this.cbo_ocasion);
            this.Controls.Add(this.cbo_subcategoria);
            this.Controls.Add(this.cbo_categoria);
            this.Controls.Add(this.nud_stock_producto);
            this.Controls.Add(this.nud_tamano_producto);
            this.Controls.Add(this.nud_precio_venta);
            this.Controls.Add(this.lbl_familia);
            this.Controls.Add(this.lbl_ocasion);
            this.Controls.Add(this.lbl_subcategoria);
            this.Controls.Add(this.lbl_categoria);
            this.Controls.Add(this.lbl_color);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_stock);
            this.Controls.Add(this.lbl_tamano);
            this.Controls.Add(this.lbl_precio_venta);
            this.Controls.Add(this.lbl_detalle_diferencial);
            this.Controls.Add(this.lbl_nombre_producto);
            this.Controls.Add(this.lbl_cm);
            this.Controls.Add(this.lbl_codigo);
            this.Controls.Add(this.txt_detalle_diferencial);
            this.Controls.Add(this.txt_nombre_producto);
            this.Controls.Add(this.txt_codigo_producto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_producto";
            this.Text = "Nuevo_Producto";
            this.Load += new System.EventHandler(this.frm_nuevo_producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_precio_venta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_tamano_producto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_stock_producto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_volver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.Label lbl_nombre_producto;
        private System.Windows.Forms.Label lbl_precio_venta;
        private System.Windows.Forms.Label lbl_tamano;
        private System.Windows.Forms.Label lbl_color;
        private System.Windows.Forms.Label lbl_categoria;
        private System.Windows.Forms.Label lbl_subcategoria;
        private System.Windows.Forms.Label lbl_ocasion;
        private System.Windows.Forms.Label lbl_familia;
        private System.Windows.Forms.Label lbl_detalle_diferencial;
        private System.Windows.Forms.Label lbl_stock;
        public System.Windows.Forms.Label lbl_id_codigo;
        private System.Windows.Forms.PictureBox pic_volver;
        public System.Windows.Forms.TextBox txt_codigo_producto;
        public System.Windows.Forms.TextBox txt_nombre_producto;
        public System.Windows.Forms.NumericUpDown nud_precio_venta;
        public System.Windows.Forms.ComboBox cbo_categoria;
        public System.Windows.Forms.ComboBox cbo_subcategoria;
        public System.Windows.Forms.ComboBox cbo_ocasion;
        public System.Windows.Forms.ComboBox cbo_color;
        public System.Windows.Forms.NumericUpDown nud_tamano_producto;
        public System.Windows.Forms.Label lbl_cm;
        public System.Windows.Forms.TextBox txt_detalle_diferencial;
        public System.Windows.Forms.Button btn_registrar_producto;
        public System.Windows.Forms.Label lbl_control_producto;
        public System.Windows.Forms.NumericUpDown nud_stock_producto;
        public System.Windows.Forms.ComboBox cbo_familia;
        public System.Windows.Forms.Label lbl_id_producto;
        public System.Windows.Forms.Button btn_actualizar_producto;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dtp_ultimo_pedido;
    }
}