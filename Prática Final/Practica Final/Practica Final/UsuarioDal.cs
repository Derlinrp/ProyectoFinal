using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Practica_Final
{
    class UsuarioDal
    {

        public static int CrearCuentas(string Usuario, string Contraseña)
        {
            int resultado = 0;
            SqlConnection Conn = DataSource.Connect();

            SqlCommand Comando = new SqlCommand(string.Format("Insert Into tblregistro (Nombre, Contraseña) values ('{0}', PwdEncrypt('{1}') )", Usuario, Contraseña), Conn);

            resultado = Comando.ExecuteNonQuery();
            Conn.Close();

            return resultado;
        }

        public static int IniciarSesion(String Usuarios, String Contraseña)
        {
            int resultado = -1;

            SqlConnection conexion = DataSource.Connect();

            SqlCommand comando = new SqlCommand(string.Format("Select * From tblregistro Where Nombre = '{0}' and PwdCompare('{1}',Contraseña) = 1 ", Usuarios, Contraseña), conexion);

            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                resultado = 50;
            }

            conexion.Close();
            return resultado;
        }

    }
}
