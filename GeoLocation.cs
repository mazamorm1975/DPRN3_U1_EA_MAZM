using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPRNIII_U1_EA_MAZM
{
    class GeoLocation
    {
        //calculo de la distancia
        public static double DistanceTo(double lat1, double lon1, double lat2, double lon2, char unit = 'K')
        {
            double rlat1 = Math.PI * lat1 / 180;
            double rlat2 = Math.PI * lat2 / 180;
            double theta = lon1 - lon2;
            double rtheta = Math.PI * theta / 180;
            double dist =
                Math.Sin(rlat1) * Math.Sin(rlat2) + Math.Cos(rlat1) *
                Math.Cos(rlat2) * Math.Cos(rtheta);
            dist = Math.Acos(dist);
            dist = dist * 180 / Math.PI;
            dist = dist * 60 * 1.1515;

            switch (unit)
            {
                case 'K': //Kilometers -> default
                    return dist * 1.609344;
                case 'N': //Nautical Miles 
                    return dist * 0.8684;
                case 'M': //Miles
                    return dist;
            }

            return dist;
        }

        //Calculo del tiempo estimado del recorrido
        public static double TiempoDelRecorrido(double distancia)
        {
            double tiempo = 0.0;
            //Velocidad del dron 120 / hr.
            double velocidad = 5;
            tiempo = (distancia / velocidad) * 100;

            return Math.Round(tiempo, 2);
        }


        //Calculo de la direccion cardinal
        public static string DegreesToCardinal(double degrees)
        {
            string[] caridnals = { "North", "North East", "East", "South East", "South", "South West", "West", "North West", "N" };
            return caridnals[(int)Math.Round(((double)degrees % 360) / 45)];
        }


        public static DateTime AjusteDeTiempo(int anio, int m, int d, int h, int min, double distancia)
        {
            //Declaracion de variables
            int horas1 = 0;
            int horas2 = 0;
            int min1 = 0;
            int min2 = 0;


            //Datos de trabajo
            int residuo = 0;


            //Datos de salida
            int rDia = 0;
            int rHoras = 0;
            int rSeg = 0;

            horas1 = h;
            min1 = min;


            //Se obtienen los datos de los calculos de tiempo y distancia.
            double tiempo = GeoLocation.TiempoDelRecorrido(distancia);

            double tiempoRecorrido = (double)tiempo;

            int parteEntera = (int)tiempoRecorrido;

            int parteDecimal = (int)((tiempoRecorrido - parteEntera) * 100);



            //Se piden los datos del segundo tiempo
            horas2 = 0;
            min2 = parteEntera;


            //suma de minutos
            int rMin = min1 + min2 + residuo;
            residuo = 0;

            //Verificacion si se ha excedido de la hora

            while (rMin > 59)
            {
                rMin = rMin - 60;
                residuo = residuo + 1;
            }


            //Suma de las horas
            rHoras = horas1 + horas2 + residuo;
            residuo = 0;

            //verificacion de si se ha excedido el dia

            if (rHoras > 23)
            {
                rHoras = rHoras - 24;
                d = d + 1;
            }

            DateTime fecha = new DateTime(anio, m, d, rHoras, rMin, rSeg);
            return fecha;
            //Console.WriteLine(fecha);
        }

    }
}
