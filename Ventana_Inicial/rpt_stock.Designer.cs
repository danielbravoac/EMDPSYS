namespace Ventana_Inicial
{
    partial class rpt_stock
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.lbl_titulo_producto = new System.Windows.Forms.Label();
            this.btn_generar = new System.Windows.Forms.Button();
            this.cbo_buscar_venta = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.EMDP_DBDataSet1 = new Ventana_Inicial.EMDP_DBDataSet1();
            this.sp_rpt_productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_rpt_productosTableAdapter = new Ventana_Inicial.EMDP_DBDataSet1TableAdapters.sp_rpt_productosTableAdapter();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.EMDP_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_rpt_productosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo_producto
            // 
            this.lbl_titulo_producto.AutoSize = true;
            this.lbl_titulo_producto.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_producto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.lbl_titulo_producto.Location = new System.Drawing.Point(403, 19);
            this.lbl_titulo_producto.Name = "lbl_titulo_producto";
            this.lbl_titulo_producto.Size = new System.Drawing.Size(240, 32);
            this.lbl_titulo_producto.TabIndex = 95;
            this.lbl_titulo_producto.Text = "Reporte de Stock";
            // 
            // btn_generar
            // 
            this.btn_generar.Location = new System.Drawing.Point(823, 71);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(75, 23);
            this.btn_generar.TabIndex = 94;
            this.btn_generar.Text = "Generar";
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // cbo_buscar_venta
            // 
            this.cbo_buscar_venta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_buscar_venta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_buscar_venta.FormattingEnabled = true;
            this.cbo_buscar_venta.Items.AddRange(new object[] {
            "Todos los Productos",
            "Código de Producto"});
            this.cbo_buscar_venta.Location = new System.Drawing.Point(48, 71);
            this.cbo_buscar_venta.Name = "cbo_buscar_venta";
            this.cbo_buscar_venta.Size = new System.Drawing.Size(158, 25);
            this.cbo_buscar_venta.TabIndex = 93;
            this.cbo_buscar_venta.SelectedIndexChanged += new System.EventHandler(this.cbo_buscar_venta_SelectedIndexChanged);
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.sp_rpt_productosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Ventana_Inicial.rpt_stock.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(48, 119);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(878, 418);
            this.reportViewer1.TabIndex = 96;
            // 
            // EMDP_DBDataSet1
            // 
            this.EMDP_DBDataSet1.DataSetName = "EMDP_DBDataSet1";
            this.EMDP_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_rpt_productosBindingSource
            // 
            this.sp_rpt_productosBindingSource.DataMember = "sp_rpt_productos";
            this.sp_rpt_productosBindingSource.DataSource = this.EMDP_DBDataSet1;
            // 
            // sp_rpt_productosTableAdapter
            // 
            this.sp_rpt_productosTableAdapter.ClearBeforeFill = true;
            // 
            // txt_codigo
            // 
            this.txt_codigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_codigo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.Location = new System.Drawing.Point(229, 71);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(551, 23);
            this.txt_codigo.TabIndex = 97;
            // 
            // rpt_stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.lbl_titulo_producto);
            this.Controls.Add(this.btn_generar);
            this.Controls.Add(this.cbo_buscar_venta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "rpt_stock";
            this.Text = "rpt_stock";
            this.Load += new System.EventHandler(this.rpt_stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EMDP_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_rpt_productosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo_producto;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.ComboBox cbo_buscar_venta;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_rpt_productosBindingSource;
        private EMDP_DBDataSet1 EMDP_DBDataSet1;
        private EMDP_DBDataSet1TableAdapters.sp_rpt_productosTableAdapter sp_rpt_productosTableAdapter;
        private System.Windows.Forms.TextBox txt_codigo;
    }
}