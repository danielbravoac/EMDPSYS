namespace Ventana_Inicial
{
    partial class frm_descuento
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
            this.cbo_empleado = new System.Windows.Forms.ComboBox();
            this.nud_cantidad_descuento = new System.Windows.Forms.NumericUpDown();
            this.lbl_dni_empleado = new System.Windows.Forms.Label();
            this.lbl_cantidad_descuento = new System.Windows.Forms.Label();
            this.lbl_motivo_descuento = new System.Windows.Forms.Label();
            this.txt_motivo_descuento = new System.Windows.Forms.TextBox();
            this.lbl_control_descuento = new System.Windows.Forms.Label();
            this.btn_registrar_descuento = new System.Windows.Forms.Button();
            this.pic_volver = new System.Windows.Forms.PictureBox();
            this.btn_actualizar_descuento = new System.Windows.Forms.Button();
            this.lbl_id_descuento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cantidad_descuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_volver)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_empleado
            // 
            this.cbo_empleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_empleado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_empleado.FormattingEnabled = true;
            this.cbo_empleado.Location = new System.Drawing.Point(341, 331);
            this.cbo_empleado.Name = "cbo_empleado";
            this.cbo_empleado.Size = new System.Drawing.Size(223, 25);
            this.cbo_empleado.TabIndex = 3;
            // 
            // nud_cantidad_descuento
            // 
            this.nud_cantidad_descuento.DecimalPlaces = 2;
            this.nud_cantidad_descuento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_cantidad_descuento.Location = new System.Drawing.Point(341, 274);
            this.nud_cantidad_descuento.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nud_cantidad_descuento.Name = "nud_cantidad_descuento";
            this.nud_cantidad_descuento.Size = new System.Drawing.Size(120, 23);
            this.nud_cantidad_descuento.TabIndex = 2;
            // 
            // lbl_dni_empleado
            // 
            this.lbl_dni_empleado.AutoSize = true;
            this.lbl_dni_empleado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dni_empleado.Location = new System.Drawing.Point(174, 330);
            this.lbl_dni_empleado.Name = "lbl_dni_empleado";
            this.lbl_dni_empleado.Size = new System.Drawing.Size(142, 18);
            this.lbl_dni_empleado.TabIndex = 116;
            this.lbl_dni_empleado.Text = "DNI del Empleado";
            // 
            // lbl_cantidad_descuento
            // 
            this.lbl_cantidad_descuento.AutoSize = true;
            this.lbl_cantidad_descuento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad_descuento.Location = new System.Drawing.Point(132, 273);
            this.lbl_cantidad_descuento.Name = "lbl_cantidad_descuento";
            this.lbl_cantidad_descuento.Size = new System.Drawing.Size(184, 18);
            this.lbl_cantidad_descuento.TabIndex = 117;
            this.lbl_cantidad_descuento.Text = "Cantidad de Descuento";
            // 
            // lbl_motivo_descuento
            // 
            this.lbl_motivo_descuento.AutoSize = true;
            this.lbl_motivo_descuento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_motivo_descuento.Location = new System.Drawing.Point(151, 218);
            this.lbl_motivo_descuento.Name = "lbl_motivo_descuento";
            this.lbl_motivo_descuento.Size = new System.Drawing.Size(165, 18);
            this.lbl_motivo_descuento.TabIndex = 118;
            this.lbl_motivo_descuento.Text = "Motivo de Descuento";
            // 
            // txt_motivo_descuento
            // 
            this.txt_motivo_descuento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_motivo_descuento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_motivo_descuento.Location = new System.Drawing.Point(341, 218);
            this.txt_motivo_descuento.Name = "txt_motivo_descuento";
            this.txt_motivo_descuento.Size = new System.Drawing.Size(587, 23);
            this.txt_motivo_descuento.TabIndex = 1;
            this.txt_motivo_descuento.TextChanged += new System.EventHandler(this.txt_motivo_descuento_TextChanged);
            // 
            // lbl_control_descuento
            // 
            this.lbl_control_descuento.AutoSize = true;
            this.lbl_control_descuento.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_control_descuento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.lbl_control_descuento.Location = new System.Drawing.Point(427, 61);
            this.lbl_control_descuento.Name = "lbl_control_descuento";
            this.lbl_control_descuento.Size = new System.Drawing.Size(274, 32);
            this.lbl_control_descuento.TabIndex = 113;
            this.lbl_control_descuento.Text = "[Control] Descuento";
            // 
            // btn_registrar_descuento
            // 
            this.btn_registrar_descuento.Enabled = false;
            this.btn_registrar_descuento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_registrar_descuento.FlatAppearance.BorderSize = 2;
            this.btn_registrar_descuento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar_descuento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar_descuento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_registrar_descuento.Location = new System.Drawing.Point(757, 444);
            this.btn_registrar_descuento.Name = "btn_registrar_descuento";
            this.btn_registrar_descuento.Size = new System.Drawing.Size(200, 45);
            this.btn_registrar_descuento.TabIndex = 4;
            this.btn_registrar_descuento.Text = "Registrar Descuento";
            this.btn_registrar_descuento.UseVisualStyleBackColor = true;
            this.btn_registrar_descuento.Click += new System.EventHandler(this.btn_registrar_descuento_Click);
            // 
            // pic_volver
            // 
            this.pic_volver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_volver.Image = global::Ventana_Inicial.Properties.Resources.Atras;
            this.pic_volver.Location = new System.Drawing.Point(94, 47);
            this.pic_volver.Name = "pic_volver";
            this.pic_volver.Size = new System.Drawing.Size(20, 32);
            this.pic_volver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_volver.TabIndex = 114;
            this.pic_volver.TabStop = false;
            this.pic_volver.Click += new System.EventHandler(this.pic_volver_Click);
            // 
            // btn_actualizar_descuento
            // 
            this.btn_actualizar_descuento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_actualizar_descuento.FlatAppearance.BorderSize = 2;
            this.btn_actualizar_descuento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizar_descuento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar_descuento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_actualizar_descuento.Location = new System.Drawing.Point(757, 444);
            this.btn_actualizar_descuento.Name = "btn_actualizar_descuento";
            this.btn_actualizar_descuento.Size = new System.Drawing.Size(200, 45);
            this.btn_actualizar_descuento.TabIndex = 4;
            this.btn_actualizar_descuento.Text = "Actualizar Descuento";
            this.btn_actualizar_descuento.UseVisualStyleBackColor = true;
            this.btn_actualizar_descuento.Click += new System.EventHandler(this.btn_actualizar_descuento_Click);
            // 
            // lbl_id_descuento
            // 
            this.lbl_id_descuento.AutoSize = true;
            this.lbl_id_descuento.Location = new System.Drawing.Point(341, 175);
            this.lbl_id_descuento.Name = "lbl_id_descuento";
            this.lbl_id_descuento.Size = new System.Drawing.Size(76, 13);
            this.lbl_id_descuento.TabIndex = 121;
            this.lbl_id_descuento.Text = "ID_Descuento";
            this.lbl_id_descuento.Visible = false;
            // 
            // frm_descuento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.lbl_id_descuento);
            this.Controls.Add(this.cbo_empleado);
            this.Controls.Add(this.nud_cantidad_descuento);
            this.Controls.Add(this.lbl_dni_empleado);
            this.Controls.Add(this.lbl_cantidad_descuento);
            this.Controls.Add(this.lbl_motivo_descuento);
            this.Controls.Add(this.txt_motivo_descuento);
            this.Controls.Add(this.pic_volver);
            this.Controls.Add(this.lbl_control_descuento);
            this.Controls.Add(this.btn_actualizar_descuento);
            this.Controls.Add(this.btn_registrar_descuento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_descuento";
            this.Text = "Nuevo_Descuento";
            this.Load += new System.EventHandler(this.frm_nuevo_descuento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_cantidad_descuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_volver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_dni_empleado;
        private System.Windows.Forms.Label lbl_cantidad_descuento;
        private System.Windows.Forms.Label lbl_motivo_descuento;
        private System.Windows.Forms.PictureBox pic_volver;
        public System.Windows.Forms.Button btn_actualizar_descuento;
        public System.Windows.Forms.ComboBox cbo_empleado;
        public System.Windows.Forms.NumericUpDown nud_cantidad_descuento;
        public System.Windows.Forms.TextBox txt_motivo_descuento;
        public System.Windows.Forms.Label lbl_control_descuento;
        public System.Windows.Forms.Button btn_registrar_descuento;
        public System.Windows.Forms.Label lbl_id_descuento;
    }
}