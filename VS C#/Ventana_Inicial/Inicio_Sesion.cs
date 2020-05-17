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
using System.Security.Cryptography;

namespace Ventana_Inicial
{
    public partial class frm_inicio_sesion : Form
    {
        public frm_inicio_sesion()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_iniciar_sesion_Click(object sender, EventArgs e)
        {
            Variables_Globales.username = txt_usuario_sesion.Text.ToString();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_encontrar_id_usuario '" + txt_usuario_sesion.Text + "'", Variables_Globales.cadconex);
                DataTable dt = new DataTable();
                da.Fill(dt);
                lbl_id_usuario.Text =Convert.ToString(dt.Rows[0]["ID_Empleado"]);
                Variables_Globales.user = Convert.ToInt32(lbl_id_usuario.Text);
                da.Dispose();
                DateTime fecha;
                SqlDataAdapter da2 = new SqlDataAdapter("sp_listar_iniciales", Variables_Globales.cadconex);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                fecha = Convert.ToDateTime(dt2.Rows[0][1]);
                if (fecha == DateTime.Today)
                {
                    Variables_Globales.registrado = true;
                }
                else {
                    Variables_Globales.registrado = false;
                }                
                da2.Dispose();
            }
            catch
            {
                
            }
            if (lbl_pass.Text == txt_encriptado.Text && lbl_id_usuario.Text != "ID_Usuario")
            {
                if (Variables_Globales.nivel_seg == 2 && Variables_Globales.registrado == false)
                {
                    frm_inicial ini_caja = new frm_inicial();
                    ini_caja.Show();
                    Visible = false;
                }
                else
                {
                    Inicio_Sistema ini_sis = new Inicio_Sistema();
                    ini_sis.Visible = true;
                    Visible = false;
                    ini_sis.lbl_usuario.Text = txt_usuario_sesion.Text.ToString();
                }
                
            }
            else if (lbl_pass.Text == "Password")
            {
                MessageBox.Show("Usuario Inexistente", "Error en Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_password.Clear();
                txt_usuario_sesion.Clear();
                txt_usuario_sesion.Select();
            }
            else
            {
                MessageBox.Show("Contraseña Incorrecta", "Error en Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbl_id_usuario.Text = "ID_Usuario";
                lbl_pass.Text = "";
                txt_password.Clear();
                txt_password.Select();
            }
            
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            if (txt_usuario_sesion.Text != "" && txt_password.Text != "")
            {
                btn_iniciar_sesion.Enabled = true;
                //cadena original
                string password;
                password = txt_password.Text;
                //encriptar clave
                SHA1CryptoServiceProvider proveedor = new SHA1CryptoServiceProvider();
                byte[] vectorbytes = System.Text.Encoding.UTF8.GetBytes(password);
                byte[] vectorencriptado = proveedor.ComputeHash(vectorbytes);
                //CADENA ENCRIPTADA FINAL
                txt_encriptado.Text = Convert.ToBase64String(vectorencriptado);
            }
            else {
                btn_iniciar_sesion.Enabled = false;
            }
        }

        private void frm_inicio_sesion_Load(object sender, EventArgs e)
        {
            txt_usuario_sesion.Select();
        }

        private void txt_usuario_sesion_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lbl_id_usuario_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_encontrar_password '" + Convert.ToInt32(lbl_id_usuario.Text) + "'", Variables_Globales.cadconex);
                DataTable dt = new DataTable();
                da.Fill(dt);
                lbl_pass.Text = Convert.ToString(dt.Rows[0]["Contrasena"]);
                da.Dispose();
                SqlDataAdapter da2 = new SqlDataAdapter("sp_encontrar_nivel '" + Convert.ToInt32(lbl_id_usuario.Text) + "'", Variables_Globales.cadconex);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                lbl_tipo_acceso.Text = Convert.ToString(dt2.Rows[0]["ID_Nivel_Seguridad"]);
                Variables_Globales.nivel_seg = Convert.ToInt32(lbl_tipo_acceso.Text);
                
                da2.Dispose();
                
            }
            catch
            {

            }
           
        }

        private void lbl_pass_Click(object sender, EventArgs e)
        {

        }
    }
}
