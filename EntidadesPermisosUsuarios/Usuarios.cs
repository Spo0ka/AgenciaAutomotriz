using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPermisosUsuarios
{
    public class Usuarios
    {
        public Usuarios(int idusuario, string nombre, string apellidop, string apellidoM, string fdn, string rfc, string contra)
        {
            Idusuario = idusuario;
            Nombre = nombre;
            Apellidop = apellidop;
            ApellidoM = apellidoM;
            Fdn = fdn;
            Rfc = rfc;
            Contra = contra;
        }

        public int Idusuario { get; set; }
        public string Nombre { get; set; }
        public string Apellidop { get; set; }
        public string ApellidoM { get; set; }
        public string Fdn { get; set; }
        public string Rfc { get; set; }
        public string Contra { get; set; }

    }
}
