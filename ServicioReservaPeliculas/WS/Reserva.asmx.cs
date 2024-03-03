using ServicioReservaPeliculas.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using static ServicioReservaPeliculas.Modelos.ReservaDB.Reserva;
using System.Configuration;
using Newtonsoft.Json;
using static ServicioReservaPeliculas.Modelos.PeliculaDB;

namespace ServicioReservaPeliculas.WS
{

    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class Reserva : System.Web.Services.WebService
    {
        static string strconexion = ConfigurationManager.ConnectionStrings["ReservaPelicualas"].ConnectionString;
        private SqlDataReader leerFilas;

        [WebMethod]
        public String registrarReserva(int cliente, string fechaSeleccionada, string hora, int pelicula)
        {
            using (SqlConnection Conexion = new SqlConnection(strconexion))
            {
                using (SqlCommand cmd2 = new SqlCommand("InsertarPelicula", Conexion))
                {
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@P_cliente", cliente);
                    cmd2.Parameters.AddWithValue("@P_fecha", DateTime.Parse(fechaSeleccionada));
                    cmd2.Parameters.AddWithValue("@P_hora", DateTime.Parse(hora));
                    cmd2.Parameters.AddWithValue("@P_IdPelicula", pelicula);
                    try
                    {
                        Conexion.Open();
                        cmd2.ExecuteNonQuery();
                        return "Reserva Agregada con exito";
                    }
                    catch (Exception ex)
                    {
                        return "Error: no se logró agregar reserva";
                    }
                }
            }
        }
        [WebMethod]
        public String listarClientes()
        {
            DataTable dt = new DataTable();
            using (SqlConnection Conexion = new SqlConnection(strconexion))
            {
                using (SqlCommand comando = new SqlCommand("ListarClientes", Conexion))
                {
                    comando.Connection.Open();
                    comando.CommandType = CommandType.StoredProcedure;
                    leerFilas = comando.ExecuteReader();
                    dt.Load(leerFilas);
                    leerFilas.Close();
                }
            }
            String jsonResult = JsonConvert.SerializeObject(dt);
            return jsonResult;
        }
        [WebMethod]
        public String listarPeliculas()
        {
            DataTable dt = new DataTable();
            using (SqlConnection Conexion = new SqlConnection(strconexion))
            {
                using (SqlCommand comando = new SqlCommand("listarPeliculas", Conexion))
                {
                    comando.Connection.Open();
                    comando.CommandType = CommandType.StoredProcedure;
                    leerFilas = comando.ExecuteReader();
                    dt.Load(leerFilas);
                    leerFilas.Close();
                }
            }
            String jsonResult = JsonConvert.SerializeObject(dt);
            return jsonResult;
        }
        [WebMethod]
        public String TraerReserva(string condicion = "")
        {
            List<ReservaDB.Reserva> Reserva = new List<ReservaDB.Reserva>();
            using (SqlConnection Conexion = new SqlConnection(strconexion))
            {
                string sql = (condicion == "")
                    ? "Select * From reserva_peliculas"
                    : "Select * From reserva_peliculas Where cliente Like @condicion";
                using (SqlCommand comando = new SqlCommand(sql, Conexion))
                {
                    if (condicion != "")
                    {
                        comando.Parameters.AddWithValue("@condicion", condicion);
                    }
                    else
                    {
                        comando.Parameters.AddWithValue("@condicion", condicion + '%');
                    }
                    comando.CommandType = CommandType.Text;
                    try
                    {
                        Conexion.Open();
                        SqlDataReader reader = comando.ExecuteReader();
                        while (reader.Read())
                        {
                            ReservaDB.Reserva oReserva = new ReservaDB.Reserva
                            {
                                id = reader.GetInt32(0),
                                Cliente = reader.GetInt32(1),
                                Fecha = reader.GetDateTime(2).ToString(),
                                Hora = reader.GetTimeSpan(3).ToString(),
                                Pelicula = reader.GetInt32(4)
                            };
                            Reserva.Add(oReserva);
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error: " + ex.Message);
                    }
                }
            }
            String jsonResult = JsonConvert.SerializeObject(Reserva);
            return jsonResult;
        }
        [WebMethod]
        public String eliminarReserva(int íd)
        {
            using (SqlConnection Conexion = new SqlConnection(strconexion))
            {
                using (SqlCommand cmd2 = new SqlCommand("EliminarReserva", Conexion))
                {
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@id", íd);
                    try
                    {
                        Conexion.Open();
                        cmd2.ExecuteNonQuery();
                        return "success";
                    }
                    catch (Exception ex)
                    {
                        return "Error: no se logró eliminar reserva";
                    }
                }
            }
        }
        [WebMethod]
        public String modificarReserva(int id, int cliente, string fecha, string hora, int pelicula)
        {
            using (SqlConnection Conexion = new SqlConnection(strconexion))
            {
                using (SqlCommand cmd2 = new SqlCommand("ActualizarReserva", Conexion))
                {
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@id", id);
                    cmd2.Parameters.AddWithValue("@cliente", cliente);
                    cmd2.Parameters.AddWithValue("@fecha", DateTime.Parse(fecha));
                    cmd2.Parameters.AddWithValue("@hora", DateTime.Parse(hora));
                    cmd2.Parameters.AddWithValue("@id_pelicula", pelicula);
                    try
                    {
                        Conexion.Open();
                        cmd2.ExecuteNonQuery();
                        return "success";
                    }
                    catch (Exception ex)
                    {
                        return "Error: no se logró modificar reserva";
                    }
                }
            }
        }
        [WebMethod]
        public decimal CalcularPrecioTotal(int idCliente)
        {
            int totalReservas = ObtenerTotalReservasRegistradas(idCliente);
            decimal precioFijoPorReserva = 4.0m;
            decimal precioTotal = totalReservas * precioFijoPorReserva;

            return precioTotal;
        }

        [WebMethod]
        public int ObtenerTotalReservasRegistradas(int idCliente)
        {
            int totalReservas = 0;

            using (SqlConnection Conexion = new SqlConnection(strconexion))
            {
                using (SqlCommand comando = new SqlCommand("SELECT COUNT(*) FROM reserva_peliculas WHERE cliente = @idCliente", Conexion))
                {
                    comando.Parameters.AddWithValue("@idCliente", idCliente);

                    try
                    {
                        Conexion.Open();
                        totalReservas = (int)comando.ExecuteScalar();
                    }
                    catch (Exception ex)
                    {
                        // Manejar la excepción si es necesario
                        Console.WriteLine("Error al obtener el número total de reservas: " + ex.Message);
                    }
                }
            }
            return totalReservas;
        }

        [WebMethod]
        public string ObtenerNombrePelicula(int idPelicula)
        {
            string nombrePelicula = string.Empty;
            using (SqlConnection Conexion = new SqlConnection(strconexion))
            {
                using (SqlCommand comando = new SqlCommand("SELECT nombre FROM peliculas WHERE id = @idPelicula", Conexion))
                {
                    comando.Parameters.AddWithValue("@idPelicula", idPelicula);

                    try
                    {
                        Conexion.Open();
                        object result = comando.ExecuteScalar();
                        if (result != null)
                        {
                            nombrePelicula = result.ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejar la excepción si es necesario
                        Console.WriteLine("Error al obtener el nombre de la película: " + ex.Message);
                    }
                }
            }

            return nombrePelicula;
        }
    }
}
