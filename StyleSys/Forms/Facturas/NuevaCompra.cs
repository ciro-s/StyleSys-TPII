using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StyleSys.Forms.Facturas
{
    public partial class NuevaCompra : Form
    {
        public NuevaCompra()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("¿Estás seguro de que quiere salir?", "Confirme", MessageBoxButtons.YesNo))
            {
                this.Dispose();
            }
        }

        private void btnBuscarProv_Click(object sender, EventArgs e)
        {
            BuscarProveedor buscarProveedor = new BuscarProveedor();
            buscarProveedor.ShowDialog();
        }

        private void btnBuscarProd_Click(object sender, EventArgs e)
        {
            BuscarProducto buscar = new BuscarProducto();
            buscar.ShowDialog();
        }
    }
}
