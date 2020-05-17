namespace Ventana_Inicial
{
    partial class factura_envio
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.EMDP_DBDataSet3 = new Ventana_Inicial.EMDP_DBDataSet3();
            this.sp_guia_envioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_guia_envioTableAdapter = new Ventana_Inicial.EMDP_DBDataSet3TableAdapters.sp_guia_envioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.EMDP_DBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_guia_envioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sp_guia_envioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Ventana_Inicial.rpt_factura_envio.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(983, 495);
            this.reportViewer1.TabIndex = 0;
            // 
            // EMDP_DBDataSet3
            // 
            this.EMDP_DBDataSet3.DataSetName = "EMDP_DBDataSet3";
            this.EMDP_DBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_guia_envioBindingSource
            // 
            this.sp_guia_envioBindingSource.DataMember = "sp_guia_envio";
            this.sp_guia_envioBindingSource.DataSource = this.EMDP_DBDataSet3;
            // 
            // sp_guia_envioTableAdapter
            // 
            this.sp_guia_envioTableAdapter.ClearBeforeFill = true;
            // 
            // factura_envio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 494);
            this.Controls.Add(this.reportViewer1);
            this.Name = "factura_envio";
            this.ShowIcon = false;
            this.Text = "Impresion de Factura";
            this.Load += new System.EventHandler(this.factura_envio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EMDP_DBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_guia_envioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_guia_envioBindingSource;
        private EMDP_DBDataSet3 EMDP_DBDataSet3;
        private EMDP_DBDataSet3TableAdapters.sp_guia_envioTableAdapter sp_guia_envioTableAdapter;
    }
}