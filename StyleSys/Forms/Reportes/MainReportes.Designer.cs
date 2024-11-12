namespace StyleSys.Forms.Reportes
{
    partial class MainReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainReportes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            panel1 = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            tabReportes = new System.Windows.Forms.TabControl();
            ventas = new System.Windows.Forms.TabPage();
            dgvVentasDiarias = new System.Windows.Forms.DataGridView();
            dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cod_factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cf_montototal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cl_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            fp_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            us_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            fechaVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            detalles = new System.Windows.Forms.DataGridViewImageColumn();
            panel2 = new System.Windows.Forms.Panel();
            VentaBusca = new System.Windows.Forms.Button();
            ventas_fechahasta = new System.Windows.Forms.DateTimePicker();
            label5 = new System.Windows.Forms.Label();
            ventas_fechadesde = new System.Windows.Forms.DateTimePicker();
            label7 = new System.Windows.Forms.Label();
            compras = new System.Windows.Forms.TabPage();
            dgvCompras = new System.Windows.Forms.DataGridView();
            codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nombreproducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cantidad_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            precio_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            total_parcial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panel3 = new System.Windows.Forms.Panel();
            compras_fechahasta = new System.Windows.Forms.DateTimePicker();
            compras_fechadesde = new System.Windows.Forms.DateTimePicker();
            btnComprasFiltrar = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            topVentas = new System.Windows.Forms.TabPage();
            dgvRanking = new System.Windows.Forms.DataGridView();
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nombre_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            acumulado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panelForm = new System.Windows.Forms.Panel();
            mostrarRank = new System.Windows.Forms.Button();
            rankHasta = new System.Windows.Forms.DateTimePicker();
            label3 = new System.Windows.Forms.Label();
            rankDesde = new System.Windows.Forms.DateTimePicker();
            label2 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabReportes.SuspendLayout();
            ventas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentasDiarias).BeginInit();
            panel2.SuspendLayout();
            compras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCompras).BeginInit();
            panel3.SuspendLayout();
            topVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRanking).BeginInit();
            panelForm.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.DodgerBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 265);
            panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(859, 75);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(10, 11);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(61, 52);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(77, 25);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(106, 26);
            label1.TabIndex = 2;
            label1.Text = "Reportes";
            // 
            // tabReportes
            // 
            tabReportes.Controls.Add(ventas);
            tabReportes.Controls.Add(compras);
            tabReportes.Controls.Add(topVentas);
            tabReportes.Dock = System.Windows.Forms.DockStyle.Fill;
            tabReportes.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tabReportes.Location = new System.Drawing.Point(0, 0);
            tabReportes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabReportes.Name = "tabReportes";
            tabReportes.SelectedIndex = 0;
            tabReportes.Size = new System.Drawing.Size(859, 265);
            tabReportes.TabIndex = 2;
            // 
            // ventas
            // 
            ventas.Controls.Add(dgvVentasDiarias);
            ventas.Controls.Add(panel2);
            ventas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            ventas.Location = new System.Drawing.Point(4, 28);
            ventas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            ventas.Name = "ventas";
            ventas.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            ventas.Size = new System.Drawing.Size(851, 233);
            ventas.TabIndex = 1;
            ventas.Text = "Ventas";
            ventas.UseVisualStyleBackColor = true;
            // 
            // dgvVentasDiarias
            // 
            dgvVentasDiarias.AllowUserToAddRows = false;
            dgvVentasDiarias.BackgroundColor = System.Drawing.Color.White;
            dgvVentasDiarias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvVentasDiarias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvVentasDiarias.ColumnHeadersHeight = 30;
            dgvVentasDiarias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvVentasDiarias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dataGridViewTextBoxColumn1, cod_factura, cf_montototal, cl_nombre, fp_nombre, us_nombre, fechaVenta, detalles });
            dgvVentasDiarias.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvVentasDiarias.EnableHeadersVisualStyles = false;
            dgvVentasDiarias.Location = new System.Drawing.Point(3, 48);
            dgvVentasDiarias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dgvVentasDiarias.Name = "dgvVentasDiarias";
            dgvVentasDiarias.RowHeadersWidth = 51;
            dgvVentasDiarias.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dgvVentasDiarias.Size = new System.Drawing.Size(845, 183);
            dgvVentasDiarias.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn1.HeaderText = "No";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 46;
            // 
            // cod_factura
            // 
            cod_factura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            cod_factura.HeaderText = "Código";
            cod_factura.MinimumWidth = 6;
            cod_factura.Name = "cod_factura";
            cod_factura.Width = 69;
            // 
            // cf_montototal
            // 
            cf_montototal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            cf_montototal.HeaderText = "Monto Total";
            cf_montototal.MinimumWidth = 6;
            cf_montototal.Name = "cf_montototal";
            // 
            // cl_nombre
            // 
            cl_nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            cl_nombre.HeaderText = "Cliente";
            cl_nombre.MinimumWidth = 6;
            cl_nombre.Name = "cl_nombre";
            // 
            // fp_nombre
            // 
            fp_nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            fp_nombre.HeaderText = "Forma de pago";
            fp_nombre.MinimumWidth = 6;
            fp_nombre.Name = "fp_nombre";
            // 
            // us_nombre
            // 
            us_nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            us_nombre.HeaderText = "Vendedor";
            us_nombre.MinimumWidth = 6;
            us_nombre.Name = "us_nombre";
            // 
            // fechaVenta
            // 
            fechaVenta.HeaderText = "Fecha";
            fechaVenta.Name = "fechaVenta";
            // 
            // detalles
            // 
            detalles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            detalles.HeaderText = "";
            detalles.Image = (System.Drawing.Image)resources.GetObject("detalles.Image");
            detalles.MinimumWidth = 6;
            detalles.Name = "detalles";
            detalles.Width = 6;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.DodgerBlue;
            panel2.Controls.Add(VentaBusca);
            panel2.Controls.Add(ventas_fechahasta);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(ventas_fechadesde);
            panel2.Controls.Add(label7);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(3, 2);
            panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(845, 46);
            panel2.TabIndex = 1;
            // 
            // VentaBusca
            // 
            VentaBusca.BackColor = System.Drawing.Color.Azure;
            VentaBusca.Location = new System.Drawing.Point(652, 15);
            VentaBusca.Name = "VentaBusca";
            VentaBusca.Size = new System.Drawing.Size(75, 23);
            VentaBusca.TabIndex = 8;
            VentaBusca.Text = "Buscar";
            VentaBusca.UseVisualStyleBackColor = false;
            VentaBusca.Click += VentaBusca_Click;
            // 
            // ventas_fechahasta
            // 
            ventas_fechahasta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            ventas_fechahasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            ventas_fechahasta.Location = new System.Drawing.Point(487, 15);
            ventas_fechahasta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            ventas_fechahasta.MaxDate = new System.DateTime(2070, 11, 11, 0, 0, 0, 0);
            ventas_fechahasta.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            ventas_fechahasta.Name = "ventas_fechahasta";
            ventas_fechahasta.Size = new System.Drawing.Size(109, 23);
            ventas_fechahasta.TabIndex = 7;
            ventas_fechahasta.Value = new System.DateTime(2024, 11, 11, 23, 59, 0, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(372, 16);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(96, 18);
            label5.TabIndex = 6;
            label5.Text = "Datos hasta:";
            // 
            // ventas_fechadesde
            // 
            ventas_fechadesde.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            ventas_fechadesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            ventas_fechadesde.Location = new System.Drawing.Point(190, 14);
            ventas_fechadesde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            ventas_fechadesde.MaxDate = new System.DateTime(2080, 11, 11, 0, 0, 0, 0);
            ventas_fechadesde.Name = "ventas_fechadesde";
            ventas_fechadesde.Size = new System.Drawing.Size(109, 23);
            ventas_fechadesde.TabIndex = 5;
            ventas_fechadesde.Value = new System.DateTime(2024, 11, 1, 0, 0, 0, 0);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label7.ForeColor = System.Drawing.Color.White;
            label7.Location = new System.Drawing.Point(74, 15);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(103, 18);
            label7.TabIndex = 4;
            label7.Text = "Datos desde:";
            // 
            // compras
            // 
            compras.Controls.Add(dgvCompras);
            compras.Controls.Add(panel3);
            compras.Location = new System.Drawing.Point(4, 28);
            compras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            compras.Name = "compras";
            compras.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            compras.Size = new System.Drawing.Size(851, 233);
            compras.TabIndex = 2;
            compras.Text = "Compras";
            compras.UseVisualStyleBackColor = true;
            // 
            // dgvCompras
            // 
            dgvCompras.AllowUserToAddRows = false;
            dgvCompras.AllowUserToDeleteRows = false;
            dgvCompras.BackgroundColor = System.Drawing.Color.White;
            dgvCompras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCompras.ColumnHeadersHeight = 30;
            dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { codigo, fecha, total, nombreproducto, cantidad_compra, precio_compra, total_parcial });
            dgvCompras.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvCompras.EnableHeadersVisualStyles = false;
            dgvCompras.Location = new System.Drawing.Point(3, 48);
            dgvCompras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dgvCompras.Name = "dgvCompras";
            dgvCompras.RowHeadersWidth = 51;
            dgvCompras.Size = new System.Drawing.Size(845, 183);
            dgvCompras.TabIndex = 3;
            // 
            // codigo
            // 
            codigo.HeaderText = "Código Compra";
            codigo.MinimumWidth = 6;
            codigo.Name = "codigo";
            codigo.Width = 125;
            // 
            // fecha
            // 
            fecha.HeaderText = "Fecha";
            fecha.MinimumWidth = 6;
            fecha.Name = "fecha";
            fecha.Width = 125;
            // 
            // total
            // 
            total.HeaderText = "Total";
            total.MinimumWidth = 6;
            total.Name = "total";
            total.Width = 125;
            // 
            // nombreproducto
            // 
            nombreproducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            nombreproducto.HeaderText = "Producto";
            nombreproducto.MinimumWidth = 6;
            nombreproducto.Name = "nombreproducto";
            // 
            // cantidad_compra
            // 
            cantidad_compra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            cantidad_compra.HeaderText = "Cantidad";
            cantidad_compra.MinimumWidth = 6;
            cantidad_compra.Name = "cantidad_compra";
            // 
            // precio_compra
            // 
            precio_compra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            precio_compra.HeaderText = "Precio Compra";
            precio_compra.MinimumWidth = 6;
            precio_compra.Name = "precio_compra";
            // 
            // total_parcial
            // 
            total_parcial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            total_parcial.HeaderText = "Total parcial";
            total_parcial.MinimumWidth = 6;
            total_parcial.Name = "total_parcial";
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.DodgerBlue;
            panel3.Controls.Add(compras_fechahasta);
            panel3.Controls.Add(compras_fechadesde);
            panel3.Controls.Add(btnComprasFiltrar);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label6);
            panel3.Dock = System.Windows.Forms.DockStyle.Top;
            panel3.Location = new System.Drawing.Point(3, 2);
            panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(845, 46);
            panel3.TabIndex = 1;
            // 
            // compras_fechahasta
            // 
            compras_fechahasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            compras_fechahasta.Location = new System.Drawing.Point(416, 10);
            compras_fechahasta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            compras_fechahasta.Name = "compras_fechahasta";
            compras_fechahasta.Size = new System.Drawing.Size(119, 27);
            compras_fechahasta.TabIndex = 22;
            // 
            // compras_fechadesde
            // 
            compras_fechadesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            compras_fechadesde.Location = new System.Drawing.Point(151, 10);
            compras_fechadesde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            compras_fechadesde.Name = "compras_fechadesde";
            compras_fechadesde.Size = new System.Drawing.Size(119, 27);
            compras_fechadesde.TabIndex = 21;
            compras_fechadesde.Value = new System.DateTime(2024, 11, 1, 0, 0, 0, 0);
            // 
            // btnComprasFiltrar
            // 
            btnComprasFiltrar.BackColor = System.Drawing.Color.Gainsboro;
            btnComprasFiltrar.FlatAppearance.BorderSize = 0;
            btnComprasFiltrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            btnComprasFiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            btnComprasFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnComprasFiltrar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnComprasFiltrar.ForeColor = System.Drawing.Color.Black;
            btnComprasFiltrar.Image = (System.Drawing.Image)resources.GetObject("btnComprasFiltrar.Image");
            btnComprasFiltrar.Location = new System.Drawing.Point(577, 8);
            btnComprasFiltrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnComprasFiltrar.Name = "btnComprasFiltrar";
            btnComprasFiltrar.Size = new System.Drawing.Size(116, 29);
            btnComprasFiltrar.TabIndex = 20;
            btnComprasFiltrar.Text = "Buscar";
            btnComprasFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnComprasFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnComprasFiltrar.UseVisualStyleBackColor = false;
            btnComprasFiltrar.Click += btnComprasFiltrar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(318, 14);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(96, 18);
            label4.TabIndex = 2;
            label4.Text = "Datos hasta:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(46, 14);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(103, 18);
            label6.TabIndex = 0;
            label6.Text = "Datos desde:";
            // 
            // topVentas
            // 
            topVentas.Controls.Add(dgvRanking);
            topVentas.Controls.Add(panelForm);
            topVentas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            topVentas.Location = new System.Drawing.Point(4, 28);
            topVentas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            topVentas.Name = "topVentas";
            topVentas.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            topVentas.Size = new System.Drawing.Size(851, 233);
            topVentas.TabIndex = 0;
            topVentas.Text = "Ranking Ventas";
            topVentas.UseVisualStyleBackColor = true;
            // 
            // dgvRanking
            // 
            dgvRanking.AllowUserToAddRows = false;
            dgvRanking.AllowUserToDeleteRows = false;
            dgvRanking.BackgroundColor = System.Drawing.Color.White;
            dgvRanking.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvRanking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvRanking.ColumnHeadersHeight = 30;
            dgvRanking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRanking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1, nombre_producto, cantidad, acumulado, stock });
            dgvRanking.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvRanking.EnableHeadersVisualStyles = false;
            dgvRanking.Location = new System.Drawing.Point(3, 48);
            dgvRanking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dgvRanking.Name = "dgvRanking";
            dgvRanking.RowHeadersWidth = 51;
            dgvRanking.Size = new System.Drawing.Size(845, 183);
            dgvRanking.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "No";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 46;
            // 
            // nombre_producto
            // 
            nombre_producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            nombre_producto.HeaderText = "Producto";
            nombre_producto.MinimumWidth = 6;
            nombre_producto.Name = "nombre_producto";
            // 
            // cantidad
            // 
            cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            cantidad.HeaderText = "Cantidad Vendida";
            cantidad.MinimumWidth = 6;
            cantidad.Name = "cantidad";
            // 
            // acumulado
            // 
            acumulado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            acumulado.HeaderText = "Ingreso Acumulado";
            acumulado.MinimumWidth = 6;
            acumulado.Name = "acumulado";
            // 
            // stock
            // 
            stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            stock.HeaderText = "Stock Actual";
            stock.MinimumWidth = 6;
            stock.Name = "stock";
            // 
            // panelForm
            // 
            panelForm.BackColor = System.Drawing.Color.DodgerBlue;
            panelForm.Controls.Add(mostrarRank);
            panelForm.Controls.Add(rankHasta);
            panelForm.Controls.Add(label3);
            panelForm.Controls.Add(rankDesde);
            panelForm.Controls.Add(label2);
            panelForm.Dock = System.Windows.Forms.DockStyle.Top;
            panelForm.Location = new System.Drawing.Point(3, 2);
            panelForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            panelForm.Name = "panelForm";
            panelForm.Size = new System.Drawing.Size(845, 46);
            panelForm.TabIndex = 0;
            // 
            // mostrarRank
            // 
            mostrarRank.Location = new System.Drawing.Point(638, 16);
            mostrarRank.Name = "mostrarRank";
            mostrarRank.Size = new System.Drawing.Size(75, 23);
            mostrarRank.TabIndex = 4;
            mostrarRank.Text = "Rankin";
            mostrarRank.UseVisualStyleBackColor = true;
            mostrarRank.Click += mostrarRank_Click;
            // 
            // rankHasta
            // 
            rankHasta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            rankHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            rankHasta.Location = new System.Drawing.Point(471, 14);
            rankHasta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            rankHasta.MaxDate = new System.DateTime(2080, 11, 11, 0, 0, 0, 0);
            rankHasta.Name = "rankHasta";
            rankHasta.Size = new System.Drawing.Size(109, 23);
            rankHasta.TabIndex = 3;
            rankHasta.Value = new System.DateTime(2024, 11, 12, 23, 59, 0, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(356, 16);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(96, 18);
            label3.TabIndex = 2;
            label3.Text = "Datos hasta:";
            // 
            // rankDesde
            // 
            rankDesde.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            rankDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            rankDesde.Location = new System.Drawing.Point(185, 12);
            rankDesde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            rankDesde.MaxDate = new System.DateTime(2080, 11, 11, 0, 0, 0, 0);
            rankDesde.Name = "rankDesde";
            rankDesde.Size = new System.Drawing.Size(109, 23);
            rankDesde.TabIndex = 1;
            rankDesde.Value = new System.DateTime(2024, 9, 27, 0, 0, 0, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(70, 14);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(103, 18);
            label2.TabIndex = 0;
            label2.Text = "Datos desde:";
            // 
            // MainReportes
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(859, 340);
            Controls.Add(tabReportes);
            Controls.Add(panel1);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "MainReportes";
            Text = "Reportes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabReportes.ResumeLayout(false);
            ventas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVentasDiarias).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            compras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCompras).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            topVentas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRanking).EndInit();
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabReportes;
        private System.Windows.Forms.TabPage topVentas;
        private System.Windows.Forms.TabPage ventas;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker rankHasta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker rankDesde;
        private System.Windows.Forms.DataGridView dgvRanking;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn acumulado;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpVentasDiarias;
        private System.Windows.Forms.DataGridView dgvVentasDiarias;
        private System.Windows.Forms.TabPage compras;
        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker compras_fechadesde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker ventas_fechahasta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker ventas_fechadesde;
        private System.Windows.Forms.Label label7;
        protected System.Windows.Forms.Button btnComprasFiltrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_parcial;
        private System.Windows.Forms.DateTimePicker compras_fechahasta;
        private System.Windows.Forms.Button VentaBusca;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn cf_montototal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn fp_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn us_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVenta;
        private System.Windows.Forms.DataGridViewImageColumn detalles;
        private System.Windows.Forms.Button mostrarRank;
    }
}