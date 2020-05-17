namespace Ventana_Inicial
{
    partial class frm_opciones_empleado
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
            this.btn_hacer_decuento = new System.Windows.Forms.Button();
            this.btn_control_bono = new System.Windows.Forms.Button();
            this.btn_controlar_empleado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_titulo_venta
            // 
            this.lbl_titulo_venta.AutoSize = true;
            this.lbl_titulo_venta.Font = new System.Drawing.Font("Century Gothic", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_venta.Location = new System.Drawing.Point(248, 78);
            this.lbl_titulo_venta.Name = "lbl_titulo_venta";
            this.lbl_titulo_venta.Size = new System.Drawing.Size(547, 63);
            this.lbl_titulo_venta.TabIndex = 12;
            this.lbl_titulo_venta.Text = "¿Qué Desea Hacer?";
            // 
            // btn_hacer_decuento
            // 
            this.btn_hacer_decuento.BackColor = System.Drawing.Color.White;
            this.btn_hacer_decuento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hacer_decuento.FlatAppearance.BorderSize = 0;
            this.btn_hacer_decuento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_hacer_decuento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hacer_decuento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hacer_decuento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_hacer_decuento.Image = global::Ventana_Inicial.Properties.Resources.Descuentos;
            this.btn_hacer_decuento.Location = new System.Drawing.Point(602, 252);
            this.btn_hacer_decuento.Margin = new System.Windows.Forms.Padding(0);
            this.btn_hacer_decuento.Name = "btn_hacer_decuento";
            this.btn_hacer_decuento.Size = new System.Drawing.Size(155, 140);
            this.btn_hacer_decuento.TabIndex = 18;
            this.btn_hacer_decuento.Text = "Controlar Descuentos";
            this.btn_hacer_decuento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_hacer_decuento.UseVisualStyleBackColor = false;
            this.btn_hacer_decuento.Click += new System.EventHandler(this.btn_hacer_decuento_Click);
            // 
            // btn_control_bono
            // 
            this.btn_control_bono.BackColor = System.Drawing.Color.White;
            this.btn_control_bono.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_control_bono.FlatAppearance.BorderSize = 0;
            this.btn_control_bono.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_control_bono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_control_bono.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_control_bono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_control_bono.Image = global::Ventana_Inicial.Properties.Resources.Bono;
            this.btn_control_bono.Location = new System.Drawing.Point(435, 252);
            this.btn_control_bono.Margin = new System.Windows.Forms.Padding(0);
            this.btn_control_bono.Name = "btn_control_bono";
            this.btn_control_bono.Size = new System.Drawing.Size(155, 140);
            this.btn_control_bono.TabIndex = 17;
            this.btn_control_bono.Text = "Controlar Bonos";
            this.btn_control_bono.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_control_bono.UseVisualStyleBackColor = false;
            this.btn_control_bono.Click += new System.EventHandler(this.btn_control_bono_Click);
            // 
            // btn_controlar_empleado
            // 
            this.btn_controlar_empleado.BackColor = System.Drawing.Color.White;
            this.btn_controlar_empleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_controlar_empleado.FlatAppearance.BorderSize = 0;
            this.btn_controlar_empleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_controlar_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_controlar_empleado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_controlar_empleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_controlar_empleado.Image = global::Ventana_Inicial.Properties.Resources.Nuevo_Cliente;
            this.btn_controlar_empleado.Location = new System.Drawing.Point(271, 252);
            this.btn_controlar_empleado.Margin = new System.Windows.Forms.Padding(0);
            this.btn_controlar_empleado.Name = "btn_controlar_empleado";
            this.btn_controlar_empleado.Size = new System.Drawing.Size(155, 140);
            this.btn_controlar_empleado.TabIndex = 13;
            this.btn_controlar_empleado.Text = "Controlar Empleado";
            this.btn_controlar_empleado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_controlar_empleado.UseVisualStyleBackColor = false;
            this.btn_controlar_empleado.Click += new System.EventHandler(this.btn_controlar_empleado_Click);
            // 
            // frm_opciones_empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.btn_hacer_decuento);
            this.Controls.Add(this.btn_control_bono);
            this.Controls.Add(this.btn_controlar_empleado);
            this.Controls.Add(this.lbl_titulo_venta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_opciones_empleado";
            this.Text = "Opciones_Empleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_controlar_empleado;
        private System.Windows.Forms.Label lbl_titulo_venta;
        private System.Windows.Forms.Button btn_hacer_decuento;
        private System.Windows.Forms.Button btn_control_bono;
    }
}