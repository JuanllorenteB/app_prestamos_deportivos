using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frm_modulo_sexo : Form
    {
        public frm_modulo_sexo()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            txt_descripcion.Clear();
            txt_id.Clear();
            txt_nomenclatura.Clear();
            txt_id.Focus();
        }
    }
}
