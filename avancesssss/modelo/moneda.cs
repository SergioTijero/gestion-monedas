using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avancesssss.modelo
{
    internal class moneda
    {
        private string id_Moneda, nombre_Moneda;
        private double precio_Actual;
        private int cantidad;

        public moneda()
        {
            this.Id_Moneda = "00";
            this.Nombre_Moneda = "NN";
            this.precio_Actual = 00;
            this.cantidad = 00;

        }
        public moneda(string id_Moneda, string nombre_Moneda, double precio_Actual, int cantidad)
        {
            this.Id_Moneda = id_Moneda;
            this.Nombre_Moneda = nombre_Moneda;
            this.Precio_Actual = precio_Actual;
            this.Cantidad = cantidad;
        }

        public string Id_Moneda { get => id_Moneda; set => id_Moneda = value; }
        public string Nombre_Moneda { get => nombre_Moneda; set => nombre_Moneda = value; }
        public double Precio_Actual { get => precio_Actual; set => precio_Actual = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}
