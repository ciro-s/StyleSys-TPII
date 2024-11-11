using DB;
using FluentValidation;
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

namespace StyleSys.Forms.Clientes
{
    public partial class ModuloClientes : Form
    {
        private StyleSysContext _context;
        ListaClientes _listaClientes;
        public ModuloClientes(ListaClientes lu = null)
        {
            InitializeComponent();
            _context = new StyleSysContext(); //Conexión a la base de datos
            _listaClientes = lu;
        }

        /*
         * Recibe los datos del formulario de nuevo cliente y lo intenta registrar en la base de datos
         */
        private bool createCliente(Cliente u)
        {
            try
            {
                //Verifica la conexión a la DB
                if (_context == null) { _context = new StyleSysContext(); }

                //Lo guarda en la base de datos
                _context.Clientes.Add(u);
                _context.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.InnerException.Message);
                return false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validacion())
            {
                MessageBox.Show("Se creó el nuevo cliente correctamente.", "Inserción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (_listaClientes != null)
                {
                    _listaClientes.bindDGView(_context.Clientes.Where(u => u.cl_estado == true).ToList());
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                }
                this.Dispose();
            }
        }

        private bool Validacion()
        {
            //CHEQUEO DE CAMPOS VACÍOS
            if (string.IsNullOrEmpty(tbNombre.Text) || string.IsNullOrEmpty(tbApellido.Text) ||
                string.IsNullOrEmpty(tbDni.Text) || string.IsNullOrEmpty(tbMail.Text) || string.IsNullOrEmpty(tbTelefono.Text))
            {
                MessageBox.Show("¡Complete todos los campos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                //BLOQUE TRY CATCH PARA VALIDAR SEGÚN LAS REGLAS DE VALIDACIÓN ESCRITAS EN LA CLASE USUARIOVALIDATOR
                try
                {
                    //Crea un objeto de tipo Cliente
                    var cliente = new Cliente()
                    {
                        cl_nombre = tbNombre.Text,
                        cl_apellido = tbApellido.Text,
                        cl_dni = int.Parse(tbDni.Text),
                        cl_email = tbMail.Text,
                        cl_telefono = tbTelefono.Text,
                        cl_fechaNacimiento = dateTimePicker.Value,
                        cl_fechaAlta = DateTime.Now,
                        cl_estado = true
                    };

                    //Verifica si el formulario contiene un id, significa que se está EDITANDO un cliente
                    if (int.TryParse(lbId.Text, out int id))
                    {
                        //VALIDACIÓN DE DATOS CON LA LIBRERIA FLUENTVALIDATION
                        var validator = new ClienteValidator(_context.Clientes.Select(u => u.cl_dni).ToList(), _context.Clientes.Select(u => u.cl_email).ToList(), true);
                        validator.ValidateAndThrow(cliente); //Lanza una excepción cuando falla
                        updateCliente(cliente, id);
                    }
                    else
                    {
                        //VALIDACIÓN DE DATOS CON LA LIBRERIA FLUENTVALIDATION
                        var validator = new ClienteValidator(_context.Clientes.Select(u => u.cl_dni).ToList(), _context.Clientes.Select(u => u.cl_email).ToList(), false);
                        validator.ValidateAndThrow(cliente); //Lanza una excepción cuando falla
                        if (!createCliente(cliente))
                        {
                            throw new ValidationException("Error creando cliente."); //Si falla la creación del cliente se lanza una exception
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

        /*
         * Limpia todos los campos del formulario
         */
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("¿Está seguro de borrar el formulario?", "Confirmar.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (msg == DialogResult.Yes)
            {
                tbNombre.Clear();
                tbApellido.Clear();
                tbMail.Clear();
                tbTelefono.Clear();
                tbDni.Clear();
                dateTimePicker.DataBindings.Clear();
            }
        }

        /*
         * Espera el evento de apretar una tecla en un textbox y solo acepta números.
         */
        private void numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("¿Está seguro que quiere actualizar la información de este cliente?", "Actualización.", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (Validacion())
                {
                    MessageBox.Show("Se actualizó al cliente correctamente.", "Actualización.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _listaClientes.bindDGView(_context.Clientes.Where(u => u.cl_estado == true).ToList());
                    this.Dispose();
                }
            }
        }

        private void updateCliente(Cliente u, int id)
        {
            try
            {
                //Verifica la conexión a la DB
                if (_context == null) { _context = new StyleSysContext(); }

                //Busca el cliente en la base de datos
                Cliente clienteUpdate = _context.Clientes.Where(x => x.id_cliente == id).FirstOrDefault();

                if (clienteUpdate != null) //Chequea que se haya encontrado el cliente
                {
                    //Asigna los valores traidos desde el formulario al cliente
                    clienteUpdate.cl_nombre = u.cl_nombre;
                    clienteUpdate.cl_apellido = u.cl_apellido;
                    clienteUpdate.cl_telefono = u.cl_telefono;
                    clienteUpdate.cl_fechaNacimiento = u.cl_fechaNacimiento;
                    //_context.Clientes.Update(cliente);
                    _context.SaveChanges();
                    //_context.Dispose();
                }
                else
                {
                    throw new Exception("No se encontró al cliente");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
