using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StyleSys.Forms.Productos;
using StyleSys.Forms.Usuarios;
using DB;

namespace StyleSys.Forms.MainForms
{
    public partial class Dashboard : Form
    {
        private Usuario activeUser = null;
        private StyleSysContext _context;
        public Dashboard(string username)
        {
            InitializeComponent();
            using (_context = new StyleSysContext())
            {
                activeUser = _context.Usuarios.Where(u => u.us_nickname == username).FirstOrDefault();
                if (activeUser != null)
                    lbUser.Text = activeUser.us_nombre.ToUpper() + " " + activeUser.us_apellido.ToUpper();
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            switch (activeUser.id_rol)
            {
                case 1:
                    btnProductos.Enabled = true;
                    btnFacturas.Enabled = true;
                    btnProveedores.Enabled = false;
                    btnUsuarios.Enabled = false;
                    break;
                case 2:
                    btnProductos.Enabled = true;
                    btnFacturas.Enabled = true;
                    btnProveedores.Enabled = true;
                    btnUsuarios.Enabled=true;
                    break;
                case 3:
                    btnProductos.Enabled = true;
                    btnFacturas.Enabled = true;
                    btnProveedores.Enabled = true;
                    btnUsuarios.Enabled = true;
                    break;

            }
        }

        //Atributo que guarda el formulario activo dentro del dashboard.
        private Form activeForm = null;

        /*
         * Abre el formulario según lo clickeado en el dashboard.
         */
        public void abrirFormHijo(Form hijo)
        {
            //Si hay otro formulario activo, se lo cierra antes de abrir el nuevo
            if (activeForm != null)
            { activeForm.Close(); }

            activeForm = hijo; //Se asigna el nuevo formulario

            //Configuración del formulario para que entre en el dashboard
            hijo.TopLevel = false;
            hijo.FormBorderStyle = FormBorderStyle.None;
            hijo.Dock = DockStyle.Fill;
            lbTitulo.Text = hijo.Text;

            //Agrega el formulario al panel del dashboard
            panelMain.Controls.Add(hijo);
            panelMain.Tag = hijo;
            hijo.BringToFront();
            hijo.Show();
        }
        private void btnProductos_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new ListaProductos());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new ListaProveedores());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new ListaUsuarios());
        }
    }
}
