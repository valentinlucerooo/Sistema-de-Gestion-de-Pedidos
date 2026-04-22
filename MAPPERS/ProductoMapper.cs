using ENTITYS;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAPPERS
{
    public static class ProductoMapper
    {
        public static Producto map(SqlDataReader lector)
        {
            Producto nuevo = new Producto();
            nuevo.IDProducto = Convert.ToInt32(lector["ID_PRODUCTO"]);
            nuevo.ProductoTipo = lector["TIPO_PRODUCTO"].ToString();
            nuevo.Descripcion = lector["DESCRIPCION"].ToString();
            nuevo.Precio = Convert.ToDecimal(lector["PRECIO"]);
            return nuevo;
        }

    }
}
