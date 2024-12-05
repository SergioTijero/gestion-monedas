using avancesssss.dao;
using avancesssss.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace avancesssss
{
    internal class cgestor
    {
        private conexion x;
        private cgestor()
        {
            x = new conexion();
        }
        public void insert(gestor dato)
        {
            x.consulta("insert into gestor values('" +
                dato.Id + "','" +
                dato.Nombre + "','" +
                dato.Login + "','" +
                dato.Acceso + "')");
        }
        public void update(gestor dato)
        {
            x.consulta("update gestor set " +
                "id_Moneda= '" + dato.Id + "'," +
                "nombre_Moneda='" + dato.Nombre+ "', '" +
                "precio_Actual= '" + dato.Login+ "', '" +
                "cantidad= '" + dato.Acceso + "', '");
        }
        public void delete(gestor dato)
        {
            x.consulta("delete from gestor where " +
               "id_Moneda='" + dato.Id + "'");
        }
        public void select(DataGridView datos)
        {
            datos.DataSource = x.consulta("select * from gestor");
        }
        public void select(ComboBox datos)
        {
            datos.DataSource = x.consulta("select * from gestor");
            datos.ValueMember = "id";
            datos.DisplayMember = "nombre";
        }
        public void select(DataGridView datos, gestor dato)
        {
            datos.DataSource = x.consulta("select * from gestor where" +
                " id='" + dato.Id+ "' or" +
                " nombre='" + dato.Nombre+ "' or" +
                " login='" + dato.Login+ "' or" +
                " acceso='" + dato.Acceso+ "'");

        }

    }
}
 