namespace StyleSys.Forms.Facturas
{
    partial class Compras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compras));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            panel1 = new System.Windows.Forms.Panel();
            tbBuscarCompra = new System.Windows.Forms.TextBox();
            btnAgregar = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            dgvCompras = new System.Windows.Forms.DataGridView();
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cod_factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            montototal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cf_fechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            detalles = new System.Windows.Forms.DataGridViewImageColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCompras).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.DodgerBlue;
            panel1.Controls.Add(tbBuscarCompra);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 265);
            panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(859, 75);
            panel1.TabIndex = 5;
            // 
            // tbBuscarCompra
            // 
            tbBuscarCompra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tbBuscarCompra.Location = new System.Drawing.Point(282, 25);
            tbBuscarCompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tbBuscarCompra.Name = "tbBuscarCompra";
            tbBuscarCompra.PlaceholderText = "Busca una compra...";
            tbBuscarCompra.Size = new System.Drawing.Size(357, 27);
            tbBuscarCompra.TabIndex = 6;
            tbBuscarCompra.TextChanged += tbBuscarCompra_TextChanged;
            tbBuscarCompra.KeyPress += numero_KeyPress;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = System.Drawing.Color.Transparent;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAgregar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnAgregar.Image = (System.Drawing.Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.Location = new System.Drawing.Point(738, 17);
            btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new System.Drawing.Size(108, 40);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(7, 10);
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
            label1.Location = new System.Drawing.Point(71, 24);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(111, 26);
            label1.TabIndex = 2;
            label1.Text = "Compras";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvCompras);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(859, 340);
            panel2.TabIndex = 6;
            // 
            // dgvCompras
            // 
            dgvCompras.AllowUserToAddRows = false;
            dgvCompras.BackgroundColor = System.Drawing.Color.White;
            dgvCompras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvCompras.ColumnHeadersHeight = 30;
            dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1, cod_factura, montototal, usuario, cf_fechaRegistro, detalles });
            dgvCompras.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvCompras.EnableHeadersVisualStyles = false;
            dgvCompras.Location = new System.Drawing.Point(0, 0);
            dgvCompras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dgvCompras.Name = "dgvCompras";
            dgvCompras.RowHeadersWidth = 51;
            dgvCompras.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dgvCompras.Size = new System.Drawing.Size(859, 340);
            dgvCompras.TabIndex = 1;
            dgvCompras.CellContentClick += dgvCompras_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "No";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 52;
            // 
            // cod_factura
            // 
            cod_factura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            cod_factura.HeaderText = "Código";
            cod_factura.MinimumWidth = 6;
            cod_factura.Name = "cod_factura";
            cod_factura.Width = 87;
            // 
            // montototal
            // 
            montototal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            montototal.HeaderText = "Monto Total";
            montototal.MinimumWidth = 6;
            montototal.Name = "montototal";
            // 
            // usuario
            // 
            usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            usuario.HeaderText = "Usuario";
            usuario.MinimumWidth = 6;
            usuario.Name = "usuario";
            // 
            // cf_fechaRegistro
            // 
            cf_fechaRegistro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            cf_fechaRegistro.HeaderText = "Fecha";
            cf_fechaRegistro.MinimumWidth = 6;
            cf_fechaRegistro.Name = "cf_fechaRegistro";
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
            // Compras
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(859, 340);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "Compras";
            Text = "Compras";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCompras).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox tbBuscarCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn montototal;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cf_fechaRegistro;
        private System.Windows.Forms.DataGridViewImageColumn detalles;
    }
}