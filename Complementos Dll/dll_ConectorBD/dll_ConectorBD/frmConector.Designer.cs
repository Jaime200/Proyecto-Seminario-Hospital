namespace dll_ConectorBD
{
    partial class frmConector
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
            this.gbAdmin = new System.Windows.Forms.GroupBox();
            this.btnGuardarPass = new System.Windows.Forms.Button();
            this.txtPassAdminNueva = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPassAdmin = new System.Windows.Forms.Label();
            this.txtPassAdmin = new System.Windows.Forms.TextBox();
            this.btnGuardarConexion = new System.Windows.Forms.Button();
            this.gbBaseDatos = new System.Windows.Forms.GroupBox();
            this.btnOcultarBD = new System.Windows.Forms.Button();
            this.btnMostrarBD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBaseDatos = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.gbConexion = new System.Windows.Forms.GroupBox();
            this.txtServidor = new System.Windows.Forms.MaskedTextBox();
            this.btnOcultarConexion = new System.Windows.Forms.Button();
            this.btnMostrarConexion = new System.Windows.Forms.Button();
            this.rdbLocalhost = new System.Windows.Forms.RadioButton();
            this.rdbServer = new System.Windows.Forms.RadioButton();
            this.btnProbarConexion = new System.Windows.Forms.Button();
            this.txtLocalhost = new System.Windows.Forms.TextBox();
            this.gbAdmin.SuspendLayout();
            this.gbBaseDatos.SuspendLayout();
            this.gbConexion.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAdmin
            // 
            this.gbAdmin.Controls.Add(this.btnGuardarPass);
            this.gbAdmin.Controls.Add(this.txtPassAdminNueva);
            this.gbAdmin.Controls.Add(this.label4);
            this.gbAdmin.Controls.Add(this.lblPassAdmin);
            this.gbAdmin.Controls.Add(this.txtPassAdmin);
            this.gbAdmin.Location = new System.Drawing.Point(10, 11);
            this.gbAdmin.Name = "gbAdmin";
            this.gbAdmin.Size = new System.Drawing.Size(250, 122);
            this.gbAdmin.TabIndex = 22;
            this.gbAdmin.TabStop = false;
            this.gbAdmin.Text = "Administración";
            // 
            // btnGuardarPass
            // 
            this.btnGuardarPass.Location = new System.Drawing.Point(65, 91);
            this.btnGuardarPass.Name = "btnGuardarPass";
            this.btnGuardarPass.Size = new System.Drawing.Size(110, 25);
            this.btnGuardarPass.TabIndex = 18;
            this.btnGuardarPass.Text = "Guardar ";
            this.btnGuardarPass.UseVisualStyleBackColor = true;
            this.btnGuardarPass.Click += new System.EventHandler(this.btnGuardarPass_Click);
            // 
            // txtPassAdminNueva
            // 
            this.txtPassAdminNueva.Location = new System.Drawing.Point(123, 48);
            this.txtPassAdminNueva.Name = "txtPassAdminNueva";
            this.txtPassAdminNueva.PasswordChar = '*';
            this.txtPassAdminNueva.Size = new System.Drawing.Size(93, 20);
            this.txtPassAdminNueva.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password nueva:";
            // 
            // lblPassAdmin
            // 
            this.lblPassAdmin.AutoSize = true;
            this.lblPassAdmin.Location = new System.Drawing.Point(14, 25);
            this.lblPassAdmin.Name = "lblPassAdmin";
            this.lblPassAdmin.Size = new System.Drawing.Size(94, 13);
            this.lblPassAdmin.TabIndex = 8;
            this.lblPassAdmin.Text = "Password antigua:";
            // 
            // txtPassAdmin
            // 
            this.txtPassAdmin.Location = new System.Drawing.Point(123, 22);
            this.txtPassAdmin.Name = "txtPassAdmin";
            this.txtPassAdmin.PasswordChar = '*';
            this.txtPassAdmin.Size = new System.Drawing.Size(93, 20);
            this.txtPassAdmin.TabIndex = 7;
            // 
            // btnGuardarConexion
            // 
            this.btnGuardarConexion.Location = new System.Drawing.Point(139, 434);
            this.btnGuardarConexion.Name = "btnGuardarConexion";
            this.btnGuardarConexion.Size = new System.Drawing.Size(110, 25);
            this.btnGuardarConexion.TabIndex = 21;
            this.btnGuardarConexion.Text = "Guardar Conexión";
            this.btnGuardarConexion.UseVisualStyleBackColor = true;
            this.btnGuardarConexion.Click += new System.EventHandler(this.btnGuardarConexion_Click);
            // 
            // gbBaseDatos
            // 
            this.gbBaseDatos.Controls.Add(this.btnOcultarBD);
            this.gbBaseDatos.Controls.Add(this.btnMostrarBD);
            this.gbBaseDatos.Controls.Add(this.label1);
            this.gbBaseDatos.Controls.Add(this.txtBaseDatos);
            this.gbBaseDatos.Controls.Add(this.txtPass);
            this.gbBaseDatos.Controls.Add(this.label2);
            this.gbBaseDatos.Controls.Add(this.label3);
            this.gbBaseDatos.Controls.Add(this.txtUser);
            this.gbBaseDatos.Location = new System.Drawing.Point(10, 272);
            this.gbBaseDatos.Name = "gbBaseDatos";
            this.gbBaseDatos.Size = new System.Drawing.Size(250, 156);
            this.gbBaseDatos.TabIndex = 20;
            this.gbBaseDatos.TabStop = false;
            this.gbBaseDatos.Text = "Datos de Base de Datos";
            // 
            // btnOcultarBD
            // 
            this.btnOcultarBD.Location = new System.Drawing.Point(129, 125);
            this.btnOcultarBD.Name = "btnOcultarBD";
            this.btnOcultarBD.Size = new System.Drawing.Size(110, 25);
            this.btnOcultarBD.TabIndex = 18;
            this.btnOcultarBD.Text = "Ocultar";
            this.btnOcultarBD.UseVisualStyleBackColor = true;
            this.btnOcultarBD.Click += new System.EventHandler(this.btnOcultarBD_Click);
            // 
            // btnMostrarBD
            // 
            this.btnMostrarBD.Location = new System.Drawing.Point(13, 125);
            this.btnMostrarBD.Name = "btnMostrarBD";
            this.btnMostrarBD.Size = new System.Drawing.Size(110, 25);
            this.btnMostrarBD.TabIndex = 15;
            this.btnMostrarBD.Text = "Mostrar";
            this.btnMostrarBD.UseVisualStyleBackColor = true;
            this.btnMostrarBD.Click += new System.EventHandler(this.btnMostrarBD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Base de Datos:";
            // 
            // txtBaseDatos
            // 
            this.txtBaseDatos.Location = new System.Drawing.Point(123, 22);
            this.txtBaseDatos.Name = "txtBaseDatos";
            this.txtBaseDatos.PasswordChar = '*';
            this.txtBaseDatos.Size = new System.Drawing.Size(93, 20);
            this.txtBaseDatos.TabIndex = 5;
            this.txtBaseDatos.Text = "HospitalBD";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(123, 77);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(93, 20);
            this.txtPass.TabIndex = 10;
            this.txtPass.Text = "1234";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "User:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(123, 51);
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '*';
            this.txtUser.Size = new System.Drawing.Size(93, 20);
            this.txtUser.TabIndex = 8;
            this.txtUser.Text = "1234";
            // 
            // gbConexion
            // 
            this.gbConexion.Controls.Add(this.txtLocalhost);
            this.gbConexion.Controls.Add(this.txtServidor);
            this.gbConexion.Controls.Add(this.btnOcultarConexion);
            this.gbConexion.Controls.Add(this.btnMostrarConexion);
            this.gbConexion.Controls.Add(this.rdbLocalhost);
            this.gbConexion.Controls.Add(this.rdbServer);
            this.gbConexion.Location = new System.Drawing.Point(10, 139);
            this.gbConexion.Name = "gbConexion";
            this.gbConexion.Size = new System.Drawing.Size(250, 127);
            this.gbConexion.TabIndex = 19;
            this.gbConexion.TabStop = false;
            this.gbConexion.Text = "Conexión";
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(129, 47);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.PasswordChar = '*';
            this.txtServidor.Size = new System.Drawing.Size(93, 20);
            this.txtServidor.TabIndex = 19;
            // 
            // btnOcultarConexion
            // 
            this.btnOcultarConexion.Location = new System.Drawing.Point(129, 82);
            this.btnOcultarConexion.Name = "btnOcultarConexion";
            this.btnOcultarConexion.Size = new System.Drawing.Size(110, 25);
            this.btnOcultarConexion.TabIndex = 17;
            this.btnOcultarConexion.Text = "Ocultar";
            this.btnOcultarConexion.UseVisualStyleBackColor = true;
            this.btnOcultarConexion.Click += new System.EventHandler(this.btnOcultarConexion_Click);
            // 
            // btnMostrarConexion
            // 
            this.btnMostrarConexion.Location = new System.Drawing.Point(17, 82);
            this.btnMostrarConexion.Name = "btnMostrarConexion";
            this.btnMostrarConexion.Size = new System.Drawing.Size(110, 25);
            this.btnMostrarConexion.TabIndex = 16;
            this.btnMostrarConexion.Text = "Mostrar";
            this.btnMostrarConexion.UseVisualStyleBackColor = true;
            this.btnMostrarConexion.Click += new System.EventHandler(this.btnMostrarConexion_Click);
            // 
            // rdbLocalhost
            // 
            this.rdbLocalhost.AutoSize = true;
            this.rdbLocalhost.Checked = true;
            this.rdbLocalhost.Location = new System.Drawing.Point(17, 19);
            this.rdbLocalhost.Name = "rdbLocalhost";
            this.rdbLocalhost.Size = new System.Drawing.Size(74, 17);
            this.rdbLocalhost.TabIndex = 11;
            this.rdbLocalhost.TabStop = true;
            this.rdbLocalhost.Text = "Localhost:";
            this.rdbLocalhost.UseVisualStyleBackColor = true;
            // 
            // rdbServer
            // 
            this.rdbServer.AutoSize = true;
            this.rdbServer.Location = new System.Drawing.Point(17, 50);
            this.rdbServer.Name = "rdbServer";
            this.rdbServer.Size = new System.Drawing.Size(67, 17);
            this.rdbServer.TabIndex = 12;
            this.rdbServer.TabStop = true;
            this.rdbServer.Text = "Servidor:";
            this.rdbServer.UseVisualStyleBackColor = true;
            // 
            // btnProbarConexion
            // 
            this.btnProbarConexion.Location = new System.Drawing.Point(23, 434);
            this.btnProbarConexion.Name = "btnProbarConexion";
            this.btnProbarConexion.Size = new System.Drawing.Size(110, 25);
            this.btnProbarConexion.TabIndex = 18;
            this.btnProbarConexion.Text = "Probar Conexión";
            this.btnProbarConexion.UseVisualStyleBackColor = true;
            this.btnProbarConexion.Click += new System.EventHandler(this.btnProbarConexion_Click);
            // 
            // txtLocalhost
            // 
            this.txtLocalhost.Location = new System.Drawing.Point(129, 21);
            this.txtLocalhost.Name = "txtLocalhost";
            this.txtLocalhost.PasswordChar = '*';
            this.txtLocalhost.Size = new System.Drawing.Size(93, 20);
            this.txtLocalhost.TabIndex = 19;
            // 
            // frmConector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 470);
            this.Controls.Add(this.gbAdmin);
            this.Controls.Add(this.btnGuardarConexion);
            this.Controls.Add(this.gbBaseDatos);
            this.Controls.Add(this.gbConexion);
            this.Controls.Add(this.btnProbarConexion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmConector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conector MySQL";
            this.Load += new System.EventHandler(this.frmConector_Load);
            this.gbAdmin.ResumeLayout(false);
            this.gbAdmin.PerformLayout();
            this.gbBaseDatos.ResumeLayout(false);
            this.gbBaseDatos.PerformLayout();
            this.gbConexion.ResumeLayout(false);
            this.gbConexion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAdmin;
        private System.Windows.Forms.Button btnGuardarPass;
        private System.Windows.Forms.TextBox txtPassAdminNueva;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPassAdmin;
        private System.Windows.Forms.TextBox txtPassAdmin;
        private System.Windows.Forms.Button btnGuardarConexion;
        private System.Windows.Forms.GroupBox gbBaseDatos;
        private System.Windows.Forms.Button btnOcultarBD;
        private System.Windows.Forms.Button btnMostrarBD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBaseDatos;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.GroupBox gbConexion;
        private System.Windows.Forms.Button btnOcultarConexion;
        private System.Windows.Forms.Button btnMostrarConexion;
        private System.Windows.Forms.RadioButton rdbLocalhost;
        private System.Windows.Forms.RadioButton rdbServer;
        private System.Windows.Forms.Button btnProbarConexion;
        private System.Windows.Forms.MaskedTextBox txtServidor;
        private System.Windows.Forms.TextBox txtLocalhost;
    }
}