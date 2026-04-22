using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITYS
{
    public  class Envio
    {
        public int IDEnvio {  get; set; }
        public string Zona { get; set; }
        public decimal Precio { get; set; }  
        public override string ToString() // Para mostrar la zona en el ComboBox
        {
            return Zona;
        }
    }
}
