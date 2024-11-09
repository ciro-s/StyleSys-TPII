using DB;
using Microsoft.EntityFrameworkCore;
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
    public partial class Compras : Form
    {
        public Usuario activeUser;
        StyleSysContext _context;
        public Compras(Usuario user)
        {
            InitializeComponent();
            activeUser = user;
            _context = new StyleSysContext();
            bindDGV(_context.compraCabeceras.ToList());
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NuevaCompra nuevo = new NuevaCompra(this);
            nuevo.ShowDialog();
        }

        public void bindDGV(List<CompraCabecera> compras)
        {
            //Limpia todos los registros para obtener los nuevos
            dgvCompras.Rows.Clear();

            for (int i = 0; i < compras.Count; i++)
            {
                //Obtiene el usuario
                string usuario = _context.Usuarios.Find(compras[i].id_usuario).us_nombre;

                //Agrega el registro al grid
                dgvCompras.Rows.Add(i + 1, compras[i].cod_cabecera, compras[i].monto_total, usuario, compras[i].fecha_registro);
            }
        }

        private void dgvCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex > 0)
            {
                string col = dgvCompras.Columns[e.ColumnIndex].Name;
                var cod_cabecera = long.Parse(dgvCompras[1, e.RowIndex].Value.ToString());
                CompraCabecera cabecera = _context.compraCabeceras.Where(c => c.cod_cabecera == cod_cabecera).FirstOrDefault();

                //CLICK EN BOTON DETALLES
                if (col == "detalles")
                {
                    DetalleCompra modulo = new DetalleCompra(cabecera); //Crea un formulario de detalles
                    modulo.lbFactura.Text = "Código de compra: " + cabecera.cod_cabecera;
                    modulo.ShowDialog();
                }
            }
        }

        private void numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void tbBuscarCompra_TextChanged(object sender, EventArgs e)
        {
            var codigo = tbBuscarCompra.Text.ToUpper(); // Convertimos a mayúsculas para una comparación insensible a mayúsculas/minúsculas

            foreach (DataGridViewRow row in dgvCompras.Rows)
            {
                if (row.Cells["cod_factura"].Value != null) // Asegurarse de que la celda existe y tiene un valor
                {
                    string codigoCompra = row.Cells["cod_factura"].Value.ToString().ToUpper();
                    row.Visible = codigoCompra.Contains(codigo);
                }
            }
        }
    }
}
