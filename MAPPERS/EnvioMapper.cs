using ENTITYS;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAPPERS
{
    public static   class EnvioMapper
    {
        public static  Envio map ( SqlDataReader lector)
        {
            Envio nuevo = new Envio();
            nuevo.IDEnvio = Convert.ToInt32(lector["ID_ENVIO"]);
            nuevo.Zona = lector["ZONA"].ToString();
            nuevo.Precio = Convert.ToDecimal(lector["PRECIO"]);
            return nuevo;
        }
    }
}
