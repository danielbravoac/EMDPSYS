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
    public partial class frm_ticket : Form
    {
        public frm_ticket()
        {
            InitializeComponent();
        }

        private void frm_ticket_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'EMDP_DBDataSet3.sp_rpt_boleta' Puede moverla o quitarla según sea necesario.
            this.sp_rpt_boletaTableAdapter.Fill(this.EMDP_DBDataSet3.sp_rpt_boleta,Variables_Globales.nNumdocentrada);

            this.reportViewer1.RefreshReport();
        }
    }
}
