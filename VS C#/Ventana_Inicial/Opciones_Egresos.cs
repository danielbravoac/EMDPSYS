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
    public partial class frm_opciones_egresos : Form
    {
        public frm_opciones_egresos()
        {
            InitializeComponent();
        }

        private void frm_opciones_egresos_Load(object sender, EventArgs e)
        {
            
            Lista_Tablas.listar_egresos(dgv_control_egresos);
            cbo_buscar_egre.SelectedIndex = 0;
        }

        private void btn_registrar_egreso_Click(object sender, EventArgs e)
        {
            frm_egreso frm_egreso = new frm_egreso();
            AddOwnedForm(frm_egreso);
            frm_egreso.TopLevel = false;
            frm_egreso.Dock = DockStyle.Fill;
            this.Controls.Add(frm_egreso);
            this.Tag = frm_egreso;
            frm_egreso.BringToFront();
            frm_egreso.Show();
            frm_egreso.lbl_control_egreso.Text = "Nuevo Egreso";
            frm_egreso.btn_actualizar_egreso.Visible = false;
            
        }       
        private void btn_editar_egreso_Click(object sender, EventArgs e)
        {
            frm_egreso frm_egreso = new frm_egreso();
            AddOwnedForm(frm_egreso);
            frm_egreso.TopLevel = false;
            frm_egreso.Dock = DockStyle.Fill;
            this.Controls.Add(frm_egreso);
            this.Tag = frm_egreso;
            frm_egreso.BringToFront();
            frm_egreso.Show();
            frm_egreso.lbl_control_egreso.Text = "Editar Egreso";
            frm_egreso.btn_registrar_egreso.Visible = false;
            Variables_Globales.limpiar_controles(frm_egreso);
            frm_egreso.lbl_id_egreso.Text = dgv_control_egresos.CurrentRow.Cells[0].Value.ToString();
            frm_egreso.txt_motivo_egreso.Text = dgv_control_egresos.CurrentRow.Cells[1].Value.ToString();
            frm_egreso.nud_cantidad_egreso.Value = Convert.ToDecimal(dgv_control_egresos.CurrentRow.Cells[2].Value);
            
            frm_egreso.dtp_egreso.Value = Convert.ToDateTime(dgv_control_egresos.CurrentRow.Cells[4].Value);
        }

        private void cbo_buscar_egre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_buscar_egre.SelectedIndex == 1)
            {
                txt_buscar_egre.Enabled = true;
            }
            else {
                txt_buscar_egre.Enabled = false;
            }
        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_buscar_egreso '" + cbo_buscar_egre.SelectedIndex + "','" + dtp_inicio.Value.ToString("MM-dd-yyyy") + "','" + dtp_fin.Value.ToString("MM-dd-yyyy") + "','" + txt_buscar_egre.Text + "'", Variables_Globales.cadconex);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_control_egresos.DataSource = dt;
                da.Dispose();
                

            }
            catch
            {


            }
        }
    }
}
