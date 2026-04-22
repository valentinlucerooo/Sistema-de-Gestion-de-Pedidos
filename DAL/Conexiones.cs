using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class Conexiones
    {
        public static string BS()
        {
            return ConfigurationManager.ConnectionStrings["ConBS"].ConnectionString;
        
        
        }

    }
}
