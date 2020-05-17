namespace Ventana_Inicial
{
    partial class rpt_ventas
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
            this.sp_rpt_ventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EMDP_DBDataSet = new Ventana_Inicial.EMDP_DBDataSet();
            this.cbo_buscar_venta = new System.Windows.Forms.ComboBox();
            this.dtp_ini_venta = new System.Windows.Forms.DateTimePicker();
            this.dtp_fin_venta = new System.Windows.Forms.DateTimePicker();
            this.lbl_ini = new System.Windows.Forms.Label();
            this.lbl_fin = new System.Windows.Forms.Label();
            this.btn_generar = new System.Windows.Forms.Button();
            this.cbo_empleado = new System.Windows.Forms.ComboBox();
            this.lbl_nombre_emp = new System.Windows.Forms.Label();
            this.lbl_titulo_producto = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_rpt_ventasTableAdapter = new Ventana_Inicial.EMDP_DBDataSetTableAdapters.sp_rpt_ventasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_rpt_ventasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMDP_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_rpt_ventasBindingSource
            // 
            this.sp_rpt_ventasBindingSource.DataMember = "sp_rpt_ventas";
            this.sp_rpt_ventasBindingSource.DataSource = this.EMDP_DBDataSet;
            // 
            // EMDP_DBDataSet
            // 
            this.EMDP_DBDataSet.DataSetName = "EMDP_DBDataSet";
            this.EMDP_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbo_buscar_venta
            // 
            this.cbo_buscar_venta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_buscar_venta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_buscar_venta.FormattingEnabled = true;
            this.cbo_buscar_venta.Items.AddRange(new object[] {
            "Todas las Ventas",
            "Ventas Anuladas",
            "Nombre de Empleado",
            "Fecha de Venta"});
            this.cbo_buscar_venta.Location = new System.Drawing.Point(49, 61);
            this.cbo_buscar_venta.Name = "cbo_buscar_venta";
            this.cbo_buscar_venta.Size = new System.Drawing.Size(158, 25);
            this.cbo_buscar_venta.TabIndex = 25;
            this.cbo_buscar_venta.SelectedIndexChanged += new System.EventHandler(this.cbo_buscar_venta_SelectedIndexChanged);
            // 
            // dtp_ini_venta
            // 
            this.dtp_ini_venta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ini_venta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ini_venta.Location = new System.Drawing.Point(278, 78);
            this.dtp_ini_venta.Name = "dtp_ini_venta";
            this.dtp_ini_venta.Size = new System.Drawing.Size(100, 23);
            this.dtp_ini_venta.TabIndex = 27;
            this.dtp_ini_venta.Visible = false;
            // 
            // dtp_fin_venta
            // 
            this.dtp_fin_venta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fin_venta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fin_venta.Location = new System.Drawing.Point(466, 78);
            this.dtp_fin_venta.Name = "dtp_fin_venta";
            this.dtp_fin_venta.Size = new System.Drawing.Size(100, 23);
            this.dtp_fin_venta.TabIndex = 27;
            this.dtp_fin_venta.Visible = false;
            // 
            // lbl_ini
            // 
            this.lbl_ini.AutoSize = true;
            this.lbl_ini.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ini.Location = new System.Drawing.Point(225, 57);
            this.lbl_ini.Name = "lbl_ini";
            this.lbl_ini.Size = new System.Drawing.Size(123, 18);
            this.lbl_ini.TabIndex = 89;
            this.lbl_ini.Text = "Fecha de Inicio";
            this.lbl_ini.Visible = false;
            // 
            // lbl_fin
            // 
            this.lbl_fin.AutoSize = true;
            this.lbl_fin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fin.Location = new System.Drawing.Point(419, 57);
            this.lbl_fin.Name = "lbl_fin";
            this.lbl_fin.Size = new System.Drawing.Size(102, 18);
            this.lbl_fin.TabIndex = 89;
            this.lbl_fin.Text = "Fecha de Fin";
            this.lbl_fin.Visible = false;
            // 
            // btn_generar
            // 
            this.btn_generar.Location = new System.Drawing.Point(760, 63);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(75, 23);
            this.btn_generar.TabIndex = 90;
            this.btn_generar.Text = "Generar";
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.Btn_generar_Click);
            // 
            // cbo_empleado
            // 
            this.cbo_empleado.AutoCompleteCustomSource.AddRange(new string[] {
            "Boleta",
            "Factura"});
            this.cbo_empleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_empleado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_empleado.FormattingEnabled = true;
            this.cbo_empleado.Location = new System.Drawing.Point(237, 61);
            this.cbo_empleado.Name = "cbo_empleado";
            this.cbo_empleado.Size = new System.Drawing.Size(223, 25);
            this.cbo_empleado.TabIndex = 91;
            this.cbo_empleado.Visible = false;
            this.cbo_empleado.SelectedIndexChanged += new System.EventHandler(this.Cbo_empleado_SelectedIndexChanged);
            // 
            // lbl_nombre_emp
            // 
            this.lbl_nombre_emp.AutoSize = true;
            this.lbl_nombre_emp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_emp.Location = new System.Drawing.Point(486, 61);
            this.lbl_nombre_emp.Name = "lbl_nombre_emp";
            this.lbl_nombre_emp.Size = new System.Drawing.Size(176, 18);
            this.lbl_nombre_emp.TabIndex = 89;
            this.lbl_nombre_emp.Text = "Nombre del Empleado";
            this.lbl_nombre_emp.Visible = false;
            // 
            // lbl_titulo_producto
            // 
            this.lbl_titulo_producto.AutoSize = true;
            this.lbl_titulo_producto.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_producto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(74)))), ((int)(((byte)(167)))));
            this.lbl_titulo_producto.Location = new System.Drawing.Point(404, 9);
            this.lbl_titulo_producto.Name = "lbl_titulo_producto";
            this.lbl_titulo_producto.Size = new System.Drawing.Size(258, 32);
            this.lbl_titulo_producto.TabIndex = 92;
            this.lbl_titulo_producto.Text = "Reporte de Ventas";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sp_rpt_ventasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Ventana_Inicial.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(49, 141);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(918, 413);
            this.reportViewer1.TabIndex = 93;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // sp_rpt_ventasTableAdapter
            // 
            this.sp_rpt_ventasTableAdapter.ClearBeforeFill = true;
            // 
            // rpt_ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.lbl_titulo_producto);
            this.Controls.Add(this.cbo_empleado);
            this.Controls.Add(this.btn_generar);
            this.Controls.Add(this.lbl_nombre_emp);
            this.Controls.Add(this.lbl_fin);
            this.Controls.Add(this.lbl_ini);
            this.Controls.Add(this.dtp_fin_venta);
            this.Controls.Add(this.dtp_ini_venta);
            this.Controls.Add(this.cbo_buscar_venta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "rpt_ventas";
            this.Text = "rpt_ventas";
            this.Load += new System.EventHandler(this.Rpt_ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_rpt_ventasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMDP_DBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbo_buscar_venta;
        public System.Windows.Forms.DateTimePicker dtp_ini_venta;
        public System.Windows.Forms.DateTimePicker dtp_fin_venta;
        private System.Windows.Forms.Label lbl_ini;
        private System.Windows.Forms.Label lbl_fin;
        private System.Windows.Forms.Button btn_generar;
        public System.Windows.Forms.ComboBox cbo_empleado;
        private System.Windows.Forms.Label lbl_nombre_emp;
        private System.Windows.Forms.Label lbl_titulo_producto;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_rpt_ventasBindingSource;
        private EMDP_DBDataSet EMDP_DBDataSet;
        private EMDP_DBDataSetTableAdapters.sp_rpt_ventasTableAdapter sp_rpt_ventasTableAdapter;
    }
}