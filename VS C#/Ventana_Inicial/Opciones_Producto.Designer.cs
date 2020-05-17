namespace Ventana_Inicial
{
    partial class frm_opciones_producto
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
            this.lbl_titulo_venta = new System.Windows.Forms.Label();
            this.btn_configurar_caracteristicas = new System.Windows.Forms.Button();
            this.btn_datos_producto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_titulo_venta
            // 
            this.lbl_titulo_venta.AutoSize = true;
            this.lbl_titulo_venta.Font = new System.Drawing.Font("Century Gothic", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_venta.Location = new System.Drawing.Point(248, 78);
            this.lbl_titulo_venta.Name = "lbl_titulo_venta";
            this.lbl_titulo_venta.Size = new System.Drawing.Size(547, 63);
            this.lbl_titulo_venta.TabIndex = 4;
            this.lbl_titulo_venta.Text = "¿Qué Desea Hacer?";
            // 
            // btn_configurar_caracteristicas
            // 
            this.btn_configurar_caracteristicas.BackColor = System.Drawing.Color.White;
            this.btn_configurar_caracteristicas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_configurar_caracteristicas.FlatAppearance.BorderSize = 0;
            this.btn_configurar_caracteristicas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_configurar_caracteristicas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_configurar_caracteristicas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_configurar_caracteristicas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_configurar_caracteristicas.Image = global::Ventana_Inicial.Properties.Resources.Configurar_Caracteristicas;
            this.btn_configurar_caracteristicas.Location = new System.Drawing.Point(569, 269);
            this.btn_configurar_caracteristicas.Margin = new System.Windows.Forms.Padding(0);
            this.btn_configurar_caracteristicas.Name = "btn_configurar_caracteristicas";
            this.btn_configurar_caracteristicas.Size = new System.Drawing.Size(155, 140);
            this.btn_configurar_caracteristicas.TabIndex = 5;
            this.btn_configurar_caracteristicas.Text = "Configurar Características";
            this.btn_configurar_caracteristicas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_configurar_caracteristicas.UseVisualStyleBackColor = false;
            this.btn_configurar_caracteristicas.Click += new System.EventHandler(this.btn_configurar_caracteristicas_Click);
            // 
            // btn_datos_producto
            // 
            this.btn_datos_producto.BackColor = System.Drawing.Color.White;
            this.btn_datos_producto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_datos_producto.FlatAppearance.BorderSize = 0;
            this.btn_datos_producto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_datos_producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_datos_producto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_datos_producto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_datos_producto.Image = global::Ventana_Inicial.Properties.Resources.Nuevo_Producto;
            this.btn_datos_producto.Location = new System.Drawing.Point(341, 269);
            this.btn_datos_producto.Margin = new System.Windows.Forms.Padding(0);
            this.btn_datos_producto.Name = "btn_datos_producto";
            this.btn_datos_producto.Size = new System.Drawing.Size(155, 140);
            this.btn_datos_producto.TabIndex = 7;
            this.btn_datos_producto.Text = "Controlar Productos";
            this.btn_datos_producto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_datos_producto.UseVisualStyleBackColor = false;
            this.btn_datos_producto.Click += new System.EventHandler(this.btn_nuevo_producto_Click);
            // 
            // frm_opciones_producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.btn_configurar_caracteristicas);
            this.Controls.Add(this.btn_datos_producto);
            this.Controls.Add(this.lbl_titulo_venta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_opciones_producto";
            this.Text = "Opciones_Producto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_configurar_caracteristicas;
        private System.Windows.Forms.Button btn_datos_producto;
        private System.Windows.Forms.Label lbl_titulo_venta;
    }
}