namespace Ventana_Inicial
{
    partial class frm_categorias
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
            this.dgv_categorias = new System.Windows.Forms.DataGridView();
            this.txt_buscar_categoria = new System.Windows.Forms.TextBox();
            this.lbl_buscar_categoria = new System.Windows.Forms.Label();
            this.btn_nueva_categoria = new System.Windows.Forms.Button();
            this.btn_editar_categoria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_categorias)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_categorias
            // 
            this.dgv_categorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_categorias.Location = new System.Drawing.Point(12, 12);
            this.dgv_categorias.Name = "dgv_categorias";
            this.dgv_categorias.Size = new System.Drawing.Size(391, 576);
            this.dgv_categorias.TabIndex = 0;
            // 
            // txt_buscar_categoria
            // 
            this.txt_buscar_categoria.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar_categoria.Location = new System.Drawing.Point(455, 55);
            this.txt_buscar_categoria.Name = "txt_buscar_categoria";
            this.txt_buscar_categoria.Size = new System.Drawing.Size(494, 26);
            this.txt_buscar_categoria.TabIndex = 1;
            // 
            // lbl_buscar_categoria
            // 
            this.lbl_buscar_categoria.AutoSize = true;
            this.lbl_buscar_categoria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar_categoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.lbl_buscar_categoria.Location = new System.Drawing.Point(451, 23);
            this.lbl_buscar_categoria.Name = "lbl_buscar_categoria";
            this.lbl_buscar_categoria.Size = new System.Drawing.Size(60, 19);
            this.lbl_buscar_categoria.TabIndex = 2;
            this.lbl_buscar_categoria.Text = "Buscar";
            // 
            // btn_nueva_categoria
            // 
            this.btn_nueva_categoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_nueva_categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nueva_categoria.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nueva_categoria.ForeColor = System.Drawing.Color.White;
            this.btn_nueva_categoria.Location = new System.Drawing.Point(455, 120);
            this.btn_nueva_categoria.Name = "btn_nueva_categoria";
            this.btn_nueva_categoria.Size = new System.Drawing.Size(89, 32);
            this.btn_nueva_categoria.TabIndex = 3;
            this.btn_nueva_categoria.Text = "Nuevo";
            this.btn_nueva_categoria.UseVisualStyleBackColor = false;
            // 
            // btn_editar_categoria
            // 
            this.btn_editar_categoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_editar_categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar_categoria.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar_categoria.ForeColor = System.Drawing.Color.White;
            this.btn_editar_categoria.Location = new System.Drawing.Point(455, 179);
            this.btn_editar_categoria.Name = "btn_editar_categoria";
            this.btn_editar_categoria.Size = new System.Drawing.Size(89, 32);
            this.btn_editar_categoria.TabIndex = 3;
            this.btn_editar_categoria.Text = "Editar";
            this.btn_editar_categoria.UseVisualStyleBackColor = false;
            // 
            // frm_categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.ControlBox = false;
            this.Controls.Add(this.btn_editar_categoria);
            this.Controls.Add(this.btn_nueva_categoria);
            this.Controls.Add(this.lbl_buscar_categoria);
            this.Controls.Add(this.txt_buscar_categoria);
            this.Controls.Add(this.dgv_categorias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_categorias";
            this.Text = "Categorias";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_categorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_categorias;
        private System.Windows.Forms.TextBox txt_buscar_categoria;
        private System.Windows.Forms.Label lbl_buscar_categoria;
        private System.Windows.Forms.Button btn_nueva_categoria;
        private System.Windows.Forms.Button btn_editar_categoria;

    }
}