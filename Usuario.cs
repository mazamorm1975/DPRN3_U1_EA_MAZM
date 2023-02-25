using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPRNIII_U1_EA_MAZM
{
    class Usuario
    {
        //Cabecera de variables
        private int idUsuario;
        private string nombreCompleto;
        private DateTime horaYFechaEvento;
        private string lugarEvento;
        private string statusSeguimiento;
        private string folioSeguimiento;
        private int eventoId;

        //Setters & Getters
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public DateTime HoraYFechaEvento { get => horaYFechaEvento; set => horaYFechaEvento = value; }
        public string LugarEvento { get => lugarEvento; set => lugarEvento = value; }
        public string StatusSeguimiento { get => statusSeguimiento; set => statusSeguimiento = value; }
        public string FolioSeguimiento { get => folioSeguimiento; set => folioSeguimiento = value; }
        public int EventoId { get => eventoId; set => eventoId = value; }



    }
}
