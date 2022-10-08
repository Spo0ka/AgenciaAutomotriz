using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesPermisosUsuarios;
using AccesoDatos;
using System.Diagnostics;
using crud;
using System.Windows.Forms;
using System.Drawing;

namespace ManejadorPermisoUsuarios
{
    public class ManejadorProductos : IManejador
    {
        AccesoDatosProducto Adp = new AccesoDatosProducto();
        Grafico g = new Grafico();
        public void Borrar(dynamic entidad)
        {
            Adp.Borrar(entidad);
        }

        public void Guardar(dynamic entidad)
        {
            Adp.Guardar(entidad);
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = Adp.Mostrar(filtro).Tables["producto"];
            tabla.Columns.Insert(4,g.Boton("Editar",Color.FromArgb(120,255,180)));
            tabla.Columns.Insert(5, g.Boton("Eliminar", Color.FromArgb(199, 0, 57)));
            tabla.Columns[0].Visible = false;

        }
    }
}
