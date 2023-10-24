using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    internal class cls_conexion
    {
        public SqlConnection connection = new SqlConnection("Data Source=DESKTOP-6MUA0BA;Initial Catalog=dbs_prestamos_deportivos;Integrated Security=True");
    }
}
