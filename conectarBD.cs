using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class conectarBD
{
    //Se declara variable de tipo conexion
    public static MySqlConnection conectarBd;
	
	//Se establece cadena de conexion
	private static string cadena = "server=localhost; user id=root; database=base_datos_ea_unadm; password=Cu213lona1973;";
	
	//Se crea metodo para probar conexion
	public static bool verificarConexion()
    {
        try
        {
		   conectarBD = new MySQLConnection(cadena);
			conectarBD.
			conectarBD.
			return true;
        }
        catch (InvalidCastException e)
        {
			Console.WriteLine(e);
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


}
