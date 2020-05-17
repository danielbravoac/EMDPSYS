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
    public partial class frm_enviosrpt : Form
    {
        public frm_enviosrpt()
        {
            InitializeComponent();
        }

        private void btn_registrar_envio_Click(object sender, EventArgs e)
        {

            bool t_correcto = true;
            if (txt_telefono_destinatario.MaskCompleted == false && txt_telefono_destinatario.Text.Substring(0, 5) == "(+51)")
            {

                if (txt_telefono_destinatario.Text == "(+51)000-000-000")
                {
                    t_correcto = true;
                }
                if (txt_telefono_destinatario.Text.Length == 16)
                {
                    t_correcto = true;
                }
                else if (txt_telefono_destinatario.Text.Length != 16 && txt_telefono_destinatario.Text != "(+51)000-000-000")
                {
                    Convert.ToByte(MessageBox.Show("Telefono de Destinatario no válido", "Error en ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error));
                    t_correcto = false;
                }

            }
            if (txt_telefono_remitente.MaskCompleted == false && txt_telefono_remitente.Text.Substring(0, 5) == "(+51)")
            {

                if (txt_telefono_remitente.Text == "(+51)000-000-000")
                {
                    t_correcto = true;
                }
                if (txt_telefono_remitente.Text.Length == 16)
                {
                    t_correcto = true;
                }
                else if (txt_telefono_remitente.Text.Length != 16 && txt_telefono_remitente.Text != "(+51)000-000-000")
                {
                    Convert.ToByte(MessageBox.Show("Telefono de Remitente no válido", "Error en ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error));
                    t_correcto = false;
                }

            }


            if (t_correcto == true)
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("sp_insertar_envio '" + cbo_ventas.SelectedValue + "','" + txt_remitente_envio.Text + "','" + txt_dni_receptor.Text + "','" + txt_destinatario_envio.Text + "','" + txt_direccion_destinatario.Text + "','" + nud_costo_envio.Value + "','" + dtp_fec_env.Value.ToString("MM-dd-yyyy") + "','" + txt_nombre_receptor.Text + "','" + dtp_fec_rec.Value.ToString("MM-dd-yyyy") + "','" + cbo_empleado.SelectedValue + "','" + "En Tienda" + "','" + txt_telefono_destinatario.Text + "','" + txt_telefono_remitente.Text + "','" + mtxt_envio_hora.Text.ToString() + "','" + (cbo_tipo_comp.SelectedIndex).ToString() + "','"+cbo_cliente.SelectedValue+"','"+cbo_comp_imp.SelectedItem+"'", Variables_Globales.cadconex);
                    DataTable dt = new DataTable(); da.Fill(dt); da.Dispose();
                    SqlDataAdapter da2 = new SqlDataAdapter("sp_listar_envio_1", Variables_Globales.cadconex);
                    DataTable dt2 = new DataTable();
                    da2.Fill(dt2);
                    Variables_Globales.envio = Convert.ToInt32(dt2.Rows[0][0]);
                    da2.Dispose();
                    if (MessageBox.Show("Registro Exitoso", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        Variables_Globales.llamar_formulario(formulario_hijo: new frm_opciones_delivery(), frm_papa: this);
                        guia_envio envio = new guia_envio();
                        envio.Show();
                        if (cbo_comp_imp.SelectedIndex == 0)
                        {
                            boleta_envio bol_en = new boleta_envio();
                            bol_en.Show();
                        }
                        if (cbo_comp_imp.SelectedIndex == 1) {
                            factura_envio fac_en = new factura_envio();
                            fac_en.Show();
                        }
                    }

                }
                catch
                {

                    Convert.ToByte(MessageBox.Show("Hubo un error en la Inserción de Datos", "Error en la Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error));
                }
            }

        }

        private void frm_nuevo_envio_Load(object sender, EventArgs e)
        {
            
            Lista_Tablas.llenar_cliente(cbo_cliente);

            Lista_Tablas.llenar_empleado(cbo_empleado);
            cbo_ventas.Select();
            txt_telefono_destinatario.Text = "51";
            txt_telefono_remitente.Text = "51";
        }

        private void pic_volver_Click(object sender, EventArgs e)
        {
            Variables_Globales.llamar_formulario(formulario_hijo: new frm_opciones_delivery(), frm_papa: this);
        }

        private void btn_actualizar_envio_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_editar_envio '" + lbl_id_envio.Text + "','" + cbo_ventas.SelectedValue + "','" + txt_remitente_envio.Text + "','" + txt_dni_receptor.Text + "','" + txt_destinatario_envio.Text + "','" + txt_direccion_destinatario.Text + "','" + nud_costo_envio.Value + "','" + dtp_fec_env.Value.ToString("MM-dd-yyyy") + "','" + txt_nombre_receptor.Text + "','" + dtp_fec_rec.Value.ToString("MM-dd-yyyy") + "','" + cbo_empleado.SelectedValue + "','" + "En Tienda" + "','" + txt_telefono_destinatario.Text + "','" + txt_telefono_remitente.Text+ "','" + mtxt_envio_hora.Text.ToString()+"','"+cbo_tipo_comp.SelectedIndex.ToString() + "','" + cbo_cliente.SelectedValue + "','" + cbo_comp_imp.SelectedItem + "'", Variables_Globales.cadconex);
                DataTable dt = new DataTable(); da.Fill(dt); da.Dispose();
                if (MessageBox.Show("Cambios Guardados", "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    Variables_Globales.llamar_formulario(formulario_hijo: new frm_opciones_delivery(), frm_papa: this);
                    guia_envio envio = new guia_envio();
                    envio.Show();
                }
            }
            catch
            {

                Convert.ToByte(MessageBox.Show("Hubo un error en la Inserción de Datos", "Error en la Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error));
            }
        }

        private void txt_telefono_remitente_TextChanged(object sender, EventArgs e)
        {
            if (txt_telefono_remitente.Text.Substring(0, 5) == "(+51)")
            {
                                   
                txt_telefono_remitente.Mask = "(+00)000-000-000";
                if (txt_telefono_destinatario.Text.Length == 14)
                {
                    btn_actualizar_envio.Enabled = true;
                    btn_registrar_envio.Enabled = true;
                }
                else
                {
                    btn_actualizar_envio.Enabled = false;
                    btn_registrar_envio.Enabled = false;
                }
            }
            else {
                txt_telefono_remitente.Mask = "(+00)000-000-000-000-000-000";
                btn_registrar_envio.Enabled = true;
                btn_actualizar_envio.Enabled = true;
            
            }
        }

        private void txt_telefono_destinatario_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txt_telefono_destinatario_TextChanged(object sender, EventArgs e)
        {
            if (txt_telefono_destinatario.Text.Substring(0, 5) == "(+51)")
            {
                txt_telefono_destinatario.Mask = "(+00)000-000-000";
            }
            else
            {
                txt_telefono_destinatario.Mask = "(+00)000-000-000-000-000-000";

            }
        }

        private void txt_dni_receptor_TextChanged(object sender, EventArgs e)
        {
            txt_dni_receptor.MaxLength = 30;
        }

        private void Txt_telefono_remitente_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void Cbo_ventas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_ventas.SelectedIndex != -1)
            {
                btn_registrar_envio.Enabled = true;
            }
            else {
                btn_registrar_envio.Enabled = false;
            }
        }

        private void Cbo_tipo_comp_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                SqlDataAdapter da7 = new SqlDataAdapter("sp_listar_comprobantes '" + Convert.ToSByte(cbo_tipo_comp.SelectedIndex) + "'", Variables_Globales.cadconex);
                DataTable dt7 = new DataTable();
                da7.Fill(dt7);
                cbo_ventas.DataSource = dt7;
                cbo_ventas.DisplayMember = "Numero_Comprobante";
                cbo_ventas.ValueMember = "ID_Venta";
                da7.Dispose();
            }
            catch { }
        }

        private void Cbo_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_encontrar_nombre_cliente '" + cbo_cliente.SelectedValue + "'", Variables_Globales.cadconex);
                DataTable dt = new DataTable();
                da.Fill(dt);
                lbl_nom_cliente.Text = Convert.ToString(dt.Rows[0]["Nombre_Cliente"]);
                da.Dispose();
            }
            catch
            {
            }
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
