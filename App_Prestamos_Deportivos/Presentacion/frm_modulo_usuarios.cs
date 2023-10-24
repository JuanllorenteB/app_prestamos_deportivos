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
    public partial class frm_modulo_usuarios : Form
    {
        public frm_modulo_usuarios()
        {
            InitializeComponent();
        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_modulo_usuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbs_prestamos_deportivosDataSet.tbl_sexo' Puede moverla o quitarla según sea necesario.
            this.tbl_sexoTableAdapter.Fill(this.dbs_prestamos_deportivosDataSet.tbl_sexo);

        }

        private void materialTextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialTextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
                
        }

        private void txt_sexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
