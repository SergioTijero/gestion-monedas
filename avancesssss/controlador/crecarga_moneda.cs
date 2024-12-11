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
    internal class crecarga_moneda
    {
        private conexion x;
        public crecarga_moneda()
        {
            x = new conexion();
        }
        public void insert(recarga_moneda dato)
        {
            MessageBox.Show(dato.Fecha.ToString("dd-MM-yyyy HH:mm:ss"));
            x.Consulta("insert into recarga_monedas values('" +
                dato.Id_Recarga + "','" +
                dato.Id_Moneda + "','" +
                dato.Cantidad_recarga + "','" +
                dato.Fecha.ToString("dd-MM-yyyy HH:mm:ss") + "')");
        }
        public void update(recarga_moneda dato)
        {
            x.Consulta("update recarga_monedas set " +
                "id_Recarga= '" + dato.Id_Recarga + "'," +
                "id_Moneda= '" + dato.Id_Moneda + "'," +
                "cantidad_recarga='" + dato.Cantidad_recarga + "'where " +
                "fecha= '" + dato.Fecha + "', '");
        }
        public void delete(recarga_moneda dato)
        {
            x.Consulta("delete from recarga_monedas where " +
               "id_Moneda='" + dato.Id_Moneda + "'");
        }
        public void select(DataGridView datos)
        {
            datos.DataSource = x.Consulta("select * from recarga_monedas");
        }
        public void select(ComboBox datos)
        {
            datos.DataSource = x.Consulta("select * from recarga_monedas");
            datos.ValueMember = "id_Recarga";
            datos.DisplayMember = "id_Moneda";
        }
        public void select(DataGridView datos, recarga_moneda dato)
        {
            datos.DataSource = x.Consulta("select * from recarga_monedas where" +
                " id_Recarga='" + dato.Id_Recarga + "' or" +
                " id_Moneda='" + dato.Id_Moneda + "' or" +
                " cantidad_recarga='" + dato.Cantidad_recarga + "' or" +
                " fecha='" + dato.Fecha + "'");

        }
        public void select(DataGridView datos, string dato)
        {
            datos.DataSource = x.Consulta("select * from categorias where" +
                " id_Recarga like '%" + dato + "%' or" +
                " id_Moneda like '%" + dato + "%' or" +
                " cantidad_recarga like '%" + dato + "%' or" +
                " fecha like '%" + dato + "%'");
        }
    }
}