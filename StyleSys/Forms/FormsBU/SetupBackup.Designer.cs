namespace StyleSys.Forms.Backup
{
    partial class SetupBackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetupBackup));
            panel1 = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            btnRutaBack = new System.Windows.Forms.Button();
            tbRutaBack = new System.Windows.Forms.TextBox();
            btnGuardar = new System.Windows.Forms.Button();
            folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            panel1.TabIndex = 2;
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
            label1.Size = new System.Drawing.Size(118, 34);
            label1.TabIndex = 2;
            label1.Text = "Backup";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(26, 29);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(562, 27);
            label2.TabIndex = 3;
            label2.Text = "Seleccione la carpeta donde guardar el backup:";
            // 
            // btnRutaBack
            // 
            btnRutaBack.BackColor = System.Drawing.Color.DodgerBlue;
            btnRutaBack.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnRutaBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRutaBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnRutaBack.ForeColor = System.Drawing.Color.White;
            btnRutaBack.Image = (System.Drawing.Image)resources.GetObject("btnRutaBack.Image");
            btnRutaBack.Location = new System.Drawing.Point(26, 114);
            btnRutaBack.Name = "btnRutaBack";
            btnRutaBack.Size = new System.Drawing.Size(126, 46);
            btnRutaBack.TabIndex = 4;
            btnRutaBack.Text = "BUSCAR";
            btnRutaBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnRutaBack.UseVisualStyleBackColor = false;
            btnRutaBack.Click += btnRutaBack_Click;
            // 
            // tbRutaBack
            // 
            tbRutaBack.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tbRutaBack.Location = new System.Drawing.Point(26, 68);
            tbRutaBack.Name = "tbRutaBack";
            tbRutaBack.ReadOnly = true;
            tbRutaBack.Size = new System.Drawing.Size(694, 31);
            tbRutaBack.TabIndex = 5;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = System.Drawing.Color.DodgerBlue;
            btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = System.Drawing.Color.White;
            btnGuardar.Image = (System.Drawing.Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.Location = new System.Drawing.Point(158, 114);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(126, 46);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // SetupBackup
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(982, 453);
            Controls.Add(btnGuardar);
            Controls.Add(tbRutaBack);
            Controls.Add(btnRutaBack);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "SetupBackup";
            Text = "Backup";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRutaBack;
        private System.Windows.Forms.TextBox tbRutaBack;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}