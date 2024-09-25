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
        public DetalleFactura()
        {
            InitializeComponent();
            bindDGView();
        }

        public void bindDGView()
        {
            //SOLO PARA PRUEBA
            dgvDetalles.Rows.Add(1, 12345, 1, "Nuevo Producto", 1, "$20.000", "$20.000");
            dgvDetalles.Rows.Add(1, 12345, 2, "Otro Producto", 2, "$12.000", "$24.000");
            lbTotal.Text = "$44.000";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
