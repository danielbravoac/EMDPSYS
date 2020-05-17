namespace Ventana_Inicial
{
    partial class Inicio_Sistema
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio_Sistema));
            this.pnl_menu_vertical = new System.Windows.Forms.Panel();
            this.lbl_cargo = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.pic_usuario = new System.Windows.Forms.PictureBox();
            this.btn_egresos = new System.Windows.Forms.Button();
            this.btn_reportes = new System.Windows.Forms.Button();
            this.btn_empleados = new System.Windows.Forms.Button();
            this.btn_proveedores = new System.Windows.Forms.Button();
            this.btn_delivery = new System.Windows.Forms.Button();
            this.btn_clientes = new System.Windows.Forms.Button();
            this.btn_ventas = new System.Windows.Forms.Button();
            this.btn_productos = new System.Windows.Forms.Button();
            this.pnl_barra_titulo = new System.Windows.Forms.Panel();
            this.pic_normal = new System.Windows.Forms.PictureBox();
            this.pic_minimizar = new System.Windows.Forms.PictureBox();
            this.pic_maximizar = new System.Windows.Forms.PictureBox();
            this.pic_cerrar = new System.Windows.Forms.PictureBox();
            this.pnl_contenedor = new System.Windows.Forms.Panel();
            this.pnl_menu_vertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_usuario)).BeginInit();
            this.pnl_barra_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_normal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_menu_vertical
            // 
            this.pnl_menu_vertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.pnl_menu_vertical.Controls.Add(this.lbl_cargo);
            this.pnl_menu_vertical.Controls.Add(this.lbl_usuario);
            this.pnl_menu_vertical.Controls.Add(this.pic_usuario);
            this.pnl_menu_vertical.Controls.Add(this.btn_egresos);
            this.pnl_menu_vertical.Controls.Add(this.btn_reportes);
            this.pnl_menu_vertical.Controls.Add(this.btn_empleados);
            this.pnl_menu_vertical.Controls.Add(this.btn_proveedores);
            this.pnl_menu_vertical.Controls.Add(this.btn_delivery);
            this.pnl_menu_vertical.Controls.Add(this.btn_clientes);
            this.pnl_menu_vertical.Controls.Add(this.btn_ventas);
            this.pnl_menu_vertical.Controls.Add(this.btn_productos);
            this.pnl_menu_vertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_menu_vertical.Location = new System.Drawing.Point(0, 0);
            this.pnl_menu_vertical.Name = "pnl_menu_vertical";
            this.pnl_menu_vertical.Size = new System.Drawing.Size(250, 650);
            this.pnl_menu_vertical.TabIndex = 0;
            // 
            // lbl_cargo
            // 
            this.lbl_cargo.AutoSize = true;
            this.lbl_cargo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cargo.ForeColor = System.Drawing.Color.White;
            this.lbl_cargo.Location = new System.Drawing.Point(97, 38);
            this.lbl_cargo.Name = "lbl_cargo";
            this.lbl_cargo.Size = new System.Drawing.Size(50, 17);
            this.lbl_cargo.TabIndex = 2;
            this.lbl_cargo.Text = "Cargo";
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.ForeColor = System.Drawing.Color.White;
            this.lbl_usuario.Location = new System.Drawing.Point(96, 16);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(65, 19);
            this.lbl_usuario.TabIndex = 2;
            this.lbl_usuario.Text = "Usuario";
            // 
            // pic_usuario
            // 
            this.pic_usuario.Image = global::Ventana_Inicial.Properties.Resources.Usuario;
            this.pic_usuario.Location = new System.Drawing.Point(48, 19);
            this.pic_usuario.Name = "pic_usuario";
            this.pic_usuario.Size = new System.Drawing.Size(32, 32);
            this.pic_usuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_usuario.TabIndex = 1;
            this.pic_usuario.TabStop = false;
            // 
            // btn_egresos
            // 
            this.btn_egresos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_egresos.FlatAppearance.BorderSize = 0;
            this.btn_egresos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(80)))), ((int)(((byte)(167)))));
            this.btn_egresos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_egresos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_egresos.ForeColor = System.Drawing.Color.White;
            this.btn_egresos.Image = global::Ventana_Inicial.Properties.Resources.Egresos;
            this.btn_egresos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_egresos.Location = new System.Drawing.Point(0, 402);
            this.btn_egresos.Name = "btn_egresos";
            this.btn_egresos.Size = new System.Drawing.Size(250, 40);
            this.btn_egresos.TabIndex = 0;
            this.btn_egresos.Text = "Egresos";
            this.btn_egresos.UseVisualStyleBackColor = true;
            this.btn_egresos.Click += new System.EventHandler(this.btn_egresos_Click);
            // 
            // btn_reportes
            // 
            this.btn_reportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reportes.FlatAppearance.BorderSize = 0;
            this.btn_reportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(80)))), ((int)(((byte)(167)))));
            this.btn_reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reportes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reportes.ForeColor = System.Drawing.Color.White;
            this.btn_reportes.Image = global::Ventana_Inicial.Properties.Resources.Reportes;
            this.btn_reportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reportes.Location = new System.Drawing.Point(0, 453);
            this.btn_reportes.Name = "btn_reportes";
            this.btn_reportes.Size = new System.Drawing.Size(250, 40);
            this.btn_reportes.TabIndex = 0;
            this.btn_reportes.Text = "Reportes";
            this.btn_reportes.UseVisualStyleBackColor = true;
            this.btn_reportes.Click += new System.EventHandler(this.btn_reportes_Click);
            // 
            // btn_empleados
            // 
            this.btn_empleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_empleados.FlatAppearance.BorderSize = 0;
            this.btn_empleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(80)))), ((int)(((byte)(167)))));
            this.btn_empleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_empleados.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_empleados.ForeColor = System.Drawing.Color.White;
            this.btn_empleados.Image = global::Ventana_Inicial.Properties.Resources.Empleado;
            this.btn_empleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_empleados.Location = new System.Drawing.Point(0, 249);
            this.btn_empleados.Name = "btn_empleados";
            this.btn_empleados.Size = new System.Drawing.Size(250, 40);
            this.btn_empleados.TabIndex = 0;
            this.btn_empleados.Text = "Empleados";
            this.btn_empleados.UseVisualStyleBackColor = true;
            this.btn_empleados.Click += new System.EventHandler(this.btn_empleados_Click);
            // 
            // btn_proveedores
            // 
            this.btn_proveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_proveedores.FlatAppearance.BorderSize = 0;
            this.btn_proveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(80)))), ((int)(((byte)(167)))));
            this.btn_proveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_proveedores.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_proveedores.ForeColor = System.Drawing.Color.White;
            this.btn_proveedores.Image = global::Ventana_Inicial.Properties.Resources.Proveedor;
            this.btn_proveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_proveedores.Location = new System.Drawing.Point(0, 147);
            this.btn_proveedores.Name = "btn_proveedores";
            this.btn_proveedores.Size = new System.Drawing.Size(250, 40);
            this.btn_proveedores.TabIndex = 0;
            this.btn_proveedores.Text = "Proveedores";
            this.btn_proveedores.UseVisualStyleBackColor = true;
            this.btn_proveedores.Click += new System.EventHandler(this.btn_proveedores_Click);
            // 
            // btn_delivery
            // 
            this.btn_delivery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delivery.FlatAppearance.BorderSize = 0;
            this.btn_delivery.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(80)))), ((int)(((byte)(167)))));
            this.btn_delivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delivery.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delivery.ForeColor = System.Drawing.Color.White;
            this.btn_delivery.Image = global::Ventana_Inicial.Properties.Resources.Delivery;
            this.btn_delivery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delivery.Location = new System.Drawing.Point(0, 351);
            this.btn_delivery.Name = "btn_delivery";
            this.btn_delivery.Size = new System.Drawing.Size(250, 40);
            this.btn_delivery.TabIndex = 0;
            this.btn_delivery.Text = "Delivery";
            this.btn_delivery.UseVisualStyleBackColor = true;
            this.btn_delivery.Click += new System.EventHandler(this.btn_delivery_Click);
            // 
            // btn_clientes
            // 
            this.btn_clientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clientes.FlatAppearance.BorderSize = 0;
            this.btn_clientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(80)))), ((int)(((byte)(167)))));
            this.btn_clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clientes.ForeColor = System.Drawing.Color.White;
            this.btn_clientes.Image = global::Ventana_Inicial.Properties.Resources.Cliente;
            this.btn_clientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clientes.Location = new System.Drawing.Point(0, 198);
            this.btn_clientes.Name = "btn_clientes";
            this.btn_clientes.Size = new System.Drawing.Size(250, 40);
            this.btn_clientes.TabIndex = 0;
            this.btn_clientes.Text = "Clientes";
            this.btn_clientes.UseVisualStyleBackColor = true;
            this.btn_clientes.Click += new System.EventHandler(this.btn_clientes_Click);
            // 
            // btn_ventas
            // 
            this.btn_ventas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ventas.FlatAppearance.BorderSize = 0;
            this.btn_ventas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(80)))), ((int)(((byte)(167)))));
            this.btn_ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ventas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ventas.ForeColor = System.Drawing.Color.White;
            this.btn_ventas.Image = global::Ventana_Inicial.Properties.Resources.Venta;
            this.btn_ventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ventas.Location = new System.Drawing.Point(0, 300);
            this.btn_ventas.Name = "btn_ventas";
            this.btn_ventas.Size = new System.Drawing.Size(250, 40);
            this.btn_ventas.TabIndex = 0;
            this.btn_ventas.Text = "Ventas";
            this.btn_ventas.UseVisualStyleBackColor = true;
            this.btn_ventas.Click += new System.EventHandler(this.btn_ventas_Click);
            // 
            // btn_productos
            // 
            this.btn_productos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_productos.FlatAppearance.BorderSize = 0;
            this.btn_productos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(80)))), ((int)(((byte)(167)))));
            this.btn_productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_productos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_productos.ForeColor = System.Drawing.Color.White;
            this.btn_productos.Image = global::Ventana_Inicial.Properties.Resources.Producto;
            this.btn_productos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_productos.Location = new System.Drawing.Point(0, 96);
            this.btn_productos.Name = "btn_productos";
            this.btn_productos.Size = new System.Drawing.Size(250, 40);
            this.btn_productos.TabIndex = 0;
            this.btn_productos.Text = "Productos";
            this.btn_productos.UseVisualStyleBackColor = true;
            this.btn_productos.Click += new System.EventHandler(this.btn_productos_Click);
            // 
            // pnl_barra_titulo
            // 
            this.pnl_barra_titulo.Controls.Add(this.pic_normal);
            this.pnl_barra_titulo.Controls.Add(this.pic_minimizar);
            this.pnl_barra_titulo.Controls.Add(this.pic_maximizar);
            this.pnl_barra_titulo.Controls.Add(this.pic_cerrar);
            this.pnl_barra_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_barra_titulo.Location = new System.Drawing.Point(250, 0);
            this.pnl_barra_titulo.Name = "pnl_barra_titulo";
            this.pnl_barra_titulo.Size = new System.Drawing.Size(1050, 50);
            this.pnl_barra_titulo.TabIndex = 1;
            this.pnl_barra_titulo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_barra_titulo_Paint);
            this.pnl_barra_titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_barra_titulo_MouseDown);
            // 
            // pic_normal
            // 
            this.pic_normal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_normal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_normal.Image = global::Ventana_Inicial.Properties.Resources.Normal;
            this.pic_normal.Location = new System.Drawing.Point(943, 9);
            this.pic_normal.Name = "pic_normal";
            this.pic_normal.Size = new System.Drawing.Size(35, 35);
            this.pic_normal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_normal.TabIndex = 0;
            this.pic_normal.TabStop = false;
            this.pic_normal.Visible = false;
            this.pic_normal.Click += new System.EventHandler(this.pic_normal_Click);
            // 
            // pic_minimizar
            // 
            this.pic_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_minimizar.Image = global::Ventana_Inicial.Properties.Resources.Minimizar;
            this.pic_minimizar.Location = new System.Drawing.Point(883, 9);
            this.pic_minimizar.Name = "pic_minimizar";
            this.pic_minimizar.Size = new System.Drawing.Size(35, 35);
            this.pic_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_minimizar.TabIndex = 0;
            this.pic_minimizar.TabStop = false;
            this.pic_minimizar.Click += new System.EventHandler(this.pic_minimizar_Click);
            // 
            // pic_maximizar
            // 
            this.pic_maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_maximizar.Image = global::Ventana_Inicial.Properties.Resources.Maximizar;
            this.pic_maximizar.Location = new System.Drawing.Point(943, 9);
            this.pic_maximizar.Name = "pic_maximizar";
            this.pic_maximizar.Size = new System.Drawing.Size(35, 35);
            this.pic_maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_maximizar.TabIndex = 0;
            this.pic_maximizar.TabStop = false;
            this.pic_maximizar.Click += new System.EventHandler(this.pic_maximizar_Click);
            // 
            // pic_cerrar
            // 
            this.pic_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_cerrar.Image = global::Ventana_Inicial.Properties.Resources.Cerrar;
            this.pic_cerrar.Location = new System.Drawing.Point(1001, 9);
            this.pic_cerrar.Name = "pic_cerrar";
            this.pic_cerrar.Size = new System.Drawing.Size(35, 35);
            this.pic_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_cerrar.TabIndex = 0;
            this.pic_cerrar.TabStop = false;
            this.pic_cerrar.Click += new System.EventHandler(this.pic_cerrar_Click);
            // 
            // pnl_contenedor
            // 
            this.pnl_contenedor.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_contenedor.Location = new System.Drawing.Point(250, 50);
            this.pnl_contenedor.Name = "pnl_contenedor";
            this.pnl_contenedor.Size = new System.Drawing.Size(1050, 600);
            this.pnl_contenedor.TabIndex = 2;
            // 
            // Inicio_Sistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.pnl_contenedor);
            this.Controls.Add(this.pnl_barra_titulo);
            this.Controls.Add(this.pnl_menu_vertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicio_Sistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMDPSYS";
            this.Load += new System.EventHandler(this.Inicio_Sistema_Load);
            this.pnl_menu_vertical.ResumeLayout(false);
            this.pnl_menu_vertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_usuario)).EndInit();
            this.pnl_barra_titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_normal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_menu_vertical;
        private System.Windows.Forms.Panel pnl_barra_titulo;
        private System.Windows.Forms.Panel pnl_contenedor;
        private System.Windows.Forms.PictureBox pic_cerrar;
        private System.Windows.Forms.PictureBox pic_maximizar;
        private System.Windows.Forms.PictureBox pic_minimizar;
        private System.Windows.Forms.PictureBox pic_normal;
        private System.Windows.Forms.Button btn_productos;
        private System.Windows.Forms.Button btn_empleados;
        private System.Windows.Forms.Button btn_proveedores;
        private System.Windows.Forms.Button btn_clientes;
        private System.Windows.Forms.Button btn_ventas;
        private System.Windows.Forms.Button btn_reportes;
        private System.Windows.Forms.Button btn_delivery;
        private System.Windows.Forms.Button btn_egresos;
        private System.Windows.Forms.PictureBox pic_usuario;
        public System.Windows.Forms.Label lbl_cargo;
        public System.Windows.Forms.Label lbl_usuario;
    }
}

