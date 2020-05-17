namespace Ventana_Inicial
{
    partial class frm_anular_venta
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
            this.btn_anular_venta = new System.Windows.Forms.Button();
            this.lbl_motivo_anulacion = new System.Windows.Forms.Label();
            this.txt_motivo_anulacion = new System.Windows.Forms.TextBox();
            this.lbl_id_venta = new System.Windows.Forms.Label();
            this.pic_volver = new System.Windows.Forms.PictureBox();
            this.dgv_detalle_venta = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_volver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle_venta)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo_cliente
            // 
            this.lbl_titulo_cliente.AutoSize = true;
            this.lbl_titulo_cliente.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_cliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.lbl_titulo_cliente.Location = new System.Drawing.Point(408, 35);
            this.lbl_titulo_cliente.Name = "lbl_titulo_cliente";
            this.lbl_titulo_cliente.Size = new System.Drawing.Size(186, 32);
            this.lbl_titulo_cliente.TabIndex = 76;
            this.lbl_titulo_cliente.Text = "Anular Venta";
            // 
            // btn_anular_venta
            // 
            this.btn_anular_venta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_anular_venta.FlatAppearance.BorderSize = 2;
            this.btn_anular_venta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_anular_venta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_anular_venta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_anular_venta.Location = new System.Drawing.Point(791, 499);
            this.btn_anular_venta.Name = "btn_anular_venta";
            this.btn_anular_venta.Size = new System.Drawing.Size(200, 45);
            this.btn_anular_venta.TabIndex = 2;
            this.btn_anular_venta.Text = "Anular Venta";
            this.btn_anular_venta.UseVisualStyleBackColor = true;
            this.btn_anular_venta.Click += new System.EventHandler(this.btn_anular_venta_Click);
            // 
            // lbl_motivo_anulacion
            // 
            this.lbl_motivo_anulacion.AutoSize = true;
            this.lbl_motivo_anulacion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_motivo_anulacion.Location = new System.Drawing.Point(49, 223);
            this.lbl_motivo_anulacion.Name = "lbl_motivo_anulacion";
            this.lbl_motivo_anulacion.Size = new System.Drawing.Size(138, 18);
            this.lbl_motivo_anulacion.TabIndex = 67;
            this.lbl_motivo_anulacion.Text = "Motivo Anulacion";
            // 
            // txt_motivo_anulacion
            // 
            this.txt_motivo_anulacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_motivo_anulacion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_motivo_anulacion.Location = new System.Drawing.Point(193, 222);
            this.txt_motivo_anulacion.Name = "txt_motivo_anulacion";
            this.txt_motivo_anulacion.Size = new System.Drawing.Size(798, 23);
            this.txt_motivo_anulacion.TabIndex = 1;
            // 
            // lbl_id_venta
            // 
            this.lbl_id_venta.AutoSize = true;
            this.lbl_id_venta.Location = new System.Drawing.Point(190, 191);
            this.lbl_id_venta.Name = "lbl_id_venta";
            this.lbl_id_venta.Size = new System.Drawing.Size(52, 13);
            this.lbl_id_venta.TabIndex = 78;
            this.lbl_id_venta.Text = "ID_Venta";
            this.lbl_id_venta.Visible = false;
            // 
            // pic_volver
            // 
            this.pic_volver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_volver.Image = global::Ventana_Inicial.Properties.Resources.Atras;
            this.pic_volver.Location = new System.Drawing.Point(104, 35);
            this.pic_volver.Name = "pic_volver";
            this.pic_volver.Size = new System.Drawing.Size(20, 32);
            this.pic_volver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_volver.TabIndex = 77;
            this.pic_volver.TabStop = false;
            this.pic_volver.Click += new System.EventHandler(this.pic_volver_Click);
            // 
            // dgv_detalle_venta
            // 
            this.dgv_detalle_venta.AllowUserToAddRows = false;
            this.dgv_detalle_venta.AllowUserToDeleteRows = false;
            this.dgv_detalle_venta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_detalle_venta.BackgroundColor = System.Drawing.Color.White;
            this.dgv_detalle_venta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detalle_venta.Enabled = false;
            this.dgv_detalle_venta.Location = new System.Drawing.Point(193, 297);
            this.dgv_detalle_venta.MultiSelect = false;
            this.dgv_detalle_venta.Name = "dgv_detalle_venta";
            this.dgv_detalle_venta.ReadOnly = true;
            this.dgv_detalle_venta.RowHeadersVisible = false;
            this.dgv_detalle_venta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_detalle_venta.Size = new System.Drawing.Size(798, 182);
            this.dgv_detalle_venta.TabIndex = 142;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 18);
            this.label1.TabIndex = 67;
            this.label1.Text = "Detalle de Venta";
            // 
            // frm_anular_venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.dgv_detalle_venta);
            this.Controls.Add(this.lbl_id_venta);
            this.Controls.Add(this.pic_volver);
            this.Controls.Add(this.lbl_titulo_cliente);
            this.Controls.Add(this.btn_anular_venta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_motivo_anulacion);
            this.Controls.Add(this.txt_motivo_anulacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_anular_venta";
            this.Text = "Anular_Venta";
            this.Load += new System.EventHandler(this.frm_anular_venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_volver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle_venta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_volver;
        private System.Windows.Forms.Label lbl_titulo_cliente;
        private System.Windows.Forms.Button btn_anular_venta;
        private System.Windows.Forms.Label lbl_motivo_anulacion;
        public System.Windows.Forms.TextBox txt_motivo_anulacion;
        public System.Windows.Forms.Label lbl_id_venta;
        public System.Windows.Forms.DataGridView dgv_detalle_venta;
        private System.Windows.Forms.Label label1;
    }
}