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
    public partial class frm_bono : Form
    {
        public frm_bono()
        {
            InitializeComponent();
        }

        private void btn_registrar_bono_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_insertar_bono '" + txt_motivo_bono.Text + "','" + nud_cantidad_bono.Value + "','" + Convert.ToInt32(cbo_empleado.SelectedValue) + "'", Variables_Globales.cadconex);
                DataTable dt = new DataTable(); da.Fill(dt); da.Dispose();
                if (MessageBox.Show("Registro Exitoso", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK) {
                    Variables_Globales.llamar_formulario(formulario_hijo: new frm_control_bono(), frm_papa: this);
                }
            }
            catch
            {

                Convert.ToByte(MessageBox.Show("Hubo un error en la Inserción de Datos", "Error en la Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error));
            }            
        }

        private void frm_nuevo_bono_Load(object sender, EventArgs e)
        {
            Lista_Tablas.llenar_empleado(cbo_empleado);
            txt_motivo_bono.Select();
            cbo_empleado.SelectedIndex = 0;
        }

        private void btn_actualizar_bono_Click(object sender, EventArgs e)
        {
            byte rpta;
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_editar_bono '" + lbl_id_bono.Text + "','" + txt_motivo_bono.Text + "','" + nud_cantidad_bono.Value + "','" + Convert.ToInt32(cbo_empleado.SelectedValue) + "'", Variables_Globales.cadconex);
                DataTable dt = new DataTable(); da.Fill(dt); da.Dispose();
                rpta = Convert.ToByte(MessageBox.Show("Cambios Guardados", "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information));
                if (rpta == 1)
                {
                    Variables_Globales.llamar_formulario(formulario_hijo: new frm_control_bono(), frm_papa: this);

                }
            }
            catch
            {

                Convert.ToByte(MessageBox.Show("Hubo un error en la Actualización de Datos", "Error en la Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error));
            }
        }

        private void cbo_empleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void nud_cantidad_bono_ValueChanged(object sender, EventArgs e)
        {
            if (nud_cantidad_bono.Value != 0 && txt_motivo_bono.Text != "")
            {
                btn_registrar_bono.Enabled = true;
            }
        }

        private void pic_volver_Click(object sender, EventArgs e)
        {
            Variables_Globales.llamar_formulario(formulario_hijo: new frm_control_bono(), frm_papa: this);
        }
    }
}
