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
    public partial class FrmUsuarioCliente : Form
    {
        nusuario_cliente x = new nusuario_cliente();
        public FrmUsuarioCliente()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            x.actualizar(txtid.Text, txtnombre.Text, txtApellido.Text, Convert.ToDouble(txtSaldoActual.Text));
            x.seleccionar(dgvUsuarioCliente);
        }

        private void FrmUsuarioCliente_Load(object sender, EventArgs e)
        {
            x.seleccionar(dgvUsuarioCliente);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            x.eliminar(txtid.Text);
            x.seleccionar(dgvUsuarioCliente);
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            x.insertar(txtid.Text, txtnombre.Text, txtApellido.Text, Convert.ToDouble(txtSaldoActual.Text));
            x.seleccionar(dgvUsuarioCliente);
        }

        private void txtlogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
