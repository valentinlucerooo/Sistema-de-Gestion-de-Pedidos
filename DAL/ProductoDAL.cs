using ENTITYS;
using MAPPERS;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductoDAL
    {
        public List<Producto> ObtenerProductosBS()
        {
            try
            {
                List<Producto> productos = new List<Producto>();
                using (SqlConnection conexion = new SqlConnection(Conexiones.BS()))
                {
                    conexion.Open();
                    string consulta = "SELECT * FROM PRODUCTO";
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                Producto encontrado = ProductoMapper.map(lector);
                                productos.Add(encontrado);

                            }

                        }
                    }
                }
                return productos;
            }
            catch
            {
                throw;
            }

        }
        public Producto ProductoByIDenBS(int ID)
        {
            try
            {
                Producto buscado = new Producto();
                buscado = null;
                using (SqlConnection conexion = new SqlConnection(Conexiones.BS()))
                {
                    conexion.Open();
                    string consulta = "SELECT ID_PRODUCTO, TIPO_PRODUCTO, DESCRIPCION, PRECIO FROM PRODUCTO WHERE ID_PRODUCTO = @id ";
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("id", ID);
                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                buscado = ProductoMapper.map(lector);
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
        public void AgregarProductoBS(Producto Valido)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexiones.BS()))
                {
                    conexion.Open();
                    string consulta = "INSERT INTO PRODUCTO ( TIPO_PRODUCTO, DESCRIPCION, PRECIO) VALUES ( @tipo, @descripcion, @precio)";
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@tipo", Valido.ProductoTipo);
                        comando.Parameters.AddWithValue("@descripcion", Valido.Descripcion);
                        comando.Parameters.AddWithValue("@precio", Valido.Precio);
                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
