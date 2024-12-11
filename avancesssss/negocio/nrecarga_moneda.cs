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
    internal class nrecarga_moneda
    {
            private crecarga_moneda x;
            public nrecarga_moneda(){
                this.x = new crecarga_moneda();
            
            }
            public void insertar(string id_Recarga, string id_Moneda, DateTime fecha, double cantidad_recarga )
            {
                x.insert(new recarga_moneda(id_Recarga, id_Moneda, fecha, cantidad_recarga));
            }
            public void actualizar(string id_Recarga, string id_Moneda, DateTime fecha, double cantidad_recarga)
            {
                x.update(new recarga_moneda(id_Recarga, id_Moneda, fecha, cantidad_recarga));
            }
            public void eliminar(string id_Recarga)
            {
                x.delete(new recarga_moneda(id_Recarga, "", DateTime.MinValue, 0));
            }
            public void seleccionar(DataGridView datos)
            {
                x.select(datos);
            }
            public void seleccionar(ComboBox datos)
            {
                x.select(datos);
            }
            public void seleccionar(DataGridView datos, recarga_moneda dato)
            {
                x.select(datos, dato);
            }
            public void seleccionar(DataGridView datos, string dato)
            {
                x.select(datos);
            }
        }
    }

