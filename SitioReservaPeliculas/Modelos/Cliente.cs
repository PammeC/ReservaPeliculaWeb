﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitioReservaPeliculas.Modelos
{
    internal class ClienteDB
    {
        public class Cliente
        {
            public int id { get; set; }
            public string nombre { get; set; }
            public string apellido { get; set; }
            public string correo { get; set; }
            public string contrasena { get; set; }
        }
    }
}