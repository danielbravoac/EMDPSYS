using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ventana_Inicial
{
    class Lista_Tablas
    {
        //Envio
        public static void listar_envio(DataGridView dgv)
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_listar_envio", Variables_Globales.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
            dgv.Columns[6].DefaultCellStyle.Format = "C2";
            da.Dispose();

        }
        //Venta
        public static void listar_venta(DataGridView dgv)
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_listar_venta", Variables_Globales.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
            dgv.Columns[12].DefaultCellStyle.Format = "C2";
            dgv.Columns[13].DefaultCellStyle.Format = "C2";
            da.Dispose();

        }
        public static void llenar_venta(ComboBox cbo)
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_listar_venta", Variables_Globales.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbo.DataSource = dt;
            cbo.DisplayMember = "Numero_Comprobante";
            cbo.ValueMember = "ID_Venta";
            da.Dispose();

        }
        //Descuentos
        public static void listar_descuentos(DataGridView dgv)
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_listar_descuento", Variables_Globales.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
            dgv.Columns[0].Visible = true;
            dgv.Columns[1].Visible = true;
            dgv.Columns[2].Visible = true;
            dgv.Columns[3].Visible = true;
            dgv.Columns[4].Visible = false;
            dgv.Columns[5].Visible = true;
            dgv.Columns[2].DefaultCellStyle.Format = "C2";
            da.Dispose();

        }
        //Bonos
        public static void listar_bonos(DataGridView dgv)
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_listar_bono", Variables_Globales.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
            dgv.Columns[0].Visible = true;
            dgv.Columns[1].Visible = true;
            dgv.Columns[2].Visible = true;
            dgv.Columns[3].Visible = true;
            dgv.Columns[4].Visible = false;
            dgv.Columns[5].Visible = true;
            dgv.Columns[2].DefaultCellStyle.Format = "C2";
            da.Dispose();

        }
        //Egresos
        public static void listar_egresos(DataGridView dgv)
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_listar_egreso", Variables_Globales.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
            dgv.Columns[2].DefaultCellStyle.Format = "C2";
            da.Dispose();

        }
        //Empleado
        public static void listar_empleados(DataGridView dgv)
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_listar_empleado", Variables_Globales.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
            dgv.Columns[5].DefaultCellStyle.Format = "C2";
            da.Dispose();

        }
        public static void llenar_empleado(ComboBox cbo)
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_listar_empleado", Variables_Globales.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbo.DataSource = dt;
            cbo.DisplayMember = "Numero_Documento_Empleado";
            cbo.ValueMember = "ID_Empleado";
            
            da.Dispose();

        }
        //Nivel de Seguridad
        public static void listar_nseg(DataGridView dgv)
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_listar_nseg", Variables_Globales.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
            da.Dispose();

        }
        public static void llenar_nseguridad(ComboBox cbo)
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_listar_nseg", Variables_Globales.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbo.DataSource = dt;
            cbo.DisplayMember = "Nivel";
            cbo.ValueMember = "ID_Nivel_Seguridad";
            da.Dispose();

        }
        //Proveedor
        public static void listar_proveedores(DataGridView dgv)
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_listar_proveedor", Variables_Globales.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
            da.Dispose();

        }
        //Cliente
        public static void listar_clientes(DataGridView dgv)
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_listar_cliente", Variables_Globales.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
            da.Dispose();

        }
        public static void llenar_cliente(ComboBox cbo)
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_listar_cliente", Variables_Globales.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbo.DataSource = dt;
            cbo.DisplayMember = "Numero_Documento";
            cbo.ValueMember = "ID_Cliente";
            da.Dispose();

        }
        //Productos
        public static void listar_productos(DataGridView dgv)
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_listar_producto", Variables_Globales.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);            
            dgv.DataSource = dt;
            dgv.Columns[7].Visible = false;
            dgv.Columns[8].Visible = false;
            dgv.Columns[9].Visible = false;
            dgv.Columns[10].Visible = false;
            dgv.Columns[11].Visible = false;
            dgv.Columns[5].DefaultCellStyle.Format = "C2";
            da.Dispose();

        }
        public static void llenar_producto(ComboBox cbo)
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_listar_producto", Variables_Globales.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbo.DataSource = dt;
            cbo.DisplayMember = "Codigo_Producto";
            cbo.ValueMember = "ID_Producto";
            da.Dispose();

        }
        //Categoria
        public static void listar_categoria(DataGridView dgv)
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_listar_categoria", Variables_Globales.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
            da.Dispose();
        }
        public static void llenar_categoria(ComboBox cbo)
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_listar_categoria", Variables_Globales.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbo.DataSource = dt;
            cbo.DisplayMember = "Nombre_Categoria";
            cbo.ValueMember = "ID_Categoria";
            da.Dispose();

        }
        //Subcategoria
        public static  void listar_subcategoria(DataGridView dgv)
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_listar_subcategoria", Variables_Globales.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
            dgv.Columns[0].Visible = true;
            dgv.Columns[1].Visible = true; 
            dgv.Columns[2].Visible = false;
            dgv.Columns[3].Visible = true; 
            da.Dispose();
        }
        public static void llenar_subcategoria(ComboBox cbo,ComboBox cbo_categoria)
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_listar_subcategoria_categoria '"+Convert.ToInt16(cbo_categoria.SelectedIndex+1)+"'", Variables_Globales.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbo.DataSource = dt;
            cbo.DisplayMember = "Nombre_Subcategoria";
            cbo.ValueMember = "ID_Subcategoria";
            da.Dispose();
        }
        //Familia
        public static void listar_familia(DataGridView dgv)
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_listar_familia", Variables_Globales.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
            da.Dispose();
        }
        public static void llenar_familia(ComboBox cbo)
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_listar_familia", Variables_Globales.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbo.DataSource = dt;
            cbo.DisplayMember = "Nombre_Familia";
            cbo.ValueMember = "ID_Familia";
            da.Dispose();
        }
        //Color
        public static void listar_color(DataGridView dgv)
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_listar_color", Variables_Globales.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
            da.Dispose();
        }
        public static void llenar_color(ComboBox cbo)
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_listar_color", Variables_Globales.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbo.DataSource = dt;
            cbo.DisplayMember = "Nombre_Color";
            cbo.ValueMember = "ID_Color";
            da.Dispose();
        }
        //Ocasion
        public static void listar_ocasion(DataGridView dgv)
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_listar_ocasion", Variables_Globales.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
            da.Dispose();
        }

        public static void llenar_ocasion(ComboBox cbo)
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_listar_ocasion", Variables_Globales.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbo.DataSource = dt;
            cbo.DisplayMember = "Nombre_Ocasion";
            cbo.ValueMember = "ID_Ocasion";
            da.Dispose();
        }
        public static void listar_pedido(DataGridView dgv)
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_listar_pedido", Variables_Globales.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
            dgv.Columns[4].DefaultCellStyle.Format = "C2";
            dgv.Columns[6].DefaultCellStyle.Format = "C2";
            da.Dispose();
        }
        public static void llenar_proveedor(ComboBox cbo)
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_listar_proveedor", Variables_Globales.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbo.DataSource = dt;
            cbo.DisplayMember = "Nombre_Comercial_Proveedor";
            cbo.ValueMember = "ID_Proveedor";
            da.Dispose();
        }
        public static void listar_devolucion(DataGridView dgv)
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_listar_devolucion", Variables_Globales.cadconex);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
            dgv.Columns[0].Visible = true;
            dgv.Columns[1].Visible = true;
            dgv.Columns[2].Visible = false;
            dgv.Columns[3].Visible = true; 
            da.Dispose();
        }
       
        
    }

}
