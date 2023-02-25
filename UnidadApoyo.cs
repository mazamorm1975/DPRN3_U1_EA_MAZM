using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPRNIII_U1_EA_MAZM
{
    class UnidadApoyo
    {
        //Cabecera de variables
        private int idUnidadApoyo;
        private string tipoUnidad;
        private TimeZone horaArribo;
        private string reporteFinal;
        private string comentarios;
        private string numeroDron;
        private string placaUnidad;
        private string oficialAsignado;

        //Setters & Getters
        public int IdUnidadApoyo { get => idUnidadApoyo; set => idUnidadApoyo = value; }
        public string TipoUnidad { get => tipoUnidad; set => tipoUnidad = value; }
        public TimeZone HoraArribo { get => horaArribo; set => horaArribo = value; }
        public string ReporteFinal { get => reporteFinal; set => reporteFinal = value; }
        public string Comentarios { get => comentarios; set => comentarios = value; }
        public string NumeroDron { get => numeroDron; set => numeroDron = value; }
        public string PlacaUnidad { get => placaUnidad; set => placaUnidad = value; }
        public string OficialAsignado { get => oficialAsignado; set => oficialAsignado = value; }
    }
}
