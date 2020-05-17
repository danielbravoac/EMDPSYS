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
    public partial class frm_descuento : Form
    {
        public frm_descuento()
        {
            InitializeComponent();
        }

        private void btn_registrar_descuento_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_insertar_descuento '" + txt_motivo_descuento.Text + "','" + nud_cantidad_descuento.Value + "','" + Convert.ToInt32(cbo_empleado.SelectedValue) + "'", Variables_Globales.cadconex);
                DataTable dt = new DataTable(); da.Fill(dt); da.Dispose();
                if (MessageBox.Show("Registro Exitoso", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK) {
                    Variables_Globales.llamar_formulario(formulario_hijo: new frm_control_descuentos(), frm_papa: this);
                }

            }
            catch
            {
                
            }
        }

        private void txt_motivo_descuento_TextChanged(object sender, EventArgs e)
        {
            if (txt_motivo_descuento.Text != "")
            {
                btn_registrar_descuento.Enabled = true;
            }
        }

        private void frm_nuevo_descuento_Load(object sender, EventArgs e)
        {
            Lista_Tablas.llenar_empleado(cbo_empleado);
        }

        private void btn_actualizar_descuento_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_editar_descuento '" + lbl_id_descuento.Text + "','" + txt_motivo_descuento.Text + "','" + nud_cantidad_descuento.Value + "','" + Convert.ToInt32(cbo_empleado.SelectedValue) + "'", Variables_Globales.cadconex);
                DataTable dt = new DataTable(); da.Fill(dt); da.Dispose();

                if (MessageBox.Show("Cambios Guardados", "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)==DialogResult.OK)
                {
                    Variables_Globales.llamar_formulario(formulario_hijo: new frm_control_descuentos(), frm_papa: this);
                }
            }
            catch
            {
                Convert.ToByte(MessageBox.Show("Hubo un error en la Actualización de Datos", "Error en la Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error));
            }
        }

        private void pic_volver_Click(object sender, EventArgs e)
        {
            Variables_Globales.llamar_formulario(formulario_hijo: new frm_control_descuentos(), frm_papa: this);
        }
    }
}
