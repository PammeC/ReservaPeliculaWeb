using ServicioReservaPeliculas.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Configuration;
using static ServicioReservaPeliculas.Modelos.CategoriaDB.Categoria;
using Newtonsoft.Json;

namespace ServicioReservaPeliculas.WS
{

    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class Categoria : System.Web.Services.WebService
    {
        private string strconexion = ConfigurationManager.ConnectionStrings["ReservaPelicualas"].ConnectionString;

        [WebMethod]
        public String registrarCategoria(string nombre)
        {
            using (SqlConnection Conexion = new SqlConnection(strconexion))
            {
                SqlCommand cmd2 = new SqlCommand
                {
                    Connection = Conexion,
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "InsertarCategoria"
                };
                cmd2.Parameters.AddWithValue("@nombre", nombre);
                try
                {
                    Conexion.Open();
                    cmd2.ExecuteNonQuery();
                    return "Categoria Agregada con éxito";
                }
                catch (Exception ex)
                {
                    return "Error: No se logró crear la categoria";
                }
            }
        }
        [WebMethod]
        public String TraerCategoria(string condicion = "")
        {
            List<CategoriaDB.Categoria> Categoria = new List<CategoriaDB.Categoria>();
            using (SqlConnection Conexion = new SqlConnection(strconexion))
            {
                string sql = (condicion == "")
                    ? "Select * From categorias"
                    : "Select * From categorias Where id Like @condicion";
                using (SqlCommand comando = new SqlCommand(sql, Conexion))
                {
                    comando.Parameters.AddWithValue("@condicion", condicion + '%');
                    comando.CommandType = CommandType.Text;
                    try
                    {
                        Conexion.Open();
                        SqlDataReader reader = comando.ExecuteReader();
                        while (reader.Read())
                        {
                            CategoriaDB.Categoria oCategoria = new CategoriaDB.Categoria();
                            oCategoria.id = reader.GetInt32(0);
                            oCategoria.nombre = reader.GetString(1);
                            Categoria.Add(oCategoria);
                        }
                        reader.Close();
                        Conexion.Close();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error: " + ex.Message);
                    }
                }
            }
            String jsonResult = JsonConvert.SerializeObject(Categoria);
            return jsonResult;
        }
        [WebMethod]
        public String eliminarCategoria(int íd)
        {
            using (SqlConnection Conexion = new SqlConnection(strconexion))
            {
                using (SqlCommand cmd2 = new SqlCommand("EliminarCategoria", Conexion))
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
                        return "Categoria Referenciada en un Pelicula, no se logró eliminar registro";
                    }
                }
            }
        }
        [WebMethod]
        public String modificarCategoria(int id, string nombre)
        {
            using (SqlConnection Conexion = new SqlConnection(strconexion))
            {
                using (SqlCommand cmd2 = new SqlCommand("ActualizarCategoria", Conexion))
                {
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@id", id);
                    cmd2.Parameters.AddWithValue("@nombre", nombre);
                    try
                    {
                        Conexion.Open();
                        cmd2.ExecuteNonQuery();
                        return "success";
                    }
                    catch (Exception ex)
                    {
                        return "Error: no se logró modificar categoria";
                    }
                }
            }
        }
    }
}
