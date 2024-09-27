namespace StyleSys.Forms.Facturas
{
    partial class DetalleFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalleFactura));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            panel1 = new System.Windows.Forms.Panel();
            btnClose = new System.Windows.Forms.Button();
            lbFactura = new System.Windows.Forms.Label();
            dgvDetalles = new System.Windows.Forms.DataGridView();
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cod_detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            preciounitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            precioparcial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panel2 = new System.Windows.Forms.Panel();
            lbTotal = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.DodgerBlue;
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(lbFactura);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(764, 70);
            panel1.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Image = (System.Drawing.Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new System.Drawing.Point(697, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(55, 55);
            btnClose.TabIndex = 16;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lbFactura
            // 
            lbFactura.AutoSize = true;
            lbFactura.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lbFactura.ForeColor = System.Drawing.Color.White;
            lbFactura.Location = new System.Drawing.Point(12, 19);
            lbFactura.Name = "lbFactura";
            lbFactura.Size = new System.Drawing.Size(243, 34);
            lbFactura.TabIndex = 1;
            lbFactura.Text = "Detalles factura: ";
            // 
            // dgvDetalles
            // 
            dgvDetalles.AllowUserToAddRows = false;
            dgvDetalles.BackgroundColor = System.Drawing.Color.White;
            dgvDetalles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvDetalles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDetalles.ColumnHeadersHeight = 30;
            dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1, cod_detalle, id_producto, producto, cantidad, preciounitario, precioparcial });
            dgvDetalles.Dock = System.Windows.Forms.DockStyle.Top;
            dgvDetalles.EnableHeadersVisualStyles = false;
            dgvDetalles.Location = new System.Drawing.Point(0, 70);
            dgvDetalles.Name = "dgvDetalles";
            dgvDetalles.RowHeadersWidth = 51;
            dgvDetalles.Size = new System.Drawing.Size(764, 463);
            dgvDetalles.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "No";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 62;
            // 
            // cod_detalle
            // 
            cod_detalle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            cod_detalle.HeaderText = "Código";
            cod_detalle.MinimumWidth = 6;
            cod_detalle.Name = "cod_detalle";
            cod_detalle.Visible = false;
            cod_detalle.Width = 125;
            // 
            // id_producto
            // 
            id_producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            id_producto.HeaderText = "cod prod";
            id_producto.MinimumWidth = 6;
            id_producto.Name = "id_producto";
            id_producto.Visible = false;
            // 
            // producto
            // 
            producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            producto.HeaderText = "Producto";
            producto.MinimumWidth = 6;
            producto.Name = "producto";
            // 
            // cantidad
            // 
            cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            cantidad.HeaderText = "Cantidad";
            cantidad.MinimumWidth = 6;
            cantidad.Name = "cantidad";
            // 
            // preciounitario
            // 
            preciounitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            preciounitario.HeaderText = "$ unitario";
            preciounitario.MinimumWidth = 6;
            preciounitario.Name = "preciounitario";
            // 
            // precioparcial
            // 
            precioparcial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            precioparcial.HeaderText = "$ parcial";
            precioparcial.MinimumWidth = 6;
            precioparcial.Name = "precioparcial";
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.DodgerBlue;
            panel2.Controls.Add(lbTotal);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(0, 533);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(764, 70);
            panel2.TabIndex = 3;
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lbTotal.ForeColor = System.Drawing.Color.White;
            lbTotal.Location = new System.Drawing.Point(469, 14);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new System.Drawing.Size(110, 34);
            lbTotal.TabIndex = 1;
            lbTotal.Text = "Total: $";
            lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DetalleFactura
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(764, 600);
            Controls.Add(panel2);
            Controls.Add(dgvDetalles);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "DetalleFactura";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "DetalleFactura";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciounitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioparcial;
        public System.Windows.Forms.Label lbFactura;
    }
}