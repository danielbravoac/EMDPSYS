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
    public partial class frm_empleado : Form
    {
        public frm_empleado()
        {
            InitializeComponent();
        }
        
        

        private void frm_nuevo_empleado_Load(object sender, EventArgs e)
        {
            Lista_Tablas.llenar_nseguridad(cbo_nivel_seguridad);
            txt_dni_empleado.Select();
            cbo_cargo.SelectedIndex = 0;
            cbo_estado_empleado.SelectedIndex = 0;
            cbo_sexo.SelectedIndex = 0;
        }

        private void txt_nombre_empleado_TextChanged(object sender, EventArgs e)
        {
            if (txt_nombre_empleado.Text != ""&&txt_dni_empleado.Text!="")
            {
                btn_registrar_empleado.Enabled = true;
            }
        }

        private void btn_registrar_empleado_Click(object sender, EventArgs e)
        {            
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_insertar_empleado '" + txt_dni_empleado.Text.ToString() + "','" + txt_nombre_empleado.Text.ToString() + "','" + dtp_nacimiento.Value.ToString("MM-dd-yyyy") + "','" +  dtp_contrato.Value.ToString("MM-dd-yyyy") + "','" + Convert.ToDecimal(nud_sueldo.Value) + "','" + txt_encriptado.Text.ToString() + "','" + Convert.ToInt32(cbo_nivel_seguridad.SelectedValue) + "','" + cbo_sexo.SelectedItem.ToString() + "','" + cbo_estado_empleado.SelectedItem.ToString() + "','" + cbo_cargo.SelectedItem.ToString() + "'", Variables_Globales.cadconex);
                DataTable dt = new DataTable(); da.Fill(dt); da.Dispose();
                
                if (MessageBox.Show("Empleado Registrado Con Éxito", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)==DialogResult.OK)
                {
                   Variables_Globales.llamar_formulario(formulario_hijo: new frm_control_empleado(), frm_papa: this);

                }
            }
            catch
            {

                Convert.ToByte(MessageBox.Show("Hubo un error en la Inserción de Datos", "Error en la Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error));
            }
            
        }

        

        private void pic_volver_Click(object sender, EventArgs e)
        {
            Variables_Globales.llamar_formulario(formulario_hijo: new frm_control_empleado(), frm_papa: this);
        }

        private void btn_actualizar_empleado_Click(object sender, EventArgs e)
        {
            
           // try
            //{
                SqlDataAdapter da = new SqlDataAdapter("sp_editar_empleado '" + Convert.ToInt32(lbl_id_empleado.Text) + "','" + txt_dni_empleado.Text.ToString() + "','" + txt_nombre_empleado.Text.ToString() + "','" + dtp_nacimiento.Value.ToString("MM-dd-yyyy") + "','" + dtp_contrato.Value.ToString("MM-dd-yyyy") + "'," + Convert.ToDecimal(nud_sueldo.Value) + ",'" + txt_encriptado.Text.ToString() + "','" + Convert.ToInt32(cbo_nivel_seguridad.SelectedValue) + "','" + cbo_sexo.SelectedItem.ToString() + "','" + cbo_estado_empleado.SelectedItem.ToString() + "','" + cbo_cargo.SelectedItem.ToString() + "'", Variables_Globales.cadconex);
                DataTable dt = new DataTable();
                da.Fill(dt);
                da.Dispose();                
                if (MessageBox.Show("Cambios Guardados", "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)==DialogResult.OK)
                {
                    Variables_Globales.llamar_formulario(formulario_hijo: new frm_control_empleado(), frm_papa: this);
                }
            //}
            //catch
            //{

            //    MessageBox.Show("Hubo un error en la Actualización" + e.ToString(), "Error en la Base de Datos ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }



        private void Txt_dni_empleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Txt_dni_empleado_TextChanged(object sender, EventArgs e)
        {
            txt_dni_empleado.MaxLength = 8;
            if (txt_dni_empleado.Text != ""&&txt_dni_empleado.TextLength==8)
            {
                btn_registrar_empleado.Enabled = true;
                btn_actualizar_empleado.Enabled = true;
            }
            else
            {
                btn_registrar_empleado.Enabled = false;
                btn_actualizar_empleado.Enabled = false;
            }
        }

        private void Txt_contrasena_TextChanged(object sender, EventArgs e)
        {
            //cadena original
            string password;
            password = txt_contrasena.Text;
            //encriptar clave
            SHA1CryptoServiceProvider proveedor = new SHA1CryptoServiceProvider();
            byte[] vectorbytes = System.Text.Encoding.UTF8.GetBytes(password);
            byte[] vectorencriptado = proveedor.ComputeHash(vectorbytes);
            //CADENA ENCRIPTADA FINAL
            txt_encriptado.Text = Convert.ToBase64String(vectorencriptado);
        }
    }
}
