using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avancesssss.modelo
{
    internal class transaccion
    {
        private string id_transaccion, id_moneda, ide_user_gestor, ide_user_cliente;
        private int fecha;
        private double precio_venta, cantidad;

        public transaccion()
        {
            this.id_transaccion = "NN";
            this.id_moneda = "NN";
            this.ide_user_gestor = "NN";
            this.ide_user_cliente = "NN";
            this.fecha = 0;
            this.precio_venta = 0;
            this.cantidad = 0;
        }
        public transaccion(string id_transaccion, string id_moneda, string ide_user_gestor, string ide_user_cliente, int fecha, double precio_venta, double cantidad)
        {
            this.id_transaccion = id_transaccion;
            this.id_moneda = id_moneda;
            this.ide_user_gestor = ide_user_gestor;
            this.ide_user_cliente = ide_user_cliente;
            this.fecha = fecha;
            this.precio_venta = precio_venta;
            this.cantidad = cantidad;
        }

        public string Id_transaccion { get => id_transaccion; set => id_transaccion = value; }
        public string Id_moneda { get => id_moneda; set => id_moneda = value; }
        public string Ide_user_gestor { get => ide_user_gestor; set => ide_user_gestor = value; }
        public string Ide_user_cliente { get => ide_user_cliente; set => ide_user_cliente = value; }
        public int Fecha { get => fecha; set => fecha = value; }
        public double Precio_venta { get => precio_venta; set => precio_venta = value; }
        public double Cantidad { get => cantidad; set => cantidad = value; }
    }
}
