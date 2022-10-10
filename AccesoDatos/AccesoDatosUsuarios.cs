using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConectarBd;
using EntidadesPermisosUsuarios;
using MySql.Data.MySqlClient;
using System.Security.Cryptography.X509Certificates;

namespace AccesoDatos
{
    public class AccesoDatosUsuarios : IAcceso
    {
        
       public MySqlConnection con = new MySqlConnection(String.Format("server = localhost;database=AgenciaAutomotriz; user=root; password="));
        Base b = new Base("localhost","root","", "AgenciaAutomotriz");
        
        public void Borrar(dynamic entidad)
        {
            b.comando(String.Format("Call DeleteUsuario({0})",entidad.Idusuario));
        }

        public void Guardar(dynamic entidad)
        {
            b.comando(String.Format("Call insertUsuario({0},'{1}','{2}','{3}','{4}','{5}','{6}')",
                entidad.Idusuario,entidad.Nombre,entidad.Apellidop,
                entidad.ApellidoM,entidad.Fdn,entidad.Rfc,entidad.Contra));
        }

        public DataSet Mostrar(string entidad)
        {
            return b.Obtener(string.Format("Call ShowUsuarios('%{0}%')",entidad),"usuarios");
        }
        
        public bool Login2(string usuario, string contra)
        {
            
            con.Open();
            bool Valor = false;
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection cone = new MySqlConnection();
            cmd.Connection = con;
            cmd.CommandText = (string.Format("Select * from usuarios where nombre ='{0}' and contra = '{1}'",usuario,contra));
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
               Valor =  true;

            }
            else
            {
                Valor = false;
            }
            con.Close();
            return Valor;

        }
        
    }
}
