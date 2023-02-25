using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPRNIII_U1_EA_MAZM
{
    class Evento
    {
        //Cabecera de variables
        private int idEvento;
        private string tipoEvento;
        private string apoyoSolicitado;
        private string coordenadaLatitud;
        private string coordenadaLongitud;
        private string descripcion;


        //Setters & Getters
        public int IdEvento { get => idEvento; set => idEvento = value; }
        public string TipoEvento { get => tipoEvento; set => tipoEvento = value; }
        public string ApoyoSolicitado { get => apoyoSolicitado; set => apoyoSolicitado = value; }
        public string CoordenadaLatitud { get => coordenadaLatitud; set => coordenadaLatitud = value; }
        public string CoordenadaLongitud { get => coordenadaLongitud; set => coordenadaLongitud = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

   }
}
