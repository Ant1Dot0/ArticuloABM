using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        int id { get; set; }
        string codigo { get; set; }
        string descripcion { get; set; }
        decimal precio { get; set; }
        string imagen { get; set; }

        Linea LineaUno = new Linea();
        Marca MarcaUno = new Marca();

        public Articulo(int id, string codigo, string descripcion, decimal precio, string imagen)
        {
            this.id = id;
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.precio = precio;
            this.imagen = imagen;
        }

    }

    

   
}
