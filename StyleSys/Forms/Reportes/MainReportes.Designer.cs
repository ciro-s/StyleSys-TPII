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
            panel1 = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            tabReportes = new System.Windows.Forms.TabControl();
            topVentas = new System.Windows.Forms.TabPage();
            dgvRanking = new System.Windows.Forms.DataGridView();
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nombre_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            acumulado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panelForm = new System.Windows.Forms.Panel();
            dtpHasta = new System.Windows.Forms.DateTimePicker();
            label3 = new System.Windows.Forms.Label();
            dtpDesde = new System.Windows.Forms.DateTimePicker();
            label2 = new System.Windows.Forms.Label();
            ventasDiarias = new System.Windows.Forms.TabPage();
            dgvVentasDiarias = new System.Windows.Forms.DataGridView();
            dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cod_factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cf_montototal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cl_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            fp_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            us_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            detalles = new System.Windows.Forms.DataGridViewImageColumn();
            panel2 = new System.Windows.Forms.Panel();
            dtpVentasDiarias = new System.Windows.Forms.DateTimePicker();
            label5 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabReportes.SuspendLayout();
            topVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRanking).BeginInit();
            panelForm.SuspendLayout();
            ventasDiarias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentasDiarias).BeginInit();
            panel2.SuspendLayout();
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
            label1.Location = new System.Drawing.Point(88, 33);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(132, 34);
            label1.TabIndex = 2;
            label1.Text = "Reportes";
            // 
            // tabReportes
            // 
            tabReportes.Controls.Add(topVentas);
            tabReportes.Controls.Add(ventasDiarias);
            tabReportes.Dock = System.Windows.Forms.DockStyle.Fill;
            tabReportes.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tabReportes.Location = new System.Drawing.Point(0, 0);
            tabReportes.Name = "tabReportes";
            tabReportes.SelectedIndex = 0;
            tabReportes.Size = new System.Drawing.Size(982, 353);
            tabReportes.TabIndex = 2;
            // 
            // topVentas
            // 
            topVentas.Controls.Add(dgvRanking);
            topVentas.Controls.Add(panelForm);
            topVentas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            topVentas.Location = new System.Drawing.Point(4, 29);
            topVentas.Name = "topVentas";
            topVentas.Padding = new System.Windows.Forms.Padding(3);
            topVentas.Size = new System.Drawing.Size(974, 320);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvRanking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRanking.ColumnHeadersHeight = 30;
            dgvRanking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRanking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1, nombre_producto, cantidad, acumulado, stock });
            dgvRanking.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvRanking.EnableHeadersVisualStyles = false;
            dgvRanking.Location = new System.Drawing.Point(3, 65);
            dgvRanking.Name = "dgvRanking";
            dgvRanking.RowHeadersWidth = 51;
            dgvRanking.Size = new System.Drawing.Size(968, 252);
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
            panelForm.Controls.Add(dtpHasta);
            panelForm.Controls.Add(label3);
            panelForm.Controls.Add(dtpDesde);
            panelForm.Controls.Add(label2);
            panelForm.Dock = System.Windows.Forms.DockStyle.Top;
            panelForm.Location = new System.Drawing.Point(3, 3);
            panelForm.Name = "panelForm";
            panelForm.Size = new System.Drawing.Size(968, 62);
            panelForm.TabIndex = 0;
            // 
            // dtpHasta
            // 
            dtpHasta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpHasta.Location = new System.Drawing.Point(680, 16);
            dtpHasta.MaxDate = new System.DateTime(2024, 9, 27, 0, 0, 0, 0);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new System.Drawing.Size(124, 27);
            dtpHasta.TabIndex = 3;
            dtpHasta.Value = new System.DateTime(2024, 9, 27, 0, 0, 0, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(548, 18);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(118, 22);
            label3.TabIndex = 2;
            label3.Text = "Datos hasta:";
            // 
            // dtpDesde
            // 
            dtpDesde.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpDesde.Location = new System.Drawing.Point(270, 16);
            dtpDesde.MaxDate = new System.DateTime(2024, 9, 27, 0, 0, 0, 0);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new System.Drawing.Size(124, 27);
            dtpDesde.TabIndex = 1;
            dtpDesde.Value = new System.DateTime(2024, 9, 27, 0, 0, 0, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(138, 18);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(126, 22);
            label2.TabIndex = 0;
            label2.Text = "Datos desde:";
            // 
            // ventasDiarias
            // 
            ventasDiarias.Controls.Add(dgvVentasDiarias);
            ventasDiarias.Controls.Add(panel2);
            ventasDiarias.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            ventasDiarias.Location = new System.Drawing.Point(4, 34);
            ventasDiarias.Name = "ventasDiarias";
            ventasDiarias.Padding = new System.Windows.Forms.Padding(3);
            ventasDiarias.Size = new System.Drawing.Size(974, 315);
            ventasDiarias.TabIndex = 1;
            ventasDiarias.Text = "Ventas Diarias";
            ventasDiarias.UseVisualStyleBackColor = true;
            // 
            // dgvVentasDiarias
            // 
            dgvVentasDiarias.AllowUserToAddRows = false;
            dgvVentasDiarias.BackgroundColor = System.Drawing.Color.White;
            dgvVentasDiarias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvVentasDiarias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvVentasDiarias.ColumnHeadersHeight = 30;
            dgvVentasDiarias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvVentasDiarias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dataGridViewTextBoxColumn1, cod_factura, cf_montototal, cl_nombre, fp_nombre, us_nombre, detalles });
            dgvVentasDiarias.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvVentasDiarias.EnableHeadersVisualStyles = false;
            dgvVentasDiarias.Location = new System.Drawing.Point(3, 65);
            dgvVentasDiarias.Name = "dgvVentasDiarias";
            dgvVentasDiarias.RowHeadersWidth = 51;
            dgvVentasDiarias.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dgvVentasDiarias.Size = new System.Drawing.Size(968, 247);
            dgvVentasDiarias.TabIndex = 2;
            dgvVentasDiarias.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn1.HeaderText = "No";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 56;
            // 
            // cod_factura
            // 
            cod_factura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            cod_factura.HeaderText = "Código";
            cod_factura.MinimumWidth = 6;
            cod_factura.Name = "cod_factura";
            cod_factura.Width = 85;
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
            panel2.Controls.Add(dtpVentasDiarias);
            panel2.Controls.Add(label5);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(968, 62);
            panel2.TabIndex = 1;
            // 
            // dtpVentasDiarias
            // 
            dtpVentasDiarias.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dtpVentasDiarias.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpVentasDiarias.Location = new System.Drawing.Point(492, 17);
            dtpVentasDiarias.MaxDate = new System.DateTime(2024, 9, 27, 0, 0, 0, 0);
            dtpVentasDiarias.Name = "dtpVentasDiarias";
            dtpVentasDiarias.Size = new System.Drawing.Size(124, 27);
            dtpVentasDiarias.TabIndex = 1;
            dtpVentasDiarias.Value = new System.DateTime(2024, 9, 27, 0, 0, 0, 0);
            dtpVentasDiarias.ValueChanged += dtpVentasDiarias_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(317, 20);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(169, 22);
            label5.TabIndex = 0;
            label5.Text = "Seleccione el día:";
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
            topVentas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRanking).EndInit();
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            ventasDiarias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVentasDiarias).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabReportes;
        private System.Windows.Forms.TabPage topVentas;
        private System.Windows.Forms.TabPage ventasDiarias;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DataGridView dgvRanking;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn acumulado;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpVentasDiarias;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvVentasDiarias;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn cf_montototal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn fp_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn us_nombre;
        private System.Windows.Forms.DataGridViewImageColumn detalles;
    }
}