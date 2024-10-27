using DB;
using FluentValidation;
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

namespace StyleSys.Forms.Productos
{
    public partial class ModuloProveedores : Form
    {
        private StyleSysContext _context;
        ListaProveedores _listaProveedores;

        public ModuloProveedores(ListaProveedores lp)
        {
            InitializeComponent();
            _context = new StyleSysContext(); //Conexión a la base de datos
            _listaProveedores = lp;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validacion())
            {
                MessageBox.Show("Se creó el nuevo proveedor correctamente.", "Inserción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _listaProveedores.bindDGView(_context.Proveedores.Where(p => p.prov_estado == true).ToList());
                this.Dispose();
            }
        }

        /// <summary>
        /// Valida los campos del modulo de proveedores.
        /// </summary>
        /// <returns>Un valor booleano correspondiente a si los datos del formulario pasaron o no la validacion.</returns>
        private bool Validacion()
        {
            //CHEQUEO DE CAMPOS VACÍOS
            if (string.IsNullOrEmpty(tbNombre.Text) || string.IsNullOrEmpty(tbCUIT.Text) ||
                string.IsNullOrEmpty(tbRazonSocial.Text) || string.IsNullOrEmpty(tbDireccion.Text) ||
                string.IsNullOrEmpty(tbTelefono.Text) || string.IsNullOrEmpty(tbDescripcion.Text))
            {
                MessageBox.Show("¡Complete todos los campos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                //BLOQUE TRY CATCH PARA VALIDAR SEGÚN LAS REGLAS DE VALIDACIÓN ESCRITAS EN LA CLASE PROVEEDORVALIDATOR
                try
                {
                    //Crea un objeto de tipo PROVEEDOR
                    var proveedor = new Proveedor()
                    {
                        prov_nombre = tbNombre.Text,
                        prov_cuit = long.Parse(tbCUIT.Text),
                        prov_razonSocial = tbRazonSocial.Text,
                        prov_direccion = tbDireccion.Text,
                        prov_telefono = tbTelefono.Text,
                        prov_descripcion = tbDescripcion.Text,
                        prov_estado = true
                    };

                    //Verifica si el formulario contiene un id, significa que se está EDITANDO 
                    if (int.TryParse(lbId.Text, out int id))
                    {
                        //VALIDACIÓN DE DATOS CON LA LIBRERIA FLUENTVALIDATION
                        var validator = new ProveedorValidator(_context.Proveedores.Select(p => p.prov_cuit).ToList(), true);
                        validator.ValidateAndThrow(proveedor); //Lanza una excepción cuando falla
                        updateProveedor(proveedor, id);
                    }
                    else
                    {
                        //VALIDACIÓN DE DATOS CON LA LIBRERIA FLUENTVALIDATION
                        var validator = new ProveedorValidator(_context.Proveedores.Select(p => p.prov_cuit).ToList(), false);
                        validator.ValidateAndThrow(proveedor); //Lanza una excepción cuando falla
                        if (!createProveedor(proveedor))
                        {
                            throw new ValidationException("Error creando proveedor."); //Si falla la creación del proveedor se lanza una exception
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
        /// Recibe los datos del formulario de nuevo proveedor y lo intenta registrar en la base de datos
        /// </summary>
        /// <param name="p">los datos del proveedor a crear</param>
        private bool createProveedor(Proveedor p)
        {
            try
            {
                //Verifica la conexión a la DB
                if (_context == null) { _context = new StyleSysContext(); }

                //Lo guarda en la base de datos
                _context.Proveedores.Add(p);
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
        /// Recibe el evento de presionar el botón "actualizar" en el módulo de proveedores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("¿Está seguro que quiere actualizar la información de este proveedor?", "Actualización.", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (Validacion())
                {
                    MessageBox.Show("Se actualizó al proveedor correctamente.", "Actualización.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _listaProveedores.bindDGView(_context.Proveedores.Where(u => u.prov_estado == true).ToList());
                    this.Dispose();
                }
            }
        }

        /// <summary>
        /// Recibe la informacion desde el formulario y actualiza al proveedor seleccionado
        /// </summary>
        /// <param name="p">una instancia de tipo proveedor que contiene los datos a actualizar</param>
        /// <param name="id">el id del proveedor seleccionado</param>
        private void updateProveedor(Proveedor p, int id)
        {
            try
            {
                //Verifica la conexión a la DB
                if (_context == null) { _context = new StyleSysContext(); }

                //Busca el proveedor en la base de datos
                Proveedor provUpdate = _context.Proveedores.Where(x => x.id_proveedor == id).FirstOrDefault();

                if (provUpdate != null) //Chequea que se haya encontrado el proveedor
                {
                    //Asigna los valores traidos desde el formulario al proveedor
                    provUpdate.prov_nombre = p.prov_nombre;
                    provUpdate.prov_razonSocial = p.prov_razonSocial;
                    provUpdate.prov_direccion = p.prov_direccion;
                    provUpdate.prov_telefono = p.prov_telefono;
                    provUpdate.prov_cuit = p.prov_cuit;
                    provUpdate.prov_descripcion = p.prov_descripcion;

                    _context.SaveChanges();
                }
                else
                {
                    throw new Exception("No se encontró al proveedor");
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
                tbCUIT.Clear();
                tbRazonSocial.Clear();
                tbTelefono.Clear();
                tbDireccion.Clear();
                tbDescripcion.Clear();
            }
        }
    }
}
