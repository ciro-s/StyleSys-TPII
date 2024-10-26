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
            ModuloProveedores moduloProveedores = new ModuloProveedores(this);
            moduloProveedores.btnActualizar.Enabled = false;
            moduloProveedores.ShowDialog();
        }

        /// <summary>
        /// Chequea qué celda se clickeó. Si es el botón de editar, eliminar, o restaurar, se maneja la acción solicitada.
        /// </summary>
        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string col = dgvProveedores.Columns[e.ColumnIndex].Name;
            var id = int.Parse(dgvProveedores[1, e.RowIndex].Value.ToString());
            Proveedor proveedor = _context.Proveedores.Find(id);

            //CLICK EN BOTON EDITAR
            if (col == "editar")
            {
                ModuloProveedores modulo = new ModuloProveedores(this);

                if (proveedor != null)
                {
                    modulo.btnGuardar.Enabled = false; //Deshabilitar el botón de guardar
                    //Completar los campos con los datos del usuario seleccionado (EXCEPTO LA CONTRASEÑA)
                    // El DNI, el mail, y el nickname al ser UNIQUE no permiten ser actualizados/editados
                    modulo.lbId.Text = proveedor.id_proveedor.ToString();
                    modulo.tbNombre.Text = proveedor.prov_nombre;
                    modulo.tbCUIT.Text = proveedor.prov_cuit.ToString();
                    modulo.tbRazonSocial.Text = proveedor.prov_razonSocial;
                    modulo.tbDireccion.Text = proveedor.prov_direccion;
                    modulo.tbTelefono.Text = proveedor?.prov_telefono;
                    modulo.tbDescripcion.Text = proveedor.prov_descripcion;
                    modulo.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Ocurrió un error recuperando al proveedor seleccionado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (col == "Eliminar") //CLICK EN BOTÓN ELIMINAR
            {
                //Verificar que existe el proveedor y está habilitado
                if (proveedor != null && proveedor.prov_estado)
                {
                    if (MessageBox.Show("¿Está seguro de que quiere eliminar este proveedor?\n" + proveedor.prov_nombre, "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        proveedor.prov_estado = false; //deshabilita
                        _context.SaveChanges(); //guarda la actualización
                    }
                }
                else if (!proveedor.prov_estado)
                {
                    MessageBox.Show("Este proveedor ya está deshabilitado.", "No se pudo eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                bindDGView(_context.Proveedores.ToList());
                checkEliminados.Checked = true;
            }
            else if (col == "restaurar")
            {
                //Verificar que existe el usuario y está deshabilitado
                if (proveedor != null && !proveedor.prov_estado)
                {
                    if (MessageBox.Show("¿Está seguro de que quiere RESTAURAR este proveedor?\n" + proveedor.prov_nombre, "Restaurar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        proveedor.prov_estado = true; //habilita al usuario
                        _context.SaveChanges(); //guarda la actualización
                    }
                }
                else if (proveedor.prov_estado)
                {
                    MessageBox.Show("Este usuario ya está habilitado.", "No se pudo restaurar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                bindDGView(_context.Proveedores.ToList());//Muestra todos los usuarios en el grid
                checkEliminados.Checked = true;
            }
        }

        /*
         * Envia una lista de usuarios al DataGridView según si se requieren los eliminados o no
         */
        private void checkEliminados_CheckedChanged(object sender, EventArgs e)
        {
            //Si el checkbox no está seleccionado...
            if (!checkEliminados.Checked)
            {
                //Se muestran solo los usuarios habilitados
                bindDGView(_context.Proveedores.Where(p => p.prov_estado == true).ToList());
                dgvProveedores.Columns[7].Visible = false; //esconde columna de estado
                dgvProveedores.Columns[10].Visible = false; //esconde columna de restaurar
            }
            else //Si se selecciona el checkbox
            {
                //Muestra TODOS los usuarios
                bindDGView(_context.Proveedores.ToList());
                dgvProveedores.Columns[7].Visible = true; //Muestra columna de estado
                dgvProveedores.Columns[10].Visible = true; //Muestra columna de restaurar
            }
        }
    }
}
