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
    public partial class frm_devolucion : Form
    {
        public frm_devolucion()
        {
            InitializeComponent();
        }
        int proveedor;
        int cantidad;
        private void pic_volver_Click(object sender, EventArgs e)
        {
            Variables_Globales.llamar_formulario(formulario_hijo: new frm_devolucion_proveedor(), frm_papa: this);
        }

        private void frm_devolucion_Load(object sender, EventArgs e)
        {
            cbo_tipo_documento.SelectedIndex = 0;
            cbo_ingresos.SelectedIndex = -1;
            
            Lista_Tablas.llenar_producto(cbo_producto);
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("¿Seguro de agregar nuevo item al detalle?", "Consulta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dgv_control_producto.Rows.Add(lbl_id_producto.Text, cbo_producto.Text, lbl_nom_prod.Text, nud_cantidad.Value);
                nud_cantidad.Value = 0;
            }
        }

        private void nud_cantidad_ValueChanged(object sender, EventArgs e)
        {
            if (nud_cantidad.Value > 0)
            {
                btn_agregar.Enabled = true;
            }
            if (Convert.ToInt32(nud_cantidad.Value) > cantidad) {
                MessageBox.Show("La cantidad excede al stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nud_cantidad.Value = 0;
            }
            else if (nud_cantidad.Value <= 0)
            {
                btn_agregar.Enabled = false;
            }
        }

        private void cbo_producto_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void lbl_id_producto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_encontrar_nombre '" + lbl_id_producto.Text + "'", Variables_Globales.cadconex);
                DataTable dt = new DataTable();
                da.Fill(dt);
                lbl_nom_prod.Text = dt.Rows[0]["Nombre_Producto"].ToString();
                da.Dispose();
            }
            catch
            {
            }
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_encontrar_stock '" + lbl_id_producto.Text + "'", Variables_Globales.cadconex);
                DataTable dt = new DataTable();
                da.Fill(dt);
                lbl_stock.Text = dt.Rows[0]["Stock"].ToString();
                da.Dispose();
            }
            catch
            {
            }
        }

        private void btn_registrar_devolucion_Click(object sender, EventArgs e)
        {
            if (dgv_control_producto.RowCount > 0)
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("sp_insertar_devolucion '" + proveedor+"','"+cbo_ingresos.SelectedValue + "'", Variables_Globales.cadconex);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    da.Dispose();
                    SqlDataAdapter da2 = new SqlDataAdapter("SELECT TOP 1 ID_Devolucion FROM Devolucion_Proveedor ORDER BY ID_Devolucion DESC" , Variables_Globales.cadconex);
                    DataTable dt2 = new DataTable();
                    da2.Fill(dt2);
                    Variables_Globales.num_devolucion =Convert.ToInt32( dt2.Rows[0]["ID_Devolucion"]);
                    da2.Dispose();
                    int c;
                    for (c = 0; c <= dgv_control_producto.RowCount - 1; c++)
                    {
                        SqlDataAdapter da3 = new SqlDataAdapter("sp_insertar_detalle_devolucion '" + dgv_control_producto.Rows[c].Cells[3].Value + "','" + Variables_Globales.num_devolucion + "','" + dgv_control_producto.Rows[c].Cells[0].Value + "'", Variables_Globales.cadconex);
                        DataTable dt3 = new DataTable();
                        da3.Fill(dt3);
                        da3.Dispose();
                    }
                    if (MessageBox.Show("Devolucion Hecha al Proveedor") == DialogResult.OK)
                    {
                        Variables_Globales.llamar_formulario(formulario_hijo: new frm_devolucion_proveedor(), frm_papa: this);
                    }
                    //dgv_control_producto.Rows.Clear();
                }
                catch
                {
                    MessageBox.Show("Devolucion no procesada");
                }
            }
            else
            {
                MessageBox.Show("No se puede grabar ingreso," + Char.ConvertFromUtf32(13) + "No existen items o superó límite máximo de items por comprobante", "Aviso");
            }
        }

        private void btn_actualizar_devolucion_Click(object sender, EventArgs e)
        {
            
        }

        private void Cbo_tipo_documento_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da7 = new SqlDataAdapter("sp_listar_comprobantes_pedido '" + Convert.ToSByte(cbo_tipo_documento.SelectedIndex) + "'", Variables_Globales.cadconex);
            DataTable dt7 = new DataTable();
            da7.Fill(dt7);
            cbo_ingresos.DataSource = dt7;
            cbo_ingresos.DisplayMember = "Numero_Documento";
            cbo_ingresos.ValueMember = "ID_Pedido";
            da7.Dispose();
        }

        private void Cbo_ingresos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                
                SqlDataAdapter da8 = new SqlDataAdapter("sp_prov_pedido '" + cbo_ingresos.SelectedValue + "'", Variables_Globales.cadconex);
                DataTable dt8 = new DataTable();
                da8.Fill(dt8);
                proveedor = Convert.ToInt32(dt8.Rows[0]["ID_Proveedor"]);
                SqlDataAdapter da = new SqlDataAdapter("sp_listar_detalle_pedido '" + cbo_ingresos.SelectedValue + "'", Variables_Globales.cadconex);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_pedido.DataSource = dt;
                da.Dispose();
            }
            catch { }


        }

        private void dgv_pedido_CurrentCellChanged(object sender, EventArgs e)
        {
            
            try
            {
                lbl_id_producto.Text = (dgv_pedido.CurrentRow.Cells[0].Value).ToString();
                cbo_producto.Text= (dgv_pedido.CurrentRow.Cells[8].Value).ToString();
                cantidad = Convert.ToInt32(dgv_pedido.CurrentRow.Cells[3].Value);
            }
            catch { }

        }

        private void dgv_pedido_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            
        }

        private void dgv_pedido_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgv_pedido.Columns[2].DefaultCellStyle.Format = "C2";
            dgv_pedido.Columns[6].DefaultCellStyle.Format = "C2";
            dgv_pedido.Columns[7].DefaultCellStyle.Format = "C2";
        }

        private void btn_quitar_Click(object sender, EventArgs e)
        {
            if (dgv_control_producto.RowCount > 0)
            {
                if (MessageBox.Show("¿Seguro de Eliminar Item Seleccionado de la Venta?", "Eliminar Item", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dgv_control_producto.Rows.RemoveAt(dgv_control_producto.CurrentRow.Index);
                }
                else
                {
                    MessageBox.Show("No existen items para eliminar", "Aviso",
                   MessageBoxButtons.YesNo);
                }
            }
        }
    }
}
