using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ventana_Inicial
{
    public partial class rpt_ventas : Form
    {
        public rpt_ventas()
        {
            InitializeComponent();
        }

        private void Rpt_ventas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'EMDP_DBDataSet.sp_rpt_ventas' Puede moverla o quitarla según sea necesario.
            Lista_Tablas.llenar_empleado(cbo_empleado);
            cbo_empleado.SelectedIndex = 0;
            cbo_buscar_venta.SelectedIndex = 0;
        }

        private void Cbo_empleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_encontrar_nombre_empleado '" + cbo_empleado.SelectedValue + "'", Variables_Globales.cadconex);
                DataTable dt = new DataTable();
                da.Fill(dt);
                lbl_nombre_emp.Text = Convert.ToString(dt.Rows[0]["Nombre_Empleado"]);
                da.Dispose();
            }
            catch
            {
            }
        }

        private void Btn_generar_Click(object sender, EventArgs e)
        {
            this.sp_rpt_ventasTableAdapter.Fill(this.EMDP_DBDataSet.sp_rpt_ventas, Convert.ToByte(cbo_buscar_venta.SelectedIndex), lbl_nombre_emp.Text.ToString(), dtp_ini_venta.Value, dtp_fin_venta.Value);                      
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void cbo_buscar_venta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_buscar_venta.SelectedIndex == 2)
            {
                cbo_empleado.Visible = true;
                lbl_nombre_emp.Visible = true;
            }
            if (cbo_buscar_venta.SelectedIndex != 2) {
                cbo_empleado.Visible = false;
                lbl_nombre_emp.Visible = false;
            }
            if (cbo_buscar_venta.SelectedIndex == 3) {
                lbl_ini.Visible = true;
                lbl_fin.Visible = true;
                dtp_fin_venta.Visible = true;
                dtp_ini_venta.Visible = true;
            }
            if (cbo_buscar_venta.SelectedIndex != 3)
            {
                lbl_ini.Visible = false;
                lbl_fin.Visible = false;
                dtp_fin_venta.Visible = false;
                dtp_ini_venta.Visible = false;
            }
        }
    }
}
