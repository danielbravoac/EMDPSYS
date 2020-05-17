namespace Ventana_Inicial
{
    partial class frm_categoria
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
            this.txt_categoria = new System.Windows.Forms.TextBox();
            this.btn_nueva_cat = new System.Windows.Forms.Button();
            this.btn_guardar_cat = new System.Windows.Forms.Button();
            this.btn_actualizar_cat = new System.Windows.Forms.Button();
            this.dgv_categorias = new System.Windows.Forms.DataGridView();
            this.lbl_id_cat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_categorias)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre de Categoria";
            // 
            // txt_categoria
            // 
            this.txt_categoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_categoria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_categoria.Location = new System.Drawing.Point(199, 42);
            this.txt_categoria.Name = "txt_categoria";
            this.txt_categoria.Size = new System.Drawing.Size(280, 23);
            this.txt_categoria.TabIndex = 2;
            // 
            // btn_nueva_cat
            // 
            this.btn_nueva_cat.Location = new System.Drawing.Point(519, 27);
            this.btn_nueva_cat.Name = "btn_nueva_cat";
            this.btn_nueva_cat.Size = new System.Drawing.Size(75, 23);
            this.btn_nueva_cat.TabIndex = 4;
            this.btn_nueva_cat.Text = "Nuevo";
            this.btn_nueva_cat.UseVisualStyleBackColor = true;
            this.btn_nueva_cat.Click += new System.EventHandler(this.btn_nueva_cat_Click);
            // 
            // btn_guardar_cat
            // 
            this.btn_guardar_cat.Location = new System.Drawing.Point(519, 56);
            this.btn_guardar_cat.Name = "btn_guardar_cat";
            this.btn_guardar_cat.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar_cat.TabIndex = 4;
            this.btn_guardar_cat.Text = "Guardar";
            this.btn_guardar_cat.UseVisualStyleBackColor = true;
            this.btn_guardar_cat.Click += new System.EventHandler(this.btn_guardar_cat_Click);
            // 
            // btn_actualizar_cat
            // 
            this.btn_actualizar_cat.Location = new System.Drawing.Point(519, 85);
            this.btn_actualizar_cat.Name = "btn_actualizar_cat";
            this.btn_actualizar_cat.Size = new System.Drawing.Size(75, 23);
            this.btn_actualizar_cat.TabIndex = 4;
            this.btn_actualizar_cat.Text = "Actualizar";
            this.btn_actualizar_cat.UseVisualStyleBackColor = true;
            this.btn_actualizar_cat.Click += new System.EventHandler(this.btn_actualizar_cat_Click);
            // 
            // dgv_categorias
            // 
            this.dgv_categorias.AllowUserToAddRows = false;
            this.dgv_categorias.AllowUserToDeleteRows = false;
            this.dgv_categorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_categorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_categorias.Location = new System.Drawing.Point(12, 94);
            this.dgv_categorias.Name = "dgv_categorias";
            this.dgv_categorias.ReadOnly = true;
            this.dgv_categorias.RowHeadersVisible = false;
            this.dgv_categorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_categorias.Size = new System.Drawing.Size(487, 175);
            this.dgv_categorias.TabIndex = 5;
            this.dgv_categorias.CurrentCellChanged += new System.EventHandler(this.dgv_categorias_CurrentCellChanged);
            // 
            // lbl_id_cat
            // 
            this.lbl_id_cat.AutoSize = true;
            this.lbl_id_cat.Location = new System.Drawing.Point(115, 16);
            this.lbl_id_cat.Name = "lbl_id_cat";
            this.lbl_id_cat.Size = new System.Drawing.Size(69, 13);
            this.lbl_id_cat.TabIndex = 7;
            this.lbl_id_cat.Text = "ID_Categoria";
            this.lbl_id_cat.Visible = false;
            // 
            // frm_categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(659, 281);
            this.Controls.Add(this.lbl_id_cat);
            this.Controls.Add(this.dgv_categorias);
            this.Controls.Add(this.btn_actualizar_cat);
            this.Controls.Add(this.btn_guardar_cat);
            this.Controls.Add(this.btn_nueva_cat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_categoria);
            this.Name = "frm_categoria";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categoria";
            this.Load += new System.EventHandler(this.Categoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_categorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_categoria;
        private System.Windows.Forms.Button btn_nueva_cat;
        private System.Windows.Forms.Button btn_guardar_cat;
        private System.Windows.Forms.Button btn_actualizar_cat;
        private System.Windows.Forms.DataGridView dgv_categorias;
        private System.Windows.Forms.Label lbl_id_cat;

    }
}