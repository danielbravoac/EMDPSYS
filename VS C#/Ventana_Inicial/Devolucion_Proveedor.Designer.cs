namespace Ventana_Inicial
{
    partial class frm_devolucion_proveedor
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
            this.btn_filtrar = new System.Windows.Forms.Button();
            this.dtp_fin = new System.Windows.Forms.DateTimePicker();
            this.lbl_a = new System.Windows.Forms.Label();
            this.dtp_inicio = new System.Windows.Forms.DateTimePicker();
            this.lbl_de = new System.Windows.Forms.Label();
            this.cbo_buscar_dev = new System.Windows.Forms.ComboBox();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.lbl_devolucion_proveedor = new System.Windows.Forms.Label();
            this.dgv_control_descuento = new System.Windows.Forms.DataGridView();
            this.btn_registrar_devolucion = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_control_descuento)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.Location = new System.Drawing.Point(654, 87);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(75, 23);
            this.btn_filtrar.TabIndex = 94;
            this.btn_filtrar.Text = "Filtrar";
            this.btn_filtrar.UseVisualStyleBackColor = true;
            // 
            // dtp_fin
            // 
            this.dtp_fin.CalendarFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fin.Location = new System.Drawing.Point(471, 87);
            this.dtp_fin.Name = "dtp_fin";
            this.dtp_fin.Size = new System.Drawing.Size(120, 26);
            this.dtp_fin.TabIndex = 92;
            this.dtp_fin.ValueChanged += new System.EventHandler(this.dtp_fin_ValueChanged);
            // 
            // lbl_a
            // 
            this.lbl_a.AutoSize = true;
            this.lbl_a.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_a.Location = new System.Drawing.Point(436, 92);
            this.lbl_a.Name = "lbl_a";
            this.lbl_a.Size = new System.Drawing.Size(19, 18);
            this.lbl_a.TabIndex = 93;
            this.lbl_a.Text = "A";
            // 
            // dtp_inicio
            // 
            this.dtp_inicio.CalendarFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_inicio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_inicio.Location = new System.Drawing.Point(303, 87);
            this.dtp_inicio.Name = "dtp_inicio";
            this.dtp_inicio.Size = new System.Drawing.Size(120, 26);
            this.dtp_inicio.TabIndex = 90;
            // 
            // lbl_de
            // 
            this.lbl_de.AutoSize = true;
            this.lbl_de.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_de.Location = new System.Drawing.Point(268, 92);
            this.lbl_de.Name = "lbl_de";
            this.lbl_de.Size = new System.Drawing.Size(29, 18);
            this.lbl_de.TabIndex = 91;
            this.lbl_de.Text = "De";
            // 
            // cbo_buscar_dev
            // 
            this.cbo_buscar_dev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_buscar_dev.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_buscar_dev.FormattingEnabled = true;
            this.cbo_buscar_dev.Items.AddRange(new object[] {
            "Fecha de Devolucion"});
            this.cbo_buscar_dev.Location = new System.Drawing.Point(86, 87);
            this.cbo_buscar_dev.Name = "cbo_buscar_dev";
            this.cbo_buscar_dev.Size = new System.Drawing.Size(158, 25);
            this.cbo_buscar_dev.TabIndex = 88;
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.lbl_buscar.Location = new System.Drawing.Point(23, 91);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(57, 18);
            this.lbl_buscar.TabIndex = 87;
            this.lbl_buscar.Text = "Buscar";
            // 
            // lbl_devolucion_proveedor
            // 
            this.lbl_devolucion_proveedor.AutoSize = true;
            this.lbl_devolucion_proveedor.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_devolucion_proveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.lbl_devolucion_proveedor.Location = new System.Drawing.Point(384, 23);
            this.lbl_devolucion_proveedor.Name = "lbl_devolucion_proveedor";
            this.lbl_devolucion_proveedor.Size = new System.Drawing.Size(318, 32);
            this.lbl_devolucion_proveedor.TabIndex = 86;
            this.lbl_devolucion_proveedor.Text = "Devolucion al Provedor";
            // 
            // dgv_control_descuento
            // 
            this.dgv_control_descuento.AllowUserToAddRows = false;
            this.dgv_control_descuento.AllowUserToDeleteRows = false;
            this.dgv_control_descuento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_control_descuento.BackgroundColor = System.Drawing.Color.White;
            this.dgv_control_descuento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_control_descuento.Location = new System.Drawing.Point(23, 127);
            this.dgv_control_descuento.MultiSelect = false;
            this.dgv_control_descuento.Name = "dgv_control_descuento";
            this.dgv_control_descuento.ReadOnly = true;
            this.dgv_control_descuento.RowHeadersVisible = false;
            this.dgv_control_descuento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_control_descuento.Size = new System.Drawing.Size(740, 456);
            this.dgv_control_descuento.TabIndex = 85;
            // 
            // btn_registrar_devolucion
            // 
            this.btn_registrar_devolucion.BackColor = System.Drawing.Color.White;
            this.btn_registrar_devolucion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_registrar_devolucion.FlatAppearance.BorderSize = 0;
            this.btn_registrar_devolucion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_registrar_devolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar_devolucion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar_devolucion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_registrar_devolucion.Image = global::Ventana_Inicial.Properties.Resources.Devolucion_Proveedor;
            this.btn_registrar_devolucion.Location = new System.Drawing.Point(832, 303);
            this.btn_registrar_devolucion.Margin = new System.Windows.Forms.Padding(0);
            this.btn_registrar_devolucion.Name = "btn_registrar_devolucion";
            this.btn_registrar_devolucion.Size = new System.Drawing.Size(155, 140);
            this.btn_registrar_devolucion.TabIndex = 83;
            this.btn_registrar_devolucion.Text = "Registrar Devolucion";
            this.btn_registrar_devolucion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_registrar_devolucion.UseVisualStyleBackColor = false;
            this.btn_registrar_devolucion.Click += new System.EventHandler(this.btn_registrar_devolucion_Click);
            // 
            // frm_devolucion_proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.btn_filtrar);
            this.Controls.Add(this.dtp_fin);
            this.Controls.Add(this.lbl_a);
            this.Controls.Add(this.dtp_inicio);
            this.Controls.Add(this.lbl_de);
            this.Controls.Add(this.cbo_buscar_dev);
            this.Controls.Add(this.lbl_buscar);
            this.Controls.Add(this.lbl_devolucion_proveedor);
            this.Controls.Add(this.dgv_control_descuento);
            this.Controls.Add(this.btn_registrar_devolucion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_devolucion_proveedor";
            this.Text = "Devolucion_Proveedor";
            this.Load += new System.EventHandler(this.frm_devolucion_proveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_control_descuento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_filtrar;
        public System.Windows.Forms.DateTimePicker dtp_fin;
        private System.Windows.Forms.Label lbl_a;
        public System.Windows.Forms.DateTimePicker dtp_inicio;
        private System.Windows.Forms.Label lbl_de;
        private System.Windows.Forms.ComboBox cbo_buscar_dev;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.Label lbl_devolucion_proveedor;
        public System.Windows.Forms.DataGridView dgv_control_descuento;
        private System.Windows.Forms.Button btn_registrar_devolucion;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}