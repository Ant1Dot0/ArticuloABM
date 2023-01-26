using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Vista
{
    public partial class ConsultaArticulo : Form
    {
        public ConsultaArticulo()
        {
            InitializeComponent();
        }

        private void ConsultaArticulo_Load(object sender, EventArgs e)
        {
            List<Articulo> lista = new List<Articulo>();
            ArticuloNegocio negocio= new ArticuloNegocio();
            lista = negocio.listar();

            dvgArticulo.DataSource = lista;
        }
    }
}
