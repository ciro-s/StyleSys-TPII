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
using StyleSys.Forms.Ventas_Carrito;
using StyleSys.Forms.Reportes;
using StyleSys.Forms.Backup;

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
                Rol rol = _context.Roles.Find(activeUser.id_rol);
                if (activeUser != null)
                    lbUser.Text = activeUser.us_nombre.ToUpper() + " " + activeUser.us_apellido.ToUpper() + " - " + rol.rol_nombre;
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
                case 1: //rol empleado-vendedor
                    panelProductos.Visible = false;
                    panelProveedores.Visible = false;
                    panelUsuarios.Visible = false;
                    panelFacturas.Visible = true;
                    panelClientes.Visible = true;
                    panelCarrito.Visible = true;
                    panelReportes.Visible = false;
                    panelBackup.Visible = false;
                    panelCompras.Visible = true;
                    break;
                case 2: //rol gerente
                    panelProductos.Visible = true;
                    panelProveedores.Visible = true;
                    panelUsuarios.Visible = false;
                    panelFacturas.Visible = true;
                    panelClientes.Visible = false;
                    panelCarrito.Visible = false;
                    panelReportes.Visible = true;
                    panelBackup.Visible = false;
                    panelCompras.Visible = true;
                    break;
                case 3: //rol super admin
                    panelProductos.Visible = false;
                    panelProveedores.Visible = true;
                    panelUsuarios.Visible = true;
                    panelFacturas.Visible = true;
                    panelClientes.Visible = false;
                    panelCarrito.Visible = false;
                    panelReportes.Visible = true;
                    panelBackup.Visible = true;
                    panelCompras.Visible = false;
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
            lbTitulo.Visible = true;

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
            if (DialogResult.Yes == MessageBox.Show("¿Seguro que quiere salir?", "Salir", MessageBoxButtons.YesNo))
            {
                Application.Exit();
            }
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new ListaProveedores());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new ListaUsuarios());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new ListaClientes());
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new ListaFacturas());
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new CarritoVenta(activeUser));
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new MainReportes());
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new SetupBackup());
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Compras(activeUser));
        }
    }
}
