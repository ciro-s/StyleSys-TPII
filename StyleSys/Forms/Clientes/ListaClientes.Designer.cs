namespace StyleSys.Forms.Clientes
{
    partial class ListaClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaClientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            panel1 = new System.Windows.Forms.Panel();
            checkEliminadosCL = new System.Windows.Forms.CheckBox();
            btnCAgregar = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            dgvClientes = new System.Windows.Forms.DataGridView();
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nombre_completo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            us_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            us_telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            alta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            editar = new System.Windows.Forms.DataGridViewImageColumn();
            Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            restaurar = new System.Windows.Forms.DataGridViewImageColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.DodgerBlue;
            panel1.Controls.Add(checkEliminadosCL);
            panel1.Controls.Add(btnCAgregar);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 353);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(982, 100);
            panel1.TabIndex = 7;
            // 
            // checkEliminadosCL
            // 
            checkEliminadosCL.AutoSize = true;
            checkEliminadosCL.Location = new System.Drawing.Point(514, 38);
            checkEliminadosCL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            checkEliminadosCL.Name = "checkEliminadosCL";
            checkEliminadosCL.Size = new System.Drawing.Size(159, 24);
            checkEliminadosCL.TabIndex = 5;
            checkEliminadosCL.Text = "Mostrar Eliminados";
            checkEliminadosCL.UseVisualStyleBackColor = true;
            checkEliminadosCL.CheckedChanged += checkEliminados_CheckedChanged;
            // 
            // btnCAgregar
            // 
            btnCAgregar.BackColor = System.Drawing.Color.Transparent;
            btnCAgregar.FlatAppearance.BorderSize = 0;
            btnCAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            btnCAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            btnCAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCAgregar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnCAgregar.Image = (System.Drawing.Image)resources.GetObject("btnCAgregar.Image");
            btnCAgregar.Location = new System.Drawing.Point(803, 24);
            btnCAgregar.Name = "btnCAgregar";
            btnCAgregar.Size = new System.Drawing.Size(123, 53);
            btnCAgregar.TabIndex = 4;
            btnCAgregar.Text = "Agregar";
            btnCAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnCAgregar.UseVisualStyleBackColor = false;
            btnCAgregar.Click += btnCAgregar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(11, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(70, 69);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(87, 33);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(263, 34);
            label1.TabIndex = 2;
            label1.Text = "Gestionar Clientes";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvClientes);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(982, 453);
            panel2.TabIndex = 8;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.BackgroundColor = System.Drawing.Color.White;
            dgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvClientes.ColumnHeadersHeight = 30;
            dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1, id, dni, nombre_completo, us_email, us_telefono, alta, estado, editar, Eliminar, restaurar });
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvClientes.DefaultCellStyle = dataGridViewCellStyle2;
            dgvClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvClientes.EnableHeadersVisualStyles = false;
            dgvClientes.Location = new System.Drawing.Point(0, 0);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new System.Drawing.Size(982, 453);
            dgvClientes.TabIndex = 2;
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
            id.Visible = false;
            id.Width = 54;
            // 
            // dni
            // 
            dni.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dni.HeaderText = "DNI";
            dni.MinimumWidth = 6;
            dni.Name = "dni";
            // 
            // nombre_completo
            // 
            nombre_completo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            nombre_completo.HeaderText = "Nombre";
            nombre_completo.MinimumWidth = 6;
            nombre_completo.Name = "nombre_completo";
            // 
            // us_email
            // 
            us_email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            us_email.HeaderText = "e-Mail";
            us_email.MinimumWidth = 6;
            us_email.Name = "us_email";
            // 
            // us_telefono
            // 
            us_telefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            us_telefono.HeaderText = "Telefono";
            us_telefono.MinimumWidth = 6;
            us_telefono.Name = "us_telefono";
            // 
            // alta
            // 
            alta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            alta.HeaderText = "Alta";
            alta.MinimumWidth = 6;
            alta.Name = "alta";
            // 
            // estado
            // 
            estado.HeaderText = "Estado";
            estado.MinimumWidth = 6;
            estado.Name = "estado";
            estado.ReadOnly = true;
            estado.Visible = false;
            estado.Width = 125;
            // 
            // editar
            // 
            editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            editar.HeaderText = "";
            editar.Image = (System.Drawing.Image)resources.GetObject("editar.Image");
            editar.MinimumWidth = 6;
            editar.Name = "editar";
            editar.Width = 6;
            // 
            // Eliminar
            // 
            Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            Eliminar.HeaderText = "";
            Eliminar.Image = (System.Drawing.Image)resources.GetObject("Eliminar.Image");
            Eliminar.MinimumWidth = 6;
            Eliminar.Name = "Eliminar";
            Eliminar.Width = 6;
            // 
            // restaurar
            // 
            restaurar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            restaurar.HeaderText = "";
            restaurar.Image = (System.Drawing.Image)resources.GetObject("restaurar.Image");
            restaurar.MinimumWidth = 6;
            restaurar.Name = "restaurar";
            restaurar.Visible = false;
            restaurar.Width = 6;
            // 
            // ListaClientes
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(982, 453);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "ListaClientes";
            Text = "Clientes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCAgregar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkEliminadosCL;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_completo;
        private System.Windows.Forms.DataGridViewTextBoxColumn us_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn us_telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn alta;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewImageColumn editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewImageColumn restaurar;
    }
}