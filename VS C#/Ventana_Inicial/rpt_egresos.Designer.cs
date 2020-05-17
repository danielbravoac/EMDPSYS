namespace Ventana_Inicial
{
    partial class rpt_egresos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.sp_rpt_egresosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EMDP_DBDataSet2 = new Ventana_Inicial.EMDP_DBDataSet2();
            this.lbl_titulo_producto = new System.Windows.Forms.Label();
            this.btn_generar = new System.Windows.Forms.Button();
            this.lbl_ini = new System.Windows.Forms.Label();
            this.dtp_fin_venta = new System.Windows.Forms.DateTimePicker();
            this.dtp_ini_venta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_rpt_egresosTableAdapter = new Ventana_Inicial.EMDP_DBDataSet2TableAdapters.sp_rpt_egresosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_rpt_egresosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMDP_DBDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_rpt_egresosBindingSource
            // 
            this.sp_rpt_egresosBindingSource.DataMember = "sp_rpt_egresos";
            this.sp_rpt_egresosBindingSource.DataSource = this.EMDP_DBDataSet2;
            // 
            // EMDP_DBDataSet2
            // 
            this.EMDP_DBDataSet2.DataSetName = "EMDP_DBDataSet2";
            this.EMDP_DBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_titulo_producto
            // 
            this.lbl_titulo_producto.AutoSize = true;
            this.lbl_titulo_producto.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_producto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.lbl_titulo_producto.Location = new System.Drawing.Point(393, 9);
            this.lbl_titulo_producto.Name = "lbl_titulo_producto";
            this.lbl_titulo_producto.Size = new System.Drawing.Size(267, 32);
            this.lbl_titulo_producto.TabIndex = 98;
            this.lbl_titulo_producto.Text = "Reporte de Egresos";
            // 
            // btn_generar
            // 
            this.btn_generar.Location = new System.Drawing.Point(812, 78);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(75, 23);
            this.btn_generar.TabIndex = 97;
            this.btn_generar.Text = "Generar";
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // lbl_ini
            // 
            this.lbl_ini.AutoSize = true;
            this.lbl_ini.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ini.Location = new System.Drawing.Point(165, 70);
            this.lbl_ini.Name = "lbl_ini";
            this.lbl_ini.Size = new System.Drawing.Size(123, 18);
            this.lbl_ini.TabIndex = 101;
            this.lbl_ini.Text = "Fecha de Inicio";
            // 
            // dtp_fin_venta
            // 
            this.dtp_fin_venta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fin_venta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fin_venta.Location = new System.Drawing.Point(533, 91);
            this.dtp_fin_venta.Name = "dtp_fin_venta";
            this.dtp_fin_venta.Size = new System.Drawing.Size(100, 23);
            this.dtp_fin_venta.TabIndex = 99;
            this.dtp_fin_venta.ValueChanged += new System.EventHandler(this.dtp_fin_venta_ValueChanged);
            // 
            // dtp_ini_venta
            // 
            this.dtp_ini_venta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ini_venta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ini_venta.Location = new System.Drawing.Point(218, 91);
            this.dtp_ini_venta.Name = "dtp_ini_venta";
            this.dtp_ini_venta.Size = new System.Drawing.Size(100, 23);
            this.dtp_ini_venta.TabIndex = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(462, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 101;
            this.label1.Text = "Fecha de Fin";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sp_rpt_egresosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Ventana_Inicial.rpt_egreso.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(23, 140);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(949, 414);
            this.reportViewer1.TabIndex = 102;
            // 
            // sp_rpt_egresosTableAdapter
            // 
            this.sp_rpt_egresosTableAdapter.ClearBeforeFill = true;
            // 
            // rpt_egresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_ini);
            this.Controls.Add(this.dtp_fin_venta);
            this.Controls.Add(this.dtp_ini_venta);
            this.Controls.Add(this.lbl_titulo_producto);
            this.Controls.Add(this.btn_generar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "rpt_egresos";
            this.Text = "rpt_egresos";
            this.Load += new System.EventHandler(this.rpt_egresos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_rpt_egresosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMDP_DBDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo_producto;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.Label lbl_ini;
        public System.Windows.Forms.DateTimePicker dtp_fin_venta;
        public System.Windows.Forms.DateTimePicker dtp_ini_venta;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_rpt_egresosBindingSource;
        private EMDP_DBDataSet2 EMDP_DBDataSet2;
        private EMDP_DBDataSet2TableAdapters.sp_rpt_egresosTableAdapter sp_rpt_egresosTableAdapter;
    }
}