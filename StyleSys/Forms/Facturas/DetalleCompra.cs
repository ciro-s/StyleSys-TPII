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
    public partial class DetalleCompra : Form
    {
        CompraCabecera _cabecera;
        StyleSysContext _context;
        public DetalleCompra(CompraCabecera compra)
        {
            InitializeComponent();
            _cabecera = compra;
            _context = new StyleSysContext();
            bindDGV(_context.compraDetalles.Where(c => c.id_cabecera == compra.id_cabecera).ToList());
        }

        public void bindDGV(List<CompraDetalle> detalles)
        {
            //Limpia todos los registros para obtener los nuevos
            dgvDetalles.Rows.Clear();

            decimal total = 0;

            for (int i = 0; i < detalles.Count; i++)
            {
                //Obtiene el producto
                string producto = _context.Productos.Find(detalles[i].id_producto).pr_nombre;

                //calcula el monto parcial
                var parcial = (decimal)detalles[i].cantidad * (decimal)detalles[i].precio_compra;
                total += parcial;

                //Agrega el registro al grid
                dgvDetalles.Rows.Add(i + 1, producto, detalles[i].cantidad, detalles[i].precio_compra, parcial);
            }

            lbTotal.Text = "Total: $"+total.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
