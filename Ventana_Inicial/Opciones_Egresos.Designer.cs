namespace Ventana_Inicial
{
    partial class frm_opciones_egresos
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
            this.cbo_buscar_egre = new System.Windows.Forms.ComboBox();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.dgv_control_egresos = new System.Windows.Forms.DataGridView();
            this.btn_editar_egreso = new System.Windows.Forms.Button();
            this.btn_registrar_egreso = new System.Windows.Forms.Button();
            this.txt_buscar_egre = new System.Windows.Forms.TextBox();
            this.btn_filtrar = new System.Windows.Forms.Button();
            this.dtp_fin = new System.Windows.Forms.DateTimePicker();
            this.lbl_a = new System.Windows.Forms.Label();
            this.dtp_inicio = new System.Windows.Forms.DateTimePicker();
            this.lbl_de = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_control_egresos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo_producto
            // 
            this.lbl_titulo_producto.AutoSize = true;
            this.lbl_titulo_producto.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_producto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.lbl_titulo_producto.Location = new System.Drawing.Point(397, 23);
            this.lbl_titulo_producto.Name = "lbl_titulo_producto";
            this.lbl_titulo_producto.Size = new System.Drawing.Size(259, 32);
            this.lbl_titulo_producto.TabIndex = 25;
            this.lbl_titulo_producto.Text = "Control de Egresos";
            // 
            // cbo_buscar_egre
            // 
            this.cbo_buscar_egre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_buscar_egre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_buscar_egre.FormattingEnabled = true;
            this.cbo_buscar_egre.Items.AddRange(new object[] {
            "Fecha de Egreso",
            "Motivo y Fecha de Egreso"});
            this.cbo_buscar_egre.Location = new System.Drawing.Point(75, 90);
            this.cbo_buscar_egre.Name = "cbo_buscar_egre";
            this.cbo_buscar_egre.Size = new System.Drawing.Size(158, 25);
            this.cbo_buscar_egre.TabIndex = 23;
            this.cbo_buscar_egre.SelectedIndexChanged += new System.EventHandler(this.cbo_buscar_egre_SelectedIndexChanged);
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.lbl_buscar.Location = new System.Drawing.Point(12, 94);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(57, 18);
            this.lbl_buscar.TabIndex = 22;
            this.lbl_buscar.Text = "Buscar";
            // 
            // dgv_control_egresos
            // 
            this.dgv_control_egresos.AllowUserToAddRows = false;
            this.dgv_control_egresos.AllowUserToDeleteRows = false;
            this.dgv_control_egresos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_control_egresos.BackgroundColor = System.Drawing.Color.White;
            this.dgv_control_egresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_control_egresos.Location = new System.Drawing.Point(12, 132);
            this.dgv_control_egresos.MultiSelect = false;
            this.dgv_control_egresos.Name = "dgv_control_egresos";
            this.dgv_control_egresos.ReadOnly = true;
            this.dgv_control_egresos.RowHeadersVisible = false;
            this.dgv_control_egresos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_control_egresos.Size = new System.Drawing.Size(740, 456);
            this.dgv_control_egresos.TabIndex = 19;
            // 
            // btn_editar_egreso
            // 
            this.btn_editar_egreso.BackColor = System.Drawing.Color.White;
            this.btn_editar_egreso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar_egreso.FlatAppearance.BorderSize = 0;
            this.btn_editar_egreso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_editar_egreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar_egreso.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar_egreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_editar_egreso.Image = global::Ventana_Inicial.Properties.Resources.Ver_Egresos;
            this.btn_editar_egreso.Location = new System.Drawing.Point(829, 358);
            this.btn_editar_egreso.Margin = new System.Windows.Forms.Padding(0);
            this.btn_editar_egreso.Name = "btn_editar_egreso";
            this.btn_editar_egreso.Size = new System.Drawing.Size(155, 140);
            this.btn_editar_egreso.TabIndex = 18;
            this.btn_editar_egreso.Text = "Editar Egreso";
            this.btn_editar_egreso.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_editar_egreso.UseVisualStyleBackColor = false;
            this.btn_editar_egreso.Click += new System.EventHandler(this.btn_editar_egreso_Click);
            // 
            // btn_registrar_egreso
            // 
            this.btn_registrar_egreso.BackColor = System.Drawing.Color.White;
            this.btn_registrar_egreso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_registrar_egreso.FlatAppearance.BorderSize = 0;
            this.btn_registrar_egreso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_registrar_egreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar_egreso.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar_egreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_registrar_egreso.Image = global::Ventana_Inicial.Properties.Resources.Agregar_Egresos;
            this.btn_registrar_egreso.Location = new System.Drawing.Point(829, 203);
            this.btn_registrar_egreso.Margin = new System.Windows.Forms.Padding(0);
            this.btn_registrar_egreso.Name = "btn_registrar_egreso";
            this.btn_registrar_egreso.Size = new System.Drawing.Size(155, 140);
            this.btn_registrar_egreso.TabIndex = 16;
            this.btn_registrar_egreso.Text = "Registrar Egreso";
            this.btn_registrar_egreso.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_registrar_egreso.UseVisualStyleBackColor = false;
            this.btn_registrar_egreso.Click += new System.EventHandler(this.btn_registrar_egreso_Click);
            // 
            // txt_buscar_egre
            // 
            this.txt_buscar_egre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar_egre.Location = new System.Drawing.Point(250, 93);
            this.txt_buscar_egre.Name = "txt_buscar_egre";
            this.txt_buscar_egre.Size = new System.Drawing.Size(397, 23);
            this.txt_buscar_egre.TabIndex = 24;
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.Location = new System.Drawing.Point(869, 132);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(75, 23);
            this.btn_filtrar.TabIndex = 87;
            this.btn_filtrar.Text = "Filtrar";
            this.btn_filtrar.UseVisualStyleBackColor = true;
            this.btn_filtrar.Click += new System.EventHandler(this.btn_filtrar_Click);
            // 
            // dtp_fin
            // 
            this.dtp_fin.CalendarFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fin.Location = new System.Drawing.Point(869, 92);
            this.dtp_fin.Name = "dtp_fin";
            this.dtp_fin.Size = new System.Drawing.Size(120, 26);
            this.dtp_fin.TabIndex = 85;
            // 
            // lbl_a
            // 
            this.lbl_a.AutoSize = true;
            this.lbl_a.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_a.Location = new System.Drawing.Point(834, 97);
            this.lbl_a.Name = "lbl_a";
            this.lbl_a.Size = new System.Drawing.Size(19, 18);
            this.lbl_a.TabIndex = 86;
            this.lbl_a.Text = "A";
            // 
            // dtp_inicio
            // 
            this.dtp_inicio.CalendarFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_inicio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_inicio.Location = new System.Drawing.Point(701, 92);
            this.dtp_inicio.Name = "dtp_inicio";
            this.dtp_inicio.Size = new System.Drawing.Size(120, 26);
            this.dtp_inicio.TabIndex = 83;
            // 
            // lbl_de
            // 
            this.lbl_de.AutoSize = true;
            this.lbl_de.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_de.Location = new System.Drawing.Point(666, 97);
            this.lbl_de.Name = "lbl_de";
            this.lbl_de.Size = new System.Drawing.Size(29, 18);
            this.lbl_de.TabIndex = 84;
            this.lbl_de.Text = "De";
            // 
            // frm_opciones_egresos
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
            this.Controls.Add(this.lbl_titulo_producto);
            this.Controls.Add(this.txt_buscar_egre);
            this.Controls.Add(this.cbo_buscar_egre);
            this.Controls.Add(this.lbl_buscar);
            this.Controls.Add(this.dgv_control_egresos);
            this.Controls.Add(this.btn_editar_egreso);
            this.Controls.Add(this.btn_registrar_egreso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_opciones_egresos";
            this.Text = "Opciones_Egresos";
            this.Load += new System.EventHandler(this.frm_opciones_egresos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_control_egresos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_editar_egreso;
        private System.Windows.Forms.Button btn_registrar_egreso;
        private System.Windows.Forms.Label lbl_titulo_producto;
        private System.Windows.Forms.ComboBox cbo_buscar_egre;
        private System.Windows.Forms.Label lbl_buscar;
        public System.Windows.Forms.DataGridView dgv_control_egresos;
        private System.Windows.Forms.TextBox txt_buscar_egre;
        private System.Windows.Forms.Button btn_filtrar;
        public System.Windows.Forms.DateTimePicker dtp_fin;
        private System.Windows.Forms.Label lbl_a;
        public System.Windows.Forms.DateTimePicker dtp_inicio;
        private System.Windows.Forms.Label lbl_de;
    }
}