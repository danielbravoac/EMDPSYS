﻿namespace Ventana_Inicial
{
    partial class frm_boleta
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
            this.sp_rpt_boletaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EMDP_DBDataSet3 = new Ventana_Inicial.EMDP_DBDataSet3();
            this.sp_rpt_boletaTableAdapter = new Ventana_Inicial.EMDP_DBDataSet3TableAdapters.sp_rpt_boletaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_rpt_boletaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMDP_DBDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sp_rpt_boletaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Ventana_Inicial.rpt_boleta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-2, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1050, 574);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load_1);
            // 
            // sp_rpt_boletaBindingSource
            // 
            this.sp_rpt_boletaBindingSource.DataMember = "sp_rpt_boleta";
            this.sp_rpt_boletaBindingSource.DataSource = this.EMDP_DBDataSet3;
            // 
            // EMDP_DBDataSet3
            // 
            this.EMDP_DBDataSet3.DataSetName = "EMDP_DBDataSet3";
            this.EMDP_DBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_rpt_boletaTableAdapter
            // 
            this.sp_rpt_boletaTableAdapter.ClearBeforeFill = true;
            // 
            // frm_boleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 574);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_boleta";
            this.ShowIcon = false;
            this.Text = "Impresion de Boleta";
            this.Load += new System.EventHandler(this.frm_boleta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_rpt_boletaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMDP_DBDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource sp_rpt_boletaBindingSource;
        private EMDP_DBDataSet3 EMDP_DBDataSet3;
        private EMDP_DBDataSet3TableAdapters.sp_rpt_boletaTableAdapter sp_rpt_boletaTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}