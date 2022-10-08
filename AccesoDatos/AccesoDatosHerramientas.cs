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
        Base b = new Base("localhost","Root","", "AgenciaAutomotriz");
        public void Borrar(dynamic entidad)
        {
            b.comando(String.Format("Call DeleteHerramientas('{0}')",entidad.CodigoHerramientas));

        }

        public void Guardar(dynamic entidad)
        {
            b.comando(String.Format("Call DeleteHerramientas('{0}','{1}',{2},'{3}','{4}')", entidad.CodigoHerramientas,
                entidad.Nombre,entidad.Medida, entidad.Marca,entidad.Descripcion));
        }

        public DataSet Mostrar(dynamic entidad)
        {
          return  b.Obtener(String.Format("call ShowProductos('%{0}%')",entidad), "herramientas");
        }
    }
}
