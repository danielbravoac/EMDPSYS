namespace Ventana_Inicial
{
    partial class frm_ocasion
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
            this.btn_actualizar_ocasion = new System.Windows.Forms.Button();
            this.btn_guardar_ocasion = new System.Windows.Forms.Button();
            this.btn_nueva_ocasion = new System.Windows.Forms.Button();
            this.dgv_ocasion = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_id_ocasion = new System.Windows.Forms.Label();
            this.txt_ocasion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ocasion)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_actualizar_ocasion
            // 
            this.btn_actualizar_ocasion.Location = new System.Drawing.Point(519, 85);
            this.btn_actualizar_ocasion.Name = "btn_actualizar_ocasion";
            this.btn_actualizar_ocasion.Size = new System.Drawing.Size(75, 23);
            this.btn_actualizar_ocasion.TabIndex = 12;
            this.btn_actualizar_ocasion.Text = "Actualizar";
            this.btn_actualizar_ocasion.UseVisualStyleBackColor = true;
            this.btn_actualizar_ocasion.Click += new System.EventHandler(this.btn_actualizar_ocasion_Click);
            // 
            // btn_guardar_ocasion
            // 
            this.btn_guardar_ocasion.Location = new System.Drawing.Point(519, 56);
            this.btn_guardar_ocasion.Name = "btn_guardar_ocasion";
            this.btn_guardar_ocasion.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar_ocasion.TabIndex = 13;
            this.btn_guardar_ocasion.Text = "Guardar";
            this.btn_guardar_ocasion.UseVisualStyleBackColor = true;
            this.btn_guardar_ocasion.Click += new System.EventHandler(this.btn_guardar_ocasion_Click);
            // 
            // btn_nueva_ocasion
            // 
            this.btn_nueva_ocasion.Location = new System.Drawing.Point(519, 27);
            this.btn_nueva_ocasion.Name = "btn_nueva_ocasion";
            this.btn_nueva_ocasion.Size = new System.Drawing.Size(75, 23);
            this.btn_nueva_ocasion.TabIndex = 14;
            this.btn_nueva_ocasion.Text = "Nuevo";
            this.btn_nueva_ocasion.UseVisualStyleBackColor = true;
            this.btn_nueva_ocasion.Click += new System.EventHandler(this.btn_nueva_ocasion_Click);
            // 
            // dgv_ocasion
            // 
            this.dgv_ocasion.AllowUserToAddRows = false;
            this.dgv_ocasion.AllowUserToDeleteRows = false;
            this.dgv_ocasion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ocasion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ocasion.Location = new System.Drawing.Point(12, 94);
            this.dgv_ocasion.Name = "dgv_ocasion";
            this.dgv_ocasion.ReadOnly = true;
            this.dgv_ocasion.RowHeadersVisible = false;
            this.dgv_ocasion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ocasion.Size = new System.Drawing.Size(487, 175);
            this.dgv_ocasion.TabIndex = 11;
            this.dgv_ocasion.CurrentCellChanged += new System.EventHandler(this.dgv_ocasion_CurrentCellChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre de Ocasion";
            // 
            // lbl_id_ocasion
            // 
            this.lbl_id_ocasion.AutoSize = true;
            this.lbl_id_ocasion.Location = new System.Drawing.Point(115, 16);
            this.lbl_id_ocasion.Name = "lbl_id_ocasion";
            this.lbl_id_ocasion.Size = new System.Drawing.Size(63, 13);
            this.lbl_id_ocasion.TabIndex = 15;
            this.lbl_id_ocasion.Text = "ID_Ocasion";
            this.lbl_id_ocasion.Visible = false;
            // 
            // txt_ocasion
            // 
            this.txt_ocasion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_ocasion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ocasion.Location = new System.Drawing.Point(199, 42);
            this.txt_ocasion.Name = "txt_ocasion";
            this.txt_ocasion.Size = new System.Drawing.Size(280, 23);
            this.txt_ocasion.TabIndex = 16;
            // 
            // frm_ocasion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(659, 281);
            this.Controls.Add(this.txt_ocasion);
            this.Controls.Add(this.lbl_id_ocasion);
            this.Controls.Add(this.btn_actualizar_ocasion);
            this.Controls.Add(this.btn_guardar_ocasion);
            this.Controls.Add(this.btn_nueva_ocasion);
            this.Controls.Add(this.dgv_ocasion);
            this.Controls.Add(this.label1);
            this.Name = "frm_ocasion";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ocasion";
            this.Load += new System.EventHandler(this.frm_ocasion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ocasion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_actualizar_ocasion;
        private System.Windows.Forms.Button btn_guardar_ocasion;
        private System.Windows.Forms.Button btn_nueva_ocasion;
        private System.Windows.Forms.DataGridView dgv_ocasion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_id_ocasion;
        private System.Windows.Forms.TextBox txt_ocasion;
    }
}