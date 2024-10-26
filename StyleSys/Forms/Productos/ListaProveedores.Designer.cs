namespace StyleSys.Forms.Productos
{
    partial class ListaProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaProveedores));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            panel1 = new System.Windows.Forms.Panel();
            checkEliminados = new System.Windows.Forms.CheckBox();
            btnAgregar = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            dgvProveedores = new System.Windows.Forms.DataGridView();
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            razonsocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            editar = new System.Windows.Forms.DataGridViewImageColumn();
            Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            restaurar = new System.Windows.Forms.DataGridViewImageColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.DodgerBlue;
            panel1.Controls.Add(checkEliminados);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 353);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(982, 100);
            panel1.TabIndex = 3;
            // 
            // checkEliminados
            // 
            checkEliminados.AutoSize = true;
            checkEliminados.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            checkEliminados.Location = new System.Drawing.Point(614, 43);
            checkEliminados.Name = "checkEliminados";
            checkEliminados.Size = new System.Drawing.Size(186, 25);
            checkEliminados.TabIndex = 6;
            checkEliminados.Text = "Mostrar Eliminados";
            checkEliminados.UseVisualStyleBackColor = true;
            checkEliminados.CheckedChanged += checkEliminados_CheckedChanged;
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
            btnAgregar.Location = new System.Drawing.Point(834, 28);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new System.Drawing.Size(123, 53);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
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
            label1.Size = new System.Drawing.Size(324, 34);
            label1.TabIndex = 2;
            label1.Text = "Gestionar Proveedores";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvProveedores);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(982, 453);
            panel2.TabIndex = 4;
            // 
            // dgvProveedores
            // 
            dgvProveedores.AllowUserToAddRows = false;
            dgvProveedores.BackgroundColor = System.Drawing.Color.White;
            dgvProveedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProveedores.ColumnHeadersHeight = 30;
            dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1, id, nombre, cuit, razonsocial, telefono, direccion, estado, editar, Eliminar, restaurar });
            dgvProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvProveedores.EnableHeadersVisualStyles = false;
            dgvProveedores.Location = new System.Drawing.Point(0, 0);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.RowHeadersWidth = 51;
            dgvProveedores.Size = new System.Drawing.Size(982, 453);
            dgvProveedores.TabIndex = 1;
            dgvProveedores.CellContentClick += dgvProveedores_CellContentClick;
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
            id.Width = 125;
            // 
            // nombre
            // 
            nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            // 
            // cuit
            // 
            cuit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            cuit.HeaderText = "CUIT";
            cuit.MinimumWidth = 6;
            cuit.Name = "cuit";
            // 
            // razonsocial
            // 
            razonsocial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            razonsocial.HeaderText = "Razon Social";
            razonsocial.MinimumWidth = 6;
            razonsocial.Name = "razonsocial";
            // 
            // telefono
            // 
            telefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            telefono.HeaderText = "Telefono";
            telefono.MinimumWidth = 6;
            telefono.Name = "telefono";
            // 
            // direccion
            // 
            direccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            direccion.HeaderText = "Direccion";
            direccion.MinimumWidth = 6;
            direccion.Name = "direccion";
            // 
            // estado
            // 
            estado.HeaderText = "Estado";
            estado.MinimumWidth = 6;
            estado.Name = "estado";
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
            restaurar.Width = 125;
            // 
            // ListaProveedores
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(982, 453);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "ListaProveedores";
            Text = "Proveedores";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.CheckBox checkEliminados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonsocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewImageColumn editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewImageColumn restaurar;
    }
}