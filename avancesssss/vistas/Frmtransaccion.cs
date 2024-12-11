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
    public partial class Frmtransaccion : Form
    {
        ntransaccion x = new ntransaccion();
        public Frmtransaccion()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dgvTransaccion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            x.insertar(txtIdTransaccion.Text, txtIdMoneda.Text, txtIdUserGestor.Text, txtIdUserCliente.Text, dtpFecha2.Value, Convert.ToDouble(txtPrecioVenta.Text), Convert.ToDouble(txtCantidad.Text));
            x.seleccionar(dgvTransaccion);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            x.actualizar(txtIdTransaccion.Text, txtIdMoneda.Text, txtIdUserGestor.Text, txtIdUserCliente.Text, dtpFecha2.Value, Convert.ToDouble(txtPrecioVenta.Text), Convert.ToDouble(txtCantidad.Text));
            x.seleccionar(dgvTransaccion);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            x.eliminar(txtIdTransaccion.Text);
            x.seleccionar(dgvTransaccion);
        }

        private void Frmtransaccion_Load(object sender, EventArgs e)
        {
            x.seleccionar(dgvTransaccion);
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
