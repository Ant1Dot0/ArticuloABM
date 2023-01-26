using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        public int id { get; set; }
        public string codigo { get; set; }
        public string descripcion { get; set; }
        public double precio { get; set; }
        public string imagen { get; set; }

        public Linea lineaArt { get; set; }
        public Marca marcaArt { get; set; }

        public Articulo(int id, string codigo, string descripcion, Double precio, string imagen)
        {
            this.id = id;
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.precio = precio;
            this.imagen = imagen;

        }
        public Articulo()
        {
            this.marcaArt = new Marca();
            this.lineaArt= new Linea();
        }
    }

    

   
}
