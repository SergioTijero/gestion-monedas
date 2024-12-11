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
    internal class cusuario_cliente
    {

        private conexion x;
        public cusuario_cliente()
        {
            x = new conexion();
        }
        public void insert(usuario_cliente dato)
        {
            x.Consulta("insert into usuarios_cliente values('" +
                dato.Id + "','" +
                dato.Nombres + "','" +
                dato.Apellidos + "','" +
                dato.saldo_actual + "')");
        }
        public void update(usuario_cliente dato)
        {
            x.Consulta("update usuarios_cliente set " +
                "id= '" + dato.Id + "'," +
                "nombres='" + dato.Nombres + "', " +
                "apellidos= '" + dato.Apellidos + "' where " +
                "saldo_actual= '" + dato.saldo_actual + "', ");
        }
        public void delete(usuario_cliente dato)
        {
            x.Consulta("delete from usuarios_cliente where " +
               "id='" + dato.Id + "'");
        }
        public void select(DataGridView datos)
        {
            datos.DataSource = x.Consulta("select * from usuarios_cliente");
        }
        public void select(ComboBox datos)
        {
            datos.DataSource = x.Consulta("select * from usuarios_cliente");
            datos.ValueMember = "id";
            datos.DisplayMember = "nombres";
        }
        public void select(DataGridView datos, usuario_cliente dato)
        {
            datos.DataSource = x.Consulta("select * from usuarios_cliente where" +
                " id='" + dato.Id + "' or" +
                " nombres='" + dato.Nombres + "' or" +
                " apellidos='" + dato.Apellidos + "' or" +
                " saldo_actual='" + dato.Saldo_actual + "'");

        }

    }
}