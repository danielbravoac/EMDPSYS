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
    public partial class frm_cliente : Form
    {
        public frm_cliente()
        {
            InitializeComponent();
        }

        private void frm_cliente_Load(object sender, EventArgs e)
        {
            
            txt_documento_cliente.Select();
            
        }

        private void cbo_tipo_documento_SelectedIndexChanged(object sender, EventArgs e)
        {            

            if (cbo_tipo_documento.SelectedItem.ToString() == "RUC")
            {
                dtp_nacimiento.Enabled = false;
                txt_documento_cliente.MaxLength = 11;
                cbo_sexo.Enabled = false;
                cbo_sexo.SelectedItem = "Empresa";
                dtp_nacimiento.Value = Convert.ToDateTime("01/01/1900");
            }
            if (cbo_tipo_documento.SelectedItem.ToString() == "DNI")
            {
                txt_documento_cliente.MaxLength = 8;
                dtp_nacimiento.Enabled = true;
                cbo_sexo.Enabled = true;
            }
            if (cbo_tipo_documento.SelectedItem.ToString() == "Pasaporte")
            {
                txt_documento_cliente.MaxLength = 35;
                dtp_nacimiento.Enabled = true;
                cbo_sexo.Enabled = true;
            }
            
        }

        private void txt_documento_cliente_TextChanged(object sender, EventArgs e)
        {

            if (txt_documento_cliente.Text != "")
            {
                if (cbo_tipo_documento.SelectedIndex == 0 && txt_documento_cliente.TextLength == 8)
                {
                    btn_registrar_cliente.Enabled = true;
                    btn_actualizar_cliente.Enabled = true;
                }
                if (cbo_tipo_documento.SelectedIndex == 0 && txt_documento_cliente.TextLength != 8)
                {
                    btn_registrar_cliente.Enabled = false;
                    btn_actualizar_cliente.Enabled = false;
                }
                if (cbo_tipo_documento.SelectedIndex == 1 && txt_documento_cliente.TextLength == 11)
                {
                    btn_registrar_cliente.Enabled = true;
                    btn_actualizar_cliente.Enabled = true;
                }
                if (cbo_tipo_documento.SelectedIndex == 1 && txt_documento_cliente.TextLength != 11)
                {
                    btn_registrar_cliente.Enabled = false;
                    btn_actualizar_cliente.Enabled = false;
                }

                if (cbo_tipo_documento.SelectedIndex == 2 && txt_documento_cliente.TextLength >= 2)
                {
                    btn_registrar_cliente.Enabled = true;
                    btn_actualizar_cliente.Enabled = true;
                }
                if (cbo_tipo_documento.SelectedIndex == 2 && txt_documento_cliente.TextLength <= 2)
                {
                    btn_registrar_cliente.Enabled = false;
                    btn_actualizar_cliente.Enabled = false;
                }

            }
            else {
                btn_registrar_cliente.Enabled = false;
                btn_actualizar_cliente.Enabled = false;
            }
        }
        private void btn_actualizar_cliente_Click(object sender, EventArgs e)
        {
            bool t_correcto = true, e_correcto = true;
            if (txt_telefono_cliente.MaskCompleted==false && txt_telefono_cliente.Text.Substring(0, 5) == "(+51)")
            {

                if (txt_telefono_cliente.Text =="(+51)000-000-000") {
                    t_correcto = true;
                }
                if (txt_telefono_cliente.Text.Length == 16)
                {
                    t_correcto = true;
                }
                else if(txt_telefono_cliente.Text.Length != 16&& txt_telefono_cliente.Text != "(+51)000-000-000")
                {
                    Convert.ToByte(MessageBox.Show("Telefono no válido", "Error en ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error));
                    t_correcto = false;
                }

            }

            if (txt_email_cliente.Text != "")
            {
                if (txt_email_cliente.Text.Contains("@"))
                {
                    e_correcto = true;
                }
                else
                {
                    Convert.ToByte(MessageBox.Show("Email no válido", "Error en ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error));
                    e_correcto = false;

                }
            }
            if (e_correcto == true && t_correcto == true)
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("sp_editar_cliente '" + Convert.ToInt32(lbl_id_cliente.Text) + "','" + cbo_tipo_documento.SelectedItem.ToString() + "','" + txt_documento_cliente.Text.ToString() + "','" + txt_nombre_cliente.Text + "','" + dtp_nacimiento.Value.ToString("MM-dd-yyyy") + "','" + txt_direccion_cliente.Text + "','" + txt_telefono_cliente.Text.ToString() + "','" + txt_email_cliente.Text.ToString() + "','" + cbo_sexo.SelectedItem.ToString() + "'", Variables_Globales.cadconex);
                    DataTable dt = new DataTable(); da.Fill(dt); da.Dispose();

                    if (MessageBox.Show("Cambios Guardados", "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        Variables_Globales.llamar_formulario(formulario_hijo: new frm_control_cliente(), frm_papa: this);
                    }
                }
                catch
                {

                    Convert.ToByte(MessageBox.Show("Hubo un error en la Actualización de Datos", "Error en la Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error));
                }
            }
        }

        private void pic_volver_Click(object sender, EventArgs e)
        {
            Variables_Globales.llamar_formulario(formulario_hijo: new frm_control_cliente(), frm_papa: this);
        }

        private void btn_registrar_cliente_Click(object sender, EventArgs e)
        {
            bool t_correcto = true, e_correcto = true;
            if (txt_telefono_cliente.MaskCompleted == false && txt_telefono_cliente.Text.Substring(0, 5) == "(+51)")
            {

                if (txt_telefono_cliente.Text == "(+51)000-000-000")
                {
                    t_correcto = true;
                }
                if (txt_telefono_cliente.Text.Length == 16)
                {
                    t_correcto = true;
                }
                else if (txt_telefono_cliente.Text.Length != 16 && txt_telefono_cliente.Text != "(+51)000-000-000")
                {
                    Convert.ToByte(MessageBox.Show("Telefono no válido", "Error en ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error));
                    t_correcto = false;
                }

            }

            if (txt_email_cliente.Text != "")
            {
                if (txt_email_cliente.Text.Contains("@"))
                {
                    e_correcto = true;
                }
                else
                {
                    Convert.ToByte(MessageBox.Show("Email no válido", "Error en ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error));
                    e_correcto = false;

                }
            }


            if (t_correcto==true&&e_correcto==true) {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("sp_insertar_cliente '" + cbo_tipo_documento.SelectedItem.ToString() + "','" + txt_documento_cliente.Text.ToString() + "','" + txt_nombre_cliente.Text + "','" + dtp_nacimiento.Value.ToString("MM-dd-yyyy") + "','" + txt_direccion_cliente.Text + "','" + txt_telefono_cliente.Text.ToString() + "','" + txt_email_cliente.Text + "','" + cbo_sexo.SelectedItem.ToString() + "'", Variables_Globales.cadconex);
                    DataTable dt = new DataTable(); da.Fill(dt); da.Dispose();
                    if (MessageBox.Show("Registro Exitoso", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        Variables_Globales.llamar_formulario(formulario_hijo: new frm_control_cliente(), frm_papa: this);

                    }
                }
                catch
                {

                    Convert.ToByte(MessageBox.Show("Hubo un error en la Inserción de Datos", "Error en la Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error));
                }            
            }
        }

        private void txt_documento_cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbo_tipo_documento.Text !="Pasaporte") { 
            if(Char.IsNumber(e.KeyChar)) 
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
            

        }

        private void txt_telefono_cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
 
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = true;
                }

            
        }

        private void txt_telefono_cliente_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void txt_telefono_cliente_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txt_telefono_cliente_TextChanged_1(object sender, EventArgs e)
        {
            if (txt_telefono_cliente.Text.Substring(0, 5) == "(+51)")
            {
                txt_telefono_cliente.Mask = "(+00)000-000-000";
            }
            else
            {
                txt_telefono_cliente.Mask = "(+00)000-000-000-000-000-000";

            }
        }

        
    }
}
