namespace StyleSys.Forms.Ventas_Carrito
{
    partial class BuscarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarProducto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            panel1 = new System.Windows.Forms.Panel();
            tbBuscarProd = new System.Windows.Forms.TextBox();
            btnCancelar = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            dgvProductos = new System.Windows.Forms.DataGridView();
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            precioventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            select = new System.Windows.Forms.DataGridViewImageColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.DodgerBlue;
            panel1.Controls.Add(tbBuscarProd);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 506);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1043, 100);
            panel1.TabIndex = 3;
            // 
            // tbBuscarProd
            // 
            tbBuscarProd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tbBuscarProd.Location = new System.Drawing.Point(404, 36);
            tbBuscarProd.Name = "tbBuscarProd";
            tbBuscarProd.PlaceholderText = "Busca un producto...";
            tbBuscarProd.Size = new System.Drawing.Size(407, 32);
            tbBuscarProd.TabIndex = 5;
            tbBuscarProd.TextChanged += tbBuscarProd_TextChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = System.Drawing.Color.Transparent;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnCancelar.Image = (System.Drawing.Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.Location = new System.Drawing.Point(899, 26);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(132, 53);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(12, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(70, 70);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(88, 35);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(235, 34);
            label1.TabIndex = 2;
            label1.Text = "Buscar Producto";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvProductos);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1043, 606);
            panel2.TabIndex = 4;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.BackgroundColor = System.Drawing.Color.White;
            dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvProductos.ColumnHeadersHeight = 30;
            dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1, id, nombre, categoria, stock, precioventa, select });
            dgvProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvProductos.EnableHeadersVisualStyles = false;
            dgvProductos.Location = new System.Drawing.Point(0, 0);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new System.Drawing.Size(1043, 606);
            dgvProductos.TabIndex = 1;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "No";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 62;
            // 
            // id
            // 
            id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            id.HeaderText = "Id";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Width = 54;
            // 
            // nombre
            // 
            nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            // 
            // categoria
            // 
            categoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            categoria.HeaderText = "Categoria";
            categoria.MinimumWidth = 6;
            categoria.Name = "categoria";
            // 
            // stock
            // 
            stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            stock.HeaderText = "Stock Actual";
            stock.MinimumWidth = 6;
            stock.Name = "stock";
            // 
            // precioventa
            // 
            precioventa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            precioventa.DefaultCellStyle = dataGridViewCellStyle4;
            precioventa.HeaderText = "Precio Venta";
            precioventa.MinimumWidth = 6;
            precioventa.Name = "precioventa";
            // 
            // select
            // 
            select.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            select.HeaderText = "";
            select.Image = (System.Drawing.Image)resources.GetObject("select.Image");
            select.MinimumWidth = 6;
            select.Name = "select";
            select.Width = 6;
            // 
            // BuscarProducto
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1043, 606);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "BuscarProducto";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "BuscarProducto";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.TextBox tbBuscarProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioventa;
        private System.Windows.Forms.DataGridViewImageColumn select;
    }
}