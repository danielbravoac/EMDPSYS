namespace Ventana_Inicial
{
    partial class frm_inicial
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
            this.label1 = new System.Windows.Forms.Label();
            this.nud_inicial = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_fecha_actual = new System.Windows.Forms.Label();
            this.btn_registrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_inicial)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cuota Inicial";
            // 
            // nud_inicial
            // 
            this.nud_inicial.DecimalPlaces = 2;
            this.nud_inicial.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_inicial.Location = new System.Drawing.Point(196, 63);
            this.nud_inicial.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.nud_inicial.Name = "nud_inicial";
            this.nud_inicial.Size = new System.Drawing.Size(120, 23);
            this.nud_inicial.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha Actual";
            // 
            // lbl_fecha_actual
            // 
            this.lbl_fecha_actual.AutoSize = true;
            this.lbl_fecha_actual.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_actual.Location = new System.Drawing.Point(193, 29);
            this.lbl_fecha_actual.Name = "lbl_fecha_actual";
            this.lbl_fecha_actual.Size = new System.Drawing.Size(45, 17);
            this.lbl_fecha_actual.TabIndex = 0;
            this.lbl_fecha_actual.Text = "fecha";
            // 
            // btn_registrar
            // 
            this.btn_registrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar.Location = new System.Drawing.Point(348, 75);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(96, 32);
            this.btn_registrar.TabIndex = 2;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // frm_inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(470, 119);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.nud_inicial);
            this.Controls.Add(this.lbl_fecha_actual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_inicial";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicial del Día";
            this.Load += new System.EventHandler(this.frm_inicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_inicial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud_inicial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_fecha_actual;
        private System.Windows.Forms.Button btn_registrar;
    }
}