using ENTITYS;
using MAPPERS;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL
{
    public class PedidoDAL
    {
        private EnvioDAL envios = new EnvioDAL();
        private ProductoDAL productos = new ProductoDAL();
        public void AgregarPedidoBS(Pedido Valido)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexiones.BS()))
                {
                    conexion.Open();
                    string consulta = "INSERT INTO PEDIDO ( ID_PRODUCTO, CANTIDAD, ID_ENVIO, MONTO_TOTAL, PRIORIDAD, FECHA_REGISTRO  ) VALUES (@producto, @cantidad, @envio, @monto, @prioridad, @fecha)";
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@producto", Valido.Producto.IDProducto);
                        comando.Parameters.AddWithValue("@cantidad", Valido.Cantidad);
                        comando.Parameters.AddWithValue("@envio", Valido.Envio.IDEnvio);
                        comando.Parameters.AddWithValue("@monto", Valido.MontoTotal);
                        comando.Parameters.AddWithValue("@prioridad", Valido.Prioridad);
                        comando.Parameters.AddWithValue("@fecha", Valido.FechaRegistro);

                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch
            {
                throw;
            }
        }
        public List<Pedido> ObtemerPedidosBS()
        {
            try
            {
                List<Pedido> Pedidos = new List<Pedido>();
                using (SqlConnection conexion = new SqlConnection(Conexiones.BS()))
                {
                    conexion.Open();
                    string consulta = "SELECT * FROM PEDIDO";
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                Pedido nuevo = new Pedido();
                                Envio envio = envios.BuscarIDenBS(Convert.ToInt32(lector["ID_ENVIO"]));
                                Producto producto = productos.ProductoByIDenBS(Convert.ToInt32(lector["ID_PRODUCTO"]));
                                nuevo = PedidoMapper.map(producto, envio, lector);
                                Pedidos.Add(nuevo);
                            }


                        }

                    }
                }


                return Pedidos;
            }
            catch
            {
                throw;
            }

        }
        public Pedido GetByIDBS(int P)
        {
            try
            {
                Pedido buscado = null;
                using (SqlConnection conexion = new SqlConnection(Conexiones.BS()))
                {
                    conexion.Open();
                    string consulta = "SELECT * FROM PEDIDO WHERE ID_PEDIDO = @id";
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@id", P);
                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                Producto producto = productos.ProductoByIDenBS(Convert.ToInt32(lector["ID_PRODUCTO"]));
                                Envio envio = envios.BuscarIDenBS(Convert.ToInt32(lector["ID_ENVIO"]));
                                buscado = PedidoMapper.map(producto, envio, lector);

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
        public void ModificarPedidoBS(Pedido pedido)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexiones.BS()))
                {
                    conexion.Open();
                    string consulta = "UPDATE PEDIDO SET ID_PRODUCTO = @producto, CANTIDAD = @cantidad, ID_ENVIO = @envio, MONTO_TOTAL = @monto ,PRIORIDAD = @prioridad, FECHA_REGISTRO = @fecha WHERE ID_PEDIDO = @id";
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@id", pedido.IDpedido);
                        comando.Parameters.AddWithValue("@producto", pedido.Producto.IDProducto);
                        comando.Parameters.AddWithValue("@cantidad", pedido.Cantidad);
                        comando.Parameters.AddWithValue("@envio", pedido.Envio.IDEnvio);
                        comando.Parameters.AddWithValue("@monto", pedido.MontoTotal);
                        comando.Parameters.AddWithValue("@prioridad", pedido.Prioridad);
                        comando.Parameters.AddWithValue("@fecha", pedido.FechaRegistro);
                        comando.ExecuteNonQuery();
                    }
                }


            }
            catch
            {
                throw;
            }
        }

        public void eliminarPedidoBS(int ID)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexiones.BS()))
                {
                    conexion.Open();
                    string consulta = "DELETE FROM PEDIDO WHERE ID_PEDIDO = @id";
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@id", ID);
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
