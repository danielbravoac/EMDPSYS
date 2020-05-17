namespace Ventana_Inicial
{
    partial class frm_control_descuentos
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
            this.txt_buscar_des = new System.Windows.Forms.TextBox();
            this.cbo_buscar_des = new System.Windows.Forms.ComboBox();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.lbl_control_descuentos = new System.Windows.Forms.Label();
            this.dgv_control_descuento = new System.Windows.Forms.DataGridView();
            this.btn_editar_descuento = new System.Windows.Forms.Button();
            this.btn_registrar_descuento = new System.Windows.Forms.Button();
            this.btn_filtrar = new System.Windows.Forms.Button();
            this.dtp_fin = new System.Windows.Forms.DateTimePicker();
            this.lbl_a = new System.Windows.Forms.Label();
            this.dtp_inicio = new System.Windows.Forms.DateTimePicker();
            this.lbl_de = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_control_descuento)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_buscar_des
            // 
            this.txt_buscar_des.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar_des.Location = new System.Drawing.Point(251, 95);
            this.txt_buscar_des.Name = "txt_buscar_des";
            this.txt_buscar_des.Size = new System.Drawing.Size(374, 23);
            this.txt_buscar_des.TabIndex = 35;
            // 
            // cbo_buscar_des
            // 
            this.cbo_buscar_des.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_buscar_des.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_buscar_des.FormattingEnabled = true;
            this.cbo_buscar_des.Items.AddRange(new object[] {
            "Fecha",
            "Empleado y Fecha"});
            this.cbo_buscar_des.Location = new System.Drawing.Point(75, 92);
            this.cbo_buscar_des.Name = "cbo_buscar_des";
            this.cbo_buscar_des.Size = new System.Drawing.Size(158, 25);
            this.cbo_buscar_des.TabIndex = 34;
            this.cbo_buscar_des.SelectedIndexChanged += new System.EventHandler(this.cbo_buscar_des_SelectedIndexChanged);
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.lbl_buscar.Location = new System.Drawing.Point(12, 96);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(57, 18);
            this.lbl_buscar.TabIndex = 33;
            this.lbl_buscar.Text = "Buscar";
            // 
            // lbl_control_descuentos
            // 
            this.lbl_control_descuentos.AutoSize = true;
            this.lbl_control_descuentos.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_control_descuentos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.lbl_control_descuentos.Location = new System.Drawing.Point(404, 23);
            this.lbl_control_descuentos.Name = "lbl_control_descuentos";
            this.lbl_control_descuentos.Size = new System.Drawing.Size(311, 32);
            this.lbl_control_descuentos.TabIndex = 32;
            this.lbl_control_descuentos.Text = "Control de Descuentos";
            // 
            // dgv_control_descuento
            // 
            this.dgv_control_descuento.AllowUserToAddRows = false;
            this.dgv_control_descuento.AllowUserToDeleteRows = false;
            this.dgv_control_descuento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_control_descuento.BackgroundColor = System.Drawing.Color.White;
            this.dgv_control_descuento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_control_descuento.Location = new System.Drawing.Point(12, 132);
            this.dgv_control_descuento.MultiSelect = false;
            this.dgv_control_descuento.Name = "dgv_control_descuento";
            this.dgv_control_descuento.ReadOnly = true;
            this.dgv_control_descuento.RowHeadersVisible = false;
            this.dgv_control_descuento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_control_descuento.Size = new System.Drawing.Size(740, 456);
            this.dgv_control_descuento.TabIndex = 31;
            // 
            // btn_editar_descuento
            // 
            this.btn_editar_descuento.BackColor = System.Drawing.Color.White;
            this.btn_editar_descuento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar_descuento.FlatAppearance.BorderSize = 0;
            this.btn_editar_descuento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_editar_descuento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar_descuento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar_descuento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_editar_descuento.Image = global::Ventana_Inicial.Properties.Resources.Editar_Cliente;
            this.btn_editar_descuento.Location = new System.Drawing.Point(822, 356);
            this.btn_editar_descuento.Margin = new System.Windows.Forms.Padding(0);
            this.btn_editar_descuento.Name = "btn_editar_descuento";
            this.btn_editar_descuento.Size = new System.Drawing.Size(155, 140);
            this.btn_editar_descuento.TabIndex = 30;
            this.btn_editar_descuento.Text = "Editar Descuento";
            this.btn_editar_descuento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_editar_descuento.UseVisualStyleBackColor = false;
            this.btn_editar_descuento.Click += new System.EventHandler(this.btn_editar_descuento_Click);
            // 
            // btn_registrar_descuento
            // 
            this.btn_registrar_descuento.BackColor = System.Drawing.Color.White;
            this.btn_registrar_descuento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_registrar_descuento.FlatAppearance.BorderSize = 0;
            this.btn_registrar_descuento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_registrar_descuento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar_descuento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar_descuento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_registrar_descuento.Image = global::Ventana_Inicial.Properties.Resources.Nuevo_Cliente;
            this.btn_registrar_descuento.Location = new System.Drawing.Point(822, 204);
            this.btn_registrar_descuento.Margin = new System.Windows.Forms.Padding(0);
            this.btn_registrar_descuento.Name = "btn_registrar_descuento";
            this.btn_registrar_descuento.Size = new System.Drawing.Size(155, 140);
            this.btn_registrar_descuento.TabIndex = 29;
            this.btn_registrar_descuento.Text = "Registrar Descuento";
            this.btn_registrar_descuento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_registrar_descuento.UseVisualStyleBackColor = false;
            this.btn_registrar_descuento.Click += new System.EventHandler(this.btn_registrar_descuento_Click);
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.Location = new System.Drawing.Point(853, 132);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(75, 23);
            this.btn_filtrar.TabIndex = 82;
            this.btn_filtrar.Text = "Filtrar";
            this.btn_filtrar.UseVisualStyleBackColor = true;
            this.btn_filtrar.Click += new System.EventHandler(this.btn_filtrar_Click);
            // 
            // dtp_fin
            // 
            this.dtp_fin.CalendarFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fin.Location = new System.Drawing.Point(853, 92);
            this.dtp_fin.Name = "dtp_fin";
            this.dtp_fin.Size = new System.Drawing.Size(120, 26);
            this.dtp_fin.TabIndex = 80;
            // 
            // lbl_a
            // 
            this.lbl_a.AutoSize = true;
            this.lbl_a.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_a.Location = new System.Drawing.Point(818, 97);
            this.lbl_a.Name = "lbl_a";
            this.lbl_a.Size = new System.Drawing.Size(19, 18);
            this.lbl_a.TabIndex = 81;
            this.lbl_a.Text = "A";
            // 
            // dtp_inicio
            // 
            this.dtp_inicio.CalendarFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_inicio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_inicio.Location = new System.Drawing.Point(685, 92);
            this.dtp_inicio.Name = "dtp_inicio";
            this.dtp_inicio.Size = new System.Drawing.Size(120, 26);
            this.dtp_inicio.TabIndex = 78;
            // 
            // lbl_de
            // 
            this.lbl_de.AutoSize = true;
            this.lbl_de.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_de.Location = new System.Drawing.Point(650, 97);
            this.lbl_de.Name = "lbl_de";
            this.lbl_de.Size = new System.Drawing.Size(29, 18);
            this.lbl_de.TabIndex = 79;
            this.lbl_de.Text = "De";
            // 
            // frm_control_descuentos
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
            this.Controls.Add(this.txt_buscar_des);
            this.Controls.Add(this.cbo_buscar_des);
            this.Controls.Add(this.lbl_buscar);
            this.Controls.Add(this.lbl_control_descuentos);
            this.Controls.Add(this.dgv_control_descuento);
            this.Controls.Add(this.btn_editar_descuento);
            this.Controls.Add(this.btn_registrar_descuento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_control_descuentos";
            this.Text = "Control_Descuentos";
            this.Load += new System.EventHandler(this.Control_Descuentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_control_descuento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_buscar_des;
        private System.Windows.Forms.ComboBox cbo_buscar_des;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.Label lbl_control_descuentos;
        public System.Windows.Forms.DataGridView dgv_control_descuento;
        private System.Windows.Forms.Button btn_editar_descuento;
        private System.Windows.Forms.Button btn_registrar_descuento;
        private System.Windows.Forms.Button btn_filtrar;
        public System.Windows.Forms.DateTimePicker dtp_fin;
        private System.Windows.Forms.Label lbl_a;
        public System.Windows.Forms.DateTimePicker dtp_inicio;
        private System.Windows.Forms.Label lbl_de;
    }
}