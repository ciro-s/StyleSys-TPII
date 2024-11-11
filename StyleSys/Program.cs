using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using StyleSys.Forms.Clientes;
using StyleSys.Forms.Facturas;
using StyleSys.Forms.MainForms;
using StyleSys.Forms.Productos;
using StyleSys.Forms.Ventas_Carrito;


namespace StyleSys
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Dashboard("llopez"));
        }
    }
}
