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
    internal class nmoneda
    {
        private cmoneda x;
        public nmoneda()
        {
            this.x = new cmoneda();
        }
        public void insertar(string id_moneda, string nombre_moneda, double precio_actual,  int cantidad)
        {
            x.insert(new moneda(id_moneda, nombre_moneda, precio_actual, cantidad));
        }
        public void actualizar(string id_moneda, string nombre_moneda, double precio_actual, int cantidad)
        {
            x.update(new moneda(id_moneda, nombre_moneda, precio_actual, cantidad));
        }
        public void eliminar(string id_moneda)
        {
            x.delete(new moneda(id_moneda, "", 0, 0));
        }
        public void seleccionar(DataGridView datos)
        {
            x.select(datos);
        }
        public void seleccionar(ComboBox datos)
        {
            x.select(datos);
        }
        public void seleccionar(DataGridView datos, moneda dato)
        {
            x.select(datos, dato);
        }
        public void seleccionar(DataGridView datos, string dato)
        {
            x.select(datos, dato);
        }
    }
}
