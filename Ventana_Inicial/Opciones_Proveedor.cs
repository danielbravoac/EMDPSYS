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
    public partial class frm_opciones_proveedor : Form
    {
        public frm_opciones_proveedor()
        {
            InitializeComponent();
        }

        private void btn_registrar_proveedor_Click(object sender, EventArgs e)
        {
            frm_control_proveedor frm_ctrl_prov = new frm_control_proveedor();
            AddOwnedForm(frm_ctrl_prov);
            frm_ctrl_prov.TopLevel = false;
            frm_ctrl_prov.Dock = DockStyle.Fill;
            this.Controls.Add(frm_ctrl_prov);
            this.Tag = frm_ctrl_prov;
            frm_ctrl_prov.BringToFront();
            frm_ctrl_prov.Show();
        }

        private void btn_nuevo_pedido_Click(object sender, EventArgs e)
        {
            Variables_Globales.llamar_formulario(formulario_hijo: new frm_control_pedido(), frm_papa: this);
        }

        private void btn_devolucion_proveedor_Click(object sender, EventArgs e)
        {
            Variables_Globales.llamar_formulario(formulario_hijo: new frm_devolucion_proveedor(), frm_papa: this);
        }
    }
}
