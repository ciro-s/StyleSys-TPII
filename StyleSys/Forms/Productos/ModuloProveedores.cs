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

namespace StyleSys.Forms.Productos
{
    public partial class ModuloProveedores : Form
    {
        private StyleSysContext _context;
        ListaProveedores _listaProveedores;

        public ModuloProveedores(ListaProveedores lp)
        {
            InitializeComponent();
            _context = new StyleSysContext(); //Conexión a la base de datos
            _listaProveedores = lp;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //ACÁ DEBERÍA VALIDAR LOS DATOS E INSERTAR UN NUEVO PRODUCTO EN LA BD
            //HACER UN TRY CATCH CON LA CONEXION A DB
            MessageBox.Show("Nuevo proveedor ingresado correctamente.", "Inserción", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Recibe los datos del formulario de nuevo proveedor y lo intenta registrar en la base de datos
        /// </summary>
        /// <param name="p">los datos del proveedor a crear</param>
        private bool createProveedor(Proveedor p)
        {
            try
            {
                //Verifica la conexión a la DB
                if (_context == null) { _context = new StyleSysContext(); }

                //Lo guarda en la base de datos
                _context.Proveedores.Add(p);
                _context.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.InnerException.Message);
                return false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("¿Está seguro de borrar el formulario?", "Confirmar.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (msg == DialogResult.Yes)
            {
                tbNombre.Clear();
                tbCUIT.Clear();
                tbRazonSocial.Clear();
                tbTelefono.Clear();
                tbDireccion.Clear();
                tbDescripcion.Clear();
            }
        }
    }
}
