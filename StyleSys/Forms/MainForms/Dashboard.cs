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
using StyleSys.Forms.Clientes;

namespace StyleSys.Forms.MainForms
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
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

        private void button2_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new ListaClientes());
        }
    }
}
