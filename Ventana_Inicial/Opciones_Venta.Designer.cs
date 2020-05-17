namespace Ventana_Inicial
{
    partial class frm_opciones_venta
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
            this.dgv_control_venta = new System.Windows.Forms.DataGridView();
            this.lbl_titulo_producto = new System.Windows.Forms.Label();
            this.txt_buscar_venta = new System.Windows.Forms.TextBox();
            this.cbo_buscar_venta = new System.Windows.Forms.ComboBox();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.btn_anular_venta = new System.Windows.Forms.Button();
            this.btn_nueva_venta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_control_venta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_control_venta
            // 
            this.dgv_control_venta.AllowUserToAddRows = false;
            this.dgv_control_venta.AllowUserToDeleteRows = false;
            this.dgv_control_venta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_control_venta.BackgroundColor = System.Drawing.Color.White;
            this.dgv_control_venta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_control_venta.Location = new System.Drawing.Point(12, 143);
            this.dgv_control_venta.MultiSelect = false;
            this.dgv_control_venta.Name = "dgv_control_venta";
            this.dgv_control_venta.ReadOnly = true;
            this.dgv_control_venta.RowHeadersVisible = false;
            this.dgv_control_venta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_control_venta.Size = new System.Drawing.Size(809, 445);
            this.dgv_control_venta.TabIndex = 4;
            // 
            // lbl_titulo_producto
            // 
            this.lbl_titulo_producto.AutoSize = true;
            this.lbl_titulo_producto.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_producto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.lbl_titulo_producto.Location = new System.Drawing.Point(399, 33);
            this.lbl_titulo_producto.Name = "lbl_titulo_producto";
            this.lbl_titulo_producto.Size = new System.Drawing.Size(238, 32);
            this.lbl_titulo_producto.TabIndex = 10;
            this.lbl_titulo_producto.Text = "Control de Venta";
            // 
            // txt_buscar_venta
            // 
            this.txt_buscar_venta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar_venta.Location = new System.Drawing.Point(216, 97);
            this.txt_buscar_venta.Name = "txt_buscar_venta";
            this.txt_buscar_venta.Size = new System.Drawing.Size(754, 23);
            this.txt_buscar_venta.TabIndex = 24;
            this.txt_buscar_venta.TextChanged += new System.EventHandler(this.txt_buscar_venta_TextChanged);
            // 
            // cbo_buscar_venta
            // 
            this.cbo_buscar_venta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_buscar_venta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_buscar_venta.FormattingEnabled = true;
            this.cbo_buscar_venta.Items.AddRange(new object[] {
            "Comprobante"});
            this.cbo_buscar_venta.Location = new System.Drawing.Point(52, 95);
            this.cbo_buscar_venta.Name = "cbo_buscar_venta";
            this.cbo_buscar_venta.Size = new System.Drawing.Size(158, 25);
            this.cbo_buscar_venta.TabIndex = 23;
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.lbl_buscar.Location = new System.Drawing.Point(49, 66);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(57, 18);
            this.lbl_buscar.TabIndex = 22;
            this.lbl_buscar.Text = "Buscar";
            // 
            // btn_anular_venta
            // 
            this.btn_anular_venta.BackColor = System.Drawing.Color.White;
            this.btn_anular_venta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_anular_venta.FlatAppearance.BorderSize = 0;
            this.btn_anular_venta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_anular_venta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_anular_venta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_anular_venta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_anular_venta.Image = global::Ventana_Inicial.Properties.Resources.Anular_Venta;
            this.btn_anular_venta.Location = new System.Drawing.Point(851, 318);
            this.btn_anular_venta.Margin = new System.Windows.Forms.Padding(0);
            this.btn_anular_venta.Name = "btn_anular_venta";
            this.btn_anular_venta.Size = new System.Drawing.Size(155, 140);
            this.btn_anular_venta.TabIndex = 3;
            this.btn_anular_venta.Text = "Anular Venta";
            this.btn_anular_venta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_anular_venta.UseVisualStyleBackColor = false;
            this.btn_anular_venta.Click += new System.EventHandler(this.btn_anular_venta_Click);
            // 
            // btn_nueva_venta
            // 
            this.btn_nueva_venta.BackColor = System.Drawing.Color.White;
            this.btn_nueva_venta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nueva_venta.FlatAppearance.BorderSize = 0;
            this.btn_nueva_venta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_nueva_venta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nueva_venta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nueva_venta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_nueva_venta.Image = global::Ventana_Inicial.Properties.Resources.Nueva_Venta;
            this.btn_nueva_venta.Location = new System.Drawing.Point(851, 143);
            this.btn_nueva_venta.Margin = new System.Windows.Forms.Padding(0);
            this.btn_nueva_venta.Name = "btn_nueva_venta";
            this.btn_nueva_venta.Size = new System.Drawing.Size(155, 140);
            this.btn_nueva_venta.TabIndex = 3;
            this.btn_nueva_venta.Text = "Nueva Venta";
            this.btn_nueva_venta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_nueva_venta.UseVisualStyleBackColor = false;
            this.btn_nueva_venta.Click += new System.EventHandler(this.btn_nueva_venta_Click);
            // 
            // frm_opciones_venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.txt_buscar_venta);
            this.Controls.Add(this.cbo_buscar_venta);
            this.Controls.Add(this.lbl_buscar);
            this.Controls.Add(this.lbl_titulo_producto);
            this.Controls.Add(this.dgv_control_venta);
            this.Controls.Add(this.btn_anular_venta);
            this.Controls.Add(this.btn_nueva_venta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_opciones_venta";
            this.Text = "Opciones_Venta";
            this.Load += new System.EventHandler(this.frm_opciones_venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_control_venta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_nueva_venta;
        private System.Windows.Forms.Button btn_anular_venta;
        public System.Windows.Forms.DataGridView dgv_control_venta;
        private System.Windows.Forms.Label lbl_titulo_producto;
        private System.Windows.Forms.TextBox txt_buscar_venta;
        private System.Windows.Forms.ComboBox cbo_buscar_venta;
        private System.Windows.Forms.Label lbl_buscar;

    }
}