using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPermisosUsuarios
{
    public class Usuarios
    {
        public Usuarios(int idusuario, int nombre, int apellidop, int apellidoM, int fdn, int rfc, int contra)
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
        public int Nombre { get; set; }
        public int Apellidop { get; set; }
        public int ApellidoM { get; set; }
        public int Fdn { get; set; }
        public int Rfc { get; set; }
        public int Contra { get; set; }

    }
}
