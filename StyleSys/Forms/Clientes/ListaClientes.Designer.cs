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
            id_cl = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            panel1.Location = new System.Drawing.Point(0, 375);
            panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(800, 75);
            panel1.TabIndex = 7;
            // 
            // checkEliminadosCL
            // 
            checkEliminadosCL.AutoSize = true;
            checkEliminadosCL.Location = new System.Drawing.Point(451, 33);
            checkEliminadosCL.Name = "checkEliminadosCL";
            checkEliminadosCL.Size = new System.Drawing.Size(128, 19);
            checkEliminadosCL.TabIndex = 5;
            checkEliminadosCL.Text = "Mostrar Eliminados";
            checkEliminadosCL.UseVisualStyleBackColor = true;
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
            btnCAgregar.Location = new System.Drawing.Point(692, 23);
            btnCAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnCAgregar.Name = "btnCAgregar";
            btnCAgregar.Size = new System.Drawing.Size(108, 40);
            btnCAgregar.TabIndex = 4;
            btnCAgregar.Text = "Agregar";
            btnCAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnCAgregar.UseVisualStyleBackColor = false;
            btnCAgregar.Click += btnCAgregar_Click;
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
            panel2.Controls.Add(dgvClientes);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(800, 450);
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
            dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1, id_cl, cl_nombre, cl_apellido, cl_email, cl_fechaNacimiento, cl_telefono, cl_DNI, cl_estado, cl_fechaAlta, editar, Eliminar });
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
            dgvClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new System.Drawing.Size(800, 450);
            dgvClientes.TabIndex = 1;
            dgvClientes.CellContentClick += dgvClientes_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "No";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 52;
            // 
            // id_cl
            // 
            id_cl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            id_cl.HeaderText = "Id";
            id_cl.MinimumWidth = 6;
            id_cl.Name = "id_cl";
            id_cl.Visible = false;
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
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCAgregar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cl;
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
        private System.Windows.Forms.CheckBox checkEliminadosCL;
    }
}