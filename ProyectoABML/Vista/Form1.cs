using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class ProyectoABML : Form
    {
        public ProyectoABML()
        {
            InitializeComponent();
        }

        private void articuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaArticulo irAltaArticulo = new AltaArticulo();
            irAltaArticulo.Show();
            this.Hide();
        }
    }
}
