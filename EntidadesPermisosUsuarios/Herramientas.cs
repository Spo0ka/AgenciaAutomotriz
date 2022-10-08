using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPermisosUsuarios
{
    public class Herramientas
    {
        public Herramientas(string codigoHerramientas, string nombre, double medida, string marca, string descripcion)
        {
            CodigoHerramientas = codigoHerramientas;
            Nombre = nombre;
            Medida = medida;
            Marca = marca;
            Descripcion = descripcion;
        }

        public string CodigoHerramientas { get; set; }
        public string Nombre { get; set; }
        public double Medida { get; set; }
        public string Marca { get; set; }
        public string Descripcion { get; set; }
    }
}
