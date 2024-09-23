using DB;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace StyleSys.Forms.MainForms
{
    public partial class Login : Form
    {
        private StyleSysContext? dbContext;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.dbContext = new StyleSysContext();

            // Descomentar la línea de abajo si se desea iniciar desde una base de datos nueva
            // this.dbContext.Database.EnsureDeleted();
            // this.dbContext.Database.EnsureCreated();

            //Aplica las migraciones pendientes - COMENTAR SI NO HACE FALTA MIGRAR
            //this.dbContext.Database.Migrate();
            
        }

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

            //Verifica que los campos no estén vacíos
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Complete todos los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Pregunta si coinciden el usuario y la contraseña
                if (VerificarCredenciales(user, password))
                {
                    //Muestra el dashboard
                    MessageBox.Show("Bienvenido: " + user, "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Hide();
                    Dashboard dashboard = new Dashboard(user);
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("El usuario o la contraseña no son correctos", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        /*
         * Busca en la base de datos al usuario por el nickname, y verifica si la contraseña coincide
         * FALTA HACER HASH A LAS CONTRASEÑAS DE LA BASE DE DATOS.
         */
        private bool VerificarCredenciales(string nick, string password)
        {
            using (StyleSysContext db = new StyleSysContext())
            {
                Usuario usuario = db.Usuarios.Where(u => u.us_nickname == nick).FirstOrDefault();

                //¿Esto es optimo?
                if (usuario != null)
                {
                    //Obtener contraseña de la DB
                    byte[] storedPass = Convert.FromHexString(usuario.us_clave);

                    //Convierte el string ingresado a una cadena de bytes
                    byte[] messageBytes = Encoding.UTF8.GetBytes(password);

                    //Crea el valor hasheado a partir de la cadena de 
                    byte[] hashValue = SHA256.HashData(messageBytes);
                    
                    return storedPass.SequenceEqual(hashValue);
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
