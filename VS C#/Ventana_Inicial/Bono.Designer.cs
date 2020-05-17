namespace Ventana_Inicial
{
    partial class frm_bono
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
            this.nud_cantidad_bono = new System.Windows.Forms.NumericUpDown();
            this.lbl_cantidad_bono = new System.Windows.Forms.Label();
            this.lbl_motivo_bono = new System.Windows.Forms.Label();
            this.txt_motivo_bono = new System.Windows.Forms.TextBox();
            this.lbl_control_bono = new System.Windows.Forms.Label();
            this.btn_registrar_bono = new System.Windows.Forms.Button();
            this.cbo_empleado = new System.Windows.Forms.ComboBox();
            this.lbl_dni_empleado = new System.Windows.Forms.Label();
            this.pic_volver = new System.Windows.Forms.PictureBox();
            this.lbl_id_bono = new System.Windows.Forms.Label();
            this.btn_actualizar_bono = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cantidad_bono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_volver)).BeginInit();
            this.SuspendLayout();
            // 
            // nud_cantidad_bono
            // 
            this.nud_cantidad_bono.DecimalPlaces = 2;
            this.nud_cantidad_bono.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_cantidad_bono.Location = new System.Drawing.Point(341, 293);
            this.nud_cantidad_bono.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nud_cantidad_bono.Name = "nud_cantidad_bono";
            this.nud_cantidad_bono.Size = new System.Drawing.Size(120, 23);
            this.nud_cantidad_bono.TabIndex = 2;
            this.nud_cantidad_bono.ValueChanged += new System.EventHandler(this.nud_cantidad_bono_ValueChanged);
            // 
            // lbl_cantidad_bono
            // 
            this.lbl_cantidad_bono.AutoSize = true;
            this.lbl_cantidad_bono.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad_bono.Location = new System.Drawing.Point(173, 293);
            this.lbl_cantidad_bono.Name = "lbl_cantidad_bono";
            this.lbl_cantidad_bono.Size = new System.Drawing.Size(143, 18);
            this.lbl_cantidad_bono.TabIndex = 108;
            this.lbl_cantidad_bono.Text = "Cantidad de Bono";
            // 
            // lbl_motivo_bono
            // 
            this.lbl_motivo_bono.AutoSize = true;
            this.lbl_motivo_bono.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_motivo_bono.Location = new System.Drawing.Point(192, 237);
            this.lbl_motivo_bono.Name = "lbl_motivo_bono";
            this.lbl_motivo_bono.Size = new System.Drawing.Size(124, 18);
            this.lbl_motivo_bono.TabIndex = 109;
            this.lbl_motivo_bono.Text = "Motivo de Bono";
            // 
            // txt_motivo_bono
            // 
            this.txt_motivo_bono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_motivo_bono.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_motivo_bono.Location = new System.Drawing.Point(341, 237);
            this.txt_motivo_bono.Name = "txt_motivo_bono";
            this.txt_motivo_bono.Size = new System.Drawing.Size(587, 23);
            this.txt_motivo_bono.TabIndex = 1;
            // 
            // lbl_control_bono
            // 
            this.lbl_control_bono.AutoSize = true;
            this.lbl_control_bono.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_control_bono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.lbl_control_bono.Location = new System.Drawing.Point(436, 61);
            this.lbl_control_bono.Name = "lbl_control_bono";
            this.lbl_control_bono.Size = new System.Drawing.Size(201, 32);
            this.lbl_control_bono.TabIndex = 104;
            this.lbl_control_bono.Text = "[Control] Bono";
            // 
            // btn_registrar_bono
            // 
            this.btn_registrar_bono.Enabled = false;
            this.btn_registrar_bono.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_registrar_bono.FlatAppearance.BorderSize = 2;
            this.btn_registrar_bono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar_bono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar_bono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_registrar_bono.Location = new System.Drawing.Point(757, 509);
            this.btn_registrar_bono.Name = "btn_registrar_bono";
            this.btn_registrar_bono.Size = new System.Drawing.Size(200, 45);
            this.btn_registrar_bono.TabIndex = 4;
            this.btn_registrar_bono.Text = "Registrar Bono";
            this.btn_registrar_bono.UseVisualStyleBackColor = true;
            this.btn_registrar_bono.Click += new System.EventHandler(this.btn_registrar_bono_Click);
            // 
            // cbo_empleado
            // 
            this.cbo_empleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_empleado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_empleado.FormattingEnabled = true;
            this.cbo_empleado.Location = new System.Drawing.Point(341, 350);
            this.cbo_empleado.Name = "cbo_empleado";
            this.cbo_empleado.Size = new System.Drawing.Size(223, 25);
            this.cbo_empleado.TabIndex = 3;
            this.cbo_empleado.SelectedIndexChanged += new System.EventHandler(this.cbo_empleado_SelectedIndexChanged);
            // 
            // lbl_dni_empleado
            // 
            this.lbl_dni_empleado.AutoSize = true;
            this.lbl_dni_empleado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dni_empleado.Location = new System.Drawing.Point(174, 353);
            this.lbl_dni_empleado.Name = "lbl_dni_empleado";
            this.lbl_dni_empleado.Size = new System.Drawing.Size(142, 18);
            this.lbl_dni_empleado.TabIndex = 108;
            this.lbl_dni_empleado.Text = "DNI del Empleado";
            // 
            // pic_volver
            // 
            this.pic_volver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_volver.Image = global::Ventana_Inicial.Properties.Resources.Atras;
            this.pic_volver.Location = new System.Drawing.Point(94, 47);
            this.pic_volver.Name = "pic_volver";
            this.pic_volver.Size = new System.Drawing.Size(20, 32);
            this.pic_volver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_volver.TabIndex = 105;
            this.pic_volver.TabStop = false;
            this.pic_volver.Click += new System.EventHandler(this.pic_volver_Click);
            // 
            // lbl_id_bono
            // 
            this.lbl_id_bono.AutoSize = true;
            this.lbl_id_bono.Location = new System.Drawing.Point(341, 180);
            this.lbl_id_bono.Name = "lbl_id_bono";
            this.lbl_id_bono.Size = new System.Drawing.Size(49, 13);
            this.lbl_id_bono.TabIndex = 112;
            this.lbl_id_bono.Text = "ID_Bono";
            this.lbl_id_bono.Visible = false;
            // 
            // btn_actualizar_bono
            // 
            this.btn_actualizar_bono.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_actualizar_bono.FlatAppearance.BorderSize = 2;
            this.btn_actualizar_bono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizar_bono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar_bono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_actualizar_bono.Location = new System.Drawing.Point(757, 509);
            this.btn_actualizar_bono.Name = "btn_actualizar_bono";
            this.btn_actualizar_bono.Size = new System.Drawing.Size(200, 45);
            this.btn_actualizar_bono.TabIndex = 4;
            this.btn_actualizar_bono.Text = "Actualizar Bono";
            this.btn_actualizar_bono.UseVisualStyleBackColor = true;
            this.btn_actualizar_bono.Click += new System.EventHandler(this.btn_actualizar_bono_Click);
            // 
            // frm_bono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.lbl_id_bono);
            this.Controls.Add(this.cbo_empleado);
            this.Controls.Add(this.nud_cantidad_bono);
            this.Controls.Add(this.lbl_dni_empleado);
            this.Controls.Add(this.lbl_cantidad_bono);
            this.Controls.Add(this.lbl_motivo_bono);
            this.Controls.Add(this.txt_motivo_bono);
            this.Controls.Add(this.pic_volver);
            this.Controls.Add(this.lbl_control_bono);
            this.Controls.Add(this.btn_actualizar_bono);
            this.Controls.Add(this.btn_registrar_bono);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_bono";
            this.Text = "Nuevo_Bono";
            this.Load += new System.EventHandler(this.frm_nuevo_bono_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_cantidad_bono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_volver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cantidad_bono;
        private System.Windows.Forms.Label lbl_motivo_bono;
        private System.Windows.Forms.PictureBox pic_volver;
        private System.Windows.Forms.Label lbl_dni_empleado;
        public System.Windows.Forms.NumericUpDown nud_cantidad_bono;
        public System.Windows.Forms.TextBox txt_motivo_bono;
        public System.Windows.Forms.ComboBox cbo_empleado;
        public System.Windows.Forms.Label lbl_id_bono;
        public System.Windows.Forms.Button btn_registrar_bono;
        public System.Windows.Forms.Button btn_actualizar_bono;
        public System.Windows.Forms.Label lbl_control_bono;
    }
}