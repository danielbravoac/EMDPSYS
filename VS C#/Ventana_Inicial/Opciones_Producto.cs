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
    public partial class frm_opciones_producto : Form
    {
        public frm_opciones_producto()
        {
            InitializeComponent();
        }

        private void btn_nuevo_producto_Click(object sender, EventArgs e)
        {
            Variables_Globales.llamar_formulario(formulario_hijo: new frm_control_producto(), frm_papa: this);

        }

        private void btn_configurar_caracteristicas_Click(object sender, EventArgs e)
        {
            Variables_Globales.llamar_formulario(formulario_hijo: new frm_caracteristicas_producto(), frm_papa: this);
        }

        private void btn_devolucion_proveedor_Click(object sender, EventArgs e)
        {
            
        }
    }
}
