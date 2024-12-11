using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avancesssss
{
    internal class gestor
    {
        public string id, nombres, login, acceso;

        public gestor()
        {
            this.id = "NN";
            this.nombres = "NN";
            this.login = "NN";
            this.acceso = "NN";
        }

        public gestor(string id, string nombre, string login, string acceso)
        {
            this.id = id;
            this.nombres = nombre;
            this.login = login;
            this.acceso = acceso;
        }

        public string Id { get => id; set => id = value; }
        public string Nombre { get => nombres; set => nombres = value; }
        public string Login { get => login; set => login = value; }
        public string Acceso { get => acceso; set => acceso = value; }
    }
}
