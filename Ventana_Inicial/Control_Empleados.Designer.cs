namespace Ventana_Inicial
{
    partial class frm_control_empleado
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
            this.dgv_control_empleado = new System.Windows.Forms.DataGridView();
            this.txt_buscar_emp = new System.Windows.Forms.TextBox();
            this.cbo_buscar_emp = new System.Windows.Forms.ComboBox();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.btn_editar_empleado = new System.Windows.Forms.Button();
            this.btn_registrar_empleado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_control_empleado)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo_producto
            // 
            this.lbl_titulo_producto.AutoSize = true;
            this.lbl_titulo_producto.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_producto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.lbl_titulo_producto.Location = new System.Drawing.Point(385, 28);
            this.lbl_titulo_producto.Name = "lbl_titulo_producto";
            this.lbl_titulo_producto.Size = new System.Drawing.Size(293, 32);
            this.lbl_titulo_producto.TabIndex = 18;
            this.lbl_titulo_producto.Text = "Control de Empleado";
            // 
            // dgv_control_empleado
            // 
            this.dgv_control_empleado.AllowUserToAddRows = false;
            this.dgv_control_empleado.AllowUserToDeleteRows = false;
            this.dgv_control_empleado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_control_empleado.BackgroundColor = System.Drawing.Color.White;
            this.dgv_control_empleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_control_empleado.Location = new System.Drawing.Point(29, 132);
            this.dgv_control_empleado.MultiSelect = false;
            this.dgv_control_empleado.Name = "dgv_control_empleado";
            this.dgv_control_empleado.ReadOnly = true;
            this.dgv_control_empleado.RowHeadersVisible = false;
            this.dgv_control_empleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_control_empleado.Size = new System.Drawing.Size(740, 456);
            this.dgv_control_empleado.TabIndex = 17;
            // 
            // txt_buscar_emp
            // 
            this.txt_buscar_emp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar_emp.Location = new System.Drawing.Point(283, 89);
            this.txt_buscar_emp.Name = "txt_buscar_emp";
            this.txt_buscar_emp.Size = new System.Drawing.Size(697, 23);
            this.txt_buscar_emp.TabIndex = 21;
            this.txt_buscar_emp.TextChanged += new System.EventHandler(this.txt_buscar_pro_TextChanged);
            // 
            // cbo_buscar_emp
            // 
            this.cbo_buscar_emp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_buscar_emp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_buscar_emp.FormattingEnabled = true;
            this.cbo_buscar_emp.Items.AddRange(new object[] {
            "Numero de DNI",
            "Nombre del Empleado"});
            this.cbo_buscar_emp.Location = new System.Drawing.Point(89, 87);
            this.cbo_buscar_emp.Name = "cbo_buscar_emp";
            this.cbo_buscar_emp.Size = new System.Drawing.Size(184, 25);
            this.cbo_buscar_emp.TabIndex = 20;
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.lbl_buscar.Location = new System.Drawing.Point(26, 88);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(57, 18);
            this.lbl_buscar.TabIndex = 19;
            this.lbl_buscar.Text = "Buscar";
            // 
            // btn_editar_empleado
            // 
            this.btn_editar_empleado.BackColor = System.Drawing.Color.White;
            this.btn_editar_empleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar_empleado.FlatAppearance.BorderSize = 0;
            this.btn_editar_empleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_editar_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar_empleado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar_empleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_editar_empleado.Image = global::Ventana_Inicial.Properties.Resources.Editar_Cliente;
            this.btn_editar_empleado.Location = new System.Drawing.Point(825, 352);
            this.btn_editar_empleado.Margin = new System.Windows.Forms.Padding(0);
            this.btn_editar_empleado.Name = "btn_editar_empleado";
            this.btn_editar_empleado.Size = new System.Drawing.Size(155, 140);
            this.btn_editar_empleado.TabIndex = 16;
            this.btn_editar_empleado.Text = "Editar Empleado";
            this.btn_editar_empleado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_editar_empleado.UseVisualStyleBackColor = false;
            this.btn_editar_empleado.Click += new System.EventHandler(this.btn_editar_empleado_Click);
            // 
            // btn_registrar_empleado
            // 
            this.btn_registrar_empleado.BackColor = System.Drawing.Color.White;
            this.btn_registrar_empleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_registrar_empleado.FlatAppearance.BorderSize = 0;
            this.btn_registrar_empleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_registrar_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar_empleado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar_empleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_registrar_empleado.Image = global::Ventana_Inicial.Properties.Resources.Nuevo_Cliente;
            this.btn_registrar_empleado.Location = new System.Drawing.Point(825, 173);
            this.btn_registrar_empleado.Margin = new System.Windows.Forms.Padding(0);
            this.btn_registrar_empleado.Name = "btn_registrar_empleado";
            this.btn_registrar_empleado.Size = new System.Drawing.Size(155, 140);
            this.btn_registrar_empleado.TabIndex = 15;
            this.btn_registrar_empleado.Text = "Registrar Empleado";
            this.btn_registrar_empleado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_registrar_empleado.UseVisualStyleBackColor = false;
            this.btn_registrar_empleado.Click += new System.EventHandler(this.btn_registrar_empleado_Click);
            // 
            // frm_control_empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.txt_buscar_emp);
            this.Controls.Add(this.cbo_buscar_emp);
            this.Controls.Add(this.lbl_buscar);
            this.Controls.Add(this.lbl_titulo_producto);
            this.Controls.Add(this.dgv_control_empleado);
            this.Controls.Add(this.btn_editar_empleado);
            this.Controls.Add(this.btn_registrar_empleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_control_empleado";
            this.Text = "Control_Empleados";
            this.Load += new System.EventHandler(this.frm_control_empleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_control_empleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_editar_empleado;
        private System.Windows.Forms.Button btn_registrar_empleado;
        private System.Windows.Forms.Label lbl_titulo_producto;
        public System.Windows.Forms.DataGridView dgv_control_empleado;
        private System.Windows.Forms.TextBox txt_buscar_emp;
        private System.Windows.Forms.ComboBox cbo_buscar_emp;
        private System.Windows.Forms.Label lbl_buscar;
    }
}