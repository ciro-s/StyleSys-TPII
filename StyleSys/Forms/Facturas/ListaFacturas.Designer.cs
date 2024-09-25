namespace StyleSys.Forms.Facturas
{
    partial class ListaFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaFacturas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            panel1 = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            dgvFacturas = new System.Windows.Forms.DataGridView();
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cod_factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cf_montototal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cl_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            fp_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            us_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cf_fechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            detalles = new System.Windows.Forms.DataGridViewImageColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFacturas).BeginInit();
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
            panel1.TabIndex = 3;
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
            label1.Location = new System.Drawing.Point(85, 37);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(183, 34);
            label1.TabIndex = 2;
            label1.Text = "Ver Facturas";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvFacturas);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(982, 453);
            panel2.TabIndex = 4;
            // 
            // dgvFacturas
            // 
            dgvFacturas.AllowUserToAddRows = false;
            dgvFacturas.BackgroundColor = System.Drawing.Color.White;
            dgvFacturas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvFacturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvFacturas.ColumnHeadersHeight = 30;
            dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1, cod_factura, cf_montototal, cl_nombre, fp_nombre, us_nombre, cf_fechaRegistro, detalles });
            dgvFacturas.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvFacturas.EnableHeadersVisualStyles = false;
            dgvFacturas.Location = new System.Drawing.Point(0, 0);
            dgvFacturas.Name = "dgvFacturas";
            dgvFacturas.RowHeadersWidth = 51;
            dgvFacturas.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dgvFacturas.Size = new System.Drawing.Size(982, 453);
            dgvFacturas.TabIndex = 1;
            dgvFacturas.CellContentClick += dgvFacturas_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "No";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 62;
            // 
            // cod_factura
            // 
            cod_factura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            cod_factura.HeaderText = "Código";
            cod_factura.MinimumWidth = 6;
            cod_factura.Name = "cod_factura";
            cod_factura.Width = 103;
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
            // ListaFacturas
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(982, 453);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "ListaFacturas";
            Text = "Facturas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFacturas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvFacturas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn cf_montototal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn fp_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn us_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cf_fechaRegistro;
        private System.Windows.Forms.DataGridViewImageColumn detalles;
    }
}