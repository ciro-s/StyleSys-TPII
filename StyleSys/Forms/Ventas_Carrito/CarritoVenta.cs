using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StyleSys.Forms.Ventas_Carrito
{
    public partial class CarritoVenta : Form
    {
        public CarritoVenta()
        {
            InitializeComponent();
            lbCodFactura.Text = DateTime.Now.ToString("yyyyMMdd") + "1001";
            loadCart();
        }

        public void loadCart()
        {
            dgvCarrito.Rows.Clear();
            dgvCarrito.Rows.Add(1, 25578, "Camiseta Adidas 3", "$15.450", 1, "$15.450");
            dgvCarrito.Rows.Add(2, 36611, "Pantalón Nike", "$27.100", 2, "$54.200");
            lbPrecioTotal.Text = "$69.650";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lbTimer.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarProducto search = new BuscarProducto();
            search.ShowDialog();
        }
    }
}
