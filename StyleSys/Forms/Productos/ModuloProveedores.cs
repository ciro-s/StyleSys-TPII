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
        public ModuloProveedores()
        {
            InitializeComponent();
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
