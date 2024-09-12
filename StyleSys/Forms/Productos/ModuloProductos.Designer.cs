namespace StyleSys.Forms.Productos
{
    partial class ModuloProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModuloProductos));
            panel1 = new System.Windows.Forms.Panel();
            btnClose = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            tbNombre = new System.Windows.Forms.TextBox();
            tbPrecioCompra = new System.Windows.Forms.TextBox();
            tbPrecioVenta = new System.Windows.Forms.TextBox();
            tbStock = new System.Windows.Forms.TextBox();
            lbCategoria = new System.Windows.Forms.ListBox();
            btnGuardar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            lbId = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.DodgerBlue;
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(782, 70);
            panel1.TabIndex = 0;
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
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(12, 19);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(149, 34);
            label1.TabIndex = 1;
            label1.Text = "Productos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(111, 109);
            label2.Margin = new System.Windows.Forms.Padding(20);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(76, 19);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(29, 152);
            label3.Margin = new System.Windows.Forms.Padding(20);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(158, 19);
            label3.TabIndex = 4;
            label3.Text = "Precio de compra";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(48, 200);
            label4.Margin = new System.Windows.Forms.Padding(20);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(139, 19);
            label4.TabIndex = 5;
            label4.Text = "Precio de venta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(67, 246);
            label5.Margin = new System.Windows.Forms.Padding(20);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(120, 19);
            label5.TabIndex = 6;
            label5.Text = "Stock mínimo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(97, 290);
            label6.Margin = new System.Windows.Forms.Padding(20);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(90, 19);
            label6.TabIndex = 7;
            label6.Text = "Categoria";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label7.Location = new System.Drawing.Point(93, 329);
            label7.Margin = new System.Windows.Forms.Padding(20);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(94, 19);
            label7.TabIndex = 8;
            label7.Text = "Proveedor";
            // 
            // tbNombre
            // 
            tbNombre.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            tbNombre.Location = new System.Drawing.Point(193, 104);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new System.Drawing.Size(523, 28);
            tbNombre.TabIndex = 9;
            // 
            // tbPrecioCompra
            // 
            tbPrecioCompra.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            tbPrecioCompra.Location = new System.Drawing.Point(193, 147);
            tbPrecioCompra.Name = "tbPrecioCompra";
            tbPrecioCompra.Size = new System.Drawing.Size(523, 28);
            tbPrecioCompra.TabIndex = 10;
            // 
            // tbPrecioVenta
            // 
            tbPrecioVenta.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            tbPrecioVenta.Location = new System.Drawing.Point(193, 195);
            tbPrecioVenta.Name = "tbPrecioVenta";
            tbPrecioVenta.Size = new System.Drawing.Size(523, 28);
            tbPrecioVenta.TabIndex = 11;
            // 
            // tbStock
            // 
            tbStock.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            tbStock.Location = new System.Drawing.Point(193, 241);
            tbStock.Name = "tbStock";
            tbStock.Size = new System.Drawing.Size(523, 28);
            tbStock.TabIndex = 12;
            // 
            // lbCategoria
            // 
            lbCategoria.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lbCategoria.FormattingEnabled = true;
            lbCategoria.ItemHeight = 19;
            lbCategoria.Location = new System.Drawing.Point(193, 290);
            lbCategoria.Name = "lbCategoria";
            lbCategoria.Size = new System.Drawing.Size(523, 23);
            lbCategoria.TabIndex = 13;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = System.Drawing.Color.DodgerBlue;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGuardar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = System.Drawing.Color.White;
            btnGuardar.Image = (System.Drawing.Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.Location = new System.Drawing.Point(454, 362);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(128, 47);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = System.Drawing.Color.DodgerBlue;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = System.Drawing.Color.White;
            btnCancelar.Image = (System.Drawing.Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.Location = new System.Drawing.Point(588, 362);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(128, 47);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new System.Drawing.Point(12, 409);
            lbId.Name = "lbId";
            lbId.Size = new System.Drawing.Size(41, 34);
            lbId.TabIndex = 16;
            lbId.Text = "Id";
            lbId.Visible = false;
            // 
            // ModuloProductos
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(782, 452);
            Controls.Add(lbId);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(lbCategoria);
            Controls.Add(tbStock);
            Controls.Add(tbPrecioVenta);
            Controls.Add(tbPrecioCompra);
            Controls.Add(tbNombre);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            Name = "ModuloProductos";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "ModuloProductos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbPrecioCompra;
        private System.Windows.Forms.TextBox tbPrecioVenta;
        private System.Windows.Forms.TextBox tbStock;
        private System.Windows.Forms.ListBox lbCategoria;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbId;
    }
}