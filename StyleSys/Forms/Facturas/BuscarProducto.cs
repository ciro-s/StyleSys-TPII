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
    public partial class BuscarProducto : Form
    {
        StyleSysContext _context;
        public string producto_nombre = null;
        public int id_producto = 0;
        public BuscarProducto(int idprov)
        {
            InitializeComponent();
            _context = new StyleSysContext();
            bindDGView(_context.Productos.Where(p => p.pr_estado == true && p.id_proveedor == idprov).ToList());
        }

        public void bindDGView(List<Producto> productos)
        {
            //Limpia todos los registros para obtener los nuevos
            dgvProductos.Rows.Clear();

            for (int i = 0; i < productos.Count; i++)
            {
                //Obtiene la categoria
                string categoria = _context.Categorias.Find(productos[i].id_categoria).cat_nombre;

                //Agrega el registro al grid
                dgvProductos.Rows.Add(i + 1, productos[i].id_producto, productos[i].pr_nombre, categoria, productos[i].pr_stock, productos[i].pr_precioVenta);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex > 0)
            {
                string col = dgvProductos.Columns[e.ColumnIndex].Name;
                var id = int.Parse(dgvProductos[1, e.RowIndex].Value.ToString());
                Producto producto = _context.Productos.Find(id);

                if (col == "select")
                {
                    if (producto != null)
                    {
                        producto_nombre = producto.pr_nombre;
                        id_producto = producto.id_producto;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error recuperando al producto seleccionado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
