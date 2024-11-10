using DB;
using FluentValidation;
using StyleSys.Forms.Usuarios;
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
    public partial class Modulo_Clientes : Form
    {
        private StyleSysContext _context;
        ListaClientes _listaClientes;
        public Modulo_Clientes(ListaClientes lc)
        {
            InitializeComponent();
            _context = new StyleSysContext(); //Conexión a la base de dato
            _listaClientes = lc;
        }

        /*
         * Recibe los datos del formulario de nuevo usuario y lo intenta registrar en la base de datos
         */
        private bool createCliente(Cliente c)
        {
            try
            {
                //Verifica la conexión a la DB
                if (_context == null) { _context = new StyleSysContext(); }

                //Lo guarda en la base de datos
                _context.Clientes.Add(c);
                _context.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.InnerException.Message);
                return false;
            }
        }

        private Label label1;

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            tbCnombre = new TextBox();
            tbCapellido = new TextBox();
            tbCDni = new TextBox();
            tbCTelefono = new TextBox();
            tbCEmail = new TextBox();
            panel1 = new Panel();
            btnClose = new Button();
            label8 = new Label();
            btnGuardarCli = new Button();
            btnActualizarCli = new Button();
            btnCancelarCli = new Button();
            dateFechaNac = new DateTimePicker();
            dateFechAlta = new DateTimePicker();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 92);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(395, 92);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 141);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 2;
            label3.Text = "DNI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(395, 141);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 3;
            label4.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 189);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 4;
            label5.Text = "Fecha Nacimiento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(395, 189);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 5;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(55, 235);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 6;
            label7.Text = "Fecha Alta";
            // 
            // tbCnombre
            // 
            tbCnombre.Location = new Point(174, 84);
            tbCnombre.Name = "tbCnombre";
            tbCnombre.Size = new Size(177, 23);
            tbCnombre.TabIndex = 7;
            tbCnombre.TextChanged += tbCnombre_TextChanged;
            // 
            // tbCapellido
            // 
            tbCapellido.Location = new Point(465, 84);
            tbCapellido.Name = "tbCapellido";
            tbCapellido.Size = new Size(177, 23);
            tbCapellido.TabIndex = 8;
            // 
            // tbCDni
            // 
            tbCDni.Location = new Point(174, 138);
            tbCDni.Name = "tbCDni";
            tbCDni.Size = new Size(177, 23);
            tbCDni.TabIndex = 9;
            // 
            // tbCTelefono
            // 
            tbCTelefono.Location = new Point(465, 138);
            tbCTelefono.Name = "tbCTelefono";
            tbCTelefono.Size = new Size(177, 23);
            tbCTelefono.TabIndex = 12;
            // 
            // tbCEmail
            // 
            tbCEmail.Location = new Point(465, 181);
            tbCEmail.Name = "tbCEmail";
            tbCEmail.Size = new Size(177, 23);
            tbCEmail.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(754, 51);
            panel1.TabIndex = 14;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.DodgerBlue;
            btnClose.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(700, 7);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(44, 41);
            btnClose.TabIndex = 20;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click_1;
            // 
            // label8
            // 
            label8.AutoEllipsis = true;
            label8.AutoSize = true;
            label8.BackColor = Color.DodgerBlue;
            label8.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(3, 7);
            label8.Name = "label8";
            label8.Size = new Size(168, 32);
            label8.TabIndex = 1;
            label8.Text = "Nuevo Cliente";
            // 
            // btnGuardarCli
            // 
            btnGuardarCli.Location = new Point(395, 345);
            btnGuardarCli.Name = "btnGuardarCli";
            btnGuardarCli.Size = new Size(75, 23);
            btnGuardarCli.TabIndex = 15;
            btnGuardarCli.Text = "Guardar";
            btnGuardarCli.UseVisualStyleBackColor = true;
            btnGuardarCli.Click += btnGuardarCli_Click;
            // 
            // btnActualizarCli
            // 
            btnActualizarCli.Location = new Point(508, 345);
            btnActualizarCli.Name = "btnActualizarCli";
            btnActualizarCli.Size = new Size(75, 23);
            btnActualizarCli.TabIndex = 16;
            btnActualizarCli.Text = "Actualizar";
            btnActualizarCli.UseVisualStyleBackColor = true;
            // 
            // btnCancelarCli
            // 
            btnCancelarCli.Location = new Point(612, 345);
            btnCancelarCli.Name = "btnCancelarCli";
            btnCancelarCli.Size = new Size(75, 23);
            btnCancelarCli.TabIndex = 17;
            btnCancelarCli.Text = "Cancelar";
            btnCancelarCli.UseVisualStyleBackColor = true;
            btnCancelarCli.Click += btnCancelarCli_Click;
            // 
            // dateFechaNac
            // 
            dateFechaNac.Format = DateTimePickerFormat.Short;
            dateFechaNac.Location = new Point(174, 183);
            dateFechaNac.Name = "dateFechaNac";
            dateFechaNac.Size = new Size(177, 23);
            dateFechaNac.TabIndex = 18;
            dateFechaNac.Value = new DateTime(2024, 11, 9, 11, 36, 0, 0);
            // 
            // dateFechAlta
            // 
            dateFechAlta.Format = DateTimePickerFormat.Short;
            dateFechAlta.Location = new Point(174, 227);
            dateFechAlta.Name = "dateFechAlta";
            dateFechAlta.Size = new Size(177, 23);
            dateFechAlta.TabIndex = 19;
            dateFechAlta.Value = new DateTime(2024, 11, 9, 11, 36, 0, 0);
            // 
            // Modulo_Clientes
            // 
            ClientSize = new Size(758, 406);
            Controls.Add(dateFechAlta);
            Controls.Add(dateFechaNac);
            Controls.Add(btnCancelarCli);
            Controls.Add(btnActualizarCli);
            Controls.Add(btnGuardarCli);
            Controls.Add(panel1);
            Controls.Add(tbCEmail);
            Controls.Add(tbCTelefono);
            Controls.Add(tbCDni);
            Controls.Add(tbCapellido);
            Controls.Add(tbCnombre);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Modulo_Clientes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox tbCnombre;
        private TextBox tbCapellido;
        private TextBox tbCDni;
        private TextBox tbCTelefono;
        private TextBox tbCEmail;
        private Panel panel1;
        private Label label8;
        private Button btnGuardarCli;
        private Button btnActualizarCli;
        private Button btnCancelarCli;
        private DateTimePicker dateFechaNac;
        private DateTimePicker dateFechAlta;


        private void btnGuardarCli_Click(object sender, EventArgs e)
        {
            if (Validacion())
            {
                MessageBox.Show("Se creó el nuevo cliente correctamente.", "Inserción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _listaClientes.bindDGView(_context.Clientes.Where(c => c.cl_estado == true).ToList());
                this.Dispose();
            }
        }

        private bool Validacion()
        {
            //CHEQUEO DE CAMPOS VACÍOS
            if (string.IsNullOrEmpty(tbCnombre.Text) || string.IsNullOrEmpty(tbCapellido.Text) ||
                string.IsNullOrEmpty(tbCDni.Text)
                || string.IsNullOrEmpty(tbCEmail.Text) || string.IsNullOrEmpty(tbCTelefono.Text))
            {
                MessageBox.Show("¡Complete todos los campos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                //BLOQUE TRY CATCH PARA VALIDAR SEGÚN LAS REGLAS DE VALIDACIÓN ESCRITAS EN LA CLASE USUARIOVALIDATOR
                try
                {
                    //Crea un objeto de tipo Usuario
                    var cliente = new Cliente()
                    {
                        cl_nombre = tbCnombre.Text,
                        cl_apellido = tbCapellido.Text,
                        cl_dni = int.Parse(tbCDni.Text),
                        cl_email = tbCEmail.Text,

                        cl_telefono = tbCTelefono.Text,

                        cl_fechaNacimiento = dateFechaNac.Value,
                        cl_fechaAlta = dateFechAlta.Value,


                        cl_estado = true
                    };

                    //Verifica si el formulario contiene un id, significa que se está EDITANDO un usuario
                    /*if (int.TryParse(lbId.Text, out int id))
                    {
                        //VALIDACIÓN DE DATOS CON LA LIBRERIA FLUENTVALIDATION
                        var validator = new UsuarioValidator(_context.Clientes.Select(c => c.cl_dni).ToList(), _context.Clientes.Select(c => c.cl_email).ToList(), true);
                        validator.ValidateAndThrow(cliente); //Lanza una excepción cuando falla
                        updateUsuario(cliente, id);
                    }
                    else
                    {
                        //VALIDACIÓN DE DATOS CON LA LIBRERIA FLUENTVALIDATION
                        var validator = new UsuarioValidator(_context.Usuarios.Select(u => u.us_dni).ToList(), _context.Usuarios.Select(u => u.us_email).ToList(), false);
                        validator.ValidateAndThrow(cliente); //Lanza una excepción cuando falla
                        if (!createUsuario(usuario))
                        {
                            throw new ValidationException("Error creando usuario."); //Si falla la creación del usuario se lanza una exception
                        }
                    }*/
                    if (!createCliente(cliente))
                    {
                        throw new ValidationException("Error creando usuario."); //Si falla la creación del usuario se lanza una exception
                    }

                    return true;
                }
                catch (ValidationException e)
                {
                    MessageBox.Show(e.Errors.First().ErrorMessage, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
        }

        private Button btnClose;

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tbCnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelarCli_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("¿Está seguro de borrar el formulario?", "Confirmar.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (msg == DialogResult.Yes)
            {
                tbCnombre.Clear();
                tbCapellido.Clear();
                
               
                tbCEmail.Clear();
                tbCTelefono.Clear();
                tbCDni.Clear();
               
                dateFechaNac.DataBindings.Clear();
            }
        }
    }

}
