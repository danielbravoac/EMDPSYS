using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ventana_Inicial
{
    class Variables_Globales
    {
        public static SqlConnection cadconex = new SqlConnection("Server=(local);database=EMDP_DB;Integrated Security=true;");
        //public static SqlConnection cadconex = new SqlConnection("Server=(local)\\MSSQLSERVERIC;database=EMDP_DB;Integrated Security=true");
        //public static SqlConnection cadconex = new SqlConnection("Data Source=(local),1433;Network Library=DBMSSOCN;Initial Catalog=EMDP_DB;User ID=sa;Password=continental;");
        //public static SqlConnection cadconex = new SqlConnection("Server=(local)\\MSSQLSERVERIC;Database=EMDP_DB;User Id=sa;Password = continental;");
        public static Int32 envio;
        public static Int32 user;
        public static Int32 nivel_seg;
        public static Int32 nNumdocentrada,pedido;
        public static decimal mano_obra;
        public static int  num_devolucion;
        public static bool registrado;
        public static string username;
        
        public static void limpiar_controles(Form frm) {
            foreach (Control ctrl in frm.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox txt = ctrl as TextBox;
                    txt.Clear();
                }
                if (ctrl is ComboBox)
                {
                    ComboBox cbo = ctrl as ComboBox;
                    cbo.SelectedText = "";
                    cbo.SelectedIndex = -1;
                }
                if (ctrl is NumericUpDown)
                {
                    NumericUpDown nud = ctrl as NumericUpDown;
                    nud.Value = 0;
                }                
            }
        }
        public static void llamar_formulario(object formulario_hijo,object frm_papa) {
            Form fp = frm_papa as Form;
            Form fh = formulario_hijo as Form;
            fp.AddOwnedForm(fh);
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            fp.Controls.Add(fh);
            fp.Tag = fh;
            fh.BringToFront();
            fh.Show();
            
        }

        
    }
}
