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
        
        public void Borrar(dynamic entidad)
        {
            throw new NotImplementedException();
        }

        public void Guardar(dynamic entidad)
        {
            throw new NotImplementedException();
        }

        public DataSet Mostrar(string entidad)
        {
            throw new NotImplementedException();
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
