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
            dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panel2 = new System.Windows.Forms.Panel();
            VentaBusca = new System.Windows.Forms.Button();
            ventas_fechahasta = new System.Windows.Forms.DateTimePicker();
            label5 = new System.Windows.Forms.Label();
            ventas_fechadesde = new System.Windows.Forms.DateTimePicker();
            label7 = new System.Windows.Forms.Label();
            compras = new System.Windows.Forms.TabPage();
            dgvCompras = new System.Windows.Forms.DataGridView();
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
            codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nombreproducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cantidad_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            precio_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            total_parcial = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            panel1.Location = new System.Drawing.Point(0, 353);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(982, 100);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(11, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(70, 69);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(88, 33);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(132, 34);
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
            tabReportes.Name = "tabReportes";
            tabReportes.SelectedIndex = 0;
            tabReportes.Size = new System.Drawing.Size(982, 353);
            tabReportes.TabIndex = 2;
            // 
            // ventas
            // 
            ventas.Controls.Add(dgvVentasDiarias);
            ventas.Controls.Add(panel2);
            ventas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            ventas.Location = new System.Drawing.Point(4, 34);
            ventas.Name = "ventas";
            ventas.Padding = new System.Windows.Forms.Padding(3);
            ventas.Size = new System.Drawing.Size(974, 315);
            ventas.TabIndex = 1;
            ventas.Text = "Ventas";
            ventas.UseVisualStyleBackColor = true;
            // 
            // dgvVentasDiarias
            // 
            dgvVentasDiarias.AllowUserToAddRows = false;
            dgvVentasDiarias.AllowUserToDeleteRows = false;
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
            dgvVentasDiarias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, vendedor, cliente });
            dgvVentasDiarias.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvVentasDiarias.EnableHeadersVisualStyles = false;
            dgvVentasDiarias.Location = new System.Drawing.Point(3, 64);
            dgvVentasDiarias.Name = "dgvVentasDiarias";
            dgvVentasDiarias.RowHeadersWidth = 51;
            dgvVentasDiarias.Size = new System.Drawing.Size(968, 248);
            dgvVentasDiarias.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.HeaderText = "Código";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn2.HeaderText = "Fecha";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 74;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.HeaderText = "Forma Pago";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn4.HeaderText = "Producto";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn5.HeaderText = "Cantidad";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 96;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn6.HeaderText = "Precio";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 77;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn7.HeaderText = "Total";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // vendedor
            // 
            vendedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            vendedor.HeaderText = "Vendedor";
            vendedor.MinimumWidth = 6;
            vendedor.Name = "vendedor";
            // 
            // cliente
            // 
            cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            cliente.HeaderText = "Cliente";
            cliente.MinimumWidth = 6;
            cliente.Name = "cliente";
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
            panel2.Location = new System.Drawing.Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(968, 61);
            panel2.TabIndex = 1;
            // 
            // VentaBusca
            // 
            VentaBusca.BackColor = System.Drawing.Color.Azure;
            VentaBusca.Location = new System.Drawing.Point(745, 20);
            VentaBusca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            VentaBusca.Name = "VentaBusca";
            VentaBusca.Size = new System.Drawing.Size(86, 31);
            VentaBusca.TabIndex = 8;
            VentaBusca.Text = "Buscar";
            VentaBusca.UseVisualStyleBackColor = false;
            VentaBusca.Click += VentaBusca_Click;
            // 
            // ventas_fechahasta
            // 
            ventas_fechahasta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            ventas_fechahasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            ventas_fechahasta.Location = new System.Drawing.Point(557, 20);
            ventas_fechahasta.MaxDate = new System.DateTime(2070, 11, 11, 0, 0, 0, 0);
            ventas_fechahasta.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            ventas_fechahasta.Name = "ventas_fechahasta";
            ventas_fechahasta.Size = new System.Drawing.Size(124, 27);
            ventas_fechahasta.TabIndex = 7;
            ventas_fechahasta.Value = new System.DateTime(2024, 11, 11, 23, 59, 0, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(425, 21);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(118, 22);
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
            ventas_fechadesde.Size = new System.Drawing.Size(124, 27);
            ventas_fechadesde.TabIndex = 5;
            ventas_fechadesde.Value = new System.DateTime(2024, 11, 1, 0, 0, 0, 0);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label7.ForeColor = System.Drawing.Color.White;
            label7.Location = new System.Drawing.Point(85, 20);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(126, 22);
            label7.TabIndex = 4;
            label7.Text = "Datos desde:";
            // 
            // compras
            // 
            compras.Controls.Add(dgvCompras);
            compras.Controls.Add(panel3);
            compras.Location = new System.Drawing.Point(4, 34);
            compras.Name = "compras";
            compras.Padding = new System.Windows.Forms.Padding(3);
            compras.Size = new System.Drawing.Size(974, 315);
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
            dgvCompras.Location = new System.Drawing.Point(3, 64);
            dgvCompras.Name = "dgvCompras";
            dgvCompras.RowHeadersWidth = 51;
            dgvCompras.Size = new System.Drawing.Size(968, 248);
            dgvCompras.TabIndex = 3;
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
            panel3.Location = new System.Drawing.Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(968, 61);
            panel3.TabIndex = 1;
            // 
            // compras_fechahasta
            // 
            compras_fechahasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            compras_fechahasta.Location = new System.Drawing.Point(475, 13);
            compras_fechahasta.Name = "compras_fechahasta";
            compras_fechahasta.Size = new System.Drawing.Size(135, 31);
            compras_fechahasta.TabIndex = 22;
            // 
            // compras_fechadesde
            // 
            compras_fechadesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            compras_fechadesde.Location = new System.Drawing.Point(173, 13);
            compras_fechadesde.Name = "compras_fechadesde";
            compras_fechadesde.Size = new System.Drawing.Size(135, 31);
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
            btnComprasFiltrar.Location = new System.Drawing.Point(659, 11);
            btnComprasFiltrar.Name = "btnComprasFiltrar";
            btnComprasFiltrar.Size = new System.Drawing.Size(133, 39);
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
            label4.Location = new System.Drawing.Point(363, 19);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(118, 22);
            label4.TabIndex = 2;
            label4.Text = "Datos hasta:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(53, 19);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(126, 22);
            label6.TabIndex = 0;
            label6.Text = "Datos desde:";
            // 
            // topVentas
            // 
            topVentas.Controls.Add(dgvRanking);
            topVentas.Controls.Add(panelForm);
            topVentas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            topVentas.Location = new System.Drawing.Point(4, 34);
            topVentas.Name = "topVentas";
            topVentas.Padding = new System.Windows.Forms.Padding(3);
            topVentas.Size = new System.Drawing.Size(974, 315);
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
            dgvRanking.Location = new System.Drawing.Point(3, 64);
            dgvRanking.Name = "dgvRanking";
            dgvRanking.RowHeadersWidth = 51;
            dgvRanking.Size = new System.Drawing.Size(968, 248);
            dgvRanking.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "No";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 56;
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
            panelForm.Location = new System.Drawing.Point(3, 3);
            panelForm.Name = "panelForm";
            panelForm.Size = new System.Drawing.Size(968, 61);
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
            label3.Size = new System.Drawing.Size(118, 22);
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
            label2.Size = new System.Drawing.Size(126, 22);
            label2.TabIndex = 0;
            label2.Text = "Datos desde:";
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
            fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            fecha.HeaderText = "Fecha";
            fecha.MinimumWidth = 6;
            fecha.Name = "fecha";
            fecha.Width = 84;
            // 
            // total
            // 
            total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            total.HeaderText = "Total";
            total.MinimumWidth = 6;
            total.Name = "total";
            total.Width = 76;
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
            cantidad_compra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            cantidad_compra.HeaderText = "Cantidad";
            cantidad_compra.MinimumWidth = 6;
            cantidad_compra.Name = "cantidad_compra";
            cantidad_compra.Width = 110;
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
            // MainReportes
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(982, 453);
            Controls.Add(tabReportes);
            Controls.Add(panel1);
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
        private System.Windows.Forms.DateTimePicker compras_fechahasta;
        private System.Windows.Forms.Button VentaBusca;
        private System.Windows.Forms.DataGridView dgvVentasDiarias;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
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