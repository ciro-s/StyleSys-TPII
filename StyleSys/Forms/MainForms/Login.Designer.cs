namespace StyleSys.Forms.MainForms
{
    partial class Login
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
            panel1 = new System.Windows.Forms.Panel();
            pbIcon = new System.Windows.Forms.PictureBox();
            btnCerrar = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            btnLogin = new System.Windows.Forms.Button();
            panel4 = new System.Windows.Forms.Panel();
            tbPassword = new System.Windows.Forms.TextBox();
            pbPassword = new System.Windows.Forms.PictureBox();
            panel3 = new System.Windows.Forms.Panel();
            tbUsuario = new System.Windows.Forms.TextBox();
            pbUser = new System.Windows.Forms.PictureBox();
            label2 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcon).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPassword).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbUser).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.DodgerBlue;
            panel1.Controls.Add(pbIcon);
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(432, 75);
            panel1.TabIndex = 0;
            // 
            // pbIcon
            // 
            pbIcon.Location = new System.Drawing.Point(2, 2);
            pbIcon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pbIcon.Name = "pbIcon";
            pbIcon.Size = new System.Drawing.Size(56, 70);
            pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pbIcon.TabIndex = 3;
            pbIcon.TabStop = false;
            // 
            // btnCerrar
            // 
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCerrar.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = System.Drawing.Color.White;
            btnCerrar.Location = new System.Drawing.Point(389, 9);
            btnCerrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new System.Drawing.Size(40, 50);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(64, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(302, 34);
            label1.TabIndex = 1;
            label1.Text = "Bienvenido - StyleSys";
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label2);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(0, 75);
            panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(432, 554);
            panel2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label4.ForeColor = System.Drawing.Color.DodgerBlue;
            label4.Location = new System.Drawing.Point(3, 500);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(120, 17);
            label4.TabIndex = 9;
            label4.Text = "Desarrollado por:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.DodgerBlue;
            label3.Location = new System.Drawing.Point(3, 521);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(223, 17);
            label3.TabIndex = 8;
            label3.Text = "Ciro Solalinde y Maximiliano Luna";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = System.Drawing.Color.DodgerBlue;
            btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogin.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnLogin.ForeColor = System.Drawing.Color.White;
            btnLogin.Location = new System.Drawing.Point(130, 325);
            btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(148, 44);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Ingresar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel4
            // 
            panel4.BackColor = System.Drawing.Color.White;
            panel4.Controls.Add(tbPassword);
            panel4.Controls.Add(pbPassword);
            panel4.Location = new System.Drawing.Point(0, 228);
            panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(432, 56);
            panel4.TabIndex = 6;
            // 
            // tbPassword
            // 
            tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            tbPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tbPassword.ForeColor = System.Drawing.Color.DodgerBlue;
            tbPassword.Location = new System.Drawing.Point(39, 10);
            tbPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new System.Drawing.Size(381, 25);
            tbPassword.TabIndex = 8;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // pbPassword
            // 
            pbPassword.Location = new System.Drawing.Point(3, 10);
            pbPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pbPassword.Name = "pbPassword";
            pbPassword.Size = new System.Drawing.Size(30, 38);
            pbPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pbPassword.TabIndex = 5;
            pbPassword.TabStop = false;
            pbPassword.MouseDown += pbPassword_MouseDown;
            pbPassword.MouseUp += pbPassword_MouseUp;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.White;
            panel3.Controls.Add(tbUsuario);
            panel3.Controls.Add(pbUser);
            panel3.Location = new System.Drawing.Point(0, 164);
            panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(432, 56);
            panel3.TabIndex = 5;
            // 
            // tbUsuario
            // 
            tbUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            tbUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tbUsuario.ForeColor = System.Drawing.Color.DodgerBlue;
            tbUsuario.Location = new System.Drawing.Point(39, 10);
            tbUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbUsuario.Name = "tbUsuario";
            tbUsuario.Size = new System.Drawing.Size(381, 25);
            tbUsuario.TabIndex = 7;
            // 
            // pbUser
            // 
            pbUser.Location = new System.Drawing.Point(3, 10);
            pbUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pbUser.Name = "pbUser";
            pbUser.Size = new System.Drawing.Size(30, 38);
            pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbUser.TabIndex = 4;
            pbUser.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.DodgerBlue;
            label2.Location = new System.Drawing.Point(107, 75);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(194, 34);
            label2.TabIndex = 4;
            label2.Text = "Iniciar Sesión";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(432, 629);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Login";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcon).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPassword).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.PictureBox pbPassword;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}