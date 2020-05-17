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
    public partial class rpt_stock : Form
    {
        public rpt_stock()
        {
            InitializeComponent();
        }

        private void rpt_stock_Load(object sender, EventArgs e)
        {
            cbo_buscar_venta.SelectedIndex = 0;
        }

        private void cbo_buscar_venta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_buscar_venta.SelectedIndex == 0)
            {
                txt_codigo.Visible = false;
            }
            else {
                txt_codigo.Visible = true;
            }
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'EMDP_DBDataSet1.sp_rpt_productos' Puede moverla o quitarla según sea necesario.
            this.sp_rpt_productosTableAdapter.Fill(this.EMDP_DBDataSet1.sp_rpt_productos,txt_codigo.Text,Convert.ToByte(cbo_buscar_venta.SelectedIndex));
            this.reportViewer1.RefreshReport();
        }
    }
}
