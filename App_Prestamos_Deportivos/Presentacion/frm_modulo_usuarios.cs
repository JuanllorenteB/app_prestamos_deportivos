using Negocio;
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

   

        private void frm_modulo_usuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbs_prestamos_deportivosnewDataSet.tbl_sexo' Puede moverla o quitarla según sea necesario.
            this.tbl_sexoTableAdapter2.Fill(this.dbs_prestamos_deportivosnewDataSet.tbl_sexo);
            // TODO: esta línea de código carga datos en la tabla 'dbs_prestamos_deportivosDataSet1.tbl_sexo' Puede moverla o quitarla según sea necesario.
            this.tbl_sexoTableAdapter1.Fill(this.dbs_prestamos_deportivosDataSet1.tbl_sexo);
            // TODO: esta línea de código carga datos en la tabla 'dbs_prestamos_deportivosDataSet.tbl_sexo' Puede moverla o quitarla según sea necesario.
            this.tbl_sexoTableAdapter.Fill(this.dbs_prestamos_deportivosDataSet.tbl_sexo);

        }

      

        private void materialButton3_Click(object sender, EventArgs e)
        {
            txt_id.Clear();
            txt_pnombre.Clear();
            txt_snombre.Clear();
            txt_papellido.Clear();
            txt_sapellido.Clear();
            txt_contacto.Clear();
            txt_correo.Clear();
            cbx_sexo.Items.Clear();
            txt_direccion.Clear();


        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            cls_modulo_usuarios obj_guardar = new cls_modulo_usuarios();

    
            string id = txt_id.Text;
            string pnombre = txt_pnombre.Text;
            string snombre = txt_snombre.Text;
            string papellido = txt_papellido.Text;
            string sapellido = txt_sapellido.Text;
            string sexo = cbx_sexo.Text; 
            string contacto = txt_contacto.Text;
            string correo = txt_correo.Text;
            string direccion = txt_direccion.Text;

            obj_guardar.fnt_guardarusuario(id, pnombre, snombre, papellido, sapellido, contacto, correo, direccion, sexo);

        }
    }
}
