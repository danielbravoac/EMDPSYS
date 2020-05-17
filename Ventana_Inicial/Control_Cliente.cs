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
    public partial class frm_control_cliente : Form
    {
        public frm_control_cliente()
        {
            InitializeComponent();
        }

        private void btn_registrar_cliente_Click(object sender, EventArgs e)
        {
            frm_cliente frm_cliente = new frm_cliente();
            AddOwnedForm(frm_cliente);
            frm_cliente.TopLevel = false;
            frm_cliente.Dock = DockStyle.Fill;
            this.Controls.Add(frm_cliente);
            this.Tag = frm_cliente;
            frm_cliente.BringToFront();
            frm_cliente.Show();
            frm_cliente.btn_actualizar_cliente.Visible = false;
            frm_cliente.lbl_control_cliente.Text = "Nuevo Cliente";
            frm_cliente.txt_telefono_cliente.Text = "(+51)000-000-000";
            frm_cliente.cbo_sexo.SelectedIndex = 0;
            frm_cliente.cbo_tipo_documento.SelectedIndex = 0;
        }

        private void btn_editar_cliente_Click(object sender, EventArgs e)
        {
            frm_cliente frm_cliente = new frm_cliente();
            AddOwnedForm(frm_cliente);
            frm_cliente.TopLevel = false;
            frm_cliente.Dock = DockStyle.Fill;
            this.Controls.Add(frm_cliente);
            this.Tag = frm_cliente;
            frm_cliente.BringToFront();
            frm_cliente.Show();
            frm_cliente.btn_registrar_cliente.Visible = false;
            frm_cliente.lbl_control_cliente.Text = "Editar Cliente";            
            frm_cliente.lbl_id_cliente.Text = dgv_control_cliente.CurrentRow.Cells[0].Value.ToString();
            frm_cliente.cbo_tipo_documento.SelectedItem = dgv_control_cliente.CurrentRow.Cells[1].Value.ToString();
            frm_cliente.txt_documento_cliente.Text = dgv_control_cliente.CurrentRow.Cells[2].Value.ToString();
            frm_cliente.txt_nombre_cliente.Text = dgv_control_cliente.CurrentRow.Cells[3].Value.ToString();
            frm_cliente.dtp_nacimiento.Value = Convert.ToDateTime(dgv_control_cliente.CurrentRow.Cells[4].Value);
            frm_cliente.txt_direccion_cliente.Text = dgv_control_cliente.CurrentRow.Cells[5].Value.ToString();
            frm_cliente.txt_telefono_cliente.Text = dgv_control_cliente.CurrentRow.Cells[6].Value.ToString();
            frm_cliente.txt_email_cliente.Text = dgv_control_cliente.CurrentRow.Cells[7].Value.ToString();
            frm_cliente.cbo_sexo.SelectedItem = dgv_control_cliente.CurrentRow.Cells[8].Value.ToString();            
        }

        private void frm_control_cliente_Load(object sender, EventArgs e)
        {
            Lista_Tablas.listar_clientes(dgv_control_cliente);
            cbo_buscar_cli.SelectedIndex = 0;
        }

        private void txt_buscar_cli_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_buscar_cliente '" + cbo_buscar_cli.SelectedIndex + "','" +txt_buscar_cli.Text + "'", Variables_Globales.cadconex);
                DataTable dt = new DataTable();
                dgv_control_cliente.DataSource = dt;
                da.Fill(dt);

            }
            catch
            {


            }
        }
    }
}
