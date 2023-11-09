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
    public partial class frm_prestamo : Form
    {
        public frm_prestamo()
        {
            InitializeComponent();
        }

        private void txt_descripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_prestamo_Load(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            txt_id.Focus();
            txt_id.Clear();
            txt_codigo.Clear();
            txt_descripcion.Clear();
            txt_cantidad_prestamo.Clear();
            txt_observaciones.Clear();
            txt_nombre_implemento.Clear();
            txt_nombre.Clear();
            dtg_prestamo.DataSource = null;

        }

        private void txt_id_KeyUp(object sender, KeyEventArgs e)
        {
           if (e.KeyCode == Keys.Enter)
            {
                cls_prestamos objConsutarP = new cls_prestamos();
                objConsutarP.fnt_consultarprestamo(txt_id.Text);
                txt_nombre.Text = objConsutarP.getNombre();
            }
        }

        private void btn_prestamo_Click(object sender, EventArgs e)
        {
            cls_prestamos obj_prestar = new cls_prestamos();

            obj_prestar.fnt_prestamo(txt_id.Text, "1001.JuanLópez");
                for(int i=0; i < dtg_prestamo.Rows.Count; i++)
            {
                obj_prestar.fnt_det_prestamos(Convert.ToString(dtg_prestamo.Rows[i].Cells[0].Value),
                    Convert.ToInt16(dtg_prestamo.Rows[i].Cells[1].Value));
            }
        }

        private void txt_codigo_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                cls_prestamos objConsultar = new cls_prestamos();
                objConsultar.fnt_consultarimplemento(txt_codigo.Text);
                txt_existencia.Text = "" + objConsultar.getCantidad();
                txt_nombre_implemento.Text = objConsultar.getNombreImplemento();
                txt_descripcion.Text = objConsultar.getEspecificaciones();
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(txt_cantidad_prestamo.Text)<= Convert.ToInt16(txt_existencia.Text)) {
                dtg_prestamo.Rows.Add(
                    txt_codigo.Text,
                    txt_cantidad_prestamo.Text);
            }else
            {
                MessageBox.Show("No puedes superar la cantidad de existencias","Agregar",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void dtg_prestamo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
