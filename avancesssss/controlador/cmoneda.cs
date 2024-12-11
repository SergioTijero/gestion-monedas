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
        public cmoneda()
        {
            x = new conexion();
        }
        public void insert(moneda dato)
        {
            x.Consulta("insert into monedas values('" +
                dato.Id_Moneda + "','" +
                dato.Nombre_Moneda + "','" +
                Convert.ToDouble(dato.Precio_Actual) + "','" +
                Convert.ToInt32(dato.Cantidad) + "')");
        }   
        public void update(moneda dato)
        {
            x.Consulta("update monedas set " +
                "nombre_Moneda='" + dato.Nombre_Moneda+ "', " +
                "precio_Actual= '" + Convert.ToDouble(dato.Precio_Actual)+ "', " +
                "cantidad= '" + Convert.ToInt32(dato.Cantidad) + "' where " +
                "id_Moneda= '"+dato.Id_Moneda+"'");
        }
        public void delete(moneda dato)
        {
            x.Consulta("delete from monedas where " +
               "id_Moneda='" + dato.Id_Moneda + "'");
        }
        public void select(DataGridView datos)
        {
            datos.DataSource = x.Consulta("select * from monedas");
            //MessageBox.Show("exito");
        }
        public void select (ComboBox datos)
        {
            datos.DataSource = x.Consulta("select * from monedas");
            datos.ValueMember = "id_Moneda";
            datos.DisplayMember = "nombre_Moneda";
        }
        public void select(DataGridView datos, moneda dato){

            datos.DataSource = x.Consulta("select * from monedas where" +
                " id_Moneda='" + dato.Id_Moneda + "' or" +
                " nombre_Moneda='" + dato.Nombre_Moneda + "' or" +
                " precio_Actual='" + dato.Precio_Actual + "' or" +
                " cantidad='" + dato.Cantidad + "'");

        }
        public void select(DataGridView datos, string dato)
        {
            datos.DataSource = x.Consulta("select * from monedas where" +
                " id_Moneda like '%" + dato + "%' or" +
                " nombre_Moneda like '%" + dato + "%' or" +
                " precio_Actual like '%" + dato + "%' or" +
                " cantidad like '%" + dato + "%'");
        }

    }
}
