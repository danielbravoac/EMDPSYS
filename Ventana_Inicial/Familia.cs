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
    public partial class frm_familia : Form
    {
        public frm_familia()
        {
            InitializeComponent();
        }
        

        private void dgv_familia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_familia_Load(object sender, EventArgs e)
        {
            Lista_Tablas.listar_familia(dgv_familia);
        }

        private void dgv_familia_CurrentCellChanged(object sender, EventArgs e)
        {
            try { lbl_id_fam.Text = Convert.ToString(dgv_familia.CurrentRow.Cells[0].Value); txt_familia.Text = Convert.ToString(dgv_familia.CurrentRow.Cells[1].Value); }
            catch (Exception) { }
        }

        private void btn_nueva_fam_Click(object sender, EventArgs e)
        {
            lbl_id_fam.Text="";
            txt_familia.Clear();
            txt_familia.Select();
        }

        private void btn_guardar_fam_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_insertar_familia '" + txt_familia.Text + "'", Variables_Globales.cadconex);
                DataTable dt = new DataTable(); da.Fill(dt); da.Dispose(); Lista_Tablas.listar_familia(dgv_familia); MessageBox.Show("Familia Creada Exitosamente");
            }
            catch { MessageBox.Show("Hubo un error en la inserción"); }
        }

        private void btn_actualizar_fam_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_editar_familia '" + lbl_id_fam.Text + "','" + txt_familia.Text + "'", Variables_Globales.cadconex);
                DataTable dt = new DataTable(); da.Fill(dt); da.Dispose(); Lista_Tablas.listar_familia(dgv_familia); MessageBox.Show("Familia Actualizada Exitosamente");
            }
            catch { MessageBox.Show("Hubo un error en la actualización"); }
        }
    }
}
