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
    public partial class FrmUsuariogestor1 : Form
    {
        ngestor x = new ngestor();
        public FrmUsuariogestor1()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            x.actualizar(txtid2.Text, txtnombre2.Text, txtlogin.Text, txtAcceso.Text);
            x.seleccionar(dgvUsuarioGestor);
        }

        private void Frmgestor1_Load(object sender, EventArgs e)
        {
            x.seleccionar(dgvUsuarioGestor);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            x.eliminar(txtid2.Text);
            x.seleccionar(dgvUsuarioGestor);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            x.insertar(txtid2.Text, txtnombre2.Text, txtlogin.Text, txtAcceso.Text);
            x.seleccionar(dgvUsuarioGestor);
        }

        private void dgvUsuarioGestor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
                
        }
    }    
}
