using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avancesssss.modelo
{
    internal class recarga_moneda
    {
        private string id_Recarga, id_Moneda;
        private int fecha;
        private double cantidad_recarga;

        public recarga_moneda()
        {
            this.id_Recarga = "NN";
            this.id_Moneda = "NN";
            this.fecha = 0;
            this.cantidad_recarga = 0;
        }
        public recarga_moneda(string id_Recarga, string id_Moneda, int fecha, double cantidad_recarga)
        {

            this.id_Recarga = id_Recarga;
            this.id_Moneda = id_Moneda;
            this.fecha = fecha;
            this.cantidad_recarga = cantidad_recarga;
        }

        public string Id_Recarga { get => id_Recarga; set => id_Recarga = value; }
        public string Id_Moneda { get => id_Moneda; set => id_Moneda = value; }
        public int Fecha { get => fecha; set => fecha = value; }
        public double Cantidad_recarga { get => cantidad_recarga; set => cantidad_recarga = value; }
    }
}