using avancesssss.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace avancesssss.modelo
{
    internal class cusuario_cliente
    {

            private conexion x;
            private cusuario_cliente()
            {
                x = new conexion();
            }
            public void insert(usuario_cliente dato)
            {
                x.consulta("insert into usuario_cliente values('" +
                    dato.Id + "','" +
                    dato.Nombre + "','" +
                    dato.Login + "','" +
                    dato.Acceso + "')");
            }
            public void update(usuario_cliente dato)
            {
                x.consulta("update usuario_cliente set " +
                    "id_Moneda= '" + dato.Id + "'," +
                    "nombre_Moneda='" + dato.Nombre + "', '" +
                    "precio_Actual= '" + dato.Login + "', '" +
                    "cantidad= '" + dato.Acceso + "', '");
            }
            public void delete(usuario_cliente dato)
            {
                x.consulta("delete from usuario_cliente where " +
                   "id_Moneda='" + dato.Id + "'");
            }
            public void select(DataGridView datos)
            {
                datos.DataSource = x.consulta("select * from usuario_cliente");
            }
            public void select(ComboBox datos)
            {
                datos.DataSource = x.consulta("select * from usuario_cliente");
                datos.ValueMember = "id";
                datos.DisplayMember = "nombre";
            }
            public void select(DataGridView datos, usuario_cliente dato)
            {
                datos.DataSource = x.consulta("select * from usuario_cliente where" +
                    " id='" + dato.Id + "' or" +
                    " nombre='" + dato.Nombre + "' or" +
                    " login='" + dato.Login + "' or" +
                    " acceso='" + dato.Acceso + "'");

            }

        }
    }
