namespace StyleSys.Forms.Facturas
{
    partial class NuevaCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevaCompra));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            panel1 = new System.Windows.Forms.Panel();
            idProd = new System.Windows.Forms.Label();
            idProv = new System.Windows.Forms.Label();
            cant = new System.Windows.Forms.NumericUpDown();
            label3 = new System.Windows.Forms.Label();
            btnAgregar = new System.Windows.Forms.Button();
            btnBuscarProd = new System.Windows.Forms.Button();
            tbProd = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            btnBuscarProv = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            tbProv = new System.Windows.Forms.TextBox();
            lbProd = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            tbTotal = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            btnRegistrar = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            dgvCarrito = new System.Windows.Forms.DataGridView();
            id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            precioventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            delete = new System.Windows.Forms.DataGridViewImageColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cant).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.White;
            panel1.Controls.Add(idProd);
            panel1.Controls.Add(idProv);
            panel1.Controls.Add(cant);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(btnBuscarProd);
            panel1.Controls.Add(tbProd);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnBuscarProv);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(tbProv);
            panel1.Controls.Add(lbProd);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(931, 243);
            panel1.TabIndex = 0;
            // 
            // idProd
            // 
            idProd.AutoSize = true;
            idProd.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            idProd.ForeColor = System.Drawing.Color.Black;
            idProd.Location = new System.Drawing.Point(593, 139);
            idProd.Name = "idProd";
            idProd.Size = new System.Drawing.Size(142, 27);
            idProd.TabIndex = 23;
            idProd.Text = "id producto";
            idProd.Visible = false;
            // 
            // idProv
            // 
            idProv.AutoSize = true;
            idProv.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            idProv.ForeColor = System.Drawing.Color.Black;
            idProv.Location = new System.Drawing.Point(593, 98);
            idProv.Name = "idProv";
            idProv.Size = new System.Drawing.Size(156, 27);
            idProv.TabIndex = 22;
            idProv.Text = "id proveedor";
            idProv.Visible = false;
            // 
            // cant
            // 
            cant.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            cant.Location = new System.Drawing.Point(511, 195);
            cant.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            cant.Name = "cant";
            cant.Size = new System.Drawing.Size(74, 28);
            cant.TabIndex = 21;
            cant.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.Black;
            label3.Location = new System.Drawing.Point(373, 196);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(123, 27);
            label3.TabIndex = 20;
            label3.Text = "Cantidad:";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = System.Drawing.Color.Gainsboro;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAgregar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = System.Drawing.Color.Black;
            btnAgregar.Image = (System.Drawing.Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.Location = new System.Drawing.Point(627, 170);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new System.Drawing.Size(264, 53);
            btnAgregar.TabIndex = 19;
            btnAgregar.Text = "Agregar Producto";
            btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnBuscarProd
            // 
            btnBuscarProd.BackColor = System.Drawing.Color.Transparent;
            btnBuscarProd.FlatAppearance.BorderSize = 0;
            btnBuscarProd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            btnBuscarProd.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            btnBuscarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBuscarProd.Image = (System.Drawing.Image)resources.GetObject("btnBuscarProd.Image");
            btnBuscarProd.Location = new System.Drawing.Point(222, 139);
            btnBuscarProd.Name = "btnBuscarProd";
            btnBuscarProd.Size = new System.Drawing.Size(61, 48);
            btnBuscarProd.TabIndex = 18;
            btnBuscarProd.UseVisualStyleBackColor = false;
            btnBuscarProd.Click += btnBuscarProd_Click;
            // 
            // tbProd
            // 
            tbProd.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tbProd.Location = new System.Drawing.Point(289, 149);
            tbProd.Name = "tbProd";
            tbProd.ReadOnly = true;
            tbProd.Size = new System.Drawing.Size(298, 30);
            tbProd.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(12, 151);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(199, 27);
            label2.TabIndex = 16;
            label2.Text = "Buscar Producto:";
            // 
            // btnBuscarProv
            // 
            btnBuscarProv.BackColor = System.Drawing.Color.Transparent;
            btnBuscarProv.FlatAppearance.BorderSize = 0;
            btnBuscarProv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            btnBuscarProv.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            btnBuscarProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBuscarProv.Image = (System.Drawing.Image)resources.GetObject("btnBuscarProv.Image");
            btnBuscarProv.Location = new System.Drawing.Point(222, 85);
            btnBuscarProv.Name = "btnBuscarProv";
            btnBuscarProv.Size = new System.Drawing.Size(61, 48);
            btnBuscarProv.TabIndex = 15;
            btnBuscarProv.UseVisualStyleBackColor = false;
            btnBuscarProv.Click += btnBuscarProv_Click;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.DodgerBlue;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(931, 57);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(5, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(53, 46);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(51, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(245, 34);
            label1.TabIndex = 4;
            label1.Text = "Registrar compra";
            // 
            // tbProv
            // 
            tbProv.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tbProv.Location = new System.Drawing.Point(289, 95);
            tbProv.Name = "tbProv";
            tbProv.ReadOnly = true;
            tbProv.Size = new System.Drawing.Size(298, 30);
            tbProv.TabIndex = 14;
            // 
            // lbProd
            // 
            lbProd.AutoSize = true;
            lbProd.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lbProd.ForeColor = System.Drawing.Color.Black;
            lbProd.Location = new System.Drawing.Point(12, 97);
            lbProd.Name = "lbProd";
            lbProd.Size = new System.Drawing.Size(213, 27);
            lbProd.TabIndex = 13;
            lbProd.Text = "Buscar Proveedor:";
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.White;
            panel3.Controls.Add(tbTotal);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(btnRegistrar);
            panel3.Controls.Add(button1);
            panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel3.Location = new System.Drawing.Point(0, 560);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(931, 78);
            panel3.TabIndex = 1;
            // 
            // tbTotal
            // 
            tbTotal.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tbTotal.Location = new System.Drawing.Point(222, 23);
            tbTotal.Name = "tbTotal";
            tbTotal.ReadOnly = true;
            tbTotal.Size = new System.Drawing.Size(298, 30);
            tbTotal.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.ForeColor = System.Drawing.Color.Black;
            label4.Location = new System.Drawing.Point(141, 23);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(84, 27);
            label4.TabIndex = 22;
            label4.Text = "TOTAL:";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = System.Drawing.Color.Gainsboro;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = System.Drawing.Color.Black;
            btnRegistrar.Image = (System.Drawing.Image)resources.GetObject("btnRegistrar.Image");
            btnRegistrar.Location = new System.Drawing.Point(718, 13);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new System.Drawing.Size(173, 53);
            btnRegistrar.TabIndex = 21;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Gainsboro;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            button1.ForeColor = System.Drawing.Color.Black;
            button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
            button1.Location = new System.Drawing.Point(543, 13);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(169, 53);
            button1.TabIndex = 20;
            button1.Text = "Cancelar";
            button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            dgvCarrito.Location = new System.Drawing.Point(0, 243);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.RowHeadersWidth = 51;
            dgvCarrito.Size = new System.Drawing.Size(931, 317);
            dgvCarrito.TabIndex = 3;
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
            // NuevaCompra
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(931, 638);
            Controls.Add(dgvCarrito);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "NuevaCompra";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "NuevaCompra";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cant).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvCarrito;
        protected System.Windows.Forms.Button btnBuscarProv;
        protected System.Windows.Forms.Label lbProd;
        protected System.Windows.Forms.Button btnBuscarProd;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Button btnAgregar;
        protected System.Windows.Forms.NumericUpDown cant;
        protected System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label idProv;
        public System.Windows.Forms.TextBox tbProv;
        public System.Windows.Forms.TextBox tbProd;
        public System.Windows.Forms.Label idProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioventa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        public System.Windows.Forms.TextBox tbTotal;
        protected System.Windows.Forms.Label label4;
    }
}