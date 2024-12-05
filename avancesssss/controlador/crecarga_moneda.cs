using avancesssss.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace avancesssss.modelo
{
    internal class crecarga_moneda
    {
        private conexion x;
        private crecarga_moneda()
        {
            x = new conexion();
        }
        public void insert(recarga_moneda dato)
        {
            x.consulta("insert into recarga_moneda values('" +
                dato.Id_Recarga + "','" +
                dato.Id_Moneda + "','" +
                dato.Cantidad_recarga + "','" +
                dato.Fecha + "')");
        }
        public void update(recarga_moneda dato)
        {
            x.consulta("update recarga_moneda set " +
                "id_Recarga= '" + dato.Id_Recarga + "'," +
                "id_Moneda= '" + dato.Id_Moneda + "'," +
                "cantidad_recarga='" + dato.Cantidad_recarga + "', '" +
                "fecha= '" + dato.Fecha + "', '");
        }
        public void delete(recarga_moneda dato)
        {
            x.consulta("delete from recarga_moneda where " +
               "id_Moneda='" + dato.Id_Moneda + "'");
        }
        public void select(DataGridView datos)
        {
            datos.DataSource = x.consulta("select * from recarga_moneda");
        }
        public void select(ComboBox datos)
        {
            datos.DataSource = x.consulta("select * from recarga_moneda");
            datos.ValueMember = "id_Recarga";
            datos.DisplayMember = "id_Moneda";
        }
        public void select(DataGridView datos, recarga_moneda dato)
        {
            datos.DataSource = x.consulta("select * from recarga_moneda where" +
                " id_Recarga='" + dato.Id_Recarga + "' or" +
                " id_Moneda='" + dato.Id_Moneda + "' or" +
                " cantidad_recarga='" + dato.Cantidad_recarga + "' or" +
                " fecha='" + dato.Fecha + "'");

        }

    }
}