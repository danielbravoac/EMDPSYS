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
    public partial class frm_pedido : Form
    {
        public frm_pedido()
        {
            InitializeComponent();
        }

        private void Nuevo_Pedido_Load(object sender, EventArgs e)
        {
            Lista_Tablas.llenar_proveedor(cbo_proveedor);
            Lista_Tablas.llenar_producto(cbo_producto);
            
            btn_registrar_pedido.Enabled = false;
        }    
                
         private void pic_volver_Click(object sender, EventArgs e)
        {
            Variables_Globales.llamar_formulario(formulario_hijo: new frm_control_pedido(), frm_papa: this);
        }
        
        private void cbo_producto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_encontrar_id_producto '" + cbo_producto.Text + "'", Variables_Globales.cadconex);
                DataTable dt = new DataTable();
                da.Fill(dt);
                lbl_id_producto.Text = Convert.ToString(dt.Rows[0]["ID_Producto"]);
                da.Dispose();
            }
            catch
            {
            }
        }

        private void lbl_id_producto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_encontrar_precio_producto '" + lbl_id_producto.Text + "'", Variables_Globales.cadconex);
                DataTable dt = new DataTable();
                da.Fill(dt);
                nud_precio_venta.Value = Convert.ToDecimal(dt.Rows[0]["Precio_Venta"]);
                da.Dispose();
                SqlDataAdapter da2 = new SqlDataAdapter("sp_encontrar_costo_producto '" + lbl_id_producto.Text + "'", Variables_Globales.cadconex);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                nud_precio_compra.Value = Convert.ToDecimal(dt2.Rows[0]["Precio_Costo"]);
                da2.Dispose();
            }
            catch
            {
            }

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
                SqlDataAdapter da2 = new SqlDataAdapter("sp_encontrar_nombre_producto '" + lbl_id_producto.Text + "'", Variables_Globales.cadconex);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                lbl_nom_pro.Text = Convert.ToString(dt2.Rows[0]["Nombre_Producto"]);
                da2.Dispose();
            }
            catch { }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            dgv_pedido.Columns[3].DefaultCellStyle.Format = "C2";
            dgv_pedido.Columns[4].DefaultCellStyle.Format = "C2";
            dgv_pedido.Columns[6].DefaultCellStyle.Format = "C2";
            dgv_pedido.Columns[9].DefaultCellStyle.Format = "C2";
            if (MessageBox.Show("¿Seguro de agregar nuevo item al detalle?", "Agregar Item", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dgv_pedido.Rows.Add(lbl_id_producto.Text, cbo_producto.Text, lbl_nom_prod.Text, nud_precio_venta.Value,nud_precio_compra.Value, nud_cantidad.Value, Convert.ToDecimal((nud_precio_venta.Value - nud_descuento.Value) * nud_cantidad.Value),txt_lote.Text,dtp_fecha_vencimiento.Value.ToString("MM-dd-yyyy"),nud_descuento.Value);
                cbo_producto.SelectedIndex = -1;
                nud_precio_compra.Value = 0;
                nud_precio_venta.Value = 0;
                nud_cantidad.Value = 0;
                nud_descuento.Value = 0;                
                txt_lote.Clear();
                dtp_fecha_vencimiento.Value = Convert.ToDateTime("01/01/1900");
                lbl_nom_pro.Text = "";

            }
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            int c = 0;
            double subtot = 0;
            for (; c <= dgv_pedido.RowCount - 1; c++)
            {
                subtot = subtot + Convert.ToDouble(dgv_pedido.Rows[c].Cells[6].Value);
            }
            txt_subtotal.Text = subtot.ToString();
            txt_total.Text = subtot.ToString();
            if (Convert.ToDouble(txt_total.Text) != 0)
            {
                btn_registrar_pedido.Enabled = true;
            }
            else {
                btn_registrar_pedido.Enabled = false;
            }
        }

        private void btn_quitar_Click(object sender, EventArgs e)
        {
            if (dgv_pedido.RowCount > 0)
            {
                if (MessageBox.Show("¿Seguro de eliminar item seleccionado a comprobante?","Quitar Item", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes){
                    dgv_pedido.Rows.RemoveAt(dgv_pedido.CurrentRow.Index);
                }
                else
                {
                    MessageBox.Show("No existen items para eliminar", "Error al Quitar Item", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void btn_registrar_pedido_Click(object sender, EventArgs e)
        {
            if (dgv_pedido.RowCount > 0) { 
            try
                {
                SqlDataAdapter da = new SqlDataAdapter("sp_insertar_pedido '" +cbo_proveedor.SelectedValue+"','"+dtp_fecha_pedido.Value.ToString("MM-dd-yyyy") +"','"+dtp_fecha_llegada_pedido.Value.ToString("MM-dd-yyyy") +"','"+nud_costo_envio_pedido.Value+"','"+txt_numero_documento.Text+ "','" + cbo_tipo_documento.SelectedItem.ToString()+ "','" + Variables_Globales.user+"','"+ Convert.ToDecimal(txt_total.Text) +  "'", Variables_Globales.cadconex);
                DataTable dt = new DataTable();
                da.Fill(dt);
                da.Dispose();
                    SqlDataAdapter da2 = new SqlDataAdapter("sp_listar_pedido", Variables_Globales.cadconex);
                    DataTable dt2 = new DataTable();
                    da2.Fill(dt2);
                    Variables_Globales.pedido = Convert.ToInt32(dt2.Rows[0]["ID_Pedido"]);
                    da2.Dispose();
                    int c;
                for (c = 0; c <= dgv_pedido.RowCount - 1; c++)
                {
                    SqlDataAdapter da3 = new SqlDataAdapter("sp_insertar_detalle_pedido '" + dgv_pedido.Rows[c].Cells[0].Value + "','" + Variables_Globales.pedido + "','" + dgv_pedido.Rows[c].Cells[4].Value + "','" + dgv_pedido.Rows[c].Cells[5].Value + "','" + dgv_pedido.Rows[c].Cells[7].Value + "','" + dgv_pedido.Rows[c].Cells[8].Value  + "','" + dgv_pedido.Rows[c].Cells[9].Value +"','"+dgv_pedido.Rows[c].Cells[3].Value+"','"+dtp_fecha_pedido.Value.ToString("MM-dd-yyyy") + "'", Variables_Globales.cadconex);
                    DataTable dt3 = new DataTable();
                    da3.Fill(dt3);
                    da3.Dispose();                    
                }
                if (MessageBox.Show("Pedido Registrado Exitosamente", "Ingreso Procesado", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    Variables_Globales.llamar_formulario(formulario_hijo: new frm_control_pedido(), frm_papa: this);
                }
                dgv_pedido.Rows.Clear();
                }
            catch
            {
                    MessageBox.Show("Error al Registrar el Pedido", "Error en el Registro de Pedido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            }
        }

        private void btn_actualizar_pedido_Click(object sender, EventArgs e)
        {   
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_editar_pedido '" + lbl_id_pedido.Text + "','" + cbo_proveedor.SelectedValue + "','" + dtp_fecha_pedido.Value.ToString("MM-dd-yyyy") + "','" + dtp_fecha_llegada_pedido.Value.ToString("MM-dd-yyyy") + "','" + nud_costo_envio_pedido.Value + "','" + txt_numero_documento.Text.ToString() +"','"+ cbo_tipo_documento.Text+"'", Variables_Globales.cadconex);
                DataTable dt = new DataTable(); da.Fill(dt); da.Dispose();

                if (MessageBox.Show("Pedido Actualizado Exitosamente", "Actualización Procesada", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    Variables_Globales.llamar_formulario(formulario_hijo: new frm_control_pedido(), frm_papa: this);

                }
            }
            catch
            {
                Convert.ToByte(MessageBox.Show("Hubo un Error en la Actualización de Pedido", "Error en la Actualización de Pedido", MessageBoxButtons.OK, MessageBoxIcon.Error));
            }
        }

        private void Nud_cantidad_ValueChanged(object sender, EventArgs e)
        {
            if (nud_cantidad.Value >= 1) {
                btn_agregar.Enabled = true;
            }
            else{
                btn_agregar.Enabled = false;
            }
        }

        private void Cbo_tipo_documento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_id_producto_Click(object sender, EventArgs e)
        {

        }
    }
            
}
