using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Marca
    {
        public int id { get; set; }
        public string codigo { get; set; }
        public string descripcion { get; set; }

        public override string ToString()
        {
            return ""+codigo ;
        }
    }
}
