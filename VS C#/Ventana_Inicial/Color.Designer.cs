namespace Ventana_Inicial
{
    partial class frm_color
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id_col = new System.Windows.Forms.TextBox();
            this.dgv_color = new System.Windows.Forms.DataGridView();
            this.btn_actualizar_color = new System.Windows.Forms.Button();
            this.btn_guardar_color = new System.Windows.Forms.Button();
            this.btn_nuevo_color = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_color = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_color)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "ID_Colores";
            this.label2.Visible = false;
            // 
            // txt_id_col
            // 
            this.txt_id_col.Enabled = false;
            this.txt_id_col.Location = new System.Drawing.Point(214, 12);
            this.txt_id_col.Name = "txt_id_col";
            this.txt_id_col.Size = new System.Drawing.Size(154, 20);
            this.txt_id_col.TabIndex = 22;
            this.txt_id_col.Visible = false;
            // 
            // dgv_color
            // 
            this.dgv_color.AllowUserToAddRows = false;
            this.dgv_color.AllowUserToDeleteRows = false;
            this.dgv_color.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_color.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_color.Location = new System.Drawing.Point(12, 94);
            this.dgv_color.Name = "dgv_color";
            this.dgv_color.ReadOnly = true;
            this.dgv_color.RowHeadersVisible = false;
            this.dgv_color.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_color.Size = new System.Drawing.Size(487, 175);
            this.dgv_color.TabIndex = 21;
            this.dgv_color.CurrentCellChanged += new System.EventHandler(this.dgv_color_CurrentCellChanged);
            // 
            // btn_actualizar_color
            // 
            this.btn_actualizar_color.Location = new System.Drawing.Point(519, 85);
            this.btn_actualizar_color.Name = "btn_actualizar_color";
            this.btn_actualizar_color.Size = new System.Drawing.Size(75, 26);
            this.btn_actualizar_color.TabIndex = 18;
            this.btn_actualizar_color.Text = "Actualizar";
            this.btn_actualizar_color.UseVisualStyleBackColor = true;
            this.btn_actualizar_color.Click += new System.EventHandler(this.btn_actualizar_color_Click);
            // 
            // btn_guardar_color
            // 
            this.btn_guardar_color.Location = new System.Drawing.Point(519, 56);
            this.btn_guardar_color.Name = "btn_guardar_color";
            this.btn_guardar_color.Size = new System.Drawing.Size(75, 26);
            this.btn_guardar_color.TabIndex = 19;
            this.btn_guardar_color.Text = "Guardar";
            this.btn_guardar_color.UseVisualStyleBackColor = true;
            this.btn_guardar_color.Click += new System.EventHandler(this.btn_guardar_color_Click);
            // 
            // btn_nuevo_color
            // 
            this.btn_nuevo_color.Location = new System.Drawing.Point(519, 27);
            this.btn_nuevo_color.Name = "btn_nuevo_color";
            this.btn_nuevo_color.Size = new System.Drawing.Size(75, 26);
            this.btn_nuevo_color.TabIndex = 20;
            this.btn_nuevo_color.Text = "Nuevo";
            this.btn_nuevo_color.UseVisualStyleBackColor = true;
            this.btn_nuevo_color.Click += new System.EventHandler(this.btn_nuevo_color_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nombre del Color";
            // 
            // txt_color
            // 
            this.txt_color.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_color.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_color.Location = new System.Drawing.Point(214, 42);
            this.txt_color.Name = "txt_color";
            this.txt_color.Size = new System.Drawing.Size(280, 23);
            this.txt_color.TabIndex = 16;
            // 
            // frm_color
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(659, 281);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_id_col);
            this.Controls.Add(this.dgv_color);
            this.Controls.Add(this.btn_actualizar_color);
            this.Controls.Add(this.btn_guardar_color);
            this.Controls.Add(this.btn_nuevo_color);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_color);
            this.Name = "frm_color";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color";
            this.Load += new System.EventHandler(this.Color_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_color)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id_col;
        private System.Windows.Forms.DataGridView dgv_color;
        private System.Windows.Forms.Button btn_actualizar_color;
        private System.Windows.Forms.Button btn_guardar_color;
        private System.Windows.Forms.Button btn_nuevo_color;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_color;
    }
}