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
    public partial class frm_ocasion : Form
    {
        public frm_ocasion()
        {
            InitializeComponent();

        }
        

        private void frm_ocasion_Load(object sender, EventArgs e)
        {
            Lista_Tablas.listar_ocasion(dgv_ocasion);
        }


        private void btn_actualizar_ocasion_Click(object sender, EventArgs e)
        { 
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_editar_ocasion '" + lbl_id_ocasion.Text + "','" + txt_ocasion.Text + "'", Variables_Globales.cadconex);
                DataTable dt = new DataTable(); 
                da.Fill(dt);
                da.Dispose();
                Lista_Tablas.listar_ocasion(dgv_ocasion); 
                MessageBox.Show("Categoria Actualizada Exitosamente");
            }
            catch { MessageBox.Show("Hubo un error en la actualización"); }        
        }

        private void dgv_ocasion_CurrentCellChanged(object sender, EventArgs e)
        {
            try { lbl_id_ocasion.Text = Convert.ToString(dgv_ocasion.CurrentRow.Cells[0].Value); txt_ocasion.Text = Convert.ToString(dgv_ocasion.CurrentRow.Cells[1].Value); }
            catch (Exception) { }
        }

        private void btn_nueva_ocasion_Click(object sender, EventArgs e)
        {
            lbl_id_ocasion.Text = "";
            txt_ocasion.Clear();
            txt_ocasion.Select();
        }

        private void btn_guardar_ocasion_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_insertar_ocasion '" + txt_ocasion.Text + "'", Variables_Globales.cadconex);
                DataTable dt = new DataTable(); 
                da.Fill(dt); 
                da.Dispose();
                Lista_Tablas.listar_ocasion(dgv_ocasion); ;
            }
            catch
            {
                
                 Convert.ToByte(MessageBox.Show("Hubo un error en la Inserción de Datos, inténtelo de nuevo", "Error en la Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error));
            }
        }


    }
}
