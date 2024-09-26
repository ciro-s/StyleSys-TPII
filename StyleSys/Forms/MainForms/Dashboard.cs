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
using StyleSys.Forms.Clientes;
using StyleSys.Forms.Facturas;

namespace StyleSys.Forms.MainForms
{
    public partial class Dashboard : Form
    {
        private Usuario activeUser = null; //Usuario que inició sesión
        private StyleSysContext _context; //Conexion a bd
        public Dashboard(string username)
        {
            InitializeComponent();
            
            //Muestra el nombre del usuario que inició sesión y guarda el usuario en una variable
            using (_context = new StyleSysContext())
            {
                activeUser = _context.Usuarios.Where(u => u.us_nickname == username).FirstOrDefault();
                if (activeUser != null)
                    lbUser.Text = activeUser.us_nombre.ToUpper() + " " + activeUser.us_apellido.ToUpper();
            }
        }

        /// <summary>
        /// Desactiva los botones del dashboard según el rol del usuario activo
        /// </summary>
        /// <param name="e">Contiene el evento que se disparó.</param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            switch (activeUser.id_rol)
            {
                case 1:
                    panelProductos.Visible = true;
                    panelFacturas.Visible = true;
                    panelProveedores.Visible = false;
                    panelUsuarios.Visible = false;
                    break;
                case 2:
                    panelProductos.Visible = true;
                    panelFacturas.Visible = true;
                    panelProveedores.Visible = true;
                    panelUsuarios.Visible = false;
                    break;
                case 3:
                    panelProductos.Visible = true;
                    panelFacturas.Visible = true;
                    panelProveedores.Visible = true;
                    panelUsuarios.Visible = true;
                    break;

            }
        }

        //Atributo que guarda el formulario activo dentro del dashboard.
        private Form activeForm = null;

        /// <summary>
        /// Recibe un formulario para mostrar en el dashboard según el botón clickeado
        /// </summary>
        /// <param name="hijo">Formulario a abrirse.</param>
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

        private void button2_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new ListaClientes());
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new ListaFacturas());
        }
    }
}
