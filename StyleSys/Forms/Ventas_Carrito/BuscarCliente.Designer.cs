namespace StyleSys.Forms.Ventas_Carrito
{
    partial class BuscarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarCliente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            tbBuscarCliente = new System.Windows.Forms.TextBox();
            btnCancelar = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            btnNuevoCliente = new System.Windows.Forms.Button();
            dgvClientes = new System.Windows.Forms.DataGridView();
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            alta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            select = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // tbBuscarCliente
            // 
            tbBuscarCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tbBuscarCliente.Location = new System.Drawing.Point(279, 35);
            tbBuscarCliente.Name = "tbBuscarCliente";
            tbBuscarCliente.PlaceholderText = "Busca un producto...";
            tbBuscarCliente.Size = new System.Drawing.Size(407, 32);
            tbBuscarCliente.TabIndex = 5;
            tbBuscarCliente.TextChanged += tbBuscarProd_TextChanged;
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
            btnCancelar.Location = new System.Drawing.Point(868, 24);
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
            label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(88, 35);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(173, 27);
            label1.TabIndex = 2;
            label1.Text = "Buscar Cliente";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.DodgerBlue;
            panel1.Controls.Add(btnNuevoCliente);
            panel1.Controls.Add(tbBuscarCliente);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 400);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1000, 100);
            panel1.TabIndex = 4;
            // 
            // btnNuevoCliente
            // 
            btnNuevoCliente.BackColor = System.Drawing.Color.Transparent;
            btnNuevoCliente.FlatAppearance.BorderSize = 0;
            btnNuevoCliente.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            btnNuevoCliente.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            btnNuevoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNuevoCliente.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnNuevoCliente.Image = (System.Drawing.Image)resources.GetObject("btnNuevoCliente.Image");
            btnNuevoCliente.Location = new System.Drawing.Point(692, 24);
            btnNuevoCliente.Name = "btnNuevoCliente";
            btnNuevoCliente.Size = new System.Drawing.Size(170, 53);
            btnNuevoCliente.TabIndex = 6;
            btnNuevoCliente.Text = "Nuevo Cliente";
            btnNuevoCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnNuevoCliente.UseVisualStyleBackColor = false;
            btnNuevoCliente.Click += btnNuevoCliente_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.BackgroundColor = System.Drawing.Color.White;
            dgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvClientes.ColumnHeadersHeight = 30;
            dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1, id, dni, nombre, mail, alta, select });
            dgvClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvClientes.EnableHeadersVisualStyles = false;
            dgvClientes.Location = new System.Drawing.Point(0, 0);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new System.Drawing.Size(1000, 400);
            dgvClientes.TabIndex = 5;
            dgvClientes.CellContentClick += dgvClientes_CellContentClick;
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
            // dni
            // 
            dni.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dni.DefaultCellStyle = dataGridViewCellStyle6;
            dni.HeaderText = "DNI";
            dni.MinimumWidth = 6;
            dni.Name = "dni";
            // 
            // nombre
            // 
            nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            // 
            // mail
            // 
            mail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            mail.HeaderText = "Email";
            mail.MinimumWidth = 6;
            mail.Name = "mail";
            // 
            // alta
            // 
            alta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            alta.HeaderText = "Fecha Alta";
            alta.MinimumWidth = 6;
            alta.Name = "alta";
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
            // BuscarCliente
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1000, 500);
            Controls.Add(dgvClientes);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "BuscarCliente";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "BuscarCliente";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TextBox tbBuscarCliente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn alta;
        private System.Windows.Forms.DataGridViewImageColumn select;
        private System.Windows.Forms.Button btnNuevoCliente;
    }
}