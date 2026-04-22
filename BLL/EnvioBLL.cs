using DAL;
using ENTITYS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Xml.Linq;

namespace BLL
{
     public class EnvioBLL
    {
        private EnvioDAL dal = new EnvioDAL(); 
        public void ValidarLIstaEnvios(List<Envio> Borrador)
        {
            try 
            {
                if (Borrador == null || Borrador.Count == 0)
                {
                    throw new BLLException("El borrador de envios no puede estar vacio.");
                }
                using (var trx = new TransactionScope())
                {
                    foreach (var envio in Borrador)
                    {
                        ValidarEnvio(envio);
                    }
                    foreach (var envio in Borrador)
                    {
                        dal.AgregarEnvioBS(envio);
                    }
                    trx.Complete();
                }
            }
            catch
            {
                throw new BLLException("Error al validar el borrador de envios.");

            }
        }
        public List<Envio> GetAllEnvios() 
        {
            try
            {                 
              return dal.ObtenerEnviosBS();  
            }
            catch
            {
                throw new BLLException("Error al obtener los envios.");
            }
        }
        public void ValidarEnvio(Envio Nuevo) 
        {
            try
            {
                using ( var trx = new TransactionScope())
                {
                    if (Nuevo.Zona.Length < 6)
                    {
                        throw new BLLException("La zona debe tener al menos 7 caracteres");
                    }
                    if (Nuevo.Precio <= 0)
                    {
                        throw new BLLException("El precio del envio debe ser mayor a cero");
                    }
                    dal.AgregarEnvioBS(Nuevo);
                    trx.Complete();
                }
                

            }
            catch
            {
                throw new BLLException("error al validar la zona del envio");
            }
        
        }
    }
}
