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
            btnAgregar = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            dgvUsuarios = new System.Windows.Forms.DataGridView();
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cl_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cl_apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cl_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cl_fechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cl_telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cl_DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cl_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cl_fechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            editar = new System.Windows.Forms.DataGridViewImageColumn();
            Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.DodgerBlue;
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 375);
            panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(800, 75);
            panel1.TabIndex = 7;
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
            btnAgregar.Location = new System.Drawing.Point(692, 23);
            btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new System.Drawing.Size(108, 40);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(10, 11);
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
            label1.Location = new System.Drawing.Point(77, 26);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(206, 26);
            label1.TabIndex = 2;
            label1.Text = "Gestionar Clientes";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvUsuarios);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(800, 450);
            panel2.TabIndex = 8;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.BackgroundColor = System.Drawing.Color.White;
            dgvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsuarios.ColumnHeadersHeight = 30;
            dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1, id, cl_nombre, cl_apellido, cl_email, cl_fechaNacimiento, cl_telefono, cl_DNI, cl_estado, cl_fechaAlta, editar, Eliminar });
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvUsuarios.EnableHeadersVisualStyles = false;
            dgvUsuarios.Location = new System.Drawing.Point(0, 0);
            dgvUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.Size = new System.Drawing.Size(800, 450);
            dgvUsuarios.TabIndex = 1;
            dgvUsuarios.CellContentClick += dgvClientes_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "No";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 52;
            // 
            // id
            // 
            id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            id.HeaderText = "Id";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Visible = false;
            id.Width = 45;
            // 
            // cl_nombre
            // 
            cl_nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            cl_nombre.HeaderText = "Nombre";
            cl_nombre.MinimumWidth = 6;
            cl_nombre.Name = "cl_nombre";
            // 
            // cl_apellido
            // 
            cl_apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            cl_apellido.HeaderText = "Apellido";
            cl_apellido.MinimumWidth = 6;
            cl_apellido.Name = "cl_apellido";
            // 
            // cl_email
            // 
            cl_email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            cl_email.HeaderText = "e-Mail";
            cl_email.MinimumWidth = 6;
            cl_email.Name = "cl_email";
            // 
            // cl_fechaNacimiento
            // 
            cl_fechaNacimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            cl_fechaNacimiento.HeaderText = "Nacimiento";
            cl_fechaNacimiento.MinimumWidth = 6;
            cl_fechaNacimiento.Name = "cl_fechaNacimiento";
            // 
            // cl_telefono
            // 
            cl_telefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            cl_telefono.HeaderText = "Telefono";
            cl_telefono.MinimumWidth = 6;
            cl_telefono.Name = "cl_telefono";
            // 
            // cl_DNI
            // 
            cl_DNI.HeaderText = "DNI";
            cl_DNI.Name = "cl_DNI";
            // 
            // cl_estado
            // 
            cl_estado.HeaderText = "Estado";
            cl_estado.Name = "cl_estado";
            // 
            // cl_fechaAlta
            // 
            cl_fechaAlta.HeaderText = "Fecha Alta";
            cl_fechaAlta.Name = "cl_fechaAlta";
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
            // ListaClientes
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "ListaClientes";
            Text = "Clientes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_fechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_fechaAlta;
        private System.Windows.Forms.DataGridViewImageColumn editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
    }
}