namespace StyleSys.Forms.MainForms
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new System.Windows.Forms.Panel();
            lbUser = new System.Windows.Forms.Label();
            btnClose = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            burger = new System.Windows.Forms.PictureBox();
            panelPrincipal = new System.Windows.Forms.FlowLayoutPanel();
            panelProductos = new System.Windows.Forms.Panel();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            btnProductos = new System.Windows.Forms.Button();
            panelProveedores = new System.Windows.Forms.Panel();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            btnProveedores = new System.Windows.Forms.Button();
            panelUsuarios = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            btnUsuarios = new System.Windows.Forms.Button();
            panelFacturas = new System.Windows.Forms.Panel();
            panel6 = new System.Windows.Forms.Panel();
            pictureBox5 = new System.Windows.Forms.PictureBox();
            btnListaFacturas = new System.Windows.Forms.Button();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            btnFacturas = new System.Windows.Forms.Button();
            panelClientes = new System.Windows.Forms.Panel();
            panel8 = new System.Windows.Forms.Panel();
            pictureBox6 = new System.Windows.Forms.PictureBox();
            btnClientes = new System.Windows.Forms.Button();
            pictureBox7 = new System.Windows.Forms.PictureBox();
            button3 = new System.Windows.Forms.Button();
            panelMain = new System.Windows.Forms.Panel();
            panelTitulo = new System.Windows.Forms.Panel();
            lbTitulo = new System.Windows.Forms.Label();
            panelCarrito = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            pictureBox8 = new System.Windows.Forms.PictureBox();
            btnVenta = new System.Windows.Forms.Button();
            pictureBox9 = new System.Windows.Forms.PictureBox();
            button2 = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)burger).BeginInit();
            panelPrincipal.SuspendLayout();
            panelProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panelUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelFacturas.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panelClientes.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panelMain.SuspendLayout();
            panelTitulo.SuspendLayout();
            panelCarrito.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.DodgerBlue;
            panel1.Controls.Add(lbUser);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(burger);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1285, 45);
            panel1.TabIndex = 0;
            // 
            // lbUser
            // 
            lbUser.AutoSize = true;
            lbUser.Location = new System.Drawing.Point(196, 5);
            lbUser.Name = "lbUser";
            lbUser.Size = new System.Drawing.Size(141, 34);
            lbUser.TabIndex = 1;
            lbUser.Text = "User - Rol";
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnClose.Location = new System.Drawing.Point(1233, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(40, 40);
            btnClose.TabIndex = 2;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(49, 5);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(161, 34);
            label1.TabIndex = 1;
            label1.Text = " STYLESYS -";
            // 
            // burger
            // 
            burger.Image = Properties.Resources.burgerbtn;
            burger.Location = new System.Drawing.Point(3, 2);
            burger.Name = "burger";
            burger.Size = new System.Drawing.Size(40, 40);
            burger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            burger.TabIndex = 0;
            burger.TabStop = false;
            // 
            // panelPrincipal
            // 
            panelPrincipal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            panelPrincipal.BackColor = System.Drawing.SystemColors.InactiveCaption;
            panelPrincipal.Controls.Add(panelProductos);
            panelPrincipal.Controls.Add(panelProveedores);
            panelPrincipal.Controls.Add(panelUsuarios);
            panelPrincipal.Controls.Add(panelFacturas);
            panelPrincipal.Controls.Add(panelClientes);
            panelPrincipal.Controls.Add(panelCarrito);
            panelPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            panelPrincipal.Location = new System.Drawing.Point(0, 45);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new System.Drawing.Size(382, 611);
            panelPrincipal.TabIndex = 1;
            // 
            // panelProductos
            // 
            panelProductos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            panelProductos.Controls.Add(pictureBox2);
            panelProductos.Controls.Add(btnProductos);
            panelProductos.Dock = System.Windows.Forms.DockStyle.Top;
            panelProductos.Location = new System.Drawing.Point(3, 3);
            panelProductos.Name = "panelProductos";
            panelProductos.Size = new System.Drawing.Size(379, 42);
            panelProductos.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.prodbtn;
            pictureBox2.Location = new System.Drawing.Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(35, 35);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // btnProductos
            // 
            btnProductos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            btnProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnProductos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnProductos.ForeColor = System.Drawing.Color.White;
            btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnProductos.Location = new System.Drawing.Point(0, 0);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new System.Drawing.Size(379, 42);
            btnProductos.TabIndex = 2;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += btnProductos_Click;
            // 
            // panelProveedores
            // 
            panelProveedores.BackColor = System.Drawing.SystemColors.InactiveCaption;
            panelProveedores.Controls.Add(pictureBox3);
            panelProveedores.Controls.Add(btnProveedores);
            panelProveedores.Location = new System.Drawing.Point(3, 51);
            panelProveedores.Name = "panelProveedores";
            panelProveedores.Size = new System.Drawing.Size(379, 42);
            panelProveedores.TabIndex = 5;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(35, 35);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // btnProveedores
            // 
            btnProveedores.BackColor = System.Drawing.SystemColors.InactiveCaption;
            btnProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            btnProveedores.FlatAppearance.BorderSize = 0;
            btnProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnProveedores.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnProveedores.ForeColor = System.Drawing.Color.White;
            btnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnProveedores.Location = new System.Drawing.Point(0, 0);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new System.Drawing.Size(379, 42);
            btnProveedores.TabIndex = 2;
            btnProveedores.Text = "Proveedores";
            btnProveedores.UseVisualStyleBackColor = false;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // panelUsuarios
            // 
            panelUsuarios.BackColor = System.Drawing.SystemColors.InactiveCaption;
            panelUsuarios.Controls.Add(pictureBox1);
            panelUsuarios.Controls.Add(btnUsuarios);
            panelUsuarios.Location = new System.Drawing.Point(3, 99);
            panelUsuarios.Name = "panelUsuarios";
            panelUsuarios.Size = new System.Drawing.Size(379, 42);
            panelUsuarios.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(35, 35);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = System.Drawing.SystemColors.InactiveCaption;
            btnUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUsuarios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnUsuarios.ForeColor = System.Drawing.Color.White;
            btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnUsuarios.Location = new System.Drawing.Point(0, 0);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new System.Drawing.Size(379, 42);
            btnUsuarios.TabIndex = 2;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // panelFacturas
            // 
            panelFacturas.BackColor = System.Drawing.SystemColors.InactiveCaption;
            panelFacturas.Controls.Add(panel6);
            panelFacturas.Controls.Add(pictureBox4);
            panelFacturas.Controls.Add(btnFacturas);
            panelFacturas.Location = new System.Drawing.Point(3, 147);
            panelFacturas.Name = "panelFacturas";
            panelFacturas.Size = new System.Drawing.Size(379, 42);
            panelFacturas.TabIndex = 5;
            // 
            // panel6
            // 
            panel6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            panel6.Controls.Add(pictureBox5);
            panel6.Controls.Add(btnListaFacturas);
            panel6.Dock = System.Windows.Forms.DockStyle.Top;
            panel6.Location = new System.Drawing.Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new System.Drawing.Size(379, 42);
            panel6.TabIndex = 6;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (System.Drawing.Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new System.Drawing.Point(3, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new System.Drawing.Size(35, 35);
            pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // btnListaFacturas
            // 
            btnListaFacturas.BackColor = System.Drawing.SystemColors.InactiveCaption;
            btnListaFacturas.Dock = System.Windows.Forms.DockStyle.Fill;
            btnListaFacturas.FlatAppearance.BorderSize = 0;
            btnListaFacturas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnListaFacturas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnListaFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnListaFacturas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnListaFacturas.ForeColor = System.Drawing.Color.White;
            btnListaFacturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnListaFacturas.Location = new System.Drawing.Point(0, 0);
            btnListaFacturas.Name = "btnListaFacturas";
            btnListaFacturas.Size = new System.Drawing.Size(379, 42);
            btnListaFacturas.TabIndex = 2;
            btnListaFacturas.Text = "Facturas";
            btnListaFacturas.UseVisualStyleBackColor = false;
            btnListaFacturas.Click += btnFacturas_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.prodbtn;
            pictureBox4.Location = new System.Drawing.Point(3, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(35, 35);
            pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // btnFacturas
            // 
            btnFacturas.BackColor = System.Drawing.SystemColors.InactiveCaption;
            btnFacturas.Dock = System.Windows.Forms.DockStyle.Fill;
            btnFacturas.FlatAppearance.BorderSize = 0;
            btnFacturas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnFacturas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFacturas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnFacturas.ForeColor = System.Drawing.Color.White;
            btnFacturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnFacturas.Location = new System.Drawing.Point(0, 0);
            btnFacturas.Name = "btnFacturas";
            btnFacturas.Size = new System.Drawing.Size(379, 42);
            btnFacturas.TabIndex = 2;
            btnFacturas.Text = "Facturas";
            btnFacturas.UseVisualStyleBackColor = false;
            // 
            // panelClientes
            // 
            panelClientes.BackColor = System.Drawing.SystemColors.InactiveCaption;
            panelClientes.Controls.Add(panel8);
            panelClientes.Controls.Add(pictureBox7);
            panelClientes.Controls.Add(button3);
            panelClientes.Location = new System.Drawing.Point(3, 195);
            panelClientes.Name = "panelClientes";
            panelClientes.Size = new System.Drawing.Size(379, 42);
            panelClientes.TabIndex = 7;
            // 
            // panel8
            // 
            panel8.BackColor = System.Drawing.SystemColors.InactiveCaption;
            panel8.Controls.Add(pictureBox6);
            panel8.Controls.Add(btnClientes);
            panel8.Dock = System.Windows.Forms.DockStyle.Top;
            panel8.Location = new System.Drawing.Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new System.Drawing.Size(379, 42);
            panel8.TabIndex = 6;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (System.Drawing.Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new System.Drawing.Point(3, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new System.Drawing.Size(35, 35);
            pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 4;
            pictureBox6.TabStop = false;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = System.Drawing.SystemColors.InactiveCaption;
            btnClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnClientes.ForeColor = System.Drawing.Color.White;
            btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnClientes.Location = new System.Drawing.Point(0, 0);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new System.Drawing.Size(379, 42);
            btnClientes.TabIndex = 2;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += button2_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.prodbtn;
            pictureBox7.Location = new System.Drawing.Point(3, 3);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new System.Drawing.Size(35, 35);
            pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 4;
            pictureBox7.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            button3.Dock = System.Windows.Forms.DockStyle.Fill;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            button3.ForeColor = System.Drawing.Color.White;
            button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button3.Location = new System.Drawing.Point(0, 0);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(379, 42);
            button3.TabIndex = 2;
            button3.Text = "Facturas";
            button3.UseVisualStyleBackColor = false;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(panelTitulo);
            panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            panelMain.Location = new System.Drawing.Point(382, 45);
            panelMain.Name = "panelMain";
            panelMain.Size = new System.Drawing.Size(903, 611);
            panelMain.TabIndex = 4;
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            panelTitulo.Controls.Add(lbTitulo);
            panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            panelTitulo.Location = new System.Drawing.Point(0, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new System.Drawing.Size(903, 50);
            panelTitulo.TabIndex = 0;
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Location = new System.Drawing.Point(402, 8);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new System.Drawing.Size(84, 34);
            lbTitulo.TabIndex = 1;
            lbTitulo.Text = "Titulo";
            // 
            // panelCarrito
            // 
            panelCarrito.BackColor = System.Drawing.SystemColors.InactiveCaption;
            panelCarrito.Controls.Add(panel3);
            panelCarrito.Controls.Add(pictureBox9);
            panelCarrito.Controls.Add(button2);
            panelCarrito.Location = new System.Drawing.Point(3, 243);
            panelCarrito.Name = "panelCarrito";
            panelCarrito.Size = new System.Drawing.Size(379, 42);
            panelCarrito.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            panel3.Controls.Add(pictureBox8);
            panel3.Controls.Add(btnVenta);
            panel3.Dock = System.Windows.Forms.DockStyle.Top;
            panel3.Location = new System.Drawing.Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(379, 42);
            panel3.TabIndex = 6;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (System.Drawing.Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new System.Drawing.Point(3, 3);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new System.Drawing.Size(35, 35);
            pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 4;
            pictureBox8.TabStop = false;
            // 
            // btnVenta
            // 
            btnVenta.BackColor = System.Drawing.SystemColors.InactiveCaption;
            btnVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            btnVenta.FlatAppearance.BorderSize = 0;
            btnVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnVenta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnVenta.ForeColor = System.Drawing.Color.White;
            btnVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnVenta.Location = new System.Drawing.Point(0, 0);
            btnVenta.Name = "btnVenta";
            btnVenta.Size = new System.Drawing.Size(379, 42);
            btnVenta.TabIndex = 2;
            btnVenta.Text = "Nueva Venta";
            btnVenta.UseVisualStyleBackColor = false;
            btnVenta.Click += btnVenta_Click;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.prodbtn;
            pictureBox9.Location = new System.Drawing.Point(3, 3);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new System.Drawing.Size(35, 35);
            pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 4;
            pictureBox9.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            button2.Dock = System.Windows.Forms.DockStyle.Fill;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            button2.ForeColor = System.Drawing.Color.White;
            button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button2.Location = new System.Drawing.Point(0, 0);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(379, 42);
            button2.TabIndex = 2;
            button2.Text = "Facturas";
            button2.UseVisualStyleBackColor = false;
            // 
            // Dashboard
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new System.Drawing.Size(1285, 656);
            Controls.Add(panelMain);
            Controls.Add(panelPrincipal);
            Controls.Add(panel1);
            Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(6);
            Name = "Dashboard";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Dashboard - StyleSys";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)burger).EndInit();
            panelPrincipal.ResumeLayout(false);
            panelProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelProveedores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panelUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelFacturas.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panelClientes.ResumeLayout(false);
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panelMain.ResumeLayout(false);
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            panelCarrito.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox burger;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel panelPrincipal;
        private System.Windows.Forms.Panel panelProductos;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelUsuarios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Panel panelProveedores;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Panel panelFacturas;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnFacturas;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnListaFacturas;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Panel panelClientes;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panelCarrito;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Button button2;
    }
}

