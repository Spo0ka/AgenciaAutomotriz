using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesPermisosUsuarios;
using ConectarBd;
using System.Data;

namespace AccesoDatos
{
    public class AccesoDatosPermisos :IAcceso
    {
        Base b = new Base("localhost","root","", "AgenciaAutomotriz");

        public void Borrar(dynamic entidad)
        {
            b.comando(String.Format("call deletepermisos({0})",entidad.Idpermisos));
        }

        public void Guardar(dynamic entidad)
        {
            b.comando(String.Format("CALL InsertPermiso({0},{1},{2},{3},{4})",entidad.Idpermisos,
                entidad.FkUsuario,entidad.Administrador,entidad.Ejecutivo,entidad.Empleado));
        }

        public DataSet Mostrar(string entidad)
        {
            return b.Obtener(String.Format("CALL showPermisos('%{0}%')",entidad),"Permisos");
        }
        
    }
}
