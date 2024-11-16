using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace avancesssss
{
    public partial class Form1 : Form
    {
        // Diccionario para almacenar usuarios y contraseñas válidos
        private Dictionary<string, string> validUsers;

        public Form1()
        {
            InitializeComponent();
            InitializeValidUsers();
        }

        private void InitializeValidUsers()
        {
            // Inicializamos el diccionario con usuarios y contraseñas válidos
            validUsers = new Dictionary<string, string>
            {
                { "usuario1", "contraseña1" },
                { "usuario2", "contraseña2" },
                { "usuario3", "contraseña3" }
            };
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttom1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            // Verificamos si el usuario existe en el diccionario y si la contraseña es correcta
            if (validUsers.ContainsKey(username) && validUsers[username] == password)
            {
                new Form2().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Su nombre de usuario o contraseña son incorrectas, intente de nuevo, por favor.");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
