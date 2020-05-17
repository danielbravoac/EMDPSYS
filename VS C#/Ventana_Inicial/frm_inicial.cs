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
    public partial class frm_inicial : Form
    {
        public frm_inicial()
        {
            InitializeComponent();
        }

        private void frm_inicial_Load(object sender, EventArgs e)
        {
            lbl_fecha_actual.Text = DateTime.Today.ToShortDateString();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_insertar_inicial '" + nud_inicial.Value + "','" + Variables_Globales.user  + "'", Variables_Globales.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);            
            da.Dispose();
                        
            Inicio_Sistema ini_sis = new Inicio_Sistema();
            ini_sis.Visible = true;
            Visible = false;
            ini_sis.lbl_usuario.Text = Variables_Globales.username;
            
        }
    }
}
