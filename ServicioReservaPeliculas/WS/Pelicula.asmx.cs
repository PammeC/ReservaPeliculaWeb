using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using static ServicioReservaPeliculas.Modelos.PeliculaDB.Pelicula;
using ServicioReservaPeliculas.Modelos;
using System.Configuration;
using Newtonsoft.Json;

namespace ServicioReservaPeliculas.WS
{

    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]


    public class Pelicula : System.Web.Services.WebService
    {

        static string strconexion = ConfigurationManager.ConnectionStrings["ReservaPelicualas"].ConnectionString;
        public SqlConnection Conexion = new SqlConnection(strconexion);
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader leerFilas;

        [WebMethod]
        public String mostrarPelicula(string condicion = "")
        {
            List<PeliculaDB.Pelicula> Pelicula = new List<PeliculaDB.Pelicula>();
            string sql = "";
            using (Conexion)
            {
                if (condicion == "")
                {
                    sql = "Select * From peliculas";
                }
                else
                {
                    sql = "Select * From peliculas Where id Like @condicion";
                }
                //Sanitización
                SqlCommand comando = new SqlCommand();
                comando.Connection = Conexion;
                comando.CommandText = sql;
                comando.Parameters.AddWithValue("@condicion", condicion + '%');
                comando.CommandType = CommandType.Text;
                try
                {
                    Conexion.Open();
                    SqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        PeliculaDB.Pelicula oPelicula = new PeliculaDB.Pelicula();
                        oPelicula.id = reader.GetInt32(0);
                        oPelicula.nombre = reader.GetString(1);
                        oPelicula.descripcion = reader.GetString(2);
                        oPelicula.categoria = reader.GetInt32(3);
                        Pelicula.Add(oPelicula);
                    }
                    reader.Close();
                    Conexion.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error: " + ex.Message);
                }
            }
            String jsonResult = JsonConvert.SerializeObject(Pelicula);
            return jsonResult;
        }
        [WebMethod]
        public String registrarPelicula(string nombre, string descripcion, int categoria)
        {
            String res = "";
            using (Conexion)
            {
                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = Conexion;
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.CommandText = "Crear_Peliculas";
                cmd2.Parameters.AddWithValue("@P_Nombre", nombre);
                cmd2.Parameters.AddWithValue("@P_Descripcion", descripcion);
                cmd2.Parameters.AddWithValue("@P_categoria", categoria);
                try
                {
                    Conexion.Open();
                    cmd2.ExecuteNonQuery();
                    res = "Pelicula Agregada con exito";
                }
                catch (Exception ex)
                {
                    res = "Error: No se logró crear pelicula";
                }

            }
            return res;
        }
        [WebMethod]
        public String listarCategoria()
        {
            DataTable dt = new DataTable();
            Comando.Connection = Conexion;
            Comando.Connection.Open();
            Comando.CommandText = "ListarPelicula";
            Comando.CommandType = CommandType.StoredProcedure;
            leerFilas = Comando.ExecuteReader();
            dt.Load(leerFilas);
            leerFilas.Close();
            Conexion.Close();
            String jsonResult = JsonConvert.SerializeObject(dt);
            return jsonResult;
        }
        [WebMethod]
        public String eliminarPelicula(int íd)
        {
            String res = "";
            using (Conexion)
            {
                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = Conexion;
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.CommandText = "EliminarPelicula";
                cmd2.Parameters.AddWithValue("@id", íd);
                try
                {
                    Conexion.Open();
                    cmd2.ExecuteNonQuery();
                    res = "success";
                }
                catch (Exception ex)
                {
                    res = "Pelicula Referenciado en una reserva, no se logró eliminar registro";
                }

            }
            return res;
        }
        [WebMethod]
        public String modificarPelicula(int id, string nombre, string descripcion, int categoria)
        {
            String res = "";
            using (Conexion)
            {
                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = Conexion;
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.CommandText = "ActualizarPelicula";
                cmd2.Parameters.AddWithValue("@id", id);
                cmd2.Parameters.AddWithValue("@nombre", nombre);
                cmd2.Parameters.AddWithValue("@descripcion", descripcion);
                cmd2.Parameters.AddWithValue("@id_categoria", categoria);
                try
                {
                    Conexion.Open();
                    cmd2.ExecuteNonQuery();
                    res = "success";
                }
                catch (Exception ex)
                {
                    res = "No se logró modificar la Pelicula";
                }

            }
            return res;
        }
    }
}
