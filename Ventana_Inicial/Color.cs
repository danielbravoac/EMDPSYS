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
    public partial class frm_color : Form
    {
        public frm_color()
        {
            InitializeComponent();
        }
        

        private void Color_Load(object sender, EventArgs e)
        {
            Lista_Tablas.listar_color(dgv_color);
        }

        private void btn_guardar_color_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_insertar_color '" + txt_color.Text + "'", Variables_Globales.cadconex);
                DataTable dt = new DataTable();
                da.Fill(dt);
                da.Dispose(); 
                Lista_Tablas.listar_color(dgv_color); 
                MessageBox.Show("Categoria Creada Exitosamente");
            }
            catch
            {
                MessageBox.Show("Hubo un error en la inserción");
            }
        }

        private void btn_actualizar_color_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_editar_color '" + txt_id_col.Text + "','" + txt_color.Text + "'", Variables_Globales.cadconex);
                DataTable dt = new DataTable();
                da.Fill(dt);
                da.Dispose();
                Lista_Tablas.listar_color(dgv_color);
                MessageBox.Show("Categoria Actualizada Exitosamente");
            }
            catch { MessageBox.Show("Hubo un error en la actualización"); } 
        }

        private void btn_nuevo_color_Click(object sender, EventArgs e)
        {
            txt_color.Clear();
            txt_id_col.Clear();
        }

        private void dgv_color_CurrentCellChanged(object sender, EventArgs e)
        {
            try { txt_id_col.Text = Convert.ToString(dgv_color.CurrentRow.Cells[0].Value); txt_color.Text = Convert.ToString(dgv_color.CurrentRow.Cells[1].Value); }
            catch (Exception) { }
        }
    }
}
