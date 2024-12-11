using avancesssss.controlador;
using avancesssss.negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace avancesssss.vistas
{
    public partial class FrmRecargaMoneda : Form
    {
        nrecarga_moneda x = new nrecarga_moneda();
        public FrmRecargaMoneda()
        {
            InitializeComponent();
           
        }

        private void FrmRecargaMoneda_Load(object sender, EventArgs e)
        {
            x.seleccionar(dataGridView1);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            x.actualizar(txtidrecarga.Text, txtidmoneda.Text, dtpFecha.Value, Convert.ToDouble(txtCantidadRecarga.Text));
            x.seleccionar(dataGridView1);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            x.insertar(txtidrecarga.Text, txtidmoneda.Text, dtpFecha.Value, Convert.ToDouble(txtCantidadRecarga.Text));
            x.seleccionar(dataGridView1);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            x.eliminar(txtidrecarga.Text);
            x.seleccionar(dataGridView1);
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
