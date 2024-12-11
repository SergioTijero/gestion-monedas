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
    internal class ctransaccion
    {
        private conexion x;
        public ctransaccion()
        {
            x = new conexion();
        }
        public void insert(transaccion dato)
        {
            MessageBox.Show(dato.Fecha.ToString("dd-MM-yyyy HH:mm:ss"));
            x.Consulta("insert into transaccion values('" +
                dato.Id_transaccion + "'," +
                dato.Id_moneda + "','" +
                dato.Ide_user_gestor + "','" +
                dato.Ide_user_cliente + "','" +
                dato.Fecha.ToString("dd-MM-yyyy HH:mm:ss") + "','" +
                Convert.ToDouble(dato.Precio_venta) + "','" +
                Convert.ToDouble(dato.Cantidad) + "')");
        }
        public void update(transaccion dato)
        {
            x.Consulta("update transaccion set " +
                "id_transaccion='" + dato.Id_transaccion + "'," +
                "id_moneda='" + dato.Id_moneda + "'," +
                "ide_user_gestor='" + dato.Ide_user_gestor + "'," +
                "ide_user_cliente='" + dato.Ide_user_cliente + "'," +
                "fecha='" + dato.Fecha + "' " +
                "precio_venta='" + Convert.ToDouble(dato.Precio_venta) + "' where " +
                "cantidad='" + Convert.ToDouble(dato.Cantidad) + "'");
        }
        public void delete(transaccion dato)
        {
            x.Consulta("delete from transaccion where " +
                "id_transaccion='" + dato.Id_transaccion + "'");
        }
        public void select(DataGridView datos)
        {
            datos.DataSource = x.Consulta("select * from transaccion");
        }
        public void select(ComboBox datos)
        {
            datos.DataSource = x.Consulta("select * from transaccion");
            datos.DisplayMember = "id_transaccion";
            datos.ValueMember = "id_moneda";
        }
        public void select(DataGridView datos, transaccion dato)
        {
            datos.DataSource = x.Consulta("select * from transaccion where" +
                " id_transaccion='" + dato.Id_transaccion + "' or" +
                " id_moneda='" + dato.Id_moneda + "' or" +
                " ide_user_gestor='" + dato.Ide_user_gestor + "' or" +
                " ide_user_cliente='" + dato.Ide_user_cliente + "' or" +
                " fecha='" + dato.Fecha + "' or" +
                " precio_venta='" + dato.Precio_venta + "' or" +
                " cantidad='" + dato.Cantidad + "'");
        }
        public void select(DataGridView datos, string dato)
        {
            datos.DataSource = x.Consulta("select * from transaccion where" +
                " id_transaccion like '%" + dato + "%' or" +
                " id_moneda like '%" + dato + "%' or" +
                " ide_user_gestor like '%" + dato + "%' or" +
                " ide_user_cliente like '%" + dato + "%' or" +
                " fecha like '%" + dato + "%' or" +
                " precio_venta like '%" + dato + "%' or" +
                " cantidad like '%" + dato + "%'");
        }
    }
}
