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
    public partial class frm_reportes : Form
    {
        public frm_reportes()
        {
            InitializeComponent();
        }

        private void btn_reporte_venta_Click(object sender, EventArgs e)
        {
            Variables_Globales.llamar_formulario(frm_papa: this, formulario_hijo: new rpt_ventas());
        }

        private void btn_stock_productos_Click(object sender, EventArgs e)
        {
            Variables_Globales.llamar_formulario(frm_papa: this, formulario_hijo: new rpt_stock());
        }

        private void btn_reporte_economico_Click(object sender, EventArgs e)
        {
            Variables_Globales.llamar_formulario(frm_papa: this, formulario_hijo: new rpt_egresos());
        }

        private void btn_reporte_empleados_Click(object sender, EventArgs e)
        {
            Variables_Globales.llamar_formulario(frm_papa: this, formulario_hijo: new rpt_caja());
        }
    }
}
