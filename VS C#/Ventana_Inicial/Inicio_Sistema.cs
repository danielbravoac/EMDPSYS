using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Ventana_Inicial
{
    public partial class Inicio_Sistema : Form
    {
        public Inicio_Sistema()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void pic_cerrar_Click(object sender, EventArgs e)
        {
            ;
            if (MessageBox.Show("¿Salir del Sistema?", "Cierre de Aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes) {
                Application.Exit();
            }
            
        }

        private void pic_maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pic_normal.Visible = true;
            pic_maximizar.Visible = false;
            if (this.Width == 1024)
            {
                pnl_contenedor.Width = 980;
                pnl_menu_vertical.Width = 40;

            }
        }

        private void pic_normal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pic_normal.Visible = false;
            pic_maximizar.Visible = true;
            pnl_contenedor.Width = 1050;
            pnl_menu_vertical.Width = 250;
        }

        private void pic_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnl_barra_titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void abrir_formulario(object formulario_hijo) {
            if (this.pnl_contenedor.Controls.Count > 0)
                this.pnl_contenedor.Controls.RemoveAt(0);
            Form fh = formulario_hijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnl_contenedor.Controls.Add(fh);
            this.pnl_contenedor.Tag = fh;
            fh.Show();
        
        }

        private void btn_productos_Click(object sender, EventArgs e)
        {
            abrir_formulario(new frm_opciones_producto());
        }
        private void btn_ventas_Click(object sender, EventArgs e)
        {
            abrir_formulario(new frm_opciones_venta());
        }

        private void btn_delivery_Click(object sender, EventArgs e)
        {
            abrir_formulario(new frm_opciones_delivery());
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            abrir_formulario(new frm_control_cliente());
        }

        private void btn_proveedores_Click(object sender, EventArgs e)
        {
            abrir_formulario(new frm_opciones_proveedor());
        }

        private void btn_empleados_Click(object sender, EventArgs e)
        {
            abrir_formulario(new frm_opciones_empleado());
        }

        private void btn_egresos_Click(object sender, EventArgs e)
        {
            abrir_formulario(new frm_opciones_egresos());
        }

        private void btn_reportes_Click(object sender, EventArgs e)
        {
            abrir_formulario(new frm_reportes());
        }

        private void Inicio_Sistema_Load(object sender, EventArgs e)
        {
            if (Variables_Globales.nivel_seg == 1)
            {
                lbl_cargo.Text = "Empleado";
                btn_productos.Visible = false;
                btn_proveedores.Visible= false;
                btn_egresos.Visible = false;
                btn_reportes.Visible = false;
                btn_empleados.Visible = false;

            }
            else if (Variables_Globales.nivel_seg == 2)
            {
                lbl_cargo.Text = "Administrador";
            }
        }

        private void lbl_id_user_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pnl_barra_titulo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
