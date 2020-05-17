namespace Ventana_Inicial
{
    partial class frm_control_bono
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
            this.cbo_buscar_bono = new System.Windows.Forms.ComboBox();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.lbl_titulo_producto = new System.Windows.Forms.Label();
            this.dgv_control_bono = new System.Windows.Forms.DataGridView();
            this.btn_editar_bono = new System.Windows.Forms.Button();
            this.btn_registrar_bono = new System.Windows.Forms.Button();
            this.txt_bus_bono = new System.Windows.Forms.TextBox();
            this.dtp_inicio = new System.Windows.Forms.DateTimePicker();
            this.lbl_de = new System.Windows.Forms.Label();
            this.dtp_fin = new System.Windows.Forms.DateTimePicker();
            this.lbl_a = new System.Windows.Forms.Label();
            this.btn_filtrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_control_bono)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_buscar_bono
            // 
            this.cbo_buscar_bono.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_buscar_bono.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_buscar_bono.FormattingEnabled = true;
            this.cbo_buscar_bono.Items.AddRange(new object[] {
            "Fecha",
            "Empleado y Fecha"});
            this.cbo_buscar_bono.Location = new System.Drawing.Point(90, 95);
            this.cbo_buscar_bono.Name = "cbo_buscar_bono";
            this.cbo_buscar_bono.Size = new System.Drawing.Size(158, 25);
            this.cbo_buscar_bono.TabIndex = 27;
            this.cbo_buscar_bono.SelectedIndexChanged += new System.EventHandler(this.cbo_buscar_bono_SelectedIndexChanged);
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.lbl_buscar.Location = new System.Drawing.Point(9, 96);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(57, 18);
            this.lbl_buscar.TabIndex = 26;
            this.lbl_buscar.Text = "Buscar";
            // 
            // lbl_titulo_producto
            // 
            this.lbl_titulo_producto.AutoSize = true;
            this.lbl_titulo_producto.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_producto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.lbl_titulo_producto.Location = new System.Drawing.Point(404, 23);
            this.lbl_titulo_producto.Name = "lbl_titulo_producto";
            this.lbl_titulo_producto.Size = new System.Drawing.Size(238, 32);
            this.lbl_titulo_producto.TabIndex = 25;
            this.lbl_titulo_producto.Text = "Control de Bonos";
            // 
            // dgv_control_bono
            // 
            this.dgv_control_bono.AllowUserToAddRows = false;
            this.dgv_control_bono.AllowUserToDeleteRows = false;
            this.dgv_control_bono.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_control_bono.BackgroundColor = System.Drawing.Color.White;
            this.dgv_control_bono.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_control_bono.Location = new System.Drawing.Point(12, 132);
            this.dgv_control_bono.MultiSelect = false;
            this.dgv_control_bono.Name = "dgv_control_bono";
            this.dgv_control_bono.ReadOnly = true;
            this.dgv_control_bono.RowHeadersVisible = false;
            this.dgv_control_bono.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_control_bono.Size = new System.Drawing.Size(740, 456);
            this.dgv_control_bono.TabIndex = 24;
            // 
            // btn_editar_bono
            // 
            this.btn_editar_bono.BackColor = System.Drawing.Color.White;
            this.btn_editar_bono.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar_bono.FlatAppearance.BorderSize = 0;
            this.btn_editar_bono.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_editar_bono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar_bono.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar_bono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_editar_bono.Image = global::Ventana_Inicial.Properties.Resources.Editar_Cliente;
            this.btn_editar_bono.Location = new System.Drawing.Point(816, 353);
            this.btn_editar_bono.Margin = new System.Windows.Forms.Padding(0);
            this.btn_editar_bono.Name = "btn_editar_bono";
            this.btn_editar_bono.Size = new System.Drawing.Size(155, 140);
            this.btn_editar_bono.TabIndex = 23;
            this.btn_editar_bono.Text = "Editar Bono";
            this.btn_editar_bono.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_editar_bono.UseVisualStyleBackColor = false;
            this.btn_editar_bono.Click += new System.EventHandler(this.btn_editar_bono_Click);
            // 
            // btn_registrar_bono
            // 
            this.btn_registrar_bono.BackColor = System.Drawing.Color.White;
            this.btn_registrar_bono.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_registrar_bono.FlatAppearance.BorderSize = 0;
            this.btn_registrar_bono.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_registrar_bono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar_bono.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar_bono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_registrar_bono.Image = global::Ventana_Inicial.Properties.Resources.Nuevo_Cliente;
            this.btn_registrar_bono.Location = new System.Drawing.Point(816, 201);
            this.btn_registrar_bono.Margin = new System.Windows.Forms.Padding(0);
            this.btn_registrar_bono.Name = "btn_registrar_bono";
            this.btn_registrar_bono.Size = new System.Drawing.Size(155, 140);
            this.btn_registrar_bono.TabIndex = 22;
            this.btn_registrar_bono.Text = "Registrar Bono";
            this.btn_registrar_bono.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_registrar_bono.UseVisualStyleBackColor = false;
            this.btn_registrar_bono.Click += new System.EventHandler(this.btn_registrar_bono_Click);
            // 
            // txt_bus_bono
            // 
            this.txt_bus_bono.Enabled = false;
            this.txt_bus_bono.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bus_bono.Location = new System.Drawing.Point(254, 95);
            this.txt_bus_bono.Name = "txt_bus_bono";
            this.txt_bus_bono.Size = new System.Drawing.Size(374, 23);
            this.txt_bus_bono.TabIndex = 28;
            // 
            // dtp_inicio
            // 
            this.dtp_inicio.CalendarFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_inicio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_inicio.Location = new System.Drawing.Point(683, 92);
            this.dtp_inicio.Name = "dtp_inicio";
            this.dtp_inicio.Size = new System.Drawing.Size(120, 26);
            this.dtp_inicio.TabIndex = 73;
            this.dtp_inicio.ValueChanged += new System.EventHandler(this.dtp_inicio_ValueChanged);
            // 
            // lbl_de
            // 
            this.lbl_de.AutoSize = true;
            this.lbl_de.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_de.Location = new System.Drawing.Point(648, 97);
            this.lbl_de.Name = "lbl_de";
            this.lbl_de.Size = new System.Drawing.Size(29, 18);
            this.lbl_de.TabIndex = 74;
            this.lbl_de.Text = "De";
            // 
            // dtp_fin
            // 
            this.dtp_fin.CalendarFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fin.Location = new System.Drawing.Point(851, 92);
            this.dtp_fin.Name = "dtp_fin";
            this.dtp_fin.Size = new System.Drawing.Size(120, 26);
            this.dtp_fin.TabIndex = 75;
            // 
            // lbl_a
            // 
            this.lbl_a.AutoSize = true;
            this.lbl_a.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_a.Location = new System.Drawing.Point(816, 97);
            this.lbl_a.Name = "lbl_a";
            this.lbl_a.Size = new System.Drawing.Size(19, 18);
            this.lbl_a.TabIndex = 76;
            this.lbl_a.Text = "A";
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.Location = new System.Drawing.Point(851, 132);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(75, 23);
            this.btn_filtrar.TabIndex = 77;
            this.btn_filtrar.Text = "Filtrar";
            this.btn_filtrar.UseVisualStyleBackColor = true;
            this.btn_filtrar.Click += new System.EventHandler(this.btn_filtrar_Click);
            // 
            // frm_control_bono
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
            this.Controls.Add(this.txt_bus_bono);
            this.Controls.Add(this.cbo_buscar_bono);
            this.Controls.Add(this.lbl_buscar);
            this.Controls.Add(this.lbl_titulo_producto);
            this.Controls.Add(this.dgv_control_bono);
            this.Controls.Add(this.btn_editar_bono);
            this.Controls.Add(this.btn_registrar_bono);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_control_bono";
            this.Text = "Control_Bono";
            this.Load += new System.EventHandler(this.frm_control_bono_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_control_bono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_buscar_bono;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.Label lbl_titulo_producto;
        public System.Windows.Forms.DataGridView dgv_control_bono;
        private System.Windows.Forms.Button btn_editar_bono;
        private System.Windows.Forms.Button btn_registrar_bono;
        private System.Windows.Forms.TextBox txt_bus_bono;
        public System.Windows.Forms.DateTimePicker dtp_inicio;
        private System.Windows.Forms.Label lbl_de;
        public System.Windows.Forms.DateTimePicker dtp_fin;
        private System.Windows.Forms.Label lbl_a;
        private System.Windows.Forms.Button btn_filtrar;
    }
}