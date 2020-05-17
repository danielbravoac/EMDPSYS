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
    public partial class frm_control_descuentos : Form
    {
        public frm_control_descuentos()
        {
            InitializeComponent();
        }

        private void Control_Descuentos_Load(object sender, EventArgs e)
        {
            Lista_Tablas.listar_descuentos(dgv_control_descuento);
            cbo_buscar_des.SelectedIndex = 0;
        }

        private void btn_registrar_descuento_Click(object sender, EventArgs e)
        {
            frm_descuento frm_descuento = new frm_descuento();
            AddOwnedForm(frm_descuento);
            frm_descuento.TopLevel = false;
            frm_descuento.Dock = DockStyle.Fill;
            this.Controls.Add(frm_descuento);
            this.Tag = frm_descuento;
            frm_descuento.BringToFront();
            frm_descuento.Show();
            frm_descuento.btn_actualizar_descuento.Visible = false;
            frm_descuento.lbl_control_descuento.Text = "Nuevo Descuento";

        }

        private void btn_editar_descuento_Click(object sender, EventArgs e)
        {
            frm_descuento frm_descuento = new frm_descuento();
            AddOwnedForm(frm_descuento);
            frm_descuento.TopLevel = false;
            frm_descuento.Dock = DockStyle.Fill;
            this.Controls.Add(frm_descuento);
            this.Tag = frm_descuento;
            frm_descuento.BringToFront();
            frm_descuento.Show();
            frm_descuento.lbl_control_descuento.Text = "Editar Descuento";
            btn_registrar_descuento.Visible = false;
            Variables_Globales.limpiar_controles(frm_descuento);
            frm_descuento.lbl_id_descuento.Text = dgv_control_descuento.CurrentRow.Cells[0].Value.ToString();
            frm_descuento.txt_motivo_descuento.Text = dgv_control_descuento.CurrentRow.Cells[1].Value.ToString();
            frm_descuento.nud_cantidad_descuento.Value = Convert.ToDecimal(dgv_control_descuento.CurrentRow.Cells[2].Value);
            frm_descuento.cbo_empleado.SelectedValue = Convert.ToInt16(dgv_control_descuento.CurrentRow.Cells[4].Value);
        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_buscar_descuento '" + cbo_buscar_des.SelectedIndex + "','" + dtp_inicio.Value.ToString("MM-dd-yyyy") + "','" + dtp_fin.Value.ToString("MM-dd-yyyy") + "','" + txt_buscar_des.Text + "'", Variables_Globales.cadconex);
                DataTable dt = new DataTable();
                dgv_control_descuento.DataSource = dt;
                da.Fill(dt);

            }
            catch
            {


            }
        }

        private void cbo_buscar_des_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_buscar_des.SelectedIndex == 0)
            {
                txt_buscar_des.Enabled = false;
            }
            else {

                txt_buscar_des.Enabled = true;
            }
        }
    }
}
