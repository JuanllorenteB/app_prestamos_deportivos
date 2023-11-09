using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    internal static class Inicio
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
       
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_prestamo());
            Application.Run(new frm_implementos());
            Application.Run(new frm_modulo_estado());
            Application.Run(new frm_modulo_login());
            Application.Run(new frm_modulo_roles());
            Application.Run(new frm_modulo_sexo());
            Application.Run(new frm_modulo_usuarios());
        }
    }
}
