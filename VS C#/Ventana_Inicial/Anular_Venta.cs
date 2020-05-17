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
    public partial class frm_anular_venta : Form
    {
        public frm_anular_venta()
        {
            InitializeComponent();
        }

        private void btn_anular_venta_Click(object sender, EventArgs e)
        {
            
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_anular_venta '" + lbl_id_venta.Text + "','" + txt_motivo_anulacion.Text + "'", Variables_Globales.cadconex);
                DataTable dt = new DataTable(); da.Fill(dt); da.Dispose();
                int c;
                for (c = 0; c <= (dgv_detalle_venta.RowCount - 1); c++)
                {
                    SqlDataAdapter da2 = new SqlDataAdapter("sp_anular_detalle_venta '" + dgv_detalle_venta.Rows[c].Cells[3].Value + "','" + dgv_detalle_venta.Rows[c].Cells[1].Value + "'", Variables_Globales.cadconex);
                    DataTable dt2 = new DataTable(); da2.Fill(dt2); da2.Dispose();
                }
                if (MessageBox.Show("Venta Anulada", "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)==DialogResult.OK)
                {
                    Variables_Globales.llamar_formulario(formulario_hijo: new frm_opciones_venta(), frm_papa: this);

                }
            }
            catch
            {

                Convert.ToByte(MessageBox.Show("Error en la anulacion", "Error en la Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error));
            }
        }

        private void pic_volver_Click(object sender, EventArgs e)
        {
            Variables_Globales.llamar_formulario(formulario_hijo: new frm_opciones_venta(), frm_papa: this);
        }

        private void frm_anular_venta_Load(object sender, EventArgs e)
        {
            
        }
    }
}
