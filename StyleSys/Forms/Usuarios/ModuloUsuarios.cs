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

namespace StyleSys.Forms.Usuarios
{
    public partial class ModuloUsuarios : Form
    {
        private StyleSysContext _context;
        public ModuloUsuarios()
        {
            InitializeComponent();
            _context = new StyleSysContext(); //Conexión a la base de datos
            loadRoles(); //Carga los roles
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
        private bool createUsuario(string nombre, string apellido, int dni, string email, string direccion, string telefono, string clave, DateTime fechaNac, string nick, int rol)
        {
            try
            {
                if (_context == null)
                {
                    _context = new StyleSysContext();
                }

                //Crea el nuevo Usuario
                var usuario = new Usuario()
                {
                    us_nombre = nombre,
                    us_apellido = apellido,
                    us_dni = dni,
                    us_email = email,
                    us_direccion = direccion,
                    us_telefono = telefono,
                    us_clave = clave,
                    us_fechaNacimiento = fechaNac,
                    us_nickname = nick,
                    id_rol = rol,
                    us_estado = true
                };

                //Lo guarda en la base de datos
                _context.Usuarios.Add(usuario);
                _context.SaveChanges();

                //Agregarlo al datagridview
                //BindDGView(_context.Usuarios.ToList());
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (createUsuario(tbNombre.Text, tbApellido.Text, int.Parse(tbDni.Text), tbMail.Text, tbDireccion.Text, tbTelefono.Text, tbClave.Text, dateTimePicker.Value, tbNick.Text, cbRol.SelectedIndex))
            {
                MessageBox.Show("Nuevo usuario ingresado correctamente.", "Inserción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Ocurrió un error con el nuevo usuario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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
                dateTimePicker.DataBindings.Clear();
            }
        }
    }
}
