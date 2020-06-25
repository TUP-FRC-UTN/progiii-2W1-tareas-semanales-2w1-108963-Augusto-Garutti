using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Auto.Models
{
    public class ConexionBD
    {

        string cadenaConexion = @"Data Source=DESKTOP-E8575KS;Initial Catalog=Autos;Integrated Security=True";

       

        public List<Marcas>ListaMarcas()
        {
            List<Marcas> lista = new List<Marcas>();
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();
            SqlCommand comando = new SqlCommand("select * from Marcas",conexion);
            SqlDataReader datos = comando.ExecuteReader();

            while (datos.Read())
            {
                int idMarca = datos.GetInt32(0);
                string nombre = datos.GetString(1);

                Marcas m = new Marcas(idMarca, nombre);
                lista.Add(m);
            }
            return lista;
        }

        public void Alta(Autos a)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();
            SqlCommand comando = new SqlCommand("insert into Autos values(@patente, @idMarcas, @promocion, @precio, @km)", conexion);
            comando.Parameters.Add(new SqlParameter("@patente",a.Patente));
            comando.Parameters.Add(new SqlParameter("@idMarcas",a.IdMarca));
            comando.Parameters.Add(new SqlParameter("@promocion",a.Promocion));
            comando.Parameters.Add(new SqlParameter("@precio",a.Precio));
            comando.Parameters.Add(new SqlParameter("@km",a.Km));

            comando.ExecuteNonQuery();
            conexion.Close();
        }
    }
}