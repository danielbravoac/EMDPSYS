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
    public partial class frm_control_bono : Form
    {
        public frm_control_bono()
        {
            InitializeComponent();
        }

        private void btn_registrar_bono_Click(object sender, EventArgs e)
        {
            frm_bono frm_bono = new frm_bono();
            AddOwnedForm(frm_bono);
            frm_bono.TopLevel = false;
            frm_bono.Dock = DockStyle.Fill;
            this.Controls.Add(frm_bono);
            this.Tag = frm_bono;
            frm_bono.BringToFront();
            frm_bono.Show();
            frm_bono.lbl_control_bono.Text = "Nuevo Bono";
            frm_bono.btn_actualizar_bono.Visible = false;
        }

        private void frm_control_bono_Load(object sender, EventArgs e)
        {
            Lista_Tablas.listar_bonos(dgv_control_bono);
            cbo_buscar_bono.SelectedIndex = 0;
        }

        private void btn_editar_bono_Click(object sender, EventArgs e)
        {
            frm_bono frm_bono = new frm_bono();
            AddOwnedForm(frm_bono);
            frm_bono.TopLevel = false;
            frm_bono.Dock = DockStyle.Fill;
            this.Controls.Add(frm_bono);
            this.Tag = frm_bono;
            frm_bono.BringToFront();
            frm_bono.Show();
            frm_bono.btn_registrar_bono.Visible = false;
            frm_bono.lbl_control_bono.Text = "Editar Bono";
            Variables_Globales.limpiar_controles(frm_bono);
            frm_bono.lbl_id_bono.Text = dgv_control_bono.CurrentRow.Cells[0].Value.ToString();
            frm_bono.txt_motivo_bono.Text = dgv_control_bono.CurrentRow.Cells[1].Value.ToString();
            frm_bono.nud_cantidad_bono.Value = Convert.ToDecimal(dgv_control_bono.CurrentRow.Cells[2].Value);
            frm_bono.cbo_empleado.SelectedValue = Convert.ToString(dgv_control_bono.CurrentRow.Cells[4].Value);
            
        }

        private void cbo_buscar_bono_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_buscar_bono.SelectedIndex == 1)
            {
                txt_bus_bono.Enabled = true;
            }
            else {
                txt_bus_bono.Enabled = false;
            }
        }

        private void dtp_inicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_buscar_bono '" + cbo_buscar_bono.SelectedIndex + "','" + dtp_inicio.Value.ToString("MM-dd-yyyy") +"','"+dtp_fin.Value.ToString("MM-dd-yyyy") +"','"+txt_bus_bono.Text+ "'", Variables_Globales.cadconex);
                DataTable dt = new DataTable();
                dgv_control_bono.DataSource = dt;
                da.Fill(dt);

            }
            catch
            {


            }
        }
    }
}
