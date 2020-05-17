namespace Ventana_Inicial
{
    partial class frm_reportes
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
            this.btn_reporte_empleados = new System.Windows.Forms.Button();
            this.btn_reporte_economico = new System.Windows.Forms.Button();
            this.btn_stock_productos = new System.Windows.Forms.Button();
            this.btn_reporte_venta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_titulo_venta
            // 
            this.lbl_titulo_venta.AutoSize = true;
            this.lbl_titulo_venta.Font = new System.Drawing.Font("Century Gothic", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_venta.Location = new System.Drawing.Point(237, 78);
            this.lbl_titulo_venta.Name = "lbl_titulo_venta";
            this.lbl_titulo_venta.Size = new System.Drawing.Size(633, 63);
            this.lbl_titulo_venta.TabIndex = 7;
            this.lbl_titulo_venta.Text = "¿Qué Desea Visualizar?";
            // 
            // btn_reporte_empleados
            // 
            this.btn_reporte_empleados.BackColor = System.Drawing.Color.White;
            this.btn_reporte_empleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reporte_empleados.FlatAppearance.BorderSize = 0;
            this.btn_reporte_empleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_reporte_empleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reporte_empleados.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reporte_empleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_reporte_empleados.Image = global::Ventana_Inicial.Properties.Resources.Reporte_Empleados;
            this.btn_reporte_empleados.Location = new System.Drawing.Point(530, 265);
            this.btn_reporte_empleados.Margin = new System.Windows.Forms.Padding(0);
            this.btn_reporte_empleados.Name = "btn_reporte_empleados";
            this.btn_reporte_empleados.Size = new System.Drawing.Size(155, 140);
            this.btn_reporte_empleados.TabIndex = 17;
            this.btn_reporte_empleados.Text = "Cuadre de Caja";
            this.btn_reporte_empleados.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_reporte_empleados.UseVisualStyleBackColor = false;
            this.btn_reporte_empleados.Click += new System.EventHandler(this.btn_reporte_empleados_Click);
            // 
            // btn_reporte_economico
            // 
            this.btn_reporte_economico.BackColor = System.Drawing.Color.White;
            this.btn_reporte_economico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reporte_economico.FlatAppearance.BorderSize = 0;
            this.btn_reporte_economico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_reporte_economico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reporte_economico.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reporte_economico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_reporte_economico.Image = global::Ventana_Inicial.Properties.Resources.Dashboard_Economico;
            this.btn_reporte_economico.Location = new System.Drawing.Point(356, 265);
            this.btn_reporte_economico.Margin = new System.Windows.Forms.Padding(0);
            this.btn_reporte_economico.Name = "btn_reporte_economico";
            this.btn_reporte_economico.Size = new System.Drawing.Size(155, 140);
            this.btn_reporte_economico.TabIndex = 17;
            this.btn_reporte_economico.Text = "Egresos";
            this.btn_reporte_economico.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_reporte_economico.UseVisualStyleBackColor = false;
            this.btn_reporte_economico.Click += new System.EventHandler(this.btn_reporte_economico_Click);
            // 
            // btn_stock_productos
            // 
            this.btn_stock_productos.BackColor = System.Drawing.Color.White;
            this.btn_stock_productos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_stock_productos.FlatAppearance.BorderSize = 0;
            this.btn_stock_productos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_stock_productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stock_productos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stock_productos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_stock_productos.Image = global::Ventana_Inicial.Properties.Resources.Reporte_Stock;
            this.btn_stock_productos.Location = new System.Drawing.Point(704, 265);
            this.btn_stock_productos.Margin = new System.Windows.Forms.Padding(0);
            this.btn_stock_productos.Name = "btn_stock_productos";
            this.btn_stock_productos.Size = new System.Drawing.Size(155, 140);
            this.btn_stock_productos.TabIndex = 17;
            this.btn_stock_productos.Text = "Stock de Productos";
            this.btn_stock_productos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_stock_productos.UseVisualStyleBackColor = false;
            this.btn_stock_productos.Click += new System.EventHandler(this.btn_stock_productos_Click);
            // 
            // btn_reporte_venta
            // 
            this.btn_reporte_venta.BackColor = System.Drawing.Color.White;
            this.btn_reporte_venta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reporte_venta.FlatAppearance.BorderSize = 0;
            this.btn_reporte_venta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_reporte_venta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reporte_venta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reporte_venta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_reporte_venta.Image = global::Ventana_Inicial.Properties.Resources.Reporte_Venta;
            this.btn_reporte_venta.Location = new System.Drawing.Point(182, 265);
            this.btn_reporte_venta.Margin = new System.Windows.Forms.Padding(0);
            this.btn_reporte_venta.Name = "btn_reporte_venta";
            this.btn_reporte_venta.Size = new System.Drawing.Size(155, 140);
            this.btn_reporte_venta.TabIndex = 17;
            this.btn_reporte_venta.Text = "Venta de Productos";
            this.btn_reporte_venta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_reporte_venta.UseVisualStyleBackColor = false;
            this.btn_reporte_venta.Click += new System.EventHandler(this.btn_reporte_venta_Click);
            // 
            // frm_reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.btn_reporte_empleados);
            this.Controls.Add(this.btn_reporte_economico);
            this.Controls.Add(this.btn_stock_productos);
            this.Controls.Add(this.btn_reporte_venta);
            this.Controls.Add(this.lbl_titulo_venta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_reportes";
            this.Text = "Reportes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo_venta;
        private System.Windows.Forms.Button btn_reporte_venta;
        private System.Windows.Forms.Button btn_reporte_economico;
        private System.Windows.Forms.Button btn_reporte_empleados;
        private System.Windows.Forms.Button btn_stock_productos;

    }
}