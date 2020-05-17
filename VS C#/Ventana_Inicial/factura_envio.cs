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
    public partial class factura_envio : Form
    {
        public factura_envio()
        {
            InitializeComponent();
        }

        private void factura_envio_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'EMDP_DBDataSet3.sp_guia_envio' Puede moverla o quitarla según sea necesario.
            this.sp_guia_envioTableAdapter.Fill(this.EMDP_DBDataSet3.sp_guia_envio,Variables_Globales.envio);

            this.reportViewer1.RefreshReport();
        }
    }
}
