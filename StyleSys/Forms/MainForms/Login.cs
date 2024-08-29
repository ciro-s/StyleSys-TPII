using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StyleSys.Forms.MainForms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            //Inicializar imagenes
            pbUser.Image = Properties.Resources.avatar;
            pbIcon.Image = Properties.Resources.icon_cloth;
            pbPassword.Image = Properties.Resources._lock; //lock es palabra reservada por eso se usa "_lock"
        }

        /*
         * Responde al evento de click en el botón de cerrar, saliendo de la aplicación.
         */
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbPassword_MouseDown(object sender, MouseEventArgs e)
        {
            tbPassword.UseSystemPasswordChar = false;
        }

        private void pbPassword_MouseUp(object sender, MouseEventArgs e)
        {
            tbPassword.UseSystemPasswordChar=true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user, password;

            user = tbUsuario.Text;
            password = tbPassword.Text;

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Complete todos los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Muestra el dashboard
                MessageBox.Show("Bienvenido: " + user, "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
            }
        }
    }
}
