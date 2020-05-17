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
    public partial class frm_subcategoria : Form
    {
        public frm_subcategoria()
        {
            InitializeComponent();
        }
        

        private void frm_subcategoria_Load(object sender, EventArgs e)
        {
            Lista_Tablas.listar_subcategoria(dgv_subcategoria);
            Lista_Tablas.llenar_categoria(cbo_categoria);
        }

        private void dgv_subcategoria_CurrentCellChanged(object sender, EventArgs e)
        {
            try { lbl_id_subc.Text = Convert.ToString(dgv_subcategoria.CurrentRow.Cells[0].Value); txt_subcategoria.Text = Convert.ToString(dgv_subcategoria.CurrentRow.Cells[1].Value); cbo_categoria.SelectedValue = dgv_subcategoria.CurrentRow.Cells[2].Value; }
            catch (Exception) { }
        }

        private void btn_guardar_subcat_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_insertar_subcategoria '" + txt_subcategoria.Text +"','"+Convert.ToInt16(cbo_categoria.SelectedValue)+ "'", Variables_Globales.cadconex);
                DataTable dt = new DataTable(); da.Fill(dt); da.Dispose(); Lista_Tablas.listar_subcategoria(dgv_subcategoria); MessageBox.Show("Categoria Creada Exitosamente");
            }
            catch { MessageBox.Show("Hubo un error en la inserción"); }
        }

        private void btn_actualizar_subcat_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_editar_subcategoria '" + lbl_id_subc.Text + "','" + txt_subcategoria.Text + "','" + Convert.ToInt16(cbo_categoria.SelectedValue) + "'", Variables_Globales.cadconex);
                DataTable dt = new DataTable(); da.Fill(dt); da.Dispose(); Lista_Tablas.listar_subcategoria(dgv_subcategoria); MessageBox.Show("Categoria Actualizada Exitosamente");
            }
            catch { MessageBox.Show("Hubo un error en la actualización"); }
        }

        private void btn_nueva_subcat_Click(object sender, EventArgs e)
        {
            lbl_id_subc.Text = "";
            txt_subcategoria.Clear();
            txt_subcategoria.Select();
        }

        private void dgv_subcategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
