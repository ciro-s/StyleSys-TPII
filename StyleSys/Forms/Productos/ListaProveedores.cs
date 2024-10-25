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
    public partial class ListaProveedores : Form
    {
        private StyleSysContext _context;

        public ListaProveedores()
        {
            InitializeComponent();
            _context = new StyleSysContext();
            bindDGView(_context.Proveedores.Where(p => p.prov_estado == true).ToList());
        }

        public void bindDGView(List<Proveedor> proveedores)
        {
            //Limpia todos los registros para obtener los nuevos
            dgvProveedores.Rows.Clear();

            for (int i = 0; i < proveedores.Count; i++)
            {
                //Escribe el estado del proveedor
                string estado = "HABILITADO";
                if (!proveedores[i].prov_estado)
                {
                    estado = "DESHABILITADO";
                }

                //Agrega el registro al grid
                dgvProveedores.Rows.Add(i + 1, proveedores[i].id_proveedor, proveedores[i].prov_nombre, proveedores[i].prov_cuit, proveedores[i].prov_razonSocial, proveedores[i].prov_telefono, proveedores[i].prov_direccion, estado);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ModuloProveedores moduloProveedores = new ModuloProveedores();
            moduloProveedores.btnActualizar.Enabled = false;
            moduloProveedores.ShowDialog();
        }
    }
}
