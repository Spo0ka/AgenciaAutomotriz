using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
using crud;

namespace ManejadorPermisoUsuarios
{
    public class ManejadorHerramientas : IManejador
    {
        AccesoDatosHerramientas Adh = new AccesoDatosHerramientas();
        Grafico g = new Grafico();
        public void Borrar(dynamic entidad)
        {
            DialogResult  rs =MessageBox.Show("Estas seguro de borrar?","cuidado",MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                Adh.Borrar(entidad);
            }
        }

        public void Guardar(dynamic entidad)
        {
           Adh.Guardar(entidad);
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = Adh.Mostrar(filtro).Tables["herramientas"];
            tabla.Columns.Insert(5, g.Boton("Editar", Color.FromArgb(120, 255, 180)));
            tabla.Columns.Insert(6, g.Boton("Eliminar", Color.FromArgb(199, 0, 57)));
            tabla.Columns[0].Visible = false;
        }

        public void Permisus(bool admin, bool ejecutivo, bool empleado, Button Add)
        {
            if (empleado)
            {
                Add.Visible = false;
            }
        }
    }
}
