using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPRNIII_U1_EA_MAZM
{
    class Operador
    {
        //Cabecera de variables
        private int idOperador;
        private string nombreCompleto;
        private string centroMonitoreo;
        private string numeroPlaca;
        private string eventoReportado;
        private string comentarios;
        private int idUsuario;
        private int idUnidadApoyo;


        //Setters & Getters
        public int IdOperador { get => idOperador; set => idOperador = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public string CentroMonitoreo { get => centroMonitoreo; set => centroMonitoreo = value; }
        public string NumeroPlaca { get => numeroPlaca; set => numeroPlaca = value; }
        public string EventoReportado { get => eventoReportado; set => eventoReportado = value; }
        public string Comentarios { get => comentarios; set => comentarios = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public int IdUnidadApoyo { get => idUnidadApoyo; set => idUnidadApoyo = value; }
    }
}
