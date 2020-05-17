namespace Ventana_Inicial
{
    partial class frm_opciones_delivery
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
            this.lbl_titulo_producto = new System.Windows.Forms.Label();
            this.dgv_control_envios = new System.Windows.Forms.DataGridView();
            this.btn_actualizar_envio = new System.Windows.Forms.Button();
            this.btn_nuevo_delivery = new System.Windows.Forms.Button();
            this.btn_filtrar = new System.Windows.Forms.Button();
            this.dtp_fin = new System.Windows.Forms.DateTimePicker();
            this.lbl_a = new System.Windows.Forms.Label();
            this.dtp_inicio = new System.Windows.Forms.DateTimePicker();
            this.lbl_de = new System.Windows.Forms.Label();
            this.txt_buscar_envio = new System.Windows.Forms.TextBox();
            this.cbo_buscar_envio = new System.Windows.Forms.ComboBox();
            this.lbl_buscar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_control_envios)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo_producto
            // 
            this.lbl_titulo_producto.AutoSize = true;
            this.lbl_titulo_producto.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_producto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.lbl_titulo_producto.Location = new System.Drawing.Point(397, 23);
            this.lbl_titulo_producto.Name = "lbl_titulo_producto";
            this.lbl_titulo_producto.Size = new System.Drawing.Size(240, 32);
            this.lbl_titulo_producto.TabIndex = 27;
            this.lbl_titulo_producto.Text = "Control de Envios";
            // 
            // dgv_control_envios
            // 
            this.dgv_control_envios.AllowUserToAddRows = false;
            this.dgv_control_envios.AllowUserToDeleteRows = false;
            this.dgv_control_envios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_control_envios.BackgroundColor = System.Drawing.Color.White;
            this.dgv_control_envios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_control_envios.Location = new System.Drawing.Point(12, 132);
            this.dgv_control_envios.MultiSelect = false;
            this.dgv_control_envios.Name = "dgv_control_envios";
            this.dgv_control_envios.ReadOnly = true;
            this.dgv_control_envios.RowHeadersVisible = false;
            this.dgv_control_envios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_control_envios.Size = new System.Drawing.Size(740, 456);
            this.dgv_control_envios.TabIndex = 26;
            // 
            // btn_actualizar_envio
            // 
            this.btn_actualizar_envio.BackColor = System.Drawing.Color.White;
            this.btn_actualizar_envio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_actualizar_envio.FlatAppearance.BorderSize = 0;
            this.btn_actualizar_envio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_actualizar_envio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizar_envio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar_envio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_actualizar_envio.Image = global::Ventana_Inicial.Properties.Resources.Actualizar_Estado_Delivery;
            this.btn_actualizar_envio.Location = new System.Drawing.Point(816, 376);
            this.btn_actualizar_envio.Margin = new System.Windows.Forms.Padding(0);
            this.btn_actualizar_envio.Name = "btn_actualizar_envio";
            this.btn_actualizar_envio.Size = new System.Drawing.Size(155, 140);
            this.btn_actualizar_envio.TabIndex = 8;
            this.btn_actualizar_envio.Text = "Actualizar Envio";
            this.btn_actualizar_envio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_actualizar_envio.UseVisualStyleBackColor = false;
            this.btn_actualizar_envio.Click += new System.EventHandler(this.btn_actualizar_envio_Click);
            // 
            // btn_nuevo_delivery
            // 
            this.btn_nuevo_delivery.BackColor = System.Drawing.Color.White;
            this.btn_nuevo_delivery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevo_delivery.FlatAppearance.BorderSize = 0;
            this.btn_nuevo_delivery.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_nuevo_delivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo_delivery.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo_delivery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_nuevo_delivery.Image = global::Ventana_Inicial.Properties.Resources.Nuevo_Delivery;
            this.btn_nuevo_delivery.Location = new System.Drawing.Point(816, 210);
            this.btn_nuevo_delivery.Margin = new System.Windows.Forms.Padding(0);
            this.btn_nuevo_delivery.Name = "btn_nuevo_delivery";
            this.btn_nuevo_delivery.Size = new System.Drawing.Size(155, 140);
            this.btn_nuevo_delivery.TabIndex = 8;
            this.btn_nuevo_delivery.Text = "Nuevo Delivery";
            this.btn_nuevo_delivery.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_nuevo_delivery.UseVisualStyleBackColor = false;
            this.btn_nuevo_delivery.Click += new System.EventHandler(this.btn_nuevo_delivery_Click);
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.Location = new System.Drawing.Point(868, 140);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(75, 23);
            this.btn_filtrar.TabIndex = 95;
            this.btn_filtrar.Text = "Filtrar";
            this.btn_filtrar.UseVisualStyleBackColor = true;
            this.btn_filtrar.Click += new System.EventHandler(this.btn_filtrar_Click);
            // 
            // dtp_fin
            // 
            this.dtp_fin.CalendarFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fin.Location = new System.Drawing.Point(868, 100);
            this.dtp_fin.Name = "dtp_fin";
            this.dtp_fin.Size = new System.Drawing.Size(120, 26);
            this.dtp_fin.TabIndex = 93;
            // 
            // lbl_a
            // 
            this.lbl_a.AutoSize = true;
            this.lbl_a.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_a.Location = new System.Drawing.Point(833, 105);
            this.lbl_a.Name = "lbl_a";
            this.lbl_a.Size = new System.Drawing.Size(19, 18);
            this.lbl_a.TabIndex = 94;
            this.lbl_a.Text = "A";
            // 
            // dtp_inicio
            // 
            this.dtp_inicio.CalendarFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_inicio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_inicio.Location = new System.Drawing.Point(700, 100);
            this.dtp_inicio.Name = "dtp_inicio";
            this.dtp_inicio.Size = new System.Drawing.Size(120, 26);
            this.dtp_inicio.TabIndex = 91;
            // 
            // lbl_de
            // 
            this.lbl_de.AutoSize = true;
            this.lbl_de.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_de.Location = new System.Drawing.Point(665, 105);
            this.lbl_de.Name = "lbl_de";
            this.lbl_de.Size = new System.Drawing.Size(29, 18);
            this.lbl_de.TabIndex = 92;
            this.lbl_de.Text = "De";
            // 
            // txt_buscar_envio
            // 
            this.txt_buscar_envio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar_envio.Location = new System.Drawing.Point(249, 101);
            this.txt_buscar_envio.Name = "txt_buscar_envio";
            this.txt_buscar_envio.Size = new System.Drawing.Size(397, 23);
            this.txt_buscar_envio.TabIndex = 90;
            // 
            // cbo_buscar_envio
            // 
            this.cbo_buscar_envio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_buscar_envio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_buscar_envio.FormattingEnabled = true;
            this.cbo_buscar_envio.Items.AddRange(new object[] {
            "Fecha de Envio",
            "Fecha y Remitente"});
            this.cbo_buscar_envio.Location = new System.Drawing.Point(74, 98);
            this.cbo_buscar_envio.Name = "cbo_buscar_envio";
            this.cbo_buscar_envio.Size = new System.Drawing.Size(158, 25);
            this.cbo_buscar_envio.TabIndex = 89;
            this.cbo_buscar_envio.SelectedIndexChanged += new System.EventHandler(this.cbo_buscar_envio_SelectedIndexChanged);
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.lbl_buscar.Location = new System.Drawing.Point(11, 102);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(57, 18);
            this.lbl_buscar.TabIndex = 88;
            this.lbl_buscar.Text = "Buscar";
            // 
            // frm_opciones_delivery
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
            this.Controls.Add(this.txt_buscar_envio);
            this.Controls.Add(this.cbo_buscar_envio);
            this.Controls.Add(this.lbl_buscar);
            this.Controls.Add(this.lbl_titulo_producto);
            this.Controls.Add(this.dgv_control_envios);
            this.Controls.Add(this.btn_actualizar_envio);
            this.Controls.Add(this.btn_nuevo_delivery);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_opciones_delivery";
            this.Text = "Opciones_Delivery";
            this.Load += new System.EventHandler(this.frm_opciones_delivery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_control_envios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_nuevo_delivery;
        private System.Windows.Forms.Button btn_actualizar_envio;
        private System.Windows.Forms.Label lbl_titulo_producto;
        public System.Windows.Forms.DataGridView dgv_control_envios;
        private System.Windows.Forms.Button btn_filtrar;
        public System.Windows.Forms.DateTimePicker dtp_fin;
        private System.Windows.Forms.Label lbl_a;
        public System.Windows.Forms.DateTimePicker dtp_inicio;
        private System.Windows.Forms.Label lbl_de;
        private System.Windows.Forms.TextBox txt_buscar_envio;
        private System.Windows.Forms.ComboBox cbo_buscar_envio;
        private System.Windows.Forms.Label lbl_buscar;
    }
}