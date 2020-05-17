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
    public partial class frm_proveedor : Form
    {
        public frm_proveedor()
        {
            InitializeComponent();
        }

        private void btn_nuevo_proveedor_Click(object sender, EventArgs e)
        {
            Variables_Globales.limpiar_controles(this);
            
        }


        private void txt_nombre_comercial_TextChanged(object sender, EventArgs e)
        {
            btn_registrar_proveedor.Enabled = true;
        }

        private void btn_registrar_proveedor_Click(object sender, EventArgs e)
        {
            
            if (txt_email_proveedor.Text != "" && txt_ruc_proveedor.Text.Length == 11)
            {

                if (txt_email_proveedor.Text.Contains("@"))
                {
                    try
                    {
                        SqlDataAdapter da = new SqlDataAdapter("sp_insertar_proveedor '" + txt_ruc_proveedor.Text.ToString() + "','" + txt_razon_social.Text + "','" + txt_direccion_proveedor.Text + "','" + txt_nombre_contacto.Text + "','" + txt_telefono_proveedor.Text.ToString() + "','" + txt_email_proveedor.Text + "','" + txt_nombre_comercial.Text + "'", Variables_Globales.cadconex);
                        DataTable dt = new DataTable(); da.Fill(dt); da.Dispose();
                        if (MessageBox.Show("Proveedor Registrado Con Éxito", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            Variables_Globales.llamar_formulario(formulario_hijo: new frm_control_proveedor(), frm_papa: this);                        
                        }
                    }
                    catch
                    {
                        Convert.ToByte(MessageBox.Show("Hubo un error en la Inserción de Datos", "Error en la Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error));
                    }
                }
                else
                {
                    MessageBox.Show("Correo electrónico inválido y RUC Invalido");
                }
            }
            else 
            {
                if (txt_ruc_proveedor.Text.Length == 11)
                {
                    try
                    {
                        SqlDataAdapter da = new SqlDataAdapter("sp_insertar_proveedor '" + txt_ruc_proveedor.Text.ToString() + "','" + txt_razon_social.Text + "','" + txt_direccion_proveedor.Text + "','" + txt_nombre_contacto.Text + "','" + txt_telefono_proveedor.Text.ToString() + "','" + txt_email_proveedor.Text + "','" + txt_nombre_comercial.Text + "'", Variables_Globales.cadconex);
                        DataTable dt = new DataTable(); da.Fill(dt); da.Dispose();
                        if (MessageBox.Show("Proveedor Registrado Con Éxito!", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            Variables_Globales.llamar_formulario(formulario_hijo: new frm_control_proveedor(), frm_papa: this);
                        }
                    }
                    catch
                    {
                        Convert.ToByte(MessageBox.Show("Hubo un error en la Inserción de Datos", "Error en la Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error));
                    }
                }
                else {
                    MessageBox.Show("RUC Invalido");
                    txt_ruc_proveedor.Select();
                }            
            }            
            
            
        }


        private void btn_actualizar_proveedor_Click(object sender, EventArgs e)
        {
            bool t_correcto = true, e_correcto = true;
            if (txt_telefono_proveedor.MaskCompleted == false && txt_telefono_proveedor.Text.Substring(0, 5) == "(+51)")
            {

                if (txt_telefono_proveedor.Text == "(+51)000-000-000")
                {

                    t_correcto = true;
                }
                if (txt_telefono_proveedor.Text.Length == 16)
                {
                    t_correcto = true;
                }
                else if (txt_telefono_proveedor.Text.Length != 16 && txt_telefono_proveedor.Text != "(+51)000-000-000")
                {
                    Convert.ToByte(MessageBox.Show("Telefono no válido", "Error en ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error));
                    t_correcto = false;
                }

            }

            if (txt_email_proveedor.Text != "")
            {
                if (txt_email_proveedor.Text.Contains("@"))
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
                    SqlDataAdapter da = new SqlDataAdapter("sp_editar_proveedor '" + lbl_id_proveedor.Text + "','" + txt_ruc_proveedor.Text.ToString() + "','" + txt_razon_social.Text + "','" + txt_direccion_proveedor.Text + "','" + txt_nombre_contacto.Text + "','" + txt_telefono_proveedor.Text.ToString() + "','" + txt_email_proveedor.Text + "','" + txt_nombre_comercial.Text + "'", Variables_Globales.cadconex);
                    DataTable dt = new DataTable(); da.Fill(dt); da.Dispose();

                    if (MessageBox.Show("Cambios Guardados", "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        Variables_Globales.llamar_formulario(formulario_hijo: new frm_control_proveedor(), frm_papa: this);
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
            Variables_Globales.llamar_formulario(formulario_hijo: new frm_control_proveedor(), frm_papa: this);
        }

        private void frm_proveedor_Load(object sender, EventArgs e)
        {
            
            txt_ruc_proveedor.Select();
            
        }

        private void txt_telefono_proveedor_TextChanged(object sender, EventArgs e)
        {
            if (txt_telefono_proveedor.Text.Substring(1, 3) == "51")
            {
                txt_telefono_proveedor.MaxLength = 14;
            }
            else
            {
                txt_telefono_proveedor.MaxLength = 50;
            }
        }

        private void Txt_ruc_proveedor_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Txt_ruc_proveedor_TextChanged(object sender, EventArgs e)
        {
            if (txt_ruc_proveedor.Text != "")
            {
                if (txt_ruc_proveedor.TextLength == 11)
                {
                    btn_registrar_proveedor.Enabled = true;
                    btn_actualizar_proveedor.Enabled = true;

                }
                else
                {
                    btn_registrar_proveedor.Enabled = false;
                    btn_actualizar_proveedor.Enabled = false;
                }
            }
            else {
                btn_registrar_proveedor.Enabled = true;
                btn_actualizar_proveedor.Enabled = true;
            }
            txt_ruc_proveedor.MaxLength = 11;
            
        }

        private void txt_ruc_proveedor_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_razon_social_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_telefono_proveedor_TextChanged_1(object sender, EventArgs e)
        {
            if (txt_telefono_proveedor.Text.Substring(0, 5) == "(+51)")
            {
                txt_telefono_proveedor.Mask = "(+00)000-000-000";
            }
            else
            {
                txt_telefono_proveedor.Mask = "(+00)000-000-000-000-000-000";

            }
        }
    }
}
