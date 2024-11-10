using DB;
using Microsoft.EntityFrameworkCore;
using StyleSys.Forms.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StyleSys.Forms.Clientes
{

    public partial class ListaClientes : Form
    {
        private StyleSysContext _context;
        public ListaClientes()
        {
            
            InitializeComponent();
            _context = new StyleSysContext();
            bindDGView(_context.Clientes.Where(c => c.cl_estado == true).ToList());
        }

        public void bindDGView(List<Cliente> clientes)
        {
            //Limpia todos los registros para obtener los nuevos
            dgvClientes.Rows.Clear();

            for (int i = 0; i < clientes.Count; i++)
            {
                //Escribe el estado del usuario
                string estado = "HABILITADO";
               if (!clientes[i].cl_estado)
                {
                   estado = "DESHABILITADO";
                }

                //Agrega el registro al grid
                dgvClientes.Rows.Add(i + 1, clientes[i].id_cliente, clientes[i].cl_nombre, clientes[i].cl_apellido, clientes[i].cl_email, clientes[i].cl_telefono, clientes[i].cl_fechaNacimiento, estado);
            }
        }

        //Maneja los botones de editar y eliminar en el grid de usuarios.
        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string col = dgvClientes.Columns[e.ColumnIndex].Name;
            var id = int.Parse(dgvClientes[1, e.RowIndex].Value.ToString());
            Cliente user = _context.Clientes.Find(id);

            //CLICK EN BOTON EDITAR
            if (col == "editar")
            {
                Modulo_Clientes modulo = new Modulo_Clientes(this);

                if (user != null)
                {
                    //modulo.btnGuardar.Enabled = false; //Deshabilitar el botón de guardar
                    //Completar los campos con los datos del usuario seleccionado (EXCEPTO LA CONTRASEÑA)
                    // El DNI, el mail, y el nickname al ser UNIQUE no permiten ser actualizados/editados
                    //modulo.lbId.Text = user.id_cliente.ToString();
                   // modulo.tbCnombre.Text = user.cl_nombre;
                   // modulo.tbCapellido.Text = user.cl_apellido;
                    //modulo.tbDni.Text = user.cl_dni.ToString();
                    //modulo.tbDni.Enabled = false; //Deshabilita el ingreso de dni
                    //modulo.tbMail.Text = user.cl_email;
                    //modulo.tbMail.Enabled = false; //Deshabilita el ingreso de email
                    //modulo.tbTelefono.Text = user.cl_telefono;
                    //modulo.dateTimePicker.Value = user.cl_fechaNacimiento;
                    modulo.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Ocurrió un error recuperando al usuario seleccionado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (col == "Eliminar") //CLICK EN BOTÓN ELIMINAR
            {
                //Verificar que existe el usuario y está habilitado
                if (user != null && user.cl_estado)
                {
                    if (MessageBox.Show("¿Está seguro de que quiere eliminar este usuario?\n" + user.cl_nombre + " " + user.cl_apellido, "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        user.cl_estado = false; //deshabilita al usuario
                        _context.SaveChanges(); //guarda la actualización
                    }
                }
                else if (!user.cl_estado)
                {
                    MessageBox.Show("Este usuario ya está deshabilitado.", "No se pudo eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                bindDGView(_context.Clientes.ToList());
                checkEliminadosCL.Checked = true;
            }
            else if (col == "restaurar")
            {
                //Verificar que existe el usuario y está deshabilitado
                if (user != null && !user.cl_estado)
                {
                    if (MessageBox.Show("¿Está seguro de que quiere RESTAURAR este usuario?\n" + user.cl_nombre + " " + user.cl_apellido, "Restaurar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        user.cl_estado = true; //habilita al usuario
                        _context.SaveChanges(); //guarda la actualización
                    }
                }
                else if (user.cl_estado)
                {
                    MessageBox.Show("Este usuario ya está habilitado.", "No se pudo restaurar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                bindDGView(_context.Clientes.ToList());//Muestra todos los usuarios en el grid
                checkEliminadosCL.Checked = true;
            }
        }

        private void checkEliminados_CheckedChanged(object sender, EventArgs e)
        {
            //Si el checkbox no está seleccionado...
            if (checkEliminadosCL.Checked)
            {
                //Se muestran solo los usuarios habilitados
                bindDGView(_context.Clientes.Where(c => c.cl_estado == true).ToList());
                dgvClientes.Columns[7].Visible = false; //esconde columna de estado
                dgvClientes.Columns[10].Visible = false; //esconde columna de restaurar
            }
            else //Si se selecciona el checkbox
            {
                //Muestra TODOS los usuarios
                bindDGView(_context.Clientes.ToList());
                dgvClientes.Columns[7].Visible = true; //Muestra columna de estado
                dgvClientes.Columns[10].Visible = true; //Muestra columna de restaurar
            }
        }

        private void btnCAgregar_Click(object sender, EventArgs e)
        {
            Modulo_Clientes modulo_clientes = new Modulo_Clientes(this);
            modulo_clientes.ShowDialog();
        }
    }
}
