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
    public partial class frm_categoria : Form
    {
        public frm_categoria()
        {
            InitializeComponent();
        }
        


        private void Categoria_Load(object sender, EventArgs e)
        {
            Lista_Tablas.listar_categoria(dgv_categorias);
        }

        private void btn_nueva_cat_Click(object sender, EventArgs e)
        {
            lbl_id_cat.Text="";
            txt_categoria.Enabled = true;
            txt_categoria.Clear();
            txt_categoria.Select();            
        }

        private void btn_guardar_cat_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_insertar_categoria '" + txt_categoria.Text + "'", Variables_Globales.cadconex);
                DataTable dt = new DataTable(); da.Fill(dt); da.Dispose(); Lista_Tablas.listar_categoria(dgv_categorias); MessageBox.Show("Categoria Creada Exitosamente");
            }
            catch { MessageBox.Show("Hubo un error en la inserción"); }
        }

        private void btn_actualizar_cat_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_editar_categoria '" +lbl_id_cat.Text+"','"+ txt_categoria.Text + "'", Variables_Globales.cadconex);
                DataTable dt = new DataTable(); da.Fill(dt); da.Dispose();  Lista_Tablas.listar_categoria(dgv_categorias); MessageBox.Show("Categoria Actualizada Exitosamente");
            }
            catch { MessageBox.Show("Hubo un error en la actualización"); }
        }

        private void dgv_categorias_CurrentCellChanged(object sender, EventArgs e)
        {
            try { lbl_id_cat.Text = Convert.ToString(dgv_categorias.CurrentRow.Cells[0].Value);
                txt_categoria.Text=Convert.ToString(dgv_categorias.CurrentRow.Cells[1].Value); }
            catch (Exception) { }
        }
    }
}
