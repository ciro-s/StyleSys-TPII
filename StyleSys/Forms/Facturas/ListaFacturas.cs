using DB;
using Microsoft.EntityFrameworkCore;
using StyleSys.Forms.Usuarios;
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
    public partial class ListaFacturas : Form
    {
        StyleSysContext _context;
        public ListaFacturas()
        {
            InitializeComponent();
            _context = new StyleSysContext();
            bindDGView(_context.ventaCabeceras.ToList());
        }

        /// <summary>
        /// Itera sobre los registros de facturas de en la BD y los agrega al DGV
        /// </summary>
        /// <param name="facturas">la lista de usuarios a mostrar recibida desde la bd</param>
        public void bindDGView(List<VentaCabecera> ventas)
        {
            //Limpia todos los registros para obtener los nuevos
            dgvFacturas.Rows.Clear();

            for (int i = 0; i < ventas.Count; i++)
            {
                //Busca el cliente y el vendedor
                string cliente = _context.Clientes.Find(ventas[i].id_cliente).cl_nombre + " " + _context.Clientes.Find(ventas[i].id_cliente).cl_apellido;
                string vendedor = _context.Usuarios.Find(ventas[i].id_usuario).us_nombre + " " + _context.Usuarios.Find(ventas[i].id_usuario).us_apellido;
                string formapago = _context.formaPagos.Find(ventas[i].id_formaPago).fp_nombre;


                //Agrega el registro al grid
                dgvFacturas.Rows.Add(i + 1, ventas[i].cod_cabecera, ventas[i].monto_total, cliente, formapago, vendedor, ventas[i].fecha_registro);
            }
        }

        /// <summary>
        /// Chequea qué celda se clickeó. Si es el botón de detalles, se maneja la acción solicitada.
        /// </summary>
        private void dgvFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex > 0)
            {
                string col = dgvFacturas.Columns[e.ColumnIndex].Name;
                var cod_factura = long.Parse(dgvFacturas[1, e.RowIndex].Value.ToString());

                VentaCabecera cabecera = _context.ventaCabeceras.Where(v => v.cod_cabecera == cod_factura).FirstOrDefault();

                //CLICK EN BOTON DETALLES
                if (col == "detalles")
                {
                    DetalleFactura modulo = new DetalleFactura(cabecera); //Crea un formulario de detalles
                    modulo.lbFactura.Text = "Código de venta: " + cabecera.cod_cabecera;
                    modulo.ShowDialog();
                }
            }
        }

        private void tbBuscarVenta_TextChanged(object sender, EventArgs e)
        {
            var textoBusqueda = tbBuscarVenta.Text.ToUpper();

            // Definimos las columnas en las que queremos realizar la búsqueda
            string[] columnasBusqueda = { "cod_factura", "cl_nombre", "us_nombre", "fp_nombre" };

            foreach (DataGridViewRow row in dgvFacturas.Rows)
            {
                bool visible = false;

                // Iteramos sobre las columnas especificadas
                foreach (var columna in columnasBusqueda)
                {
                    if (row.Cells[columna].Value != null)
                    {
                        string valorCelda = row.Cells[columna].Value.ToString().ToUpper();

                        // Si encontramos el texto, marcamos la fila como visible
                        if (valorCelda.Contains(textoBusqueda))
                        {
                            visible = true;
                            break; // No es necesario seguir buscando en las otras columnas
                        }
                    }
                }

                // Definimos la visibilidad de la fila según si se encontró el texto o no
                row.Visible = visible;
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
    }
}
