using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio
{
    public class cls_modulo_usuarios
    {
       
        private string str_pnombre;
        private string str_snombre;
        private string str_papellido;
        private string str_sapellido;
        private string str_contacto;
        private string str_correo;
        private string str_direccion;
        private string str_sexo;



        cls_conexion objConectar = new cls_conexion();

        public void fnt_guadar (string id, string pnombre, string snombre, string papellido, string sapellido,
            string contacto, string correo, string direccion, string sexo, MessageBox messageBox)
        {
            if (id.Equals("") || pnombre.Equals("") || snombre.Equals("") || papellido.Equals("") || sapellido.Equals("") ||
                contacto.Equals("") || correo.Equals("") || direccion.Equals(""))
            {
                MessageBox.Show("Debe ingresar todos los datos", "Registro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
               
                SqlCommand con = new SqlCommand("SP_Registrar_Personas", objConectar.connection);
                con.CommandType = CommandType.StoredProcedure;
                con.Parameters.AddWithValue("@id", id);
                con.Parameters.AddWithValue("@p_nombre", pnombre);
                con.Parameters.AddWithValue("@s_nombre", snombre);
                con.Parameters.AddWithValue("@p_apellido", papellido);
                con.Parameters.AddWithValue("@s_apellido", sapellido);
                con.Parameters.AddWithValue("@contacto", contacto);
                con.Parameters.AddWithValue("@direccion",direccion);
                con.Parameters.AddWithValue("@sexo", sexo);
                con.Parameters.AddWithValue("@correo", correo);
                objConectar.connection.Open();
                con.ExecuteNonQuery();
                objConectar.connection.Close();
                MessageBox.Show("Datos registrados con éxito", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

    }
}
