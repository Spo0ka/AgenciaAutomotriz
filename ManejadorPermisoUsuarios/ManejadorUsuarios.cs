using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace ManejadorPermisoUsuarios
{
    public class ManejadorUsuarios
    {
        AccesoDatosUsuarios usuarios = new AccesoDatosUsuarios();


        public bool login(string usuario, string contra){
           return usuarios.Login2(usuario,contra);
}
    }
}
