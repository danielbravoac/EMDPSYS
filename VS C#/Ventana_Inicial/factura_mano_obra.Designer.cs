﻿namespace Ventana_Inicial
{
    partial class factura_mano_obra
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
            this.sp_rpt_boletaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EMDP_DBDataSet3 = new Ventana_Inicial.EMDP_DBDataSet3();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_rpt_boletaTableAdapter = new Ventana_Inicial.EMDP_DBDataSet3TableAdapters.sp_rpt_boletaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_rpt_boletaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMDP_DBDataSet3)).BeginInit();
            this.SuspendLayout();
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
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sp_rpt_boletaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Ventana_Inicial.rpt_factura_mano_obra.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(803, 451);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_rpt_boletaTableAdapter
            // 
            this.sp_rpt_boletaTableAdapter.ClearBeforeFill = true;
            // 
            // factura_mano_obra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "factura_mano_obra";
            this.ShowIcon = false;
            this.Text = "Impresion de Factura";
            this.Load += new System.EventHandler(this.Factura_mano_obra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_rpt_boletaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMDP_DBDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_rpt_boletaBindingSource;
        private EMDP_DBDataSet3 EMDP_DBDataSet3;
        private EMDP_DBDataSet3TableAdapters.sp_rpt_boletaTableAdapter sp_rpt_boletaTableAdapter;
    }
}