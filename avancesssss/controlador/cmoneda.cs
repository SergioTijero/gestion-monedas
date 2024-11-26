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
    internal class cmoneda
    {
        private conexion x;
        private cmoneda()
        {
            x = new conexion();
        }
        public void insert( moneda dato)
        {
            x.consulta("insert into moneda values('" +
                dato.Id_Moneda + "','" +
                dato.Nombre_Moneda + "','" +
                dato.Precio_Actual + "','" +
                dato.Cantidad + "')");
        }
        public void update(moneda dato)
        {
            x.consulta("update moneda set " +
                "id_Moneda= '" + dato.Id_Moneda + "'," +
                "nombre_Moneda='" + dato.Nombre_Moneda + "', '" +
                "precio_Actual= '" + dato.Precio_Actual + "', '" +
                "cantidad= '" + dato.Cantidad + "', '");
        }
        public void delete(moneda dato)
        {
            x.consulta("delete from moneda where " +
               "id_Moneda='" + dato.Id_Moneda + "'");
        }
        public void select(DataGridView datos)
        {
            datos.DataSource = x.consulta("select * from moneda");
        }
        public void select(ComboBox datos)
        {
            datos.DataSource = x.consulta("select * from moneda");
            datos.ValueMember = "id_Moneda";
            datos.DisplayMember = "nombre_Moneda";
        }
        public void select(DataGridView datos, moneda dato)
        {
            datos.DataSource = x.consulta("select * from moneda where" +
                " id_Moneda='" + dato.Id_Moneda + "' or" +
                " nombre_Moneda='" + dato.Nombre_Moneda + "' or" +
                " precio_Actual='" + dato.Precio_Actual + "' or" +
                " cantidad='" + dato.Cantidad + "'");

        }

    }
}
