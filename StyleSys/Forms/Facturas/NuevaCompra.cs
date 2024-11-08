using DB;
using Microsoft.IdentityModel.Tokens;
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
        public NuevaCompra()
        {
            InitializeComponent();
            _context = new StyleSysContext();
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
                    dgvCarrito.Rows.Add(producto.id_producto, producto.pr_nombre, producto.pr_precioCompra, cant.Value, (decimal)producto.pr_precioCompra * cant.Value);
                }
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

        }
    }
}
