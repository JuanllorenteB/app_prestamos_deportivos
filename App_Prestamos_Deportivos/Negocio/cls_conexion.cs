using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    internal class cls_conexion
    {
        public SqlConnection connection = new SqlConnection("Data Source=DESKTOP-6MU0BAA;Initial Catalog=dbs_prestamos_deportivosnew;Integrated Security=True");
    }
}

