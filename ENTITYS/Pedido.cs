using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITYS
{
    public class Pedido
    {
        public int IDpedido { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad {  get; set; }
        public Envio Envio { get; set; }
        public decimal MontoTotal { get; set; }
        public string Prioridad { get; set; }
        public DateTime FechaRegistro {  get; set; }

        

    }
}
