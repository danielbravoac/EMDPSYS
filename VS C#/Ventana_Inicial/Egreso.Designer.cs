namespace Ventana_Inicial
{
    partial class frm_egreso
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
            this.nud_cantidad_egreso = new System.Windows.Forms.NumericUpDown();
            this.lbl_cantidad_egreso = new System.Windows.Forms.Label();
            this.lbl_motivo_egreso = new System.Windows.Forms.Label();
            this.txt_motivo_egreso = new System.Windows.Forms.TextBox();
            this.lbl_control_egreso = new System.Windows.Forms.Label();
            this.btn_registrar_egreso = new System.Windows.Forms.Button();
            this.dtp_egreso = new System.Windows.Forms.DateTimePicker();
            this.lbl_fecha_egreso = new System.Windows.Forms.Label();
            this.pic_volver = new System.Windows.Forms.PictureBox();
            this.lbl_id_egreso = new System.Windows.Forms.Label();
            this.btn_actualizar_egreso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cantidad_egreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_volver)).BeginInit();
            this.SuspendLayout();
            // 
            // nud_cantidad_egreso
            // 
            this.nud_cantidad_egreso.DecimalPlaces = 2;
            this.nud_cantidad_egreso.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_cantidad_egreso.Location = new System.Drawing.Point(342, 278);
            this.nud_cantidad_egreso.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nud_cantidad_egreso.Name = "nud_cantidad_egreso";
            this.nud_cantidad_egreso.Size = new System.Drawing.Size(120, 23);
            this.nud_cantidad_egreso.TabIndex = 2;
            this.nud_cantidad_egreso.ValueChanged += new System.EventHandler(this.nud_cantidad_egreso_ValueChanged);
            // 
            // lbl_cantidad_egreso
            // 
            this.lbl_cantidad_egreso.AutoSize = true;
            this.lbl_cantidad_egreso.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad_egreso.Location = new System.Drawing.Point(159, 278);
            this.lbl_cantidad_egreso.Name = "lbl_cantidad_egreso";
            this.lbl_cantidad_egreso.Size = new System.Drawing.Size(154, 18);
            this.lbl_cantidad_egreso.TabIndex = 85;
            this.lbl_cantidad_egreso.Text = "Cantidad de Egreso";
            // 
            // lbl_motivo_egreso
            // 
            this.lbl_motivo_egreso.AutoSize = true;
            this.lbl_motivo_egreso.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_motivo_egreso.Location = new System.Drawing.Point(178, 232);
            this.lbl_motivo_egreso.Name = "lbl_motivo_egreso";
            this.lbl_motivo_egreso.Size = new System.Drawing.Size(135, 18);
            this.lbl_motivo_egreso.TabIndex = 86;
            this.lbl_motivo_egreso.Text = "Motivo de Egreso";
            // 
            // txt_motivo_egreso
            // 
            this.txt_motivo_egreso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_motivo_egreso.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_motivo_egreso.Location = new System.Drawing.Point(342, 231);
            this.txt_motivo_egreso.Name = "txt_motivo_egreso";
            this.txt_motivo_egreso.Size = new System.Drawing.Size(587, 23);
            this.txt_motivo_egreso.TabIndex = 1;
            // 
            // lbl_control_egreso
            // 
            this.lbl_control_egreso.AutoSize = true;
            this.lbl_control_egreso.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_control_egreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.lbl_control_egreso.Location = new System.Drawing.Point(443, 35);
            this.lbl_control_egreso.Name = "lbl_control_egreso";
            this.lbl_control_egreso.Size = new System.Drawing.Size(222, 32);
            this.lbl_control_egreso.TabIndex = 79;
            this.lbl_control_egreso.Text = "[Control] Egreso";
            // 
            // btn_registrar_egreso
            // 
            this.btn_registrar_egreso.Enabled = false;
            this.btn_registrar_egreso.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_registrar_egreso.FlatAppearance.BorderSize = 2;
            this.btn_registrar_egreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar_egreso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar_egreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_registrar_egreso.Location = new System.Drawing.Point(756, 437);
            this.btn_registrar_egreso.Name = "btn_registrar_egreso";
            this.btn_registrar_egreso.Size = new System.Drawing.Size(200, 45);
            this.btn_registrar_egreso.TabIndex = 4;
            this.btn_registrar_egreso.Text = "Registrar Egreso";
            this.btn_registrar_egreso.UseVisualStyleBackColor = true;
            this.btn_registrar_egreso.Click += new System.EventHandler(this.btn_registrar_egreso_Click);
            // 
            // dtp_egreso
            // 
            this.dtp_egreso.CalendarFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_egreso.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_egreso.Location = new System.Drawing.Point(342, 327);
            this.dtp_egreso.Name = "dtp_egreso";
            this.dtp_egreso.Size = new System.Drawing.Size(338, 26);
            this.dtp_egreso.TabIndex = 3;
            // 
            // lbl_fecha_egreso
            // 
            this.lbl_fecha_egreso.AutoSize = true;
            this.lbl_fecha_egreso.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_egreso.Location = new System.Drawing.Point(182, 333);
            this.lbl_fecha_egreso.Name = "lbl_fecha_egreso";
            this.lbl_fecha_egreso.Size = new System.Drawing.Size(131, 18);
            this.lbl_fecha_egreso.TabIndex = 85;
            this.lbl_fecha_egreso.Text = "Fecha de Egreso";
            // 
            // pic_volver
            // 
            this.pic_volver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_volver.Image = global::Ventana_Inicial.Properties.Resources.Atras;
            this.pic_volver.Location = new System.Drawing.Point(93, 35);
            this.pic_volver.Name = "pic_volver";
            this.pic_volver.Size = new System.Drawing.Size(20, 32);
            this.pic_volver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_volver.TabIndex = 80;
            this.pic_volver.TabStop = false;
            this.pic_volver.Click += new System.EventHandler(this.pic_volver_Click);
            // 
            // lbl_id_egreso
            // 
            this.lbl_id_egreso.AutoSize = true;
            this.lbl_id_egreso.Location = new System.Drawing.Point(380, 168);
            this.lbl_id_egreso.Name = "lbl_id_egreso";
            this.lbl_id_egreso.Size = new System.Drawing.Size(57, 13);
            this.lbl_id_egreso.TabIndex = 103;
            this.lbl_id_egreso.Text = "ID_Egreso";
            this.lbl_id_egreso.Visible = false;
            // 
            // btn_actualizar_egreso
            // 
            this.btn_actualizar_egreso.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_actualizar_egreso.FlatAppearance.BorderSize = 2;
            this.btn_actualizar_egreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizar_egreso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar_egreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_actualizar_egreso.Location = new System.Drawing.Point(756, 437);
            this.btn_actualizar_egreso.Name = "btn_actualizar_egreso";
            this.btn_actualizar_egreso.Size = new System.Drawing.Size(200, 45);
            this.btn_actualizar_egreso.TabIndex = 4;
            this.btn_actualizar_egreso.Text = "Actualizar Egreso";
            this.btn_actualizar_egreso.UseVisualStyleBackColor = true;
            this.btn_actualizar_egreso.Click += new System.EventHandler(this.btn_actualizar_egreso_Click);
            // 
            // frm_egreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.lbl_id_egreso);
            this.Controls.Add(this.dtp_egreso);
            this.Controls.Add(this.nud_cantidad_egreso);
            this.Controls.Add(this.lbl_fecha_egreso);
            this.Controls.Add(this.lbl_cantidad_egreso);
            this.Controls.Add(this.lbl_motivo_egreso);
            this.Controls.Add(this.txt_motivo_egreso);
            this.Controls.Add(this.pic_volver);
            this.Controls.Add(this.lbl_control_egreso);
            this.Controls.Add(this.btn_actualizar_egreso);
            this.Controls.Add(this.btn_registrar_egreso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_egreso";
            this.Text = "Egresos";
            this.Load += new System.EventHandler(this.Egresos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_cantidad_egreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_volver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cantidad_egreso;
        private System.Windows.Forms.Label lbl_motivo_egreso;
        private System.Windows.Forms.PictureBox pic_volver;
        private System.Windows.Forms.Label lbl_fecha_egreso;
        public System.Windows.Forms.Label lbl_id_egreso;
        public System.Windows.Forms.Button btn_actualizar_egreso;
        public System.Windows.Forms.NumericUpDown nud_cantidad_egreso;
        public System.Windows.Forms.TextBox txt_motivo_egreso;
        public System.Windows.Forms.Label lbl_control_egreso;
        public System.Windows.Forms.Button btn_registrar_egreso;
        public System.Windows.Forms.DateTimePicker dtp_egreso;

    }
}