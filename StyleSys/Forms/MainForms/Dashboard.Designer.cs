namespace StyleSys.Forms.MainForms
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new System.Windows.Forms.Panel();
            btnClose = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            burger = new System.Windows.Forms.PictureBox();
            panelPrincipal = new System.Windows.Forms.FlowLayoutPanel();
            panel2 = new System.Windows.Forms.Panel();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            btnProductos = new System.Windows.Forms.Button();
            panel4 = new System.Windows.Forms.Panel();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            btnProveedores = new System.Windows.Forms.Button();
            panel3 = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            btnUsuarios = new System.Windows.Forms.Button();
            panel5 = new System.Windows.Forms.Panel();
            panel6 = new System.Windows.Forms.Panel();
            pictureBox5 = new System.Windows.Forms.PictureBox();
            button1 = new System.Windows.Forms.Button();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            btnFacturas = new System.Windows.Forms.Button();
            panelMain = new System.Windows.Forms.Panel();
            panelTitulo = new System.Windows.Forms.Panel();
            lbTitulo = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)burger).BeginInit();
            panelPrincipal.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panelMain.SuspendLayout();
            panelTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.DodgerBlue;
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(burger);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1285, 45);
            panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnClose.Location = new System.Drawing.Point(1233, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(40, 40);
            btnClose.TabIndex = 2;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(49, 5);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(141, 34);
            label1.TabIndex = 1;
            label1.Text = " STYLESYS";
            // 
            // burger
            // 
            burger.Image = Properties.Resources.burgerbtn;
            burger.Location = new System.Drawing.Point(3, 2);
            burger.Name = "burger";
            burger.Size = new System.Drawing.Size(40, 40);
            burger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            burger.TabIndex = 0;
            burger.TabStop = false;
            // 
            // panelPrincipal
            // 
            panelPrincipal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            panelPrincipal.BackColor = System.Drawing.SystemColors.InactiveCaption;
            panelPrincipal.Controls.Add(panel2);
            panelPrincipal.Controls.Add(panel4);
            panelPrincipal.Controls.Add(panel3);
            panelPrincipal.Controls.Add(panel5);
            panelPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            panelPrincipal.Location = new System.Drawing.Point(0, 45);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new System.Drawing.Size(382, 611);
            panelPrincipal.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(btnProductos);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(379, 42);
            panel2.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.prodbtn;
            pictureBox2.Location = new System.Drawing.Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(35, 35);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // btnProductos
            // 
            btnProductos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            btnProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnProductos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnProductos.ForeColor = System.Drawing.Color.White;
            btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnProductos.Location = new System.Drawing.Point(0, 0);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new System.Drawing.Size(379, 42);
            btnProductos.TabIndex = 2;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += btnProductos_Click;
            // 
            // panel4
            // 
            panel4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(btnProveedores);
            panel4.Location = new System.Drawing.Point(3, 51);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(379, 42);
            panel4.TabIndex = 5;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(35, 35);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // btnProveedores
            // 
            btnProveedores.BackColor = System.Drawing.SystemColors.InactiveCaption;
            btnProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            btnProveedores.FlatAppearance.BorderSize = 0;
            btnProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnProveedores.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnProveedores.ForeColor = System.Drawing.Color.White;
            btnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnProveedores.Location = new System.Drawing.Point(0, 0);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new System.Drawing.Size(379, 42);
            btnProveedores.TabIndex = 2;
            btnProveedores.Text = "Proveedores";
            btnProveedores.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(btnUsuarios);
            panel3.Location = new System.Drawing.Point(3, 99);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(379, 42);
            panel3.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(35, 35);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = System.Drawing.SystemColors.InactiveCaption;
            btnUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUsuarios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnUsuarios.ForeColor = System.Drawing.Color.White;
            btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnUsuarios.Location = new System.Drawing.Point(0, 0);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new System.Drawing.Size(379, 42);
            btnUsuarios.TabIndex = 2;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(pictureBox4);
            panel5.Controls.Add(btnFacturas);
            panel5.Location = new System.Drawing.Point(3, 147);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(379, 42);
            panel5.TabIndex = 5;
            // 
            // panel6
            // 
            panel6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            panel6.Controls.Add(pictureBox5);
            panel6.Controls.Add(button1);
            panel6.Dock = System.Windows.Forms.DockStyle.Top;
            panel6.Location = new System.Drawing.Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new System.Drawing.Size(379, 42);
            panel6.TabIndex = 6;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (System.Drawing.Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new System.Drawing.Point(3, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new System.Drawing.Size(35, 35);
            pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            button1.Dock = System.Windows.Forms.DockStyle.Fill;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            button1.ForeColor = System.Drawing.Color.White;
            button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button1.Location = new System.Drawing.Point(0, 0);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(379, 42);
            button1.TabIndex = 2;
            button1.Text = "Facturas";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.prodbtn;
            pictureBox4.Location = new System.Drawing.Point(3, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(35, 35);
            pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // btnFacturas
            // 
            btnFacturas.BackColor = System.Drawing.SystemColors.InactiveCaption;
            btnFacturas.Dock = System.Windows.Forms.DockStyle.Fill;
            btnFacturas.FlatAppearance.BorderSize = 0;
            btnFacturas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnFacturas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFacturas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnFacturas.ForeColor = System.Drawing.Color.White;
            btnFacturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnFacturas.Location = new System.Drawing.Point(0, 0);
            btnFacturas.Name = "btnFacturas";
            btnFacturas.Size = new System.Drawing.Size(379, 42);
            btnFacturas.TabIndex = 2;
            btnFacturas.Text = "Facturas";
            btnFacturas.UseVisualStyleBackColor = false;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(panelTitulo);
            panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            panelMain.Location = new System.Drawing.Point(382, 45);
            panelMain.Name = "panelMain";
            panelMain.Size = new System.Drawing.Size(903, 611);
            panelMain.TabIndex = 4;
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            panelTitulo.Controls.Add(lbTitulo);
            panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            panelTitulo.Location = new System.Drawing.Point(0, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new System.Drawing.Size(903, 50);
            panelTitulo.TabIndex = 0;
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Location = new System.Drawing.Point(402, 8);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new System.Drawing.Size(84, 34);
            lbTitulo.TabIndex = 1;
            lbTitulo.Text = "Titulo";
            // 
            // Dashboard
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new System.Drawing.Size(1285, 656);
            Controls.Add(panelMain);
            Controls.Add(panelPrincipal);
            Controls.Add(panel1);
            Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(6);
            Name = "Dashboard";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Dashboard - StyleSys";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)burger).EndInit();
            panelPrincipal.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panelMain.ResumeLayout(false);
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox burger;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel panelPrincipal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnFacturas;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button button1;
    }
}

