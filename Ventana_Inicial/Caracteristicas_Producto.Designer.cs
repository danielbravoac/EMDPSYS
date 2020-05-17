namespace Ventana_Inicial
{
    partial class frm_caracteristicas_producto
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
            this.btn_color = new System.Windows.Forms.Button();
            this.btn_ocasion = new System.Windows.Forms.Button();
            this.btn_familia = new System.Windows.Forms.Button();
            this.btn_subcategoria = new System.Windows.Forms.Button();
            this.btn_categoria = new System.Windows.Forms.Button();
            this.pic_volver = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_volver)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_color
            // 
            this.btn_color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_color.FlatAppearance.BorderSize = 0;
            this.btn_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_color.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_color.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_color.Image = global::Ventana_Inicial.Properties.Resources.Color;
            this.btn_color.Location = new System.Drawing.Point(792, 256);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(155, 140);
            this.btn_color.TabIndex = 0;
            this.btn_color.Text = "Color";
            this.btn_color.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_color.UseVisualStyleBackColor = true;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // btn_ocasion
            // 
            this.btn_ocasion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ocasion.FlatAppearance.BorderSize = 0;
            this.btn_ocasion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ocasion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ocasion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_ocasion.Image = global::Ventana_Inicial.Properties.Resources.Ocasion;
            this.btn_ocasion.Location = new System.Drawing.Point(627, 256);
            this.btn_ocasion.Name = "btn_ocasion";
            this.btn_ocasion.Size = new System.Drawing.Size(155, 140);
            this.btn_ocasion.TabIndex = 0;
            this.btn_ocasion.Text = "Ocasion";
            this.btn_ocasion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ocasion.UseVisualStyleBackColor = true;
            this.btn_ocasion.Click += new System.EventHandler(this.btn_ocasion_Click);
            // 
            // btn_familia
            // 
            this.btn_familia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_familia.FlatAppearance.BorderSize = 0;
            this.btn_familia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_familia.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_familia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_familia.Image = global::Ventana_Inicial.Properties.Resources.Familia;
            this.btn_familia.Location = new System.Drawing.Point(462, 256);
            this.btn_familia.Name = "btn_familia";
            this.btn_familia.Size = new System.Drawing.Size(155, 140);
            this.btn_familia.TabIndex = 0;
            this.btn_familia.Text = "Familia";
            this.btn_familia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_familia.UseVisualStyleBackColor = true;
            this.btn_familia.Click += new System.EventHandler(this.btn_familia_Click);
            // 
            // btn_subcategoria
            // 
            this.btn_subcategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_subcategoria.FlatAppearance.BorderSize = 0;
            this.btn_subcategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_subcategoria.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_subcategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_subcategoria.Image = global::Ventana_Inicial.Properties.Resources.Subcategoria;
            this.btn_subcategoria.Location = new System.Drawing.Point(297, 256);
            this.btn_subcategoria.Name = "btn_subcategoria";
            this.btn_subcategoria.Size = new System.Drawing.Size(155, 140);
            this.btn_subcategoria.TabIndex = 0;
            this.btn_subcategoria.Text = "Subcategoria";
            this.btn_subcategoria.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_subcategoria.UseVisualStyleBackColor = true;
            this.btn_subcategoria.Click += new System.EventHandler(this.btn_subcategoria_Click);
            // 
            // btn_categoria
            // 
            this.btn_categoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_categoria.FlatAppearance.BorderSize = 0;
            this.btn_categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_categoria.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_categoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.btn_categoria.Image = global::Ventana_Inicial.Properties.Resources.Categoria;
            this.btn_categoria.Location = new System.Drawing.Point(132, 256);
            this.btn_categoria.Name = "btn_categoria";
            this.btn_categoria.Size = new System.Drawing.Size(155, 140);
            this.btn_categoria.TabIndex = 0;
            this.btn_categoria.Text = "Categoria";
            this.btn_categoria.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_categoria.UseVisualStyleBackColor = true;
            this.btn_categoria.Click += new System.EventHandler(this.btn_categoria_Click);
            // 
            // pic_volver
            // 
            this.pic_volver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_volver.Image = global::Ventana_Inicial.Properties.Resources.Atras;
            this.pic_volver.Location = new System.Drawing.Point(103, 34);
            this.pic_volver.Name = "pic_volver";
            this.pic_volver.Size = new System.Drawing.Size(20, 32);
            this.pic_volver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_volver.TabIndex = 81;
            this.pic_volver.TabStop = false;
            this.pic_volver.Click += new System.EventHandler(this.pic_volver_Click);
            // 
            // frm_caracteristicas_producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.pic_volver);
            this.Controls.Add(this.btn_color);
            this.Controls.Add(this.btn_ocasion);
            this.Controls.Add(this.btn_familia);
            this.Controls.Add(this.btn_subcategoria);
            this.Controls.Add(this.btn_categoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_caracteristicas_producto";
            this.Text = "Caracteristicas_Producto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_caracteristicas_producto_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_caracteristicas_producto_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pic_volver)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_categoria;
        private System.Windows.Forms.Button btn_subcategoria;
        private System.Windows.Forms.Button btn_familia;
        private System.Windows.Forms.Button btn_ocasion;
        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.PictureBox pic_volver;
    }
}