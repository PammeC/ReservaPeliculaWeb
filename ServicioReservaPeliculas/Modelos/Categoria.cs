using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ServicioReservaPeliculas.Modelos.CategoriaDB;

namespace ServicioReservaPeliculas.Modelos
{
    internal class CategoriaDB
    {
        public class Categoria
        {
            public int id { get; set; }
            public string nombre { get; set; }
        }
    }
}