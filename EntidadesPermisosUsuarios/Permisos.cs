using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPermisosUsuarios
{
    public class Permisos
    {
        public Permisos(int idpermisos, int fkUsuario, bool administrador, bool ejecutivo, bool empleado)
        {
            Idpermisos = idpermisos;
            FkUsuario = fkUsuario;
            Administrador = administrador;
            Ejecutivo = ejecutivo;
            Empleado = empleado;
        }

        public int Idpermisos { get; set; }
        public int FkUsuario { get; set; }
        public bool Administrador { get; set; }
        public bool Ejecutivo { get; set; }
        public bool Empleado { get; set; }

    }
}
