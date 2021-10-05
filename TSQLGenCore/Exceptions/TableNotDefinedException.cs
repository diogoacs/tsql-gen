using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSQLGen.Exceptions
{
    public class TableNotDefinedException : Exception
    {
        public TableNotDefinedException(String message = null) : base(message) { }
    }
}
