using ENTITYS;
using MAPPERS;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public  class EnvioDAL
    {
        public void AgregarEnvioBS(Envio Valido)
        {
            try
            {
                using(SqlConnection conexion = new SqlConnection(Conexiones.BS()))
                {
                    conexion.Open();
                    string consulta = "INSERT INTO ENVIO ( ZONA, PRECIO) VALUES (@zona, @precio)";
                    using (SqlCommand comando = new SqlCommand (consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@zona",Valido.Zona);
                        comando.Parameters.AddWithValue("@precio",Valido.Precio);
                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch
            {
                throw;
            }
        }
        public List<Envio> ObtenerEnviosBS()
        {
            try
            {
                List<Envio> envios = new List<Envio>();
                using (SqlConnection conexion = new SqlConnection(Conexiones.BS()))
                {
                    conexion.Open();
                    string consulta = "SELECT * FROM ENVIO ";
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                Envio encontrado = EnvioMapper.map(lector);
                                envios.Add(encontrado);
                            }
                        }
                    }
                }
                return envios;
            }
            
            catch
            {
                throw;
            }
        }
        public Envio BuscarIDenBS(int ID)
        {
            try
            {
                Envio buscado = new Envio();
                using (SqlConnection conexion = new SqlConnection(Conexiones.BS()))
                {
                    conexion.Open();
                    string consulta = "SELECT * FROM ENVIO WHERE ID_ENVIO = @id";
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@id", ID);
                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                buscado = EnvioMapper.map(lector);
                            }
                        }

                    }
                }
                return buscado;

            }
            catch
            {
                throw;
            }
        }
    }
}
