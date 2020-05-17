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
    public partial class frm_control_pedido : Form
    {
        public frm_control_pedido()
        {
            InitializeComponent();
        }

        private void btn_editar_pedido_Click(object sender, EventArgs e)
        {
            frm_pedido frm_pedido = new frm_pedido();
            AddOwnedForm(frm_pedido);
            frm_pedido.TopLevel = false;
            frm_pedido.Dock = DockStyle.Fill;
            this.Controls.Add(frm_pedido);
            this.Tag = frm_pedido;
            frm_pedido.BringToFront();
            frm_pedido.Show();
            frm_pedido.lbl_control_pedido.Text = "Editar Ingreso";
            Variables_Globales.limpiar_controles(frm_pedido);
            frm_pedido.cbo_proveedor.SelectedValue = dgv_control_pedido.CurrentRow.Cells[0].Value.ToString();
            frm_pedido.dtp_fecha_pedido.Value = Convert.ToDateTime(dgv_control_pedido.CurrentRow.Cells[1].Value);
            frm_pedido.lbl_id_pedido.Text = dgv_control_pedido.CurrentRow.Cells[2].Value.ToString();
            frm_pedido.dtp_fecha_llegada_pedido.Value = Convert.ToDateTime(dgv_control_pedido.CurrentRow.Cells[3].Value);            
            frm_pedido.nud_costo_envio_pedido.Value = Convert.ToDecimal(dgv_control_pedido.CurrentRow.Cells[4].Value);
            frm_pedido.txt_numero_documento.Text = dgv_control_pedido.CurrentRow.Cells[5].Value.ToString();
            frm_pedido.txt_total.Text = dgv_control_pedido.CurrentRow.Cells[6].Value.ToString();
            frm_pedido.cbo_tipo_documento.SelectedItem = dgv_control_pedido.CurrentRow.Cells[7].Value.ToString();
            frm_pedido.dgv_pedido.Enabled = false;
            frm_pedido.btn_calcular.Enabled = false;
            frm_pedido.cbo_producto.Enabled = false;
            frm_pedido.nud_cantidad.Enabled = false;
            frm_pedido.nud_precio_compra.Enabled = false;
            frm_pedido.nud_precio_venta.Enabled = false;
            frm_pedido.txt_lote.Enabled = false;
            frm_pedido.dtp_fecha_vencimiento.Enabled = false;
            frm_pedido.btn_agregar.Enabled = false;
            frm_pedido.btn_quitar.Enabled = false;
            frm_pedido.dtp_fecha_llegada_pedido.Enabled = true;
            frm_pedido.dgv_pedido.Enabled = false;
            frm_pedido.dtp_fecha_llegada_pedido.Value = DateTime.Today;
            frm_pedido.btn_registrar_pedido.Visible = false;
            SqlDataAdapter da = new SqlDataAdapter("sp_listar_detalle_pedido '" + frm_pedido.lbl_id_pedido.Text + "'", Variables_Globales.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            frm_pedido.dgv_pedido.DataSource = dt;
            da.Dispose();
            dgv_control_pedido.Enabled = false;
        }

        private void frm_control_pedido_Load(object sender, EventArgs e)
        {
            Lista_Tablas.listar_pedido(dgv_control_pedido);
            cbo_buscar_pedido.SelectedIndex = 0;
        }

        private void btn_nuevo_pedido_Click(object sender, EventArgs e)
        {
            frm_pedido frm_pedido = new frm_pedido();
            AddOwnedForm(frm_pedido);
            frm_pedido.TopLevel = false;
            frm_pedido.Dock = DockStyle.Fill;
            this.Controls.Add(frm_pedido);
            this.Tag = frm_pedido;
            frm_pedido.BringToFront();
            frm_pedido.lbl_id_pedido.Text = (dgv_control_pedido.RowCount + 1).ToString();
            frm_pedido.Show();
            frm_pedido.btn_actualizar_pedido.Visible = false;
            frm_pedido.dgv_pedido.ColumnCount = 10;
            frm_pedido.cbo_producto.SelectedIndex = 0;
            frm_pedido.dgv_pedido.Columns[0].HeaderText = "ID_Producto";
            frm_pedido.dgv_pedido.Columns[1].HeaderText = "Codigo_Producto";
            frm_pedido.dgv_pedido.Columns[2].HeaderText = "Nombre_Producto";
            frm_pedido.dgv_pedido.Columns[3].HeaderText = "Precio_Venta";
            frm_pedido.dgv_pedido.Columns[4].HeaderText = "Precio_Costo";
            frm_pedido.dgv_pedido.Columns[5].HeaderText = "Cantidad";            
            frm_pedido.dgv_pedido.Columns[6].HeaderText = "Importe";
            frm_pedido.dgv_pedido.Columns[7].HeaderText = "Numero_Lote";
            frm_pedido.dgv_pedido.Columns[8].HeaderText = "Fecha_Vencimiento";
            frm_pedido.dgv_pedido.Columns[9].HeaderText = "Descuento_Producto";

            frm_pedido.lbl_control_pedido.Text = "Nuevo Ingreso";
        }

        private void txt_buscar_pedido_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_buscar_pedido '" + cbo_buscar_pedido.SelectedIndex + "','" + txt_buscar_pedido.Text + "'", Variables_Globales.cadconex);
                DataTable dt = new DataTable();
                dgv_control_pedido.DataSource = dt;
                da.Fill(dt);

            }
            catch
            {


            }
        }
    }
}
