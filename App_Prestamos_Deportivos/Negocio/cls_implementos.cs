using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data.SqlClient;
using System.Data;
using System.Xml.Linq;
using System.Windows.Forms;

namespace Negocio
{
    public class cls_implementos
    {
        private String str_codigo;
        private String str_nombre;
        private String str_especificaciones;
        private double flt_precio;
        private int int_cantidad;
        cls_conexion objconect = new cls_conexion();

        public void fnt_registrar(string codigo, string nombre, string especificaciones, double precio, int cantidad)
        {
            SqlCommand con = new SqlCommand("SP_Agregar_Implementos", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@codigo", codigo);
            con.Parameters.AddWithValue("@nombre", nombre);
            con.Parameters.AddWithValue("@especificaciones", especificaciones);
            con.Parameters.AddWithValue("@cantidad", cantidad);
            con.Parameters.AddWithValue("@valor", precio);
            objconect.connection.Open();
            con.ExecuteNonQuery();
            objconect.connection.Close();
            MessageBox.Show("Implemento registrado con éxito", "Registrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void fnt_consultar(string codigo)
        {
            SqlCommand con; SqlDataReader Lectura;
            con = new SqlCommand("SP_Consultar_Implemento", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@codigo", codigo);
            objconect.connection.Open();
            Lectura = con.ExecuteReader();
            if (Lectura.Read() == true)
            {
                str_nombre = Convert.ToString(Lectura[0]);
                str_especificaciones = Convert.ToString(Lectura[1]);
                flt_precio = Convert.ToDouble(Lectura[3]);
                int_cantidad = Convert.ToInt32(Lectura[2]);
            }
            objconect.connection.Close();
        }

        public void fnt_actualizar(string codigo, string nombre, string especificaciones, double precio, int cantidad)
        {
            SqlCommand con = new SqlCommand("SP_Actualizar_Implementos", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@codigo", codigo);
            con.Parameters.AddWithValue("@nombre", nombre);
            con.Parameters.AddWithValue("@especificaciones", especificaciones);
            con.Parameters.AddWithValue("@cantidad", cantidad);
            con.Parameters.AddWithValue("@valor", precio);
            objconect.connection.Open();
            con.ExecuteNonQuery();
            objconect.connection.Close();
            MessageBox.Show("Implemento actualizado con éxito", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public string getNombre() { return this.str_nombre; }
        public string getEspecificaciones() { return this.str_especificaciones; }
        public int getCantidad() { return this.int_cantidad; }
        public double getValor() { return this.flt_precio; }
    }
}