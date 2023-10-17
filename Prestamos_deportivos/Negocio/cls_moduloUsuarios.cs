using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    internal class cls_moduloUsuarios
    {
        private String str_id;
        private string str_pnombre;
        private string str_snombre;
        private string str_papellido;
        private string str_sapellido;
        private string str_contacto;
        private string str_correo;
        private string str_direccion;
        private string str_sexo;

        cls_conexion objConectar = new cls_conexion()

        public void fnt_guardar(String id,string p_nombre,String s_nombre,String p_apellido, string s_apellido,String contacto,String correo, string direccion, string sexo)
        {
            if ( id.Equals("")||p_nombre.Equals("")|| s_nombre.Equals("") || p_apellido.Equals("") || s_apellido.Equals("") ||contacto.Equals("") || correo.Equals("")  || 
                direccion.Equals("") || sexo.Equals(""))
            {
                MessageBox.show("Debe ingresar todos los datos", "Registro", MessageBoxButtons.OK, MessageBoxicon.Error);
            }
        }
    }
}
