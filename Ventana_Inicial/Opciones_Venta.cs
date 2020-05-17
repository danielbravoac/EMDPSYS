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
    public partial class frm_opciones_venta : Form
    {
        public frm_opciones_venta()
        {
            InitializeComponent();
        }

        private void frm_opciones_venta_Load(object sender, EventArgs e)
        {
            Lista_Tablas.listar_venta(dgv_control_venta);
            cbo_buscar_venta.SelectedIndex = 0;
        }

        private void btn_nueva_venta_Click(object sender, EventArgs e)
        {
            Variables_Globales.llamar_formulario(formulario_hijo: new frm_nueva_venta(), frm_papa: this);
            
        }

        private void btn_anular_venta_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(dgv_control_venta.CurrentRow.Cells[6].Value) == 0)
            {
                frm_anular_venta frm_anular_venta = new frm_anular_venta();
                AddOwnedForm(frm_anular_venta);
                frm_anular_venta.TopLevel = false;
                frm_anular_venta.Dock = DockStyle.Fill;
                this.Controls.Add(frm_anular_venta);
                this.Tag = frm_anular_venta;
                frm_anular_venta.BringToFront();
                frm_anular_venta.Show();
                Variables_Globales.limpiar_controles(frm_anular_venta);
                frm_anular_venta.lbl_id_venta.Text = dgv_control_venta.CurrentRow.Cells[0].Value.ToString();
                SqlDataAdapter da = new SqlDataAdapter("sp_listar_detalle_venta '" + Convert.ToInt32(frm_anular_venta.lbl_id_venta.Text) + "'", Variables_Globales.cadconex);
                DataTable dt = new DataTable();
                da.Fill(dt);
                frm_anular_venta.dgv_detalle_venta.DataSource = dt;
                da.Dispose();
                frm_anular_venta.dgv_detalle_venta.Columns[4].DefaultCellStyle.Format = "C2";
                frm_anular_venta.dgv_detalle_venta.Columns[5].DefaultCellStyle.Format = "C2";
            }
            else {
                MessageBox.Show("Ya se ha anulado esta venta", "Incongruencia de Accion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
            
        }

        private void txt_buscar_venta_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_buscar_venta '" + cbo_buscar_venta.SelectedIndex + "','" + txt_buscar_venta.Text + "'", Variables_Globales.cadconex);
                DataTable dt = new DataTable();
                dgv_control_venta.DataSource = dt;
                da.Fill(dt);

            }
            catch
            {


            }
        }
    }
}
