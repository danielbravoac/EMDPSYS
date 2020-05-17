namespace Ventana_Inicial
{
    partial class guia_envio
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
            this.sp_guia_envioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EMDP_DBDataSet3 = new Ventana_Inicial.EMDP_DBDataSet3();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_guia_envioTableAdapter = new Ventana_Inicial.EMDP_DBDataSet3TableAdapters.sp_guia_envioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_guia_envioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMDP_DBDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_guia_envioBindingSource
            // 
            this.sp_guia_envioBindingSource.DataMember = "sp_guia_envio";
            this.sp_guia_envioBindingSource.DataSource = this.EMDP_DBDataSet3;
            // 
            // EMDP_DBDataSet3
            // 
            this.EMDP_DBDataSet3.DataSetName = "EMDP_DBDataSet3";
            this.EMDP_DBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sp_guia_envioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Ventana_Inicial.rpt_guia_envio.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, -2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(996, 535);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_guia_envioTableAdapter
            // 
            this.sp_guia_envioTableAdapter.ClearBeforeFill = true;
            // 
            // guia_envio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 534);
            this.Controls.Add(this.reportViewer1);
            this.Name = "guia_envio";
            this.Text = "Guia de Envio";
            this.Load += new System.EventHandler(this.guia_envio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_guia_envioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMDP_DBDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_guia_envioBindingSource;
        private EMDP_DBDataSet3 EMDP_DBDataSet3;
        private EMDP_DBDataSet3TableAdapters.sp_guia_envioTableAdapter sp_guia_envioTableAdapter;
    }
}