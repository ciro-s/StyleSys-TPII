using DB;
using StyleSys.Forms.Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StyleSys.Forms.Ventas_Carrito
{
    public partial class BuscarCliente : Form
    {
        StyleSysContext _context;
        public string cliente_nombre = null;
        public int id_cliente = 0;
        public BuscarCliente()
        {
            InitializeComponent();
            _context = new StyleSysContext();
            bindDGView(_context.Clientes.Where(p => p.cl_estado == true).ToList());
        }

        public void bindDGView(List<Cliente> clientes)
        {
            //Limpia todos los registros para obtener los nuevos
            dgvClientes.Rows.Clear();

            for (int i = 0; i < clientes.Count; i++)
            {
                //Agrega el registro al grid
                dgvClientes.Rows.Add(i + 1, clientes[i].id_cliente, clientes[i].cl_dni, clientes[i].cl_nombre + " " + clientes[i].cl_apellido, clientes[i].cl_email, clientes[i].cl_fechaAlta.ToString("yyyy-MM-dd"));
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex > 0)
            {
                string col = dgvClientes.Columns[e.ColumnIndex].Name;
                var id = int.Parse(dgvClientes[1, e.RowIndex].Value.ToString());
                Cliente cliente = _context.Clientes.Find(id);

                if (col == "select")
                {
                    if (cliente != null)
                    {
                        cliente_nombre = cliente.cl_nombre + " " + cliente.cl_apellido;
                        id_cliente = cliente.id_cliente;
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

        private void tbBuscarProd_TextChanged(object sender, EventArgs e)
        {
            var nombre_buscando = tbBuscarCliente.Text.ToUpper(); // Convertimos a mayúsculas para una comparación insensible a mayúsculas/minúsculas

            foreach (DataGridViewRow row in dgvClientes.Rows)
            {
                if (row.Cells["nombre"].Value != null) // Asegurarse de que la celda existe y tiene un valor
                {
                    string codigoCompra = row.Cells["nombre"].Value.ToString().ToUpper();
                    row.Visible = codigoCompra.Contains(nombre_buscando);
                }
            }
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            ModuloClientes modulo_clientes = new ModuloClientes();
            modulo_clientes.btnActualizar.Enabled = false;
            modulo_clientes.btnGuardar.Enabled = true;
            if (DialogResult.OK  == modulo_clientes.ShowDialog())
            {
                bindDGView(_context.Clientes.Where(p => p.cl_estado == true).ToList());
            }
        }
    }
}
