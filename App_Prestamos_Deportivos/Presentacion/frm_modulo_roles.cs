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
    public partial class frm_modulo_roles : Form
    {
        public frm_modulo_roles()
        {
            InitializeComponent();
        }

       

        private void materialButton2_Click(object sender, EventArgs e)
        {
            txt_id.Focus();
            txt_id.Clear();
            txt_nomenclatura.Clear();
            txt_nombre.Clear();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                cls_roles obj_guardar = new cls_roles();
                obj_guardar.fnt_registrarrol(
                    txt_id.Text,
                    txt_nomenclatura.Text,
                    txt_nombre.Text
                );
         
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar el rol: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
        }
    }
}
