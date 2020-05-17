namespace Ventana_Inicial
{
    partial class frm_control_producto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_control_producto = new System.Windows.Forms.DataGridView();
            this.btn_nuevo_producto = new System.Windows.Forms.Button();
            this.btn_editar_producto = new System.Windows.Forms.Button();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.cbo_buscar_pro = new System.Windows.Forms.ComboBox();
            this.txt_buscar_pro = new System.Windows.Forms.TextBox();
            this.lbl_titulo_producto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_control_producto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_control_producto
            // 
            this.dgv_control_producto.AllowUserToAddRows = false;
            this.dgv_control_producto.AllowUserToDeleteRows = false;
            this.dgv_control_producto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_control_producto.BackgroundColor = System.Drawing.Color.White;
            this.dgv_control_producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_control_producto.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_control_producto.Location = new System.Drawing.Point(15, 132);
            this.dgv_control_producto.MultiSelect = false;
            this.dgv_control_producto.Name = "dgv_control_producto";
            this.dgv_control_producto.ReadOnly = true;
            this.dgv_control_producto.RowHeadersVisible = false;
            this.dgv_control_producto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_control_producto.Size = new System.Drawing.Size(740, 456);
            this.dgv_control_producto.TabIndex = 0;
            // 
            // btn_nuevo_producto
            // 
            this.btn_nuevo_producto.FlatAppearance.BorderSize = 0;
            this.btn_nuevo_producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo_producto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo_producto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_nuevo_producto.Image = global::Ventana_Inicial.Properties.Resources.Nuevo_Producto;
            this.btn_nuevo_producto.Location = new System.Drawing.Point(819, 191);
            this.btn_nuevo_producto.Name = "btn_nuevo_producto";
            this.btn_nuevo_producto.Size = new System.Drawing.Size(155, 130);
            this.btn_nuevo_producto.TabIndex = 5;
            this.btn_nuevo_producto.Text = "Nuevo Producto";
            this.btn_nuevo_producto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_nuevo_producto.UseVisualStyleBackColor = true;
            this.btn_nuevo_producto.Click += new System.EventHandler(this.btn_nuevo_producto_Click);
            // 
            // btn_editar_producto
            // 
            this.btn_editar_producto.FlatAppearance.BorderSize = 0;
            this.btn_editar_producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar_producto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar_producto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_editar_producto.Image = global::Ventana_Inicial.Properties.Resources.Editar_Producto;
            this.btn_editar_producto.Location = new System.Drawing.Point(819, 346);
            this.btn_editar_producto.Name = "btn_editar_producto";
            this.btn_editar_producto.Size = new System.Drawing.Size(155, 130);
            this.btn_editar_producto.TabIndex = 5;
            this.btn_editar_producto.Text = "Editar Producto";
            this.btn_editar_producto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_editar_producto.UseVisualStyleBackColor = true;
            this.btn_editar_producto.Click += new System.EventHandler(this.btn_editar_producto_Click);
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.lbl_buscar.Location = new System.Drawing.Point(12, 94);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(57, 18);
            this.lbl_buscar.TabIndex = 6;
            this.lbl_buscar.Text = "Buscar";
            // 
            // cbo_buscar_pro
            // 
            this.cbo_buscar_pro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_buscar_pro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_buscar_pro.FormattingEnabled = true;
            this.cbo_buscar_pro.Items.AddRange(new object[] {
            "Código del  Producto",
            "Nombre del Producto"});
            this.cbo_buscar_pro.Location = new System.Drawing.Point(75, 92);
            this.cbo_buscar_pro.Name = "cbo_buscar_pro";
            this.cbo_buscar_pro.Size = new System.Drawing.Size(158, 25);
            this.cbo_buscar_pro.TabIndex = 7;
            // 
            // txt_buscar_pro
            // 
            this.txt_buscar_pro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar_pro.Location = new System.Drawing.Point(252, 94);
            this.txt_buscar_pro.Name = "txt_buscar_pro";
            this.txt_buscar_pro.Size = new System.Drawing.Size(697, 23);
            this.txt_buscar_pro.TabIndex = 8;
            this.txt_buscar_pro.TextChanged += new System.EventHandler(this.txt_buscar_pro_TextChanged);
            // 
            // lbl_titulo_producto
            // 
            this.lbl_titulo_producto.AutoSize = true;
            this.lbl_titulo_producto.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_producto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.lbl_titulo_producto.Location = new System.Drawing.Point(385, 33);
            this.lbl_titulo_producto.Name = "lbl_titulo_producto";
            this.lbl_titulo_producto.Size = new System.Drawing.Size(277, 32);
            this.lbl_titulo_producto.TabIndex = 9;
            this.lbl_titulo_producto.Text = "Control de Producto";
            // 
            // frm_control_producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1044, 600);
            this.Controls.Add(this.lbl_titulo_producto);
            this.Controls.Add(this.txt_buscar_pro);
            this.Controls.Add(this.cbo_buscar_pro);
            this.Controls.Add(this.lbl_buscar);
            this.Controls.Add(this.btn_editar_producto);
            this.Controls.Add(this.btn_nuevo_producto);
            this.Controls.Add(this.dgv_control_producto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_control_producto";
            this.Text = "Control_Producto";
            this.Load += new System.EventHandler(this.frm_control_producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_control_producto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_nuevo_producto;
        private System.Windows.Forms.Button btn_editar_producto;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.ComboBox cbo_buscar_pro;
        private System.Windows.Forms.TextBox txt_buscar_pro;
        private System.Windows.Forms.Label lbl_titulo_producto;
        public System.Windows.Forms.DataGridView dgv_control_producto;
    }
}