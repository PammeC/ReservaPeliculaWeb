using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SitioReservaPeliculas.Modelos;

namespace SitioReservaPeliculas.Modelos
{
    internal class PeliculaDB
    {
        public class Pelicula
        {
            public int id { get; set; }
            public string nombre { get; set; }
            public string descripcion { get; set; }
            public int categoria { get; set; }
        }
    }
}