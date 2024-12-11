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
    internal class ngestor
    {
        private cgestor x;
        public ngestor()
        {
            this.x = new cgestor();
        }
        public void insertar(string id, string nombre, string login, string acceso)
        {
            x.insert(new gestor(id, nombre, login, acceso));
        }
        public void actualizar(string id, string nombre, string login, string acceso)
        {
            x.update(new gestor(id, nombre, login, acceso));
        }
        public void eliminar(string id)
        {
            x.delete(new gestor(id, "","",""));
        }
        public void seleccionar(DataGridView datos)
        {
            x.select(datos);
        }
        public void seleccionar(ComboBox datos)
        {
            x.select(datos);
        }
        public void seleccionar(DataGridView datos, gestor dato)
        {
            x.select(datos, dato);
        }
        public void seleccionar(DataGridView datos, string dato)
        {
            x.select(datos);
        }
    }
}
