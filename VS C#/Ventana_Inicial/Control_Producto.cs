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
using System.IO;

namespace Ventana_Inicial
{
    public partial class frm_control_producto : Form
    {
        public frm_control_producto()
        {
            InitializeComponent();
        }

        private void btn_nuevo_producto_Click(object sender, EventArgs e)
        {
            frm_producto frm_producto = new frm_producto();
            AddOwnedForm(frm_producto);
            frm_producto.TopLevel = false;
            frm_producto.Dock = DockStyle.Fill;
            this.Controls.Add(frm_producto);
            this.Tag = frm_producto;
            frm_producto.BringToFront();
            frm_producto.Show();
            frm_producto.lbl_control_producto.Text = "Nuevo Producto";
            frm_producto.btn_actualizar_producto.Visible = false;
            frm_producto.lbl_id_codigo.Text = Convert.ToString(Convert.ToInt32(dgv_control_producto.Rows.Count+1));
            frm_producto.dtp_ultimo_pedido.Value = Convert.ToDateTime("01/01/1900");

        }    
        
        private void frm_control_producto_Load(object sender, EventArgs e)
        {
            cbo_buscar_pro.SelectedIndex = 0;
            Lista_Tablas.listar_productos(dgv_control_producto);
        }

        private void btn_editar_producto_Click(object sender, EventArgs e)
        {
            frm_producto frm_producto = new frm_producto();
            AddOwnedForm(frm_producto);
            frm_producto.TopLevel = false;
            frm_producto.Dock = DockStyle.Fill;
            this.Controls.Add(frm_producto);
            this.Tag = frm_producto;
            frm_producto.BringToFront();
            frm_producto.Show();     
            

            frm_producto.lbl_control_producto.Text = "Editar Producto";
            frm_producto.btn_registrar_producto.Visible = false;
            Variables_Globales.limpiar_controles(frm_producto);
            frm_producto.lbl_id_producto.Text = dgv_control_producto.CurrentRow.Cells[0].Value.ToString();
            frm_producto.txt_codigo_producto.Text = dgv_control_producto.CurrentRow.Cells[1].Value.ToString();
            frm_producto.txt_nombre_producto.Text = dgv_control_producto.CurrentRow.Cells[2].Value.ToString();
            frm_producto.txt_detalle_diferencial.Text = dgv_control_producto.CurrentRow.Cells[3].Value.ToString();
            frm_producto.nud_stock_producto.Value = Convert.ToInt32(dgv_control_producto.CurrentRow.Cells[4].Value);
            frm_producto.nud_precio_venta.Value = Convert.ToDecimal(dgv_control_producto.CurrentRow.Cells[5].Value);
            frm_producto.cbo_categoria.SelectedValue = Convert.ToString(dgv_control_producto.CurrentRow.Cells[8].Value);
            frm_producto.cbo_subcategoria.SelectedValue = Convert.ToString(dgv_control_producto.CurrentRow.Cells[11].Value);
            frm_producto.cbo_familia.SelectedValue = Convert.ToString(dgv_control_producto.CurrentRow.Cells[9].Value);
            frm_producto.cbo_ocasion.SelectedValue = Convert.ToString(dgv_control_producto.CurrentRow.Cells[10].Value);
            frm_producto.cbo_color.SelectedValue = Convert.ToString(dgv_control_producto.CurrentRow.Cells[7].Value);
            frm_producto.nud_tamano_producto.Value = Convert.ToInt16(dgv_control_producto.CurrentRow.Cells[6].Value);
            frm_producto.dtp_ultimo_pedido.Value = Convert.ToDateTime(dgv_control_producto.CurrentRow.Cells[17].Value);
        }

        private void txt_buscar_pro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_buscar_producto '" + cbo_buscar_pro.SelectedIndex + "','" + txt_buscar_pro.Text + "'", Variables_Globales.cadconex);
                DataTable dt = new DataTable();
                dgv_control_producto.DataSource = dt;
                da.Fill(dt);
            }
            catch
            {


            }
        }
    }
}
