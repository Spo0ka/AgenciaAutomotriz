using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public interface IAcceso
    {
        void Guardar(dynamic entidad);
        DataSet Mostrar(string entidad);
        void Borrar(dynamic entidad);

    }
}
