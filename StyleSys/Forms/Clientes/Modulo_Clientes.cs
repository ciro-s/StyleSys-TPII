using DB;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
//using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace StyleSys.Forms.Clientes
{
    public partial class ModuloClientes : Form
    {
        private StyleSysContext _context;
        ListaClientes _listaClientes;
        public ModuloClientes(ListaClientes lc)
        {
            //InitializeComponent();
            _context = new StyleSysContext(); //Conexión a la base de dato
            _listaClientes = lc;
        }

        /*
         * Recibe los datos del formulario de nuevo usuario y lo intenta registrar en la base de datos
         */
        private bool createCliente(Usuario u)
        {
            try
            {
                //Verifica la conexión a la DB
                if (_context == null) { _context = new StyleSysContext(); }

                //Lo guarda en la base de datos
                _context.Usuarios.Add(u);
                _context.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.InnerException.Message);
                return false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panelClientes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InitializeComponent()
        {

        }
    }
}
