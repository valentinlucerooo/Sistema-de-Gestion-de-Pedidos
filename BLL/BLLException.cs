using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public  class BLLException : Exception
    {
        public BLLException(string Exception) : base(Exception) { }
    }
}
