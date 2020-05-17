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
    public partial class frm_control_empleado : Form
    {
        
        public frm_control_empleado()
        {
            InitializeComponent();
        }

        private void frm_control_empleado_Load(object sender, EventArgs e)
        {
            cbo_buscar_emp.SelectedIndex = 0;
            Lista_Tablas.listar_empleados(dgv_control_empleado);
        }

        private void btn_registrar_empleado_Click(object sender, EventArgs e)
        {
            frm_empleado frm_empleado = new frm_empleado();
            AddOwnedForm(frm_empleado);
            frm_empleado.TopLevel = false;
            frm_empleado.Dock = DockStyle.Fill;
            this.Controls.Add(frm_empleado);
            this.Tag = frm_empleado;
            frm_empleado.BringToFront();
            frm_empleado.Show();
            frm_empleado.lbl_control_empleado.Text = "Nuevo Empleado";
            frm_empleado.btn_actualizar_empleado.Visible = false;
        }

        private void btn_editar_empleado_Click(object sender, EventArgs e)
        {
            frm_empleado frm_empleado = new frm_empleado();
            AddOwnedForm(frm_empleado);
            frm_empleado.TopLevel = false;
            frm_empleado.Dock = DockStyle.Fill;
            this.Controls.Add(frm_empleado);
            this.Tag = frm_empleado;
            frm_empleado.BringToFront();
            frm_empleado.Show();
            frm_empleado.lbl_control_empleado.Text = "Editar Empleado";
            frm_empleado.btn_registrar_empleado.Visible = false;
            Variables_Globales.limpiar_controles(frm_empleado);
            frm_empleado.lbl_id_empleado.Text = dgv_control_empleado.CurrentRow.Cells[0].Value.ToString();
            frm_empleado.txt_dni_empleado.Text = dgv_control_empleado.CurrentRow.Cells[1].Value.ToString();
            frm_empleado.txt_nombre_empleado.Text = dgv_control_empleado.CurrentRow.Cells[2].Value.ToString();
            frm_empleado.dtp_nacimiento.Value = Convert.ToDateTime(dgv_control_empleado.CurrentRow.Cells[3].Value);
            frm_empleado.dtp_contrato.Value = Convert.ToDateTime(dgv_control_empleado.CurrentRow.Cells[4].Value);
            frm_empleado.nud_sueldo.Value = Convert.ToDecimal(dgv_control_empleado.CurrentRow.Cells[5].Value);
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(dgv_control_empleado.CurrentRow.Cells[6].Value.ToString());
            //result = System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            frm_empleado.txt_contrasena.Text =result;
            frm_empleado.cbo_nivel_seguridad.SelectedValue = dgv_control_empleado.CurrentRow.Cells[7].Value;

            frm_empleado.cbo_sexo.SelectedItem = dgv_control_empleado.CurrentRow.Cells[8].Value.ToString();
            frm_empleado.cbo_estado_empleado.SelectedItem = dgv_control_empleado.CurrentRow.Cells[9].Value.ToString();
            frm_empleado.cbo_cargo.SelectedItem = dgv_control_empleado.CurrentRow.Cells[10].Value.ToString();            
        }

        private void txt_buscar_pro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_buscar_empleado '" + cbo_buscar_emp.SelectedIndex + "','" + txt_buscar_emp.Text + "'", Variables_Globales.cadconex);
                DataTable dt = new DataTable();
                dgv_control_empleado.DataSource = dt;
                da.Fill(dt);
                
            }
            catch
            {

                
            }
        }
    }
}
