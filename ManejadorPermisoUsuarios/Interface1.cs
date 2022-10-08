using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejadorPermisoUsuarios
{
    internal interface IManejador
    {
        void Guardar(dynamic entidad);
        void Mostrar(DataGridView tabla, string filtro);
        void Borrar(dynamic entidad);
    }
}
