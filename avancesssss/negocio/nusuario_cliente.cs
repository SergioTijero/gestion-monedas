using avancesssss.controlador;
using avancesssss.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace avancesssss.negocio
{
    internal class nusuario_cliente
    {
        private cusuario_cliente x;
        public nusuario_cliente()
        {
            this.x = new cusuario_cliente();
        }
        public void insertar(string id, string nombres, string apellidos, double saldo_actual)
        {
            x.insert(new usuario_cliente(id, nombres, apellidos, saldo_actual));
        }
        public void actualizar(string id, string nombres, string apellidos, double saldo_actual)
        {
            x.update(new usuario_cliente(id, nombres, apellidos, saldo_actual));
        }
        public void eliminar(string id)
        {
            x.delete(new usuario_cliente(id,"", "",0));
        }
        public void seleccionar(DataGridView datos)
        {
            x.select(datos);
        }
        public void seleccionar(ComboBox datos)
        {
            x.select(datos);
        }
        public void seleccionar(DataGridView datos, usuario_cliente dato)
        {
            x.select(datos, dato);
        }
        public void seleccionar(DataGridView datos, string dato)
        {
            x.select(datos);
        }
    }
}
