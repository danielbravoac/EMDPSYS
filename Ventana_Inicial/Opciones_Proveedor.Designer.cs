namespace Ventana_Inicial
{
    partial class frm_opciones_proveedor
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
            this.btn_control_pedido = new System.Windows.Forms.Button();
            this.btn_registrar_proveedor = new System.Windows.Forms.Button();
            this.btn_devolucion_proveedor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_titulo_venta
            // 
            this.lbl_titulo_venta.AutoSize = true;
            this.lbl_titulo_venta.Font = new System.Drawing.Font("Century Gothic", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_venta.Location = new System.Drawing.Point(248, 78);
            this.lbl_titulo_venta.Name = "lbl_titulo_venta";
            this.lbl_titulo_venta.Size = new System.Drawing.Size(547, 63);
            this.lbl_titulo_venta.TabIndex = 6;
            this.lbl_titulo_venta.Text = "¿Qué Desea Hacer?";
            // 
            // btn_control_pedido
            // 
            this.btn_control_pedido.BackColor = System.Drawing.Color.White;
            this.btn_control_pedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_control_pedido.FlatAppearance.BorderSize = 0;
            this.btn_control_pedido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_control_pedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_control_pedido.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_control_pedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_control_pedido.Image = global::Ventana_Inicial.Properties.Resources.Nuevo_Pedido;
            this.btn_control_pedido.Location = new System.Drawing.Point(450, 267);
            this.btn_control_pedido.Margin = new System.Windows.Forms.Padding(0);
            this.btn_control_pedido.Name = "btn_control_pedido";
            this.btn_control_pedido.Size = new System.Drawing.Size(155, 140);
            this.btn_control_pedido.TabIndex = 9;
            this.btn_control_pedido.Text = "Controlar Ingresos";
            this.btn_control_pedido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_control_pedido.UseVisualStyleBackColor = false;
            this.btn_control_pedido.Click += new System.EventHandler(this.btn_nuevo_pedido_Click);
            // 
            // btn_registrar_proveedor
            // 
            this.btn_registrar_proveedor.BackColor = System.Drawing.Color.White;
            this.btn_registrar_proveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_registrar_proveedor.FlatAppearance.BorderSize = 0;
            this.btn_registrar_proveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_registrar_proveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar_proveedor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar_proveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_registrar_proveedor.Image = global::Ventana_Inicial.Properties.Resources.Nuevo_Proveedor1;
            this.btn_registrar_proveedor.Location = new System.Drawing.Point(235, 267);
            this.btn_registrar_proveedor.Margin = new System.Windows.Forms.Padding(0);
            this.btn_registrar_proveedor.Name = "btn_registrar_proveedor";
            this.btn_registrar_proveedor.Size = new System.Drawing.Size(155, 140);
            this.btn_registrar_proveedor.TabIndex = 9;
            this.btn_registrar_proveedor.Text = "Controlar Proveedor";
            this.btn_registrar_proveedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_registrar_proveedor.UseVisualStyleBackColor = false;
            this.btn_registrar_proveedor.Click += new System.EventHandler(this.btn_registrar_proveedor_Click);
            // 
            // btn_devolucion_proveedor
            // 
            this.btn_devolucion_proveedor.BackColor = System.Drawing.Color.White;
            this.btn_devolucion_proveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_devolucion_proveedor.FlatAppearance.BorderSize = 0;
            this.btn_devolucion_proveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_devolucion_proveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_devolucion_proveedor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_devolucion_proveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_devolucion_proveedor.Image = global::Ventana_Inicial.Properties.Resources.Devolucion;
            this.btn_devolucion_proveedor.Location = new System.Drawing.Point(657, 267);
            this.btn_devolucion_proveedor.Margin = new System.Windows.Forms.Padding(0);
            this.btn_devolucion_proveedor.Name = "btn_devolucion_proveedor";
            this.btn_devolucion_proveedor.Size = new System.Drawing.Size(155, 140);
            this.btn_devolucion_proveedor.TabIndex = 10;
            this.btn_devolucion_proveedor.Text = "Devolución al Proveedor";
            this.btn_devolucion_proveedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_devolucion_proveedor.UseVisualStyleBackColor = false;
            this.btn_devolucion_proveedor.Click += new System.EventHandler(this.btn_devolucion_proveedor_Click);
            // 
            // frm_opciones_proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.btn_devolucion_proveedor);
            this.Controls.Add(this.btn_control_pedido);
            this.Controls.Add(this.btn_registrar_proveedor);
            this.Controls.Add(this.lbl_titulo_venta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_opciones_proveedor";
            this.Text = "Opciones_Proveedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo_venta;
        private System.Windows.Forms.Button btn_registrar_proveedor;
        private System.Windows.Forms.Button btn_control_pedido;
        private System.Windows.Forms.Button btn_devolucion_proveedor;
    }
}