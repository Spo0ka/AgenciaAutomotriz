using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPermisosUsuarios
{
    public class Productos
    {
        public Productos(string codigoDeBarras, string nombre, string descripcion, string marca)
        {
            CodigoDeBarras = codigoDeBarras;
            Nombre = nombre;
            Descripcion = descripcion;
            Marca = marca;
        }

        public string CodigoDeBarras { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }

    }
}
