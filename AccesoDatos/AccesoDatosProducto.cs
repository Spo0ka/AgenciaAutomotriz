using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConectarBd;
using EntidadesPermisosUsuarios;

namespace AccesoDatos
{
    public class AccesoDatosProducto : IAcceso
    {
        Base b = new Base("Localhost","root","", "AgenciaAutomotriz");

        public void Borrar(dynamic entidad)
        {
            b.comando(String.Format("call DeleteProductos('{0}')",entidad.CodigoDeBarras));
        }

        public void Guardar(dynamic entidad)
        {
            b.comando(String.Format("call InsertProducto('{0}','{1}','{2}','{3}')", entidad.CodigoDeBarras,
                entidad.Nombre,entidad.Descripcion,entidad.Marca));
        }

        public DataSet Mostrar(string entidad)
        {
            return b.Obtener(String.Format("call ShowProductos('%{0}%')", entidad), "producto");
        }
    }
}
