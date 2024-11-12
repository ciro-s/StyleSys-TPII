using DB;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace StyleSys.Forms.Reportes
{
    public partial class MainReportes : Form
    {
        private StyleSysContext _context;

        public MainReportes()
        {
            InitializeComponent();
            _context = new StyleSysContext();
        }

        private void btnComprasFiltrar_Click(object sender, EventArgs e)
        {
            DateTime fechaDesde = compras_fechadesde.Value;
            DateTime fechaHasta = compras_fechahasta.Value;

            // Realiza la consulta uniendo las tablas compraCabeceras y compraDetalles
            var query = from cab in _context.compraCabeceras
                        join det in _context.compraDetalles
                        on cab.id_cabecera equals det.id_cabecera
                        where cab.fecha_registro >= fechaDesde && cab.fecha_registro <= fechaHasta
                        select new
                        {
                            cab.id_cabecera,
                            cab.id_usuario,
                            cab.cod_cabecera, // cod_cabecera es el campo que quieres mostrar en el detalle
                            cab.fecha_registro,
                            cab.monto_total,
                            det.id_producto,
                            det.cantidad,
                            det.precio_compra,
                            TotalParcial = det.cantidad * det.precio_compra
                        };

            var compras = query.ToList();

            // Carga los usuarios y productos en memoria para evitar múltiples consultas
            var usuarios = _context.Usuarios.ToDictionary(u => u.id_usuario, u => u.us_nombre);
            var productos = _context.Productos.ToDictionary(p => p.id_producto, p => p.pr_nombre);

            dgvCompras.Rows.Clear();

            // Itera sobre los resultados de la consulta
            foreach (var compra in compras)
            {
                // Obtiene el nombre del usuario y del producto desde los diccionarios
                string usuario = usuarios.ContainsKey(compra.id_usuario) ? usuarios[compra.id_usuario] : "Desconocido";
                string producto = productos.ContainsKey(compra.id_producto) ? productos[compra.id_producto] : "Desconocido";

                // Agrega la fila al DataGridView
                dgvCompras.Rows.Add(compra.cod_cabecera, compra.fecha_registro, compra.monto_total, producto, compra.cantidad, compra.precio_compra, compra.TotalParcial);
            }
        }

        private void VentaBusca_Click(object sender, EventArgs e)
        {
            

            DateTime fechaDesde = ventas_fechadesde.Value;  // control para fecha desde
            DateTime fechaHasta = ventas_fechahasta.Value;  // control para fecha hasta
            //DateTime fechaHasta = new DateTime(2024,11,12);
            // Realiza la consulta uniendo las tablas VentaCabeceras y VentaDetalles
            var query = from cab in _context.ventaCabeceras
                        join det in _context.ventaDetalles
                        on cab.id_cabecera equals det.id_cabecera
                        where cab.fecha_registro >= fechaDesde && cab.fecha_registro <= fechaHasta
                        select new
                        {
                            cab.id_cabecera,
                            cab.id_usuario,
                            cab.id_cliente,
                            cab.cod_cabecera, // cod_cabecera es el campo que quieres mostrar en el detalle
                            cab.fecha_registro,
                            cab.id_formaPago,
                            cab.monto_total,
                            det.id_producto,
                            det.cantidad,
                            det.precio_venta,
                            
                        };

            var ventas = query.ToList();
            

            // Carga los usuarios y productos en memoria para evitar múltiples consultas
            var usuarios = _context.Usuarios.ToDictionary(u => u.id_usuario, u => u.us_nombre);
            var clientes = _context.Clientes.ToDictionary(c => c.id_cliente, c => c.cl_nombre);
            var formaPago = _context.formaPagos.ToDictionary(f => f.id_formaPago, f => f.fp_nombre);

            dgvVentasDiarias.Rows.Clear();  //DataGridView para ventas

            // Itera sobre los resultados de la consulta
            foreach (var venta in ventas)
            {
                // Obtiene el nombre del usuario y del producto desde los diccionarios
                string usuario = usuarios.ContainsKey(venta.id_usuario) ? usuarios[venta.id_usuario] : "Desconocido";
                string cliente = clientes.ContainsKey(venta.id_cliente) ? clientes[venta.id_cliente] : "Desconocido";
                string pago = formaPago.ContainsKey(venta.id_formaPago) ? formaPago[venta.id_formaPago]: "Desconocido";

                // Agrega la fila al DataGridView
                dgvVentasDiarias.Rows.Add(venta.id_cabecera, venta.cod_cabecera, venta.monto_total, cliente, pago , usuario , venta.fecha_registro);
            }
        }

    }
}
