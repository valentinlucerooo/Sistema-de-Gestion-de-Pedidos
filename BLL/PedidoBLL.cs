using DAL;
using ENTITYS;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Xml.Linq;

namespace BLL
{
    public  class PedidoBLL
    {
        private PedidoDAL dal = new PedidoDAL();
        private EnvioDAL envioDAL= new EnvioDAL();
        private ProductoDAL productoDAL = new ProductoDAL();
        public List<Pedido> GetAll()
        {
            try
            {
               return dal.ObtemerPedidosBS();
             
            }
            catch
            {
                throw new BLLException("Error al obtener los pedidos.");
            }
        }
        public void ValidarBorrador(List<Pedido> borrador) 
        {
            try
            {
                if (borrador == null || borrador.Count == 0)
                throw new BLLException("el borrador no puede estar vacio.");
                using (var trx = new TransactionScope())
                {
                    foreach (var pedido in borrador)
                    {
                        ValidarPedido(pedido);
                    }
                    foreach (var pedido in borrador)
                    {
                        dal.AgregarPedidoBS(pedido);
                        //aqui se guardaria el pedido en la base de datos

                    }
                    trx.Complete();
                }

            }
            catch
            {
                throw new BLLException("Error al validar el borrador.");

            }


        }
        public void ModificarPedido(Pedido Modificado) 
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    dal.ModificarPedidoBS(Modificado);
                    //aqui se modificaria el pedido en la base de datos
                    trx.Complete();

                }
            }
            catch
            {
                throw new BLLException ("Error al modificar el pedido.");
            }

        }
        public void BorrarPedido(int ID)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    dal.eliminarPedidoBS(ID);
                    //aqui se eliminaría el pedido en la base de datos
                    trx.Complete();

                }
            }
            catch
            {
                throw new BLLException("Error al modificar el pedido.");
            }

        }


        public void ValidarPedido(Pedido Nuevo)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    

                    if (Nuevo.Producto == null)
                    {
                        throw new BLLException("el producto no puede estar vacio.");
                    }
                    if (Nuevo.Cantidad <= 0)
                    {
                        throw new BLLException("la cantidad debe ser mayor a cero.");
                    }
                    if (Nuevo.Envio == null)
                    {
                        throw new BLLException("debe seleccionar una zona de envio.");
                    }
                    if (Nuevo.Envio.Zona.Length <=3)
                    {
                        throw new BLLException("la zona debe tener al menos 4 caracteres");
                    }
                    if (Nuevo.Prioridad.Length <= 3)
                    {
                        throw new BLLException("la prioridad debe tener al menos 4 caracteres");
                    }
                    Nuevo.FechaRegistro = DateTime.Now;
                    Nuevo.Producto = productoDAL.ProductoByIDenBS(Nuevo.Producto.IDProducto);
                    Nuevo.Envio = envioDAL.BuscarIDenBS(Nuevo.Envio.IDEnvio);
                    Nuevo.MontoTotal = (Nuevo.Producto.Precio * Nuevo.Cantidad) + Nuevo.Envio.Precio;
                    dal.AgregarPedidoBS(Nuevo);

                    trx.Complete();
                }
            }
            catch
            {
                throw new BLLException("Error al validar el pedido.");
            }
            



        }
    }
}
