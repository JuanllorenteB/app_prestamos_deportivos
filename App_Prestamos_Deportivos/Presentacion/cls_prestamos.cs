using Negocio;
using System;
using System.Data.SqlClient;
using System.Data;

namespace Presentacion
{
    internal class cls_prestamos
    {
        cls_Conexion objconect = new cls_Conexion();
        private string str_nombre;

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
        public string getNombre() { return str_nombre; }
    }
}