using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data;
using MySql.Data.MySqlClient;


namespace DPRNIII_U1_EA_MAZM
{
    class ConexionBD
    {
        public static MySqlConnection conexion;

        private static string cadena = "server=localhost; user id=root; database=base_datos_ea_unadm; password=Cu213lona1973;";

        public static bool CheckConexion()
        {
            try
            {

                conexion = new MySqlConnection(cadena);
                conexion.Open();
                conexion.Close();
                return true;
            }
            catch (InvalidCastException e)
            {
                               
                return false;

            }
        }


        public static MySqlConnection GetConexionClient()
        {

            try
            {
                if (conexion == null || conexion.State == System.Data.ConnectionState.Closed)
                {
                    conexion = new MySqlConnection(cadena);
                    conexion.Open();
                }

            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e);
            }

            return conexion;

        }
        
    }
}
