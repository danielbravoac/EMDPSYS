namespace Ventana_Inicial
{
    partial class frm_familia
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
            this.txt_familia = new System.Windows.Forms.TextBox();
            this.dgv_familia = new System.Windows.Forms.DataGridView();
            this.btn_actualizar_fam = new System.Windows.Forms.Button();
            this.btn_guardar_fam = new System.Windows.Forms.Button();
            this.btn_nueva_fam = new System.Windows.Forms.Button();
            this.lbl_id_fam = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_familia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre de Familia";
            // 
            // txt_familia
            // 
            this.txt_familia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_familia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_familia.Location = new System.Drawing.Point(199, 42);
            this.txt_familia.Name = "txt_familia";
            this.txt_familia.Size = new System.Drawing.Size(280, 23);
            this.txt_familia.TabIndex = 4;
            // 
            // dgv_familia
            // 
            this.dgv_familia.AllowUserToAddRows = false;
            this.dgv_familia.AllowUserToDeleteRows = false;
            this.dgv_familia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_familia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_familia.Location = new System.Drawing.Point(12, 94);
            this.dgv_familia.Name = "dgv_familia";
            this.dgv_familia.ReadOnly = true;
            this.dgv_familia.RowHeadersVisible = false;
            this.dgv_familia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_familia.Size = new System.Drawing.Size(487, 175);
            this.dgv_familia.TabIndex = 6;
            this.dgv_familia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_familia_CellContentClick);
            this.dgv_familia.CurrentCellChanged += new System.EventHandler(this.dgv_familia_CurrentCellChanged);
            // 
            // btn_actualizar_fam
            // 
            this.btn_actualizar_fam.Location = new System.Drawing.Point(519, 85);
            this.btn_actualizar_fam.Name = "btn_actualizar_fam";
            this.btn_actualizar_fam.Size = new System.Drawing.Size(75, 23);
            this.btn_actualizar_fam.TabIndex = 7;
            this.btn_actualizar_fam.Text = "Actualizar";
            this.btn_actualizar_fam.UseVisualStyleBackColor = true;
            this.btn_actualizar_fam.Click += new System.EventHandler(this.btn_actualizar_fam_Click);
            // 
            // btn_guardar_fam
            // 
            this.btn_guardar_fam.Location = new System.Drawing.Point(519, 56);
            this.btn_guardar_fam.Name = "btn_guardar_fam";
            this.btn_guardar_fam.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar_fam.TabIndex = 8;
            this.btn_guardar_fam.Text = "Guardar";
            this.btn_guardar_fam.UseVisualStyleBackColor = true;
            this.btn_guardar_fam.Click += new System.EventHandler(this.btn_guardar_fam_Click);
            // 
            // btn_nueva_fam
            // 
            this.btn_nueva_fam.Location = new System.Drawing.Point(519, 27);
            this.btn_nueva_fam.Name = "btn_nueva_fam";
            this.btn_nueva_fam.Size = new System.Drawing.Size(75, 23);
            this.btn_nueva_fam.TabIndex = 9;
            this.btn_nueva_fam.Text = "Nuevo";
            this.btn_nueva_fam.UseVisualStyleBackColor = true;
            this.btn_nueva_fam.Click += new System.EventHandler(this.btn_nueva_fam_Click);
            // 
            // lbl_id_fam
            // 
            this.lbl_id_fam.AutoSize = true;
            this.lbl_id_fam.Location = new System.Drawing.Point(115, 16);
            this.lbl_id_fam.Name = "lbl_id_fam";
            this.lbl_id_fam.Size = new System.Drawing.Size(56, 13);
            this.lbl_id_fam.TabIndex = 10;
            this.lbl_id_fam.Text = "ID_Familia";
            this.lbl_id_fam.Visible = false;
            // 
            // frm_familia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(659, 281);
            this.Controls.Add(this.lbl_id_fam);
            this.Controls.Add(this.btn_actualizar_fam);
            this.Controls.Add(this.btn_guardar_fam);
            this.Controls.Add(this.btn_nueva_fam);
            this.Controls.Add(this.dgv_familia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_familia);
            this.Name = "frm_familia";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Familia";
            this.Load += new System.EventHandler(this.frm_familia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_familia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_familia;
        private System.Windows.Forms.DataGridView dgv_familia;
        private System.Windows.Forms.Button btn_actualizar_fam;
        private System.Windows.Forms.Button btn_guardar_fam;
        private System.Windows.Forms.Button btn_nueva_fam;
        private System.Windows.Forms.Label lbl_id_fam;
    }
}