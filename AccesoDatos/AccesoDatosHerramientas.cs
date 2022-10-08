using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesPermisosUsuarios;
using ConectarBd;

namespace AccesoDatos
{
    public class AccesoDatosHerramientas : IAcceso
    {
        Base b = new Base("Localhost","root","", "AgenciaAutomotriz");
        public void Borrar(dynamic entidad)
        {
            b.comando(String.Format("Call DeleteHerramientas('{0}')",entidad.CodigoHerramientas));

        }

        public void Guardar(dynamic entidad)
        {
            b.comando(String.Format("Call InsertHerramientas('{0}','{1}',{2},'{3}','{4}')", entidad.CodigoHerramientas,
                entidad.Nombre,entidad.Medida, entidad.Marca,entidad.Descripcion));
        }

        public DataSet Mostrar(string entidad)
        {
          return  b.Obtener(String.Format("call ShowHerramientas('%{0}%')", entidad),"herramientas");
        }
    }
}
