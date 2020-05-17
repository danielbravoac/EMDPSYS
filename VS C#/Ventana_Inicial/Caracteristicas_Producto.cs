using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventana_Inicial
{
    public partial class frm_caracteristicas_producto : Form
    {
        public frm_caracteristicas_producto()
        {
            InitializeComponent();
        }

        private void btn_categoria_Click(object sender, EventArgs e)
        {
            frm_categoria frm_caracteristica = new frm_categoria();
            AddOwnedForm(frm_caracteristica);
            frm_caracteristica.TopLevel = false;
            frm_caracteristica.FormBorderStyle = FormBorderStyle.Sizable;
            frm_caracteristica.Parent = this;
            frm_caracteristica.BringToFront();
            frm_caracteristica.Show();
        }

        private void btn_subcategoria_Click(object sender, EventArgs e)
        {
            frm_subcategoria frm_caracteristica = new frm_subcategoria();
            AddOwnedForm(frm_caracteristica);
            frm_caracteristica.TopLevel = false;
            frm_caracteristica.FormBorderStyle = FormBorderStyle.Sizable;
            frm_caracteristica.Parent = this;
            frm_caracteristica.BringToFront();
            frm_caracteristica.Show();

        }

        private void btn_familia_Click(object sender, EventArgs e)
        {            
            frm_familia frm_caracteristica = new frm_familia();
            AddOwnedForm(frm_caracteristica);
            frm_caracteristica.TopLevel = false;
            frm_caracteristica.FormBorderStyle = FormBorderStyle.Sizable;
            frm_caracteristica.Parent = this;
            frm_caracteristica.BringToFront();
            frm_caracteristica.Show();
        }

        private void btn_ocasion_Click(object sender, EventArgs e)
        {            
            frm_ocasion frm_caracteristica = new frm_ocasion();
            AddOwnedForm(frm_caracteristica);
            frm_caracteristica.TopLevel = false;
            frm_caracteristica.FormBorderStyle = FormBorderStyle.Sizable;
            frm_caracteristica.Parent = this;
            frm_caracteristica.BringToFront();
            frm_caracteristica.Show();
        }

        private void btn_color_Click(object sender, EventArgs e)
        {            
            frm_color frm_caracteristica = new frm_color();
            AddOwnedForm(frm_caracteristica);
            frm_caracteristica.TopLevel = false;
            frm_caracteristica.FormBorderStyle = FormBorderStyle.Sizable;
            frm_caracteristica.Parent = this;
            frm_caracteristica.BringToFront();
            frm_caracteristica.Show();
        }

        private void frm_caracteristicas_producto_FormClosed(object sender, FormClosedEventArgs e)
        {            
            
        }

        private void frm_caracteristicas_producto_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm_producto prod = new frm_producto();
            Lista_Tablas.llenar_categoria(prod.cbo_categoria);
            Lista_Tablas.llenar_subcategoria(prod.cbo_subcategoria, cbo_categoria: prod.cbo_categoria);
            Lista_Tablas.llenar_ocasion(prod.cbo_ocasion);
            Lista_Tablas.llenar_familia(prod.cbo_familia);
            Lista_Tablas.llenar_color(prod.cbo_color);
        }

        private void pic_volver_Click(object sender, EventArgs e)
        {
            Variables_Globales.llamar_formulario(frm_papa: this, formulario_hijo: new frm_opciones_producto());
        }
    }
}
