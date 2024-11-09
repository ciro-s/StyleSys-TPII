using DB;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StyleSys.Forms.Reportes
{
    public partial class MainReportes : Form
    {
        public MainReportes()
        {
            InitializeComponent();
        }

        private void btnComprasFiltrar_Click(object sender, EventArgs e)
        {
            DateTime fechaDesde = compras_fechadesde.Value;
            DateTime fechaHasta = compras_fechahasta.Value;

            using (var context = new StyleSysContext())
            {
                var query = from cab in context.compraCabeceras
                            join det in context.compraDetalles
                            on cab.id_cabecera equals det.id_cabecera
                            where cab.fecha_registro >= fechaDesde && cab.fecha_registro <= fechaHasta
                            select new
                            {
                                cab.id_cabecera,
                                cab.id_usuario,
                                cab.cod_cabecera,
                                cab.fecha_registro,
                                cab.monto_total,
                                det.id_producto,
                                det.cantidad,
                                det.precio_compra,
                                TotalParcial = det.cantidad * det.precio_compra
                            };

                var compras = query.ToList();

                dgvCompras.Rows.Clear();

                for (int i = 0; i < compras.Count; i++)
                {
                    //Obtiene el usuario
                    string usuario = context.Usuarios.Find(compras[i].id_usuario).us_nombre;

                    //Obtiene el usuario
                    string producto = context.Productos.Find(compras[i].id_producto).pr_nombre;

                    //Agrega el registro al grid
                    dgvCompras.Rows.Add(compras[i].cod_cabecera, compras[i].fecha_registro, compras[i].monto_total, producto, compras[i].cantidad, compras[i].precio_compra, compras[i].TotalParcial );
                }
            }
        }
    }
}
