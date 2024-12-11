using avancesssss.dao;
using avancesssss.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace avancesssss.controlador
{
    internal class cgestor
    {
        private conexion x;
        public cgestor()
        {
            x = new conexion();
        }
        public void insert(gestor dato)
        {
            x.Consulta("insert into usuarios_Gestor values('" +
                dato.Id + "','" +
                dato.Nombre + "','" +
                dato.Login + "','" +
                dato.Acceso + "')");
        }
        public void update(gestor dato)
        {
            x.Consulta("update usuarios_Gestor set " +
                "id= '"+dato.Id +"'," +
                "nombres='" + dato.Nombre + "', " +
                "login= '" + dato.Login + "' where " +
                "acceso= '" + dato.Acceso + "'");
        }
        public void delete(gestor dato)
        {
            x.Consulta("delete from usuarios_Gestor where " +
               "id='" + dato.Id + "'");
        }
        public void select(DataGridView datos)
        {
            datos.DataSource = x.Consulta("select * from usuarios_Gestor");
        }
        public void select(ComboBox datos)
        {
            datos.DataSource = x.Consulta("select * from usuarios_Gestor");
            datos.ValueMember = "id";
            datos.DisplayMember = "nombres";
        }
        public void select(DataGridView datos, gestor dato)
        {
            datos.DataSource = x.Consulta("select * from usuarios_Gestor where" +
                " id='" + dato.Id + "' or" +
                " nombres='" + dato.Nombre + "' or" +
                " login='" + dato.Login + "' or" +
                " acceso='" + dato.Acceso + "'");

        }
        public void select(DataGridView datos, string dato)
        {
            datos.DataSource = x.Consulta("select * from usuarios_Gestor where" +
                " id like '%" + dato + "%' or" +
                " nombres like '%" + dato + "%' or" +
                " login like '%" + dato + "%' or" +
                " acceso like '%" + dato + "%'");

        }
    }
}
