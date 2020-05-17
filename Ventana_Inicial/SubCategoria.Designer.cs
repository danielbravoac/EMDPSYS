namespace Ventana_Inicial
{
    partial class frm_subcategoria
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
            this.dgv_subcategoria = new System.Windows.Forms.DataGridView();
            this.btn_actualizar_subcat = new System.Windows.Forms.Button();
            this.btn_guardar_subcat = new System.Windows.Forms.Button();
            this.btn_nueva_subcat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_subcategoria = new System.Windows.Forms.TextBox();
            this.lbl_id_subc = new System.Windows.Forms.Label();
            this.cbo_categoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_subcategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_subcategoria
            // 
            this.dgv_subcategoria.AllowUserToAddRows = false;
            this.dgv_subcategoria.AllowUserToDeleteRows = false;
            this.dgv_subcategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_subcategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_subcategoria.Location = new System.Drawing.Point(12, 153);
            this.dgv_subcategoria.Name = "dgv_subcategoria";
            this.dgv_subcategoria.ReadOnly = true;
            this.dgv_subcategoria.RowHeadersVisible = false;
            this.dgv_subcategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_subcategoria.Size = new System.Drawing.Size(487, 175);
            this.dgv_subcategoria.TabIndex = 15;
            this.dgv_subcategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_subcategoria_CellContentClick);
            this.dgv_subcategoria.CurrentCellChanged += new System.EventHandler(this.dgv_subcategoria_CurrentCellChanged);
            // 
            // btn_actualizar_subcat
            // 
            this.btn_actualizar_subcat.Location = new System.Drawing.Point(519, 85);
            this.btn_actualizar_subcat.Name = "btn_actualizar_subcat";
            this.btn_actualizar_subcat.Size = new System.Drawing.Size(75, 26);
            this.btn_actualizar_subcat.TabIndex = 12;
            this.btn_actualizar_subcat.Text = "Actualizar";
            this.btn_actualizar_subcat.UseVisualStyleBackColor = true;
            this.btn_actualizar_subcat.Click += new System.EventHandler(this.btn_actualizar_subcat_Click);
            // 
            // btn_guardar_subcat
            // 
            this.btn_guardar_subcat.Location = new System.Drawing.Point(519, 56);
            this.btn_guardar_subcat.Name = "btn_guardar_subcat";
            this.btn_guardar_subcat.Size = new System.Drawing.Size(75, 26);
            this.btn_guardar_subcat.TabIndex = 13;
            this.btn_guardar_subcat.Text = "Guardar";
            this.btn_guardar_subcat.UseVisualStyleBackColor = true;
            this.btn_guardar_subcat.Click += new System.EventHandler(this.btn_guardar_subcat_Click);
            // 
            // btn_nueva_subcat
            // 
            this.btn_nueva_subcat.Location = new System.Drawing.Point(519, 27);
            this.btn_nueva_subcat.Name = "btn_nueva_subcat";
            this.btn_nueva_subcat.Size = new System.Drawing.Size(75, 26);
            this.btn_nueva_subcat.TabIndex = 14;
            this.btn_nueva_subcat.Text = "Nuevo";
            this.btn_nueva_subcat.UseVisualStyleBackColor = true;
            this.btn_nueva_subcat.Click += new System.EventHandler(this.btn_nueva_subcat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre de Subcategoria";
            // 
            // txt_subcategoria
            // 
            this.txt_subcategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_subcategoria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_subcategoria.Location = new System.Drawing.Point(214, 42);
            this.txt_subcategoria.Name = "txt_subcategoria";
            this.txt_subcategoria.Size = new System.Drawing.Size(280, 23);
            this.txt_subcategoria.TabIndex = 10;
            // 
            // lbl_id_subc
            // 
            this.lbl_id_subc.AutoSize = true;
            this.lbl_id_subc.Location = new System.Drawing.Point(115, 16);
            this.lbl_id_subc.Name = "lbl_id_subc";
            this.lbl_id_subc.Size = new System.Drawing.Size(87, 13);
            this.lbl_id_subc.TabIndex = 16;
            this.lbl_id_subc.Text = "ID_Subcategoria";
            this.lbl_id_subc.Visible = false;
            // 
            // cbo_categoria
            // 
            this.cbo_categoria.FormattingEnabled = true;
            this.cbo_categoria.Location = new System.Drawing.Point(214, 89);
            this.cbo_categoria.Name = "cbo_categoria";
            this.cbo_categoria.Size = new System.Drawing.Size(241, 21);
            this.cbo_categoria.TabIndex = 112;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Enlace de Categoria";
            // 
            // frm_subcategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(659, 351);
            this.Controls.Add(this.cbo_categoria);
            this.Controls.Add(this.lbl_id_subc);
            this.Controls.Add(this.dgv_subcategoria);
            this.Controls.Add(this.btn_actualizar_subcat);
            this.Controls.Add(this.btn_guardar_subcat);
            this.Controls.Add(this.btn_nueva_subcat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_subcategoria);
            this.Name = "frm_subcategoria";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subcategoria";
            this.Load += new System.EventHandler(this.frm_subcategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_subcategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_subcategoria;
        private System.Windows.Forms.Button btn_actualizar_subcat;
        private System.Windows.Forms.Button btn_guardar_subcat;
        private System.Windows.Forms.Button btn_nueva_subcat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_subcategoria;
        private System.Windows.Forms.Label lbl_id_subc;
        private System.Windows.Forms.ComboBox cbo_categoria;
        private System.Windows.Forms.Label label2;
    }
}