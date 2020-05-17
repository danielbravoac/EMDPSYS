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
    public partial class frm_boleta : Form
    {
        public frm_boleta()
        {
            InitializeComponent();
        }

        private void frm_boleta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'EMDP_DBDataSet3.sp_rpt_boleta' Puede moverla o quitarla según sea necesario.
            this.sp_rpt_boletaTableAdapter.Fill(this.EMDP_DBDataSet3.sp_rpt_boleta, Variables_Globales.nNumdocentrada);
            this.reportViewer1.RefreshReport();
        }


        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
