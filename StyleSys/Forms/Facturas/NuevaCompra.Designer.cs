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
            numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            label3 = new System.Windows.Forms.Label();
            btnAgregar = new System.Windows.Forms.Button();
            btnBuscarProd = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            btnBuscarProv = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            tbProd = new System.Windows.Forms.TextBox();
            lbProd = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.White;
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(btnBuscarProd);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnBuscarProv);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(tbProd);
            panel1.Controls.Add(lbProd);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(931, 243);
            panel1.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            numericUpDown1.Location = new System.Drawing.Point(511, 195);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new System.Drawing.Size(74, 28);
            numericUpDown1.TabIndex = 21;
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
            // textBox1
            // 
            textBox1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            textBox1.Location = new System.Drawing.Point(289, 149);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new System.Drawing.Size(298, 30);
            textBox1.TabIndex = 17;
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
            // tbProd
            // 
            tbProd.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tbProd.Location = new System.Drawing.Point(289, 95);
            tbProd.Name = "tbProd";
            tbProd.ReadOnly = true;
            tbProd.Size = new System.Drawing.Size(298, 30);
            tbProd.TabIndex = 14;
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
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel3.Location = new System.Drawing.Point(0, 560);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(931, 78);
            panel3.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.Gainsboro;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            button2.ForeColor = System.Drawing.Color.Black;
            button2.Image = (System.Drawing.Image)resources.GetObject("button2.Image");
            button2.Location = new System.Drawing.Point(718, 13);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(173, 53);
            button2.TabIndex = 21;
            button2.Text = "Registrar";
            button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
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
            dgvCarrito.Location = new System.Drawing.Point(0, 243);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.RowHeadersWidth = 51;
            dgvCarrito.Size = new System.Drawing.Size(931, 317);
            dgvCarrito.TabIndex = 3;
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
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarProv;
        private System.Windows.Forms.TextBox tbProd;
        private System.Windows.Forms.Label lbProd;
        private System.Windows.Forms.Button btnBuscarProd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioventa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewImageColumn colAdd;
        private System.Windows.Forms.DataGridViewImageColumn colReduce;
        private System.Windows.Forms.DataGridViewImageColumn delete;
    }
}