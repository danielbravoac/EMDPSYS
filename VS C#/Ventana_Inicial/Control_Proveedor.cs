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
    public partial class frm_control_proveedor : Form
    {
        public frm_control_proveedor()
        {
            InitializeComponent();
        }

        private void Control_Proveedor_Load(object sender, EventArgs e)
        {
            cbo_buscar_prov.SelectedIndex = 0;
            Lista_Tablas.listar_proveedores(dgv_control_proveedor);
        }

        private void btn_registrar_proveedor_Click(object sender, EventArgs e)
        {
            frm_proveedor frm_proveedor = new frm_proveedor();
            AddOwnedForm(frm_proveedor);
            frm_proveedor.TopLevel = false;
            frm_proveedor.Dock = DockStyle.Fill;
            this.Controls.Add(frm_proveedor);
            this.Tag = frm_proveedor;
            frm_proveedor.BringToFront();
            frm_proveedor.Show();
            frm_proveedor.lbl_control_proveedor.Text = "Nuevo Proveedor";
            frm_proveedor.btn_actualizar_proveedor.Visible = false;
            frm_proveedor.txt_telefono_proveedor.Text = "(+51)000-000-000";

        }

        private void btn_editar_proveedor_Click(object sender, EventArgs e)
        {
            frm_proveedor frm_proveedor= new frm_proveedor();
            AddOwnedForm(frm_proveedor);
            frm_proveedor.TopLevel = false;
            frm_proveedor.Dock = DockStyle.Fill;
            this.Controls.Add(frm_proveedor);
            this.Tag = frm_proveedor;
            frm_proveedor.BringToFront();
            frm_proveedor.Show();
            frm_proveedor.lbl_control_proveedor.Text = "Editar Proveedor";
            frm_proveedor.btn_registrar_proveedor.Visible = false;
            
            frm_proveedor.lbl_id_proveedor.Text = dgv_control_proveedor.CurrentRow.Cells[0].Value.ToString();
            frm_proveedor.txt_ruc_proveedor.Text = dgv_control_proveedor.CurrentRow.Cells[1].Value.ToString();
            frm_proveedor.txt_razon_social.Text = dgv_control_proveedor.CurrentRow.Cells[2].Value.ToString();
            frm_proveedor.txt_direccion_proveedor.Text = dgv_control_proveedor.CurrentRow.Cells[3].Value.ToString();
            frm_proveedor.txt_nombre_contacto.Text = dgv_control_proveedor.CurrentRow.Cells[4].Value.ToString();
            frm_proveedor.txt_telefono_proveedor.Text = dgv_control_proveedor.CurrentRow.Cells[5].Value.ToString();
            frm_proveedor.txt_email_proveedor.Text = dgv_control_proveedor.CurrentRow.Cells[6].Value.ToString();
            frm_proveedor.txt_nombre_comercial.Text = dgv_control_proveedor.CurrentRow.Cells[7].Value.ToString();
            
        }

        private void txt_buscar_pro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_buscar_proveedor '" + cbo_buscar_prov.SelectedIndex + "','" + txt_buscar_prov.Text + "'", Variables_Globales.cadconex);
                DataTable dt = new DataTable();
                dgv_control_proveedor.DataSource = dt;
                da.Fill(dt);

            }
            catch
            {


            }
        }
    }
}
