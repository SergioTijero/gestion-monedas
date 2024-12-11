using avancesssss.dao;
using avancesssss.vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace avancesssss
{
    public partial class Form2 : Form
    {
        private bool subButtonsVisible = false;
        private Form activeForm = null;

        public Form2()
        {
            InitializeComponent();
            InitializeSubButtons();
           
        }

        private void InitializeSubButtons()
        {
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            subButtonsVisible = !subButtonsVisible;

            
            if (subButtonsVisible)
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm.Dispose(); 
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }


        private void panelChild_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelo_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private void btnModificar_click(object sender, EventArgs e)
        {
            vistas.frmMonedas objMonedas = new vistas.frmMonedas();
            objMonedas.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Frmtransaccion x = new Frmtransaccion();
            x.Show();
        }

        private void frmRecarga_Click(object sender, EventArgs e)
        {
            FrmRecargaMoneda x = new FrmRecargaMoneda();
            x.Show();
        }

        private void frmUsuarioGestor_Click(object sender, EventArgs e)
        {
            FrmUsuariogestor1 x = new FrmUsuariogestor1();
            x.Show();
        }

        private void frmUsuarioCliente_Click(object sender, EventArgs e)
        {
            FrmUsuarioCliente x = new FrmUsuarioCliente();
            x.Show();
        }

        private void frmMoneda_Click(object sender, EventArgs e)
        {
            frmMonedas x = new frmMonedas();
            x.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
           
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void cerrarSesiónToolStripMenuItem_Click_1(object sender, EventArgs e)
        { 
            new Form1().Show();
            this.Hide();
        }
    }
}
