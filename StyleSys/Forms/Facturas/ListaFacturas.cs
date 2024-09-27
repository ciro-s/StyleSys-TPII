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

namespace StyleSys.Forms.Facturas
{
    public partial class ListaFacturas : Form
    {
        public ListaFacturas()
        {
            InitializeComponent();
            bindDGView();
        }

        /// <summary>
        /// Itera sobre los registros de facturas de en la BD y los agrega al DGV
        /// </summary>
        /// <param name="facturas">la lista de usuarios a mostrar recibida desde la bd</param>
        public void bindDGView()
        {
            dgvFacturas.Rows.Add(1, 12345, "$44000", "Cliente Prueba", "Crédito", "Empleado prueba", "25/09/24");
            //Limpia todos los registros para obtener los nuevos
            //dgvUsuarios.Rows.Clear();

            //for (int i = 0; i < usuarios.Count; i++)
            //{
            //    //Escribe el estado del usuario
            //    string estado = "HABILITADO";
            //    if (!usuarios[i].us_estado)
            //    {
            //        estado = "DESHABILITADO";
            //    }

            //    //Agrega el registro al grid
            //    dgvUsuarios.Rows.Add(i + 1, usuarios[i].id_usuario, usuarios[i].us_nombre, usuarios[i].us_apellido, usuarios[i].us_email, usuarios[i].us_telefono, usuarios[i].us_fechaNacimiento, estado);
            //}
        }

        /// <summary>
        /// Chequea qué celda se clickeó. Si es el botón de detalles, se maneja la acción solicitada.
        /// </summary>
        private void dgvFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string col = dgvFacturas.Columns[e.ColumnIndex].Name;
            var cod_factura = int.Parse(dgvFacturas[1, e.RowIndex].Value.ToString());
            //Factura f = _context.Facturas.Find(cod_factura);

            //CLICK EN BOTON DETALLES
            if (col == "detalles")
            {
                DetalleFactura modulo = new DetalleFactura(); //Crea un formulario de detalles

                //if (f != null)
                modulo.lbFactura.Text = "Factura: 12345";
                modulo.ShowDialog();
            }
        }
    }
}
