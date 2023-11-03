using Negocio;
using System;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics.Contracts;
using System.Windows.Forms;

namespace Presentacion
{
    public class cls_prestamos
    {
        cls_Conexion objconect = new cls_Conexion();
        private string str_nombre;
        private string str_nombre_implemento;
        private string str_especificaciones;
        private int int_cantidad;
        private double flt_valor;

        public void fnt_consultar(string codigo)
        {

            SqlCommand con; SqlDataReader Lectura;
            con = new SqlCommand("SP_Consultarpersona", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@codigo", codigo);
            objconect.connection.Open();
            Lectura = con.ExecuteReader();
            if (Lectura.Read() == true)
            {
                str_nombre = Convert.ToString(Lectura[0]);


            }
            objconect.connection.Close();
        }
        public void fnt_consultar_implemento(string codigo)
        {

            SqlCommand con; SqlDataReader Lectura;
            con = new SqlCommand("SP_ConsultarImplemento", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@codigo", codigo);
            objconect.connection.Open();
            Lectura = con.ExecuteReader();
            if (Lectura.Read() == true)
            {
                str_nombre_implemento = Convert.ToString(Lectura[0]);
                str_especificaciones = Convert.ToString(Lectura[1]);
                int_cantidad = Convert.ToInt16(Lectura[2]);
                flt_valor = Convert.ToDouble(Lectura[3]);


            }

            objconect.connection.Close();

        }
        
        public void fnt_prestamo(string id, string user)
        {
            SqlCommand con = new SqlCommand("SP_GenerarPersonas", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@id", id);
            con.Parameters.AddWithValue("@user", user);
            objconect.connection.Open();
            con.ExecuteNonQuery();
            objconect.connection.Close();
            MessageBox.Show("prestamo registrada con éxito", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void fnt_det_prestamo(string cod_implemento, int cantidad)
        {
            SqlCommand con = new SqlCommand("SP_GenerarPersonas", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@cod_implemento", cod_implemento);
            con.Parameters.AddWithValue("@cantidad", cantidad);
            objconect.connection.Open();
            con.ExecuteNonQuery();
            objconect.connection.Close();
            
        }

            public string getNombre() { return this.str_nombre; }

            public string getNombreImplemento() { return this.str_nombre_implemento; }

           public string getEspecificaciones() { return this.str_especificaciones; }

            public int getCantidad() { return this.int_cantidad; }

             public double getValor() { return this.flt_valor; }

      
    }
}