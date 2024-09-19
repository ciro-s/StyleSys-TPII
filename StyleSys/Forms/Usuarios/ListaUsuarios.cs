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
            bindDGView(_context.Usuarios.ToList());
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
                dgvUsuarios.Rows.Add(i + 1, usuarios[i].id_usuario, usuarios[i].us_nombre, usuarios[i].us_apellido, usuarios[i].us_email, usuarios[i].us_fechaNacimiento, usuarios[i].us_telefono);
            }
        }

        //Maneja los botones de editar y eliminar en el grid de usuarios.
        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string col = dgvUsuarios.Columns[e.ColumnIndex].Name;

            if (col == "editar")
            {
                MessageBox.Show("entró");
                ModuloUsuarios modulo = new ModuloUsuarios(this);
                var id = int.Parse(dgvUsuarios[1, e.RowIndex].Value.ToString());

               Usuario user = _context.Usuarios.Find(id);
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
            }
        }
    }
}
