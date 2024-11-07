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

namespace StyleSys.Forms.Productos
{
    public partial class ListaProductos : Form
    {
        private StyleSysContext _context;

        public ListaProductos()
        {
            InitializeComponent();
            _context = new StyleSysContext();
            bindDGView(_context.Productos.Where(p => p.pr_estado == true).ToList());
        }

        public void bindDGView(List<Producto> productos)
        {
            //Limpia todos los registros para obtener los nuevos
            dgvProductos.Rows.Clear();

            for (int i = 0; i < productos.Count; i++)
            {
                //Escribe el estado del producto
                string estado = "HABILITADO";
                if (!productos[i].pr_estado)
                {
                    estado = "DESHABILITADO";
                }

                //Obtiene la categoria
                string categoria = _context.Categorias.Find(productos[i].id_categoria).cat_nombre;

                //Agrega el registro al grid
                dgvProductos.Rows.Add(i + 1, productos[i].id_producto, productos[i].pr_nombre, productos[i].pr_precioCompra, productos[i].pr_precioVenta, productos[i].pr_stock, productos[i].pr_stockMinimo, categoria, estado);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ModuloProductos moduloProductos = new ModuloProductos(this);
            moduloProductos.btnActualizar.Enabled = false;
            moduloProductos.ShowDialog();
        }

        /// <summary>
        /// Chequea qué celda se clickeó. Si es el botón de editar, eliminar, o restaurar, se maneja la acción solicitada.
        /// </summary>
        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string col = dgvProductos.Columns[e.ColumnIndex].Name;
            var id = int.Parse(dgvProductos[1, e.RowIndex].Value.ToString());
            Producto producto = _context.Productos.Find(id);

            //CLICK EN BOTON EDITAR
            if (col == "editar")
            {
                ModuloProductos modulo = new ModuloProductos(this);

                if (producto != null)
                {
                    modulo.btnGuardar.Enabled = false; //Deshabilitar el botón de guardar
                    //Completar los campos con los datos del usuario seleccionado (EXCEPTO LA CONTRASEÑA)
                    // El DNI, el mail, y el nickname al ser UNIQUE no permiten ser actualizados/editados
                    modulo.lbId.Text = producto.id_producto.ToString();
                    modulo.tbNombre.Text = producto.pr_nombre;
                    modulo.tbPrecioCompra.Text = producto.pr_precioCompra.ToString();
                    modulo.tbPrecioVenta.Text = producto.pr_precioVenta.ToString();
                    modulo.tbStock.Text = producto.pr_stockMinimo.ToString();
                    modulo.cbCategoria.SelectedIndex = producto.id_categoria -1;
                    modulo.cbProveedor.SelectedIndex = producto.id_proveedor -1;
                    modulo.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Ocurrió un error recuperando al producto seleccionado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (col == "Eliminar") //CLICK EN BOTÓN ELIMINAR
            {
                //Verificar que existe el producto y está habilitado
                if (producto != null && producto.pr_estado)
                {
                    if (MessageBox.Show("¿Está seguro de que quiere eliminar este producto?\n" + producto.pr_nombre, "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        producto.pr_estado = false; //deshabilita
                        _context.SaveChanges(); //guarda la actualización
                    }
                }
                else if (!producto.pr_estado)
                {
                    MessageBox.Show("Este producto ya está deshabilitado.", "No se pudo eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                bindDGView(_context.Productos.ToList());
                checkEliminados.Checked = true;
            }
            else if (col == "restaurar")
            {
                //Verificar que existe el usuario y está deshabilitado
                if (producto != null && !producto.pr_estado)
                {
                    if (MessageBox.Show("¿Está seguro de que quiere RESTAURAR este producto?\n" + producto.pr_nombre, "Restaurar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        producto.pr_estado = true; //habilita al usuario
                        _context.SaveChanges(); //guarda la actualización
                    }
                }
                else if (producto.pr_estado)
                {
                    MessageBox.Show("Este usuario ya está habilitado.", "No se pudo restaurar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                bindDGView(_context.Productos.ToList());//Muestra todos los usuarios en el grid
                checkEliminados.Checked = true;
            }
        }

        /*
         * Envia una lista de usuarios al DataGridView según si se requieren los eliminados o no
         */
        private void checkEliminados_CheckedChanged(object sender, EventArgs e)
        {
            //Si el checkbox no está seleccionado...
            if (!checkEliminados.Checked)
            {
                //Se muestran solo los usuarios habilitados
                bindDGView(_context.Productos.Where(p => p.pr_estado == true).ToList());
                dgvProductos.Columns[8].Visible = false; //esconde columna de estado
                dgvProductos.Columns[11].Visible = false; //esconde columna de restaurar
            }
            else //Si se selecciona el checkbox
            {
                //Muestra TODOS los usuarios
                bindDGView(_context.Productos.ToList());
                dgvProductos.Columns[8].Visible = true; //Muestra columna de estado
                dgvProductos.Columns[11].Visible = true; //Muestra columna de restaurar
            }
        }
    }
}
