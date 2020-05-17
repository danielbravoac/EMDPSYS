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
    public partial class frm_nueva_venta : Form
    {
        public frm_nueva_venta()
        {
            InitializeComponent();
        }

        private void frm_nueva_venta_Load(object sender, EventArgs e)
        {
                      
            Lista_Tablas.llenar_producto(cbo_producto);
            Lista_Tablas.llenar_cliente(cbo_cliente);
            Lista_Tablas.llenar_empleado(cbo_empleado);
            

            dgv_control_producto.ColumnCount = 7;
            cbo_comprobante.SelectedIndex = 0;
            cbo_empleado.SelectedIndex = -1;
            cbo_cliente.SelectedIndex = -1;
            cbo_tipo_pago.SelectedIndex = 0;            
            cbo_producto.Select();
            dgv_control_producto.Columns[0].HeaderText = "ID_Producto";
            dgv_control_producto.Columns[1].HeaderText = "Codigo_Producto";
            dgv_control_producto.Columns[2].HeaderText = "Nombre_Producto";
            dgv_control_producto.Columns[3].HeaderText = "Precio_Unitario";
            dgv_control_producto.Columns[4].HeaderText = "Cantidad";
            dgv_control_producto.Columns[5].HeaderText = "Descuento";
            dgv_control_producto.Columns[6].HeaderText = "Importe";            
        }

        private void cbo_producto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_encontrar_id_producto '" + cbo_producto.Text + "'", Variables_Globales.cadconex);
                DataTable dt = new DataTable();
                da.Fill(dt);
                lbl_id_producto.Text =Convert.ToString(dt.Rows[0]["ID_Producto"]);
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
                SqlDataAdapter da = new SqlDataAdapter("sp_encontrar_stock '" + lbl_id_producto.Text + "'", Variables_Globales.cadconex);
                DataTable dt = new DataTable();
                da.Fill(dt);
                lbl_stock.Text= dt.Rows[0]["Stock"].ToString();
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

        private void nud_cantidad_ValueChanged(object sender, EventArgs e)
        {
            
            if (Convert.ToInt16(nud_cantidad.Value) >= 1) {
                btn_agregar.Enabled = true;
            }
            else if (Convert.ToInt16(nud_cantidad.Value) < 1) {
                btn_agregar.Enabled = false;
            }
            if (Convert.ToInt16(nud_cantidad.Value) > Convert.ToInt16(lbl_stock.Text)) {
                MessageBox.Show("La cantidad excede al stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nud_cantidad.Value = 0;
            }
            

            
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            dgv_control_producto.Columns[3].DefaultCellStyle.Format = "C2";
            dgv_control_producto.Columns[5].DefaultCellStyle.Format = "C2";
            dgv_control_producto.Columns[6].DefaultCellStyle.Format = "C2";
            bool agregado = false;
            int c=0;
            for (; c <= dgv_control_producto.RowCount - 1; c++) {
                if (dgv_control_producto.Rows[c].Cells[0].Value.ToString() == lbl_id_producto.Text) {
                    agregado = true;
                }

            }
            if (MessageBox.Show("¿Seguro de Agregar Este Item a la Venta?", "Agregar Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes && agregado == false&&dgv_control_producto.RowCount<=11)
            {
                dgv_control_producto.Rows.Add(lbl_id_producto.Text, cbo_producto.Text, lbl_nom_prod.Text, nud_precio_venta.Value, nud_cantidad.Value, nud_descuento.Value, Convert.ToDecimal((nud_precio_venta.Value * nud_cantidad.Value) - nud_descuento.Value));
                cbo_producto.SelectedIndex = 0;
                nud_cantidad.Value = 0;
                nud_descuento.Value = 0;
                lbl_nom_pro.Text = "";


            }
            else {
                if (agregado == true)
                {
                    MessageBox.Show("No Puede Agregar un Producto 2 Veces, Edite la Cantidad a Llevar", "Exceso de Cargo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbo_producto.SelectedIndex = 0;
                    nud_cantidad.Value = 0;
                    nud_descuento.Value = 0;
                }                
                if (dgv_control_producto.RowCount == 11) {
                    btn_agregar.Enabled = false;
                    nud_cantidad.Enabled = false;
                    cbo_producto.Enabled = false;
                    nud_precio_venta.Enabled = false;
                    nud_descuento.Enabled = false;
                }
            }
        }

        private void btn_quitar_Click(object sender, EventArgs e)
        {
            if (dgv_control_producto.RowCount > 0)
            {
                if (MessageBox.Show("¿Seguro de Eliminar Item Seleccionado de la Venta?","Eliminar Item", MessageBoxButtons.YesNo) == DialogResult.Yes)
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

        private void btn_vender_Click(object sender, EventArgs e)
        {
            
            if (dgv_control_producto.RowCount > 0) {
                try
                {
                SqlDataAdapter da = new SqlDataAdapter("sp_insertar_venta '" +Variables_Globales.user+"','"+cbo_cliente.SelectedValue+"','"+cbo_tipo_pago.SelectedItem.ToString()+"','"+cbo_empleado.SelectedValue+"','"+txt_serie_comprobante.Text+"','"+txt_numero_comprobante.Text+"','"+cbo_comprobante.SelectedItem.ToString()+"','"+nud_mano_obra.Value+"','"+Convert.ToDecimal(txt_total.Text)+ "'", Variables_Globales.cadconex);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Variables_Globales.mano_obra = nud_mano_obra.Value;
                da.Dispose();
                
                SqlDataAdapter da2 = new SqlDataAdapter("sp_listar_venta", Variables_Globales.cadconex);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                Variables_Globales.nNumdocentrada = Convert.ToInt32(dt2.Rows[0]["ID_Venta"]);
                da2.Dispose();
                
                int c;
                for (c = 0; c <= dgv_control_producto.RowCount-1; c++)
                {
                SqlDataAdapter da3 = new SqlDataAdapter("sp_insertar_detalle_venta '" + Variables_Globales.nNumdocentrada + "','" + dgv_control_producto.Rows[c].Cells[0].Value + "','" + dgv_control_producto.Rows[c].Cells[4].Value + "','" + dgv_control_producto.Rows[c].Cells[3].Value + "','" + Convert.ToDecimal(dgv_control_producto.Rows[c].Cells[5].Value) + "'", Variables_Globales.cadconex);
                DataTable dt3 = new DataTable();
                da3.Fill(dt3);
                da3.Dispose();
                }
                if (MessageBox.Show("Venta Procesada, Encaje Boleta en la Impresora", "Venta Procesada", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK) {
                        if (Convert.ToInt16(cbo_comprobante.SelectedIndex) == 0)
                        {
                            frm_boleta boleta = new frm_boleta();
                            boleta.Show();
                        }
                        if (Convert.ToInt16(cbo_comprobante.SelectedIndex) == 1)
                        {
                            if (nud_mano_obra.Value > 0) {
                                factura_mano_obra fac_ob = new factura_mano_obra();
                                fac_ob.Show();
                            }                        
                            frm_factura factura = new frm_factura();
                            factura.Show();                        
                        }
                        

                        Variables_Globales.llamar_formulario(frm_papa: this, formulario_hijo: new frm_opciones_venta());
                    }
                dgv_control_producto.Rows.Clear();
                }
                catch
                {
                    MessageBox.Show("Error al Procesar la Venta", "Error al procesar la venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        else
        {
         MessageBox.Show("No se puede grabar ingreso," + Char.ConvertFromUtf32(13) + "No existen items o superó límite máximo de items por comprobante", "Aviso");
        }

        }

        private void cbo_tipo_pago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pic_volver_Click(object sender, EventArgs e)
        {
            Variables_Globales.llamar_formulario(formulario_hijo: new frm_opciones_venta(), frm_papa: this);
        }

        private void dgv_control_producto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            int c=0;
            double subtot=0;
            for (; c <= dgv_control_producto.RowCount-1; c++) {
                subtot = subtot + Convert.ToDouble(dgv_control_producto.Rows[c].Cells[6].Value);            
            }
            txt_subtotal.Text = subtot.ToString();
            txt_total.Text = (subtot + Convert.ToDouble(nud_mano_obra.Value)).ToString();
            if (Convert.ToDecimal(txt_total.Text) != 0)
            {
                btn_vender.Enabled = true;
            }
        }

        private void Cbo_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_encontrar_nombre_cliente '" + cbo_cliente.SelectedValue + "'", Variables_Globales.cadconex);
                DataTable dt = new DataTable();
                da.Fill(dt);
                lbl_nom_cliente.Text = Convert.ToString(dt.Rows[0]["Nombre_Cliente"]);
                da.Dispose();
            }
            catch
            {
            }
        }

        private void Lbl_id_cliente_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Lbl_id_cliente_TextAlignChanged(object sender, EventArgs e)
        {

        }

        private void Cbo_empleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_encontrar_nombre_empleado '" + cbo_empleado.SelectedValue + "'", Variables_Globales.cadconex);
                DataTable dt = new DataTable();
                da.Fill(dt);
                lbl_empleado.Text = Convert.ToString(dt.Rows[0]["Nombre_Empleado"]);
                da.Dispose();
            }
            catch
            {
            }
        }

        private void dgv_control_producto_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dgv_control_producto.RowCount == 11)
            {
                lbl_advertencia.Text = "Comprobante lleno, genere una nueva venta";
                btn_agregar.Enabled = false;
            }
            else {
                btn_agregar.Enabled = true;
            }
        }

        private void nud_mano_obra_ValueChanged(object sender, EventArgs e)
        {
            btn_vender.Enabled = false;
        }

        private void cbo_comprobante_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da9 = new SqlDataAdapter("sp_ult_com '"+Convert.ToSByte(cbo_comprobante.SelectedIndex)+"'", Variables_Globales.cadconex);
                DataTable dt9 = new DataTable();
                da9.Fill(dt9);
            Int32 comprobante = Convert.ToInt32(dt9.Rows[0]["Numero_Comprobante"]);
            comprobante++;
                txt_numero_comprobante.Text = comprobante.ToString();
                da9.Dispose();
            int nums=txt_numero_comprobante.TextLength;
            for (; nums<7; nums++) {
                txt_numero_comprobante.Text = "0" + txt_numero_comprobante.Text;
            
            }
        }
            catch { }
        }
    }
}
