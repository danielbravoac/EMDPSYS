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
    public partial class frm_opciones_delivery : Form
    {
        public frm_opciones_delivery()
        {
            InitializeComponent();
        }

        private void frm_opciones_delivery_Load(object sender, EventArgs e)
        {
            
            Lista_Tablas.listar_envio(dgv_control_envios);
            cbo_buscar_envio.SelectedIndex = 0;
        }

        private void btn_nuevo_delivery_Click(object sender, EventArgs e)
        {
            frm_enviosrpt frm_envio = new frm_enviosrpt();
            AddOwnedForm(frm_envio);
            frm_envio.TopLevel = false;
            frm_envio.Dock = DockStyle.Fill;
            this.Controls.Add(frm_envio);
            this.Tag = frm_envio;
            frm_envio.BringToFront();
            frm_envio.Show();
            frm_envio.lbl_control_envio.Text = "Nuevo Envio";
            frm_envio.btn_actualizar_envio.Visible = false;
            frm_envio.cbo_estado.Visible = false;
            frm_envio.lbl_estado.Visible = false;
            frm_envio.cbo_ventas.SelectedIndex = -1;
            frm_envio.txt_telefono_remitente.Text = "(+51)000-000-000";
            frm_envio.txt_telefono_destinatario.Text = "(+51)000-000-000";
            frm_envio.cbo_comp_imp.SelectedIndex = 0;
        }

        private void btn_actualizar_envio_Click(object sender, EventArgs e)
        {
            frm_enviosrpt frm_envio = new frm_enviosrpt();
            AddOwnedForm(frm_envio);
            frm_envio.TopLevel = false;
            frm_envio.Dock = DockStyle.Fill;
            this.Controls.Add(frm_envio);
            this.Tag = frm_envio;
            frm_envio.BringToFront();
            frm_envio.Show();
            frm_envio.lbl_control_envio.Text = "Actualizar Envío";
            frm_envio.btn_registrar_envio.Visible = false;
            Variables_Globales.limpiar_controles(frm_envio);
            frm_envio.lbl_id_envio.Text = dgv_control_envios.CurrentRow.Cells[0].Value.ToString();
            Variables_Globales.envio = Convert.ToInt32(dgv_control_envios.CurrentRow.Cells[0].Value);
            frm_envio.cbo_ventas.SelectedValue = dgv_control_envios.CurrentRow.Cells[1].Value;
            frm_envio.txt_remitente_envio.Text = dgv_control_envios.CurrentRow.Cells[2].Value.ToString();
            frm_envio.txt_dni_receptor.Text = dgv_control_envios.CurrentRow.Cells[3].Value.ToString();            
            frm_envio.txt_destinatario_envio.Text = dgv_control_envios.CurrentRow.Cells[4].Value.ToString();
            frm_envio.txt_direccion_destinatario.Text = dgv_control_envios.CurrentRow.Cells[5].Value.ToString();            
            frm_envio.nud_costo_envio.Value = Convert.ToDecimal(dgv_control_envios.CurrentRow.Cells[6].Value);
            frm_envio.dtp_fec_env.Value = Convert.ToDateTime(dgv_control_envios.CurrentRow.Cells[7].Value);            
            frm_envio.txt_nombre_receptor.Text = dgv_control_envios.CurrentRow.Cells[8].Value.ToString();
            frm_envio.dtp_fec_rec.Value = Convert.ToDateTime(dgv_control_envios.CurrentRow.Cells[9].Value);
            frm_envio.cbo_empleado.SelectedValue = dgv_control_envios.CurrentRow.Cells[10].Value;
            frm_envio.cbo_estado.SelectedItem = dgv_control_envios.CurrentRow.Cells[11].Value.ToString();
            frm_envio.txt_telefono_destinatario.Text = dgv_control_envios.CurrentRow.Cells[12].Value.ToString();
            frm_envio.txt_telefono_remitente.Text = dgv_control_envios.CurrentRow.Cells[13].Value.ToString();
            frm_envio.mtxt_envio_hora.Text = dgv_control_envios.CurrentRow.Cells[14].Value.ToString();
            frm_envio.cbo_tipo_comp.SelectedIndex = Convert.ToSByte(dgv_control_envios.CurrentRow.Cells[16].Value);
            frm_envio.btn_actualizar_envio.Enabled = true;
            frm_envio.cbo_comp_imp.Enabled = false;
            frm_envio.cbo_cliente.Enabled = false;
        }

        private void cbo_buscar_envio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_buscar_envio.SelectedIndex == 1)
            {
                txt_buscar_envio.Enabled = true;
            }
            else
            {
                txt_buscar_envio.Enabled = false;
            }
        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_buscar_envio '" + cbo_buscar_envio.SelectedIndex + "','" + dtp_inicio.Value.ToString("MM-dd-yyyy") + "','" + dtp_fin.Value.ToString("MM-dd-yyyy") + "','" + txt_buscar_envio.Text + "'", Variables_Globales.cadconex);
                DataTable dt = new DataTable();                
                da.Fill(dt);
                dgv_control_envios.DataSource = dt;
                da.Dispose();

            }
            catch
            {


            }
        }
    }
}
