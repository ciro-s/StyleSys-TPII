using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StyleSys.Forms.MainForms
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        bool prodExpand = false;
        
        private void prodTransicion_Tick(object sender, EventArgs e)
        {
            if (!prodExpand)
            {
                panelProductos.Height += 10;
                if (panelProductos.Height >= 207)
                {
                    prodTransicion.Stop();
                    prodExpand = true;
                }
            }
            else
            {
                panelProductos.Height -= 10;
                if (panelProductos.Height <= 61)
                {
                    prodTransicion.Stop();
                    prodExpand = false;
                }
            }
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            prodTransicion.Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
