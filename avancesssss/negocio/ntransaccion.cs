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
    internal class ntransaccion
    {
            private ctransaccion x;
            public ntransaccion(){
                this.x = new ctransaccion();
            }
            public void insertar(string id_transaccion, string id_moneda, string ide_user_gestor, string ide_user_cliente, DateTime fecha, double precio_venta, double cantidad)
            {
                x.insert(new transaccion(id_transaccion, id_moneda, ide_user_gestor, ide_user_cliente, fecha, precio_venta, cantidad));
            }
            public void actualizar(string id_transaccion, string id_moneda, string ide_user_gestor, string ide_user_cliente, DateTime fecha, double precio_venta, double cantidad)
            {
                x.update(new transaccion(id_transaccion, id_moneda, ide_user_gestor, ide_user_cliente, fecha, precio_venta, cantidad));
            }
            public void eliminar(string id_transaccion)
            {
                x.delete(new transaccion(id_transaccion,"", "", "", DateTime.MinValue,0, 0));
            }
            public void seleccionar(DataGridView datos)
            {
                x.select(datos);
            }
            public void seleccionar(ComboBox datos)
            {
                x.select(datos);
            }
            public void seleccionar(DataGridView datos, transaccion dato)
            {
                x.select(datos, dato);
            }
            public void seleccionar(DataGridView datos, string dato)
            {
                x.select(datos, dato);
            }

    }
}