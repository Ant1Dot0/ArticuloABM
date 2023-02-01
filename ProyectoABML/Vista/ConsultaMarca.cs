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
    public partial class ConsultaMarca : Form
    {
        public ConsultaMarca()
        {
            InitializeComponent();
        }

        private void ConsultaMarca_Load(object sender, EventArgs e)
        {
            List<Marca> listaMarcas = new MarcaNegocio().Listar();  //instanciamos lista y listar,guardamos todo de una

            dgvMarca.DataSource = listaMarcas; //datasourse solo captura obj de tipo list

        }
    }
}
