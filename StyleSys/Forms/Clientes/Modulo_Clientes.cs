using DB;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
//using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace StyleSys.Forms.Clientes
{
    public partial class ModuloClientes : Form
    {
        private StyleSysContext _context;
        ListaClientes _listaUsuarios;
        public ModuloClientes(ListaClientes lu)
        {
            //InitializeComponent();
            _context = new StyleSysContext(); //Conexión a la base de dato
            _listaUsuarios = lu;
        }

        /*
         * Recibe los datos del formulario de nuevo usuario y lo intenta registrar en la base de datos
         */
        private bool createUsuario(Usuario u)
        {
            try
            {
                //Verifica la conexión a la DB
                if (_context == null) { _context = new StyleSysContext(); }

                //Lo guarda en la base de datos
                _context.Usuarios.Add(u);
                _context.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.InnerException.Message);
                return false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(ModuloClientes));
            tbDireccion = new TextBox();
            label11 = new Label();
            tbDni = new TextBox();
            label10 = new Label();
            dateTimePicker = new DateTimePicker();
            label9 = new Label();
            tbTelefono = new TextBox();
            tbMail = new TextBox();
            label6 = new Label();
            label8 = new Label();
            btnActualizar = new Button();
            lbId = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            tbApellido = new TextBox();
            tbNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            btnClose = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tbDireccion
            // 
            tbDireccion.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbDireccion.Location = new Point(110, 187);
            tbDireccion.Name = "tbDireccion";
            tbDireccion.Size = new Size(601, 28);
            tbDireccion.TabIndex = 57;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(17, 190);
            label11.Margin = new Padding(20);
            label11.Name = "label11";
            label11.Size = new Size(88, 19);
            label11.TabIndex = 70;
            label11.Text = "Direccion";
            // 
            // tbDni
            // 
            tbDni.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbDni.Location = new Point(110, 142);
            tbDni.Name = "tbDni";
            tbDni.Size = new Size(601, 28);
            tbDni.TabIndex = 54;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(66, 145);
            label10.Margin = new Padding(20);
            label10.Name = "label10";
            label10.Size = new Size(39, 19);
            label10.TabIndex = 69;
            label10.Text = "DNI";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Format = DateTimePickerFormat.Short;
            dateTimePicker.Location = new Point(110, 319);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(250, 27);
            dateTimePicker.TabIndex = 61;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(1, 323);
            label9.Margin = new Padding(20);
            label9.Name = "label9";
            label9.Size = new Size(104, 19);
            label9.TabIndex = 68;
            label9.Text = "Nacimiento";
            // 
            // tbTelefono
            // 
            tbTelefono.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbTelefono.Location = new Point(110, 274);
            tbTelefono.Name = "tbTelefono";
            tbTelefono.Size = new Size(601, 28);
            tbTelefono.TabIndex = 60;
            // 
            // tbMail
            // 
            tbMail.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbMail.Location = new Point(110, 231);
            tbMail.Name = "tbMail";
            tbMail.Size = new Size(601, 28);
            tbMail.TabIndex = 58;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(26, 277);
            label6.Margin = new Padding(20);
            label6.Name = "label6";
            label6.Size = new Size(79, 19);
            label6.TabIndex = 66;
            label6.Text = "Teléfono";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(44, 234);
            label8.Margin = new Padding(20);
            label8.Name = "label8";
            label8.Size = new Size(61, 19);
            label8.TabIndex = 63;
            label8.Text = "e-Mail";
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.DodgerBlue;
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatAppearance.MouseOverBackColor = Color.Navy;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Image = (Image)resources.GetObject("btnActualizar.Image");
            btnActualizar.Location = new Point(315, 357);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(128, 47);
            btnActualizar.TabIndex = 64;
            btnActualizar.Text = "Actualizar";
            btnActualizar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(29, 370);
            lbId.Name = "lbId";
            lbId.Size = new Size(22, 20);
            lbId.TabIndex = 59;
            lbId.Text = "Id";
            lbId.Visible = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DodgerBlue;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.Navy;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.Location = new Point(583, 357);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(128, 47);
            btnCancelar.TabIndex = 67;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.DodgerBlue;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.Navy;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.Location = new Point(449, 357);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(128, 47);
            btnGuardar.TabIndex = 65;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // tbApellido
            // 
            tbApellido.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbApellido.Location = new Point(461, 95);
            tbApellido.Name = "tbApellido";
            tbApellido.Size = new Size(250, 28);
            tbApellido.TabIndex = 53;
            // 
            // tbNombre
            // 
            tbNombre.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbNombre.Location = new Point(110, 95);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(250, 28);
            tbNombre.TabIndex = 52;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(383, 100);
            label3.Margin = new Padding(20);
            label3.Name = "label3";
            label3.Size = new Size(78, 19);
            label3.TabIndex = 48;
            label3.Text = "Apellido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 100);
            label2.Margin = new Padding(20);
            label2.Name = "label2";
            label2.Size = new Size(76, 19);
            label2.TabIndex = 47;
            label2.Text = "Nombre";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(764, 70);
            panel1.TabIndex = 46;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(715, 9);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(55, 55);
            btnClose.TabIndex = 16;
            btnClose.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(124, 34);
            label1.TabIndex = 1;
            label1.Text = "Clientes";
            // 
            // ModuloClientes
            // 
            ClientSize = new Size(764, 421);
            Controls.Add(tbDireccion);
            Controls.Add(label11);
            Controls.Add(tbDni);
            Controls.Add(label10);
            Controls.Add(dateTimePicker);
            Controls.Add(label9);
            Controls.Add(tbTelefono);
            Controls.Add(tbMail);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(btnActualizar);
            Controls.Add(lbId);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(tbApellido);
            Controls.Add(tbNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ModuloClientes";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        public TextBox tbDireccion;
        private Label label11;
        public TextBox tbDni;
        private Label label10;
        public DateTimePicker dateTimePicker;
        private Label label9;
        public TextBox tbTelefono;
        public TextBox tbMail;
        private Label label6;
        private Label label8;
        public Button btnActualizar;
        public Label lbId;
        public Button btnCancelar;
        public Button btnGuardar;
        public TextBox tbApellido;
        public TextBox tbNombre;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private Button btnClose;
        private Label label1;
    }
}
