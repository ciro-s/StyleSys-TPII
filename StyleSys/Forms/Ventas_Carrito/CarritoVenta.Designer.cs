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
            btnBuscar = new System.Windows.Forms.Button();
            btnAgregar = new System.Windows.Forms.Button();
            lbPrecioTotal = new System.Windows.Forms.Label();
            labelTo = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            lbTimer = new System.Windows.Forms.Label();
            tbProd = new System.Windows.Forms.TextBox();
            lbProd = new System.Windows.Forms.Label();
            lbCodFactura = new System.Windows.Forms.Label();
            lbNoFactura = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            dgvCarrito = new System.Windows.Forms.DataGridView();
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            precioventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colAdd = new System.Windows.Forms.DataGridViewImageColumn();
            colReduce = new System.Windows.Forms.DataGridViewImageColumn();
            delete = new System.Windows.Forms.DataGridViewImageColumn();
            timer = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.DodgerBlue;
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(lbPrecioTotal);
            panel1.Controls.Add(labelTo);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(tbProd);
            panel1.Controls.Add(lbProd);
            panel1.Controls.Add(lbCodFactura);
            panel1.Controls.Add(lbNoFactura);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Right;
            panel1.Location = new System.Drawing.Point(838, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(301, 611);
            panel1.TabIndex = 3;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = System.Drawing.Color.Transparent;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBuscar.Image = (System.Drawing.Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new System.Drawing.Point(228, 125);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(61, 48);
            btnBuscar.TabIndex = 12;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = System.Drawing.Color.Transparent;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAgregar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = System.Drawing.Color.White;
            btnAgregar.Image = (System.Drawing.Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.Location = new System.Drawing.Point(0, 309);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new System.Drawing.Size(346, 53);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Registrar Venta";
            btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // lbPrecioTotal
            // 
            lbPrecioTotal.AutoSize = true;
            lbPrecioTotal.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lbPrecioTotal.ForeColor = System.Drawing.Color.White;
            lbPrecioTotal.Location = new System.Drawing.Point(6, 268);
            lbPrecioTotal.Name = "lbPrecioTotal";
            lbPrecioTotal.Size = new System.Drawing.Size(90, 27);
            lbPrecioTotal.TabIndex = 10;
            lbPrecioTotal.Text = "$00000";
            // 
            // labelTo
            // 
            labelTo.AutoSize = true;
            labelTo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelTo.ForeColor = System.Drawing.Color.White;
            labelTo.Location = new System.Drawing.Point(6, 241);
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
            lbTimer.Location = new System.Drawing.Point(63, 11);
            lbTimer.Name = "lbTimer";
            lbTimer.Size = new System.Drawing.Size(174, 47);
            lbTimer.TabIndex = 9;
            lbTimer.Text = "00:00:00";
            // 
            // tbProd
            // 
            tbProd.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tbProd.Location = new System.Drawing.Point(6, 135);
            tbProd.Name = "tbProd";
            tbProd.ReadOnly = true;
            tbProd.Size = new System.Drawing.Size(216, 30);
            tbProd.TabIndex = 7;
            // 
            // lbProd
            // 
            lbProd.AutoSize = true;
            lbProd.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lbProd.ForeColor = System.Drawing.Color.White;
            lbProd.Location = new System.Drawing.Point(3, 105);
            lbProd.Name = "lbProd";
            lbProd.Size = new System.Drawing.Size(199, 27);
            lbProd.TabIndex = 6;
            lbProd.Text = "Buscar Producto:";
            // 
            // lbCodFactura
            // 
            lbCodFactura.AutoSize = true;
            lbCodFactura.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lbCodFactura.ForeColor = System.Drawing.Color.White;
            lbCodFactura.Location = new System.Drawing.Point(6, 205);
            lbCodFactura.Name = "lbCodFactura";
            lbCodFactura.Size = new System.Drawing.Size(142, 27);
            lbCodFactura.TabIndex = 5;
            lbCodFactura.Text = "0000000000";
            // 
            // lbNoFactura
            // 
            lbNoFactura.AutoSize = true;
            lbNoFactura.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lbNoFactura.ForeColor = System.Drawing.Color.White;
            lbNoFactura.Location = new System.Drawing.Point(6, 178);
            lbNoFactura.Name = "lbNoFactura";
            lbNoFactura.Size = new System.Drawing.Size(140, 27);
            lbNoFactura.TabIndex = 4;
            lbNoFactura.Text = "No Factura:";
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
            // panel2
            // 
            panel2.Controls.Add(dgvCarrito);
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
            dgvCarrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1, id, nombre, precioventa, cantidad, total, colAdd, colReduce, delete });
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
            dgvCarrito.Location = new System.Drawing.Point(0, 0);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.RowHeadersWidth = 51;
            dgvCarrito.Size = new System.Drawing.Size(838, 611);
            dgvCarrito.TabIndex = 1;
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
            // colAdd
            // 
            colAdd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            colAdd.HeaderText = "";
            colAdd.Image = (System.Drawing.Image)resources.GetObject("colAdd.Image");
            colAdd.MinimumWidth = 6;
            colAdd.Name = "colAdd";
            colAdd.Width = 6;
            // 
            // colReduce
            // 
            colReduce.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            colReduce.HeaderText = "";
            colReduce.Image = (System.Drawing.Image)resources.GetObject("colReduce.Image");
            colReduce.MinimumWidth = 6;
            colReduce.Name = "colReduce";
            colReduce.Width = 6;
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
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.Label lbCodFactura;
        private System.Windows.Forms.Label lbNoFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioventa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewImageColumn colAdd;
        private System.Windows.Forms.DataGridViewImageColumn colReduce;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.TextBox tbProd;
        private System.Windows.Forms.Label lbProd;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lbPrecioTotal;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBuscar;
    }
}