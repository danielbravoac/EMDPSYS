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
    public partial class frm_devolucion_proveedor : Form
    {
        public frm_devolucion_proveedor()
        {
            InitializeComponent();
        }

        private void frm_devolucion_proveedor_Load(object sender, EventArgs e)
        {
            cbo_buscar_dev.SelectedIndex = 0;
            Lista_Tablas.listar_devolucion(dgv_control_descuento);

        }

        private void btn_registrar_devolucion_Click(object sender, EventArgs e)
        {
            frm_devolucion frm_devolucion = new frm_devolucion();
            AddOwnedForm(frm_devolucion);
            frm_devolucion.TopLevel = false;
            frm_devolucion.Dock = DockStyle.Fill;
            this.Controls.Add(frm_devolucion);
            this.Tag = frm_devolucion;
            frm_devolucion.BringToFront();
            frm_devolucion.Show();            
            frm_devolucion.lbl_control_devolucion.Text = "Nueva Devolucion";
            frm_devolucion.dgv_control_producto.ColumnCount = 4;
            frm_devolucion.cbo_producto.SelectedIndex = 0;
            frm_devolucion.dgv_control_producto.Columns[0].HeaderText = "ID_Producto";
            frm_devolucion.dgv_control_producto.Columns[1].HeaderText = "Codigo_Producto";
            frm_devolucion.dgv_control_producto.Columns[2].HeaderText = "Nombre_Producto";
            frm_devolucion.dgv_control_producto.Columns[3].HeaderText = "Cantidad_Devolucion";
            frm_devolucion.lbl_id_devolucion.Text = dgv_control_descuento.RowCount.ToString();
            

        }

        private void btn_editar_devolucion_Click(object sender, EventArgs e)
        {
           
        }

        private void dtp_fin_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
