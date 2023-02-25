using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace DPRNIII_U1_EA_MAZM
{
    
    class salvarInformacion
    {
        protected MySqlCommand comando;

        //Metodo insertar en base de datos
        public Boolean insertarInformacionEvento(String tipoEvento, String apoyoSolicitado, String latitud, String longitud, String descripcion)
        {

            try
            {
                //Guarda datos del tipo de evento registrado
                String evento = "INSERT INTO evento SET tipo_evento='"+tipoEvento+"',apoyo_solicitado='"+apoyoSolicitado+"',coordenada_latitud='"+latitud+"',coordenadas_longitud='"+longitud + "',descripcion='"+descripcion+"'";
                
                comando = new MySqlCommand(evento, ConexionBD.GetConexionClient());
                comando.ExecuteNonQuery();
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                    
            }

            return true;
        }

        public Boolean insertarInformacionUsuario(String nombreCompleto, DateTime fechaEvento, String lugarEvento, Object status, String folio)
        {

            try
            {
                //Guarda datos del usuario
                String usuario = "INSERT INTO usuario SET nombre_completo='"+nombreCompleto+ "',hora_fecha_evento='"+fechaEvento.ToString("yyyy-MM-dd HH:mm:ss") +"',lugar_evento='"+lugarEvento+"',status_seguimiento='"+status+ "',folio_seguimiento='"+folio+"'";

                comando = new MySqlCommand(usuario, ConexionBD.GetConexionClient());
                comando.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }

            return true;
        }

        public Boolean insertarInformacionUnidad(Object tipoUnidad, DateTime HoraArribo, String reporteFinal, String comentarios, Object noDron, String placaUnidad, String oficialAsignado)
        {

            try
            {
                //Guarda datos del usuario
                String unidadApoyo = "INSERT INTO unidad_apoyo SET tipo_unidad='" +tipoUnidad+ "',hora_arribo='" +HoraArribo.ToString("HH:mm:ss") + "',reporte_final='" + reporteFinal + "',comentarios='" + comentarios + "',numero_dron='" + noDron + "',placa_unidad='"+placaUnidad+ "', oficial_asignado='"+oficialAsignado+"'";

                comando = new MySqlCommand(unidadApoyo, ConexionBD.GetConexionClient());
                comando.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }

            return true;
        }

        public Boolean insertarInformacionOperador(String nombreOficial, String centroMonitoreo, String Id, String eventoReportado, String comentarios, String folioSeguimiento)
        {

            try
            {
                //Guarda datos del usuario
                String operador = "INSERT INTO operador SET nombre_completo='" + nombreOficial + "',centro_monitoreo='" + centroMonitoreo + "',numero_placa='" + Id + "',evento_reportado='" + eventoReportado + "',comentarios='" + comentarios + "',folio_seguimiento='" + folioSeguimiento +"'";

                comando = new MySqlCommand(operador, ConexionBD.GetConexionClient());
                comando.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }

            return true;
        }

    }
}
