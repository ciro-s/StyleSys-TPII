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
            ModuloUsuarios moduloUsuarios = new ModuloUsuarios();
            moduloUsuarios.ShowDialog();
        }

        /*
         * Itera sobre los registros de usuarios de la base de datos y los agrega al DGV
         */
        public void bindDGView(List<Usuario> usuarios) 
        {
            //Limpia todos los registros para obtener los nuevos
            dgvUsuarios.Rows.Clear();

            for (int i=0; i<usuarios.Count; i++)
            {
                dgvUsuarios.Rows.Add(i+1, usuarios[i].id_usuario, usuarios[i].us_nombre, usuarios[i].us_apellido, usuarios[i].us_email, usuarios[i].us_fechaNacimiento, usuarios[i].us_telefono);
            }
        }
    }
}
