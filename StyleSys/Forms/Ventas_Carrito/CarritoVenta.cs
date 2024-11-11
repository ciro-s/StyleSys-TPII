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

namespace StyleSys.Forms.Ventas_Carrito
{
    public partial class CarritoVenta : Form
    {
        StyleSysContext _context;
        public List<int> CarritoIDs = new List<int>();
        private Usuario _usuario;
        public CarritoVenta(Usuario activeUser)
        {
            InitializeComponent();
            _context = new StyleSysContext();
            loadFormasPago();
            loadCart();
            _usuario = activeUser;
        }

        private void loadFormasPago()
        {
            cbFormaPago.Items.Clear();
            cbFormaPago.DataSource = _context.formaPagos.ToList();
            cbFormaPago.DisplayMember = "fp_nombre";
            cbFormaPago.ValueMember = "id_formaPago";
        }

        public void loadCart()
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lbTimer.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarProducto buscar = new BuscarProducto();
            var result = buscar.ShowDialog();

            if (result == DialogResult.OK)
            {
                idProd.Text = buscar.id_producto.ToString();
                tbProd.Text = buscar.producto_nombre;
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            BuscarCliente buscar = new BuscarCliente();
            var result = buscar.ShowDialog();

            if (result == DialogResult.OK)
            {
                idCliente.Text = buscar.id_cliente.ToString();
                tbCliente.Text = buscar.cliente_nombre;
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbProd.Text) && !string.IsNullOrEmpty(tbCliente.Text))
            {
                var id = int.Parse(idProd.Text);

                //Verifica si el id ya existe en la lista del carrito
                if (CarritoIDs.Contains(id))
                {
                    for (int i = 0; i < dgvCarrito.Rows.Count; i++) //Recorre el datagrid para buscar el producto
                    {
                        if (id.ToString().Equals(dgvCarrito.Rows[i].Cells[0].Value.ToString())) //Compara lo ids
                        {
                            var cantidadAnterior = (decimal)dgvCarrito.Rows[i].Cells[3].Value;
                            dgvCarrito.Rows[i].Cells[3].Value = cantidadAnterior + cant.Value;
                        }
                    }
                }
                else //Nuevo producto a agregar
                {
                    Producto producto = _context.Productos.Find(id);
                    CarritoIDs.Add(id);
                    dgvCarrito.Rows.Add(producto.id_producto, producto.pr_nombre, producto.pr_precioVenta, cant.Value, (decimal)producto.pr_precioVenta * cant.Value);
                }
                CalcularTotal();
            }
            else
            {
                MessageBox.Show("Complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Guarda en la base de datos la cabecera de la compra y el detalle de la misma.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //using var db1 = new StyleSysContext();
            var strategy = _context.Database.CreateExecutionStrategy();

            strategy.Execute(
            () =>
            {
                using var db = new StyleSysContext();
                using var transaccion = db.Database.BeginTransaction(); //Inicia la transaccion para guardar la factura y los detalles

                try
                {
                    //Crea la cabecera de la compra
                    var cabecera = new VentaCabecera()
                    {
                        cod_cabecera = GenerarCodigoFactura(),
                        id_usuario = _usuario.id_usuario,
                        id_cliente = int.Parse(idCliente.Text),
                        id_formaPago = cbFormaPago.SelectedIndex + 1,
                        monto_total = float.Parse(lbPrecioTotal.Text),
                        fecha_registro = DateTime.Now
                    };
                    _context.ventaCabeceras.Add(cabecera);
                    _context.SaveChanges();

                    //Recorre el carrito y crea los detalles
                    for (int i = 0; i < dgvCarrito.Rows.Count; i++)
                    {
                        _context.ventaDetalles.Add(
                            new VentaDetalle
                            {
                                id_cabecera = cabecera.id_cabecera,
                                id_producto = int.Parse(dgvCarrito.Rows[i].Cells[0].Value.ToString()),
                                precio_venta = float.Parse(dgvCarrito.Rows[i].Cells[2].Value.ToString()),
                                cantidad = int.Parse(dgvCarrito.Rows[i].Cells[3].Value.ToString())
                            }
                        );
                    }
                    _context.SaveChanges();

                    //Commit de la transacción, si ocurre algún error se realiza un rollback automáticamente
                    transaccion.Commit();
                    FinalizarCompra();
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    MessageBox.Show(ex.Message + "\n" + ex.InnerException.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });
        }

        /// <summary>
        /// Genera un codigo unico segun la fecha y hora cuando se realizó la compra
        /// </summary>
        /// <returns>Retorna un número único que se utilizará de código de factura</returns>
        long GenerarCodigoFactura()
        {
            // Obtener los ticks actuales y quitar los últimos dígitos para acortarlo
            long ticks = DateTime.Now.Ticks / 10000; // Dividimos por 10000 para reducir la longitud

            // Si quieres un número positivo, puedes usar Math.Abs
            return Math.Abs(ticks);
        }

        private void FinalizarCompra()
        {
            MessageBox.Show("Se realizó la venta correctamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvCarrito.Rows.Clear();
        }

        /// <summary>
        /// Calcula el total de la compra recorriendo el carrito y escribe el total en el textbox
        /// </summary>
        private void CalcularTotal()
        {
            decimal total = 0;
            for (int i = 0; i < dgvCarrito.Rows.Count; i++)
            {
                total += (decimal)dgvCarrito.Rows[i].Cells[4].Value;
            }

            lbPrecioTotal.Text = total.ToString();
        }

        private void dgvCarrito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex > 0)
            {
                string col = dgvCarrito.Columns[e.ColumnIndex].Name;
                var id = int.Parse(dgvCarrito[0, e.RowIndex].Value.ToString());

                if (col == "delete")
                {
                    dgvCarrito.Rows.RemoveAt(e.RowIndex);
                    CarritoIDs.Remove(id);
                }
            }
        }
    }
}
