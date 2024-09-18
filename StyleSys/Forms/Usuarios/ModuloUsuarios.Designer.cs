namespace StyleSys.Forms.Usuarios
{
    partial class ModuloUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModuloUsuarios));
            cbRol = new System.Windows.Forms.ComboBox();
            btnActualizar = new System.Windows.Forms.Button();
            lbId = new System.Windows.Forms.Label();
            btnCancelar = new System.Windows.Forms.Button();
            btnGuardar = new System.Windows.Forms.Button();
            tbClave = new System.Windows.Forms.TextBox();
            tbNick = new System.Windows.Forms.TextBox();
            tbApellido = new System.Windows.Forms.TextBox();
            tbNombre = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            btnClose = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            tbTelefono = new System.Windows.Forms.TextBox();
            tbMail = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            dateTimePicker = new System.Windows.Forms.DateTimePicker();
            tbDni = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            tbDireccion = new System.Windows.Forms.TextBox();
            label11 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cbRol
            // 
            cbRol.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cbRol.FormattingEnabled = true;
            cbRol.Location = new System.Drawing.Point(461, 402);
            cbRol.Name = "cbRol";
            cbRol.Size = new System.Drawing.Size(250, 27);
            cbRol.TabIndex = 36;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = System.Drawing.Color.DodgerBlue;
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnActualizar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            btnActualizar.ForeColor = System.Drawing.Color.White;
            btnActualizar.Image = (System.Drawing.Image)resources.GetObject("btnActualizar.Image");
            btnActualizar.Location = new System.Drawing.Point(315, 454);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new System.Drawing.Size(128, 47);
            btnActualizar.TabIndex = 37;
            btnActualizar.Text = "Actualizar";
            btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new System.Drawing.Point(26, 467);
            lbId.Name = "lbId";
            lbId.Size = new System.Drawing.Size(22, 20);
            lbId.TabIndex = 33;
            lbId.Text = "Id";
            lbId.Visible = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = System.Drawing.Color.DodgerBlue;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            btnCancelar.ForeColor = System.Drawing.Color.White;
            btnCancelar.Image = (System.Drawing.Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.Location = new System.Drawing.Point(583, 454);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(128, 47);
            btnCancelar.TabIndex = 39;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = System.Drawing.Color.DodgerBlue;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            btnGuardar.ForeColor = System.Drawing.Color.White;
            btnGuardar.Image = (System.Drawing.Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.Location = new System.Drawing.Point(449, 454);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(128, 47);
            btnGuardar.TabIndex = 38;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // tbClave
            // 
            tbClave.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            tbClave.Location = new System.Drawing.Point(110, 224);
            tbClave.Name = "tbClave";
            tbClave.PasswordChar = '*';
            tbClave.Size = new System.Drawing.Size(601, 28);
            tbClave.TabIndex = 31;
            tbClave.UseSystemPasswordChar = true;
            // 
            // tbNick
            // 
            tbNick.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            tbNick.Location = new System.Drawing.Point(110, 178);
            tbNick.Name = "tbNick";
            tbNick.Size = new System.Drawing.Size(601, 28);
            tbNick.TabIndex = 30;
            // 
            // tbApellido
            // 
            tbApellido.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            tbApellido.Location = new System.Drawing.Point(461, 83);
            tbApellido.Name = "tbApellido";
            tbApellido.Size = new System.Drawing.Size(250, 28);
            tbApellido.TabIndex = 28;
            // 
            // tbNombre
            // 
            tbNombre.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            tbNombre.Location = new System.Drawing.Point(110, 83);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new System.Drawing.Size(250, 28);
            tbNombre.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label7.Location = new System.Drawing.Point(414, 406);
            label7.Margin = new System.Windows.Forms.Padding(20);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(34, 19);
            label7.TabIndex = 26;
            label7.Text = "Rol";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(2, 227);
            label5.Margin = new System.Windows.Forms.Padding(20);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(103, 19);
            label5.TabIndex = 24;
            label5.Text = "Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(14, 183);
            label4.Margin = new System.Windows.Forms.Padding(20);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(91, 19);
            label4.TabIndex = 23;
            label4.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(383, 88);
            label3.Margin = new System.Windows.Forms.Padding(20);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(78, 19);
            label3.TabIndex = 22;
            label3.Text = "Apellido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(29, 88);
            label2.Margin = new System.Windows.Forms.Padding(20);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(76, 19);
            label2.TabIndex = 21;
            label2.Text = "Nombre";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.DodgerBlue;
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(764, 70);
            panel1.TabIndex = 20;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Image = (System.Drawing.Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new System.Drawing.Point(715, 9);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(55, 55);
            btnClose.TabIndex = 16;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(12, 19);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(126, 34);
            label1.TabIndex = 1;
            label1.Text = "Usuarios";
            // 
            // tbTelefono
            // 
            tbTelefono.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            tbTelefono.Location = new System.Drawing.Point(110, 357);
            tbTelefono.Name = "tbTelefono";
            tbTelefono.Size = new System.Drawing.Size(601, 28);
            tbTelefono.TabIndex = 34;
            tbTelefono.KeyPress += numero_KeyPress;
            // 
            // tbMail
            // 
            tbMail.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            tbMail.Location = new System.Drawing.Point(110, 314);
            tbMail.Name = "tbMail";
            tbMail.Size = new System.Drawing.Size(601, 28);
            tbMail.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(26, 360);
            label6.Margin = new System.Windows.Forms.Padding(20);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(79, 19);
            label6.TabIndex = 38;
            label6.Text = "Teléfono";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label8.Location = new System.Drawing.Point(44, 317);
            label8.Margin = new System.Windows.Forms.Padding(20);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(61, 19);
            label8.TabIndex = 37;
            label8.Text = "e-Mail";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label9.Location = new System.Drawing.Point(1, 406);
            label9.Margin = new System.Windows.Forms.Padding(20);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(104, 19);
            label9.TabIndex = 41;
            label9.Text = "Nacimiento";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dateTimePicker.Location = new System.Drawing.Point(110, 402);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new System.Drawing.Size(250, 27);
            dateTimePicker.TabIndex = 35;
            // 
            // tbDni
            // 
            tbDni.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            tbDni.Location = new System.Drawing.Point(110, 130);
            tbDni.Name = "tbDni";
            tbDni.Size = new System.Drawing.Size(601, 28);
            tbDni.TabIndex = 29;
            tbDni.KeyPress += numero_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label10.Location = new System.Drawing.Point(66, 133);
            label10.Margin = new System.Windows.Forms.Padding(20);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(39, 19);
            label10.TabIndex = 43;
            label10.Text = "DNI";
            // 
            // tbDireccion
            // 
            tbDireccion.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            tbDireccion.Location = new System.Drawing.Point(110, 270);
            tbDireccion.Name = "tbDireccion";
            tbDireccion.Size = new System.Drawing.Size(601, 28);
            tbDireccion.TabIndex = 32;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label11.Location = new System.Drawing.Point(17, 273);
            label11.Margin = new System.Windows.Forms.Padding(20);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(88, 19);
            label11.TabIndex = 45;
            label11.Text = "Direccion";
            // 
            // ModuloUsuarios
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(764, 525);
            Controls.Add(tbDireccion);
            Controls.Add(label11);
            Controls.Add(tbDni);
            Controls.Add(label10);
            Controls.Add(dateTimePicker);
            Controls.Add(label9);
            Controls.Add(tbTelefono);
            Controls.Add(tbMail);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(cbRol);
            Controls.Add(btnActualizar);
            Controls.Add(lbId);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(tbClave);
            Controls.Add(tbNick);
            Controls.Add(tbApellido);
            Controls.Add(tbNombre);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "ModuloUsuarios";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "ModuloUsuarios";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cbRol;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox tbClave;
        private System.Windows.Forms.TextBox tbNick;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.Label label11;
    }
}