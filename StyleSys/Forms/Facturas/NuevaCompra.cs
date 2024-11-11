using DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using StyleSys.Forms.Clientes;
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
        StyleSysContext _context;
        public List<int> CarritoIDs = new List<int>();
        Compras listaCompras;
        public NuevaCompra(Compras moduloCompras)
        {
            InitializeComponent();
            _context = new StyleSysContext();
            listaCompras = moduloCompras;
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
            var result = buscarProveedor.ShowDialog();

            if (result == DialogResult.OK)
            {
                idProv.Text = buscarProveedor.id_proveedor.ToString();
                tbProv.Text = buscarProveedor.proveedor_nombre;
            }
        }

        private void btnBuscarProd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbProv.Text))
            {
                MessageBox.Show("Primero seleccione un proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BuscarProducto buscar = new BuscarProducto(int.Parse(idProv.Text));
            var result = buscar.ShowDialog();

            if (result == DialogResult.OK)
            {
                idProd.Text = buscar.id_producto.ToString();
                tbProd.Text = buscar.producto_nombre;
            }
        }

        /// <summary>
        /// Agrega el producto seleccionado y la cantidad indicada al carrito de la compra.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbProd.Text) && !string.IsNullOrEmpty(tbProv.Text))
            {
                var id = int.Parse(idProd.Text);
                Producto producto = _context.Productos.Find(id);

                //Verifica si el id ya existe en la lista del carrito
                if (CarritoIDs.Contains(id))
                {
                    for (int i = 0; i < dgvCarrito.Rows.Count; i++) //Recorre el datagrid para buscar el producto
                    {
                        if (id.ToString().Equals(dgvCarrito.Rows[i].Cells[0].Value.ToString())) //Compara lo ids
                        {
                            var cantidadAnterior = (decimal)dgvCarrito.Rows[i].Cells[3].Value;

                            dgvCarrito.Rows[i].Cells[3].Value = cantidadAnterior + cant.Value;
                            dgvCarrito.Rows[i].Cells[4].Value = (decimal)dgvCarrito.Rows[i].Cells[3].Value * (decimal)producto.pr_precioCompra;
                        }
                    }
                }
                else //Nuevo producto a agregar
                {
                    CarritoIDs.Add(id);
                    dgvCarrito.Rows.Add(producto.id_producto, producto.pr_nombre, producto.pr_precioCompra, cant.Value, (decimal)producto.pr_precioCompra * cant.Value);
                }
                CalcularTotal();
            }
            else
            {
                MessageBox.Show("Complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

            tbTotal.Text = total.ToString();
        }

        /// <summary>
        /// Guarda en la base de datos la cabecera de la compra y el detalle de la misma.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegistrar_Click(object sender, EventArgs e)
        { 
            var strategy = _context.Database.CreateExecutionStrategy();

            strategy.Execute(
            () =>
            {
                using var db = new StyleSysContext();
                using var transaccion = db.Database.BeginTransaction(); //Inicia la transaccion para guardar la factura y los detalles

                try
                {
                    //Crea la cabecera de la compra
                    var cabecera = new CompraCabecera()
                    {
                        cod_cabecera = GenerarCodigoFactura(),
                        id_usuario = listaCompras.activeUser.id_usuario,
                        monto_total = float.Parse(tbTotal.Text),
                        fecha_registro = DateTime.Now
                    };
                    _context.compraCabeceras.Add(cabecera);
                    _context.SaveChanges();

                    //Recorre el carrito y crea los detalles
                    for (int i = 0; i < dgvCarrito.Rows.Count; i++)
                    {
                        int idProducto = int.Parse(dgvCarrito.Rows[i].Cells[0].Value.ToString());
                        float preciocompra = float.Parse(dgvCarrito.Rows[i].Cells[2].Value.ToString());
                        int cantidad = int.Parse(dgvCarrito.Rows[i].Cells[3].Value.ToString());

                        //Registra cada detalle de la compra
                        _context.compraDetalles.Add(
                            new CompraDetalle
                            {
                                id_cabecera = cabecera.id_cabecera,
                                id_producto = idProducto,
                                precio_compra = preciocompra,
                                cantidad = cantidad
                            }
                        );

                        //Actualiza el stock del producto
                        var prod = _context.Productos.Find(idProducto);
                        prod.pr_stock = prod.pr_stock + cantidad;
                    }
                    _context.SaveChanges();

                    //Commit de la transacción, si ocurre algún error se realiza un rollback automáticamente
                    transaccion.Commit();
                    FinalizarCompra();
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            MessageBox.Show("Se realizó la compra correctamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listaCompras.bindDGV(_context.compraCabeceras.ToList());
            this.Close();
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
