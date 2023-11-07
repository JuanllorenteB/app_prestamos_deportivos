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
    public class cls_roles
    {
        private string str_id;
        private string str_nombre;
        private string str_nomenclatura;
        


        cls_conexion objConectar = new cls_conexion();

        public void fnt_registrarrol(string id, string nombre, string nomenclatura)
        {
            if (id.Equals("") || nombre.Equals("") || nomenclatura.Equals("") )
            {
                MessageBox.Show("Debe ingresar todos los datos", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                SqlCommand con = new SqlCommand("SP_Rol", objConectar.connection);
                con.CommandType = CommandType.StoredProcedure;
                con.Parameters.AddWithValue("@id", id);
                con.Parameters.AddWithValue("@nombre", nombre);
                con.Parameters.AddWithValue("@nomenclatura", nomenclatura);

                objConectar.connection.Open();
                con.ExecuteNonQuery();
                objConectar.connection.Close();
                MessageBox.Show("Datos registrados con éxito", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
