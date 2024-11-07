using DB;
using FluentValidation;
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
    public partial class ModuloProductos : Form
    {
        private StyleSysContext _context;
        ListaProductos _listaProductos;

        public ModuloProductos(ListaProductos lp)
        {
            InitializeComponent();
            _context = new StyleSysContext(); //Conexión a la base de datos
            _listaProductos = lp;
            loadComboBox();
        }

        /// <summary>
        /// Carga desde base de datos las categorias y los proveedores en los combobox
        /// </summary>
        public void loadComboBox()
        {
            cbCategoria.Items.Clear();
            cbCategoria.DataSource = _context.Categorias.ToList();
            cbCategoria.DisplayMember = "cat_nombre";
            cbCategoria.ValueMember = "id_categoria";

            cbProveedor.Items.Clear();
            cbProveedor.DataSource = _context.Proveedores.ToList();
            cbProveedor.DisplayMember = "prov_nombre";
            cbProveedor.ValueMember = "id_proveedor";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validacion())
            {
                MessageBox.Show("Se creó el nuevo producto correctamente.", "Inserción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _listaProductos.bindDGView(_context.Productos.Where(p => p.pr_estado == true).ToList());
                this.Dispose();
            }
        }

        /// <summary>
        /// Valida los campos del modulo de productos.
        /// </summary>
        /// <returns>Un valor booleano correspondiente a si los datos del formulario pasaron o no la validacion.</returns>
        private bool Validacion()
        {
            //CHEQUEO DE CAMPOS VACÍOS
            if (string.IsNullOrEmpty(tbNombre.Text) || string.IsNullOrEmpty(tbPrecioCompra.Text) ||
                string.IsNullOrEmpty(tbPrecioVenta.Text) || string.IsNullOrEmpty(tbStock.Text))
            {
                MessageBox.Show("¡Complete todos los campos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                //BLOQUE TRY CATCH PARA VALIDAR SEGÚN LAS REGLAS DE VALIDACIÓN ESCRITAS EN LA CLASE PROVEEDORVALIDATOR
                try
                {
                    //Crea un objeto de tipo Producto
                    var producto = new Producto()
                    {
                        pr_nombre = tbNombre.Text,
                        pr_precioCompra = float.Parse(tbPrecioCompra.Text),
                        pr_precioVenta = float.Parse(tbPrecioVenta.Text),
                        pr_stockMinimo = int.Parse(tbStock.Text),
                        pr_stock = 0,
                        id_categoria = cbCategoria.SelectedIndex+1,
                        id_proveedor = cbProveedor.SelectedIndex+1,
                        pr_estado = true
                    };

                    //Verifica si el formulario contiene un id, significa que se está EDITANDO 
                    if (int.TryParse(lbId.Text, out int id))
                    {
                        //VALIDACIÓN DE DATOS CON LA LIBRERIA FLUENTVALIDATION
                        var validator = new ProductoValidator();
                        validator.ValidateAndThrow(producto); //Lanza una excepción cuando falla
                        updateProducto(producto, id);
                    }
                    else
                    {
                        //VALIDACIÓN DE DATOS CON LA LIBRERIA FLUENTVALIDATION
                        var validator = new ProductoValidator();
                        validator.ValidateAndThrow(producto); //Lanza una excepción cuando falla
                        if (!createProducto(producto))
                        {
                            throw new ValidationException("Error creando producto."); //Si falla la creación del producto se lanza una exception
                        }
                    }


                    return true;
                }
                catch (ValidationException e)
                {
                    MessageBox.Show(e.Errors.First().ErrorMessage, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
        }

        /// <summary>
        /// Recibe los datos del formulario de nuevo producto y lo intenta registrar en la base de datos
        /// </summary>
        /// <param name="p">los datos del producto a crear</param>
        private bool createProducto(Producto p)
        {
            try
            {
                //Verifica la conexión a la DB
                if (_context == null) { _context = new StyleSysContext(); }

                //Lo guarda en la base de datos
                _context.Productos.Add(p);
                _context.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.InnerException.Message);
                return false;
            }
        }

        /// <summary>
        /// Recibe el evento de presionar el botón "actualizar" en el módulo de productos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("¿Está seguro que quiere actualizar la información de este producto?", "Actualización.", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (Validacion())
                {
                    MessageBox.Show("Se actualizó al producto correctamente.", "Actualización.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _listaProductos.bindDGView(_context.Productos.Where(u => u.pr_estado == true).ToList());
                    this.Dispose();
                }
            }
        }

        /// <summary>
        /// Recibe la informacion desde el formulario y actualiza al producto seleccionado
        /// </summary>
        /// <param name="p">una instancia de tipo producto que contiene los datos a actualizar</param>
        /// <param name="id">el id del producto seleccionado</param>
        private void updateProducto(Producto p, int id)
        {
            try
            {
                //Verifica la conexión a la DB
                if (_context == null) { _context = new StyleSysContext(); }

                //Busca el producto en la base de datos
                Producto prodUpdate = _context.Productos.Where(x => x.id_producto == id).FirstOrDefault();

                if (prodUpdate != null) //Chequea que se haya encontrado el producto
                {
                    //Asigna los valores traidos desde el formulario al producto
                    prodUpdate.pr_nombre = p.pr_nombre;
                    prodUpdate.pr_precioVenta = p.pr_precioVenta;
                    prodUpdate.pr_precioCompra = p.pr_precioCompra;
                    prodUpdate.pr_stockMinimo = p.pr_stockMinimo;
                    prodUpdate.id_proveedor = p.id_proveedor;
                    prodUpdate.id_categoria = p.id_categoria;

                    _context.SaveChanges();
                }
                else
                {
                    throw new Exception("No se encontró al producto");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("¿Está seguro de borrar el formulario?", "Confirmar.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (msg == DialogResult.Yes)
            {
                tbNombre.Clear();
                tbPrecioCompra.Clear();
                tbPrecioVenta.Clear();
                tbStock.Clear();
            }
        }
    }
}
