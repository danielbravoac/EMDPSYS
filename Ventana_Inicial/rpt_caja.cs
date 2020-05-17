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
    public partial class rpt_caja : Form
    {
        public rpt_caja()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        decimal tot = 0, tot_visa = 0, tot_master = 0, tot_efec = 0,tot_eg=0,tot_env=0;
        private void btn_generar_Click(object sender, EventArgs e)
        {

            tot = 0; tot_visa = 0; tot_master = 0; tot_efec = 0;  tot_eg = 0; tot_env = 0;
            Int32 c,cv,cm,cef,ceg,cen;
            //Cuota Inicial
            SqlDataAdapter da10 = new SqlDataAdapter("sp_filtrar_inicial '"+dtp_dia_cons.Value.ToString("MM-dd-yyyy")+"'", Variables_Globales.cadconex);
            DataTable dt10 = new DataTable();
            da10.Fill(dt10);
            nud_inicio_dia.Value = Convert.ToDecimal(dt10.Rows[0][2]);
            da10.Dispose();
            //Delivery
            SqlDataAdapter da8 = new SqlDataAdapter("sp_cuadrar_caja_envio '" + dtp_dia_cons.Value.ToString("MM-dd-yyyy") + "'", Variables_Globales.cadconex);
            DataTable dt8 = new DataTable();
            da8.Fill(dt8);
            for (cen = 0; cen <= dt8.Rows.Count - 1; cen++)
            {
                tot_env = tot_env + Convert.ToDecimal(dt8.Rows[cen]["Costo_Envio"]);
            }
            da8.Dispose();            
            //Egresos
            SqlDataAdapter da = new SqlDataAdapter("sp_cuadrar_egresos '" + dtp_dia_cons.Value.ToString("MM-dd-yyyy") + "'", Variables_Globales.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (ceg = 0; ceg <= dt.Rows.Count - 1; ceg++)
            {
                tot_eg = tot_eg + Convert.ToDecimal(dt.Rows[ceg]["Monto_Egreso"]);
            }
            da.Dispose();
            lbl_can_egre.Visible = true;
            lbl_can_egre.Text = dt.Rows.Count.ToString();
            lbl_egresos.Visible = true;
            lbl_egresos.Text = "S/. " + Math.Round(tot_eg, 2).ToString();

            //Total
            SqlDataAdapter da2 = new SqlDataAdapter("sp_cuadrar_caja '"+dtp_dia_cons.Value.ToString("MM-dd-yyyy")  + "'", Variables_Globales.cadconex);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            for (c = 0; c <= dt2.Rows.Count-1;c++) {
                tot = tot + Convert.ToDecimal(dt2.Rows[c]["TOTAL"]);
            }
            da2.Dispose();
            tot = tot + tot_efec;
            lbl_transacciones.Visible = true;
            lbl_transacciones.Text = dt2.Rows.Count.ToString();
            lbl_total.Visible = true;
            lbl_igv.Visible = true;
            lbl_neto.Visible = true;
            lbl_neto.Text="S/. " + Math.Round(tot+tot_env, 2).ToString();
            lbl_igv.Text = "S/. " + Math.Round(Convert.ToDouble(tot+tot_env) * 0.18,2).ToString();
            lbl_total.Text = "S/. "+Math.Round((tot+tot_env)- tot_eg,2).ToString();
            //Visa
            SqlDataAdapter da3 = new SqlDataAdapter("sp_cuadrar_caja_visa '" + dtp_dia_cons.Value.ToString("MM-dd-yyyy") + "','" + (dtp_dia_cons.Value.AddDays(1)).ToString("MM-dd-yyyy") + "'", Variables_Globales.cadconex);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            for (cv = 0; cv <= dt3.Rows.Count - 1; cv++)
            {
                tot_visa = tot_visa + Convert.ToDecimal(dt3.Rows[cv]["TOTAL"]);
            }
            da3.Dispose();
            lbl_visa.Visible = true;
            lbl_visa.Text = "S/. "+Math.Round(tot_visa, 2).ToString();

            //Mastercard
            SqlDataAdapter da4 = new SqlDataAdapter("sp_cuadrar_caja_mastercard '" + dtp_dia_cons.Value.ToString("MM-dd-yyyy") + "','" + (dtp_dia_cons.Value.AddDays(1)).ToString("MM-dd-yyyy") + "'", Variables_Globales.cadconex);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);
            for (cm = 0; cm <= dt4.Rows.Count - 1; cm++)
            {
                tot_master = tot_master + Convert.ToDecimal(dt4.Rows[cm]["TOTAL"]);
            }
            da4.Dispose();
            lbl_master.Visible = true;
            lbl_master.Text = "S/. " + Math.Round(tot_master, 2).ToString();

            //Efectivo
            SqlDataAdapter da5 = new SqlDataAdapter("sp_cuadrar_caja_efectivo '" + dtp_dia_cons.Value.ToString("MM-dd-yyyy") + "','" + (dtp_dia_cons.Value.AddDays(1)).ToString("MM-dd-yyyy") + "'", Variables_Globales.cadconex);
            DataTable dt5 = new DataTable();
            da5.Fill(dt5);
            for (cef = 0; cef <= dt5.Rows.Count - 1; cef++)
            {
                tot_efec = tot_efec + Convert.ToDecimal(dt5.Rows[cef]["TOTAL"]);
            }
            da5.Dispose();
            lbl_efe_caj.Visible = true;
            lbl_efectivo.Visible = true;
            lbl_efectivo.Text = "S/. " + Math.Round(tot_efec + tot_env, 2).ToString();
            lbl_efe_caj.Text = "S/. " + Math.Round(tot + tot_env - tot_eg, 2).ToString();
            lbl_caj_tot.Visible = true;
            lbl_caj_tot.Text = "S/. " + (Math.Round((nud_inicio_dia.Value + tot_efec + tot_env) - tot_eg, 2)).ToString();
            try
            {
                SqlDataAdapter da9 = new SqlDataAdapter("sp_actualizar_caja '" + Convert.ToDecimal(tot + tot_env) + "','" + Convert.ToDecimal(tot_eg) + "','" + Convert.ToDecimal((nud_inicio_dia.Value + tot_efec + tot_env) - tot_eg) + "','" + dtp_dia_cons.Value.ToString("MM-dd-yyyy") + "'", Variables_Globales.cadconex);
                DataTable dt9 = new DataTable();
                da9.Fill(dt9);
                da9.Dispose();
            }
            catch {

            }
        }
        private void nud_inicio_dia_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
