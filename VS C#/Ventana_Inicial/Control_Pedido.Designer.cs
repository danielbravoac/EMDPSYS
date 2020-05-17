namespace Ventana_Inicial
{
    partial class frm_control_pedido
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
            this.txt_buscar_pedido = new System.Windows.Forms.TextBox();
            this.cbo_buscar_pedido = new System.Windows.Forms.ComboBox();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.lbl_titulo_producto = new System.Windows.Forms.Label();
            this.dgv_control_pedido = new System.Windows.Forms.DataGridView();
            this.btn_editar_pedido = new System.Windows.Forms.Button();
            this.btn_nuevo_pedido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_control_pedido)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_buscar_pedido
            // 
            this.txt_buscar_pedido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar_pedido.Location = new System.Drawing.Point(219, 89);
            this.txt_buscar_pedido.Name = "txt_buscar_pedido";
            this.txt_buscar_pedido.Size = new System.Drawing.Size(754, 23);
            this.txt_buscar_pedido.TabIndex = 31;
            this.txt_buscar_pedido.TextChanged += new System.EventHandler(this.txt_buscar_pedido_TextChanged);
            // 
            // cbo_buscar_pedido
            // 
            this.cbo_buscar_pedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_buscar_pedido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_buscar_pedido.FormattingEnabled = true;
            this.cbo_buscar_pedido.Items.AddRange(new object[] {
            "Comprobante"});
            this.cbo_buscar_pedido.Location = new System.Drawing.Point(28, 87);
            this.cbo_buscar_pedido.Name = "cbo_buscar_pedido";
            this.cbo_buscar_pedido.Size = new System.Drawing.Size(158, 25);
            this.cbo_buscar_pedido.TabIndex = 30;
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.lbl_buscar.Location = new System.Drawing.Point(25, 50);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(57, 18);
            this.lbl_buscar.TabIndex = 29;
            this.lbl_buscar.Text = "Buscar";
            // 
            // lbl_titulo_producto
            // 
            this.lbl_titulo_producto.AutoSize = true;
            this.lbl_titulo_producto.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_producto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.lbl_titulo_producto.Location = new System.Drawing.Point(415, 23);
            this.lbl_titulo_producto.Name = "lbl_titulo_producto";
            this.lbl_titulo_producto.Size = new System.Drawing.Size(257, 32);
            this.lbl_titulo_producto.TabIndex = 28;
            this.lbl_titulo_producto.Text = "Control de Ingreso";
            // 
            // dgv_control_pedido
            // 
            this.dgv_control_pedido.AllowUserToAddRows = false;
            this.dgv_control_pedido.AllowUserToDeleteRows = false;
            this.dgv_control_pedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_control_pedido.BackgroundColor = System.Drawing.Color.White;
            this.dgv_control_pedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_control_pedido.Location = new System.Drawing.Point(28, 133);
            this.dgv_control_pedido.MultiSelect = false;
            this.dgv_control_pedido.Name = "dgv_control_pedido";
            this.dgv_control_pedido.ReadOnly = true;
            this.dgv_control_pedido.RowHeadersVisible = false;
            this.dgv_control_pedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_control_pedido.Size = new System.Drawing.Size(809, 445);
            this.dgv_control_pedido.TabIndex = 27;
            // 
            // btn_editar_pedido
            // 
            this.btn_editar_pedido.BackColor = System.Drawing.Color.White;
            this.btn_editar_pedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar_pedido.FlatAppearance.BorderSize = 0;
            this.btn_editar_pedido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_editar_pedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar_pedido.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar_pedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_editar_pedido.Image = global::Ventana_Inicial.Properties.Resources.Editar_Pedido;
            this.btn_editar_pedido.Location = new System.Drawing.Point(864, 378);
            this.btn_editar_pedido.Margin = new System.Windows.Forms.Padding(0);
            this.btn_editar_pedido.Name = "btn_editar_pedido";
            this.btn_editar_pedido.Size = new System.Drawing.Size(155, 140);
            this.btn_editar_pedido.TabIndex = 26;
            this.btn_editar_pedido.Text = "Editar Ingreso";
            this.btn_editar_pedido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_editar_pedido.UseVisualStyleBackColor = false;
            this.btn_editar_pedido.Click += new System.EventHandler(this.btn_editar_pedido_Click);
            // 
            // btn_nuevo_pedido
            // 
            this.btn_nuevo_pedido.BackColor = System.Drawing.Color.White;
            this.btn_nuevo_pedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevo_pedido.FlatAppearance.BorderSize = 0;
            this.btn_nuevo_pedido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_nuevo_pedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo_pedido.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo_pedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_nuevo_pedido.Image = global::Ventana_Inicial.Properties.Resources.Nuevo_Pedido1;
            this.btn_nuevo_pedido.Location = new System.Drawing.Point(864, 195);
            this.btn_nuevo_pedido.Margin = new System.Windows.Forms.Padding(0);
            this.btn_nuevo_pedido.Name = "btn_nuevo_pedido";
            this.btn_nuevo_pedido.Size = new System.Drawing.Size(155, 140);
            this.btn_nuevo_pedido.TabIndex = 26;
            this.btn_nuevo_pedido.Text = "Nuevo Ingreso";
            this.btn_nuevo_pedido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_nuevo_pedido.UseVisualStyleBackColor = false;
            this.btn_nuevo_pedido.Click += new System.EventHandler(this.btn_nuevo_pedido_Click);
            // 
            // frm_control_pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.txt_buscar_pedido);
            this.Controls.Add(this.cbo_buscar_pedido);
            this.Controls.Add(this.lbl_buscar);
            this.Controls.Add(this.lbl_titulo_producto);
            this.Controls.Add(this.dgv_control_pedido);
            this.Controls.Add(this.btn_editar_pedido);
            this.Controls.Add(this.btn_nuevo_pedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_control_pedido";
            this.Text = "Control_Pedido";
            this.Load += new System.EventHandler(this.frm_control_pedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_control_pedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_buscar_pedido;
        private System.Windows.Forms.ComboBox cbo_buscar_pedido;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.Label lbl_titulo_producto;
        public System.Windows.Forms.DataGridView dgv_control_pedido;
        private System.Windows.Forms.Button btn_nuevo_pedido;
        private System.Windows.Forms.Button btn_editar_pedido;
    }
}