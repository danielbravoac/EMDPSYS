namespace Ventana_Inicial
{
    partial class frm_control_proveedor
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
            this.txt_buscar_prov = new System.Windows.Forms.TextBox();
            this.cbo_buscar_prov = new System.Windows.Forms.ComboBox();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.lbl_titulo_producto = new System.Windows.Forms.Label();
            this.dgv_control_proveedor = new System.Windows.Forms.DataGridView();
            this.btn_editar_proveedor = new System.Windows.Forms.Button();
            this.btn_registrar_proveedor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_control_proveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_buscar_prov
            // 
            this.txt_buscar_prov.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar_prov.Location = new System.Drawing.Point(257, 98);
            this.txt_buscar_prov.Name = "txt_buscar_prov";
            this.txt_buscar_prov.Size = new System.Drawing.Size(697, 23);
            this.txt_buscar_prov.TabIndex = 14;
            this.txt_buscar_prov.TextChanged += new System.EventHandler(this.txt_buscar_pro_TextChanged);
            // 
            // cbo_buscar_prov
            // 
            this.cbo_buscar_prov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_buscar_prov.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_buscar_prov.FormattingEnabled = true;
            this.cbo_buscar_prov.Items.AddRange(new object[] {
            "Nombre Comercial",
            "Nombre de Contacto"});
            this.cbo_buscar_prov.Location = new System.Drawing.Point(84, 96);
            this.cbo_buscar_prov.Name = "cbo_buscar_prov";
            this.cbo_buscar_prov.Size = new System.Drawing.Size(158, 25);
            this.cbo_buscar_prov.TabIndex = 13;
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.lbl_buscar.Location = new System.Drawing.Point(12, 97);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(57, 18);
            this.lbl_buscar.TabIndex = 12;
            this.lbl_buscar.Text = "Buscar";
            // 
            // lbl_titulo_producto
            // 
            this.lbl_titulo_producto.AutoSize = true;
            this.lbl_titulo_producto.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_producto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.lbl_titulo_producto.Location = new System.Drawing.Point(385, 33);
            this.lbl_titulo_producto.Name = "lbl_titulo_producto";
            this.lbl_titulo_producto.Size = new System.Drawing.Size(294, 32);
            this.lbl_titulo_producto.TabIndex = 16;
            this.lbl_titulo_producto.Text = "Control de Proveedor";
            // 
            // dgv_control_proveedor
            // 
            this.dgv_control_proveedor.AllowUserToAddRows = false;
            this.dgv_control_proveedor.AllowUserToDeleteRows = false;
            this.dgv_control_proveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_control_proveedor.BackgroundColor = System.Drawing.Color.White;
            this.dgv_control_proveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_control_proveedor.Location = new System.Drawing.Point(12, 132);
            this.dgv_control_proveedor.MultiSelect = false;
            this.dgv_control_proveedor.Name = "dgv_control_proveedor";
            this.dgv_control_proveedor.ReadOnly = true;
            this.dgv_control_proveedor.RowHeadersVisible = false;
            this.dgv_control_proveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_control_proveedor.Size = new System.Drawing.Size(740, 456);
            this.dgv_control_proveedor.TabIndex = 15;
            // 
            // btn_editar_proveedor
            // 
            this.btn_editar_proveedor.BackColor = System.Drawing.Color.White;
            this.btn_editar_proveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar_proveedor.FlatAppearance.BorderSize = 0;
            this.btn_editar_proveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_editar_proveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar_proveedor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar_proveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_editar_proveedor.Image = global::Ventana_Inicial.Properties.Resources.Editar_Proveedor;
            this.btn_editar_proveedor.Location = new System.Drawing.Point(835, 350);
            this.btn_editar_proveedor.Margin = new System.Windows.Forms.Padding(0);
            this.btn_editar_proveedor.Name = "btn_editar_proveedor";
            this.btn_editar_proveedor.Size = new System.Drawing.Size(155, 140);
            this.btn_editar_proveedor.TabIndex = 10;
            this.btn_editar_proveedor.Text = "Editar Proveedor";
            this.btn_editar_proveedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_editar_proveedor.UseVisualStyleBackColor = false;
            this.btn_editar_proveedor.Click += new System.EventHandler(this.btn_editar_proveedor_Click);
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
            this.btn_registrar_proveedor.Location = new System.Drawing.Point(835, 190);
            this.btn_registrar_proveedor.Margin = new System.Windows.Forms.Padding(0);
            this.btn_registrar_proveedor.Name = "btn_registrar_proveedor";
            this.btn_registrar_proveedor.Size = new System.Drawing.Size(155, 140);
            this.btn_registrar_proveedor.TabIndex = 11;
            this.btn_registrar_proveedor.Text = "Registrar Proveedor";
            this.btn_registrar_proveedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_registrar_proveedor.UseVisualStyleBackColor = false;
            this.btn_registrar_proveedor.Click += new System.EventHandler(this.btn_registrar_proveedor_Click);
            // 
            // frm_control_proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.lbl_titulo_producto);
            this.Controls.Add(this.dgv_control_proveedor);
            this.Controls.Add(this.txt_buscar_prov);
            this.Controls.Add(this.cbo_buscar_prov);
            this.Controls.Add(this.lbl_buscar);
            this.Controls.Add(this.btn_editar_proveedor);
            this.Controls.Add(this.btn_registrar_proveedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_control_proveedor";
            this.Text = "Control_Proveedor";
            this.Load += new System.EventHandler(this.Control_Proveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_control_proveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_editar_proveedor;
        private System.Windows.Forms.Button btn_registrar_proveedor;
        private System.Windows.Forms.TextBox txt_buscar_prov;
        private System.Windows.Forms.ComboBox cbo_buscar_prov;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.Label lbl_titulo_producto;
        public System.Windows.Forms.DataGridView dgv_control_proveedor;
    }
}