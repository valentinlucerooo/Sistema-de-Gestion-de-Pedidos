using ENTITYS;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAPPERS
{
    public static class PedidoMapper
    {
        public static Pedido map (Producto producto , Envio envio ,SqlDataReader lector)
        {
            Pedido nuevo = new Pedido();
            nuevo.IDpedido = Convert.ToInt32(lector["ID_PEDIDO"]);
            nuevo.Producto= producto;
            nuevo.Cantidad = Convert.ToInt32(lector["CANTIDAD"]);
            nuevo.Envio = envio;
            nuevo.MontoTotal = Convert.ToDecimal(lector["MONTO_TOTAL"]);
            nuevo.Prioridad = lector["PRIORIDAD"].ToString();
            nuevo.FechaRegistro = Convert.ToDateTime(lector["FECHA_REGISTRO"]);

            return nuevo;
        }
    }
}
