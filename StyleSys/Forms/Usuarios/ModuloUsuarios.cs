using DB;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
//using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace StyleSys.Forms.Usuarios
{
    public partial class ModuloUsuarios : Form
    {
        private StyleSysContext _context;
        ListaUsuarios _listaUsuarios;
        public ModuloUsuarios(ListaUsuarios lu)
        {
            InitializeComponent();
            _context = new StyleSysContext(); //Conexión a la base de datos
            loadRoles(); //Carga los roles
            _listaUsuarios = lu;
        }

        /*
         * Carga los roles existentes desde la base de datos al combobox de roles
         */
        public void loadRoles()
        {
            cbRol.Items.Clear();
            cbRol.DataSource = _context.Roles.ToList();
            cbRol.DisplayMember = "rol_nombre";
            cbRol.ValueMember = "id_rol";
        }

        /*
         * Recibe los datos del formulario de nuevo usuario y lo intenta registrar en la base de datos
         */
        private bool createUsuario(Usuario u)
        {
            try
            {
                //Verifica la conexión a la DB
                if (_context == null) { _context = new StyleSysContext(); }

                //Lo guarda en la base de datos
                _context.Usuarios.Add(u);
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
                MessageBox.Show("Se creó el nuevo usuario correctamente.", "Inserción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _listaUsuarios.bindDGView(_context.Usuarios.ToList());
                this.Dispose();
            }
        }

        private bool Validacion()
        {
            //CHEQUEO DE CAMPOS VACÍOS
            if (string.IsNullOrEmpty(tbNombre.Text) || string.IsNullOrEmpty(tbApellido.Text) ||
                string.IsNullOrEmpty(tbDni.Text) || string.IsNullOrEmpty(tbNick.Text) || string.IsNullOrEmpty(tbClave.Text) ||
                string.IsNullOrEmpty(tbDireccion.Text) || string.IsNullOrEmpty(tbMail.Text) || string.IsNullOrEmpty(tbTelefono.Text))
            {
                MessageBox.Show("¡Complete todos los campos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                //BLOQUE TRY CATCH PARA VALIDAR SEGÚN LAS REGLAS DE VALIDACIÓN ESCRITAS EN LA CLASE USUARIOVALIDATOR
                try
                {
                    //Crea un objeto de tipo Usuario
                    var usuario = new Usuario()
                    {
                        us_nombre = tbNombre.Text,
                        us_apellido = tbApellido.Text,
                        us_dni = int.Parse(tbDni.Text),
                        us_email = tbMail.Text,
                        us_direccion = tbDireccion.Text,
                        us_telefono = tbTelefono.Text,
                        us_clave = hashClave(tbClave.Text),
                        us_fechaNacimiento = dateTimePicker.Value,
                        us_nickname = tbNick.Text,
                        id_rol = cbRol.SelectedIndex + 1,
                        us_estado = true
                    };

                    //VALIDACIÓN DE DATOS CON LA LIBRERIA FLUENTVALIDATION
                    var validator = new UsuarioValidator();
                    validator.ValidateAndThrow(usuario); //Lanza una excepción cuando falla

                    //Si falla la creación del usuario se lanza una exception
                    if(!createUsuario(usuario))
                    {
                        throw new ValidationException("Error creando usuario.");
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
                tbNick.Clear();
                tbClave.Clear();
                tbMail.Clear();
                tbTelefono.Clear();
                tbDni.Clear();
                tbDireccion.Clear();
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
                //MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private string hashClave(string clave_original)
        {
            //Nueva instancia de la clase SHA256 que computa el hashing
            SHA256 sha256Hash = SHA256.Create();

            //Separa en bytes el string de la contraseña
            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(clave_original));

            //Representa un nuevo string o vector de caracteres
            StringBuilder builder = new StringBuilder();

            //Hashea cada byte de la contraseña y lo agrega al nuevo string/builder
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }

            return builder.ToString();
        }
    }
}
