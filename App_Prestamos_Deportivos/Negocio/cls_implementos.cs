using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Negocio
{
    public class cls_implementos
    {
        private string str_codigo;
        private string str_nombre;
        private string str_descripcion;
        private float flt_precio;
        private int int_cantidad;
        cls_conexion objconect = new cls_conexion();

        public void fnt_registrar(string codigo, string nombre, string descripcion, float precio, int cantidad)
        {
            SqlCommand con = new SqlCommand("SP_GuardarCliente", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@codigo", codigo);
            con.Parameters.AddWithValue("@nombre", nombre);
            con.Parameters.AddWithValue("@descripcion", descripcion);
            con.Parameters.AddWithValue("@precio", precio);
            con.Parameters.AddWithValue("@cantidad", cantidad);
            objconect.connection.Open();
            con.ExecuteNonQuery();
            objconect.connection.Close();
            MessageBox.Show("Implemento registrado con exito", "Registrar", MessageBoxButtons.OK , MessageBoxIcon.Error);
        }
    }
}
