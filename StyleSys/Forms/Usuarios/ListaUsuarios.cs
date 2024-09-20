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
    public partial class ListaUsuarios : Form
    {
        private StyleSysContext _context;
        public ListaUsuarios()
        {
            InitializeComponent();
            _context = new StyleSysContext();
            bindDGView(_context.Usuarios.Where(u => u.us_estado == true).ToList());
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ModuloUsuarios moduloUsuarios = new ModuloUsuarios(this);
            moduloUsuarios.btnActualizar.Enabled = false;
            moduloUsuarios.ShowDialog();
        }

        /*
         * Itera sobre los registros de usuarios de la base de datos y los agrega al DGV
         */
        public void bindDGView(List<Usuario> usuarios)
        {
            //Limpia todos los registros para obtener los nuevos
            dgvUsuarios.Rows.Clear();

            for (int i = 0; i < usuarios.Count; i++)
            {
                //Escribe el estado del usuario
                string estado = "HABILITADO";
                if (!usuarios[i].us_estado)
                {
                    estado = "DESHABILITADO";
                }

                //Agrega el registro al grid
                dgvUsuarios.Rows.Add(i + 1, usuarios[i].id_usuario, usuarios[i].us_nombre, usuarios[i].us_apellido, usuarios[i].us_email, usuarios[i].us_fechaNacimiento, usuarios[i].us_telefono, estado);
            }
        }

        //Maneja los botones de editar y eliminar en el grid de usuarios.
        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string col = dgvUsuarios.Columns[e.ColumnIndex].Name;
            var id = int.Parse(dgvUsuarios[1, e.RowIndex].Value.ToString());
            Usuario user = _context.Usuarios.Find(id);

            //CLICK EN BOTON EDITAR
            if (col == "editar")
            {
                ModuloUsuarios modulo = new ModuloUsuarios(this);

                if (user != null)
                {
                    //Deshabilitar el botón de guardar
                    modulo.btnGuardar.Enabled = false;
                    //Completar los campos con los datos del usuario seleccionado (EXCEPTO LA CONTRASEÑA)
                    modulo.tbNombre.Text = user.us_nombre;
                    modulo.tbApellido.Text = user.us_apellido;
                    modulo.tbDni.Text = user.us_dni.ToString();
                    modulo.tbNick.Text = user.us_nickname;
                    modulo.tbDireccion.Text = user.us_direccion;
                    modulo.tbMail.Text = user.us_email;
                    modulo.tbTelefono.Text = user.us_telefono;
                    modulo.dateTimePicker.Value = user.us_fechaNacimiento;
                    modulo.cbRol.SelectedIndex = user.id_rol - 1;
                    modulo.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Ocurrió un error recuperando al usuario seleccionado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (col == "Eliminar") //CLICK EN BOTÓN ELIMINAR
            {
                //Verificar que existe el usuario y está habilitado
                if (user != null && user.us_estado)
                {
                    if (MessageBox.Show("¿Está seguro de que quiere eliminar este usuario?\n" + user.us_nombre + " " + user.us_apellido, "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        user.us_estado = false; //deshabilita al usuario
                        _context.SaveChanges(); //guarda la actualización
                    }
                }
                else if (!user.us_estado)
                {
                    MessageBox.Show("Este usuario ya está deshabilitado.", "No se pudo eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                bindDGView(_context.Usuarios.ToList());
                checkEliminados.Checked = true;
            }
            else if (col == "restaurar")
            {
                //Verificar que existe el usuario y está deshabilitado
                if (user != null && !user.us_estado)
                {
                    if (MessageBox.Show("¿Está seguro de que quiere RESTAURAR este usuario?\n" + user.us_nombre + " " + user.us_apellido, "Restaurar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        user.us_estado = true; //habilita al usuario
                        _context.SaveChanges(); //guarda la actualización
                    }
                }
                else if (user.us_estado)
                {
                    MessageBox.Show("Este usuario ya está habilitado.", "No se pudo restaurar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                bindDGView(_context.Usuarios.ToList());//Muestra todos los usuarios en el grid
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
                bindDGView(_context.Usuarios.Where(u => u.us_estado == true).ToList());
                dgvUsuarios.Columns[7].Visible = false; //esconde columna de estado
                dgvUsuarios.Columns[10].Visible = false; //esconde columna de restaurar
            }
            else //Si se selecciona el checkbox
            {
                //Muestra TODOS los usuarios
                bindDGView(_context.Usuarios.ToList());
                dgvUsuarios.Columns[7].Visible = true; //Muestra columna de estado
                dgvUsuarios.Columns[10].Visible = true; //Muestra columna de restaurar
            }
        }
    }
}
