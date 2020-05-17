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
    public partial class frm_opciones_empleado : Form
    {
        public frm_opciones_empleado()
        {
            InitializeComponent();
        }

        private void btn_controlar_empleado_Click(object sender, EventArgs e)
        {
            Variables_Globales.llamar_formulario(formulario_hijo: new frm_control_empleado(), frm_papa: this);
        }

        private void btn_control_bono_Click(object sender, EventArgs e)
        {
            Variables_Globales.llamar_formulario(formulario_hijo: new frm_control_bono(), frm_papa: this);
        }

        private void btn_hacer_decuento_Click(object sender, EventArgs e)
        {
            Variables_Globales.llamar_formulario(formulario_hijo: new frm_control_descuentos(), frm_papa:this);
        }
    }
}
