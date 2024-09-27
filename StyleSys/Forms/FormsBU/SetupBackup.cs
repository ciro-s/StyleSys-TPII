using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StyleSys.Forms.Backup
{
    public partial class SetupBackup : Form
    {
        public SetupBackup()
        {
            InitializeComponent();
        }

        private void btnRutaBack_Click(object sender, EventArgs e)
        {
            //Abre el buscador de archivos y guarda la ruta de la carpeta seleccionada
            using (var fbd = folderBrowserDialog)
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    tbRutaBack.Text = fbd.SelectedPath;
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("¿Está seguro de que quiere guardar el backup en esta carpeta?", "Confirmar.", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                MessageBox.Show("Se guardó el backup correctamente.", "Guardado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
