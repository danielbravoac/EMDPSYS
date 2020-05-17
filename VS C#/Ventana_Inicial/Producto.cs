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
    public partial class frm_producto : Form
    {

        public frm_producto()
        {
            InitializeComponent();
        }
        

        private void btn_nuevo_producto_Click(object sender, EventArgs e)
        {
            Variables_Globales.limpiar_controles(this);
            txt_nombre_producto.Select();

        }

        private void frm_nuevo_producto_Load(object sender, EventArgs e)
        {
                txt_nombre_producto.Select();
            Lista_Tablas.llenar_categoria(cbo_categoria);
            Lista_Tablas.llenar_subcategoria(cbo_subcategoria, cbo_categoria: cbo_categoria);
            Lista_Tablas.llenar_ocasion(cbo_ocasion);
            Lista_Tablas.llenar_familia(cbo_familia);
            Lista_Tablas.llenar_color(cbo_color);
            cbo_categoria.SelectedIndex = 0;
            cbo_subcategoria.SelectedIndex = 0;
            cbo_ocasion.SelectedIndex = 0;
            cbo_familia.SelectedIndex = 0;
            cbo_color.SelectedIndex = 0;
        }

        private void txt_nombre_producto_TextChanged(object sender, EventArgs e)
        {
            if (txt_nombre_producto.Text != "")
            {
                btn_registrar_producto.Enabled = true;
            }
            else {
                btn_registrar_producto.Enabled = false;
            }
        }
        private void btn_registrar_producto_Click(object sender, EventArgs e)
        {

            
            
            txt_codigo_producto.Text = (lbl_id_codigo.Text+txt_nombre_producto.Text.Substring(0, 2) + Convert.ToString(cbo_color.SelectedValue) + Convert.ToString(cbo_categoria.SelectedValue) + Convert.ToString(cbo_familia.SelectedValue) + Convert.ToString(cbo_ocasion.SelectedValue) + Convert.ToString(cbo_subcategoria.SelectedValue)).ToUpper();
            try
            {                
                SqlDataAdapter da = new SqlDataAdapter("sp_insertar_producto '" + txt_codigo_producto.Text + "','" + txt_nombre_producto.Text + "','" + txt_detalle_diferencial.Text +"','"+ Convert.ToInt16(nud_stock_producto.Value) + "','" + Convert.ToDecimal(nud_precio_venta.Value) + "','" + Convert.ToInt16(nud_tamano_producto.Value) + "','" + Convert.ToInt32(cbo_color.SelectedValue) + "','" + Convert.ToInt32(cbo_categoria.SelectedValue) + "','" + Convert.ToInt32(cbo_familia.SelectedValue) + "','" + Convert.ToInt32(cbo_ocasion.SelectedValue) + "','" + Convert.ToInt32(cbo_subcategoria.SelectedValue) + "','"+"0x"+"','"+dtp_ultimo_pedido.Value.ToString("MM-dd-yyyy")+"'", Variables_Globales.cadconex);
                DataTable dt = new DataTable(); da.Fill(dt); da.Dispose();                
                if (MessageBox.Show("Registro Exitoso", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK) {
                    Variables_Globales.llamar_formulario(formulario_hijo: new frm_control_producto(), frm_papa: this);
                }
                
            }
            catch
            {
                
                Convert.ToByte(MessageBox.Show("Hubo un error en la Inserción de Datos", "Error en la Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error));
            }
            
        }

        private void pic_volver_Click(object sender, EventArgs e)
        {
            Variables_Globales.llamar_formulario(formulario_hijo: new frm_control_producto(), frm_papa: this);
        }

        private void cbo_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lista_Tablas.llenar_subcategoria(cbo_subcategoria, cbo_categoria);
        }

        private void lbl_id_codigo_Click(object sender, EventArgs e)
        {

        }

        private void btn_actualizar_producto_Click(object sender, EventArgs e)
        {

            try
            {
                
                txt_codigo_producto.Text = (lbl_id_producto.Text + txt_nombre_producto.Text.Substring(0, 2) + Convert.ToString(cbo_color.SelectedValue) + Convert.ToString(cbo_categoria.SelectedValue) + Convert.ToString(cbo_familia.SelectedValue) + Convert.ToString(cbo_ocasion.SelectedValue) + Convert.ToString(cbo_subcategoria.SelectedValue)).ToUpper();
                SqlDataAdapter da = new SqlDataAdapter("sp_editar_producto '" + lbl_id_producto.Text + "','" + txt_codigo_producto.Text + "','" + txt_nombre_producto.Text + "','" + txt_detalle_diferencial.Text + "','" + Convert.ToInt16(nud_stock_producto.Value) + "','" + Convert.ToDecimal(nud_precio_venta.Value) + "','" + Convert.ToInt16(nud_tamano_producto.Value) + "','" + Convert.ToInt32(cbo_color.SelectedValue) + "','" + Convert.ToInt32(cbo_categoria.SelectedValue) + "','" + Convert.ToInt32(cbo_familia.SelectedValue) + "','" + Convert.ToInt32(cbo_ocasion.SelectedValue) + "','" + Convert.ToInt32(cbo_subcategoria.SelectedValue) + "','" + "0x" +"','" + dtp_ultimo_pedido.Value.ToString("MM-dd-yyyy") + "'", Variables_Globales.cadconex);
                DataTable dt = new DataTable(); da.Fill(dt); da.Dispose();   
                if (MessageBox.Show("Cambios Guardados", "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)==DialogResult.OK)
                {
                    Variables_Globales.llamar_formulario(formulario_hijo: new frm_control_producto(), frm_papa: this);

                }
            }
            catch
            {
                Convert.ToByte(MessageBox.Show("Hubo un error en la Actualización de Datos", "Error en la Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error));
            }
        }

        private void btn_carac_Click(object sender, EventArgs e)
        {
            frm_caracteristicas_producto frm_caracteristica = new frm_caracteristicas_producto();
            AddOwnedForm(frm_caracteristica);            
            frm_caracteristica.TopLevel = false;
            frm_caracteristica.FormBorderStyle=FormBorderStyle.Sizable;         
            frm_caracteristica.Parent=this;
            frm_caracteristica.BringToFront();
            frm_caracteristica.Dock = DockStyle.Fill;
            frm_caracteristica.Show();
            
        }

        private void btn_carac_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void Btn_importar_producto_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
