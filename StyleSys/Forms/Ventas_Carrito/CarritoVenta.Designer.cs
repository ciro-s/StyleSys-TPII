namespace StyleSys.Forms.Ventas_Carrito
{
    partial class CarritoVenta
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarritoVenta));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            panel1 = new System.Windows.Forms.Panel();
            lbPrecioTotal = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            idCliente = new System.Windows.Forms.Label();
            cbFormaPago = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            btnBuscarCliente = new System.Windows.Forms.Button();
            tbCliente = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            btnRegistrar = new System.Windows.Forms.Button();
            labelTo = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            lbTimer = new System.Windows.Forms.Label();
            lbCodFactura = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            cant = new System.Windows.Forms.NumericUpDown();
            label4 = new System.Windows.Forms.Label();
            btnBuscarProd = new System.Windows.Forms.Button();
            tbProd = new System.Windows.Forms.TextBox();
            lbProd = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            dgvCarrito = new System.Windows.Forms.DataGridView();
            id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            precioventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            delete = new System.Windows.Forms.DataGridViewImageColumn();
            panel4 = new System.Windows.Forms.Panel();
            idProd = new System.Windows.Forms.Label();
            btnAddToCart = new System.Windows.Forms.Button();
            timer = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cant).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.DodgerBlue;
            panel1.Controls.Add(lbPrecioTotal);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(idCliente);
            panel1.Controls.Add(cbFormaPago);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnBuscarCliente);
            panel1.Controls.Add(tbCliente);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnRegistrar);
            panel1.Controls.Add(labelTo);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(lbCodFactura);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Right;
            panel1.Location = new System.Drawing.Point(838, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(301, 611);
            panel1.TabIndex = 3;
            // 
            // lbPrecioTotal
            // 
            lbPrecioTotal.AutoSize = true;
            lbPrecioTotal.BackColor = System.Drawing.Color.Transparent;
            lbPrecioTotal.Font = new System.Drawing.Font("Century Gothic", 19.8000011F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lbPrecioTotal.ForeColor = System.Drawing.Color.White;
            lbPrecioTotal.Location = new System.Drawing.Point(39, 307);
            lbPrecioTotal.Name = "lbPrecioTotal";
            lbPrecioTotal.Size = new System.Drawing.Size(112, 40);
            lbPrecioTotal.TabIndex = 10;
            lbPrecioTotal.Text = "00000";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Century Gothic", 19.8000011F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(8, 307);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(36, 40);
            label5.TabIndex = 27;
            label5.Text = "$";
            // 
            // idCliente
            // 
            idCliente.AutoSize = true;
            idCliente.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            idCliente.ForeColor = System.Drawing.Color.Black;
            idCliente.Location = new System.Drawing.Point(6, 155);
            idCliente.Name = "idCliente";
            idCliente.Size = new System.Drawing.Size(117, 27);
            idCliente.TabIndex = 26;
            idCliente.Text = "id cliente";
            idCliente.Visible = false;
            // 
            // cbFormaPago
            // 
            cbFormaPago.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            cbFormaPago.FormattingEnabled = true;
            cbFormaPago.Location = new System.Drawing.Point(9, 212);
            cbFormaPago.Name = "cbFormaPago";
            cbFormaPago.Size = new System.Drawing.Size(270, 29);
            cbFormaPago.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(6, 182);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(273, 27);
            label3.TabIndex = 16;
            label3.Text = "Elegir Metodo de Pago:";
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.BackColor = System.Drawing.Color.Transparent;
            btnBuscarCliente.FlatAppearance.BorderSize = 0;
            btnBuscarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            btnBuscarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBuscarCliente.Image = (System.Drawing.Image)resources.GetObject("btnBuscarCliente.Image");
            btnBuscarCliente.Location = new System.Drawing.Point(228, 112);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new System.Drawing.Size(61, 48);
            btnBuscarCliente.TabIndex = 15;
            btnBuscarCliente.UseVisualStyleBackColor = false;
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            // 
            // tbCliente
            // 
            tbCliente.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tbCliente.Location = new System.Drawing.Point(6, 122);
            tbCliente.Name = "tbCliente";
            tbCliente.ReadOnly = true;
            tbCliente.Size = new System.Drawing.Size(216, 30);
            tbCliente.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(3, 92);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(179, 27);
            label2.TabIndex = 13;
            label2.Text = "Buscar Cliente:";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = System.Drawing.Color.Transparent;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = System.Drawing.Color.White;
            btnRegistrar.Image = (System.Drawing.Image)resources.GetObject("btnRegistrar.Image");
            btnRegistrar.Location = new System.Drawing.Point(0, 369);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new System.Drawing.Size(346, 53);
            btnRegistrar.TabIndex = 11;
            btnRegistrar.Text = "Registrar Venta";
            btnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // labelTo
            // 
            labelTo.AutoSize = true;
            labelTo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelTo.ForeColor = System.Drawing.Color.White;
            labelTo.Location = new System.Drawing.Point(11, 280);
            labelTo.Name = "labelTo";
            labelTo.Size = new System.Drawing.Size(71, 27);
            labelTo.TabIndex = 9;
            labelTo.Text = "Total:";
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            panel3.Controls.Add(lbTimer);
            panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel3.Location = new System.Drawing.Point(0, 544);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(301, 67);
            panel3.TabIndex = 8;
            // 
            // lbTimer
            // 
            lbTimer.AutoSize = true;
            lbTimer.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lbTimer.ForeColor = System.Drawing.Color.White;
            lbTimer.Location = new System.Drawing.Point(48, 11);
            lbTimer.Name = "lbTimer";
            lbTimer.Size = new System.Drawing.Size(174, 47);
            lbTimer.TabIndex = 9;
            lbTimer.Text = "00:00:00";
            // 
            // lbCodFactura
            // 
            lbCodFactura.AutoSize = true;
            lbCodFactura.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lbCodFactura.ForeColor = System.Drawing.Color.White;
            lbCodFactura.Location = new System.Drawing.Point(6, 369);
            lbCodFactura.Name = "lbCodFactura";
            lbCodFactura.Size = new System.Drawing.Size(0, 27);
            lbCodFactura.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(15, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(53, 46);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(61, 21);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(215, 34);
            label1.TabIndex = 2;
            label1.Text = "Registrar venta";
            // 
            // cant
            // 
            cant.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            cant.ForeColor = System.Drawing.Color.Black;
            cant.Location = new System.Drawing.Point(315, 57);
            cant.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            cant.Name = "cant";
            cant.Size = new System.Drawing.Size(74, 28);
            cant.TabIndex = 23;
            cant.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.ForeColor = System.Drawing.Color.Black;
            label4.Location = new System.Drawing.Point(177, 58);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(123, 27);
            label4.TabIndex = 22;
            label4.Text = "Cantidad:";
            // 
            // btnBuscarProd
            // 
            btnBuscarProd.BackColor = System.Drawing.Color.Transparent;
            btnBuscarProd.FlatAppearance.BorderSize = 0;
            btnBuscarProd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            btnBuscarProd.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            btnBuscarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBuscarProd.ForeColor = System.Drawing.Color.Black;
            btnBuscarProd.Image = (System.Drawing.Image)resources.GetObject("btnBuscarProd.Image");
            btnBuscarProd.Location = new System.Drawing.Point(399, 5);
            btnBuscarProd.Name = "btnBuscarProd";
            btnBuscarProd.Size = new System.Drawing.Size(61, 48);
            btnBuscarProd.TabIndex = 12;
            btnBuscarProd.UseVisualStyleBackColor = false;
            btnBuscarProd.Click += btnBuscar_Click;
            // 
            // tbProd
            // 
            tbProd.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tbProd.ForeColor = System.Drawing.Color.Black;
            tbProd.Location = new System.Drawing.Point(177, 15);
            tbProd.Name = "tbProd";
            tbProd.ReadOnly = true;
            tbProd.Size = new System.Drawing.Size(216, 30);
            tbProd.TabIndex = 7;
            // 
            // lbProd
            // 
            lbProd.AutoSize = true;
            lbProd.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lbProd.ForeColor = System.Drawing.Color.Black;
            lbProd.Location = new System.Drawing.Point(12, 19);
            lbProd.Name = "lbProd";
            lbProd.Size = new System.Drawing.Size(159, 22);
            lbProd.TabIndex = 6;
            lbProd.Text = "Buscar Producto:";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvCarrito);
            panel2.Controls.Add(panel4);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(838, 611);
            panel2.TabIndex = 4;
            // 
            // dgvCarrito
            // 
            dgvCarrito.AllowUserToAddRows = false;
            dgvCarrito.BackgroundColor = System.Drawing.Color.White;
            dgvCarrito.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvCarrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCarrito.ColumnHeadersHeight = 30;
            dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCarrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { id, nombre, precioventa, cantidad, total, delete });
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvCarrito.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCarrito.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvCarrito.EnableHeadersVisualStyles = false;
            dgvCarrito.Location = new System.Drawing.Point(0, 98);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.RowHeadersWidth = 51;
            dgvCarrito.Size = new System.Drawing.Size(838, 513);
            dgvCarrito.TabIndex = 4;
            dgvCarrito.CellContentClick += dgvCarrito_CellContentClick;
            // 
            // id
            // 
            id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            id.HeaderText = "Id";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Visible = false;
            id.Width = 125;
            // 
            // nombre
            // 
            nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            // 
            // precioventa
            // 
            precioventa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            precioventa.HeaderText = "Precio";
            precioventa.MinimumWidth = 6;
            precioventa.Name = "precioventa";
            // 
            // cantidad
            // 
            cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            cantidad.HeaderText = "Cantidad";
            cantidad.MinimumWidth = 6;
            cantidad.Name = "cantidad";
            // 
            // total
            // 
            total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            total.HeaderText = "Total";
            total.MinimumWidth = 6;
            total.Name = "total";
            // 
            // delete
            // 
            delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            delete.HeaderText = "";
            delete.Image = (System.Drawing.Image)resources.GetObject("delete.Image");
            delete.MinimumWidth = 6;
            delete.Name = "delete";
            delete.Width = 6;
            // 
            // panel4
            // 
            panel4.BackColor = System.Drawing.Color.White;
            panel4.Controls.Add(idProd);
            panel4.Controls.Add(btnAddToCart);
            panel4.Controls.Add(cant);
            panel4.Controls.Add(lbProd);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(tbProd);
            panel4.Controls.Add(btnBuscarProd);
            panel4.Dock = System.Windows.Forms.DockStyle.Top;
            panel4.Location = new System.Drawing.Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(838, 98);
            panel4.TabIndex = 0;
            // 
            // idProd
            // 
            idProd.AutoSize = true;
            idProd.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            idProd.ForeColor = System.Drawing.Color.Black;
            idProd.Location = new System.Drawing.Point(12, 47);
            idProd.Name = "idProd";
            idProd.Size = new System.Drawing.Size(142, 27);
            idProd.TabIndex = 25;
            idProd.Text = "id producto";
            idProd.Visible = false;
            // 
            // btnAddToCart
            // 
            btnAddToCart.BackColor = System.Drawing.Color.Gainsboro;
            btnAddToCart.FlatAppearance.BorderSize = 0;
            btnAddToCart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            btnAddToCart.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddToCart.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnAddToCart.ForeColor = System.Drawing.Color.Black;
            btnAddToCart.Image = (System.Drawing.Image)resources.GetObject("btnAddToCart.Image");
            btnAddToCart.Location = new System.Drawing.Point(457, 21);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new System.Drawing.Size(252, 53);
            btnAddToCart.TabIndex = 24;
            btnAddToCart.Text = "Agregar Producto";
            btnAddToCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnAddToCart.UseVisualStyleBackColor = false;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Tick += timer_Tick;
            // 
            // CarritoVenta
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1139, 611);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CarritoVenta";
            Text = "Carrito de Venta";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cant).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbCodFactura;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.TextBox tbProd;
        private System.Windows.Forms.Label lbProd;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lbPrecioTotal;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnBuscarProd;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox tbCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFormaPago;
        private System.Windows.Forms.Label label3;
        protected System.Windows.Forms.NumericUpDown cant;
        protected System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        protected System.Windows.Forms.Button btnAddToCart;
        public System.Windows.Forms.Label idProd;
        public System.Windows.Forms.Label idCliente;
        private System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioventa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.Label label5;
    }
}