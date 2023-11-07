using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;
using System.Windows.Forms;
using System.Collections.Specialized;

namespace Negocio
{
    public class cls_prestamos
    {
        private string str_nombre;
        cls_conexion objconect = new cls_conexion();
        private string str_nombre_implemento;
        private string str_especificaciones;
        private int int_cantidad;
        private double flt_valor;


        public void fnt_consultarprestamo(string codigo)
        {
            SqlCommand con; SqlDataReader Lectura;
            con = new SqlCommand("SP_Consultar_Persona", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@id", codigo);
            objconect.connection.Open();
            Lectura = con.ExecuteReader();
            if (Lectura.Read() == true)
            {
                str_nombre = Convert.ToString(Lectura[0]);

            }
            objconect.connection.Close();
        }

        public void fnt_consultarimplemento(string codigo)
        {
            SqlCommand con; SqlDataReader Lectura;
            con = new SqlCommand("SP_Consultar_Implemento", objconect.connection);
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
            SqlCommand con = new SqlCommand("SP_GenerarPrestamo", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@id_persona", id);
            con.Parameters.AddWithValue("@user", user);
            objconect.connection.Open();
            con.ExecuteNonQuery();
            objconect.connection.Close();
            MessageBox.Show("Prestamo registrado con éxito", "Prestamo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void fnt_det_prestamos(string cod_implemento, int cantidad)
        {
            SqlCommand con = new SqlCommand("SP_Generardetprestamo", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@cod_implemento", cod_implemento);
            con.Parameters.AddWithValue("@cantidad", cantidad);
            objconect.connection.Open();
            con.ExecuteNonQuery();
            objconect.connection.Close();
            MessageBox.Show("Prestamo registrado con éxito", "Prestamo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public string getNombre() { return this.str_nombre; }
        public string getNombreImplemento() { return this.str_nombre_implemento; }
        public string getEspecificaciones() { return this.str_especificaciones; }
        public int getCantidad() { return this.int_cantidad; }
        public double getValor() { return this.flt_valor; }


    }
}
