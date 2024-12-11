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
    public partial class frmMonedas : Form
    {
        nmoneda x = new nmoneda();
        public frmMonedas()
        {
            InitializeComponent();

        }

        private void frmMonedas_Load(object sender, EventArgs e)
        {
            x.seleccionar(dgvListaMonedas);

        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            x.actualizar(txtIdMoneda.Text, txtNombreMoneda.Text, Convert.ToDouble(txtPrecioActual.Text), Convert.ToInt32(txtCantidad.Text));
            x.seleccionar(dgvListaMonedas);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            x.insertar(txtIdMoneda.Text, txtNombreMoneda.Text, Convert.ToDouble(txtPrecioActual.Text), Convert.ToInt32(txtCantidad.Text));
            x.seleccionar(dgvListaMonedas);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            x.eliminar(txtIdMoneda.Text);
            x.seleccionar(dgvListaMonedas);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dgvListaMonedas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
