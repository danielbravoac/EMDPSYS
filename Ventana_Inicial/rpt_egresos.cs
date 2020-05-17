using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventana_Inicial
{
    public partial class rpt_egresos : Form
    {
        public rpt_egresos()
        {
            InitializeComponent();
        }

        private void rpt_egresos_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'EMDP_DBDataSet2.sp_rpt_egresos' Puede moverla o quitarla según sea necesario.
            this.sp_rpt_egresosTableAdapter.Fill(this.EMDP_DBDataSet2.sp_rpt_egresos,dtp_ini_venta.Value,dtp_fin_venta.Value);
            this.reportViewer1.RefreshReport();
        }

        private void dtp_fin_venta_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
