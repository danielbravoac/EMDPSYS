namespace Ventana_Inicial
{
    partial class frm_control_cliente
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
            this.lbl_titulo_cliente = new System.Windows.Forms.Label();
            this.dgv_control_cliente = new System.Windows.Forms.DataGridView();
            this.txt_buscar_cli = new System.Windows.Forms.TextBox();
            this.cbo_buscar_cli = new System.Windows.Forms.ComboBox();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.btn_editar_cliente = new System.Windows.Forms.Button();
            this.btn_registrar_cliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_control_cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo_cliente
            // 
            this.lbl_titulo_cliente.AutoSize = true;
            this.lbl_titulo_cliente.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_cliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.lbl_titulo_cliente.Location = new System.Drawing.Point(385, 33);
            this.lbl_titulo_cliente.Name = "lbl_titulo_cliente";
            this.lbl_titulo_cliente.Size = new System.Drawing.Size(251, 32);
            this.lbl_titulo_cliente.TabIndex = 13;
            this.lbl_titulo_cliente.Text = "Control de Cliente";
            // 
            // dgv_control_cliente
            // 
            this.dgv_control_cliente.AllowUserToAddRows = false;
            this.dgv_control_cliente.AllowUserToDeleteRows = false;
            this.dgv_control_cliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_control_cliente.BackgroundColor = System.Drawing.Color.White;
            this.dgv_control_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_control_cliente.Location = new System.Drawing.Point(12, 132);
            this.dgv_control_cliente.MultiSelect = false;
            this.dgv_control_cliente.Name = "dgv_control_cliente";
            this.dgv_control_cliente.ReadOnly = true;
            this.dgv_control_cliente.RowHeadersVisible = false;
            this.dgv_control_cliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_control_cliente.Size = new System.Drawing.Size(740, 456);
            this.dgv_control_cliente.TabIndex = 12;
            // 
            // txt_buscar_cli
            // 
            this.txt_buscar_cli.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar_cli.Location = new System.Drawing.Point(258, 95);
            this.txt_buscar_cli.Name = "txt_buscar_cli";
            this.txt_buscar_cli.Size = new System.Drawing.Size(697, 23);
            this.txt_buscar_cli.TabIndex = 16;
            this.txt_buscar_cli.TextChanged += new System.EventHandler(this.txt_buscar_cli_TextChanged);
            // 
            // cbo_buscar_cli
            // 
            this.cbo_buscar_cli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_buscar_cli.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_buscar_cli.FormattingEnabled = true;
            this.cbo_buscar_cli.Items.AddRange(new object[] {
            "Numero de Documento",
            "Nombre de Cliente"});
            this.cbo_buscar_cli.Location = new System.Drawing.Point(75, 95);
            this.cbo_buscar_cli.Name = "cbo_buscar_cli";
            this.cbo_buscar_cli.Size = new System.Drawing.Size(167, 25);
            this.cbo_buscar_cli.TabIndex = 15;
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.lbl_buscar.Location = new System.Drawing.Point(12, 96);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(57, 18);
            this.lbl_buscar.TabIndex = 14;
            this.lbl_buscar.Text = "Buscar";
            // 
            // btn_editar_cliente
            // 
            this.btn_editar_cliente.BackColor = System.Drawing.Color.White;
            this.btn_editar_cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar_cliente.FlatAppearance.BorderSize = 0;
            this.btn_editar_cliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_editar_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar_cliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar_cliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_editar_cliente.Image = global::Ventana_Inicial.Properties.Resources.Editar_Cliente;
            this.btn_editar_cliente.Location = new System.Drawing.Point(800, 357);
            this.btn_editar_cliente.Margin = new System.Windows.Forms.Padding(0);
            this.btn_editar_cliente.Name = "btn_editar_cliente";
            this.btn_editar_cliente.Size = new System.Drawing.Size(155, 130);
            this.btn_editar_cliente.TabIndex = 11;
            this.btn_editar_cliente.Text = "Editar Cliente";
            this.btn_editar_cliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_editar_cliente.UseVisualStyleBackColor = false;
            this.btn_editar_cliente.Click += new System.EventHandler(this.btn_editar_cliente_Click);
            // 
            // btn_registrar_cliente
            // 
            this.btn_registrar_cliente.BackColor = System.Drawing.Color.White;
            this.btn_registrar_cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_registrar_cliente.FlatAppearance.BorderSize = 0;
            this.btn_registrar_cliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_registrar_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar_cliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar_cliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_registrar_cliente.Image = global::Ventana_Inicial.Properties.Resources.Nuevo_Cliente;
            this.btn_registrar_cliente.Location = new System.Drawing.Point(800, 200);
            this.btn_registrar_cliente.Margin = new System.Windows.Forms.Padding(0);
            this.btn_registrar_cliente.Name = "btn_registrar_cliente";
            this.btn_registrar_cliente.Size = new System.Drawing.Size(155, 130);
            this.btn_registrar_cliente.TabIndex = 11;
            this.btn_registrar_cliente.Text = "Registrar Cliente";
            this.btn_registrar_cliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_registrar_cliente.UseVisualStyleBackColor = false;
            this.btn_registrar_cliente.Click += new System.EventHandler(this.btn_registrar_cliente_Click);
            // 
            // frm_control_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.txt_buscar_cli);
            this.Controls.Add(this.cbo_buscar_cli);
            this.Controls.Add(this.lbl_buscar);
            this.Controls.Add(this.lbl_titulo_cliente);
            this.Controls.Add(this.dgv_control_cliente);
            this.Controls.Add(this.btn_editar_cliente);
            this.Controls.Add(this.btn_registrar_cliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_control_cliente";
            this.Text = "Opciones_Cliente";
            this.Load += new System.EventHandler(this.frm_control_cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_control_cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_registrar_cliente;
        private System.Windows.Forms.Button btn_editar_cliente;
        private System.Windows.Forms.Label lbl_titulo_cliente;
        public System.Windows.Forms.DataGridView dgv_control_cliente;
        private System.Windows.Forms.TextBox txt_buscar_cli;
        private System.Windows.Forms.ComboBox cbo_buscar_cli;
        private System.Windows.Forms.Label lbl_buscar;
    }
}