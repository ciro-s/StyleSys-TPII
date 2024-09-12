using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StyleSys.Forms.Productos
{
    public partial class ListaProductos : Form
    {
        public ListaProductos()
        {
            InitializeComponent();
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            ModuloProductos moduloProductos = new ModuloProductos();
            moduloProductos.ShowDialog();
        }
    }
}
