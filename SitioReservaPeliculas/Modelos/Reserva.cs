using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using static SitioReservaPeliculas.Modelos.ReservaDB;

namespace SitioReservaPeliculas.Modelos
{
    internal class ReservaDB
    {
        public class Reserva
        {
            public int id { get; set; }
            public int Cliente { get; set; }
            public string Fecha { get; set; }
            public string Hora { get; set; }
            public int Pelicula { get; set; }
        }
    }
}