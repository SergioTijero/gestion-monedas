using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avancesssss.modelo
{
    internal class usuario_cliente
    {
        public string id, nombres, apellidos;
        public double saldo_actual;

        public usuario_cliente()
        {
            this.id = "NN";
            this.nombres = "NN";
            this.saldo_actual= 0;
        }

        public usuario_cliente(string id, string nombres, string apellidos, double saldo_actual)
        {
            this.Id = id;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.Saldo_actual = saldo_actual;
        }

        public string Id { get => id; set => id = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public double Saldo_actual { get => saldo_actual; set => saldo_actual = value; }
    }
}
