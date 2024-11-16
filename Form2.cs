using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
       
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            subButtonsVisible = !subButtonsVisible;
            button2.Visible = subButtonsVisible;
            button3.Visible = subButtonsVisible;
            button4.Visible = subButtonsVisible;

            
            if (subButtonsVisible)
            {
                button2.Location = new Point(button1.Location.X, button1.Location.Y + button1.Height + 5);
                button3.Location = new Point(button1.Location.X, button2.Location.Y + button2.Height + 5);
                button4.Location = new Point(button1.Location.X, button3.Location.Y + button3.Height + 5);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new Form4());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new Form5());
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
    }
}
