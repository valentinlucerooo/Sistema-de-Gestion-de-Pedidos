using DAL;
using ENTITYS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BLL
{
    public   class ProductoBLL
    {
        private ProductoDAL dal = new ProductoDAL();
        public List<Producto> GetAllProductos()
        {
            try
            {                
               return dal.ObtenerProductosBS();              
            }
            catch (Exception ex)
            {
                {
                    throw new BLLException("Error al obtener los productos ");
                }
            }
        }
        public void ValidarListaPRoductos(List<Producto> Productos)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    if (Productos == null || Productos.Count == 0)
                    {
                        throw new BLLException("Debe agregar al menos un producto al borrador");
                    }
                    foreach (var producto in Productos)
                    {
                        ValidarProducto(producto);
                    }
                    foreach (var producto in Productos)
                    {
                        dal.AgregarProductoBS(producto);
                    }
                    trx.Complete();

                }
            }
            catch (Exception ex)
            {
                throw new BLLException("Error al validar los productos");

            }
        }
        public void ValidarProducto(Producto Nuevo)
        {
            try
            {
                using (var trx =new  TransactionScope())
                {
                    if (Nuevo.ProductoTipo == null)
                    {
                        throw new BLLException("debe indicar que tipo de producto es.");
                    }
                    if (Nuevo.Descripcion.Length <= 4)
                    {
                        throw new BLLException("la descripcion del produicto debe tener al menos 5 caracteres");
                    }
                    dal.AgregarProductoBS(Nuevo);
                    trx.Complete(); 
                }

            }
            catch 
            {
                throw new BLLException("Error al agregar el producto");
            }

        }



    }
}
