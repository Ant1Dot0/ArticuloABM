using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.ExceptionServices;
using Dominio;
using System.Security.Principal;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {

                datos.setearConsulta("SELECT ID, CODIGO, MARCAID, LINEAID, DESCRIPCION, PRECIO, IMAGEN FROM ARTICULOS");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.id = (int)datos.Lector["ID"];
                    aux.codigo = (string)datos.Lector["CODIGO"];
                    aux.descripcion = (string)datos.Lector["DESCRIPCION"];
                    aux.precio = (double)datos.Lector["PRECIO"];
                    aux.imagen = (string)datos.Lector["IMAGEN"];
                    aux.marcaArt.id = (int)datos.Lector["MARCAID"];
                    aux.lineaArt.id = (int)datos.Lector["LINEAID"];

                    lista.Add(aux);
                }
                datos.cerrarConexion();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
