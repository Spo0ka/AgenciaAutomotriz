using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
using crud;

namespace ManejadorPermisoUsuarios
{
    public class ManejadorUsuarios : IManejador
    {
        AccesoDatosUsuarios usuarios = new AccesoDatosUsuarios();
        Grafico g = new Grafico();

        public void Borrar(dynamic entidad)
        {
            DialogResult rs = MessageBox.Show("seguro?","Cuidado",MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                usuarios.Borrar(entidad);
            }
        }

        public void Guardar(dynamic entidad)
        {
            usuarios.Guardar(entidad);
        }

        public bool login(string usuario, string contra){
           return usuarios.Login2(usuario,contra);
}

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = usuarios.Mostrar(filtro).Tables["usuarios"];
            tabla.Columns.Insert(7, g.Boton("Editar", Color.FromArgb(120, 255, 180)));
            tabla.Columns.Insert(8, g.Boton("Eliminar", Color.FromArgb(199, 0, 57)));
            tabla.Columns[0].Visible = false;
        }
    }
}
