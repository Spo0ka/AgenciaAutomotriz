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
    public class ManejaddorPermisos : IManejador
    {
        AccesoDatosPermisos Ap = new AccesoDatosPermisos();
        AccesoDatosUsuarios Au = new AccesoDatosUsuarios();
        Grafico g = new Grafico();

        public void Borrar(dynamic entidad)
        {
            DialogResult dr = MessageBox.Show("Seguro?","Cuidado",MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Ap.Borrar(entidad);
            }
        }

        public void Guardar(dynamic entidad)
        {
            Ap.Guardar(entidad);
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = Ap.Mostrar(filtro).Tables["Permisos"];
            tabla.Columns.Insert(5, g.Boton("Editar", Color.FromArgb(120, 255, 180)));
            tabla.Columns.Insert(6, g.Boton("Eliminar", Color.FromArgb(199, 0, 57)));
            tabla.Columns[0].Visible = false;
        }

        public void ExportarUsuario(ComboBox caja) 
        {
            caja.DataSource = Au.Mostrar("").Tables["usuarios"];
            caja.DisplayMember = "nombre";
            caja.ValueMember = "idusuario";
        }

        public void Lospermisus(bool Admin, bool Ejec, bool emple, ToolStripButton Usuarios, ToolStripButton permisos)
        {
            
            if (Admin == true)
            {
                Usuarios.Visible = true;
                permisos.Visible = true;
            }
             if (emple == true)
            {
                Usuarios.Visible = false;
                permisos.Visible = false;
            }
            if (Ejec== true)
            {
                permisos.Visible = false;
            }
        }
    }
}
