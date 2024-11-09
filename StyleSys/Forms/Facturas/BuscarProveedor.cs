using DB;
using StyleSys.Forms.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StyleSys.Forms.Facturas
{
    public partial class BuscarProveedor : Form
    {
        StyleSysContext _context;
        public string proveedor_nombre;
        public int id_proveedor;
        public BuscarProveedor()
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
                //Agrega el registro al grid
                dgvProveedores.Rows.Add(i + 1, proveedores[i].id_proveedor, proveedores[i].prov_nombre, proveedores[i].prov_cuit);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex > 0)
            {
                string col = dgvProveedores.Columns[e.ColumnIndex].Name;
                var id = int.Parse(dgvProveedores[1, e.RowIndex].Value.ToString());
                Proveedor proveedor = _context.Proveedores.Find(id);

                if (col == "select")
                {
                    if (proveedor != null)
                    {
                        proveedor_nombre = proveedor.prov_nombre;
                        id_proveedor = proveedor.id_proveedor;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error recuperando al proveedor seleccionado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void tbBuscarProv_TextChanged(object sender, EventArgs e)
        {
            var nombre_buscando = tbBuscarProd.Text.ToUpper(); // Convertimos a mayúsculas para una comparación insensible a mayúsculas/minúsculas

            foreach (DataGridViewRow row in dgvProveedores.Rows)
            {
                if (row.Cells["nombre"].Value != null) // Asegurarse de que la celda existe y tiene un valor
                {
                    string codigoCompra = row.Cells["nombre"].Value.ToString().ToUpper();
                    row.Visible = codigoCompra.Contains(nombre_buscando);
                }
            }
        }
    }
}
