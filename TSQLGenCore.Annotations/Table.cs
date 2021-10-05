using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSQLGen.Annotations
{
    public class Table : System.Attribute
    {
        public String Name { get; }

        public Table(String tableName)
        {
            this.Name = tableName;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
