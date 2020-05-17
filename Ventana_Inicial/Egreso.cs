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
    public partial class frm_egreso : Form
    {
        public frm_egreso()
        {
            InitializeComponent();
        }

        private void Egresos_Load(object sender, EventArgs e)
        {
            txt_motivo_egreso.Select();
        }

        private void btn_registrar_egreso_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_insertar_egreso '" + txt_motivo_egreso.Text + "','" + nud_cantidad_egreso.Value + "','" + Variables_Globales.user + "','" + dtp_egreso.Value.ToString("MM-dd-yyyy") + "'", Variables_Globales.cadconex);
                DataTable dt = new DataTable(); da.Fill(dt); da.Dispose();
                if (MessageBox.Show("Registro Exitoso", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK) {
                    Variables_Globales.llamar_formulario(formulario_hijo: new frm_opciones_egresos(), frm_papa: this);
                }
            }
            catch
            {

                Convert.ToByte(MessageBox.Show("Hubo un error en la Inserción de Datos", "Error en la Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error));
            }

        }

        private void nud_cantidad_egreso_ValueChanged(object sender, EventArgs e)
        {
            if (txt_motivo_egreso.Text != "") {
                btn_registrar_egreso.Enabled = true;
            }
        }

        private void pic_volver_Click(object sender, EventArgs e)
        {
            Variables_Globales.llamar_formulario(formulario_hijo: new frm_opciones_egresos(), frm_papa: this);
        }

        private void btn_actualizar_egreso_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_editar_egreso '" + lbl_id_egreso.Text + "','" + txt_motivo_egreso.Text + "','" + nud_cantidad_egreso.Value.ToString() + "','" + Variables_Globales.user+ "','" + dtp_egreso.Value.ToString("MM-dd-yyyy") + "'", Variables_Globales.cadconex);
                DataTable dt = new DataTable(); da.Fill(dt); da.Dispose();
                
                if (MessageBox.Show("Cambios Guardados", "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)==DialogResult.OK)
                {
                    Variables_Globales.llamar_formulario(formulario_hijo: new frm_opciones_egresos(), frm_papa: this);

                }
            }
            catch
            {
                Convert.ToByte(MessageBox.Show("Hubo un error en la Actualización de Datos", "Error en la Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error));
            }
        }
    }
}
