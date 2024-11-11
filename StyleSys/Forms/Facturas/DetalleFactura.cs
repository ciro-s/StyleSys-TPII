using DB;
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
    public partial class DetalleFactura : Form
    {
        VentaCabecera _cabecera;
        StyleSysContext _context;
        public DetalleFactura(VentaCabecera venta)
        {
            InitializeComponent();
            _cabecera = venta;
            _context = new StyleSysContext();
            bindDGV(_context.ventaDetalles.Where(c => c.id_cabecera == venta.id_cabecera).ToList());
        }

        public void bindDGV(List<VentaDetalle> detalles)
        {
            //Limpia todos los registros para obtener los nuevos
            dgvDetalles.Rows.Clear();

            decimal total = 0;

            for (int i = 0; i < detalles.Count; i++)
            {
                //Obtiene el producto
                string producto = _context.Productos.Find(detalles[i].id_producto).pr_nombre;

                //calcula el monto parcial
                var parcial = (decimal)detalles[i].cantidad * (decimal)detalles[i].precio_venta;
                total += parcial;

                //Agrega el registro al grid
                dgvDetalles.Rows.Add(i + 1, producto, detalles[i].cantidad, detalles[i].precio_venta, parcial);
            }

            lbTotal.Text = "Total: $" + total.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
